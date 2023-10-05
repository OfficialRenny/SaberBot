# Destiny.Model.DestinyDefinitionsDestinyProgressionDefinition
A \"Progression\" in Destiny is best explained by an example.  A Character's \"Level\" is a progression: it has Experience that can be earned, levels that can be gained, and is evaluated and displayed at various points in the game. A Character's \"Faction Reputation\" is also a progression for much the same reason.  Progression is used by a variety of systems, and the definition of a Progression will generally only be useful if combining with live data (such as a character's DestinyCharacterProgressionComponent.progressions property, which holds that character's live Progression states).  Fundamentally, a Progression measures your \"Level\" by evaluating the thresholds in its Steps (one step per level, except for the last step which can be repeated indefinitely for \"Levels\" that have no ceiling) against the total earned \"progression points\"/experience. (for simplicity purposes, we will henceforth refer to earned progression points as experience, though it need not be a mechanic that in any way resembles Experience in a traditional sense).  Earned experience is calculated in a variety of ways, determined by the Progression's scope. These go from looking up a stored value to performing exceedingly obtuse calculations. This is why we provide live data in DestinyCharacterProgressionComponent.progressions, so you don't have to worry about those.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition**](DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition.md) |  | [optional] 
**Scope** | **int** | The \&quot;Scope\&quot; of the progression indicates the source of the progression&#39;s live data.  See the DestinyProgressionScope enum for more info: but essentially, a Progression can either be backed by a stored value, or it can be a calculated derivative of other values. | [optional] 
**RepeatLastStep** | **bool** | If this is True, then the progression doesn&#39;t have a maximum level. | [optional] 
**Source** | **string** | If there&#39;s a description of how to earn this progression in the local config, this will be that localized description. | [optional] 
**Steps** | [**List&lt;DestinyDefinitionsDestinyProgressionStepDefinition&gt;**](DestinyDefinitionsDestinyProgressionStepDefinition.md) | Progressions are divided into Steps, which roughly equate to \&quot;Levels\&quot; in the traditional sense of a Progression. Notably, the last step can be repeated indefinitely if repeatLastStep is true, meaning that the calculation for your level is not as simple as comparing your current progress to the max progress of the steps.   These and more calculations are done for you if you grab live character progression data, such as in the DestinyCharacterProgressionComponent. | [optional] 
**Visible** | **bool** | If true, the Progression is something worth showing to users.  If false, BNet isn&#39;t going to show it. But that doesn&#39;t mean you can&#39;t. We&#39;re all friends here. | [optional] 
**FactionHash** | **int?** | If the value exists, this is the hash identifier for the Faction that owns this Progression.  This is purely for convenience, if you&#39;re looking at a progression and want to know if and who it&#39;s related to in terms of Faction Reputation. | [optional] 
**Color** | [**DestinyMiscDestinyColor**](DestinyMiscDestinyColor.md) |  | [optional] 
**RankIcon** | **string** | For progressions that have it, this is the rank icon we use in the Companion, displayed above the progressions&#39; rank value. | [optional] 
**RewardItems** | [**List&lt;DestinyDefinitionsDestinyProgressionRewardItemQuantity&gt;**](DestinyDefinitionsDestinyProgressionRewardItemQuantity.md) |  | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

