# Destiny.Model.DestinyDefinitionsDestinyItemVendorSourceReference
Represents that a vendor could sell this item, and provides a quick link to that vendor and sale item.   Note that we do not and cannot make a guarantee that the vendor will ever *actually* sell this item, only that the Vendor has a definition that indicates it *could* be sold.   Note also that a vendor may sell the same item in multiple \"ways\", which means there may be multiple vendorItemIndexes for a single Vendor hash.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorHash** | **int** | The identifier for the vendor that may sell this item. | [optional] 
**VendorItemIndexes** | **List&lt;int&gt;** | The Vendor sale item indexes that represent the sale information for this item. The same vendor may sell an item in multiple \&quot;ways\&quot;, hence why this is a list. (for instance, a weapon may be \&quot;sold\&quot; as a reward in a quest, for Glimmer, and for Masterwork Cores: each of those ways would be represented by a different vendor sale item with a different index) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

