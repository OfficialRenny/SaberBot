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
    /// DestinyMilestonesDestinyPublicMilestoneChallengeActivity
    /// </summary>
    [DataContract(Name = "Destiny.Milestones.DestinyPublicMilestoneChallengeActivity")]
    public partial class DestinyMilestonesDestinyPublicMilestoneChallengeActivity : IEquatable<DestinyMilestonesDestinyPublicMilestoneChallengeActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyMilestonesDestinyPublicMilestoneChallengeActivity" /> class.
        /// </summary>
        /// <param name="activityHash">activityHash.</param>
        /// <param name="challengeObjectiveHashes">challengeObjectiveHashes.</param>
        /// <param name="modifierHashes">If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live..</param>
        /// <param name="loadoutRequirementIndex">If returned, this is the index into the DestinyActivityDefinition&#39;s \&quot;loadouts\&quot; property, indicating the currently active loadout requirements..</param>
        /// <param name="phaseHashes">The ordered list of phases for this activity, if any. Note that we have no human readable info for phases, nor any entities to relate them to: relating these hashes to something human readable is up to you unfortunately..</param>
        /// <param name="booleanActivityOptions">The set of activity options for this activity, keyed by an identifier that&#39;s unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \&quot;Challenge Mode\&quot;.  We have no human readable information for this data, so it&#39;s up to you if you want to associate it with such info to show it..</param>
        public DestinyMilestonesDestinyPublicMilestoneChallengeActivity(int activityHash = default(int), List<int> challengeObjectiveHashes = default(List<int>), List<int> modifierHashes = default(List<int>), int? loadoutRequirementIndex = default(int?), List<int> phaseHashes = default(List<int>), Dictionary<string, bool> booleanActivityOptions = default(Dictionary<string, bool>))
        {
            this.ActivityHash = activityHash;
            this.ChallengeObjectiveHashes = challengeObjectiveHashes;
            this.ModifierHashes = modifierHashes;
            this.LoadoutRequirementIndex = loadoutRequirementIndex;
            this.PhaseHashes = phaseHashes;
            this.BooleanActivityOptions = booleanActivityOptions;
        }

        /// <summary>
        /// Gets or Sets ActivityHash
        /// </summary>
        [DataMember(Name = "activityHash", EmitDefaultValue = false)]
        public int ActivityHash { get; set; }

        /// <summary>
        /// Gets or Sets ChallengeObjectiveHashes
        /// </summary>
        [DataMember(Name = "challengeObjectiveHashes", EmitDefaultValue = false)]
        public List<int> ChallengeObjectiveHashes { get; set; }

        /// <summary>
        /// If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live.
        /// </summary>
        /// <value>If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live.</value>
        [DataMember(Name = "modifierHashes", EmitDefaultValue = false)]
        public List<int> ModifierHashes { get; set; }

        /// <summary>
        /// If returned, this is the index into the DestinyActivityDefinition&#39;s \&quot;loadouts\&quot; property, indicating the currently active loadout requirements.
        /// </summary>
        /// <value>If returned, this is the index into the DestinyActivityDefinition&#39;s \&quot;loadouts\&quot; property, indicating the currently active loadout requirements.</value>
        [DataMember(Name = "loadoutRequirementIndex", EmitDefaultValue = true)]
        public int? LoadoutRequirementIndex { get; set; }

        /// <summary>
        /// The ordered list of phases for this activity, if any. Note that we have no human readable info for phases, nor any entities to relate them to: relating these hashes to something human readable is up to you unfortunately.
        /// </summary>
        /// <value>The ordered list of phases for this activity, if any. Note that we have no human readable info for phases, nor any entities to relate them to: relating these hashes to something human readable is up to you unfortunately.</value>
        [DataMember(Name = "phaseHashes", EmitDefaultValue = false)]
        public List<int> PhaseHashes { get; set; }

        /// <summary>
        /// The set of activity options for this activity, keyed by an identifier that&#39;s unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \&quot;Challenge Mode\&quot;.  We have no human readable information for this data, so it&#39;s up to you if you want to associate it with such info to show it.
        /// </summary>
        /// <value>The set of activity options for this activity, keyed by an identifier that&#39;s unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \&quot;Challenge Mode\&quot;.  We have no human readable information for this data, so it&#39;s up to you if you want to associate it with such info to show it.</value>
        [DataMember(Name = "booleanActivityOptions", EmitDefaultValue = false)]
        public Dictionary<string, bool> BooleanActivityOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyMilestonesDestinyPublicMilestoneChallengeActivity {\n");
            sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
            sb.Append("  ChallengeObjectiveHashes: ").Append(ChallengeObjectiveHashes).Append("\n");
            sb.Append("  ModifierHashes: ").Append(ModifierHashes).Append("\n");
            sb.Append("  LoadoutRequirementIndex: ").Append(LoadoutRequirementIndex).Append("\n");
            sb.Append("  PhaseHashes: ").Append(PhaseHashes).Append("\n");
            sb.Append("  BooleanActivityOptions: ").Append(BooleanActivityOptions).Append("\n");
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
            return this.Equals(input as DestinyMilestonesDestinyPublicMilestoneChallengeActivity);
        }

        /// <summary>
        /// Returns true if DestinyMilestonesDestinyPublicMilestoneChallengeActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyMilestonesDestinyPublicMilestoneChallengeActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyMilestonesDestinyPublicMilestoneChallengeActivity input)
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
                    this.ChallengeObjectiveHashes == input.ChallengeObjectiveHashes ||
                    this.ChallengeObjectiveHashes != null &&
                    input.ChallengeObjectiveHashes != null &&
                    this.ChallengeObjectiveHashes.SequenceEqual(input.ChallengeObjectiveHashes)
                ) && 
                (
                    this.ModifierHashes == input.ModifierHashes ||
                    this.ModifierHashes != null &&
                    input.ModifierHashes != null &&
                    this.ModifierHashes.SequenceEqual(input.ModifierHashes)
                ) && 
                (
                    this.LoadoutRequirementIndex == input.LoadoutRequirementIndex ||
                    (this.LoadoutRequirementIndex != null &&
                    this.LoadoutRequirementIndex.Equals(input.LoadoutRequirementIndex))
                ) && 
                (
                    this.PhaseHashes == input.PhaseHashes ||
                    this.PhaseHashes != null &&
                    input.PhaseHashes != null &&
                    this.PhaseHashes.SequenceEqual(input.PhaseHashes)
                ) && 
                (
                    this.BooleanActivityOptions == input.BooleanActivityOptions ||
                    this.BooleanActivityOptions != null &&
                    input.BooleanActivityOptions != null &&
                    this.BooleanActivityOptions.SequenceEqual(input.BooleanActivityOptions)
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
                if (this.ChallengeObjectiveHashes != null)
                {
                    hashCode = (hashCode * 59) + this.ChallengeObjectiveHashes.GetHashCode();
                }
                if (this.ModifierHashes != null)
                {
                    hashCode = (hashCode * 59) + this.ModifierHashes.GetHashCode();
                }
                if (this.LoadoutRequirementIndex != null)
                {
                    hashCode = (hashCode * 59) + this.LoadoutRequirementIndex.GetHashCode();
                }
                if (this.PhaseHashes != null)
                {
                    hashCode = (hashCode * 59) + this.PhaseHashes.GetHashCode();
                }
                if (this.BooleanActivityOptions != null)
                {
                    hashCode = (hashCode * 59) + this.BooleanActivityOptions.GetHashCode();
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
