# Destiny.Model.DestinyDefinitionsLoadoutsDestinyLoadoutConstantsDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**WhiteIconImagePath** | **string** | This is the same icon as the one in the display properties, offered here as well with a more descriptive name. | [optional] 
**BlackIconImagePath** | **string** | This is a color-inverted version of the whiteIconImagePath. | [optional] 
**LoadoutCountPerCharacter** | **int** | The maximum number of loadouts available to each character. The loadouts component API response can return fewer loadouts than this, as more loadouts are unlocked by reaching higher Guardian Ranks. | [optional] 
**LoadoutPreviewFilterOutSocketCategoryHashes** | **List&lt;int&gt;** | A list of the socket category hashes to be filtered out of loadout item preview displays. | [optional] 
**LoadoutPreviewFilterOutSocketTypeHashes** | **List&lt;int&gt;** | A list of the socket type hashes to be filtered out of loadout item preview displays. | [optional] 
**LoadoutNameHashes** | **List&lt;int&gt;** | A list of the loadout name hashes in index order, for convenience. | [optional] 
**LoadoutIconHashes** | **List&lt;int&gt;** | A list of the loadout icon hashes in index order, for convenience. | [optional] 
**LoadoutColorHashes** | **List&lt;int&gt;** | A list of the loadout color hashes in index order, for convenience. | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

