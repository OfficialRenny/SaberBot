# Destiny.Model.DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition
This is the position and other data related to nodes in the activity graph that you can click to launch activities. An Activity Graph node will only have one active Activity at a time, which will determine the activity to be launched (and, unless overrideDisplay information is provided, will also determine the tooltip and other UI related to the node)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NodeId** | **int** | An identifier for the Activity Graph Node, only guaranteed to be unique within its parent Activity Graph. | [optional] 
**OverrideDisplay** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**Position** | [**DestinyDefinitionsCommonDestinyPositionDefinition**](DestinyDefinitionsCommonDestinyPositionDefinition.md) |  | [optional] 
**FeaturingStates** | [**List&lt;DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition&gt;**](DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition.md) | The node may have various visual accents placed on it, or styles applied. These are the list of possible styles that the Node can have. The game iterates through each, looking for the first one that passes a check of the required game/character/account state in order to show that style, and then renders the node in that style. | [optional] 
**Activities** | [**List&lt;DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition&gt;**](DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition.md) | The node may have various possible activities that could be active for it, however only one may be active at a time. See the DestinyActivityGraphNodeActivityDefinition for details. | [optional] 
**States** | [**List&lt;DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry&gt;**](DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry.md) | Represents possible states that the graph node can be in. These are combined with some checking that happens in the game client and server to determine which state is actually active at any given time. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

