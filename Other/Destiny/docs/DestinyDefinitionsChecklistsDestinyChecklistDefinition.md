# Destiny.Model.DestinyDefinitionsChecklistsDestinyChecklistDefinition
By public demand, Checklists are loose sets of \"things to do/things you have done\" in Destiny that we were actually able to track. They include easter eggs you find in the world, unique chests you unlock, and other such data where the first time you do it is significant enough to be tracked, and you have the potential to \"get them all\".  These may be account-wide, or may be per character. The status of these will be returned in related \"Checklist\" data coming down from API requests such as GetProfile or GetCharacter.  Generally speaking, the items in a checklist can be completed in any order: we return an ordered list which only implies the way we are showing them in our own UI, and you can feel free to alter it as you wish.  Note that, in the future, there will be something resembling the old D1 Record Books in at least some vague form. When that is created, it may be that it will supercede much or all of this Checklist data. It remains to be seen if that will be the case, so for now assume that the Checklists will still exist even after the release of D2: Forsaken.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**ViewActionString** | **string** | A localized string prompting you to view the checklist. | [optional] 
**Scope** | **int** | Indicates whether you will find this checklist on the Profile or Character components. | [optional] 
**Entries** | [**List&lt;DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition&gt;**](DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition.md) | The individual checklist items. Gotta catch &#39;em all. | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

