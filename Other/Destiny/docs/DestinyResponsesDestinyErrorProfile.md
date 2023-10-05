# Destiny.Model.DestinyResponsesDestinyErrorProfile
If a Destiny Profile can't be returned, but we're pretty certain it's a valid Destiny account, this will contain as much info as we can get about the profile for your use.  Assume that the most you'll get is the Error Code, the Membership Type and the Membership ID.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ErrorCode** | **int** | The error that we encountered. You should be able to look up localized text to show to the user for these failures. | [optional] 
**InfoCard** | [**UserUserInfoCard**](UserUserInfoCard.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

