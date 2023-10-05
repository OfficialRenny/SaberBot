# Destiny.Model.DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity
If you are playing in an activity, this is some information about it.  Note that we cannot guarantee any of this resembles what ends up in the PGCR in any way. They are sourced by two entirely separate systems with their own logic, and the one we source this data from should be considered non-authoritative in comparison.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartTime** | **DateTime?** | When the activity started. | [optional] 
**EndTime** | **DateTime?** | If you&#39;re still in it but it \&quot;ended\&quot; (like when folks are dancing around the loot after they beat a boss), this is when the activity ended. | [optional] 
**Score** | **float** | This is what our non-authoritative source thought the score was. | [optional] 
**HighestOpposingFactionScore** | **float** | If you have human opponents, this is the highest opposing team&#39;s score. | [optional] 
**NumberOfOpponents** | **int** | This is how many human or poorly crafted aimbot opponents you have. | [optional] 
**NumberOfPlayers** | **int** | This is how many human or poorly crafted aimbots are on your team. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

