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
    /// Represents this player&#39;s personal completion status for the Activity under a Milestone, if the activity has trackable completion and progress information. (most activities won&#39;t, or the concept won&#39;t apply. For instance, it makes sense to talk about a tier of a raid as being Completed or having progress, but it doesn&#39;t make sense to talk about a Crucible Playlist in those terms.
    /// </summary>
    [DataContract(Name = "Destiny.Milestones.DestinyMilestoneActivityCompletionStatus")]
    public partial class DestinyMilestonesDestinyMilestoneActivityCompletionStatus : IEquatable<DestinyMilestonesDestinyMilestoneActivityCompletionStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyMilestonesDestinyMilestoneActivityCompletionStatus" /> class.
        /// </summary>
        /// <param name="completed">If the activity has been \&quot;completed\&quot;, that information will be returned here..</param>
        /// <param name="phases">If the Activity has discrete \&quot;phases\&quot; that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity..</param>
        public DestinyMilestonesDestinyMilestoneActivityCompletionStatus(bool completed = default(bool), List<DestinyMilestonesDestinyMilestoneActivityPhase> phases = default(List<DestinyMilestonesDestinyMilestoneActivityPhase>))
        {
            this.Completed = completed;
            this.Phases = phases;
        }

        /// <summary>
        /// If the activity has been \&quot;completed\&quot;, that information will be returned here.
        /// </summary>
        /// <value>If the activity has been \&quot;completed\&quot;, that information will be returned here.</value>
        [DataMember(Name = "completed", EmitDefaultValue = true)]
        public bool Completed { get; set; }

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
            sb.Append("class DestinyMilestonesDestinyMilestoneActivityCompletionStatus {\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
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
            return this.Equals(input as DestinyMilestonesDestinyMilestoneActivityCompletionStatus);
        }

        /// <summary>
        /// Returns true if DestinyMilestonesDestinyMilestoneActivityCompletionStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyMilestonesDestinyMilestoneActivityCompletionStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyMilestonesDestinyMilestoneActivityCompletionStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Completed == input.Completed ||
                    this.Completed.Equals(input.Completed)
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
                hashCode = (hashCode * 59) + this.Completed.GetHashCode();
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
