# Destiny.Model.DestinySocketPlugSources
Indicates how a socket is populated, and where you should look for valid plug data.   This is a flags enumeration/bitmask field, as you may have to look in multiple sources across multiple components for valid plugs.   For instance, a socket could have plugs that are sourced from its own definition, as well as plugs that are sourced from Character-scoped AND profile-scoped Plug Sets. Only by combining plug data for every indicated source will you be able to know all of the plugs available for a socket.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

