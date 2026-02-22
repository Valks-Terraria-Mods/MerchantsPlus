$ErrorActionPreference = 'Stop'

$rows = Import-Csv .tmp/missing_items_integrated_with_stage.csv | Sort-Object { [int]$_.Index }

$extraRows = @(
    [pscustomobject]@{ Name = 'FireworkFountain'; Id = 2738; Index = 2738; Stage = 2 },
    [pscustomobject]@{ Name = 'BoosterTrack'; Id = 2739; Index = 2739; Stage = 2 }
)

$existing = New-Object 'System.Collections.Generic.HashSet[string]'
foreach ($row in $rows)
{
    $null = $existing.Add([string]$row.Name)
}

foreach ($extra in $extraRows)
{
    if (-not $existing.Contains($extra.Name))
    {
        $rows += $extra
    }
}

$rows = $rows | Sort-Object { [int]$_.Index }

$replacementItemNames = @{
    OgreMask = 'RobotMask'
    GoblinMask = 'UnicornMask'
    SkeletonBow = 'Marrow'
}

$mergeToNativeShopNames = New-Object 'System.Collections.Generic.HashSet[string]'
foreach ($name in @(
    'Acorn',
    'JungleGrassSeeds',
    'PumpkinSeed',
    'AshGrassSeeds',
    'GemTreeTopazSeed',
    'GemTreeAmethystSeed',
    'GemTreeSapphireSeed',
    'GemTreeEmeraldSeed',
    'GemTreeRubySeed',
    'GemTreeDiamondSeed',
    'GemTreeAmberSeed',
    'VanityTreeSakuraSeed',
    'VanityTreeYellowWillowSeed'
))
{
    $null = $mergeToNativeShopNames.Add($name)
}

$currentNames = New-Object 'System.Collections.Generic.HashSet[string]'
foreach ($row in $rows)
{
    $null = $currentNames.Add([string]$row.Name)
}

foreach ($row in $rows)
{
    $name = [string]$row.Name
    if (-not $replacementItemNames.ContainsKey($name))
    {
        continue
    }

    $replacement = [string]$replacementItemNames[$name]
    if ($currentNames.Contains($replacement))
    {
        continue
    }

    $null = $currentNames.Remove($name)
    $row.Name = $replacement
    $null = $currentNames.Add($replacement)
}

$excludedItemNames = @(
    'DeadMansChest',
    'CopperCoin',
    'SilverCoin',
    'GoldCoin',
    'PlatinumCoin',
    'VortexAxe',
    'VortexChainsaw',
    'VortexHammer',
    'NebulaAxe',
    'NebulaChainsaw',
    'NebulaHammer',
    'SolarFlareAxe',
    'SolarFlareChainsaw',
    'SolarFlareHammer',
    'StardustAxe',
    'StardustChainsaw',
    'StardustHammer'
)

$rows = @($rows | Where-Object {
    $name = [string]$_.Name
    $name -notmatch 'Trapped' -and
    $name -notmatch '^Fake_' -and
    $excludedItemNames -notcontains $name -and
    -not $mergeToNativeShopNames.Contains($name)
})

$merchantNpc = [ordered]@{
    Angler = 'NPCID.Angler'
    ArmsDealer = 'NPCID.ArmsDealer'
    Clothier = 'NPCID.Clothier'
    Cyborg = 'NPCID.Cyborg'
    Demolitionist = 'NPCID.Demolitionist'
    Dryad = 'NPCID.Dryad'
    DyeTrader = 'NPCID.DyeTrader'
    GoblinTinkerer = 'NPCID.GoblinTinkerer'
    Guide = 'NPCID.Guide'
    Mechanic = 'NPCID.Mechanic'
    Merchant = 'NPCID.Merchant'
    Nurse = 'NPCID.Nurse'
    Painter = 'NPCID.Painter'
    PartyGirl = 'NPCID.PartyGirl'
    Pirate = 'NPCID.Pirate'
    Princess = 'NPCID.Princess'
    SantaClaus = 'NPCID.SantaClaus'
    SkeletonMerchant = 'NPCID.SkeletonMerchant'
    Steampunker = 'NPCID.Steampunker'
    Stylist = 'NPCID.Stylist'
    Tavernkeep = 'NPCID.DD2Bartender'
    TaxCollector = 'NPCID.TaxCollector'
    TravellingMerchant = 'NPCID.TravellingMerchant'
    Truffle = 'NPCID.Truffle'
    WitchDoctor = 'NPCID.WitchDoctor'
    Wizard = 'NPCID.Wizard'
    Golfer = 'NPCID.Golfer'
    Cat = 'NPCID.Search.GetId("TownCat")'
    Dog = 'NPCID.Search.GetId("TownDog")'
    Bunny = 'NPCID.Search.GetId("TownBunny")'
    NerdySlime = 'NPCID.Search.GetId("TownSlimeBlue")'
    CoolSlime = 'NPCID.Search.GetId("TownSlimeGreen")'
    ElderSlime = 'NPCID.Search.GetId("TownSlimeOld")'
    ClumsySlime = 'NPCID.Search.GetId("TownSlimePurple")'
    DivaSlime = 'NPCID.Search.GetId("TownSlimeRainbow")'
    SurlySlime = 'NPCID.Search.GetId("TownSlimeRed")'
    MysticSlime = 'NPCID.Search.GetId("TownSlimeYellow")'
    SquireSlime = 'NPCID.Search.GetId("TownSlimeCopper")'
}

$script:FallbackCounter = 0
$script:FallbackTargets = @(
    [pscustomobject]@{ Merchant = 'TravellingMerchant'; Shop = 'Oddities' }
)

$maxShopNameLength = 24
$furnitureTargetSlimes = @(
    'NerdySlime',
    'CoolSlime',
    'ElderSlime',
    'ClumsySlime',
    'DivaSlime',
    'SurlySlime',
    'MysticSlime'
)
$bannerOnlySlime = 'SquireSlime'

function Get-StableIndex([string]$value, [int]$mod)
{
    if ($mod -le 0)
    {
        return 0
    }

    $sum = 0
    foreach ($ch in $value.ToCharArray())
    {
        $sum += [int][char]$ch
    }

    return [math]::Abs($sum) % $mod
}

function Get-PetMerchant([string]$name)
{
    if ($name -match 'Cat|Gato')
    {
        return 'Cat'
    }

    if ($name -match 'Dog|Wolf|Puppy')
    {
        return 'Dog'
    }

    if ($name -match 'Bunny|Bird|Squirrel|Duck|Frog|Mouse|Rat|Owl|Seagull|Cockatiel|Macaw|Toucan|LadyBug|WaterStrider|Seahorse|Dragonfly')
    {
        return 'Bunny'
    }

    $petMerchants = @('Cat', 'Dog', 'Bunny')
    return $petMerchants[(Get-StableIndex $name $petMerchants.Count)]
}

function Get-FurnitureTier([string]$name)
{
    if ($name -match 'Solar|Vortex|Nebula|Stardust') { return 'Lunar' }
    if ($name -match 'Dungeon|Lihzahrd|Martian|Spider|Lesion|Granite|Marble|Meteorite|Frozen|Ice|Mushroom|Corrupt|Crimson|Hallow|Sandstone|Bamboo|Coral') { return 'Biome' }
    return 'Basic'
}

function Get-FurnitureShop([string]$name, [string]$typeName)
{
    return "$(Get-FurnitureTier $name) $typeName"
}

function Get-StatueShop([string]$name)
{
    if ($name -match 'AlphabetStatue') { return 'Alphanumeric Status' }
    if ($name -match 'BunnyStatue|SquirrelStatue|ButterflyStatue|WormStatue|FireflyStatue|ScorpionStatue|SnailStatue|GrasshopperStatue|MouseStatue|DuckStatue|PenguinStatue|FrogStatue|BuggyStatue|DragonflyStatue|SeagullStatue|OwlStatue|TurtleStatue|MacawStatue|ToucanStatue|CockatielStatue') { return 'Critter Statues' }
    if ($name -match 'Zombie|Skeleton|Undead|Wraith|Harpy|Hoplite|Pigron|Granite|Lihzahrd|Piranha|Shark|Hornet|Imp|Goblin|Reaper|Drippler|Unicorn|WallCreeper|BloodZombie') { return 'Enemy Statues' }
    return 'Utility Statues'
}

function Get-ChestShop([string]$name)
{
    if ($name -match 'Solar|Vortex|Nebula|Stardust') { return 'Lunar Chests' }
    if ($name -match 'Dungeon|Lihzahrd|Martian|Spider|Lesion|Granite|Marble|Meteorite|Frozen|Ice|Mushroom|Corrupt|Crimson|Hallow|Desert|Jungle|Bamboo|Coral|Sky') { return 'Biome Chests' }
    return 'Basic Chests'
}

function Get-ShopInfo([string]$name)
{
    if ($name -match 'CrossGraveMarker|GraveMarker|Headstone|Tombstone|Gravestone|RichGravestone|Graveyard|Gravedigger') { return [pscustomobject]@{ Merchant = 'Clothier'; Shop = 'Tombstones' } }
    if ($name -match 'BossBagOgre|BossBagDarkMage') { return [pscustomobject]@{ Merchant = 'Tavernkeep'; Shop = 'Eternia Gear' } }
    if ($name -match 'BossBag|TreasureBag') { return [pscustomobject]@{ Merchant = 'Princess'; Shop = 'Treasure Bags' } }
    if ($name -match 'SlimeCrown|WormFood|BloodySpine|Abeemination|MechanicalEye|MechanicalSkull|MechanicalWorm|LihzahrdPowerCell|CelestialSigil|Suspicious|QueenSlimeCrystal|DeerThing') { return [pscustomobject]@{ Merchant = 'Guide'; Shop = 'Boss Summons' } }
    if ($name -match 'StarPrincessCrown|StarPrincessDress') { return [pscustomobject]@{ Merchant = 'Stylist'; Shop = 'Princess Vanity' } }
    if ($name -match 'GoblinBomberCap|KoboldDynamiteBackpack') { return [pscustomobject]@{ Merchant = 'Stylist'; Shop = 'Vanity' } }
    if ($name -cmatch 'Key') { return [pscustomobject]@{ Merchant = 'GoblinTinkerer'; Shop = 'Keys' } }
    if ($name -match 'Crate') { return [pscustomobject]@{ Merchant = 'Angler'; Shop = 'Crates' } }
    if ($name -match 'MinecartTrack|MinecartPowerup|Minecart') { return [pscustomobject]@{ Merchant = 'Mechanic'; Shop = 'Minecarts' } }
    if ($name -match 'Powder') { return [pscustomobject]@{ Merchant = 'Dryad'; Shop = 'Seeds' } }
    if ($name -match '^Bowl$|BowlofSoup|DynastyBowl|GlassBowl') { return [pscustomobject]@{ Merchant = 'PartyGirl'; Shop = 'Food and Drink' } }

    if ($name -match 'Statue') { return [pscustomobject]@{ Merchant = 'Mechanic'; Shop = (Get-StatueShop $name) } }

    if ($name -match 'Clock') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = (Get-FurnitureShop $name 'Clocks') } }
    if ($name -match 'ArrowSign|PaintedArrowSign|Sign$') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = 'Signs' } }
    if ($name -match 'Banner') { return [pscustomobject]@{ Merchant = $bannerOnlySlime; Shop = 'Banners' } }
    if ($name -match 'Relic') { return [pscustomobject]@{ Merchant = 'Princess'; Shop = 'Relics' } }
    if ($name -match 'Trophy') { return [pscustomobject]@{ Merchant = 'Princess'; Shop = 'Trophies' } }
    if ($name -match 'Dungeon') { return [pscustomobject]@{ Merchant = 'SkeletonMerchant'; Shop = 'Dungeon Set' } }
    if ($name -match 'Lihzahrd') { return [pscustomobject]@{ Merchant = 'WitchDoctor'; Shop = 'Lihzahrd Set' } }
    if ($name -match 'Spider') { return [pscustomobject]@{ Merchant = 'WitchDoctor'; Shop = 'Spider Set' } }
    if ($name -match 'Martian') { return [pscustomobject]@{ Merchant = 'Cyborg'; Shop = 'Martian Set' } }
    if ($name -match 'Rainbow') { return [pscustomobject]@{ Merchant = 'PartyGirl'; Shop = 'Rainbow Set' } }
    if ($name -match 'Solar') { return [pscustomobject]@{ Merchant = 'Princess'; Shop = 'Solar Set' } }
    if ($name -match 'Vortex') { return [pscustomobject]@{ Merchant = 'Princess'; Shop = 'Vortex Set' } }
    if ($name -match 'Nebula') { return [pscustomobject]@{ Merchant = 'Princess'; Shop = 'Nebula Set' } }
    if ($name -match 'Stardust') { return [pscustomobject]@{ Merchant = 'Princess'; Shop = 'Stardust Set' } }

    if ($name -match 'Chair|HoverChair') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = (Get-FurnitureShop $name 'Chairs') } }
    if ($name -match 'Lamp|Lamppost|TableLamp') { return [pscustomobject]@{ Merchant = 'Steampunker'; Shop = (Get-FurnitureShop $name 'Lamps') } }
    if ($name -match 'Table') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = (Get-FurnitureShop $name 'Tables') } }
    if ($name -match 'Sink') { return [pscustomobject]@{ Merchant = 'Nurse'; Shop = (Get-FurnitureShop $name 'Sinks') } }
    if ($name -match 'Door') { return [pscustomobject]@{ Merchant = 'Pirate'; Shop = (Get-FurnitureShop $name 'Doors') } }
    if ($name -match 'Bed') { return [pscustomobject]@{ Merchant = 'Princess'; Shop = (Get-FurnitureShop $name 'Beds') } }
    if ($name -match 'Sofa') { return [pscustomobject]@{ Merchant = 'Princess'; Shop = (Get-FurnitureShop $name 'Sofas') } }
    if ($name -match 'Dresser') { return [pscustomobject]@{ Merchant = 'Clothier'; Shop = (Get-FurnitureShop $name 'Dressers') } }
    if ($name -match 'Bookcase|Bookshelf') { return [pscustomobject]@{ Merchant = 'Wizard'; Shop = (Get-FurnitureShop $name 'Bookcases') } }
    if ($name -match 'Piano') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = 'Pianos' } }
    if ($name -match 'Toilet') { return [pscustomobject]@{ Merchant = 'Nurse'; Shop = 'Toilets' } }
    if ($name -match 'Bathtub') { return [pscustomobject]@{ Merchant = 'Nurse'; Shop = (Get-FurnitureShop $name 'Bathtubs') } }
    if ($name -match 'Chandelier') { return [pscustomobject]@{ Merchant = 'PartyGirl'; Shop = (Get-FurnitureShop $name 'Chandeliers') } }
    if ($name -match 'Lantern') { return [pscustomobject]@{ Merchant = 'WitchDoctor'; Shop = (Get-FurnitureShop $name 'Lanterns') } }
    if ($name -match 'Candelabra') { return [pscustomobject]@{ Merchant = 'Wizard'; Shop = (Get-FurnitureShop $name 'Candelabras') } }
    if ($name -match 'Candle') { return [pscustomobject]@{ Merchant = 'Wizard'; Shop = (Get-FurnitureShop $name 'Candles') } }
    if ($name -match 'Platform') { return [pscustomobject]@{ Merchant = 'Mechanic'; Shop = (Get-FurnitureShop $name 'Platforms') } }
    if ($name -match 'Wall') { return [pscustomobject]@{ Merchant = 'Steampunker'; Shop = (Get-FurnitureShop $name 'Walls') } }
    if ($name -match 'Block|Brick') { return [pscustomobject]@{ Merchant = 'Steampunker'; Shop = (Get-FurnitureShop $name 'Blocks') } }
    if ($name -match 'Painting|Portrait|Mural|MorningHunt|NotSoLostInParadise|HappyLittleTree|ThisIsGettingOutOfHand|StrangeDeadFellows|Buddies|Reborn|Constellation|Crustography|Wildflowers|Outcast|RemnantsofDevotion|RoyalRomance') { return [pscustomobject]@{ Merchant = 'Painter'; Shop = 'Paintings' } }
    if ($name -match 'Chest$|ChestLock$') { return [pscustomobject]@{ Merchant = 'Merchant'; Shop = (Get-ChestShop $name) } }

    if ($name -match 'MusicBox') { return [pscustomobject]@{ Merchant = 'SkeletonMerchant'; Shop = 'Music Boxes' } }
    if ($name -match 'Mask|Helmet|Headgear|Visor') { return [pscustomobject]@{ Merchant = 'Clothier'; Shop = 'Masks' } }
    if ($name -match 'Breastplate|Chestplate|PlateMail|Leggings|Greaves|Chainmail|Armor|Mail') { return [pscustomobject]@{ Merchant = 'Clothier'; Shop = 'Armor' } }

    if ($name -match 'Dye|Dyed|HairDye|Reflective|Gradient|Negative|HallowBoss|ColorOnly|DyeVat') { return [pscustomobject]@{ Merchant = 'DyeTrader'; Shop = 'Dyes' } }

    if ($name -match '^BladeofGrass$|JungleYoyo') { return [pscustomobject]@{ Merchant = 'Pirate'; Shop = 'Melee Weapons' } }
    if ($name -match '^FishHook$') { return [pscustomobject]@{ Merchant = 'GoblinTinkerer'; Shop = 'Hooks' } }
    if ($name -match '^SharkFin$') { return [pscustomobject]@{ Merchant = 'Merchant'; Shop = 'Materials' } }
    if ($name -match '^Goldfish$|^FishBowl$') { return [pscustomobject]@{ Merchant = 'Bunny'; Shop = 'Critter Care' } }
    if ($name -match 'TinCan|OldShoe|FishingSeaweed') { return [pscustomobject]@{ Merchant = 'Angler'; Shop = 'Fishing Trash' } }
    if ($name -match 'AmanitaFungifin|Angelfish|Batfish|BloodyManowar|Bonefish|BumblebeeTuna|Bunnyfish|CapnTunabeard|Catfish|Cloudfish|Clownfish|Cursedfish|DemonicHellfish|Derpfish|Dirtfish|DynamiteFish|EaterofPlankton|FallenStarfish|Fishotron|Fishron|GuideVoodooFish|Harpyfish|Hemopiranha|Hungerfish|Ichorfish|InfectedScabbardfish|Jewelfish|MirageFish|Mudfish|MutantFlinxfin|Pengfish|Pixiefish|Slimefish|Spiderfish|TheFishofCthulu|TropicalBarracuda|TundraTrout|UnicornFish|Wyverntail|ZombieFish') { return [pscustomobject]@{ Merchant = 'Angler'; Shop = 'Quest Fish' } }
    if ($name -match 'WormTooth|ButterflyDust|WormHook|CanOfWorms|SharkBait') { return [pscustomobject]@{ Merchant = 'Angler'; Shop = 'Fish Gear' } }
    if ($name -match 'Cage|Jar|inaBottle' -and $name -match 'Worm|Butterfly|Buggy|Grubby|Sluggy|Firefly|LightningBug|Snail|TruffleWorm|MagmaSnail|HellButterfly|EmpressButterfly') { return [pscustomobject]@{ Merchant = 'Angler'; Shop = 'Critter Decor' } }
    if ($name -match 'Bait|Worm|Butterfly|Buggy|Grubby|Sluggy|Firefly|LightningBug|Snail') { return [pscustomobject]@{ Merchant = 'Angler'; Shop = 'Fish Gear' } }
    if ($name -match 'Fish|Fishing|Trout|Tuna|Bass|Salmon|Shrimp|Shark|Swordfish|Angelfish|Koi|Eel|Puffer|NeonTetra') { return [pscustomobject]@{ Merchant = 'Angler'; Shop = 'Fish' } }
    if ($name -match 'Seed|Acorn|Sapling|Blinkroot|Daybloom|Moonglow|Shiverthorn|Waterleaf|Fireblossom|Deathweed|Sunflower|Grass|Jungle') { return [pscustomobject]@{ Merchant = 'Dryad'; Shop = 'Seeds' } }

    if ($name -match 'Sake|CreamSoda|Milkshake|GrapeJuice|Lemonade|BananaDaiquiri|PeachSangria|PinaColada|TropicalSmoothie|BloodyMoscato|SmoothieofDarkness|FruitJuice|CoffeeCup|AppleJuice|Pomegranate|HoplitePizza') { return [pscustomobject]@{ Merchant = 'Tavernkeep'; Shop = 'Bar Drinks' } }
    if ($name -match 'Potion|Elixir|Brew') { return [pscustomobject]@{ Merchant = 'Merchant'; Shop = 'Potions' } }
    if ($name -match 'Heart|LifeCrystal|LifeFruit|Healing') { return [pscustomobject]@{ Merchant = 'Nurse'; Shop = 'Healing' } }
    if ($name -match 'Mana|StarInABottle|CrystalBall') { return [pscustomobject]@{ Merchant = 'Wizard'; Shop = 'Mana' } }

    if ($name -match '^(Amethyst|Topaz|Sapphire|Emerald|Ruby|Diamond|Amber)(Staff|Robe|Hook|Echo|BunnyCage|SquirrelCage)$|^GemLock|^GemSquirrel|^GemBunny|^Large(Amethyst|Topaz|Sapphire|Emerald|Ruby|Diamond|Amber)$') { return [pscustomobject]@{ Merchant = 'Wizard'; Shop = 'Gems' } }
    if ($name -match '^(ShroomiteBar|SpectreBar)$') { return [pscustomobject]@{ Merchant = 'Merchant'; Shop = 'Materials' } }
    if ($name -match '^(Copper|Tin|Iron|Lead|Silver|Tungsten|Gold|Platinum|Demonite|Crimtane|Meteorite|Hellstone|Cobalt|Palladium|Mythril|Orichalcum|Adamantite|Titanium|Chlorophyte|Hallowed|Lunar|Shroomite|Spectre|Fossil)Ore$') { return [pscustomobject]@{ Merchant = 'Demolitionist'; Shop = 'Ores' } }
    if ($name -match '^(Copper|Tin|Iron|Lead|Silver|Tungsten|Gold|Platinum|Demonite|Crimtane|Meteorite|Hellstone|Cobalt|Palladium|Mythril|Orichalcum|Adamantite|Titanium|Chlorophyte|Hallowed|Lunar|Shroomite|Spectre|Fossil)Bar$') { return [pscustomobject]@{ Merchant = 'Demolitionist'; Shop = 'Ores' } }
    if ($name -match '^(Amber|Amethyst|Topaz|Sapphire|Emerald|Ruby|Diamond)$') { return [pscustomobject]@{ Merchant = 'Demolitionist'; Shop = 'Ores' } }
    if ($name -match 'Picksaw|PickaxeAxe|Drax|Pickaxe') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = 'Pickaxes' } }
    if ($name -match 'Drill|Chainsaw') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = 'Drills and Saws' } }
    if ($name -match 'Hamaxe|Jackhammer|Hammer') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = 'Hammers' } }
    if ($name -match 'Waraxe|Greataxe|Axe') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = 'Axes' } }
    if ($name -match 'Workbench|Workshop|Anvil|Furnace|Hellforge|Loom|Keg|CookingPot|Alchemy|ImbuingStation') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = 'Tools' } }
    if ($name -match 'Watch|Compass|Radar|Ruler|Meter|Analyzer|GPS|PDA|CellPhone') { return [pscustomobject]@{ Merchant = 'GoblinTinkerer'; Shop = 'Info Gear' } }
    if ($name -match '^Barrel$|^BarStool$|^Bar$') { return [pscustomobject]@{ Merchant = 'Tavernkeep'; Shop = 'Bar Decor' } }

    if ($name -match 'Staff|Wand|Spell|Tome|Magic|Arcane|Nebula|Prism|Flamelash|MagicMissile|Scepter|WaterBolt|AquaScepter|FlowerofFire|NettleBurst|CrystalStorm|HexDoll|SpiritFlame|BatScepter|NimbusRod|GoldenShower|RainbowRod') { return [pscustomobject]@{ Merchant = 'Wizard'; Shop = 'Magic Weapons' } }
    if ($name -match 'Summon|Whip|Imp|Hornet|Spider|StardustDragon|Sanguine|Minion|Flask|Bewitch') { return [pscustomobject]@{ Merchant = 'WitchDoctor'; Shop = 'Summon Gear' } }

    if ($name -eq 'Marrow') { return [pscustomobject]@{ Merchant = 'ArmsDealer'; Shop = 'Ranged Weapons' } }
    if ($name -match 'Bullet|Ammo|Arrow$|Quiver|MusketPouch') { return [pscustomobject]@{ Merchant = 'ArmsDealer'; Shop = 'Ammo' } }
    if ($name -match 'Gun|Pistol|Rifle|Shotgun|Musket|Minishark|Megashark|Sniper|Uzi|Revolver|Flintlock|Boomstick|Launcher') { return [pscustomobject]@{ Merchant = 'ArmsDealer'; Shop = 'Guns' } }
    if ($name -match 'Repeater') { return [pscustomobject]@{ Merchant = 'ArmsDealer'; Shop = 'Repeaters' } }
    if ($name -match 'Bow$|Shotbow|Stormbow') { return [pscustomobject]@{ Merchant = 'ArmsDealer'; Shop = 'Bows' } }
    if ($name -match 'Crossbow|Harpoon|RangedItem|Stake') { return [pscustomobject]@{ Merchant = 'ArmsDealer'; Shop = 'Ranged Weapons' } }
    if ($name -match 'Rocket') { return [pscustomobject]@{ Merchant = 'Cyborg'; Shop = 'Rockets' } }
    if ($name -match 'Bomb|Dynamite|Grenade|Explosive|Beenade|ScarabBomb') { return [pscustomobject]@{ Merchant = 'Demolitionist'; Shop = 'Explosives' } }
    if ($name -match 'Sword|Blade|Saber|Katana|Spear|Pike|Halberd|Mace|Flail|Yoyo|Boomerang|Knife|Dagger|Scythe|Waver|Lance|Trident|Bananarang|Chakram|Fury') { return [pscustomobject]@{ Merchant = 'Pirate'; Shop = 'Melee Weapons' } }

    if ($name -match 'Hook') { return [pscustomobject]@{ Merchant = 'GoblinTinkerer'; Shop = 'Hooks' } }
    if ($name -match 'Boot|Shoe|Aglet|Anklet|RocketBoot') { return [pscustomobject]@{ Merchant = 'GoblinTinkerer'; Shop = 'Boots' } }
    if ($name -match 'Wing') { return [pscustomobject]@{ Merchant = 'WitchDoctor'; Shop = 'Wings' } }
    if ($name -match 'Accessory|Shield|Ankh|Charm|Magnet|Balloon|Horseshoe|Necklace|Band') { return [pscustomobject]@{ Merchant = 'GoblinTinkerer'; Shop = 'Accessories' } }

    if ($name -match 'Wire|Wrench|Actuator|Lever|PressurePlate|Timer|Logic|Trap|Detonator|BoosterTrack|Track') { return [pscustomobject]@{ Merchant = 'Mechanic'; Shop = 'Wiring' } }
    if ($name -match 'Steampunk|Clentaminator|Solution|Cog|Boiler|Pump|Teleporter|Conveyor') { return [pscustomobject]@{ Merchant = 'Steampunker'; Shop = 'Industry' } }
    if ($name -match 'Martian|Xeno|Nano|Laser|Electro|UFO|Plasma') { return [pscustomobject]@{ Merchant = 'Cyborg'; Shop = 'Tech Gear' } }

    if ($name -match 'Coin|Money|Piggy|Safe|Vault|Cash') { return [pscustomobject]@{ Merchant = 'TaxCollector'; Shop = 'Coins' } }
    if ($name -match 'DD2|DefenderMedal|Eternia|Betsy|DarkMage|Ogre|Apprentice|Huntress|Monk|Squire') { return [pscustomobject]@{ Merchant = 'Tavernkeep'; Shop = 'Eternia Gear' } }
    if ($name -match 'Pirate|Cannon|Parrot|Corsair|Anchor|Cutlass|Broadside') { return [pscustomobject]@{ Merchant = 'Pirate'; Shop = 'Pirate Gear' } }
    if ($name -match 'Santa|Christmas|Xmas|CandyCane|Present|Reindeer|Festive|Frost|ToySled') { return [pscustomobject]@{ Merchant = 'SantaClaus'; Shop = 'Holiday' } }
    if ($name -match 'Mushroom|Shroom|Spore|Fungal') { return [pscustomobject]@{ Merchant = 'Truffle'; Shop = 'Mushroom' } }
    if ($name -match 'Dragonfly') { return [pscustomobject]@{ Merchant = 'Bunny'; Shop = 'Critter Care' } }
    if ($name -match 'Pet|Companion|Egg|Whistle|Cracker|Totem|Seaweed|LizardEgg|Dragon|Gato') { return [pscustomobject]@{ Merchant = (Get-PetMerchant $name); Shop = 'Pets' } }
    if ($name -match 'MountItem$|Saddle$|CarKey$|ScalyTruffle$|HoneyedGoggles$|FuzzyCarrot$|ReindeerBells$|WitchsBroom$|GoatSkull$|AncientHorn$|BlessedApple$|BrainScrambler$|DarkMageBookMount$|SuperCart$|GolfCartKey$|PewMaticHorn$') { return [pscustomobject]@{ Merchant = 'Princess'; Shop = 'Mounts' } }
    if ($name -match 'Golf') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = 'Golf' } }
    if ($name -match 'Cage|Jar|Kite|Terrarium|Bird|Bunny|Squirrel|Duck|Frog|Mouse|Rat|Owl|Seagull|Cockatiel|Macaw|Toucan|LadyBug|WaterStrider|Seahorse|Dragonfly') { return [pscustomobject]@{ Merchant = 'Bunny'; Shop = 'Critter Care' } }
    if ($name -match 'Soup|Stew|Cookie|Cake|Pizza|Burger|Juice|Coffee|Soda|Milkshake|IceCream|Fries|Steak|Sake|PadThai|Nugget|Ribs|Pomegranate|Mango|Banana|Lemon|Apricot|Plum|Grapes|Peach|Cherry|Coconut|Starfruit|PinaColada|Smoothie|Daiquiri|Sangria|Moscato|Lemonade|CreamSoda|Sushi') { return [pscustomobject]@{ Merchant = 'PartyGirl'; Shop = 'Food and Drink' } }
    if ($name -match '(Lens$|Chunk$|Scale$|Stinger$|Mandible$|Feather$|Dust$|Shard$|Fragment$|Husk$|Mold$|Shell$|Fur$|Ink$|Tissue$|TissueSample$|Vertebrae$|Mucos$|Claw$|^Soulof)') { return [pscustomobject]@{ Merchant = 'Merchant'; Shop = 'Materials' } }
    if ($name -match 'Fence') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = 'Fences' } }
    if ($name -match 'Campfire') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = 'Campfires' } }
    if ($name -match 'Vase|Shelf|Fountain|Monolith|Globe|Rack|Dishes|Cup|Goblet|Plate|Brazier|PotSuspended|LawnMower|GardenGnome|WeatherVane') { return [pscustomobject]@{ Merchant = 'Golfer'; Shop = 'Decor Utility' } }
    if ($name -match 'Vanity|Robe|Shirt|Pants|Dress|Hat|Hood|Coat|Cloak|Costume|Suit|Skirt|Tuxedo|Crown|Tiara|Gown') { return [pscustomobject]@{ Merchant = 'Stylist'; Shop = 'Vanity' } }

    $fallback = $script:FallbackTargets[$script:FallbackCounter % $script:FallbackTargets.Count]
    $script:FallbackCounter++
    return [pscustomobject]@{ Merchant = $fallback.Merchant; Shop = $fallback.Shop }
}

function Get-LevelRange([int]$stage)
{
    switch ($stage)
    {
        0 { return @(1, 7) }
        1 { return @(8, 14) }
        2 { return @(15, 20) }
        3 { return @(21, 21) }
        default { return @(1, 21) }
    }
}

function Get-ProgressionLevel([int]$stage, [int]$position, [int]$count)
{
    $range = Get-LevelRange $stage
    $min = $range[0]
    $max = $range[1]

    if ($count -le 1 -or $max -le $min)
    {
        return $min
    }

    $ratio = [double]$position / [double]($count - 1)
    return [int][math]::Round($min + (($max - $min) * $ratio), 0)
}

function Get-OverflowSuffix([int]$index)
{
    $suffixes =
    @(
        'Core',
        'Plus',
        'Prime',
        'Final',
        'Mythic',
        'Rare',
        'Elite',
        'Legacy',
        'Exotic',
        'Arcane',
        'Omega',
        'Nova',
        'Apex',
        'Echo',
        'Relic',
        'Ancient',
        'Master',
        'Grand',
        'Noble',
        'Wild',
        'Secret',
        'Hidden',
        'Curious',
        'Ethereal',
        'Infernal',
        'Celestial'
    )

    if ($index -lt $suffixes.Count)
    {
        return $suffixes[$index]
    }

    return 'Omega'
}

function Get-ShopPageName([string]$baseShopName, [int]$pageIndex, [int]$pageCount)
{
    if ($pageCount -le 1)
    {
        return $baseShopName
    }

    $suffix = Get-OverflowSuffix $pageIndex
    $maxLength = $maxShopNameLength

    $candidate = "$baseShopName $suffix"
    if ($candidate.Length -le $maxLength)
    {
        return $candidate
    }

    $words = @($baseShopName -split ' ')
    if ($words.Count -ge 2)
    {
        if ($words[0] -in @('Basic', 'Biome', 'Lunar'))
        {
            $candidate = "$($words[-1]) $suffix"
            if ($candidate.Length -le $maxLength)
            {
                return $candidate
            }
        }

        $candidate = "$($words[0]) $suffix"
        if ($candidate.Length -le $maxLength)
        {
            return $candidate
        }

        $candidate = "$($words[-1]) $suffix"
        if ($candidate.Length -le $maxLength)
        {
            return $candidate
        }
    }

    $trimmed = ''
    foreach ($word in $words)
    {
        $test = if ([string]::IsNullOrWhiteSpace($trimmed)) { $word } else { "$trimmed $word" }
        if ($test.Length -gt $maxLength)
        {
            break
        }

        $trimmed = $test
    }

    if ([string]::IsNullOrWhiteSpace($trimmed))
    {
        return $baseShopName.Substring(0, [math]::Min($baseShopName.Length, $maxLength))
    }

    return $trimmed
}

function New-ManualItem([string]$name, [int]$requiredProgression)
{
    return [pscustomobject]@{
        Name = $name
        RequiredProgression = $requiredProgression
    }
}

function Add-ManualPage([hashtable]$pagesByMerchant, [string]$merchant, [string]$shopName, [object[]]$items)
{
    if (-not $pagesByMerchant.ContainsKey($merchant))
    {
        return
    }

    if ($shopName.Length -gt $maxShopNameLength)
    {
        throw "Shop name exceeds $maxShopNameLength chars: '$shopName'"
    }

    $pagesByMerchant[$merchant].Add([pscustomobject]@{
        ShopName = $shopName
        Items = $items
    })
}

function Is-FurnitureShopName([string]$shopName)
{
    return $shopName -match 'Chairs|Tables|Lamps|Sinks|Doors|Beds|Sofas|Dressers|Bookcases|Pianos|Toilets|Bathtubs|Chandeliers|Lanterns|Candelabras|Candles|Platforms|Walls|Blocks|Clocks|Chests'
}

function Redistribute-FurnitureShopsToSlimes([hashtable]$byShop)
{
    $loadByMerchant = @{}
    foreach ($merchant in $furnitureTargetSlimes)
    {
        $loadByMerchant[$merchant] = 0
    }

    $furnitureEntries = @()
    foreach ($pair in @($byShop.GetEnumerator()))
    {
        $key = [string]$pair.Key
        $parts = $key.Split('|', 2)
        if ($parts.Length -ne 2)
        {
            continue
        }

        $shopName = $parts[1]
        if (-not (Is-FurnitureShopName $shopName))
        {
            continue
        }

        $items = @($pair.Value.ToArray())
        $furnitureEntries += [pscustomobject]@{
            Key = $key
            ShopName = $shopName
            Items = $items
        }
    }

    $furnitureEntries = @(
        $furnitureEntries |
            Sort-Object @{ Expression = { $_.Items.Count }; Descending = $true }, ShopName, Key
    )

    foreach ($entry in $furnitureEntries)
    {
        $targetMerchant = $furnitureTargetSlimes |
            Sort-Object @{ Expression = { $loadByMerchant[$_] } }, @{ Expression = { $_ } } |
            Select-Object -First 1
        $targetKey = "$targetMerchant|$($entry.ShopName)"

        if (-not $byShop.ContainsKey($targetKey))
        {
            $byShop[$targetKey] = New-Object System.Collections.Generic.List[object]
        }

        foreach ($item in $entry.Items)
        {
            $byShop[$targetKey].Add($item)
        }

        $loadByMerchant[$targetMerchant] += $entry.Items.Count

        if ($entry.Key -ne $targetKey)
        {
            $byShop.Remove($entry.Key)
        }
    }
}

$byShop = @{}
foreach ($row in $rows)
{
    $name = [string]$row.Name
    $merchantShop = Get-ShopInfo $name

    if (-not $merchantNpc.Contains($merchantShop.Merchant))
    {
        $merchantShop = [pscustomobject]@{ Merchant = 'Merchant'; Shop = 'General Goods' }
    }

    $key = "$($merchantShop.Merchant)|$($merchantShop.Shop)"
    if (-not $byShop.ContainsKey($key))
    {
        $byShop[$key] = New-Object System.Collections.Generic.List[object]
    }

    $byShop[$key].Add([pscustomobject]@{
        Name = $name
        Id = [int]$row.Id
        Index = [int]$row.Index
        Stage = [int]$row.Stage
    })
}

Redistribute-FurnitureShopsToSlimes -byShop $byShop

$pageSize = 40

$manualMerchants =
@(
    'Cat',
    'Dog',
    'Bunny'
)

$manualItemNames = New-Object 'System.Collections.Generic.HashSet[string]'
foreach ($itemName in @(
    'LicenseCat', 'CatMask', 'CatShirt', 'CatPants', 'CatEars', 'CatBast',
    'LicenseDog', 'DogWhistle', 'DogEars', 'DogTail',
    'LicenseBunny', 'Bunny', 'BunnyCage', 'BunnyHood', 'BunnyEars'
))
{
    $null = $manualItemNames.Add($itemName)
}

foreach ($key in @($byShop.Keys))
{
    $merchant = $key.Split('|')[0]
    if ($manualMerchants -contains $merchant)
    {
        continue
    }

    $filtered = @($byShop[$key] | Where-Object { -not $manualItemNames.Contains([string]$_.Name) })
    $byShop[$key] = New-Object System.Collections.Generic.List[object]
    foreach ($item in $filtered)
    {
        $byShop[$key].Add($item)
    }
}

$pagesByMerchant = @{}
foreach ($merchant in $merchantNpc.Keys)
{
    $pagesByMerchant[$merchant] = New-Object System.Collections.Generic.List[object]
}

foreach ($entry in $byShop.GetEnumerator())
{
    $parts = $entry.Key.Split('|')
    $merchant = $parts[0]
    $baseShopName = $parts[1]

    $groupItems = $entry.Value | Sort-Object Stage, Index

    $itemsWithProg = New-Object System.Collections.Generic.List[object]
    foreach ($stage in 0..3)
    {
        $stageItems = @($groupItems | Where-Object { $_.Stage -eq $stage } | Sort-Object Index)
        for ($i = 0; $i -lt $stageItems.Count; $i++)
        {
            $required = Get-ProgressionLevel -stage $stage -position $i -count $stageItems.Count
            $itemsWithProg.Add([pscustomobject]@{
                Name = [string]$stageItems[$i].Name
                Id = [int]$stageItems[$i].Id
                Index = [int]$stageItems[$i].Index
                RequiredProgression = $required
            })
        }
    }

    $itemsWithProg = $itemsWithProg | Sort-Object RequiredProgression, Index

    $pageCount = [math]::Ceiling($itemsWithProg.Count / $pageSize)
    for ($pageIndex = 0; $pageIndex -lt $pageCount; $pageIndex++)
    {
        $chunk = @($itemsWithProg | Select-Object -Skip ($pageIndex * $pageSize) -First $pageSize)

        $shopName = Get-ShopPageName -baseShopName $baseShopName -pageIndex $pageIndex -pageCount $pageCount

        if ($shopName.Length -gt $maxShopNameLength)
        {
            throw "Shop name exceeds $maxShopNameLength chars: '$shopName'"
        }

        $pagesByMerchant[$merchant].Add([pscustomobject]@{
            ShopName = $shopName
            Items = $chunk
        })
    }
}

Add-ManualPage -pagesByMerchant $pagesByMerchant -merchant 'Cat' -shopName 'Cat Kit' -items @(
    (New-ManualItem 'LicenseCat' 1),
    (New-ManualItem 'CatMask' 4),
    (New-ManualItem 'CatShirt' 8),
    (New-ManualItem 'CatPants' 12),
    (New-ManualItem 'CatEars' 16),
    (New-ManualItem 'CatBast' 21)
)

Add-ManualPage -pagesByMerchant $pagesByMerchant -merchant 'Dog' -shopName 'Dog Kit' -items @(
    (New-ManualItem 'LicenseDog' 1),
    (New-ManualItem 'DogWhistle' 8),
    (New-ManualItem 'DogEars' 14),
    (New-ManualItem 'DogTail' 20)
)

Add-ManualPage -pagesByMerchant $pagesByMerchant -merchant 'Bunny' -shopName 'Bunny Kit' -items @(
    (New-ManualItem 'LicenseBunny' 1),
    (New-ManualItem 'Bunny' 4),
    (New-ManualItem 'BunnyCage' 8),
    (New-ManualItem 'BunnyHood' 14),
    (New-ManualItem 'BunnyEars' 20)
)

$slimeMerchants =
@(
    'NerdySlime',
    'CoolSlime',
    'ElderSlime',
    'ClumsySlime',
    'DivaSlime',
    'SurlySlime',
    'MysticSlime'
)
$allSlimeMerchants = @($slimeMerchants + @($bannerOnlySlime))

$smallShopExemptMerchants =
@(
    'Cat',
    'Dog',
    'Bunny'
)

function Get-NextSlimeFindShopName([System.Collections.Generic.List[object]]$pages)
{
    $usedNames = @($pages | ForEach-Object { [string]$_.ShopName })
    if ($usedNames -notcontains 'Slime Finds')
    {
        return 'Slime Finds'
    }

    $index = 1
    while ($true)
    {
        $candidate = "Slime Finds $(Get-OverflowSuffix $index)"
        if ($candidate.Length -gt $maxShopNameLength)
        {
            $candidate = "Slime Find $(Get-OverflowSuffix $index)"
        }

        if ($usedNames -notcontains $candidate)
        {
            return $candidate
        }

        $index++
    }
}

function Add-RandomSlimeItem([hashtable]$pagesByMerchant, [object]$item)
{
    $targetMerchant = Get-Random -InputObject $slimeMerchants
    $targetPages = $pagesByMerchant[$targetMerchant]

    for ($i = 0; $i -lt $targetPages.Count; $i++)
    {
        if ($targetPages[$i].Items.Count -lt $pageSize)
        {
            $targetPages[$i].Items = @($targetPages[$i].Items + $item)
            return
        }
    }

    $targetPages.Add([pscustomobject]@{
        ShopName = Get-NextSlimeFindShopName $targetPages
        Items = @($item)
    })
}

foreach ($merchant in $merchantNpc.Keys)
{
    if ($allSlimeMerchants -contains $merchant)
    {
        continue
    }

    if ($smallShopExemptMerchants -contains $merchant)
    {
        continue
    }

    $merchantKey = [string]$merchant
    if (-not $pagesByMerchant.ContainsKey($merchantKey))
    {
        continue
    }

    $originalPages = @($pagesByMerchant[$merchantKey].ToArray())
    $retainedPages = New-Object System.Collections.Generic.List[object]

    foreach ($page in $originalPages)
    {
        if ($page.Items.Count -le 5)
        {
            foreach ($item in $page.Items)
            {
                Add-RandomSlimeItem -pagesByMerchant $pagesByMerchant -item $item
            }

            continue
        }

        $retainedPages.Add($page)
    }

    $pagesByMerchant[$merchantKey] = $retainedPages
}

function Assert-NoGroupingRegressions([hashtable]$pagesByMerchant)
{
    foreach ($merchant in $merchantNpc.Keys)
    {
        if (-not $pagesByMerchant.ContainsKey($merchant))
        {
            continue
        }

        $pages = $pagesByMerchant[$merchant]
        $seenNames = New-Object 'System.Collections.Generic.HashSet[string]'

        foreach ($page in $pages)
        {
            $pageName = [string]$page.ShopName
            if (-not $seenNames.Add($pageName))
            {
                throw "Duplicate shop name '$pageName' for merchant '$merchant'."
            }

            if ($page.Items.Count -gt $pageSize)
            {
                throw "Shop '$merchant/$pageName' has $($page.Items.Count) items (max $pageSize)."
            }

            $itemNames = @($page.Items | ForEach-Object { [string]$_.Name })

            if ($pageName -like 'Explosives*')
            {
                $bad = @($itemNames | Where-Object { $_ -match 'Minecart|Powder' })
                if ($bad.Count -gt 0)
                {
                    throw "Explosives contains forbidden items: $([string]::Join(', ', $bad))"
                }
            }

            if ($pageName -like 'Ores*')
            {
                $bad = @($itemNames | Where-Object { $_ -match '^(ShroomiteBar|SpectreBar)$' })
                if ($bad.Count -gt 0)
                {
                    throw "Ores contains advanced bars: $([string]::Join(', ', $bad))"
                }
            }

            if ($pageName -like 'Ranged*')
            {
                $bad = @($itemNames | Where-Object { $_ -match 'Bow|Repeater|Bowl|RainbowString|RainbowCampfire|Whip|Summon|Staff|Wand|Tome|Spell|Scepter|Magic|Rod' })
                if ($bad.Count -gt 0)
                {
                    throw "Ranged shop contains misgrouped items: $([string]::Join(', ', $bad))"
                }
            }

            if ($pageName -match '^Bait($| )|^Fishing Misc($| )|^Food Plus($| )')
            {
                throw "Underfilled overflow shop should be merged: $merchant/$pageName"
            }

            if ($merchant -eq $bannerOnlySlime -and $pageName -notlike 'Banners*')
            {
                throw "Banner-only slime has non-banner shop: $merchant/$pageName"
            }

            if ($pageName -like 'Coins*')
            {
                $bad = @($itemNames | Where-Object { $_ -match '^(CopperCoin|SilverCoin|GoldCoin|PlatinumCoin)$' })
                if ($bad.Count -gt 0)
                {
                    throw "Coins shop contains raw coin items: $([string]::Join(', ', $bad))"
                }
            }

            if ($pageName -like 'Treasure Bags*')
            {
                $bad = @($itemNames | Where-Object { $_ -match '^(BossBagOgre|BossBagDarkMage)$' })
                if ($bad.Count -gt 0)
                {
                    throw "Treasure Bags contains invalid bags: $([string]::Join(', ', $bad))"
                }
            }

            if ($pageName -like 'Mounts*')
            {
                $bad = @($itemNames | Where-Object { $_ -match '^(ApplePieSlice|ApplePie|AppleJuice|Apple|Vilethorn|UnicornHorn)$' })
                if ($bad.Count -gt 0)
                {
                    throw "Mounts contains non-mount items: $([string]::Join(', ', $bad))"
                }
            }
        }
    }
}

Assert-NoGroupingRegressions -pagesByMerchant $pagesByMerchant

$builder = New-Object System.Text.StringBuilder
$null = $builder.AppendLine('namespace MerchantsPlus.Shops;')
$null = $builder.AppendLine('')
$null = $builder.AppendLine('public static class ShopExpandedCatalog')
$null = $builder.AppendLine('{')
$null = $builder.AppendLine('    public readonly record struct ShopItem(int ItemId, int RequiredProgression);')
$null = $builder.AppendLine('    public readonly record struct ShopPage(string ShopName, ShopItem[] Items);')
$null = $builder.AppendLine('')
$null = $builder.AppendLine('    private static readonly Dictionary<int, ShopPage[]> PagesByMerchant = new()')
$null = $builder.AppendLine('    {')

foreach ($merchant in $merchantNpc.Keys)
{
    $pages = $pagesByMerchant[$merchant]
    if ($pages.Count -eq 0)
    {
        continue
    }

    $npcConst = $merchantNpc[$merchant]
    $null = $builder.AppendLine("        [$npcConst] =")
    $null = $builder.AppendLine('        [')

    foreach ($page in $pages)
    {
        $null = $builder.AppendLine("            new(`"$($page.ShopName)`",")
        $null = $builder.AppendLine('            [')

        foreach ($item in $page.Items)
        {
            $null = $builder.AppendLine("                new(ItemID.$($item.Name), $($item.RequiredProgression)),")
        }

        $null = $builder.AppendLine('            ]),')
    }

    $null = $builder.AppendLine('        ],')
}

$null = $builder.AppendLine('    };')
$null = $builder.AppendLine('')
$null = $builder.AppendLine('    private static readonly Dictionary<int, string[]> ShopNamesByMerchant = BuildShopNames();')
$null = $builder.AppendLine('')
$null = $builder.AppendLine('    private static Dictionary<int, string[]> BuildShopNames()')
$null = $builder.AppendLine('    {')
$null = $builder.AppendLine('        Dictionary<int, string[]> namesByMerchant = new();')
$null = $builder.AppendLine('')
$null = $builder.AppendLine('        foreach ((int merchantNpcId, ShopPage[] pages) in PagesByMerchant)')
$null = $builder.AppendLine('        {')
$null = $builder.AppendLine('            string[] names = new string[pages.Length];')
$null = $builder.AppendLine('            for (int i = 0; i < pages.Length; i++)')
$null = $builder.AppendLine('            {')
$null = $builder.AppendLine('                names[i] = pages[i].ShopName;')
$null = $builder.AppendLine('            }')
$null = $builder.AppendLine('            namesByMerchant[merchantNpcId] = names;')
$null = $builder.AppendLine('        }')
$null = $builder.AppendLine('')
$null = $builder.AppendLine('        return namesByMerchant;')
$null = $builder.AppendLine('    }')
$null = $builder.AppendLine('')
$null = $builder.AppendLine('    public static IReadOnlyList<string> GetShopNames(int merchantNpcId)')
$null = $builder.AppendLine('    {')
$null = $builder.AppendLine('        return ShopNamesByMerchant.TryGetValue(merchantNpcId, out string[] names)')
$null = $builder.AppendLine('            ? names')
$null = $builder.AppendLine('            : Array.Empty<string>();')
$null = $builder.AppendLine('    }')
$null = $builder.AppendLine('')
$null = $builder.AppendLine('    public static bool TryGetPage(int merchantNpcId, string shopName, out ShopPage page)')
$null = $builder.AppendLine('    {')
$null = $builder.AppendLine('        if (PagesByMerchant.TryGetValue(merchantNpcId, out ShopPage[] pages))')
$null = $builder.AppendLine('        {')
$null = $builder.AppendLine('            for (int i = 0; i < pages.Length; i++)')
$null = $builder.AppendLine('            {')
$null = $builder.AppendLine('                if (pages[i].ShopName == shopName)')
$null = $builder.AppendLine('                {')
$null = $builder.AppendLine('                    page = pages[i];')
$null = $builder.AppendLine('                    return true;')
$null = $builder.AppendLine('                }')
$null = $builder.AppendLine('            }')
$null = $builder.AppendLine('        }')
$null = $builder.AppendLine('')
$null = $builder.AppendLine('        page = default;')
$null = $builder.AppendLine('        return false;')
$null = $builder.AppendLine('    }')
$null = $builder.AppendLine('}')

Set-Content -Path 'Shops/Catalogs/ShopExpandedCatalog.cs' -Value $builder.ToString() -Encoding UTF8

$report = foreach ($merchant in $merchantNpc.Keys)
{
    $pages = $pagesByMerchant[$merchant]
    $items = 0
    foreach ($page in $pages)
    {
        $items += $page.Items.Count
    }

    [pscustomobject]@{
        Merchant = $merchant
        Shops = $pages.Count
        Items = $items
    }
}

$report | Export-Csv -Path '.tmp/expanded_report.csv' -NoTypeInformation
"Generated ShopExpandedCatalog.cs with grouped pages and item-level progression." 
