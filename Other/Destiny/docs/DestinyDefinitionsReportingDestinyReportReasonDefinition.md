# Destiny.Model.DestinyDefinitionsReportingDestinyReportReasonDefinition
A specific reason for being banned. Only accessible under the related category (DestinyReportReasonCategoryDefinition) under which it is shown. Note that this means that report reasons' reasonHash are not globally unique: and indeed, entries like \"Other\" are defined under most categories for example.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReasonHash** | **int** | The identifier for the reason: they are only guaranteed unique under the Category in which they are found. | [optional] 
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

