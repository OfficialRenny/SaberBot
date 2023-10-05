# Destiny.Model.DestinyMilestonesDestinyMilestoneQuest
If a Milestone has one or more Quests, this will contain the live information for the character's status with one of those quests.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuestItemHash** | **int** | Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item&#39;s DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data. | [optional] 
**Status** | [**DestinyQuestsDestinyQuestStatus**](DestinyQuestsDestinyQuestStatus.md) |  | [optional] 
**Activity** | [**DestinyMilestonesDestinyMilestoneActivity**](DestinyMilestonesDestinyMilestoneActivity.md) |  | [optional] 
**Challenges** | [**List&lt;DestinyChallengesDestinyChallengeStatus&gt;**](DestinyChallengesDestinyChallengeStatus.md) | The activities referred to by this quest can have many associated challenges. They are all contained here, with activityHashes so that you can associate them with the specific activity variants in which they can be found. In retrospect, I probably should have put these under the specific Activity Variants, but it&#39;s too late to change it now. Theoretically, a quest without Activities can still have Challenges, which is why this is on a higher level than activity/variants, but it probably should have been in both places. That may come as a later revision. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

