# WarframeMarket.Model.AuctionsCreatePostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Note** | **string** |  | [optional] 
**StartingPrice** | **int** |  | 
**BuyoutPrice** | **int?** | If you want ∞ as buyout price, set this to &#x60;null&#x60; | 
**MinimalIncrement** | **int** | Minimum delta between the bids, Not appliable right now | [optional] [default to 1]
**MinimalReputation** | **int** | Minimum reputation requirenment for participation in this auction. | [optional] [default to 0]
**VarPrivate** | **bool** | is this auction is private and only accesibly by direct link. | [optional] [default to false]
**Item** | [**AuctionsCreatePostRequestItem**](AuctionsCreatePostRequestItem.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

