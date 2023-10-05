# Destiny.Model.UserEmailOptInDefinition
Defines a single opt-in category: a wide-scoped permission to send emails for the subject related to the opt-in.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The unique identifier for this opt-in category. | [optional] 
**Value** | **long** | The flag value for this opt-in category. For historical reasons, this is defined as a flags enum. | [optional] 
**SetByDefault** | **bool** | If true, this opt-in setting should be set by default in situations where accounts are created without explicit choices about what they&#39;re opting into. | [optional] 
**DependentSubscriptions** | [**List&lt;UserEmailSubscriptionDefinition&gt;**](UserEmailSubscriptionDefinition.md) | Information about the dependent subscriptions for this opt-in. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

