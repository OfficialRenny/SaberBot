# Destiny.Model.DestinyDefinitionsDestinyActivityPlaylistItemDefinition
If the activity is a playlist, this is the definition for a specific entry in the playlist: a single possible combination of Activity and Activity Mode that can be chosen.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityHash** | **int** | The hash identifier of the Activity that can be played. Use it to look up the DestinyActivityDefinition. | [optional] 
**DirectActivityModeHash** | **int?** | If this playlist entry had an activity mode directly defined on it, this will be the hash of that mode. | [optional] 
**DirectActivityModeType** | **int?** | If the playlist entry had an activity mode directly defined on it, this will be the enum value of that mode. | [optional] 
**ActivityModeHashes** | **List&lt;int&gt;** | The hash identifiers for Activity Modes relevant to this entry. | [optional] 
**ActivityModeTypes** | **List&lt;int&gt;** | The activity modes - if any - in enum form. Because we can&#39;t seem to escape the enums. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

