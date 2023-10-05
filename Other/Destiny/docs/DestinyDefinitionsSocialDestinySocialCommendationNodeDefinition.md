# Destiny.Model.DestinyDefinitionsSocialDestinySocialCommendationNodeDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**Color** | [**DestinyMiscDestinyColor**](DestinyMiscDestinyColor.md) |  | [optional] 
**ParentCommendationNodeHash** | **int** |  | [optional] 
**ChildCommendationNodeHashes** | **List&lt;int&gt;** | A list of hashes that map to child commendation nodes. Only the root commendations node is expected to have child nodes. | [optional] 
**ChildCommendationHashes** | **List&lt;int&gt;** | A list of hashes that map to child commendations. | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

