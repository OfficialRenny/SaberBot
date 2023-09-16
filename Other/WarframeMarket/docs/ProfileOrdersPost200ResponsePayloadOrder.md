# WarframeMarket.Model.ProfileOrdersPost200ResponsePayloadOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Platinum** | **int** |  | [optional] 
**Quantity** | **int** |  | [optional] 
**OrderType** | **string** |  | [optional] 
**Platform** | **string** |  | [optional] 
**Region** | **string** | will be deprecated eventually | [optional] 
**CreationDate** | **DateTime** |  | [optional] 
**LastUpdate** | **DateTime** |  | [optional] 
**Subtype** | **string** | subtyppe oof an item, all valid subtypes defined inside Item model &#x60;subtypes&#x60; field | [optional] 
**Visible** | **bool** | Is this order visible? All public orders will be visible, and only orders in your profile could be invisible.  | [optional] 
**Item** | [**ItemInOrder**](ItemInOrder.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

