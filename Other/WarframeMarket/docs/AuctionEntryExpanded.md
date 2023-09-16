# WarframeMarket.Model.AuctionEntryExpanded
`owner` will contain `userShort` model. *** 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**MinimalReputation** | **int** | Minimal amount of reputation that is required to participate in this auction. | [optional] [default to 0]
**Winner** | **string** | If winner is set, auction is in the paused state. While on pause, bids can&#39;t be added, but can be removed. | [optional] 
**VarPrivate** | **bool** |  | [optional] 
**Visible** | **bool** |  | [optional] 
**NoteRaw** | **string** | Raw format string, use it inside textarea, for editing purposes. | [optional] 
**Note** | **string** | It&#39;s safe to inject this into html, this is refined, formatted string from MD processor. | [optional] 
**Owner** | [**UserShort**](UserShort.md) |  | [optional] 
**StartingPrice** | **int** |  | [optional] 
**BuyoutPrice** | **int?** | if &#x60;buyout_price&#x60; is set to null, that means ∞ | [optional] 
**MinimalIncrement** | **int** | Minimum bid increase value | [optional] [default to 1]
**IsDirectSell** | **bool** | Shortcut to &#x60;starting_price&#x60; &#x3D;&#x3D; &#x60;buyout_price&#x60;, means that auction is not an auction, but an order. | [optional] 
**TopBid** | **int?** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** | Last time auction was updated, eighter by owner or by placing a bid. | [optional] 
**Platform** | **string** |  | [optional] 
**Closed** | **bool** | Auction is closed, and was marked for removal or archiving, no one can add or remove bids now. | [optional] 
**IsMarkedFor** | **string** | Auction will be removed or archivated after &#x60;marked_operation_at&#x60; | [optional] 
**MarkedOperationAt** | **DateTime?** |  | [optional] 
**Item** | [**AuctionsCreatePostRequestItem**](AuctionsCreatePostRequestItem.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

