# Destiny.Model.DestinyResponsesDestinyLinkedProfilesResponse
I know what you seek. You seek linked accounts. Found them, you have.  This contract returns a minimal amount of data about Destiny Accounts that are linked through your Bungie.Net account. We will not return accounts in this response whose

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profiles** | [**List&lt;DestinyResponsesDestinyProfileUserInfoCard&gt;**](DestinyResponsesDestinyProfileUserInfoCard.md) | Any Destiny account for whom we could successfully pull characters will be returned here, as the Platform-level summary of user data. (no character data, no Destiny account data other than the Membership ID and Type so you can make further queries) | [optional] 
**BnetMembership** | [**UserUserInfoCard**](UserUserInfoCard.md) |  | [optional] 
**ProfilesWithErrors** | [**List&lt;DestinyResponsesDestinyErrorProfile&gt;**](DestinyResponsesDestinyErrorProfile.md) | This is brief summary info for profiles that we believe have valid Destiny info, but who failed to return data for some other reason and thus we know that subsequent calls for their info will also fail. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

