#
# RunPesterTests.ps1
#
# Author: Viliam Batka

param
(
    $testFile = "$PSScriptRoot\..\Tests\TestDeployTemplate.tests.ps1",
    $outputFile = "$PSScriptRoot\..\Tests\TestDeployTemplate.tests.xml"
)
if( ! (Get-Command "Invoke-Pester" -ErrorAction SilentlyContinue))
{
    Write-Host "Loading Perster Module"
    Import-Module "$PSScriptRoot\..\..\packages\Pester.4.0.8\tools\Pester.psm1"
}


Invoke-Pester -Script @{Path="$testFile"}  -OutputFile $outputFile -OutputFormat NUnitXML

