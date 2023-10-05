# Destiny.Model.UserCrossSaveUserMembership
Very basic info about a user as returned by the Account server, but including CrossSave information. Do NOT use as a request contract.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CrossSaveOverride** | **int** | If there is a cross save override in effect, this value will tell you the type that is overridding this one. | [optional] 
**ApplicableMembershipTypes** | **List&lt;int&gt;** | The list of Membership Types indicating the platforms on which this Membership can be used.   Not in Cross Save &#x3D; its original membership type. Cross Save Primary &#x3D; Any membership types it is overridding, and its original membership type Cross Save Overridden &#x3D; Empty list | [optional] 
**IsPublic** | **bool** | If True, this is a public user membership. | [optional] 
**MembershipType** | **int** | Type of the membership. Not necessarily the native type. | [optional] 
**MembershipId** | **long** | Membership ID as they user is known in the Accounts service | [optional] 
**DisplayName** | **string** | Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API. | [optional] 
**BungieGlobalDisplayName** | **string** | The bungie global display name, if set. | [optional] 
**BungieGlobalDisplayNameCode** | **int?** | The bungie global display name code, if set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

