# Destiny.Model.DestinyDefinitionsDestinyRaceDefinition
In Destiny, \"Races\" are really more like \"Species\". Sort of. I mean, are the Awoken a separate species from humans? I'm not sure. But either way, they're defined here. You'll see Exo, Awoken, and Human as examples of these Species. Players will choose one for their character.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**RaceType** | **int** | An enumeration defining the existing, known Races/Species for player characters. This value will be the enum value matching this definition. | [optional] 
**GenderedRaceNames** | **Dictionary&lt;string, string&gt;** | A localized string referring to the singular form of the Race&#39;s name when referred to in gendered form. Keyed by the DestinyGender. | [optional] 
**GenderedRaceNamesByGenderHash** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

