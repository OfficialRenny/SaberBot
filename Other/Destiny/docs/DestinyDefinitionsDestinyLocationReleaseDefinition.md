# Destiny.Model.DestinyDefinitionsDestinyLocationReleaseDefinition
A specific \"spot\" referred to by a location. Only one of these can be active at a time for a given Location.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**SmallTransparentIcon** | **string** |  | [optional] 
**MapIcon** | **string** |  | [optional] 
**LargeTransparentIcon** | **string** |  | [optional] 
**SpawnPoint** | **int** | If we had map information, this spawnPoint would be interesting. But sadly, we don&#39;t have that info. | [optional] 
**DestinationHash** | **int** | The Destination being pointed to by this location. | [optional] 
**ActivityHash** | **int** | The Activity being pointed to by this location. | [optional] 
**ActivityGraphHash** | **int** | The Activity Graph being pointed to by this location. | [optional] 
**ActivityGraphNodeHash** | **int** | The Activity Graph Node being pointed to by this location. (Remember that Activity Graph Node hashes are only unique within an Activity Graph: so use the combination to find the node being spoken of) | [optional] 
**ActivityBubbleName** | **int** | The Activity Bubble within the Destination. Look this up in the DestinyDestinationDefinition&#39;s bubbles and bubbleSettings properties. | [optional] 
**ActivityPathBundle** | **int** | If we had map information, this would tell us something cool about the path this location wants you to take. I wish we had map information. | [optional] 
**ActivityPathDestination** | **int** | If we had map information, this would tell us about path information related to destination on the map. Sad. Maybe you can do something cool with it. Go to town man. | [optional] 
**NavPointType** | **int** | The type of Nav Point that this represents. See the enumeration for more info. | [optional] 
**WorldPosition** | **List&lt;int&gt;** | Looks like it should be the position on the map, but sadly it does not look populated... yet? | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

