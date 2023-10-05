# Destiny.Model.DestinyVendorsDestinyVendorReceipt
If a character purchased an item that is refundable, a Vendor Receipt will be created on the user's Destiny Profile. These expire after a configurable period of time, but until then can be used to get refunds on items. BNet does not provide the ability to refund a purchase *yet*, but you know.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrencyPaid** | [**List&lt;DestinyDestinyItemQuantity&gt;**](DestinyDestinyItemQuantity.md) | The amount paid for the item, in terms of items that were consumed in the purchase and their quantity. | [optional] 
**ItemReceived** | [**DestinyDestinyItemQuantity**](DestinyDestinyItemQuantity.md) |  | [optional] 
**LicenseUnlockHash** | **int** | The unlock flag used to determine whether you still have the purchased item. | [optional] 
**PurchasedByCharacterId** | **long** | The ID of the character who made the purchase. | [optional] 
**RefundPolicy** | **int** | Whether you can get a refund, and what happens in order for the refund to be received. See the DestinyVendorItemRefundPolicy enum for details. | [optional] 
**SequenceNumber** | **int** | The identifier of this receipt. | [optional] 
**TimeToExpiration** | **long** | The seconds since epoch at which this receipt is rendered invalid. | [optional] 
**ExpiresOn** | **DateTime** | The date at which this receipt is rendered invalid. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

