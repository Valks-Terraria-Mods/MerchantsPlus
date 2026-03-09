# Contributing

This document describes the current contribution workflow and conventions for MerchantsPlus.

## Core Rules

- Use `ItemID.*` names, never raw numeric IDs.
- Keep shop pages at `<= 40` items.
- Keep expanded item references in catalog classes.
- Keep progression unlocks gradual.
- Avoid duplicate entries unless explicitly intentional.
- Do not include raw coin items (`CopperCoin`, `SilverCoin`, `GoldCoin`, `PlatinumCoin`) in expanded coin groupings.
- Avoid trapped chest variants in expanded grouping.

## Source Of Truth

- Generated expanded catalog:
  - `Shops/Catalogs/ShopExpandedCatalog.cs`
- Manual/base catalogs:
  - `Shops/Catalogs/Shop*Catalog.cs`
- Runtime/wiring logic:
  - `Shops/Shop*.cs`
  - `UI/*.cs`

Do not start by hand-editing `ShopExpandedCatalog.cs`.

## Recommended Workflow

1. Update grouping/classification inputs.
2. Regenerate expanded catalog.
3. Compile with `BuildMod=false`.
4. Spot-check affected shops/UI behavior in-game.

## Scripts

- `generate_expanded_catalog.ps1`
  - Main generator for `Shops/Catalogs/ShopExpandedCatalog.cs`.
- `.tmp/generate_expanded_catalog.ps1`
  - Wrapper for legacy local workflows.
- `classify_missing.ps1`
  - Produces `.tmp/missing_classified.csv` from item list + local terraria-info JSON.

### Typical regenerate command

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File .\generate_expanded_catalog.ps1
```

## Build

Use compile-only build during normal development:

```powershell
dotnet build /p:BuildMod=false
```

Why:

- Full packaging can fail if tModLoader locks `.tmod` outputs.
- The project includes a guard message in `MerchantsPlus.csproj` recommending compile-only mode.

## Important Implementation Notes

- `Shops/Shop.cs` is split into partial files (`Shop.Opening`, `Shop.Visibility`, `Shop.Items`, `Shop.Progression`).
- `UI/ShowAllShopsUI.cs` and `UI/ShopUI.cs` are split into partial files for layout, selection, hinting, and pin/state logic.
- `ShopMerchant` and `ShopGuide` are split into partial files by concern.
- `ShopMerchantCatalog` is partial with progression/gear mapping split into `ShopMerchantCatalog.GearProgression.cs`.

Keep new changes consistent with this organization.

## Validation Checklist

- Builds with `dotnet build /p:BuildMod=false`.
- No page exceeds 40 items.
- No duplicate shop names per merchant.
- Shop visibility/hints remain progression-accurate.
- Expanded references remain catalog-centered.

## About `.tmp`

`.tmp/` is ignored by git in this repo.

Use it for local/generated data inputs and reports such as:

- `.tmp/missing_items_integrated_with_stage.csv`
- `.tmp/missing_classified.csv`
- `.tmp/expanded_report.csv`
