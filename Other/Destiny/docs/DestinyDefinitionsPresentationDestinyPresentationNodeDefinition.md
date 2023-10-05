# Destiny.Model.DestinyDefinitionsPresentationDestinyPresentationNodeDefinition
A PresentationNode is an entity that represents a logical grouping of other entities visually/organizationally.  For now, Presentation Nodes may contain the following... but it may be used for more in the future:  - Collectibles - Records (Or, as the public will call them, \"Triumphs.\" Don't ask me why we're overloading the term \"Triumph\", it still hurts me to think about it) - Metrics (aka Stat Trackers) - Other Presentation Nodes, allowing a tree of Presentation Nodes to be created  Part of me wants to break these into conceptual definitions per entity being collected, but the possibility of these different types being mixed in the same UI and the possibility that it could actually be more useful to return the \"bare metal\" presentation node concept has resulted in me deciding against that for the time being.  We'll see if I come to regret this as well.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**OriginalIcon** | **string** | The original icon for this presentation node, before we futzed with it. | [optional] 
**RootViewIcon** | **string** | Some presentation nodes are meant to be explicitly shown on the \&quot;root\&quot; or \&quot;entry\&quot; screens for the feature to which they are related. You should use this icon when showing them on such a view, if you have a similar \&quot;entry point\&quot; view in your UI. If you don&#39;t have a UI, then I guess it doesn&#39;t matter either way does it? | [optional] 
**NodeType** | **int** |  | [optional] 
**Scope** | **int** | Indicates whether this presentation node&#39;s state is determined on a per-character or on an account-wide basis. | [optional] 
**ObjectiveHash** | **int?** | If this presentation node shows a related objective (for instance, if it tracks the progress of its children), the objective being tracked is indicated here. | [optional] 
**CompletionRecordHash** | **int?** | If this presentation node has an associated \&quot;Record\&quot; that you can accomplish for completing its children, this is the identifier of that Record. | [optional] 
**Children** | [**DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock**](DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock.md) |  | [optional] 
**DisplayStyle** | **int** | A hint for how to display this presentation node when it&#39;s shown in a list. | [optional] 
**ScreenStyle** | **int** | A hint for how to display this presentation node when it&#39;s shown in its own detail screen. | [optional] 
**Requirements** | [**DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock**](DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock.md) |  | [optional] 
**DisableChildSubscreenNavigation** | **bool** | If this presentation node has children, but the game doesn&#39;t let you inspect the details of those children, that is indicated here. | [optional] 
**MaxCategoryRecordScore** | **int** |  | [optional] 
**PresentationNodeType** | **int** |  | [optional] 
**TraitIds** | **List&lt;string&gt;** |  | [optional] 
**TraitHashes** | **List&lt;int&gt;** |  | [optional] 
**ParentNodeHashes** | **List&lt;int&gt;** | A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents. | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

