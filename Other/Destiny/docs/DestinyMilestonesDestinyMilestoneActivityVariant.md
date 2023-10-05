# Destiny.Model.DestinyMilestonesDestinyMilestoneActivityVariant
Represents custom data that we know about an individual variant of an activity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityHash** | **int** | The hash for the specific variant of the activity related to this milestone. You can pull more detailed static info from the DestinyActivityDefinition, such as difficulty level. | [optional] 
**CompletionStatus** | [**DestinyMilestonesDestinyMilestoneActivityCompletionStatus**](DestinyMilestonesDestinyMilestoneActivityCompletionStatus.md) |  | [optional] 
**ActivityModeHash** | **int?** | The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it&#39;s not clear what mode the PVP map is being played under. If it&#39;s a playlist, this will be less specific: but hopefully useful in some way. | [optional] 
**ActivityModeType** | **int?** | The enumeration equivalent of the most specific Activity Mode under which this activity is played. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

