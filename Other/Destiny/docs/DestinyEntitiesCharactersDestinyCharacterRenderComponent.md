# Destiny.Model.DestinyEntitiesCharactersDestinyCharacterRenderComponent
Only really useful if you're attempting to render the character's current appearance in 3D, this returns a bare minimum of information, pre-aggregated, that you'll need to perform that rendering. Note that you need to combine this with other 3D assets and data from our servers.  Examine the Javascript returned by https://bungie.net/sharedbundle/spasm to see how we use this data, but be warned: the rabbit hole goes pretty deep.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomDyes** | [**List&lt;DestinyDyeReference&gt;**](DestinyDyeReference.md) | Custom dyes, calculated by iterating over the character&#39;s equipped items. Useful for pre-fetching all of the dye data needed from our server. | [optional] 
**Customization** | [**DestinyCharacterDestinyCharacterCustomization**](DestinyCharacterDestinyCharacterCustomization.md) |  | [optional] 
**PeerView** | [**DestinyCharacterDestinyCharacterPeerView**](DestinyCharacterDestinyCharacterPeerView.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

