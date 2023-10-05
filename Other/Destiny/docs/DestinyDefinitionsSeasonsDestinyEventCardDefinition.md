# Destiny.Model.DestinyDefinitionsSeasonsDestinyEventCardDefinition
Defines the properties of an 'Event Card' in Destiny 2, to coincide with a seasonal event for additional challenges, premium rewards, a new seal, and a special title. For example: Solstice of Heroes 2022.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**LinkRedirectPath** | **string** |  | [optional] 
**Color** | [**DestinyMiscDestinyColor**](DestinyMiscDestinyColor.md) |  | [optional] 
**Images** | [**DestinyDefinitionsSeasonsDestinyEventCardImages**](DestinyDefinitionsSeasonsDestinyEventCardImages.md) |  | [optional] 
**TriumphsPresentationNodeHash** | **int** |  | [optional] 
**SealPresentationNodeHash** | **int** |  | [optional] 
**TicketCurrencyItemHash** | **int** |  | [optional] 
**TicketVendorHash** | **int** |  | [optional] 
**TicketVendorCategoryHash** | **int** |  | [optional] 
**EndTime** | **long** |  | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

