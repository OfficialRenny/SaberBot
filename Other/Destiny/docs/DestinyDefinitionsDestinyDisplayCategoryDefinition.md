# Destiny.Model.DestinyDefinitionsDestinyDisplayCategoryDefinition
Display Categories are different from \"categories\" in that these are specifically for visual grouping and display of categories in Vendor UI. The \"categories\" structure is for validation of the contained items, and can be categorized entirely separately from \"Display Categories\", there need be and often will be no meaningful relationship between the two.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **int** |  | [optional] 
**Identifier** | **string** | A string identifier for the display category. | [optional] 
**DisplayCategoryHash** | **int** |  | [optional] 
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**DisplayInBanner** | **bool** | If true, this category should be displayed in the \&quot;Banner\&quot; section of the vendor&#39;s UI. | [optional] 
**ProgressionHash** | **int?** | If it exists, this is the hash identifier of a DestinyProgressionDefinition that represents the progression to show on this display category.  Specific categories can now have thier own distinct progression, apparently. So that&#39;s cool. | [optional] 
**SortOrder** | **int** | If this category sorts items in a nonstandard way, this will be the way we sort. | [optional] 
**DisplayStyleHash** | **int?** | An indicator of how the category will be displayed in the UI. It&#39;s up to you to do something cool or interesting in response to this, or just to treat it as a normal category. | [optional] 
**DisplayStyleIdentifier** | **string** | An indicator of how the category will be displayed in the UI. It&#39;s up to you to do something cool or interesting in response to this, or just to treat it as a normal category. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

