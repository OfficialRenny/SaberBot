# Destiny.Model.DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition
Nodes can have different visual states. This object represents a single visual state (\"highlight type\") that a node can be in, and the unlock expression condition to determine whether it should be set.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HighlightType** | **int** | The node can be highlighted in a variety of ways - the game iterates through these and finds the first FeaturingState that is valid at the present moment given the Game, Account, and Character state, and renders the node in that state. See the ActivityGraphNodeHighlightType enum for possible values. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

