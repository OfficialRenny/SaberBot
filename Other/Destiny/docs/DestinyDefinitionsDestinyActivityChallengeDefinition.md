# Destiny.Model.DestinyDefinitionsDestinyActivityChallengeDefinition
Represents a reference to a Challenge, which for now is just an Objective.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectiveHash** | **int** | The hash for the Objective that matches this challenge. Use it to look up the DestinyObjectiveDefinition. | [optional] 
**DummyRewards** | [**List&lt;DestinyDestinyItemQuantity&gt;**](DestinyDestinyItemQuantity.md) | The rewards as they&#39;re represented in the UI. Note that they generally link to \&quot;dummy\&quot; items that give a summary of rewards rather than direct, real items themselves.  If the quantity is 0, don&#39;t show the quantity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

