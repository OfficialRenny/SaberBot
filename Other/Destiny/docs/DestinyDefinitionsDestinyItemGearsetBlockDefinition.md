# Destiny.Model.DestinyDefinitionsDestinyItemGearsetBlockDefinition
If an item has a related gearset, this is the list of items in that set, and an unlock expression that evaluates to a number representing the progress toward gearset completion (a very rare use for unlock expressions!)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TrackingValueMax** | **int** | The maximum possible number of items that can be collected. | [optional] 
**ItemList** | **List&lt;int&gt;** | The list of hashes for items in the gearset. Use them to look up DestinyInventoryItemDefinition entries for the items in the set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

