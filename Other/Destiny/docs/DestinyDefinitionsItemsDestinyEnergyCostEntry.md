# Destiny.Model.DestinyDefinitionsItemsDestinyEnergyCostEntry
Some plugs cost Energy, which is a stat on the item that can be increased by other plugs (that, at least in Armor 2.0, have a \"masterworks-like\" mechanic for upgrading). If a plug has costs, the details of that cost are defined here.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnergyCost** | **int** | The Energy cost for inserting this plug. | [optional] 
**EnergyTypeHash** | **int** | The type of energy that this plug costs, as a reference to the DestinyEnergyTypeDefinition of the energy type. | [optional] 
**EnergyType** | **int** | The type of energy that this plug costs, in enum form. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

