# Destiny.Model.DestinyDefinitionsDestinyActivityInsertionPointDefinition
A point of entry into an activity, gated by an unlock flag and with some more-or-less useless (for our purposes) phase information. I'm including it in case we end up being able to bolt more useful information onto it in the future.  UPDATE: Turns out this information isn't actually useless, and is in fact actually useful for people. Who would have thought? We still don't have localized info for it, but at least this will help people when they're looking at phase indexes in stats data, or when they want to know what phases have been completed on a weekly achievement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PhaseHash** | **int** | A unique hash value representing the phase. This can be useful for, for example, comparing how different instances of Raids have phases in different orders! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

