# Destiny.Model.DestinyDefinitionsCollectiblesDestinyCollectibleDefinition
Defines a

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**Scope** | **int** | Indicates whether the state of this Collectible is determined on a per-character or on an account-wide basis. | [optional] 
**SourceString** | **string** | A human readable string for a hint about how to acquire the item. | [optional] 
**SourceHash** | **int?** | This is a hash identifier we are building on the BNet side in an attempt to let people group collectibles by similar sources.  I can&#39;t promise that it&#39;s going to be 100% accurate, but if the designers were consistent in assigning the same source strings to items with the same sources, it *ought to* be. No promises though.  This hash also doesn&#39;t relate to an actual definition, just to note: we&#39;ve got nothing useful other than the source string for this data. | [optional] 
**ItemHash** | **int** |  | [optional] 
**AcquisitionInfo** | [**DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock**](DestinyDefinitionsCollectiblesDestinyCollectibleAcquisitionBlock.md) |  | [optional] 
**StateInfo** | [**DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock**](DestinyDefinitionsCollectiblesDestinyCollectibleStateBlock.md) |  | [optional] 
**PresentationInfo** | [**DestinyDefinitionsPresentationDestinyPresentationChildBlock**](DestinyDefinitionsPresentationDestinyPresentationChildBlock.md) |  | [optional] 
**PresentationNodeType** | **int** |  | [optional] 
**TraitIds** | **List&lt;string&gt;** |  | [optional] 
**TraitHashes** | **List&lt;int&gt;** |  | [optional] 
**ParentNodeHashes** | **List&lt;int&gt;** | A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents. | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

