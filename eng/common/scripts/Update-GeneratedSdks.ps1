[CmdLetBinding()]
param(
  [Parameter(Mandatory)]
  [string]$PackageFoldersFile
)

. $PSScriptRoot/common.ps1
. $PSScriptRoot/Helpers/CommandInvocation-Helpers.ps1

$ErrorActionPreference = 'Stop'
$showSummary = ($env:SYSTEM_DEBUG -eq 'true') -or ($VerbosePreference -ne 'SilentlyContinue')

$packageFolders = Get-Content $PackageFoldersFile | ConvertFrom-Json

foreach ($folder in $packageFolders) {
  Push-Location $RepoRoot
  try {
    Write-Host 'Generating projects under folder ' -ForegroundColor Green -NoNewline
    Write-Host "$folder" -ForegroundColor Yellow
    if ($showSummary) {
      Invoke-LoggedCommand "dotnet msbuild /restore /t:GenerateCode /p:Scope=`"$folder`" /v:n /ds eng\service.proj"
    }
    else {
      Invoke-LoggedCommand "dotnet msbuild /restore /t:GenerateCode /p:Scope=`"$folder`" eng\service.proj"
    }
    if ($LastExitCode -ne 0) {
      Write-Error "Generation error in $folder"
      exit 1
    }
  }
  finally {
    Pop-Location
  }
}
