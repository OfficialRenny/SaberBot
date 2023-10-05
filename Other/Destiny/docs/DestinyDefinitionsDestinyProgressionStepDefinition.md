# Destiny.Model.DestinyDefinitionsDestinyProgressionStepDefinition
This defines a single Step in a progression (which roughly equates to a level. See DestinyProgressionDefinition for caveats).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StepName** | **string** | Very rarely, Progressions will have localized text describing the Level of the progression. This will be that localized text, if it exists. Otherwise, the standard appears to be to simply show the level numerically. | [optional] 
**DisplayEffectType** | **int** | This appears to be, when you \&quot;level up\&quot;, whether a visual effect will display and on what entity. See DestinyProgressionStepDisplayEffect for slightly more info. | [optional] 
**ProgressTotal** | **int** | The total amount of progression points/\&quot;experience\&quot; you will need to initially reach this step. If this is the last step and the progression is repeating indefinitely (DestinyProgressionDefinition.repeatLastStep), this will also be the progress needed to level it up further by repeating this step again. | [optional] 
**RewardItems** | [**List&lt;DestinyDestinyItemQuantity&gt;**](DestinyDestinyItemQuantity.md) | A listing of items rewarded as a result of reaching this level. | [optional] 
**Icon** | **string** | If this progression step has a specific icon related to it, this is the icon to show. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

