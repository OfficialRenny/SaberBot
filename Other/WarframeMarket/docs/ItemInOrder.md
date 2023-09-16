# WarframeMarket.Model.ItemInOrder
same as ItemFull, but with dried up lang related fields and without rarity, set_root, MR, trading tax

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**UrlName** | **string** | [a-z] snake case name of the item | [optional] 
**Icon** | **string** | it&#39;s a part of url, if you want to get an image you need to prepend assets root dirrectory: &#x60;http://warframe.market/static/assets/&#x60;  | [optional] 
**IconFormat** | **string** |  | [optional] 
**Thumb** | **string** | Thumb of an icon | [optional] 
**SubIcon** | **string** | Usually, if item is part of set and not set itself, it will have &#x60;sub_icon&#x60;  like: **Mirage Blueprint** is part of **Mirage Set**, therefore the &#x60;icon&#x60; will be the **Mirage warframe** icon, and the &#x60;sub_icon&#x60; will be the **blueprint** icon  | [optional] 
**ModMaxRank** | **int** | in the next api version will be renamed to &#x60;max_rank&#x60; | [optional] 
**Subtypes** | **List&lt;string&gt;** | relics and fishes are having this field | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**Ducats** | **int** |  | [optional] 
**QuantityForSet** | **int** |  | [optional] 
**En** | [**ItemInOrderAllOfEn**](ItemInOrderAllOfEn.md) |  | [optional] 
**Ru** | [**ItemInOrderAllOfRu**](ItemInOrderAllOfRu.md) |  | [optional] 
**Ko** | [**ItemInOrderAllOfKo**](ItemInOrderAllOfKo.md) |  | [optional] 
**Fr** | [**ItemInOrderAllOfFr**](ItemInOrderAllOfFr.md) |  | [optional] 
**De** | [**ItemInOrderAllOfDe**](ItemInOrderAllOfDe.md) |  | [optional] 
**Sv** | [**ItemInOrderAllOfEn**](ItemInOrderAllOfEn.md) |  | [optional] 
**ZhHant** | [**ItemInOrderAllOfZhHant**](ItemInOrderAllOfZhHant.md) |  | [optional] 
**ZhHans** | [**ItemInOrderAllOfZhHans**](ItemInOrderAllOfZhHans.md) |  | [optional] 
**Pt** | [**ItemInOrderAllOfPt**](ItemInOrderAllOfPt.md) |  | [optional] 
**Es** | [**ItemInOrderAllOfEs**](ItemInOrderAllOfEs.md) |  | [optional] 
**Pl** | [**ItemInOrderAllOfPl**](ItemInOrderAllOfPl.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

