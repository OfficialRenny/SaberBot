# Destiny.Model.DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition
Represents types of Energy that can be used for costs and payments related to Armor 2.0 mods.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**TransparentIconPath** | **string** | A variant of the icon that is transparent and colorless. | [optional] 
**ShowIcon** | **bool** | If TRUE, the game shows this Energy type&#39;s icon. Otherwise, it doesn&#39;t. Whether you show it or not is up to you. | [optional] 
**EnumValue** | **int** | We have an enumeration for Energy types for quick reference. This is the current definition&#39;s Energy type enum value. | [optional] 
**CapacityStatHash** | **int?** | If this Energy Type can be used for determining the Type of Energy that an item can consume, this is the hash for the DestinyInvestmentStatDefinition that represents the stat which holds the Capacity for that energy type. (Note that this is optional because \&quot;Any\&quot; is a valid cost, but not valid for Capacity - an Armor must have a specific Energy Type for determining the energy type that the Armor is restricted to use) | [optional] 
**CostStatHash** | **int** | If this Energy Type can be used as a cost to pay for socketing Armor 2.0 items, this is the hash for the DestinyInvestmentStatDefinition that stores the plug&#39;s raw cost. | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

