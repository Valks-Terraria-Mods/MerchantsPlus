# Contributing

## Scope And Source Of Truth

- Keep item definitions in catalog classes:
  - `Shops/Catalogs/Shop*Catalog.cs`
  - `Shops/Catalogs/ShopExpandedCatalog.cs`
- `Shops/Shop*.cs` should mainly handle shop wiring/open logic, not large item lists.

## Required Conventions

- Use `ItemID.*` names, not numeric IDs.
- Keep each shop page at `<= 40` items.
- Keep progression gating in catalog/shop progression data.
- Avoid duplicate item entries across shops unless intentional.

## Contributor Scripts

These scripts are now in the repository root:

- `generate_expanded_catalog.ps1`
  - Generates `Shops/Catalogs/ShopExpandedCatalog.cs`.
  - Uses input and support data in `.tmp/` (for example `.tmp/missing_items_integrated_with_stage.csv`).
- `classify_missing.ps1`
  - Classifies missing items by progression stage into `.tmp/missing_classified.csv`.

Compatibility wrappers remain in `.tmp/` so older local workflows still work.

## Typical Workflow

1. Update source data (usually `.tmp/missing_items_integrated_with_stage.csv`).
2. Run catalog generation:
   - `powershell -ExecutionPolicy Bypass -File .\generate_expanded_catalog.ps1`
3. Build compile-only:
   - `dotnet build /p:BuildMod=false`
4. Review generated shop grouping/progression and adjust as needed.

## Build Notes

- If `tModLoader` is running, full mod packaging builds can fail due to a locked `.tmod` file.
- Use compile-only build while the game is open:
  - `dotnet build /p:BuildMod=false`

## AI Assistance Disclosure

This project has used AI-assisted coding tools, including OpenAI Codex, for parts of implementation and refactoring. Human review is still required for all contributions.
