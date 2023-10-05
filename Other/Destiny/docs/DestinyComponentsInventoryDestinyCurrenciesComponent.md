# Destiny.Model.DestinyComponentsInventoryDestinyCurrenciesComponent
This component provides a quick lookup of every item the requested character has and how much of that item they have.  Requesting this component will allow you to circumvent manually putting together the list of which currencies you have for the purpose of testing currency requirements on an item being purchased, or operations that have costs.  You *could* figure this out yourself by doing a GetCharacter or GetProfile request and forming your own lookup table, but that is inconvenient enough that this feels like a worthwhile (and optional) redundency. Don't bother requesting it if you have already created your own lookup from prior GetCharacter/GetProfile calls.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemQuantities** | **Dictionary&lt;string, int&gt;** | A dictionary - keyed by the item&#39;s hash identifier (DestinyInventoryItemDefinition), and whose value is the amount of that item you have across all available inventory buckets for purchasing.  This allows you to see whether the requesting character can afford any given purchase/action without having to re-create this list itself. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

