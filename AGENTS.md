# AGENTS.md

```yaml
audience: ai_agent
project: MerchantsPlus
repo_type: tModLoader_mod
primary_language: C#
generator_language: PowerShell
last_known_state_date: 2026-02-22
```

## 0) Why This File Exists

This file is an AI-first handoff.
Assume you know nothing before reading this.
Use this as the canonical orientation and execution guide for this repo.

## 1) Project Intent

MerchantsPlus expands Terraria merchant inventories with progression-gated shops.
The goal is broad item coverage without dumping everything at game start.
Expanded item references are centralized in catalog classes, especially:
- `Shops/Catalogs/ShopExpandedCatalog.cs` (generated)
- Other `Shops/Catalogs/Shop*Catalog.cs` files (manual/base catalogs)

## 2) Hard Constraints And Owner Preferences

1. Use `ItemID.*` names, never raw numeric IDs.
2. Max 40 items per page.
3. Keep item references in catalogs.
4. Keep progression gating gradual.
5. Avoid mixed-category dump shops.
6. Use concise, readable shop names with spaces.
7. Prices are not generally migrated to catalogs from base shop logic.
8. Do not sell raw coin items (`CopperCoin`, `SilverCoin`, `GoldCoin`, `PlatinumCoin`) in expanded coin grouping.
9. Avoid trapped chest variants (`Trapped` items filtered in generator).
10. Do not run unnecessary git validation commands for normal content tasks.

## 3) Repo Layout (Important Files)

- `generate_expanded_catalog.ps1`
  - Main source of truth for expanded shop grouping and generation.
- `.tmp/generate_expanded_catalog.ps1`
  - Wrapper that invokes root generator.
- `Shops/Catalogs/ShopExpandedCatalog.cs`
  - Generated output. Do not hand-edit unless emergency hotfix.
- `Shops/Shop*.cs`
  - Shop open/wiring behavior. Base/non-expanded logic.
- `Shops/Shop.cs`
  - Shared shop framework and expansion handling.
- `UI/ShopUI.cs`
  - In-game merchant shop strip and cycle behavior.
- `UI/ShowAllShopsUI.cs`
  - All-shops browser UI (also reused for world-merchant browser mode).
- `UI/AddCustomShopUI.cs`
  - UI system host and visibility toggles.
- `UI/DarkScrollbar.cs`
  - Custom dark-styled scrollbar for browser UI.
- `Commands/ShowAllShopsCommand.cs`
  - `/showallshops` command.
- `Items/WorldShopCatalogItem.cs`
  - Craftable item that opens world-merchant shop browser.
- `Config.cs`
  - Server-side config, includes `UnlockAllItems`.
- `Player.cs`
  - UI hide behavior when not talking to NPCs.
- `TerrariaItemListComplete1.4.5.txt`
  - Master item list reference.
- `.tmp/missing_items_integrated_with_stage.csv`
  - Generator input dataset (stage-indexed).
- `CONTRIBUTING.md`
  - Human-focused contribution quick guide.

## 4) Build And Run Commands

Primary compile command:
- `dotnet build /p:BuildMod=false`

Why:
- Repo has a `RequireTModLoaderTargets` guard in `MerchantsPlus.csproj`.
- Full packaging can fail when tModLoader locks files.
- Compile-only is the safe default during active development.

Regenerate expanded catalog:
- `powershell -NoProfile -ExecutionPolicy Bypass -File .\generate_expanded_catalog.ps1`

## 5) Expanded Catalog Pipeline

### 5.1 Input

- Reads `.tmp/missing_items_integrated_with_stage.csv`, sorted by `Index`.
- Injects extra fallback rows:
  - `FireworkFountain`
  - `BoosterTrack`

### 5.2 Filtering/Normalization

- Renames selected conflicts:
  - `OgreMask -> RobotMask`
  - `GoblinMask -> UnicornMask`
  - `SkeletonBow -> Marrow`
- Excludes:
  - `Trapped` pattern
  - `Fake_` pattern
  - Some disallowed luminite tool variants
  - Merge-to-native items list
  - Raw coins (`CopperCoin`, `SilverCoin`, `GoldCoin`, `PlatinumCoin`)

### 5.3 Grouping

`Get-ShopInfo` routes each item to `Merchant + Shop`.
Grouping now includes dedicated categories for:
- Keys
- Clocks
- Fences
- Campfires
- Pickaxes
- Hammers
- Drills and Saws
- Axes
- Quest Fish
- Tombstones
- Treasure Bags
- Furniture families (chairs/tables/etc.)

### 5.4 Furniture Redistribution

Furniture groups are redistributed to slime merchants deterministically.
Algorithm:
- Detect furniture shop names by pattern.
- Assign each furniture shop (whole shop, not random item split) to the least-loaded target slime.
- Keep furniture shop names and items intact.

Current targets for furniture balancing:
- `NerdySlime`
- `CoolSlime`
- `ElderSlime`
- `ClumsySlime`
- `DivaSlime`
- `SurlySlime`
- `MysticSlime`

Reserved slime:
- `SquireSlime` is banner-only.

### 5.5 Pagination And Naming

- Page size: 40
- Overflow suffixes: `Core`, `Plus`, `Prime`, etc.
- Max shop name length in generator: 24 (`$maxShopNameLength`)

### 5.6 Small Shop Handling

For non-slime merchants (except Cat/Dog/Bunny exemptions):
- Shops with item count `<= 5` are removed.
- Items are redistributed to slime shops (`Slime Finds*`) via random slime target.

### 5.7 Assertions

Generation fails if:
1. Duplicate shop names for same merchant.
2. Any shop has more than 40 items.
3. Explosives contains `Minecart` or `Powder`.
4. Ores contains `ShroomiteBar` or `SpectreBar`.
5. Ranged contains forbidden misgrouped patterns.
6. Any `Bait`, `Fishing Misc`, `Food Plus` pages still exist.
7. Banner-only slime has non-banner shop.
8. `Coins*` contains raw coin items.
9. `Treasure Bags*` contains `BossBagOgre` or `BossBagDarkMage`.
10. `Mounts*` contains known non-mount junk patterns.

## 6) Current Curated Decisions (Critical)

1. `Alpha Statues` renamed to `Alphanumeric Status` (intentional string).
2. `Biome Toilets` merged into `Toilets`.
3. `FishHook` moved out of fish pages to Goblin `Hooks`.
4. `SharkFin` moved to Merchant `Materials`.
5. `Goldfish` and `FishBowl` moved to Bunny `Critter Care`.
6. `BossBagOgre` and `BossBagDarkMage` are not in `Treasure Bags`; they route to Tavernkeep (`Eternia Gear`).
7. `Mounts` no longer includes obvious non-mount food/junk apples.
8. Banners moved from Stylist to `SquireSlime` only.

## 7) UI/UX Architecture

### 7.1 Shop Strip UI

- File: `UI/ShopUI.cs`
- Shows merchant name, current shop, and `Cycle Shop`.
- Uses visible-shop filtering (`Shop.GetVisibleShops`) so locked empty expanded pages are hidden.

### 7.2 All Shops Browser

- File: `UI/ShowAllShopsUI.cs`
- Command opens this: `/showallshops`
- Dark/semi-transparent styling.
- Uses `DarkScrollbar`.
- Clicking a shop opens it directly.
- Input is blocked while hovering panel:
  - `Main.LocalPlayer.mouseInterface = true`
  - `Main.blockInput = true`
  - `PlayerInput.LockVanillaMouseScroll(...)`

### 7.3 World Merchant Browser (Craft Trigger)

- Same UI class with mode flag:
  - `new ShowAllShopsUI(true, "World Merchant Shops")`
- Only includes merchants that:
  1. Are in `ShopUI.Shops`
  2. Are town NPC types
  3. Exist in the world (`NPC.AnyNPCs(type)`)

- Trigger item:
  - `Items/WorldShopCatalogItem.cs`
  - Recipe: 5 wood
  - Opens world browser when crafted and when used.

### 7.4 UI Host

- File: `UI/AddCustomShopUI.cs`
- Manages three UIs:
  - regular shop strip
  - all-shops browser
  - world-merchants browser

## 8) Command And Permission Logic

`/showallshops` command:
- File: `Commands/ShowAllShopsCommand.cs`
- Singleplayer: allowed.
- Multiplayer: host/admin-like allowed using reflection-based checks.
- Command toggles all-shops browser.

## 9) Shop Framework Notes

File: `Shops/Shop.cs`

Important behavior:
- `BuildShopList` merges base shop tabs with expanded catalog tabs.
- `OpenExpandedShop` respects progression unless `Config.UnlockAllItems == true`.
- `GetVisibleShops` hides expanded pages with zero currently unlocked items.
- `EnsureMinimumSellPrice` sets 1 copper if item has no value and no explicit custom price.
- `OpenShopForNpcType` supports opening context shops when player is not near selected NPC (used by browser UI).

## 10) Config Flags

File: `Config.cs` (server-side)

Includes:
- `UnlockAllItems` (bool): ignores gated progression for expanded pages.
- Other toggles for happiness multiplier, drops, scaling, projectiles, etc.

## 11) Practical Edit Strategy (Do This)

When changing expanded grouping:
1. Edit `generate_expanded_catalog.ps1`.
2. Regenerate catalog.
3. Build compile-only.
4. Spot-check target shops with script queries.

Do not start by hand-editing `ShopExpandedCatalog.cs`.

## 12) Useful Local Queries

Regenerate:
- `powershell -NoProfile -ExecutionPolicy Bypass -File .\generate_expanded_catalog.ps1`

Build:
- `dotnet build /p:BuildMod=false`

Count expanded `new(ItemID.*)` entries:
- `Select-String -Path Shops/Catalogs/ShopExpandedCatalog.cs -Pattern 'new\\(ItemID\\.' | Measure-Object`

## 13) Current Snapshot (Last Known)

- Expanded entries (generated): 3801 item rows.
- Banner pages:
  - `TownSlimeCopper`: `Banners Core`, `Banners Plus`
- Angler pages:
  - `Fish Core`, `Fish Plus`, `Fish Gear`, `Quest Fish`, `Crates`, `Critter Decor`
- Food pages:
  - `PartyGirl`: `Food and Drink`
  - `Tavernkeep`: `Bar Drinks`
- Toilets:
  - consolidated `Toilets` page
- Tool subshops:
  - `Golfer`: `Pickaxes`, `Hammers`, `Drills and Saws`, `Axes`, `Fences`, `Campfires`

## 14) Known Risks / Watch Items

1. Regex grouping order matters. Earlier matches override later matches.
2. New mappings can accidentally create duplicate shop names when overflow suffixes collide.
3. Changing max name length can affect UI fit and suffix generation.
4. Random slime redistribution for tiny shops can change composition run-to-run.
5. If category changes are requested, update assertions too, not only mappings.

## 15) AI Operation Rules For This Repo

1. Keep context in catalogs.
2. Keep progression intact unless explicitly asked to flatten.
3. Prefer generator-level fixes for expanded content.
4. Prefer deterministic regrouping over manual scatter.
5. Keep all changes compile-safe with `dotnet build /p:BuildMod=false`.

## 16) Provenance

AI tooling (including OpenAI Codex) has been used in this repository.
Treat this as assistive automation, not authoritative design truth.
Always re-validate against owner intent and latest prompt.
