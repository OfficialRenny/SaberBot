# Destiny.Model.DestinyResponsesDestinyProfileUserInfoCard

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateLastPlayed** | **DateTime** |  | [optional] 
**IsOverridden** | **bool** | If this profile is being overridden/obscured by Cross Save, this will be set to true. We will still return the profile for display purposes where users need to know the info: it is up to any given area of the app/site to determine if this profile should still be shown. | [optional] 
**IsCrossSavePrimary** | **bool** | If true, this account is hooked up as the \&quot;Primary\&quot; cross save account for one or more platforms. | [optional] 
**PlatformSilver** | [**DestinyComponentsInventoryDestinyPlatformSilverComponent**](DestinyComponentsInventoryDestinyPlatformSilverComponent.md) |  | [optional] 
**UnpairedGameVersions** | **int?** | If this profile is not in a cross save pairing, this will return the game versions that we believe this profile has access to.   For the time being, we will not return this information for any membership that is in a cross save pairing. The gist is that, once the pairing occurs, we do not currently have a consistent way to get that information for the profile&#39;s original Platform, and thus gameVersions would be too inconsistent (based on the last platform they happened to play on) for the info to be useful.   If we ever can get this data, this field will be deprecated and replaced with data on the DestinyLinkedProfileResponse itself, with game versions per linked Platform. But since we can&#39;t get that, we have this as a stop-gap measure for getting the data in the only situation that we currently need it. | [optional] 
**SupplementalDisplayName** | **string** | A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc. | [optional] 
**IconPath** | **string** | URL the Icon if available. | [optional] 
**CrossSaveOverride** | **int** | If there is a cross save override in effect, this value will tell you the type that is overridding this one. | [optional] 
**ApplicableMembershipTypes** | **List&lt;int&gt;** | The list of Membership Types indicating the platforms on which this Membership can be used.   Not in Cross Save &#x3D; its original membership type. Cross Save Primary &#x3D; Any membership types it is overridding, and its original membership type Cross Save Overridden &#x3D; Empty list | [optional] 
**IsPublic** | **bool** | If True, this is a public user membership. | [optional] 
**MembershipType** | **int** | Type of the membership. Not necessarily the native type. | [optional] 
**MembershipId** | **long** | Membership ID as they user is known in the Accounts service | [optional] 
**DisplayName** | **string** | Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API. | [optional] 
**BungieGlobalDisplayName** | **string** | The bungie global display name, if set. | [optional] 
**BungieGlobalDisplayNameCode** | **int?** | The bungie global display name code, if set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

