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

        List<string> dialog = [];
        QuestUtils.QuestKills(dialog, "Zombie", WorldUtils.Kills(NPCID.Zombie), 100);
        QuestUtils.QuestKills(dialog, "Jellyfish", WorldUtils.MultiKills([NPCID.BlueJellyfish, NPCID.PinkJellyfish, NPCID.GreenJellyfish]), 100);
        QuestUtils.QuestKills(dialog, "Skeleton", WorldUtils.MultiKills([NPCID.ArmoredSkeleton, NPCID.BlueArmoredBones]), 1);
        
        if (Progression.Skeletron)
        {
            QuestUtils.QuestKills(dialog, "Cursed Skull", WorldUtils.Kills(NPCID.CursedSkull), 1);
        }

        if (Progression.Hardmode)
        {
            QuestUtils.QuestKills(dialog, "Corruptor", WorldUtils.Kills(NPCID.Corruptor), 1);
            QuestUtils.QuestKills(dialog, "Light Mummy", WorldUtils.Kills(NPCID.LightMummy), 1);
            QuestUtils.QuestKills(dialog, "Medusa", WorldUtils.Kills(NPCID.Medusa), 1);
            QuestUtils.QuestKills(dialog, "Mimic", WorldUtils.Kills(NPCID.Mimic), 2);
            QuestUtils.QuestKills(dialog, "Pixies", WorldUtils.MultiKills([NPCID.Pixie]), 10);
            QuestUtils.QuestKills(dialog, "Corrupt Slime", WorldUtils.Kills(NPCID.CorruptSlime), 1);
            QuestUtils.QuestKills(dialog, "Toxic Sludge", WorldUtils.Kills(NPCID.ToxicSludge), 1);
            QuestUtils.QuestKills(dialog, "Werewolf", WorldUtils.MultiKills([NPCID.RustyArmoredBonesAxe, NPCID.Werewolf, NPCID.AnglerFish]), 1);
            QuestUtils.QuestKills(dialog, "Ice Tortoise", WorldUtils.Kills(NPCID.IceTortoise), 1);
            QuestUtils.QuestKills(dialog, "Big Mimic Crimson", WorldUtils.Kills(NPCID.BigMimicCrimson), 1);
        }

        if (dialog.Count > 0)
        {
            chat = QuestUtils.Dialog(dialog.ToArray());
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
            _ when Progression.DownedMechs(1) => ProjectileID.BoneJavelin,
            _ when NPC.downedBoss2 => ProjectileID.PoisonedKnife,
            _ => ProjectileID.ThrowingKnife
        };
    }

}