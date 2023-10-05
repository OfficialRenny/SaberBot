# Destiny.Model.DestinyComponentsProfilesDestinyProfileTransitoryComponent
This is an experimental set of data that Bungie considers to be \"transitory\" - information that may be useful for API users, but that is coming from a non-authoritative data source about information that could potentially change at a more frequent pace than Bungie.net will receive updates about it.  This information is provided exclusively for convenience should any of it be useful to users: we provide no guarantees to the accuracy or timeliness of data that comes from this source. Know that this data can potentially be out-of-date or even wrong entirely if the user disconnected from the game or suddenly changed their status before we can receive refreshed data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PartyMembers** | [**List&lt;DestinyComponentsProfilesDestinyProfileTransitoryPartyMember&gt;**](DestinyComponentsProfilesDestinyProfileTransitoryPartyMember.md) | If you have any members currently in your party, this is some (very) bare-bones information about those members. | [optional] 
**CurrentActivity** | [**DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity**](DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity.md) |  | [optional] 
**Joinability** | [**DestinyComponentsProfilesDestinyProfileTransitoryJoinability**](DestinyComponentsProfilesDestinyProfileTransitoryJoinability.md) |  | [optional] 
**Tracking** | [**List&lt;DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry&gt;**](DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry.md) | Information about tracked entities. | [optional] 
**LastOrbitedDestinationHash** | **int?** | The hash identifier for the DestinyDestinationDefinition of the last location you were orbiting when in orbit. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

