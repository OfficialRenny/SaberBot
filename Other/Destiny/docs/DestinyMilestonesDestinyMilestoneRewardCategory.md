# Destiny.Model.DestinyMilestonesDestinyMilestoneRewardCategory
Represents a category of \"summary\" rewards that can be earned for the Milestone regardless of specific quest rewards that can be earned.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RewardCategoryHash** | **int** | Look up the relevant DestinyMilestoneDefinition, and then use rewardCategoryHash to look up the category info in DestinyMilestoneDefinition.rewards. | [optional] 
**Entries** | [**List&lt;DestinyMilestonesDestinyMilestoneRewardEntry&gt;**](DestinyMilestonesDestinyMilestoneRewardEntry.md) | The individual reward entries for this category, and their status. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

