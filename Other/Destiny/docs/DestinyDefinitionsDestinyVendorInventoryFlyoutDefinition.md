# Destiny.Model.DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition
The definition for an \"inventory flyout\": a UI screen where we show you part of an otherwise hidden vendor inventory: like the Vault inventory buckets.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LockedDescription** | **string** | If the flyout is locked, this is the reason why. | [optional] 
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**Buckets** | [**List&lt;DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition&gt;**](DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition.md) | A list of inventory buckets and other metadata to show on the screen. | [optional] 
**FlyoutId** | **int** | An identifier for the flyout, in case anything else needs to refer to them. | [optional] 
**SuppressNewness** | **bool** | If this is true, don&#39;t show any of the glistening \&quot;this is a new item\&quot; UI elements, like we show on the inventory items themselves in in-game UI. | [optional] 
**EquipmentSlotHash** | **int?** | If this flyout is meant to show you the contents of the player&#39;s equipment slot, this is the slot to show. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

