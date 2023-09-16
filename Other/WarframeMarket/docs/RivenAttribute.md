# WarframeMarket.Model.RivenAttribute

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**UrlName** | **string** |  | [optional] 
**Group** | **string** | Group of the attribute, like top, melee, etc.   Used for grouping within UI elements.  | [optional] 
**Prefix** | **string** |  | [optional] 
**Suffix** | **string** |  | [optional] 
**PositiveIsNegative** | **bool** | Negative value of this attribute indicate that attribute is positive, e.g. &#x60;Recoil&#x60;. | [optional] 
**ExclusiveTo** | **string** | This attribute is only available on specific types of items, check item property: &#x60;riven_type&#x60;   If &#x60;null&#x60;, then this attribute can be selected on every item.  | [optional] 
**Effect** | **string** | Name of the attribute, depends on the requested language (headers) | [optional] 
**Units** | **string** | measurement units | [optional] 
**NegativeOnly** | **bool** | This attribute occurs only as a negative. | [optional] 
**SearchOnly** | **bool** | used only while searching for auctions | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

