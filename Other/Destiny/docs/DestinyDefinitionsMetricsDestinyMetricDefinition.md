# Destiny.Model.DestinyDefinitionsMetricsDestinyMetricDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**TrackingObjectiveHash** | **int** |  | [optional] 
**LowerValueIsBetter** | **bool** |  | [optional] 
**PresentationNodeType** | **int** |  | [optional] 
**TraitIds** | **List&lt;string&gt;** |  | [optional] 
**TraitHashes** | **List&lt;int&gt;** |  | [optional] 
**ParentNodeHashes** | **List&lt;int&gt;** | A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents. | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

