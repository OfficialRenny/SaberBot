# Destiny.Model.DestinyDefinitionsDirectorDestinyActivityGraphDefinition
Represents a Map View in the director: be them overview views, destination views, or other.  They have nodes which map to activities, and other various visual elements that we (or others) may or may not be able to use.  Activity graphs, most importantly, have nodes which can have activities in various states of playability.  Unfortunately, activity graphs are combined at runtime with Game UI-only assets such as fragments of map images, various in-game special effects, decals etc... that we don't get in these definitions.  If we end up having time, we may end up trying to manually populate those here: but the last time we tried that, before the lead-up to D1, it proved to be unmaintainable as the game's content changed. So don't bet the farm on us providing that content in this definition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Nodes** | [**List&lt;DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition&gt;**](DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition.md) | These represent the visual \&quot;nodes\&quot; on the map&#39;s view. These are the activities you can click on in the map. | [optional] 
**ArtElements** | [**List&lt;DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition&gt;**](DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition.md) | Represents one-off/special UI elements that appear on the map. | [optional] 
**Connections** | [**List&lt;DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition&gt;**](DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition.md) | Represents connections between graph nodes. However, it lacks context that we&#39;d need to make good use of it. | [optional] 
**DisplayObjectives** | [**List&lt;DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition&gt;**](DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition.md) | Objectives can display on maps, and this is supposedly metadata for that. I have not had the time to analyze the details of what is useful within however: we could be missing important data to make this work. Expect this property to be expanded on later if possible. | [optional] 
**DisplayProgressions** | [**List&lt;DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition&gt;**](DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition.md) | Progressions can also display on maps, but similarly to displayObjectives we appear to lack some required information and context right now. We will have to look into it later and add more data if possible. | [optional] 
**LinkedGraphs** | [**List&lt;DestinyDefinitionsDirectorDestinyLinkedGraphDefinition&gt;**](DestinyDefinitionsDirectorDestinyLinkedGraphDefinition.md) | Represents links between this Activity Graph and other ones. | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

