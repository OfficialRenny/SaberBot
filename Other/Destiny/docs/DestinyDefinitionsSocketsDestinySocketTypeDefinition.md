# Destiny.Model.DestinyDefinitionsSocketsDestinySocketTypeDefinition
All Sockets have a \"Type\": a set of common properties that determine when the socket allows Plugs to be inserted, what Categories of Plugs can be inserted, and whether the socket is even visible at all given the current game/character/account state.  See DestinyInventoryItemDefinition for more information about Socketed items and Plugs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**InsertAction** | [**DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition**](DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition.md) |  | [optional] 
**PlugWhitelist** | [**List&lt;DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition&gt;**](DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition.md) | A list of Plug \&quot;Categories\&quot; that are allowed to be plugged into sockets of this type.  These should be compared against a given plug item&#39;s DestinyInventoryItemDefinition.plug.plugCategoryHash, which indicates the plug item&#39;s category.  If the plug&#39;s category matches any whitelisted plug, or if the whitelist is empty, it is allowed to be inserted. | [optional] 
**SocketCategoryHash** | **int** |  | [optional] 
**Visibility** | **int** | Sometimes a socket isn&#39;t visible. These are some of the conditions under which sockets of this type are not visible. Unfortunately, the truth of visibility is much, much more complex. Best to rely on the live data for whether the socket is visible and enabled. | [optional] 
**AlwaysRandomizeSockets** | **bool** |  | [optional] 
**IsPreviewEnabled** | **bool** |  | [optional] 
**HideDuplicateReusablePlugs** | **bool** |  | [optional] 
**OverridesUiAppearance** | **bool** | This property indicates if the socket type determines whether Emblem icons and nameplates should be overridden by the inserted plug item&#39;s icon and nameplate. | [optional] 
**AvoidDuplicatesOnInitialization** | **bool** |  | [optional] 
**CurrencyScalars** | [**List&lt;DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry&gt;**](DestinyDefinitionsSocketsDestinySocketTypeScalarMaterialRequirementEntry.md) |  | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

