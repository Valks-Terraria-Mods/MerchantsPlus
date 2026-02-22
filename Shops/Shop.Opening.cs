using Terraria.Audio;

namespace MerchantsPlus.Shops;

public abstract partial class Shop
{
    /// <summary>
    /// Initializes the custom shop inventory for the current NPC interaction.
    /// </summary>
    /// <param name="shop">The selected shop tab name.</param>
    public virtual void OpenShop(string shop)
    {
        bool suppressSound = IsOpenSoundSuppressed();
        bool soundPlayed = !suppressSound;

        if (soundPlayed)
        {
            SoundEngine.PlaySound(SoundID.MenuTick);
        }

        ShopOpenDiagnostics.RecordAttempt(
            _openSourceTag,
            GetDiagnosticsMerchantType(),
            shop,
            suppressSound,
            soundPlayed);

        Main.playerInventory = true;
        Main.npcChatText = "";
        EnsureForcedTalkNpcAssigned();

        // Not sure what this line of code does
        // Note that any number greater than 1 will cause index out of bounds error
        // freezing the game
        // If this line of code is commented out then an error will appear saying
        // "Object reference not set to an instance of an object"
        if (Main.npcShop != 1)
        {
            Main.SetNPCShopIndex(1);
        }

        NPC npc = GetShopContextNpc();

        // For future reference this code was updated from
        // https://github.com/tModLoader/tModLoader/blob/e6caaaf678efd2a69deece4d72fdaecc4391bd26/patches/tModLoader/Terraria/ModLoader/NPCLoader.cs#L1192
        Inv = Main.instance.shop[Main.npcShop];

        // Setting this to '2' will set up the shop items for the arms dealer
        // The arms dealer sells 3 guns
        Inv.SetupShop(NPCShopDatabase.GetShopNameFromVanillaIndex(2), npc);

        // Let's remove these guns as we will add our own items later
        foreach (Item item in Inv.item)
        {
            item.SetDefaults(ItemID.None);
        }

        NextSlot = 0;
    }

    /// <summary>
    /// Opens a shop tab using the provided NPC type as context when no NPC is being talked to.
    /// </summary>
    /// <param name="shop">The selected shop tab name.</param>
    /// <param name="npcType">The NPC type to use as the shop context.</param>
    public void OpenShopForNpcType(string shop, int npcType, bool suppressSound = false, string sourceTag = "default")
    {
        int previousNpcType = _forcedContextNpcType;
        int previousNpcIndex = _forcedContextNpcIndex;
        string previousSourceTag = _openSourceTag;
        _forcedContextNpcType = npcType;
        _forcedContextNpcIndex = FindFallbackTalkNpcIndex(npcType);
        _openSourceTag = string.IsNullOrWhiteSpace(sourceTag) ? "default" : sourceTag;
        if (suppressSound)
        {
            _suppressOpenSoundDepth++;
        }

        try
        {
            if (_forcedContextNpcIndex >= 0 && Main.LocalPlayer is not null)
            {
                // One-time context assignment for explicit/snapshot open calls.
                // Per-frame keepalive logic should avoid SetTalkNPC to prevent repeated side effects.
                Main.LocalPlayer.SetTalkNPC(_forcedContextNpcIndex, fromNet: true);
            }

            OpenShop(shop);
        }
        finally
        {
            _forcedContextNpcType = previousNpcType;
            _forcedContextNpcIndex = previousNpcIndex;
            if (suppressSound && _suppressOpenSoundDepth > 0)
            {
                _suppressOpenSoundDepth--;
            }

            _openSourceTag = previousSourceTag;
        }
    }

    private static bool IsOpenSoundSuppressed()
    {
        return _suppressOpenSoundDepth > 0;
    }

    private static int GetDiagnosticsMerchantType()
    {
        if (_forcedContextNpcType > NPCID.None)
        {
            return _forcedContextNpcType;
        }

        NPC talkNpc = Main.LocalPlayer?.TalkNPC;
        if (talkNpc is not null && talkNpc.active && talkNpc.type > NPCID.None)
        {
            return talkNpc.type;
        }

        return ShopUI.CurrentMerchantId > NPCID.None ? ShopUI.CurrentMerchantId : NPCID.None;
    }

    private static NPC GetShopContextNpc()
    {
        if (_forcedContextNpcType > NPCID.None)
        {
            if (_forcedContextNpcIndex >= 0
                && (uint)_forcedContextNpcIndex < (uint)Main.npc.Length
                && Main.npc[_forcedContextNpcIndex].active
                && Main.npc[_forcedContextNpcIndex].type == _forcedContextNpcType)
            {
                return Main.npc[_forcedContextNpcIndex];
            }

            NPC forcedTypeNpc = Array.Find(Main.npc, npc => npc.active && npc.type == _forcedContextNpcType);
            if (forcedTypeNpc is not null)
            {
                return forcedTypeNpc;
            }

            NPC forcedContext = new();
            forcedContext.SetDefaults(_forcedContextNpcType);
            return forcedContext;
        }

        NPC talkNpc = Main.LocalPlayer?.TalkNPC;
        if (talkNpc is not null && talkNpc.active && talkNpc.type > NPCID.None)
        {
            return talkNpc;
        }

        NPC activeNpc = Array.Find(Main.npc, npc => npc.active && npc.type == NPCID.Merchant);
        if (activeNpc is not null)
        {
            return activeNpc;
        }

        NPC npcContext = new();
        npcContext.SetDefaults(NPCID.Merchant);
        return npcContext;
    }

    private static void EnsureForcedTalkNpcAssigned()
    {
        if (_forcedContextNpcIndex < 0 && _forcedContextNpcType <= NPCID.None)
        {
            return;
        }

        if (_forcedContextNpcIndex < 0 || _forcedContextNpcIndex >= Main.maxNPCs || !Main.npc[_forcedContextNpcIndex].active)
        {
            _forcedContextNpcIndex = FindFallbackTalkNpcIndex(_forcedContextNpcType);
        }

        if (_forcedContextNpcIndex >= 0 && Main.LocalPlayer is not null)
        {
            Main.LocalPlayer.SetTalkNPC(_forcedContextNpcIndex, fromNet: true);
        }
    }

    private static int FindFallbackTalkNpcIndex(int preferredNpcType)
    {
        // IMPORTANT:
        // Talk anchors must be chat-capable town NPCs.
        // Using arbitrary active NPCs (enemies/critters/etc.) causes vanilla to drop talkNPC immediately,
        // which in turn closes shop context and creates recovery loops.

        if (preferredNpcType > NPCID.None)
        {
            int preferredTownNpc = Array.FindIndex(Main.npc, npc =>
                npc.active
                && npc.townNPC
                && npc.type == preferredNpcType);
            if (preferredTownNpc >= 0)
            {
                return preferredTownNpc;
            }
        }

        if (Main.LocalPlayer is not null)
        {
            Vector2 playerCenter = Main.LocalPlayer.Center;

            int nearbyTownNpc = FindNearestTalkableTownNpc(playerCenter, 480f);
            if (nearbyTownNpc >= 0)
            {
                return nearbyTownNpc;
            }
        }

        int townNpc = Array.FindIndex(Main.npc, npc => npc.active && npc.townNPC);
        if (townNpc >= 0)
        {
            return townNpc;
        }

        return -1;
    }

    private static int FindNearestTalkableTownNpc(Vector2 center, float maxDistance)
    {
        float maxDistanceSquared = maxDistance * maxDistance;
        int bestIndex = -1;
        float bestDistanceSquared = maxDistanceSquared;

        for (int i = 0; i < Main.npc.Length; i++)
        {
            NPC npc = Main.npc[i];
            if (!npc.active || !npc.townNPC)
            {
                continue;
            }

            float distSq = Vector2.DistanceSquared(center, npc.Center);
            if (distSq <= bestDistanceSquared)
            {
                bestDistanceSquared = distSq;
                bestIndex = i;
            }
        }

        return bestIndex;
    }

}
