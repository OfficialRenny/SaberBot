# Destiny.Model.DestinyDefinitionsItemsDestinyPlugRuleDefinition
Dictates a rule around whether the plug is enabled or insertable.  In practice, the live Destiny data will refer to these entries by index. You can then look up that index in the appropriate property (enabledRules or insertionRules) to get the localized string for the failure message if it failed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FailureMessage** | **string** | The localized string to show if this rule fails. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

