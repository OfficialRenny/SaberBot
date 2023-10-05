# Destiny.Model.DestinyDefinitionsDestinySandboxPerkDefinition
Perks are modifiers to a character or item that can be applied situationally.  - Perks determine a weapons' damage type.  - Perks put the Mods in Modifiers (they are literally the entity that bestows the Sandbox benefit for whatever fluff text about the modifier in the Socket, Plug or Talent Node)  - Perks are applied for unique alterations of state in Objectives  Anyways, I'm sure you can see why perks are so interesting.  What Perks often don't have is human readable information, so we attempt to reverse engineer that by pulling that data from places that uniquely refer to these perks: namely, Talent Nodes and Plugs. That only gives us a subset of perks that are human readable, but those perks are the ones people generally care about anyways. The others are left as a mystery, their true purpose mostly unknown and undocumented.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**PerkIdentifier** | **string** | The string identifier for the perk. | [optional] 
**IsDisplayable** | **bool** | If true, you can actually show the perk in the UI. Otherwise, it doesn&#39;t have useful player-facing information. | [optional] 
**DamageType** | **int** | If this perk grants a damage type to a weapon, the damage type will be defined here.  Unless you have a compelling reason to use this enum value, use the damageTypeHash instead to look up the actual DestinyDamageTypeDefinition. | [optional] 
**DamageTypeHash** | **int?** | The hash identifier for looking up the DestinyDamageTypeDefinition, if this perk has a damage type.  This is preferred over using the damageType enumeration value, which has been left purely because it is occasionally convenient. | [optional] 
**PerkGroups** | [**DestinyDefinitionsDestinyTalentNodeStepGroups**](DestinyDefinitionsDestinyTalentNodeStepGroups.md) |  | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

