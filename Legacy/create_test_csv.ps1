$ErrorActionPreference = 'Stop'

# Creates .tmp/missing_items_integrated_with_stage.csv using only index-based stage
# classification (no recipe data required). This is suitable for comparing the
# PS1 generator with the C# generator.
#
# Items NOT present in the manual/base catalog files (all except ShopExpandedCatalog.cs)
# are emitted as "missing". ShopExpandedCatalog.cs items are intentionally included
# so that the generators have real data to process.

$all = Get-Content TerrariaItemListComplete1.4.5.txt | Where-Object { $_.Trim() }

Write-Host "Total items in list: $($all.Count)"

# Scan only non-expanded base catalogs to find already-covered items.
# ShopExpandedCatalog.cs is explicitly excluded so its items appear as 'missing'
# and get re-placed by the generator (allows proper comparison).
$baseFiles = Get-ChildItem Shops/Catalogs -Filter '*.cs' |
    Where-Object { $_.Name -ne 'ShopExpandedCatalog.cs' }

$coveredItems = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::Ordinal)
foreach ($file in $baseFiles)
{
    $content = Get-Content $file.FullName -Raw
    $matches = [regex]::Matches($content, 'ItemID\.([A-Za-z0-9_]+)')
    foreach ($m in $matches)
    {
        $null = $coveredItems.Add($m.Groups[1].Value)
    }
}

Write-Host "Items covered in base catalogs: $($coveredItems.Count)"

function Get-StageByIndex([int]$idx)
{
    if ($idx -le 366)  { return 0 }
    if ($idx -le 1292) { return 1 }
    if ($idx -le 3466) { return 2 }
    return 3
}

$missing = [System.Collections.Generic.List[pscustomobject]]::new()
for ($i = 0; $i -lt $all.Count; $i++)
{
    $name = $all[$i].Trim()
    if (-not $coveredItems.Contains($name))
    {
        $stage = Get-StageByIndex $i
        $missing.Add([pscustomobject]@{ Name = $name; Id = ($i + 1); Index = $i; Stage = $stage })
    }
}

Write-Host "Missing items (will be in expanded catalog): $($missing.Count)"

New-Item -ItemType Directory -Path .tmp -Force | Out-Null
$missing | Export-Csv -Path '.tmp/missing_items_integrated_with_stage.csv' -NoTypeInformation

Write-Host "Written: .tmp/missing_items_integrated_with_stage.csv"
