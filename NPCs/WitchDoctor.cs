using MerchantsPlus.UI;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus.NPCs
{
    class WitchDoctor : ModNPC
    {
        static string[] shopNames = { "Gear", "Flasks" };
        static int shopCounter = 0;
        static string currentShop = shopNames[shopCounter];
        static short npcid = NPCID.WitchDoctor;

        public override string Texture
        {
            get
            {
                return "Terraria/NPC_" + npcid;
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Doctor";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            //Main.npcFrameCount[npc.type] = Main.npcFrameCount[npcid];
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[npcid];
            NPCID.Sets.ExtraFramesCount[npc.type] = NPCID.Sets.ExtraFramesCount[npcid];
            NPCID.Sets.AttackFrameCount[npc.type] = NPCID.Sets.AttackFrameCount[npcid];
            NPCID.Sets.DangerDetectRange[npc.type] = NPCID.Sets.DangerDetectRange[npcid];
            NPCID.Sets.AttackType[npc.type] = NPCID.Sets.AttackType[npcid];
            NPCID.Sets.AttackTime[npc.type] = NPCID.Sets.AttackTime[npcid];
            NPCID.Sets.AttackAverageChance[npc.type] = NPCID.Sets.AttackAverageChance[npcid];
            NPCID.Sets.HatOffsetY[npc.type] = NPCID.Sets.HatOffsetY[npcid];
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 300;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = npcid;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            return true;
        }


        public override string TownNPCName()
        {
            return "Zyan";
        }

        public override string GetChat()
        {
            return Utils.dialog(new string[] { "Be careful, this imbuing station needs tending to..",
                "A flask a day keeps the Witch Doctor away."});
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            if (!ExampleUI.Visible) {
                ExampleUI.Visible = true;
                Main.NewText("test");
                ExampleUI.talkingTo = NPCID.WitchDoctor;
                MerchantsPlus.instance.examplePersonUserInterface.SetState(new ExampleUI());
                switch (ExampleUI.talkingTo)
                {
                    case NPCID.Angler:
                        ExampleUI.the_shop = ExampleUI.ANGLER;
                        break;
                    case NPCID.ArmsDealer:
                        ExampleUI.the_shop = ExampleUI.ARMSDEALER;
                        break;
                    case NPCID.Clothier:
                        ExampleUI.the_shop = ExampleUI.CLOTHIER;
                        break;
                    case NPCID.Cyborg:
                        ExampleUI.the_shop = ExampleUI.CYBORG;
                        break;
                    case NPCID.Demolitionist:
                        ExampleUI.the_shop = ExampleUI.DEMOLITIONIST;
                        break;
                    case NPCID.Dryad:
                        ExampleUI.the_shop = ExampleUI.DRYAD;
                        break;
                    case NPCID.DyeTrader:
                        ExampleUI.the_shop = ExampleUI.DYETRADER;
                        break;
                    case NPCID.GoblinTinkerer:
                        ExampleUI.the_shop = ExampleUI.GOBLINTINKERER;
                        break;
                    case NPCID.Guide:
                        ExampleUI.the_shop = ExampleUI.GUIDE;
                        break;
                    case NPCID.Mechanic:
                        ExampleUI.the_shop = ExampleUI.MECHANIC;
                        break;
                    case NPCID.Merchant:
                        ExampleUI.the_shop = ExampleUI.MERCHANT;
                        break;
                    case NPCID.Nurse:
                        ExampleUI.the_shop = ExampleUI.NURSE;
                        break;
                    case NPCID.Painter:
                        ExampleUI.the_shop = ExampleUI.PAINTER;
                        break;
                    case NPCID.PartyGirl:
                        ExampleUI.the_shop = ExampleUI.PARTYGIRL;
                        break;
                    case NPCID.Pirate:
                        ExampleUI.the_shop = ExampleUI.PIRATE;
                        break;
                    case NPCID.SantaClaus:
                        ExampleUI.the_shop = ExampleUI.SANTACLAUS;
                        break;
                    case NPCID.SkeletonMerchant:
                        ExampleUI.the_shop = ExampleUI.SKELETONMERCHANT;
                        break;
                    case NPCID.Steampunker:
                        ExampleUI.the_shop = ExampleUI.STEAMPUNKER;
                        break;
                    case NPCID.Stylist:
                        ExampleUI.the_shop = ExampleUI.STYLIST;
                        break;
                    case NPCID.DD2Bartender:
                        ExampleUI.the_shop = ExampleUI.TAVERNKEEP;
                        break;
                    case NPCID.TaxCollector:
                        ExampleUI.the_shop = ExampleUI.TAXCOLLECTOR;
                        break;
                    case NPCID.Truffle:
                        ExampleUI.the_shop = ExampleUI.TRUFFLE;
                        break;
                    case NPCID.WitchDoctor:
                        ExampleUI.the_shop = ExampleUI.WITCHDOCTOR;
                        break;
                    case NPCID.Wizard:
                        ExampleUI.the_shop = ExampleUI.WIZARD;
                        break;
                }
            }
            
            //ExampleUI.Visible = true;
            
            button = currentShop;
            button2 = "Cycle Shop";
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;
                //ExampleUI.Visible = false;
                MerchantsPlus.instance.examplePersonUserInterface.IsVisible = false;

            }
            else
            {
                if (shopCounter >= shopNames.Length - 1)
                {
                    currentShop = shopNames[0];
                    shopCounter = 0;
                }
                else
                {
                    currentShop = shopNames[++shopCounter];
                }
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            switch (currentShop) {
                case "Flasks":
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofCursedFlames);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofFire);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofGold);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofIchor);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofNanites);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofParty);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofPoison);
                    shop.item[nextSlot++].SetDefaults(ItemID.FlaskofVenom);
                    break;
                default:
                    shop.item[nextSlot++].SetDefaults(ItemID.HerculesBeetle);
                    shop.item[nextSlot++].SetDefaults(ItemID.NecromanticScroll);
                    shop.item[nextSlot++].SetDefaults(ItemID.PygmyNecklace);
                    break;
            }
        }

        public override void NPCLoot()
        {
            // Item.NewItem(npc.getRect(), ItemID.SlimeBanner);
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            attackDelay = 1;
            projType = ProjectileID.ThrowingKnife;
            if (NPC.downedBoss2)
            {
                projType = ProjectileID.PoisonedKnife;
            }
            if (Utils.downedMechBosses() == 1)
            {
                projType = ProjectileID.BoneJavelin;
            }
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 20;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 0;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}
