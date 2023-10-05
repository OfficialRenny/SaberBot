# Destiny.Model.DestinyResponsesDestinyPublicVendorsResponse
A response containing all valid components for the public Vendors endpoint.   It is a decisively smaller subset of data compared to what we can get when we know the specific user making the request.   If you want any of the other data - item details, whether or not you can buy it, etc... you'll have to call in the context of a character. I know, sad but true.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorGroups** | [**SingleComponentResponseOfDestinyVendorGroupComponent**](SingleComponentResponseOfDestinyVendorGroupComponent.md) |  | [optional] 
**Vendors** | [**DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent**](DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent.md) |  | [optional] 
**Categories** | [**DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent**](DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent.md) |  | [optional] 
**Sales** | [**DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent**](DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent.md) |  | [optional] 
**StringVariables** | [**SingleComponentResponseOfDestinyStringVariablesComponent**](SingleComponentResponseOfDestinyStringVariablesComponent.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

