# Destiny.Model.DestinyDefinitionsDestinyProgressionRewardDefinition
Inventory Items can reward progression when actions are performed on them. A common example of this in Destiny 1 was Bounties, which would reward Experience on your Character and the like when you completed the bounty.  Note that this maps to a DestinyProgressionMappingDefinition, and *not* a DestinyProgressionDefinition directly. This is apparently so that multiple progressions can be granted progression points/experience at the same time.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgressionMappingHash** | **int** | The hash identifier of the DestinyProgressionMappingDefinition that contains the progressions for which experience should be applied. | [optional] 
**Amount** | **int** | The amount of experience to give to each of the mapped progressions. | [optional] 
**ApplyThrottles** | **bool** | If true, the game&#39;s internal mechanisms to throttle progression should be applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

