# Author: Viliam Batka

Describe "TestDeployTemplate" {
    Context "TestRun" {
        It "DefaultValues Validate Only" {
            {
                & "$PSScriptRoot\..\Deploy-AzureResourceGroup.ps1" -ValidateOnly
            }  | Should Not Throw
        }
    }
}