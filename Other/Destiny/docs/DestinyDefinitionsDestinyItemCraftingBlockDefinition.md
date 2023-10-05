# Destiny.Model.DestinyDefinitionsDestinyItemCraftingBlockDefinition
If an item can have an action performed on it (like \"Dismantle\"), it will be defined here if you care.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OutputItemHash** | **int** | A reference to the item definition that is created when crafting with this &#39;recipe&#39; item. | [optional] 
**RequiredSocketTypeHashes** | **List&lt;int&gt;** | A list of socket type hashes that describes which sockets are required for crafting with this recipe. | [optional] 
**FailedRequirementStrings** | **List&lt;string&gt;** |  | [optional] 
**BaseMaterialRequirements** | **int?** | A reference to the base material requirements for crafting with this recipe. | [optional] 
**BonusPlugs** | [**List&lt;DestinyDefinitionsDestinyItemCraftingBlockBonusPlugDefinition&gt;**](DestinyDefinitionsDestinyItemCraftingBlockBonusPlugDefinition.md) | A list of &#39;bonus&#39; socket plugs that may be available if certain requirements are met. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

