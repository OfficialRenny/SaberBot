# Destiny.Model.DestinyComponentsProfilesDestinyProfileTransitoryTrackingEntry
This represents a single \"thing\" being tracked by the player.  This can point to many types of entities, but only a subset of them will actually have a valid hash identifier for whatever it is being pointed to.  It's up to you to interpret what it means when various combinations of these entries have values being tracked.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationHash** | **int?** | OPTIONAL - If this is tracking a DestinyLocationDefinition, this is the identifier for that location. | [optional] 
**ItemHash** | **int?** | OPTIONAL - If this is tracking the status of a DestinyInventoryItemDefinition, this is the identifier for that item. | [optional] 
**ObjectiveHash** | **int?** | OPTIONAL - If this is tracking the status of a DestinyObjectiveDefinition, this is the identifier for that objective. | [optional] 
**ActivityHash** | **int?** | OPTIONAL - If this is tracking the status of a DestinyActivityDefinition, this is the identifier for that activity. | [optional] 
**QuestlineItemHash** | **int?** | OPTIONAL - If this is tracking the status of a quest, this is the identifier for the DestinyInventoryItemDefinition that containst that questline data. | [optional] 
**TrackedDate** | **DateTime?** | OPTIONAL - I&#39;ve got to level with you, I don&#39;t really know what this is. Is it when you started tracking it? Is it only populated for tracked items that have time limits?  I don&#39;t know, but we can get at it - when I get time to actually test what it is, I&#39;ll update this. In the meantime, bask in the mysterious data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

