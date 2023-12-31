/*
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.18.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Destiny.Client.OpenAPIDateConverter;

namespace Destiny.Model
{
    /// <summary>
    /// DestinyMilestonesDestinyMilestoneChallengeActivity
    /// </summary>
    [DataContract(Name = "Destiny.Milestones.DestinyMilestoneChallengeActivity")]
    public partial class DestinyMilestonesDestinyMilestoneChallengeActivity : IEquatable<DestinyMilestonesDestinyMilestoneChallengeActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyMilestonesDestinyMilestoneChallengeActivity" /> class.
        /// </summary>
        /// <param name="activityHash">activityHash.</param>
        /// <param name="challenges">challenges.</param>
        /// <param name="modifierHashes">If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live..</param>
        /// <param name="booleanActivityOptions">The set of activity options for this activity, keyed by an identifier that&#39;s unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \&quot;Challenge Mode\&quot;.  We don&#39;t have any human readable information for these, but saavy 3rd party app users could manually associate the key (a hash identifier for the \&quot;option\&quot; that is enabled/disabled) and the value (whether it&#39;s enabled or disabled presently)  On our side, we don&#39;t necessarily even know what these are used for (the game designers know, but we don&#39;t), and we have no human readable data for them. In order to use them, you will have to do some experimentation..</param>
        /// <param name="loadoutRequirementIndex">If returned, this is the index into the DestinyActivityDefinition&#39;s \&quot;loadouts\&quot; property, indicating the currently active loadout requirements..</param>
        /// <param name="phases">If the Activity has discrete \&quot;phases\&quot; that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity..</param>
        public DestinyMilestonesDestinyMilestoneChallengeActivity(int activityHash = default(int), List<DestinyChallengesDestinyChallengeStatus> challenges = default(List<DestinyChallengesDestinyChallengeStatus>), List<int> modifierHashes = default(List<int>), Dictionary<string, bool> booleanActivityOptions = default(Dictionary<string, bool>), int? loadoutRequirementIndex = default(int?), List<DestinyMilestonesDestinyMilestoneActivityPhase> phases = default(List<DestinyMilestonesDestinyMilestoneActivityPhase>))
        {
            this.ActivityHash = activityHash;
            this.Challenges = challenges;
            this.ModifierHashes = modifierHashes;
            this.BooleanActivityOptions = booleanActivityOptions;
            this.LoadoutRequirementIndex = loadoutRequirementIndex;
            this.Phases = phases;
        }

        /// <summary>
        /// Gets or Sets ActivityHash
        /// </summary>
        [DataMember(Name = "activityHash", EmitDefaultValue = false)]
        public int ActivityHash { get; set; }

        /// <summary>
        /// Gets or Sets Challenges
        /// </summary>
        [DataMember(Name = "challenges", EmitDefaultValue = false)]
        public List<DestinyChallengesDestinyChallengeStatus> Challenges { get; set; }

        /// <summary>
        /// If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live.
        /// </summary>
        /// <value>If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live.</value>
        [DataMember(Name = "modifierHashes", EmitDefaultValue = false)]
        public List<int> ModifierHashes { get; set; }

        /// <summary>
        /// The set of activity options for this activity, keyed by an identifier that&#39;s unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \&quot;Challenge Mode\&quot;.  We don&#39;t have any human readable information for these, but saavy 3rd party app users could manually associate the key (a hash identifier for the \&quot;option\&quot; that is enabled/disabled) and the value (whether it&#39;s enabled or disabled presently)  On our side, we don&#39;t necessarily even know what these are used for (the game designers know, but we don&#39;t), and we have no human readable data for them. In order to use them, you will have to do some experimentation.
        /// </summary>
        /// <value>The set of activity options for this activity, keyed by an identifier that&#39;s unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \&quot;Challenge Mode\&quot;.  We don&#39;t have any human readable information for these, but saavy 3rd party app users could manually associate the key (a hash identifier for the \&quot;option\&quot; that is enabled/disabled) and the value (whether it&#39;s enabled or disabled presently)  On our side, we don&#39;t necessarily even know what these are used for (the game designers know, but we don&#39;t), and we have no human readable data for them. In order to use them, you will have to do some experimentation.</value>
        [DataMember(Name = "booleanActivityOptions", EmitDefaultValue = false)]
        public Dictionary<string, bool> BooleanActivityOptions { get; set; }

        /// <summary>
        /// If returned, this is the index into the DestinyActivityDefinition&#39;s \&quot;loadouts\&quot; property, indicating the currently active loadout requirements.
        /// </summary>
        /// <value>If returned, this is the index into the DestinyActivityDefinition&#39;s \&quot;loadouts\&quot; property, indicating the currently active loadout requirements.</value>
        [DataMember(Name = "loadoutRequirementIndex", EmitDefaultValue = true)]
        public int? LoadoutRequirementIndex { get; set; }

        /// <summary>
        /// If the Activity has discrete \&quot;phases\&quot; that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.
        /// </summary>
        /// <value>If the Activity has discrete \&quot;phases\&quot; that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.</value>
        [DataMember(Name = "phases", EmitDefaultValue = false)]
        public List<DestinyMilestonesDestinyMilestoneActivityPhase> Phases { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyMilestonesDestinyMilestoneChallengeActivity {\n");
            sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
            sb.Append("  Challenges: ").Append(Challenges).Append("\n");
            sb.Append("  ModifierHashes: ").Append(ModifierHashes).Append("\n");
            sb.Append("  BooleanActivityOptions: ").Append(BooleanActivityOptions).Append("\n");
            sb.Append("  LoadoutRequirementIndex: ").Append(LoadoutRequirementIndex).Append("\n");
            sb.Append("  Phases: ").Append(Phases).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestonesDestinyMilestoneChallengeActivity);
        }

        /// <summary>
        /// Returns true if DestinyMilestonesDestinyMilestoneChallengeActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyMilestonesDestinyMilestoneChallengeActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyMilestonesDestinyMilestoneChallengeActivity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityHash == input.ActivityHash ||
                    this.ActivityHash.Equals(input.ActivityHash)
                ) && 
                (
                    this.Challenges == input.Challenges ||
                    this.Challenges != null &&
                    input.Challenges != null &&
                    this.Challenges.SequenceEqual(input.Challenges)
                ) && 
                (
                    this.ModifierHashes == input.ModifierHashes ||
                    this.ModifierHashes != null &&
                    input.ModifierHashes != null &&
                    this.ModifierHashes.SequenceEqual(input.ModifierHashes)
                ) && 
                (
                    this.BooleanActivityOptions == input.BooleanActivityOptions ||
                    this.BooleanActivityOptions != null &&
                    input.BooleanActivityOptions != null &&
                    this.BooleanActivityOptions.SequenceEqual(input.BooleanActivityOptions)
                ) && 
                (
                    this.LoadoutRequirementIndex == input.LoadoutRequirementIndex ||
                    (this.LoadoutRequirementIndex != null &&
                    this.LoadoutRequirementIndex.Equals(input.LoadoutRequirementIndex))
                ) && 
                (
                    this.Phases == input.Phases ||
                    this.Phases != null &&
                    input.Phases != null &&
                    this.Phases.SequenceEqual(input.Phases)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.ActivityHash.GetHashCode();
                if (this.Challenges != null)
                {
                    hashCode = (hashCode * 59) + this.Challenges.GetHashCode();
                }
                if (this.ModifierHashes != null)
                {
                    hashCode = (hashCode * 59) + this.ModifierHashes.GetHashCode();
                }
                if (this.BooleanActivityOptions != null)
                {
                    hashCode = (hashCode * 59) + this.BooleanActivityOptions.GetHashCode();
                }
                if (this.LoadoutRequirementIndex != null)
                {
                    hashCode = (hashCode * 59) + this.LoadoutRequirementIndex.GetHashCode();
                }
                if (this.Phases != null)
                {
                    hashCode = (hashCode * 59) + this.Phases.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
