# Destiny.Model.DestinyMilestonesDestinyMilestoneContent
Represents localized, extended content related to Milestones. This is intentionally returned by a separate endpoint and not with Character-level Milestone data because we do not put localized data into standard Destiny responses, both for brevity of response and for caching purposes. If you really need this data, hit the Milestone Content endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**About** | **string** | The \&quot;About this Milestone\&quot; text from the Firehose. | [optional] 
**Status** | **string** | The Current Status of the Milestone, as driven by the Firehose. | [optional] 
**Tips** | **List&lt;string&gt;** | A list of tips, provided by the Firehose. | [optional] 
**ItemCategories** | [**List&lt;DestinyMilestonesDestinyMilestoneContentItemCategory&gt;**](DestinyMilestonesDestinyMilestoneContentItemCategory.md) | If DPS has defined items related to this Milestone, they can categorize those items in the Firehose. That data will then be returned as item categories here. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

