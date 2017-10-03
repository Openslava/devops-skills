# Author: Viliam Batka

Describe "Test ARM Template" {
    Context "Test Run" {
        It "Deploy with Default Values" {
            $Error.Clear()
            $result = . "$PSScriptRoot\..\Deploy-AzureResourceGroup.ps1" -ValidateOnly
            $Error.Count | Should Be 0
            ($result  -match 'Template is valid') | Should be $true
        }
    }
}