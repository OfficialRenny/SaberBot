# Destiny.Model.DestinyDefinitionsItemsDestinyEnergyCapacityEntry
Items can have Energy Capacity, and plugs can provide that capacity such as on a piece of Armor in Armor 2.0. This is how much \"Energy\" can be spent on activating plugs for this item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CapacityValue** | **int** | How much energy capacity this plug provides. | [optional] 
**EnergyTypeHash** | **int** | Energy provided by a plug is always of a specific type - this is the hash identifier for the energy type for which it provides Capacity. | [optional] 
**EnergyType** | **int** | The Energy Type for this energy capacity, in enum form for easy use. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

