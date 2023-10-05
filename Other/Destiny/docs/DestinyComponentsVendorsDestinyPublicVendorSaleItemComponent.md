# Destiny.Model.DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent
Has character-agnostic information about an item being sold by a vendor.  Note that if you want instance, stats, etc... data for the item, you'll have to request additional components such as ItemInstances, ItemPerks etc... and acquire them from the DestinyVendorResponse's \"items\" property. For most of these, however, you'll have to ask for it in context of a specific character.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorItemIndex** | **int** | The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch.   Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment. | [optional] 
**ItemHash** | **int** | The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item. | [optional] 
**OverrideStyleItemHash** | **int?** | If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate. | [optional] 
**Quantity** | **int** | How much of the item you&#39;ll be getting. | [optional] 
**Costs** | [**List&lt;DestinyDestinyItemQuantity&gt;**](DestinyDestinyItemQuantity.md) | A summary of the current costs of the item. | [optional] 
**OverrideNextRefreshDate** | **DateTime?** | If this item has its own custom date where it may be removed from the Vendor&#39;s rotation, this is that date.  Note that there&#39;s not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor&#39;s sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it&#39;s the best we can give. | [optional] 
**ApiPurchasable** | **bool?** | If true, this item can be purchased through the Bungie.net API. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

