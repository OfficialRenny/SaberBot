# Destiny.Model.GroupsV2GroupQuery
NOTE: GroupQuery, as of Destiny 2, has essentially two totally different and incompatible \"modes\".  If you are querying for a group, you can pass any of the properties below.  If you are querying for a Clan, you MUST NOT pass any of the following properties (they must be null or undefined in your request, not just empty string/default values):  - groupMemberCountFilter - localeFilter - tagText  If you pass these, you will get a useless InvalidParameters error.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | [optional] 
**GroupType** | **int** |  | [optional] 
**CreationDate** | **int** |  | [optional] 
**SortBy** | **int** |  | [optional] 
**GroupMemberCountFilter** | **int?** |  | [optional] 
**LocaleFilter** | **string** |  | [optional] 
**TagText** | **string** |  | [optional] 
**ItemsPerPage** | **int** |  | [optional] 
**CurrentPage** | **int** |  | [optional] 
**RequestContinuationToken** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

