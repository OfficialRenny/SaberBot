# Destiny.Model.DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LargeIcon** | **string** | I regret calling this a \&quot;large icon\&quot;. It&#39;s more like a medium-sized image with a picture of the vendor&#39;s mug on it, trying their best to look cool. Not what one would call an icon. | [optional] 
**Subtitle** | **string** |  | [optional] 
**OriginalIcon** | **string** | If we replaced the icon with something more glitzy, this is the original icon that the vendor had according to the game&#39;s content. It may be more lame and/or have less razzle-dazzle. But who am I to tell you which icon to use. | [optional] 
**RequirementsDisplay** | [**List&lt;DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition&gt;**](DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition.md) | Vendors, in addition to expected display property data, may also show some \&quot;common requirements\&quot; as statically defined definition data. This might be when a vendor accepts a single type of currency, or when the currency is unique to the vendor and the designers wanted to show that currency when you interact with the vendor. | [optional] 
**SmallTransparentIcon** | **string** | This is the icon used in parts of the game UI such as the vendor&#39;s waypoint. | [optional] 
**MapIcon** | **string** | This is the icon used in the map overview, when the vendor is located on the map. | [optional] 
**LargeTransparentIcon** | **string** | This is apparently the \&quot;Watermark\&quot;. I am not certain offhand where this is actually used in the Game UI, but some people may find it useful. | [optional] 
**Description** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**Icon** | **string** | Note that \&quot;icon\&quot; is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition&#39;s icon was a big picture of a book.  But usually, it will be a small square image that you can use as... well, an icon.  They are currently represented as 96px x 96px images. | [optional] 
**IconSequences** | [**List&lt;DestinyDefinitionsCommonDestinyIconSequenceDefinition&gt;**](DestinyDefinitionsCommonDestinyIconSequenceDefinition.md) |  | [optional] 
**HighResIcon** | **string** | If this item has a high-res icon (at least for now, many things won&#39;t), then the path to that icon will be here. | [optional] 
**HasIcon** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

