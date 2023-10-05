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
    /// DestinyComponentsPresentationDestinyPresentationNodeComponent
    /// </summary>
    [DataContract(Name = "Destiny.Components.Presentation.DestinyPresentationNodeComponent")]
    public partial class DestinyComponentsPresentationDestinyPresentationNodeComponent : IEquatable<DestinyComponentsPresentationDestinyPresentationNodeComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsPresentationDestinyPresentationNodeComponent" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="objective">objective.</param>
        /// <param name="progressValue">How much of the presentation node is considered to be completed so far by the given character/profile..</param>
        /// <param name="completionValue">The value at which the presentation node is considered to be completed..</param>
        /// <param name="recordCategoryScore">If available, this is the current score for the record category that this node represents..</param>
        public DestinyComponentsPresentationDestinyPresentationNodeComponent(int state = default(int), DestinyQuestsDestinyObjectiveProgress objective = default(DestinyQuestsDestinyObjectiveProgress), int progressValue = default(int), int completionValue = default(int), int? recordCategoryScore = default(int?))
        {
            this.State = state;
            this.Objective = objective;
            this.ProgressValue = progressValue;
            this.CompletionValue = completionValue;
            this.RecordCategoryScore = recordCategoryScore;
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public int State { get; set; }

        /// <summary>
        /// Gets or Sets Objective
        /// </summary>
        [DataMember(Name = "objective", EmitDefaultValue = false)]
        public DestinyQuestsDestinyObjectiveProgress Objective { get; set; }

        /// <summary>
        /// How much of the presentation node is considered to be completed so far by the given character/profile.
        /// </summary>
        /// <value>How much of the presentation node is considered to be completed so far by the given character/profile.</value>
        [DataMember(Name = "progressValue", EmitDefaultValue = false)]
        public int ProgressValue { get; set; }

        /// <summary>
        /// The value at which the presentation node is considered to be completed.
        /// </summary>
        /// <value>The value at which the presentation node is considered to be completed.</value>
        [DataMember(Name = "completionValue", EmitDefaultValue = false)]
        public int CompletionValue { get; set; }

        /// <summary>
        /// If available, this is the current score for the record category that this node represents.
        /// </summary>
        /// <value>If available, this is the current score for the record category that this node represents.</value>
        [DataMember(Name = "recordCategoryScore", EmitDefaultValue = true)]
        public int? RecordCategoryScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsPresentationDestinyPresentationNodeComponent {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Objective: ").Append(Objective).Append("\n");
            sb.Append("  ProgressValue: ").Append(ProgressValue).Append("\n");
            sb.Append("  CompletionValue: ").Append(CompletionValue).Append("\n");
            sb.Append("  RecordCategoryScore: ").Append(RecordCategoryScore).Append("\n");
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
            return this.Equals(input as DestinyComponentsPresentationDestinyPresentationNodeComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsPresentationDestinyPresentationNodeComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsPresentationDestinyPresentationNodeComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsPresentationDestinyPresentationNodeComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.Objective == input.Objective ||
                    (this.Objective != null &&
                    this.Objective.Equals(input.Objective))
                ) && 
                (
                    this.ProgressValue == input.ProgressValue ||
                    this.ProgressValue.Equals(input.ProgressValue)
                ) && 
                (
                    this.CompletionValue == input.CompletionValue ||
                    this.CompletionValue.Equals(input.CompletionValue)
                ) && 
                (
                    this.RecordCategoryScore == input.RecordCategoryScore ||
                    (this.RecordCategoryScore != null &&
                    this.RecordCategoryScore.Equals(input.RecordCategoryScore))
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
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.Objective != null)
                {
                    hashCode = (hashCode * 59) + this.Objective.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProgressValue.GetHashCode();
                hashCode = (hashCode * 59) + this.CompletionValue.GetHashCode();
                if (this.RecordCategoryScore != null)
                {
                    hashCode = (hashCode * 59) + this.RecordCategoryScore.GetHashCode();
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