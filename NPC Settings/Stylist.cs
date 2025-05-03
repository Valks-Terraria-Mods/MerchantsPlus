namespace MerchantsPlus.NPCs;

public class Stylist : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.Stylist)
        {
            return;
        }

        base.GetChat(npc, ref chat);

        chat = Utils.Dialog(["Defeat 50 enemies of any type and I'll sell you the banner for that enemy."]);
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.Stylist)
        {
            return;
        }

        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);

        projType = true switch
        {
            _ when Progression.DownedMechs(1) => ProjectileID.BoneJavelin,
            _ when NPC.downedBoss2 => ProjectileID.PoisonedKnife,
            _ => ProjectileID.ThrowingKnife
        };
    }
}