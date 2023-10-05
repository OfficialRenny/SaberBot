# Destiny.Model.DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem
A subclass of DestinyItemQuantity, that provides not just the item and its quantity but also information that BNet can - at some point - use internally to provide more robust runtime information about the item's qualities.  If you want it, please ask! We're just out of time to wire it up right now. Or a clever person just may do it with our existing endpoints.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorHash** | **int?** | The quest reward item *may* be associated with a vendor. If so, this is that vendor. Use this hash to look up the DestinyVendorDefinition. | [optional] 
**VendorItemIndex** | **int?** | The quest reward item *may* be associated with a vendor. If so, this is the index of the item being sold, which we can use at runtime to find instanced item information for the reward item. | [optional] 
**ItemHash** | **int** | The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition. | [optional] 
**ItemInstanceId** | **long?** | If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null. | [optional] 
**Quantity** | **int** | The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used. | [optional] 
**HasConditionalVisibility** | **bool** | Indicates that this item quantity may be conditionally shown or hidden, based on various sources of state. For example: server flags, account state, or character progress. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

