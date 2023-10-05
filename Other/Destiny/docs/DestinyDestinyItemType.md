# Destiny.Model.DestinyDestinyItemType
An enumeration that indicates the high-level \"type\" of the item, attempting to iron out the context specific differences for specific instances of an entity. For instance, though a weapon may be of various weapon \"Types\", in DestinyItemType they are all classified as \"Weapon\". This allows for better filtering on a higher level of abstraction for the concept of types.   This enum is provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \"best guess\" fit.   NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.   I keep updating these because they're so damn convenient. I guess I shouldn't fight it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

