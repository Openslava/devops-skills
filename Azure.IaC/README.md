# Author: Viliam Batka

Azure.IaC - Infrastructure as code
- includes example of pester tests for running of deployment of IaC in test mode
 
to run dpeloyemnt from local folder change direcory to "Azure.IaC\ResourceGroup.IaC"

# deploy IaC
.\Deploy-AzureResourceGroup.ps1

# run pester test with default values
.\Scripts\RunPesterTests.ps1
