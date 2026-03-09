All coding tasks use the **Serena** agent. Full workflow rules (tooling, build, commits, polling) live in `.github/agents/serena.agent.md`.

```yaml
audience: ai_agent
project: MerchantsPlus
repo_type: tModLoader_mod
primary_language: C#
generator_language: PowerShell
last_updated: 2026-02-22
```

## 0) Purpose

This file is an AI-first handoff for this repository.
Assume no prior context.
Use this as the default operational reference before editing code.

## 1) Project Intent

MerchantsPlus expands merchant inventories with progression-gated shops.
The design goal is broad item coverage without front-loading everything at world start.

Key design principles currently in code:
- Expanded item references are catalog-centric.
- Shop visibility is progression-aware (locked-empty pages are hidden).
- Unlock pacing is gradual across progression stages.
- Page size is hard-capped at 40 items.

## 2) Hard Constraints And Owner Preferences

1. Use `ItemID.*` names, never numeric IDs.
2. Max 40 items per shop page.
3. Keep expanded references in catalogs (not spread through runtime shop classes).
4. Keep progression gradual.
5. Prefer coherent grouping, avoid catalog-dump mixes.
6. Use readable shop names with spaces.
7. Do not include raw coin items (`CopperCoin`, `SilverCoin`, `GoldCoin`, `PlatinumCoin`) in expanded coin groupings.
8. Avoid trapped chest variants in expanded generation.
9. Prices are generally handled in shop/runtime logic; do not blindly migrate all pricing into catalogs.
10. Do not hand-edit generated expanded catalog unless emergency hotfix is required.

## 3) Current Repo Layout (Important)

Core runtime:
- `Shops/Shop.cs`
- `Shops/Shop.Opening.cs`
- `Shops/Shop.Visibility.cs`
- `Shops/Shop.Items.cs`
- `Shops/Shop.Progression.cs`

Merchant shop implementations:
- `Shops/Shop*.cs`
- Large classes now split into partials, e.g.:
  - `Shops/ShopMerchant.cs`
  - `Shops/ShopMerchant.CoreShops.cs`
  - `Shops/ShopMerchant.GearSlots.cs`
  - `Shops/ShopMerchant.Weapons.cs`
  - `Shops/ShopGuide.cs`
  - `Shops/ShopGuide.Calamity.cs`
  - `Shops/ShopGuide.Redemption.cs`
  - `Shops/ShopGuide.Thorium.cs`

Catalogs:
- Generated: `Shops/Catalogs/ShopExpandedCatalog.cs`
- Manual/base: `Shops/Catalogs/Shop*Catalog.cs`
- `ShopMerchantCatalog` is partial:
  - `Shops/Catalogs/ShopMerchantCatalog.cs`
  - `Shops/Catalogs/ShopMerchantCatalog.GearProgression.cs`

UI:
- `UI/AddCustomShopUI.cs`
- `UI/ShopUI.cs`
- `UI/ShopUI.Layout.cs`
- `UI/ShopUI.Hints.cs`
- `UI/ShowAllShopsUI.cs`
- `UI/ShowAllShopsUI.Layout.cs`
- `UI/ShowAllShopsUI.Selection.cs`
- `UI/ShowAllShopsUI.Hints.cs`
- `UI/ShowAllShopsUI.Pin.cs`
- `UI/DarkScrollbar.cs`
- `UI/UIEvents.cs`

Player/config/progression:
- `Player.cs`
- `Config.cs`
- `Utils/Progression.cs`

World UI trigger:
- `UI/WorldShopsFloatingButtonUI.cs`

Generator and data:
- `generate_expanded_catalog.ps1`
- `.tmp/generate_expanded_catalog.ps1` (wrapper)
- `classify_missing.ps1`
- `.tmp/missing_items_integrated_with_stage.csv`
- `TerrariaItemListComplete1.4.5.txt`

Docs:
- `README.md`
- `CONTRIBUTING.md`
- `AGENTS.md`

## 4) Build And Run

Primary compile command:
- `dotnet build /p:BuildMod=false`

Why:
- Full packaging can fail when tModLoader locks files.
- `MerchantsPlus.csproj` includes a guard message that explicitly recommends this compile-only mode.

Regenerate expanded catalog:
- `powershell -NoProfile -ExecutionPolicy Bypass -File .\generate_expanded_catalog.ps1`

Classify missing list:
- `powershell -NoProfile -ExecutionPolicy Bypass -File .\classify_missing.ps1`

## 5) Current UI/UX Behavior

### 5.1 Merchant Shop UI (`ShopUI`)

- Opened from `UI/UIEvents.cs` on `GlobalNPC.GetChat` for supported merchants.
- Uses a draggable dark panel.
- Shows merchant label, selected shop label, hint text, and a scrollable list of visible shops.
- Shop list click opens selected shop directly.
- Uses `Shop.GetVisibleShops(...)` so locked-empty pages are not shown.

### 5.2 Browser UIs (`ShowAllShopsUI`)

Two modes exist in same UI class:
- `All Merchant Shops` mode (`_onlyPresentTownMerchants = false`)
- `World Merchant Shops` mode (`_onlyPresentTownMerchants = true`)

World mode filters merchants by:
1. Merchant exists in `ShopUI.Shops`
2. NPC exists in world (`NPC.AnyNPCs(type)`)
3. Has at least one currently visible shop

In world mode, a `Show All Items` button appears only when `DevMode` is enabled.

### 5.3 World browser trigger button

- `UI/WorldShopsFloatingButtonUI.cs`
- Displays a floating `Shops` button near the top-right HUD (left of hearts).
- Clicking `Shops` opens `World Merchant Shops`.
- Hovering the button marks UI interaction (`mouseInterface`) and locks vanilla scroll.

### 5.4 Input and close behavior

- ESC closes all custom UIs in `AddCustomShopUI.UpdateUI`.
- Pointer-over uses `mouseInterface` and scroll-lock via `PlayerInput.LockVanillaMouseScroll(...)`.
- `PlayerHooks.ProcessTriggers` hides merchant `ShopUI` when player is no longer talking to an NPC.
- Pinned talk-NPC logic is used to support remote shop open behavior for world-browser interactions.

## 6) Commands Status

- `Commands/` directory is currently empty.
- No active `ModCommand` implementation is present in source right now.
- `ShowAllShopsUI` functionality exists in UI systems, but there is currently no command-bound entry point in code.

## 7) Config Semantics (Current)

`Config.cs` (server-side):
- `DevMode` (bool)
- `ShowAllItems` (hidden bool)
- `UnlockAllItems` (computed, hidden):
  - `ForceUnlockAllItems || (DevMode && ShowAllItems)`

Important:
- If `DevMode` is disabled, `ShowAllItems` is automatically reset to `false`.

## 8) Progression System (Current)

`Utils/Progression.cs` now uses enums instead of magic numbers:
- `Progression.FullLevel` (`0..21`)
- `Progression.BossLevel` (`0..14`)

Still exposes int-compatible APIs for existing callsites:
- `LevelFull()`
- `LevelBoss()`
- `GetLevelFullUnlockHint(int)`

Preview helper used by UI snapshotting:
- `PushPreviewLevelOverride(int level)`

## 9) Shop Framework Details

`Shop` base behavior:
- `BuildShopList` merges base tabs with generated expanded tabs.
- `OpenExpandedShop` opens expanded pages with progression gating unless `UnlockAllItems` is true.
- `GetVisibleShops` hides expanded pages with zero visible items.
- `EnsureMinimumSellPrice` applies 1 copper only when item has no value and no custom price is set.
- `OpenShopForNpcType` supports opening shop contexts for NPC type even when player is not physically near that NPC.

`ShopExpandedOnly` exists for merchants that only have expanded content.

## 10) Expanded Catalog Generator Pipeline

Source script:
- `generate_expanded_catalog.ps1`

### 10.1 Input
- Reads `.tmp/missing_items_integrated_with_stage.csv`, sorted by `Index`.
- Injects fallback rows if missing:
  - `FireworkFountain`
  - `BoosterTrack`

### 10.2 Normalization and filtering
- Replacement map currently includes:
  - `OgreMask -> RobotMask`
  - `GoblinMask -> UnicornMask`
  - `SkeletonBow -> Marrow`
- Excludes:
  - `Trapped` matches
  - `Fake_` matches
  - disallowed luminite tool variants
  - merge-to-native seed/plant items list
  - raw coin items

### 10.3 Grouping
- `Get-ShopInfo` maps item name patterns to `Merchant + Shop`.
- Includes dedicated groupings for keys, clocks, tombstones, quest fish, treasure bags, tools, furniture families, paints/vanity, etc.
- `Alpha*Statue` style mapping currently uses the string `Alphanumeric Status` (intentional current spelling).

### 10.4 Furniture redistribution
- Furniture shops are reassigned to slime merchants (whole-shop reassignment, not random per item).
- Target slimes:
  - `NerdySlime`, `CoolSlime`, `ElderSlime`, `ClumsySlime`, `DivaSlime`, `SurlySlime`, `MysticSlime`
- Reserved banner slime:
  - `SquireSlime` (banner-only)

### 10.5 Pagination and names
- `pageSize = 40`
- Max shop name length: `24` (`$maxShopNameLength`)
- Overflow suffixes: `Core`, `Plus`, `Prime`, etc.

### 10.6 Manual pages and small-shop redistribution
- Manual pages are injected for:
  - `Cat Kit`
  - `Dog Kit`
  - `Bunny Kit`
- Small shops (`<= 5` items) are removed for non-slime merchants (except `Cat`, `Dog`, `Bunny`) and items are redistributed to random slime shops (`Slime Finds*`).

Important caveat:
- Small-shop redistribution currently uses `Get-Random`, so composition can vary run-to-run.

### 10.7 Assertions (generation fails if violated)
- Duplicate shop names per merchant
- Any page > 40 items
- `Explosives*` contains `Minecart` or `Powder`
- `Ores*` contains `ShroomiteBar` or `SpectreBar`
- `Ranged*` contains forbidden misgrouped patterns
- `Bait`, `Fishing Misc`, `Food Plus` pages still exist
- Banner-only slime has non-banner pages
- `Coins*` contains raw coin items
- `Treasure Bags*` contains `BossBagOgre` or `BossBagDarkMage`
- `Mounts*` contains known non-mount junk patterns

## 11) Known Current Snapshot

- Expanded generated entries: `3801` (`new(ItemID.*)` rows in `ShopExpandedCatalog.cs`).
- `ShopMerchantCatalog` split into partials.
- `Shop`, `ShopUI`, `ShowAllShopsUI`, `ShopMerchant`, and `ShopGuide` are split into partial files.

## 12) Practical Edit Strategy

For expanded grouping/content changes:
1. Edit `generate_expanded_catalog.ps1`.
2. Regenerate `ShopExpandedCatalog.cs`.
3. Compile with `dotnet build /p:BuildMod=false`.
4. Spot-check target shops in-game.

For runtime/UI behavior changes:
1. Edit relevant partial files.
2. Keep behavior-compatible refactors unless explicitly changing behavior.
3. Compile with `dotnet build /p:BuildMod=false`.

## 13) Useful Local Queries

Count expanded entries:
- `Select-String -Path Shops/Catalogs/ShopExpandedCatalog.cs -Pattern 'new\(ItemID\.' | Measure-Object`

Find progression hint and preview callsites:
- `rg -n "PushPreviewLevelOverride|GetLevelFullUnlockHint|LevelFull\(" -S`

Find UI entry points:
- `rg -n "ShowWorldShopsUI|ShowShowAllShopsUI|GetChat\(" -S`

## 14) Watch Items / Risks

1. Grouping regex order in generator is precedence-sensitive.
2. Overflow name generation can collide if changed carelessly.
3. Random slime redistribution can cause non-deterministic diffs.
4. `Shop.Opening` relies on `Main.SetNPCShopIndex(1)`; changing this has historically caused crashes/null refs.
5. Keep generated and manual catalog responsibilities separated.
