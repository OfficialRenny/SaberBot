# Destiny.Model.DestinyDefinitionsDestinyObjectiveDefinition
Defines an \"Objective\".  An objective is a specific task you should accomplish in the game. These are referred to by:  - Quest Steps (which are DestinyInventoryItemDefinition entities with Objectives)  - Challenges (which are Objectives defined on an DestinyActivityDefintion)  - Milestones (which refer to Objectives that are defined on both Quest Steps and Activities)  - Anything else that the designers decide to do later.  Objectives have progress, a notion of having been Completed, human readable data describing the task to be accomplished, and a lot of optional tack-on data that can enhance the information provided about the task.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**CompletionValue** | **int** | The value that the unlock value defined in unlockValueHash must reach in order for the objective to be considered Completed. Used in calculating progress and completion status. | [optional] 
**Scope** | **int** | A shortcut for determining the most restrictive gating that this Objective is set to use. This includes both the dynamic determination of progress and of completion values. See the DestinyGatingScope enum&#39;s documentation for more details. | [optional] 
**LocationHash** | **int** | OPTIONAL: a hash identifier for the location at which this objective must be accomplished, if there is a location defined. Look up the DestinyLocationDefinition for this hash for that additional location info. | [optional] 
**AllowNegativeValue** | **bool** | If true, the value is allowed to go negative. | [optional] 
**AllowValueChangeWhenCompleted** | **bool** | If true, you can effectively \&quot;un-complete\&quot; this objective if you lose progress after crossing the completion threshold.   If False, once you complete the task it will remain completed forever by locking the value. | [optional] 
**IsCountingDownward** | **bool** | If true, completion means having an unlock value less than or equal to the completionValue.  If False, completion means having an unlock value greater than or equal to the completionValue. | [optional] 
**ValueStyle** | **int** | The UI style applied to the objective. It&#39;s an enum, take a look at DestinyUnlockValueUIStyle for details of the possible styles. Use this info as you wish to customize your UI.  DEPRECATED: This is no longer populated by Destiny 2 game content. Please use inProgressValueStyle and completedValueStyle instead. | [optional] 
**ProgressDescription** | **string** | Text to describe the progress bar. | [optional] 
**Perks** | [**DestinyDefinitionsDestinyObjectivePerkEntryDefinition**](DestinyDefinitionsDestinyObjectivePerkEntryDefinition.md) |  | [optional] 
**Stats** | [**DestinyDefinitionsDestinyObjectiveStatEntryDefinition**](DestinyDefinitionsDestinyObjectiveStatEntryDefinition.md) |  | [optional] 
**MinimumVisibilityThreshold** | **int** | If nonzero, this is the minimum value at which the objective&#39;s progression should be shown. Otherwise, don&#39;t show it yet. | [optional] 
**AllowOvercompletion** | **bool** | If True, the progress will continue even beyond the point where the objective met its minimum completion requirements. Your UI will have to accommodate it. | [optional] 
**ShowValueOnComplete** | **bool** | If True, you should continue showing the progression value in the UI after it&#39;s complete. I mean, we already do that in BNet anyways, but if you want to be better behaved than us you could honor this flag. | [optional] 
**CompletedValueStyle** | **int** | The style to use when the objective is completed. | [optional] 
**InProgressValueStyle** | **int** | The style to use when the objective is still in progress. | [optional] 
**UiLabel** | **string** | Objectives can have arbitrary UI-defined identifiers that define the style applied to objectives. For convenience, known UI labels will be defined in the uiStyle enum value. | [optional] 
**UiStyle** | **int** | If the objective has a known UI label value, this property will represent it. | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

