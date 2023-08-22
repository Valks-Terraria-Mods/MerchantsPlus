namespace MerchantsPlus.NPCs;

internal class Stylist : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.Stylist) return;
        base.GetChat(npc, ref chat);

        chat = Utils.Dialog(new string[] { "Defeat 50 enemies of any type and I'll sell you the banner for that enemy." });
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.Stylist) return;
        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);
        projType = ProjectileID.ThrowingKnife;
        if (NPC.downedBoss2)
        {
            projType = ProjectileID.PoisonedKnife;
        }
        if (Utils.DownedMechBosses() == 1)
        {
            projType = ProjectileID.BoneJavelin;
        }
    }
}