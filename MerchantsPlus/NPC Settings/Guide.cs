namespace MerchantsPlus.NPCs;

public class Guide : BaseMerchant
{
    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type != NPCID.Guide)
        {
            return;
        }

        base.GetChat(npc, ref chat);
    }

    public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
    {
        if (npc.type != NPCID.Guide)
        {
            return;
        }

        base.TownNPCAttackProj(npc, ref projType, ref attackDelay);

        projType = true switch
        {
            _ when NPC.downedMoonlord => ProjectileID.MoonlordArrow,
            _ when NPC.downedPlantBoss => ProjectileID.ChlorophyteArrow,
            _ when Progression.DownedMechs(3) => ProjectileID.VenomArrow,
            _ when Progression.DownedMechs(2) => ProjectileID.CursedArrow,
            _ when Progression.DownedMechs(1) => ProjectileID.HolyArrow,
            _ when Main.hardMode => ProjectileID.UnholyArrow,
            _ when NPC.downedBoss2 => ProjectileID.JestersArrow,
            _ when NPC.downedSlimeKing => ProjectileID.FrostburnArrow,
            _ => ProjectileID.WoodenArrowFriendly
        };
    }
}
