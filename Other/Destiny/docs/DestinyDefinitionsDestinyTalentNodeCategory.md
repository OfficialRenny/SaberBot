# Destiny.Model.DestinyDefinitionsDestinyTalentNodeCategory
An artificial construct provided by Bungie.Net, where we attempt to group talent nodes by functionality.  This is a single set of references to Talent Nodes that share a common trait or purpose.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | Mostly just for debug purposes, but if you find it useful you can have it. This is BNet&#39;s manually created identifier for this category. | [optional] 
**IsLoreDriven** | **bool** | If true, we found the localized content in a related DestinyLoreDefinition instead of local BNet localization files. This is mostly for ease of my own future investigations. | [optional] 
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**NodeHashes** | **List&lt;int&gt;** | The set of all hash identifiers for Talent Nodes (DestinyTalentNodeDefinition) in this Talent Grid that are part of this Category. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

