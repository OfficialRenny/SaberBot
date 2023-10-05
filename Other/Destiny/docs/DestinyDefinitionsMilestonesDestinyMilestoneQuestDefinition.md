# Destiny.Model.DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition
Any data we need to figure out whether this Quest Item is the currently active one for the conceptual Milestone. Even just typing this description, I already regret it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuestItemHash** | **int** | The item representing this Milestone quest. Use this hash to look up the DestinyInventoryItemDefinition for the quest to find its steps and human readable data. | [optional] 
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**OverrideImage** | **string** | If populated, this image can be shown instead of the generic milestone&#39;s image when this quest is live, or it can be used to show a background image for the quest itself that differs from that of the Activity or the Milestone. | [optional] 
**QuestRewards** | [**DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition**](DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition.md) |  | [optional] 
**Activities** | [**Dictionary&lt;string, DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition&gt;**](DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition.md) | The full set of all possible \&quot;conceptual activities\&quot; that are related to this Milestone. Tiers or alternative modes of play within these conceptual activities will be defined as sub-entities. Keyed by the Conceptual Activity Hash. Use the key to look up DestinyActivityDefinition. | [optional] 
**DestinationHash** | **int?** | Sometimes, a Milestone&#39;s quest is related to an entire Destination rather than a specific activity. In that situation, this will be the hash of that Destination. Hotspots are currently the only Milestones that expose this data, but that does not preclude this data from being returned for other Milestones in the future. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

