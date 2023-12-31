# Destiny.Model.DestinyDefinitionsDestinyItemSetBlockDefinition
Primarily for Quests, this is the definition of properties related to the item if it is a quest and its various quest steps.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemList** | [**List&lt;DestinyDefinitionsDestinyItemSetBlockEntryDefinition&gt;**](DestinyDefinitionsDestinyItemSetBlockEntryDefinition.md) | A collection of hashes of set items, for items such as Quest Metadata items that possess this data. | [optional] 
**RequireOrderedSetItemAdd** | **bool** | If true, items in the set can only be added in increasing order, and adding an item will remove any previous item. For Quests, this is by necessity true. Only one quest step is present at a time, and previous steps are removed as you advance in the quest. | [optional] 
**SetIsFeatured** | **bool** | If true, the UI should treat this quest as \&quot;featured\&quot; | [optional] 
**SetType** | **string** | A string identifier we can use to attempt to identify the category of the Quest. | [optional] 
**QuestLineName** | **string** | The name of the quest line that this quest step is a part of. | [optional] 
**QuestLineDescription** | **string** | The description of the quest line that this quest step is a part of. | [optional] 
**QuestStepSummary** | **string** | An additional summary of this step in the quest line. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

