using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MerchantsPlus
{
	class MerchantsPlus : Mod
	{
		public MerchantsPlus()
		{
            
		}

        public override void Load()
        {
            Config.Load();

            ModTranslation text;
            text = CreateTranslation("Guide");
            text.SetDefault("The Squire has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Merchant");
            text.SetDefault("The Supplier has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Nurse");
            text.SetDefault("The Healer has arrived!");
            AddTranslation(text);

            text = CreateTranslation("ArmsDealer");
            text.SetDefault("The Guns Dealer has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Dyrad");
            text.SetDefault("The Outcast has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Demolitionist");
            text.SetDefault("The Explosives Expert has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Clothier");
            text.SetDefault("The Outfitter has arrived!");
            AddTranslation(text);

            text = CreateTranslation("DyeTrader");
            text.SetDefault("The Magicican has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Tavernkeep");
            text.SetDefault("The Bartender has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Stylist");
            text.SetDefault("The Hair Specialist has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Painter");
            text.SetDefault("The Artist has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Angler");
            text.SetDefault("The Fisherman has arrived!");
            AddTranslation(text);

            text = CreateTranslation("GoblinTinkerer");
            text.SetDefault("The Reforger has arrived!");
            AddTranslation(text);

            text = CreateTranslation("WitchDoctor");
            text.SetDefault("The Doctor has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Mechanic");
            text.SetDefault("The Manufacturer has arrived!");
            AddTranslation(text);

            text = CreateTranslation("PartyGirl");
            text.SetDefault("The Decorator has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Wizard");
            text.SetDefault("The Apprentice has arrived!");
            AddTranslation(text);

            text = CreateTranslation("TaxCollector");
            text.SetDefault("The Business Man has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Truffle");
            text.SetDefault("The Mushroom has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Pirate");
            text.SetDefault("The Bandit has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Steampunker");
            text.SetDefault("The Steampunk has arrived!");
            AddTranslation(text);

            text = CreateTranslation("Cyborg");
            text.SetDefault("The Robot has arrived!");
            AddTranslation(text);

            text = CreateTranslation("SantaClaus");
            text.SetDefault("The Santa has arrived!");
            AddTranslation(text);

            text = CreateTranslation("TravellingMerchant");
            text.SetDefault("The World Merchant has arrived!");
            AddTranslation(text);

            text = CreateTranslation("SkeletonMerchant");
            text.SetDefault("The Skeleton Dealer has arrived!");
            AddTranslation(text);

            AddNPCHeadTexture(NPCType("Squire"), "Terraria/NPC_Head_1");
            AddNPCHeadTexture(NPCType("Supplier"), "Terraria/NPC_Head_2");
            AddNPCHeadTexture(NPCType("Healer"), "Terraria/NPC_Head_3");
            AddNPCHeadTexture(NPCType("Explosives Expert"), "Terraria/NPC_Head_4");
            AddNPCHeadTexture(NPCType("Outcast"), "Terraria/NPC_Head_5");
            AddNPCHeadTexture(NPCType("Guns Dealer"), "Terraria/NPC_Head_6");
            AddNPCHeadTexture(NPCType("Outfitter"), "Terraria/NPC_Head_7");
            AddNPCHeadTexture(NPCType("Manufacturer"), "Terraria/NPC_Head_8");
            AddNPCHeadTexture(NPCType("Reforger"), "Terraria/NPC_Head_9");
            AddNPCHeadTexture(NPCType("Apprentice"), "Terraria/NPC_Head_10");
            AddNPCHeadTexture(NPCType("Santa"), "Terraria/NPC_Head_11");
            AddNPCHeadTexture(NPCType("Mushroom"), "Terraria/NPC_Head_12");
            AddNPCHeadTexture(NPCType("Steampunk"), "Terraria/NPC_Head_13");
            AddNPCHeadTexture(NPCType("Magician"), "Terraria/NPC_Head_14");
            AddNPCHeadTexture(NPCType("Decorator"), "Terraria/NPC_Head_15");
            AddNPCHeadTexture(NPCType("Robot"), "Terraria/NPC_Head_16");
            AddNPCHeadTexture(NPCType("Artist"), "Terraria/NPC_Head_17");
            AddNPCHeadTexture(NPCType("Doctor"), "Terraria/NPC_Head_18");
            AddNPCHeadTexture(NPCType("Bandit"), "Terraria/NPC_Head_19");
            AddNPCHeadTexture(NPCType("Hair Specialist"), "Terraria/NPC_Head_20");
            AddNPCHeadTexture(NPCType("World Merchant"), "Terraria/NPC_Head_21");
            AddNPCHeadTexture(NPCType("Fisherman"), "Terraria/NPC_Head_22");
            AddNPCHeadTexture(NPCType("Business Man"), "Terraria/NPC_Head_23");
            AddNPCHeadTexture(NPCType("Bartender"), "Terraria/NPC_Head_24");
        }
    }
}
