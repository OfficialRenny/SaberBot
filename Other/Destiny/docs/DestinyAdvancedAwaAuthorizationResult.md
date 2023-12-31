# Destiny.Model.DestinyAdvancedAwaAuthorizationResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserSelection** | **int** | Indication of how the user responded to the request. If the value is \&quot;Approved\&quot; the actionToken will contain the token that can be presented when performing the advanced write action. | [optional] 
**ResponseReason** | **int** |  | [optional] 
**DeveloperNote** | **string** | Message to the app developer to help understand the response. | [optional] 
**ActionToken** | **string** | Credential used to prove the user authorized an advanced write action. | [optional] 
**MaximumNumberOfUses** | **int** | This token may be used to perform the requested action this number of times, at a maximum. If this value is 0, then there is no limit. | [optional] 
**ValidUntil** | **DateTime?** | Time, UTC, when token expires. | [optional] 
**Type** | **int** | Advanced Write Action Type from the permission request. | [optional] 
**MembershipType** | **int** | MembershipType from the permission request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

