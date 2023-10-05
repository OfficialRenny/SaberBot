# Destiny.Model.DestinyRequestsActionsDestinySocketArrayType
If you look in the DestinyInventoryItemDefinition's \"sockets\" property, you'll see that there are two types of sockets: intrinsic, and \"socketEntry.\"  Unfortunately, because Intrinsic sockets are a whole separate array, it is no longer sufficient to know the index into that array to know which socket we're talking about. You have to know whether it's in the default \"socketEntries\" or if it's in the \"intrinsic\" list.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

