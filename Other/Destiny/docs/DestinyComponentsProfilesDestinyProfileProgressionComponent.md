# Destiny.Model.DestinyComponentsProfilesDestinyProfileProgressionComponent
The set of progression-related information that applies at a Profile-wide level for your Destiny experience. This differs from the Jimi Hendrix Experience because there's less guitars on fire. Yet. #spoileralert?  This will include information such as Checklist info.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Checklists** | **Dictionary&lt;string, Dictionary&lt;string, bool&gt;&gt;** | The set of checklists that can be examined on a profile-wide basis, keyed by the hash identifier of the Checklist (DestinyChecklistDefinition)  For each checklist returned, its value is itself a Dictionary keyed by the checklist&#39;s hash identifier with the value being a boolean indicating if it&#39;s been discovered yet. | [optional] 
**SeasonalArtifact** | [**DestinyArtifactsDestinyArtifactProfileScoped**](DestinyArtifactsDestinyArtifactProfileScoped.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

