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
    /// Represents the public-facing status of an activity: any data about what is currently active in the Activity, regardless of an individual character&#39;s progress in it.
    /// </summary>
    [DataContract(Name = "Destiny.Activities.DestinyPublicActivityStatus")]
    public partial class DestinyActivitiesDestinyPublicActivityStatus : IEquatable<DestinyActivitiesDestinyPublicActivityStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyActivitiesDestinyPublicActivityStatus" /> class.
        /// </summary>
        /// <param name="challengeObjectiveHashes">Active Challenges for the activity, if any - represented as hashes for DestinyObjectiveDefinitions..</param>
        /// <param name="modifierHashes">The active modifiers on this activity, if any - represented as hashes for DestinyActivityModifierDefinitions..</param>
        /// <param name="rewardTooltipItems">If the activity itself provides any specific \&quot;mock\&quot; rewards, this will be the items and their quantity.  Why \&quot;mock\&quot;, you ask? Because these are the rewards as they are represented in the tooltip of the Activity.  These are often pointers to fake items that look good in a tooltip, but represent an abstract concept of what you will get for a reward rather than the specific items you may obtain..</param>
        public DestinyActivitiesDestinyPublicActivityStatus(List<int> challengeObjectiveHashes = default(List<int>), List<int> modifierHashes = default(List<int>), List<DestinyDestinyItemQuantity> rewardTooltipItems = default(List<DestinyDestinyItemQuantity>))
        {
            this.ChallengeObjectiveHashes = challengeObjectiveHashes;
            this.ModifierHashes = modifierHashes;
            this.RewardTooltipItems = rewardTooltipItems;
        }

        /// <summary>
        /// Active Challenges for the activity, if any - represented as hashes for DestinyObjectiveDefinitions.
        /// </summary>
        /// <value>Active Challenges for the activity, if any - represented as hashes for DestinyObjectiveDefinitions.</value>
        [DataMember(Name = "challengeObjectiveHashes", EmitDefaultValue = false)]
        public List<int> ChallengeObjectiveHashes { get; set; }

        /// <summary>
        /// The active modifiers on this activity, if any - represented as hashes for DestinyActivityModifierDefinitions.
        /// </summary>
        /// <value>The active modifiers on this activity, if any - represented as hashes for DestinyActivityModifierDefinitions.</value>
        [DataMember(Name = "modifierHashes", EmitDefaultValue = false)]
        public List<int> ModifierHashes { get; set; }

        /// <summary>
        /// If the activity itself provides any specific \&quot;mock\&quot; rewards, this will be the items and their quantity.  Why \&quot;mock\&quot;, you ask? Because these are the rewards as they are represented in the tooltip of the Activity.  These are often pointers to fake items that look good in a tooltip, but represent an abstract concept of what you will get for a reward rather than the specific items you may obtain.
        /// </summary>
        /// <value>If the activity itself provides any specific \&quot;mock\&quot; rewards, this will be the items and their quantity.  Why \&quot;mock\&quot;, you ask? Because these are the rewards as they are represented in the tooltip of the Activity.  These are often pointers to fake items that look good in a tooltip, but represent an abstract concept of what you will get for a reward rather than the specific items you may obtain.</value>
        [DataMember(Name = "rewardTooltipItems", EmitDefaultValue = false)]
        public List<DestinyDestinyItemQuantity> RewardTooltipItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyActivitiesDestinyPublicActivityStatus {\n");
            sb.Append("  ChallengeObjectiveHashes: ").Append(ChallengeObjectiveHashes).Append("\n");
            sb.Append("  ModifierHashes: ").Append(ModifierHashes).Append("\n");
            sb.Append("  RewardTooltipItems: ").Append(RewardTooltipItems).Append("\n");
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
            return this.Equals(input as DestinyActivitiesDestinyPublicActivityStatus);
        }

        /// <summary>
        /// Returns true if DestinyActivitiesDestinyPublicActivityStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyActivitiesDestinyPublicActivityStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyActivitiesDestinyPublicActivityStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.RewardTooltipItems == input.RewardTooltipItems ||
                    this.RewardTooltipItems != null &&
                    input.RewardTooltipItems != null &&
                    this.RewardTooltipItems.SequenceEqual(input.RewardTooltipItems)
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
                if (this.ChallengeObjectiveHashes != null)
                {
                    hashCode = (hashCode * 59) + this.ChallengeObjectiveHashes.GetHashCode();
                }
                if (this.ModifierHashes != null)
                {
                    hashCode = (hashCode * 59) + this.ModifierHashes.GetHashCode();
                }
                if (this.RewardTooltipItems != null)
                {
                    hashCode = (hashCode * 59) + this.RewardTooltipItems.GetHashCode();
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
