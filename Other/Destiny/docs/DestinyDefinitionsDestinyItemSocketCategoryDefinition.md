# Destiny.Model.DestinyDefinitionsDestinyItemSocketCategoryDefinition
Sockets are grouped into categories in the UI. These define which category and which sockets are under that category.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SocketCategoryHash** | **int** | The hash for the Socket Category: a quick way to go get the header display information for the category. Use it to look up DestinySocketCategoryDefinition info. | [optional] 
**SocketIndexes** | **List&lt;int&gt;** | Use these indexes to look up the sockets in the \&quot;sockets.socketEntries\&quot; property on the item definition. These are the indexes under the category, in game-rendered order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

