# Destiny.Model.DestinyConstantsDestinyEnvironmentLocationMapping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationHash** | **int** | The location that is revealed on the director by this mapping. | [optional] 
**ActivationSource** | **string** | A hint that the UI uses to figure out how this location is activated by the player. | [optional] 
**ItemHash** | **int?** | If this is populated, it is the item that you must possess for this location to be active because of this mapping. (theoretically, a location can have multiple mappings, and some might require an item while others don&#39;t) | [optional] 
**ObjectiveHash** | **int?** | If this is populated, this is an objective related to the location. | [optional] 
**ActivityHash** | **int?** | If this is populated, this is the activity you have to be playing in order to see this location appear because of this mapping. (theoretically, a location can have multiple mappings, and some might require you to be in a specific activity when others don&#39;t) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

