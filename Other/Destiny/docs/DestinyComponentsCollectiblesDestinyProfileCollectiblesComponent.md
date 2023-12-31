# Destiny.Model.DestinyComponentsCollectiblesDestinyProfileCollectiblesComponent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecentCollectibleHashes** | **List&lt;int&gt;** | The list of collectibles determined by the game as having been \&quot;recently\&quot; acquired. | [optional] 
**NewnessFlaggedCollectibleHashes** | **List&lt;int&gt;** | The list of collectibles determined by the game as having been \&quot;recently\&quot; acquired.  The game client itself actually controls this data, so I personally question whether anyone will get much use out of this: because we can&#39;t edit this value through the API. But in case anyone finds it useful, here it is. | [optional] 
**Collectibles** | [**Dictionary&lt;string, DestinyComponentsCollectiblesDestinyCollectibleComponent&gt;**](DestinyComponentsCollectiblesDestinyCollectibleComponent.md) |  | [optional] 
**CollectionCategoriesRootNodeHash** | **int** | The hash for the root presentation node definition of Collection categories. | [optional] 
**CollectionBadgesRootNodeHash** | **int** | The hash for the root presentation node definition of Collection Badges. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

