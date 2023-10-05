# Destiny.Model.DestinyResponsesDestinyItemResponse
The response object for retrieving an individual instanced item. None of these components are relevant for an item that doesn't have an \"itemInstanceId\": for those, get your information from the DestinyInventoryDefinition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CharacterId** | **long?** | If the item is on a character, this will return the ID of the character that is holding the item. | [optional] 
**Item** | [**SingleComponentResponseOfDestinyItemComponent**](SingleComponentResponseOfDestinyItemComponent.md) |  | [optional] 
**Instance** | [**SingleComponentResponseOfDestinyItemInstanceComponent**](SingleComponentResponseOfDestinyItemInstanceComponent.md) |  | [optional] 
**Objectives** | [**SingleComponentResponseOfDestinyItemObjectivesComponent**](SingleComponentResponseOfDestinyItemObjectivesComponent.md) |  | [optional] 
**Perks** | [**SingleComponentResponseOfDestinyItemPerksComponent**](SingleComponentResponseOfDestinyItemPerksComponent.md) |  | [optional] 
**RenderData** | [**SingleComponentResponseOfDestinyItemRenderComponent**](SingleComponentResponseOfDestinyItemRenderComponent.md) |  | [optional] 
**Stats** | [**SingleComponentResponseOfDestinyItemStatsComponent**](SingleComponentResponseOfDestinyItemStatsComponent.md) |  | [optional] 
**TalentGrid** | [**SingleComponentResponseOfDestinyItemTalentGridComponent**](SingleComponentResponseOfDestinyItemTalentGridComponent.md) |  | [optional] 
**Sockets** | [**SingleComponentResponseOfDestinyItemSocketsComponent**](SingleComponentResponseOfDestinyItemSocketsComponent.md) |  | [optional] 
**ReusablePlugs** | [**SingleComponentResponseOfDestinyItemReusablePlugsComponent**](SingleComponentResponseOfDestinyItemReusablePlugsComponent.md) |  | [optional] 
**PlugObjectives** | [**SingleComponentResponseOfDestinyItemPlugObjectivesComponent**](SingleComponentResponseOfDestinyItemPlugObjectivesComponent.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

