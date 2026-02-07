## About
This mod makes the game easier by adding over 90 unique shops containing NEARLY EVERY ITEM IN TERRARIA spread across all merchants. 

Even the guide, nurse, angler, tax collector and old man are now merchants!

Although not all the items are unlocked at once, you will need to defeat bosses and other types of enemies to progress.

For example, the merchant sells a copper (or tin depending on what kind of world you are in) pickaxe at first. If you defeat the slime king then he will sell a iron pick and a silver pick when you beat the Eye of Cthulhu. He also sells items based on your currently equipped gear. If you have a bow equipped then he will sell you a bow that progresses as you defeat bosses. If you are holding a sword then he will sell a sword and so on.

Progression is not entirely tied to bosses but also world events and even killing say 1000 of a certain enemy.

## Featuring
+ Merchants sell more items based on bosses and enemies defeated
+ Some merchants items get upgraded as you progress
+ Merchants sell items based on what you currently have equipped
+ Items that use to have no sell value now have unique sell values
+ Quests (Quests give you hints on what you need to do to unlock more items) (WIP)
+ Merchants have a chance to drop items on death (enabled by default)
+ All merchants have 300 health (enabled by default)
+ Merchants have slightly reduced sizes (enabled by default)
+ Merchants shoot different projectiles based on bosses defeated (enabled by default)
+ Adds a shop for the NPC from the Magic Storage mod

## FAQ
Q: Is this compatible with other mods?
A: This mod does not touch vanilla shops but rather adds its own additional shops to merchants so it should be fully compatible with other mods

Q: I looked at the source code and the sell prices do not match up with that from script and in game.
A: This is because of the "happiness currency multiplier" that currently cannot be disabled via modding.

Q: My issue is not listed here?
A: Ask for help in https://discord.gg/866cg8yfxZ

## Contributing

This project uses **DLL references** for all dependent mods.

### Getting the mod DLLs

1. Download the latest release of **tModUnpacker**:  
   https://github.com/IVogel/tModUnpacker/releases

2. Extract it and move the required `.tmod` files (for example `CalamityMod.tmod`) into the extracted `tModUnpacker` folder.

3. Open a command prompt in that folder and run: `tModUnpacker.exe CalamityMod.tmod`

This will create a new folder (e.g. `CalamityMod`) containing the dll (e.g. `CalamityMod.dll`).

4. Repeat this for all required mods.

### Setting up references
- Create a folder named `ModAssemblies`
- Place it **one directory above** this project folder
- Copy all extracted mod DLLs into `ModAssemblies`
- Open the `.csproj` file and adjust the `HintPath` entries if you need to

Once all required DLLs are present, the project should compile in Visual Studio without errors.

> [!NOTE]
> These DLLs are **not required** to build the mod in-game.  
> They are only needed when building the project directly in Visual Studio.

You are now ready to start contributing!
