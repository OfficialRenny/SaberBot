# Destiny.Model.DestinyHistoricalStatsDestinyPostGameCarnageReportData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Period** | **DateTime** | Date and time for the activity. | [optional] 
**StartingPhaseIndex** | **int?** | If this activity has \&quot;phases\&quot;, this is the phase at which the activity was started. This value is only valid for activities before the Beyond Light expansion shipped. Subsequent activities will not have a valid value here. | [optional] 
**ActivityWasStartedFromBeginning** | **bool?** | True if the activity was started from the beginning, if that information is available and the activity was played post Witch Queen release. | [optional] 
**ActivityDetails** | [**DestinyHistoricalStatsDestinyHistoricalStatsActivity**](DestinyHistoricalStatsDestinyHistoricalStatsActivity.md) |  | [optional] 
**Entries** | [**List&lt;DestinyHistoricalStatsDestinyPostGameCarnageReportEntry&gt;**](DestinyHistoricalStatsDestinyPostGameCarnageReportEntry.md) | Collection of players and their data for this activity. | [optional] 
**Teams** | [**List&lt;DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry&gt;**](DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry.md) | Collection of stats for the player in this activity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

