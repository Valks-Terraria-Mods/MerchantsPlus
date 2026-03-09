# Contributing

- Expanded refs stay in `MerchantsPlus/Shops/Catalogs/`.
- Do **not** hand-edit `ShopExpandedCatalog.cs` — it is generated.

## Regenerate Catalog

```bash
dotnet run --project ../MerchantsPlus.Generator
```

- **Input:** `.tmp/missing_items_integrated_with_stage.csv`
- **Output:** `MerchantsPlus/Shops/Catalogs/ShopExpandedCatalog.cs` — overwritten directly
- Output is fully deterministic.

To change groupings: edit `MerchantsPlus.Generator/ItemClassifier.cs` or `CatalogGenerator.cs`, then regenerate.

## Build

```powershell
dotnet build /p:BuildMod=false
```
