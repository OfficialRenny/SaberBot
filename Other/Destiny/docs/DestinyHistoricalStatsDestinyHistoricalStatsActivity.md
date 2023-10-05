# Destiny.Model.DestinyHistoricalStatsDestinyHistoricalStatsActivity
Summary information about the activity that was played.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceId** | **int** | The unique hash identifier of the DestinyActivityDefinition that was played. If I had this to do over, it&#39;d be named activityHash. Too late now. | [optional] 
**DirectorActivityHash** | **int** | The unique hash identifier of the DestinyActivityDefinition that was played. | [optional] 
**InstanceId** | **long** | The unique identifier for this *specific* match that was played.  This value can be used to get additional data about this activity such as who else was playing via the GetPostGameCarnageReport endpoint. | [optional] 
**Mode** | **int** | Indicates the most specific game mode of the activity that we could find. | [optional] 
**Modes** | **List&lt;int&gt;** | The list of all Activity Modes to which this activity applies, including aggregates. This will let you see, for example, whether the activity was both Clash and part of the Trials of the Nine event. | [optional] 
**IsPrivate** | **bool** | Whether or not the match was a private match. | [optional] 
**MembershipType** | **int** | The Membership Type indicating the platform on which this match was played. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

