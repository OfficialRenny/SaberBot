# Destiny.Model.DestinyDefinitionsDestinyMaterialRequirementSetDefinition
Represent a set of material requirements: Items that either need to be owned or need to be consumed in order to perform an action.  A variety of other entities refer to these as gatekeepers and payments for actions that can be performed in game.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Materials** | [**List&lt;DestinyDefinitionsDestinyMaterialRequirement&gt;**](DestinyDefinitionsDestinyMaterialRequirement.md) | The list of all materials that are required. | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

