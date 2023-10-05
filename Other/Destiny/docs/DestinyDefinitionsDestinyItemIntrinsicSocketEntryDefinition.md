# Destiny.Model.DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition
Represents a socket that has a plug associated with it intrinsically. This is useful for situations where the weapon needs to have a visual plug/Mod on it, but that plug/Mod should never change.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlugItemHash** | **int** | Indicates the plug that is intrinsically inserted into this socket. | [optional] 
**SocketTypeHash** | **int** | Indicates the type of this intrinsic socket. | [optional] 
**DefaultVisible** | **bool** | If true, then this socket is visible in the item&#39;s \&quot;default\&quot; state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you&#39;re looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

