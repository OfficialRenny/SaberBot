# Destiny.Model.GroupsV2GroupResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Detail** | [**GroupsV2GroupV2**](GroupsV2GroupV2.md) |  | [optional] 
**Founder** | [**GroupsV2GroupMember**](GroupsV2GroupMember.md) |  | [optional] 
**AlliedIds** | **List&lt;long&gt;** |  | [optional] 
**ParentGroup** | [**GroupsV2GroupV2**](GroupsV2GroupV2.md) |  | [optional] 
**AllianceStatus** | **int** |  | [optional] 
**GroupJoinInviteCount** | **int** |  | [optional] 
**CurrentUserMembershipsInactiveForDestiny** | **bool** | A convenience property that indicates if every membership you (the current user) have that is a part of this group are part of an account that is considered inactive - for example, overridden accounts in Cross Save. | [optional] 
**CurrentUserMemberMap** | [**Dictionary&lt;string, GroupsV2GroupMember&gt;**](GroupsV2GroupMember.md) | This property will be populated if the authenticated user is a member of the group. Note that because of account linking, a user can sometimes be part of a clan more than once. As such, this returns the highest member type available. | [optional] 
**CurrentUserPotentialMemberMap** | [**Dictionary&lt;string, GroupsV2GroupPotentialMember&gt;**](GroupsV2GroupPotentialMember.md) | This property will be populated if the authenticated user is an applicant or has an outstanding invitation to join. Note that because of account linking, a user can sometimes be part of a clan more than once. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

