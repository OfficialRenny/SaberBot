# Destiny.Model.DestinyMilestonesDestinyMilestoneActivityCompletionStatus
Represents this player's personal completion status for the Activity under a Milestone, if the activity has trackable completion and progress information. (most activities won't, or the concept won't apply. For instance, it makes sense to talk about a tier of a raid as being Completed or having progress, but it doesn't make sense to talk about a Crucible Playlist in those terms.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Completed** | **bool** | If the activity has been \&quot;completed\&quot;, that information will be returned here. | [optional] 
**Phases** | [**List&lt;DestinyMilestonesDestinyMilestoneActivityPhase&gt;**](DestinyMilestonesDestinyMilestoneActivityPhase.md) | If the Activity has discrete \&quot;phases\&quot; that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

