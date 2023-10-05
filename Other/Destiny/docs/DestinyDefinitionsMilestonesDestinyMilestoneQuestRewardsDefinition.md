# Destiny.Model.DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition
If rewards are given in a quest - as opposed to overall in the entire Milestone - there's way less to track. We're going to simplify this contract as a result. However, this also gives us the opportunity to potentially put more than just item information into the reward data if we're able to mine it out in the future. Remember this if you come back and ask \"why are quest reward items nested inside of their own class?\"

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**List&lt;DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem&gt;**](DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem.md) | The items that represent your reward for completing the quest.  Be warned, these could be \&quot;dummy\&quot; items: items that are only used to render a good-looking in-game tooltip, but aren&#39;t the actual items themselves.  For instance, when experience is given there&#39;s often a dummy item representing \&quot;experience\&quot;, with quantity being the amount of experience you got. We don&#39;t have a programmatic association between those and whatever Progression is actually getting that experience... yet. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

