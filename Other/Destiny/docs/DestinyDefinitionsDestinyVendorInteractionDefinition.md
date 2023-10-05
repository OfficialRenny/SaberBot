# Destiny.Model.DestinyDefinitionsDestinyVendorInteractionDefinition
A Vendor Interaction is a dialog shown by the vendor other than sale items or transfer screens. The vendor is showing you something, and asking you to reply to it by choosing an option or reward.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InteractionIndex** | **int** | The position of this interaction in its parent array. Note that this is NOT content agnostic, and should not be used as such. | [optional] 
**Replies** | [**List&lt;DestinyDefinitionsDestinyVendorInteractionReplyDefinition&gt;**](DestinyDefinitionsDestinyVendorInteractionReplyDefinition.md) | The potential replies that the user can make to the interaction. | [optional] 
**VendorCategoryIndex** | **int** | If &gt;&#x3D; 0, this is the category of sale items to show along with this interaction dialog. | [optional] 
**QuestlineItemHash** | **int** | If this interaction dialog is about a quest, this is the questline related to the interaction. You can use this to show the quest overview, or even the character&#39;s status with the quest if you use it to find the character&#39;s current Quest Step by checking their inventory against this questlineItemHash&#39;s DestinyInventoryItemDefinition.setData. | [optional] 
**SackInteractionList** | [**List&lt;DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition&gt;**](DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition.md) | If this interaction is meant to show you sacks, this is the list of types of sacks to be shown. If empty, the interaction is not meant to show sacks. | [optional] 
**UiInteractionType** | **int** | A UI hint for the behavior of the interaction screen. This is useful to determine what type of interaction is occurring, such as a prompt to receive a rank up reward or a prompt to choose a reward for completing a quest. The hash isn&#39;t as useful as the Enum in retrospect, well what can you do. Try using interactionType instead. | [optional] 
**InteractionType** | **int** | The enumerated version of the possible UI hints for vendor interactions, which is a little easier to grok than the hash found in uiInteractionType. | [optional] 
**RewardBlockLabel** | **string** | If this interaction is displaying rewards, this is the text to use for the header of the reward-displaying section of the interaction. | [optional] 
**RewardVendorCategoryIndex** | **int** | If the vendor&#39;s reward list is sourced from one of his categories, this is the index into the category array of items to show. | [optional] 
**FlavorLineOne** | **string** | If the vendor interaction has flavor text, this is some of it. | [optional] 
**FlavorLineTwo** | **string** | If the vendor interaction has flavor text, this is the rest of it. | [optional] 
**HeaderDisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**Instructions** | **string** | The localized text telling the player what to do when they see this dialog. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

