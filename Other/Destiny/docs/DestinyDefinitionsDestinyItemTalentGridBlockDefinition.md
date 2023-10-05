# Destiny.Model.DestinyDefinitionsDestinyItemTalentGridBlockDefinition
This defines information that can only come from a talent grid on an item. Items mostly have negligible talent grid data these days, but instanced items still retain grids as a source for some of this common information.  Builds/Subclasses are the only items left that still have talent grids with meaningful Nodes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TalentGridHash** | **int** | The hash identifier of the DestinyTalentGridDefinition attached to this item. | [optional] 
**ItemDetailString** | **string** | This is meant to be a subtitle for looking at the talent grid. In practice, somewhat frustratingly, this always merely says the localized word for \&quot;Details\&quot;. Great. Maybe it&#39;ll have more if talent grids ever get used for more than builds and subclasses again. | [optional] 
**BuildName** | **string** | A shortcut string identifier for the \&quot;build\&quot; in question, if this talent grid has an associated build. Doesn&#39;t map to anything we can expose at the moment. | [optional] 
**HudDamageType** | **int** | If the talent grid implies a damage type, this is the enum value for that damage type. | [optional] 
**HudIcon** | **string** | If the talent grid has a special icon that&#39;s shown in the game UI (like builds, funny that), this is the identifier for that icon. Sadly, we don&#39;t actually get that icon right now. I&#39;ll be looking to replace this with a path to the actual icon itself. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

