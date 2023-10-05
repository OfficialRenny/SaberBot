# Destiny.Model.DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition
A shortcut for the fact that some items have a \"Preview Vendor\" - See DestinyInventoryItemDefinition.preview.previewVendorHash - that is intended to be used to show what items you can get as a result of acquiring or using this item.  A common example of this in Destiny 1 was Eververse \"Boxes,\" which could have many possible items. This \"Preview Vendor\" is not a vendor you can actually see in the game, but it defines categories and sale items for all of the possible items you could get from the Box so that the game can show them to you. We summarize that info here so that you don't have to do that Vendor lookup and aggregation manually.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CategoryDescription** | **string** | The localized string for the category title. This will be something describing the items you can get as a group, or your likelihood/the quantity you&#39;ll get. | [optional] 
**Items** | [**List&lt;DestinyDefinitionsItemsDestinyDerivedItemDefinition&gt;**](DestinyDefinitionsItemsDestinyDerivedItemDefinition.md) | This is the list of all of the items for this category and the basic properties we&#39;ll know about them. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

