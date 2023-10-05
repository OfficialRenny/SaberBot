# Destiny.Model.DestinyResponsesDestinyProfileResponse
The response for GetDestinyProfile, with components for character and item-level data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResponseMintedTimestamp** | **DateTime** | Records the timestamp of when most components were last generated from the world server source. Unless the component type is specified in the documentation for secondaryComponentsMintedTimestamp, this value is sufficient to do data freshness. | [optional] 
**SecondaryComponentsMintedTimestamp** | **DateTime** | Some secondary components are not tracked in the primary response timestamp and have their timestamp tracked here. If your component is any of the following, this field is where you will find your timestamp value:   PresentationNodes, Records, Collectibles, Metrics, StringVariables, Craftables, Transitory   All other component types may use the primary timestamp property. | [optional] 
**VendorReceipts** | [**SingleComponentResponseOfDestinyVendorReceiptsComponent**](SingleComponentResponseOfDestinyVendorReceiptsComponent.md) |  | [optional] 
**ProfileInventory** | [**SingleComponentResponseOfDestinyInventoryComponent**](SingleComponentResponseOfDestinyInventoryComponent.md) |  | [optional] 
**ProfileCurrencies** | [**SingleComponentResponseOfDestinyInventoryComponent**](SingleComponentResponseOfDestinyInventoryComponent.md) |  | [optional] 
**Profile** | [**SingleComponentResponseOfDestinyProfileComponent**](SingleComponentResponseOfDestinyProfileComponent.md) |  | [optional] 
**PlatformSilver** | [**SingleComponentResponseOfDestinyPlatformSilverComponent**](SingleComponentResponseOfDestinyPlatformSilverComponent.md) |  | [optional] 
**ProfileKiosks** | [**SingleComponentResponseOfDestinyKiosksComponent**](SingleComponentResponseOfDestinyKiosksComponent.md) |  | [optional] 
**ProfilePlugSets** | [**SingleComponentResponseOfDestinyPlugSetsComponent**](SingleComponentResponseOfDestinyPlugSetsComponent.md) |  | [optional] 
**ProfileProgression** | [**SingleComponentResponseOfDestinyProfileProgressionComponent**](SingleComponentResponseOfDestinyProfileProgressionComponent.md) |  | [optional] 
**ProfilePresentationNodes** | [**SingleComponentResponseOfDestinyPresentationNodesComponent**](SingleComponentResponseOfDestinyPresentationNodesComponent.md) |  | [optional] 
**ProfileRecords** | [**SingleComponentResponseOfDestinyProfileRecordsComponent**](SingleComponentResponseOfDestinyProfileRecordsComponent.md) |  | [optional] 
**ProfileCollectibles** | [**SingleComponentResponseOfDestinyProfileCollectiblesComponent**](SingleComponentResponseOfDestinyProfileCollectiblesComponent.md) |  | [optional] 
**ProfileTransitoryData** | [**SingleComponentResponseOfDestinyProfileTransitoryComponent**](SingleComponentResponseOfDestinyProfileTransitoryComponent.md) |  | [optional] 
**Metrics** | [**SingleComponentResponseOfDestinyMetricsComponent**](SingleComponentResponseOfDestinyMetricsComponent.md) |  | [optional] 
**ProfileStringVariables** | [**SingleComponentResponseOfDestinyStringVariablesComponent**](SingleComponentResponseOfDestinyStringVariablesComponent.md) |  | [optional] 
**ProfileCommendations** | [**SingleComponentResponseOfDestinySocialCommendationsComponent**](SingleComponentResponseOfDestinySocialCommendationsComponent.md) |  | [optional] 
**Characters** | [**DictionaryComponentResponseOfint64AndDestinyCharacterComponent**](DictionaryComponentResponseOfint64AndDestinyCharacterComponent.md) |  | [optional] 
**CharacterInventories** | [**DictionaryComponentResponseOfint64AndDestinyInventoryComponent**](DictionaryComponentResponseOfint64AndDestinyInventoryComponent.md) |  | [optional] 
**CharacterLoadouts** | [**DictionaryComponentResponseOfint64AndDestinyLoadoutsComponent**](DictionaryComponentResponseOfint64AndDestinyLoadoutsComponent.md) |  | [optional] 
**CharacterProgressions** | [**DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent**](DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent.md) |  | [optional] 
**CharacterRenderData** | [**DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent**](DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent.md) |  | [optional] 
**CharacterActivities** | [**DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent**](DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent.md) |  | [optional] 
**CharacterEquipment** | [**DictionaryComponentResponseOfint64AndDestinyInventoryComponent**](DictionaryComponentResponseOfint64AndDestinyInventoryComponent.md) |  | [optional] 
**CharacterKiosks** | [**DictionaryComponentResponseOfint64AndDestinyKiosksComponent**](DictionaryComponentResponseOfint64AndDestinyKiosksComponent.md) |  | [optional] 
**CharacterPlugSets** | [**DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent**](DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent.md) |  | [optional] 
**CharacterUninstancedItemComponents** | [**Dictionary&lt;string, DestinyBaseItemComponentSetOfuint32&gt;**](DestinyBaseItemComponentSetOfuint32.md) | Do you ever get the feeling that a system was designed *too* flexibly? That it can be used in so many different ways that you end up being unable to provide an easy to use abstraction for the mess that&#39;s happening under the surface?  Let&#39;s talk about character-specific data that might be related to items without instances. These two statements are totally unrelated, I promise.  At some point during D2, it was decided that items - such as Bounties - could be given to characters and *not* have instance data, but that *could* display and even use relevant state information on your account and character.  Up to now, any item that had meaningful dependencies on character or account state had to be instanced, and thus \&quot;itemComponents\&quot; was all that you needed: it was keyed by item&#39;s instance IDs and provided the stateful information you needed inside.  Unfortunately, we don&#39;t live in such a magical world anymore. This is information held on a per-character basis about non-instanced items that the characters have in their inventory - or that reference character-specific state information even if it&#39;s in Account-level inventory - and the values related to that item&#39;s state in relation to the given character.  To give a concrete example, look at a Moments of Triumph bounty. They exist in a character&#39;s inventory, and show/care about a character&#39;s progression toward completing the bounty. But the bounty itself is a non-instanced item, like a mod or a currency. This returns that data for the characters who have the bounty in their inventory.  I&#39;m not crying, you&#39;re crying Okay we&#39;re both crying but it&#39;s going to be okay I promise Actually I shouldn&#39;t promise that, I don&#39;t know if it&#39;s going to be okay | [optional] 
**CharacterPresentationNodes** | [**DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent**](DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent.md) |  | [optional] 
**CharacterRecords** | [**DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent**](DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent.md) |  | [optional] 
**CharacterCollectibles** | [**DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent**](DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent.md) |  | [optional] 
**CharacterStringVariables** | [**DictionaryComponentResponseOfint64AndDestinyStringVariablesComponent**](DictionaryComponentResponseOfint64AndDestinyStringVariablesComponent.md) |  | [optional] 
**CharacterCraftables** | [**DictionaryComponentResponseOfint64AndDestinyCraftablesComponent**](DictionaryComponentResponseOfint64AndDestinyCraftablesComponent.md) |  | [optional] 
**ItemComponents** | [**DestinyItemComponentSetOfint64**](DestinyItemComponentSetOfint64.md) |  | [optional] 
**CharacterCurrencyLookups** | [**DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent**](DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

