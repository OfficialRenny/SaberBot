# Destiny.Model.DestinyResponsesDestinyVendorsResponse
A response containing all of the components for all requested vendors.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorGroups** | [**SingleComponentResponseOfDestinyVendorGroupComponent**](SingleComponentResponseOfDestinyVendorGroupComponent.md) |  | [optional] 
**Vendors** | [**DictionaryComponentResponseOfuint32AndDestinyVendorComponent**](DictionaryComponentResponseOfuint32AndDestinyVendorComponent.md) |  | [optional] 
**Categories** | [**DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent**](DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent.md) |  | [optional] 
**Sales** | [**DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent**](DictionaryComponentResponseOfuint32AndPersonalDestinyVendorSaleItemSetComponent.md) |  | [optional] 
**ItemComponents** | [**Dictionary&lt;string, DestinyItemComponentSetOfint32&gt;**](DestinyItemComponentSetOfint32.md) | The set of item detail components, one set of item components per Vendor. These are keyed by the Vendor Hash, so you will get one Item Component Set per vendor returned.  The components contained inside are themselves keyed by the vendorSaleIndex, and will have whatever item-level components you requested (Sockets, Stats, Instance data etc...) per item being sold by the vendor. | [optional] 
**CurrencyLookups** | [**SingleComponentResponseOfDestinyCurrenciesComponent**](SingleComponentResponseOfDestinyCurrenciesComponent.md) |  | [optional] 
**StringVariables** | [**SingleComponentResponseOfDestinyStringVariablesComponent**](SingleComponentResponseOfDestinyStringVariablesComponent.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

