# Destiny.Model.DestinyDestinyUnlockStatus
Indicates the status of an \"Unlock Flag\" on a Character or Profile.  These are individual bits of state that can be either set or not set, and sometimes provide interesting human-readable information in their related DestinyUnlockDefinition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnlockHash** | **int** | The hash identifier for the Unlock Flag. Use to lookup DestinyUnlockDefinition for static data. Not all unlocks have human readable data - in fact, most don&#39;t. But when they do, it can be very useful to show. Even if they don&#39;t have human readable data, you might be able to infer the meaning of an unlock flag with a bit of experimentation... | [optional] 
**IsSet** | **bool** | Whether the unlock flag is set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

