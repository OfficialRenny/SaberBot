# Destiny.Model.DestinyEntitiesItemsDestinyItemInstanceComponent
If an item is \"instanced\", this will contain information about the item's instance that doesn't fit easily into other components. One might say this is the \"essential\" instance data for the item.  Items are instanced if they require information or state that can vary. For instance, weapons are Instanced: they are given a unique identifier, uniquely generated stats, and can have their properties altered. Non-instanced items have none of these things: for instance, Glimmer has no unique properties aside from how much of it you own.  You can tell from an item's definition whether it will be instanced or not by looking at the DestinyInventoryItemDefinition's definition.inventory.isInstanceItem property.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DamageType** | **int** | If the item has a damage type, this is the item&#39;s current damage type. | [optional] 
**DamageTypeHash** | **int?** | The current damage type&#39;s hash, so you can look up localized info and icons for it. | [optional] 
**PrimaryStat** | [**DestinyDestinyStat**](DestinyDestinyStat.md) |  | [optional] 
**ItemLevel** | **int** | The Item&#39;s \&quot;Level\&quot; has the most significant bearing on its stats, such as Light and Power. | [optional] 
**Quality** | **int** | The \&quot;Quality\&quot; of the item has a lesser - but still impactful - bearing on stats like Light and Power. | [optional] 
**IsEquipped** | **bool** | Is the item currently equipped on the given character? | [optional] 
**CanEquip** | **bool** | If this is an equippable item, you can check it here. There are permanent as well as transitory reasons why an item might not be able to be equipped: check cannotEquipReason for details. | [optional] 
**EquipRequiredLevel** | **int** | If the item cannot be equipped until you reach a certain level, that level will be reflected here. | [optional] 
**UnlockHashesRequiredToEquip** | **List&lt;int&gt;** | Sometimes, there are limitations to equipping that are represented by character-level flags called \&quot;unlocks\&quot;.  This is a list of flags that they need in order to equip the item that the character has not met. Use these to look up the descriptions to show in your UI by looking up the relevant DestinyUnlockDefinitions for the hashes. | [optional] 
**CannotEquipReason** | **int** | If you cannot equip the item, this is a flags enum that enumerates all of the reasons why you couldn&#39;t equip the item. You may need to refine your UI further by using unlockHashesRequiredToEquip and equipRequiredLevel. | [optional] 
**BreakerType** | **int?** | If populated, this item has a breaker type corresponding to the given value. See DestinyBreakerTypeDefinition for more details. | [optional] 
**BreakerTypeHash** | **int?** | If populated, this is the hash identifier for the item&#39;s breaker type. See DestinyBreakerTypeDefinition for more details. | [optional] 
**Energy** | [**DestinyEntitiesItemsDestinyItemInstanceEnergy**](DestinyEntitiesItemsDestinyItemInstanceEnergy.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

