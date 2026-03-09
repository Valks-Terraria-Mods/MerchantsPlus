All coding tasks use the **Serena** agent. Full workflow rules (tooling, build, commits, polling) live in `.github/agents/serena.agent.md`.

```yaml
audience: ai_agent
project: MerchantsPlus
repo_type: tModLoader_mod
primary_language: C#
generator_language: C#
last_updated: 2026-05-31
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

## 3) Current Repo Layout

### Core runtime
- `Shops/Shop.cs`
- `Shops/Shop.Opening.cs`
- `Shops/Shop.Visibility.cs`
- `Shops/Shop.Items.cs`
- `Shops/Shop.Progression.cs`

### Merchant shop implementations (partial classes)
- `Shops/ShopMerchant.cs` + `ShopMerchant.CoreShops.cs` / `.GearSlots.cs` / `.Weapons.cs`
- `Shops/ShopGuide.cs` + `ShopGuide.Calamity.cs` / `.Redemption.cs` / `.Thorium.cs`
- Other merchants: `ShopAngler`, `ShopArmsDealer`, `ShopClothier`, `ShopCyborg`, ...

### Catalogs
- Generated: `Shops/Catalogs/ShopExpandedCatalog.cs` — **do not hand-edit**
- Manual/base: `Shops/Catalogs/Shop*Catalog.cs`
- `ShopMerchantCatalog` is partial:
  - `Shops/Catalogs/ShopMerchantCatalog.cs`
  - `Shops/Catalogs/ShopMerchantCatalog.GearProgression.cs`

### UI (partial classes where noted)
- `UI/AddCustomShopUI.cs` — top-level UI controller for all custom UIs
- `UI/ShopUI.cs` + `.Layout.cs` + `.Hints.cs` — merchant-talk shop picker panel
- `UI/ShowAllShopsUI.cs` + `.Layout.cs` + `.Hints.cs` + `.Selection.cs` + `.Pin.cs` + `.Preview.cs`
- `UI/WorldShopsFloatingButtonUI.cs` — HUD "Shops" button
- `UI/DevProgressionSlider.cs` — draggable slider widget (DevMode only)
- `UI/DarkScrollbar.cs`, `UI/DraggableUIPanel.cs`, `UI/TextButton.cs`, `UI/UIHoverImageButton.cs`
- `UI/UIUtils.cs`, `UI/UIEvents.cs`
- `UI/VanillaItemSlotWrapper.cs`, `UI/WorldShopPreviewSlot.cs`
- `UI/WorldShopSession.cs` — tracks pinned NPC / world shop open state
- `UI/WorldShopTalkGuard.cs` — guards against stale talk-NPC state
- `UI/WorldShopPurchaseDiagnostics.cs` — dev diagnostics for shop purchases
- `UI/ShopUnlockAsteriskTracker.cs` — new-unlock asterisk logic
- `UI/ShopUnlockAsteriskWorldData.cs` — world-persistent acknowledged counts
- `UI/DebugPanelUI.cs` — debug overlay (if enabled)

### Player / Config / Progression
- `Player.cs`
- `Config.cs`
- `Utils/Progression.cs`

### Utils
- `Utils/ShopUnlockAsteriskProgressionWatcher.cs` — clears asterisk dynamic cache on progression change
- `Utils/ShopOpenDiagnostics.cs` — ShopDiag log entries in client.log
- `Utils/PlayerUtils.cs`, `Utils/WorldUtils.cs`, `Utils/OtherMods.cs`
- `Utils/ClassItemSet.cs`, `Utils/PlayerClass.cs`
- `Utils/Coins.cs`, `Utils/ItemCosts.cs`

### Generator and data
- `.tmp/missing_items_integrated_with_stage.csv` — **committed, do not regenerate unless needed**

### Generator (`MerchantsPlus.Generator/`)
- `MerchantsPlus.Generator.csproj`, `Program.cs`, `CatalogGenerator.cs`, `ItemClassifier.cs`, `Models.cs`
- `Legacy/classify_missing.ps1` — generates the input CSV (only needed for Terraria updates)
- `Legacy/TerrariaItemListComplete1.4.5.txt`

### Docs
- `README.md`, `CONTRIBUTING.md`, `AGENTS.md`

## 4) Build And Run

**Primary compile command:**
```
dotnet build MerchantsPlus.csproj /p:BuildMod=false
```
(Run from `MerchantsPlus/` mod sources root — or specify project path explicitly.)

Why `/p:BuildMod=false`: Full packaging can fail when tModLoader locks files.

**Regenerate expanded catalog** (run from `MerchantsPlus/` mod root):
```
dotnet run --project ../MerchantsPlus.Generator
```
See `MerchantsPlus.Generator/README.md` for full details.

**Classify missing items** (legacy, only needed when Terraria updates):
```
powershell -NoProfile -ExecutionPolicy Bypass -File ../MerchantsPlus.Generator/Legacy/classify_missing.ps1
```

**Client log location (Linux):**
```
/home/valk/.local/share/Steam/steamapps/common/tModLoader/tModLoader-Logs/client.log
```
Note: If the game crashes without a visible exception in the log, suspect a stack overflow (no catch clause captures it). Check for recursive call chains through `Update`/`Draw` paths.

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

World mode additionally shows:
- **DevMode Progression Slider panel** (above main panel): slider 0–21 drives `Progression.SetPreviewLevelOverride`. Overrides are cleared on UI close (`OnDeactivate`). Panel is hidden when DevMode is off.
- **Preview panel** (right side): shows items for the selected shop with purchase support and coin balance footer.

The old `Show All Items` toggle button was removed. `Config.ShowAllItems` is now always reset to `false` in `ApplyDevModeRules()`.

### 5.3 DevMode Progression Slider

- Implemented via `DevProgressionSlider.cs` + fields in `ShowAllShopsUI.cs`.
- Slider range 0..21 (matches `Progression.FullLevel` enum).
- `_lastDevProgLevel` (static) persists position across UI reopens within same mod session.
- **Drag throttle**: while dragging → only `InvalidateCaches`; on drag-end → full `Refresh()`.
- **Critical**: `_wasProgSliderDragging` is updated BEFORE calling `Refresh()` to prevent infinite recursion. Never move that assignment after the `if (dragJustEnded)` call.
- Money buttons (`+10G`, `+1P`, `+10P`, `+100P`) use `QuickSpawnItem` to drop coins at player feet.

### 5.4 World browser trigger button

- `UI/WorldShopsFloatingButtonUI.cs`
- Displays a floating `Shops` button near the top-right HUD.
- Clicking opens `World Merchant Shops`.

### 5.5 Input and close behavior

- ESC closes all custom UIs in `AddCustomShopUI.UpdateUI`.
- Pointer-over uses `mouseInterface` and `PlayerInput.LockVanillaMouseScroll(...)`.
- `PlayerHooks.ProcessTriggers` hides merchant `ShopUI` when not talking to NPC.
- Pinned talk-NPC logic (`WorldShopSession`, `WorldShopTalkGuard`) supports remote shop opens.

## 6) Commands Status

- `Commands/` directory is currently empty.
- No active `ModCommand` implementation.

## 7) Config Semantics (Current)

`Config.cs` (server-side):
- `DevMode` (bool)
- `ShowAllItems` (hidden bool) — **always reset to false** in `ApplyDevModeRules()`. There is no longer a toggle button. Do not add logic that reads `ShowAllItems` as a user-controllable flag.
- `UnlockAllItems` (computed, hidden):
  - `ForceUnlockAllItems || (DevMode && ShowAllItems)`

Important:
- `UnlockAllItems = true` bypasses ALL progression checks everywhere. This is a known pitfall — if `ShowAllItems` somehow remains `true` from an old save, every shop shows all items regardless of slider/world state.

## 8) Progression System (Current)

`Utils/Progression.cs` uses enums:
- `Progression.FullLevel` (0..21)
- `Progression.BossLevel` (0..14)

Exposes int-compatible APIs:
- `LevelFull()` — returns current or preview-overridden level
- `LevelBoss()`
- `GetLevelFullUnlockHint(int)`

Preview helpers:
- `PushPreviewLevelOverride(int level)` — scoped push, restores on Dispose (used by hint snapshots)
- `SetPreviewLevelOverride(int? level)` — direct persistent set/clear (used by DevMode slider)

**Pitfall**: If `Config.UnlockAllItems == true`, all progression checks are bypassed and asterisk trackers return `-1` (suppress badges). Always verify this is false before debugging progression-related display issues.

## 9) Shop Framework Details

`Shop` base behavior:
- `BuildShopList` merges base tabs with generated expanded tabs.
- `OpenExpandedShop` gates progression unless `UnlockAllItems` is true.
- `GetVisibleShops` hides expanded pages with zero visible items.
- `EnsureMinimumSellPrice` applies 1 copper when item has no value and no custom price.
- `OpenShopForNpcType` opens shop contexts without player proximity.

`ShopExpandedOnly` exists for merchants with only expanded content.

## 10) Asterisk (New-Unlock Badge) System

`ShopUnlockAsteriskTracker` — static class:
- `HasUnseenUnlocks(merchantId, shopName)` → true if new items visible since last acknowledgment.
- `AcknowledgeShop(merchantId, shopName)` — call when player views a shop.
- `AcknowledgeShops(merchantId, IEnumerable<string>)` — bulk acknowledge.
- `NotifyProgressionChanged()` — call when world progression changes; clears dynamic count cache.

`ShopUnlockAsteriskWorldData` (ModSystem):
- Stores `AcknowledgedCounts` as a `static Dictionary<(int MerchantId, string ShopName), int>`.
- **OnWorldUnload** clears the dict (was previously OnWorldLoad — that was a bug that wiped data after LoadWorldData was called).
- `LoadWorldData` always clears then repopulates.

`ShopUnlockAsteriskProgressionWatcher` (ModSystem):
- `PostUpdateWorld()` fires `NotifyProgressionChanged()` when `Progression.LevelFull()` changes.

**Known pitfall**: `_dynamicUnlockedCountCache` is static and not cleared between worlds if progression level doesn't change. TTL is 45 ticks, so stale reads are short-lived.

## 11) Coin Balance Display (Preview Panel Footer)

`DrawPreviewCoinBalance` in `ShowAllShopsUI.Preview.cs`:
- Only renders **non-zero** denominations. Copper is always shown as fallback when all are zero.
- Matches `BuildPriceSegments` filtering logic.
- Do not revert to always-showing all 4 denominations — that makes zero amounts render as nearly invisible sprites.

`GetPlayerCoinTotal` sums all coin items by denomination and returns total in copper. The method does NOT divide into display amounts — that's done at the callsite.

## 12) Expanded Catalog Generator Pipeline

### 12.1 Input
- Source: `.tmp/missing_items_integrated_with_stage.csv`, sorted by `Index`.
- The CSV is committed to the repo. You do NOT need to regenerate it for normal changes.
- Only regenerate if: new Terraria version, bulk stage reclassification, or adding new item categories.
- Fallback rows injected if missing: `FireworkFountain`, `BoosterTrack`.

### 12.2 Normalization and filtering
- Replacement map: `OgreMask→RobotMask`, `GoblinMask→UnicornMask`, `SkeletonBow→Marrow`
- Excludes: `Trapped` matches, `Fake_` matches, disallowed luminite tool variants, merge-to-native seeds/plants, raw coin items.

### 12.3 Grouping
- `Get-ShopInfo` maps item name patterns to `Merchant + Shop`.
- Groupings include keys, clocks, tombstones, quest fish, treasure bags, tools, furniture families, paints/vanity, etc.
- `Alpha*Statue` style mapping uses `Alphanumeric Status` (intentional current spelling).

### 12.4 Furniture redistribution
- Furniture shops reassigned to slime merchants (whole-shop, not per-item).
- Target slimes: `NerdySlime`, `CoolSlime`, `ElderSlime`, `ClumsySlime`, `DivaSlime`, `SurlySlime`, `MysticSlime`
- Banner-only slime: `SquireSlime`

### 12.5 Pagination and names
- `pageSize = 40`
- Max shop name length: 24 chars
- Overflow suffixes: `Core`, `Plus`, `Prime`, etc.

### 12.6 Manual pages and small-shop redistribution
- Manual pages: `Cat Kit`, `Dog Kit`, `Bunny Kit`
- Small shops (`≤ 5` items) for non-slime, non-Cat/Dog/Bunny merchants → redistributed to `Slime Finds*` (random, non-deterministic run-to-run).

### 12.7 Generator assertions (fail-fast)
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

## 13) Known Current Snapshot

- Expanded generated entries: ~3801 (`new(ItemID.*)` rows in `ShopExpandedCatalog.cs`).
- `ShopMerchantCatalog` is partial.
- `Shop`, `ShopUI`, `ShowAllShopsUI`, `ShopMerchant`, `ShopGuide` are split into partial files.
- No active `ModCommand` entry points.

## 14) Practical Edit Strategy

**For expanded catalog changes:**
1. Edit `MerchantsPlus.Generator/ItemClassifier.cs` (groupings / shop assignments) or `CatalogGenerator.cs` (pipeline rules).
2. Regenerate (from `MerchantsPlus/` mod root): `dotnet run --project ../MerchantsPlus.Generator`
3. Compile. Spot-check in-game.

**For runtime/UI behavior changes:**
1. Edit relevant partial files.
2. Compile with `dotnet build MerchantsPlus.csproj /p:BuildMod=false`.
3. Verify 0 errors and 0 warnings.

## 15) Useful Local Queries

```
# Count expanded entries
Select-String -Path Shops/Catalogs/ShopExpandedCatalog.cs -Pattern 'new\(ItemID\.' | Measure-Object

# Find progression callsites
rg -n "PushPreviewLevelOverride|SetPreviewLevelOverride|GetLevelFullUnlockHint|LevelFull\(" -S

# Find UI entry points
rg -n "ShowWorldShopsUI|ShowShowAllShopsUI|GetChat\(" -S

# Find asterisk tracker callsites
rg -n "ShopUnlockAsteriskTracker" -S
```

## 16) Watch Items / Risks

1. **Slider drag infinite recursion**: `UpdateDevProgPanel()` calls `Refresh()` on drag-end. If `_wasProgSliderDragging` is set AFTER `Refresh()`, re-entry fires `Refresh()` again → stack overflow crash. Always update `_wasProgSliderDragging` before calling `Refresh()`.
2. **UnlockAllItems ghost state**: If `Config.ShowAllItems` is ever left `true` in a saved config, ALL progression gates are bypassed. `ApplyDevModeRules()` must always reset it to `false`.
3. **Asterisk wipe bug pattern**: If you add a `OnWorldLoad` that clears persistent state, but `LoadWorldData` fills it first, the clear wipes the loaded data. Use `OnWorldUnload` to clear instead.
4. **Grouping regex order**: Generator `Get-ShopInfo` is precedence-sensitive. Earlier patterns win.
5. **Overflow name collisions**: Overflow suffix generation can collide if naming logic is changed carelessly.
6. **Random slime redistribution**: Non-deterministic diffs across generator runs.
7. **`Shop.Opening` relies on `Main.SetNPCShopIndex(1)`**: Changing this has historically caused crashes/null refs.
8. **`ShopDiag` log spam**: If you see thousands of `[ShopDiag]` entries in client.log at high rates (60+/s), a cache is being invalidated too aggressively (likely from UI update loops).
9. **`ShouldIncludeMerchant` stability**: When the DevMode progression panel is active (`_devProgPanelActive`), always return `true` early for world-present NPCs — do not let a changing progression level filter merchants in/out during the same UI session, or the merchant list will shuffle on every slider tick.
10. **`EntitySource_DebugCommand` requires a string arg**: `new EntitySource_DebugCommand("context")` — does not have a parameterless constructor.

