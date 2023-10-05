# Destiny.Model.DestinyDefinitionsDestinyProgressionRewardItemQuantity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RewardedAtProgressionLevel** | **int** |  | [optional] 
**AcquisitionBehavior** | **int** |  | [optional] 
**UiDisplayStyle** | **string** |  | [optional] 
**ClaimUnlockDisplayStrings** | **List&lt;string&gt;** |  | [optional] 
**ItemHash** | **int** | The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition. | [optional] 
**ItemInstanceId** | **long?** | If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null. | [optional] 
**Quantity** | **int** | The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used. | [optional] 
**HasConditionalVisibility** | **bool** | Indicates that this item quantity may be conditionally shown or hidden, based on various sources of state. For example: server flags, account state, or character progress. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

