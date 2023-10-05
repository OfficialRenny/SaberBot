# Destiny.Model.UserEmailSubscriptionDefinition
Defines a single subscription: permission to send emails for a specific, focused subject (generally timeboxed, such as for a specific release of a product or feature).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The unique identifier for this subscription. | [optional] 
**Localization** | [**Dictionary&lt;string, UserEMailSettingSubscriptionLocalization&gt;**](UserEMailSettingSubscriptionLocalization.md) | A dictionary of localized text for the EMail Opt-in setting, keyed by the locale. | [optional] 
**Value** | **long** | The bitflag value for this subscription. Should be a unique power of two value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

