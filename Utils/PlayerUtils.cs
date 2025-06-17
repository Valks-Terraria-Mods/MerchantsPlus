namespace MerchantsPlus;

public static class PlayerUtils
{
    public static bool TalkingToNpc() => Main.LocalPlayer.talkNPC >= 0;

    public static PlayerClass GetPlayerClass()
    {
        Player p = Main.LocalPlayer;

        if (p.HeldItem == null || p.HeldItem.damage <= 0) 
            return PlayerClass.Melee;
        
        Item heldItem = p.HeldItem;

        if (heldItem.CountsAsClass(DamageClass.Melee))
        {
            return PlayerClass.Melee;
        }

        if (heldItem.CountsAsClass(DamageClass.Ranged))
        {
            return PlayerClass.Ranger;
        }

        if (heldItem.CountsAsClass(DamageClass.Magic))
        {
            return PlayerClass.Mage;
        }

        if (heldItem.CountsAsClass(DamageClass.Summon))
        {
            return PlayerClass.Summoner;
        }

        if (heldItem.CountsAsClass(DamageClass.Throwing))
        {
            return PlayerClass.Thrower;
        }

        return PlayerClass.Melee;
    }
}