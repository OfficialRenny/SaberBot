# Destiny.Model.DestinyDefinitionsDestinyStatDisplayDefinition
Describes the way that an Item Stat (see DestinyStatDefinition) is transformed using the DestinyStatGroupDefinition related to that item. See both of the aforementioned definitions for more information about the stages of stat transformation.  This represents the transformation of a stat into a \"Display\" stat (the closest value that BNet can get to the in-game display value of the stat)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatHash** | **int** | The hash identifier for the stat being transformed into a Display stat.  Use it to look up the DestinyStatDefinition, or key into a DestinyInventoryItemDefinition&#39;s stats property. | [optional] 
**MaximumValue** | **int** | Regardless of the output of interpolation, this is the maximum possible value that the stat can be. It should also be used as the upper bound for displaying the stat as a progress bar (the minimum always being 0) | [optional] 
**DisplayAsNumeric** | **bool** | If this is true, the stat should be displayed as a number. Otherwise, display it as a progress bar. Or, you know, do whatever you want. There&#39;s no displayAsNumeric police. | [optional] 
**DisplayInterpolation** | [**List&lt;InterpolationInterpolationPoint&gt;**](InterpolationInterpolationPoint.md) | The interpolation table representing how the Investment Stat is transformed into a Display Stat.   See DestinyStatDefinition for a description of the stages of stat transformation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

