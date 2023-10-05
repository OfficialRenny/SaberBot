# Destiny.Model.DestinyDefinitionsDestinyItemInvestmentStatDefinition
Represents a \"raw\" investment stat, before calculated stats are calculated and before any DestinyStatGroupDefinition is applied to transform the stat into something closer to what you see in-game.  Because these won't match what you see in-game, consider carefully whether you really want to use these stats. I have left them in case someone can do something useful or interesting with the pre-processed statistics.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatTypeHash** | **int** | The hash identifier for the DestinyStatDefinition defining this stat. | [optional] 
**Value** | **int** | The raw \&quot;Investment\&quot; value for the stat, before transformations are performed to turn this raw stat into stats that are displayed in the game UI. | [optional] 
**IsConditionallyActive** | **bool** | If this is true, the stat will only be applied on the item in certain game state conditions, and we can&#39;t know statically whether or not this stat will be applied. Check the \&quot;live\&quot; API data instead for whether this value is being applied on a specific instance of the item in question, and you can use this to decide whether you want to show the stat on the generic view of the item, or whether you want to show some kind of caveat or warning about the stat value being conditional on game state. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

