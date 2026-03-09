# MerchantsPlus

A [tModLoader](https://tmodloader.net/) mod for Terraria 1.4 that adds dozens of new shop pages to town merchants. Items unlock gradually as you progress through the game — no cheating the whole catalog at world start.

## Installing

1. Open Terraria with tModLoader installed.
2. Go to **Workshop → Download Mods** and search **MerchantsPlus**.
3. Enable the mod and enter a world.

Or grab it from the [Steam Workshop](https://steamcommunity.com/sharedfiles/filedetails/?id=2790780765).

## What It Does

- Every major town NPC gets expanded shop pages (e.g. Merchant → Ores, Gear, Weapons, Pets, …).
- Pages only appear once you've reached the required progression milestone (e.g. post-Skeletron, post-Hardmode).
- A floating **Shops** button in the HUD lets you browse all world merchants and preview / buy items without talking to them.

## Building From Source

You need the [.NET 8 SDK](https://dotnet.microsoft.com/download) and a tModLoader install.

```
dotnet build MerchantsPlus.csproj /p:BuildMod=false
```

The `/p:BuildMod=false` flag skips full packaging, which can fail when tModLoader has files locked.

## Support

[GitHub Issues](../../issues) · [Discord](https://discord.gg/j8HQZZ76r8)

