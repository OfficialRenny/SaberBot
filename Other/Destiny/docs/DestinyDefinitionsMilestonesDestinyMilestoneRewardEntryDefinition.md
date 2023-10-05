# Destiny.Model.DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition
The definition of a specific reward, which may be contained in a category of rewards and that has optional information about how it is obtained.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RewardEntryHash** | **int** | The identifier for this reward entry. Runtime data will refer to reward entries by this hash. Only guaranteed unique within the specific Milestone. | [optional] 
**RewardEntryIdentifier** | **string** | The string identifier, if you care about it. Only guaranteed unique within the specific Milestone. | [optional] 
**Items** | [**List&lt;DestinyDestinyItemQuantity&gt;**](DestinyDestinyItemQuantity.md) | The items you will get as rewards, and how much of it you&#39;ll get. | [optional] 
**VendorHash** | **int?** | If this reward is redeemed at a Vendor, this is the hash of the Vendor to go to in order to redeem the reward. Use this hash to look up the DestinyVendorDefinition. | [optional] 
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**Order** | **int** | If you want to follow BNet&#39;s ordering of these rewards, use this number within a given category to order the rewards. Yeah, I know. I feel dirty too. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

