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
