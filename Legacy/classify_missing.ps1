$ErrorActionPreference='Stop'
$all = Get-Content TerrariaItemListComplete1.4.5.txt | ForEach-Object { $_.Trim() } | Where-Object { $_ }
$catalogItems = rg -o "ItemID\.([A-Za-z0-9_]+)" Shops/Catalogs -g "*.cs" | ForEach-Object { ($_ -split 'ItemID\.')[1] } | Sort-Object -Unique
$missing = [System.Collections.Generic.List[pscustomobject]]::new()
for($i=0;$i -lt $all.Count;$i++){
  $name = $all[$i]
  if(-not ($catalogItems -contains $name)){
    $missing.Add([pscustomobject]@{ Name=$name; Id=($i+1); Index=$i })
  }
}
Write-Host "missing count: $($missing.Count)"

$recipesDb = Get-Content .tmp/terraria-info/json/recipes.json -Raw | ConvertFrom-Json
$tablesDb = Get-Content .tmp/terraria-info/json/tables.json -Raw | ConvertFrom-Json

$recipesById = @{}
foreach($r in $recipesDb){ 
  $rid=[int]0
  if(-not [int]::TryParse([string]$r.name,[ref]$rid)){ continue }
  if($rid -le 0){ continue }
  if(-not $recipesById.ContainsKey($rid)){ $recipesById[$rid] = @() }
  $recipesById[$rid] += ,$r 
}

$tableById = @{}
foreach($t in $tablesDb){ 
  $tid=[int]0
  if([int]::TryParse([string]$t.id,[ref]$tid)){ $tableById[$tid] = [string]$t.name }
}

function Get-StageByIndex([int]$idx){
  if($idx -le 366){ return 0 }
  if($idx -le 1292){ return 1 }
  if($idx -le 3466){ return 2 }
  return 3
}

$hardmodeTables = @('Mythril Anvil','Adamantite Forge','Titanium Forge','Blend-O-Matic','Steampunk Boiler','Autohammer')
$postPlanteraTables = @('Lihzahrd Furnace')
$postMoonlordTables = @('Ancient Manipulator')

function Get-ItemStage([int]$itemId){
  $base = Get-StageByIndex ($itemId-1)
  if(-not $recipesById.ContainsKey($itemId)){ return $base }

  $best = 99
  foreach($r in $recipesById[$itemId]){
    $stage = 0
    $tid=[int]0
    $tableName=''
    if([int]::TryParse([string]$r.table,[ref]$tid) -and $tableById.ContainsKey($tid)){ $tableName = $tableById[$tid] }

    if($postMoonlordTables -contains $tableName){ $stage = [Math]::Max($stage,3) }
    elseif($postPlanteraTables -contains $tableName){ $stage = [Math]::Max($stage,2) }
    elseif($hardmodeTables -contains $tableName){ $stage = [Math]::Max($stage,1) }

    for($i=1;$i -le 6;$i++){
      $raw=[string]$r."ingredient$i"
      if([string]::IsNullOrWhiteSpace($raw)){ continue }
      $ingId=[int]0
      if(-not [int]::TryParse($raw,[ref]$ingId)){ continue }
      if($ingId -le 0){ continue }
      $stage = [Math]::Max($stage, (Get-StageByIndex ($ingId-1)))
    }

    if($stage -lt $best){ $best = $stage }
  }

  if($best -eq 99){ $best = $base }
  return [Math]::Max($best,$base)
}

$classified = foreach($m in $missing){
  [pscustomobject]@{ Name=$m.Name; Id=$m.Id; Index=$m.Index; Stage=(Get-ItemStage $m.Id) }
}
$classified | Export-Csv .tmp/missing_classified.csv -NoTypeInformation
($classified | Group-Object Stage | Sort-Object Name | ForEach-Object { "Stage$($_.Name)=$($_.Count)" }) | ForEach-Object { Write-Host $_ }
$classified | Select-Object -First 30 | Format-Table -AutoSize
