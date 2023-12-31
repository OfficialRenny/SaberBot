# Destiny.Model.DestinyDefinitionsDestinyDamageTypeDefinition
All damage types that are possible in the game are defined here, along with localized info and icons as needed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**TransparentIconPath** | **string** | A variant of the icon that is transparent and colorless. | [optional] 
**ShowIcon** | **bool** | If TRUE, the game shows this damage type&#39;s icon. Otherwise, it doesn&#39;t. Whether you show it or not is up to you. | [optional] 
**EnumValue** | **int** | We have an enumeration for damage types for quick reference. This is the current definition&#39;s damage type enum value. | [optional] 
**Color** | [**DestinyMiscDestinyColor**](DestinyMiscDestinyColor.md) |  | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

