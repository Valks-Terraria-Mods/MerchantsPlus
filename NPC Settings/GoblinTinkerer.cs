namespace MerchantsPlus.NPCs;

public class GoblinTinkerer : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.GoblinTinkerer)
        {
            return;
        }

        base.GetChat(npc, ref chat);

        List<string> dialog = new List<string>();
        Utils.QuestKills(dialog, "Zombie", Utils.Kills(NPCID.Zombie), 100);
        Utils.QuestKills(dialog, "Jellyfish", Utils.MultiKills([NPCID.BlueJellyfish, NPCID.PinkJellyfish, NPCID.GreenJellyfish]), 100);
        Utils.QuestKills(dialog, "Skeleton", Utils.MultiKills([NPCID.ArmoredSkeleton, NPCID.BlueArmoredBones]), 1);
        
        if (Utils.DownedSkeletron())
        {
            Utils.QuestKills(dialog, "Cursed Skull", Utils.Kills(NPCID.CursedSkull), 1);
        }

        if (Utils.IsHardMode())
        {
            Utils.QuestKills(dialog, "Corruptor", Utils.Kills(NPCID.Corruptor), 1);
            Utils.QuestKills(dialog, "Light Mummy", Utils.Kills(NPCID.LightMummy), 1);
            Utils.QuestKills(dialog, "Medusa", Utils.Kills(NPCID.Medusa), 1);
            Utils.QuestKills(dialog, "Mimic", Utils.Kills(NPCID.Mimic), 2);
            Utils.QuestKills(dialog, "Pixies", Utils.MultiKills([NPCID.Pixie]), 10);
            Utils.QuestKills(dialog, "Corrupt Slime", Utils.Kills(NPCID.CorruptSlime), 1);
            Utils.QuestKills(dialog, "Toxic Sludge", Utils.Kills(NPCID.ToxicSludge), 1);
            Utils.QuestKills(dialog, "Werewolf", Utils.MultiKills([NPCID.RustyArmoredBonesAxe, NPCID.Werewolf, NPCID.AnglerFish]), 1);
            Utils.QuestKills(dialog, "Ice Tortoise", Utils.Kills(NPCID.IceTortoise), 1);
            Utils.QuestKills(dialog, "Big Mimic Crimson", Utils.Kills(NPCID.BigMimicCrimson), 1);
        }

        if (dialog.Count > 0)
        {
            chat = Utils.Dialog(dialog.ToArray());
        }
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.GoblinTinkerer)
        {
            return;
        }

        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);

        projType = true switch
        {
            _ when Utils.DownedMechBosses() == 1 => ProjectileID.BoneJavelin,
            _ when NPC.downedBoss2 => ProjectileID.PoisonedKnife,
            _ => ProjectileID.ThrowingKnife
        };
    }

}