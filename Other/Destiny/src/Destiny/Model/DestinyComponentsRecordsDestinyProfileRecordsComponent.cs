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
    /// DestinyComponentsRecordsDestinyProfileRecordsComponent
    /// </summary>
    [DataContract(Name = "Destiny.Components.Records.DestinyProfileRecordsComponent")]
    public partial class DestinyComponentsRecordsDestinyProfileRecordsComponent : IEquatable<DestinyComponentsRecordsDestinyProfileRecordsComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsRecordsDestinyProfileRecordsComponent" /> class.
        /// </summary>
        /// <param name="score">Your &#39;active&#39; Triumphs score, maintained for backwards compatibility..</param>
        /// <param name="activeScore">Your &#39;active&#39; Triumphs score..</param>
        /// <param name="legacyScore">Your &#39;legacy&#39; Triumphs score..</param>
        /// <param name="lifetimeScore">Your &#39;lifetime&#39; Triumphs score..</param>
        /// <param name="trackedRecordHash">If this profile is tracking a record, this is the hash identifier of the record it is tracking..</param>
        /// <param name="records">records.</param>
        /// <param name="recordCategoriesRootNodeHash">The hash for the root presentation node definition of Triumph categories..</param>
        /// <param name="recordSealsRootNodeHash">The hash for the root presentation node definition of Triumph Seals..</param>
        public DestinyComponentsRecordsDestinyProfileRecordsComponent(int score = default(int), int activeScore = default(int), int legacyScore = default(int), int lifetimeScore = default(int), int? trackedRecordHash = default(int?), Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> records = default(Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent>), int recordCategoriesRootNodeHash = default(int), int recordSealsRootNodeHash = default(int))
        {
            this.Score = score;
            this.ActiveScore = activeScore;
            this.LegacyScore = legacyScore;
            this.LifetimeScore = lifetimeScore;
            this.TrackedRecordHash = trackedRecordHash;
            this.Records = records;
            this.RecordCategoriesRootNodeHash = recordCategoriesRootNodeHash;
            this.RecordSealsRootNodeHash = recordSealsRootNodeHash;
        }

        /// <summary>
        /// Your &#39;active&#39; Triumphs score, maintained for backwards compatibility.
        /// </summary>
        /// <value>Your &#39;active&#39; Triumphs score, maintained for backwards compatibility.</value>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public int Score { get; set; }

        /// <summary>
        /// Your &#39;active&#39; Triumphs score.
        /// </summary>
        /// <value>Your &#39;active&#39; Triumphs score.</value>
        [DataMember(Name = "activeScore", EmitDefaultValue = false)]
        public int ActiveScore { get; set; }

        /// <summary>
        /// Your &#39;legacy&#39; Triumphs score.
        /// </summary>
        /// <value>Your &#39;legacy&#39; Triumphs score.</value>
        [DataMember(Name = "legacyScore", EmitDefaultValue = false)]
        public int LegacyScore { get; set; }

        /// <summary>
        /// Your &#39;lifetime&#39; Triumphs score.
        /// </summary>
        /// <value>Your &#39;lifetime&#39; Triumphs score.</value>
        [DataMember(Name = "lifetimeScore", EmitDefaultValue = false)]
        public int LifetimeScore { get; set; }

        /// <summary>
        /// If this profile is tracking a record, this is the hash identifier of the record it is tracking.
        /// </summary>
        /// <value>If this profile is tracking a record, this is the hash identifier of the record it is tracking.</value>
        [DataMember(Name = "trackedRecordHash", EmitDefaultValue = true)]
        public int? TrackedRecordHash { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name = "records", EmitDefaultValue = false)]
        public Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> Records { get; set; }

        /// <summary>
        /// The hash for the root presentation node definition of Triumph categories.
        /// </summary>
        /// <value>The hash for the root presentation node definition of Triumph categories.</value>
        [DataMember(Name = "recordCategoriesRootNodeHash", EmitDefaultValue = false)]
        public int RecordCategoriesRootNodeHash { get; set; }

        /// <summary>
        /// The hash for the root presentation node definition of Triumph Seals.
        /// </summary>
        /// <value>The hash for the root presentation node definition of Triumph Seals.</value>
        [DataMember(Name = "recordSealsRootNodeHash", EmitDefaultValue = false)]
        public int RecordSealsRootNodeHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsRecordsDestinyProfileRecordsComponent {\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  ActiveScore: ").Append(ActiveScore).Append("\n");
            sb.Append("  LegacyScore: ").Append(LegacyScore).Append("\n");
            sb.Append("  LifetimeScore: ").Append(LifetimeScore).Append("\n");
            sb.Append("  TrackedRecordHash: ").Append(TrackedRecordHash).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  RecordCategoriesRootNodeHash: ").Append(RecordCategoriesRootNodeHash).Append("\n");
            sb.Append("  RecordSealsRootNodeHash: ").Append(RecordSealsRootNodeHash).Append("\n");
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
            return this.Equals(input as DestinyComponentsRecordsDestinyProfileRecordsComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsRecordsDestinyProfileRecordsComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsRecordsDestinyProfileRecordsComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsRecordsDestinyProfileRecordsComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
                ) && 
                (
                    this.ActiveScore == input.ActiveScore ||
                    this.ActiveScore.Equals(input.ActiveScore)
                ) && 
                (
                    this.LegacyScore == input.LegacyScore ||
                    this.LegacyScore.Equals(input.LegacyScore)
                ) && 
                (
                    this.LifetimeScore == input.LifetimeScore ||
                    this.LifetimeScore.Equals(input.LifetimeScore)
                ) && 
                (
                    this.TrackedRecordHash == input.TrackedRecordHash ||
                    (this.TrackedRecordHash != null &&
                    this.TrackedRecordHash.Equals(input.TrackedRecordHash))
                ) && 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
                ) && 
                (
                    this.RecordCategoriesRootNodeHash == input.RecordCategoriesRootNodeHash ||
                    this.RecordCategoriesRootNodeHash.Equals(input.RecordCategoriesRootNodeHash)
                ) && 
                (
                    this.RecordSealsRootNodeHash == input.RecordSealsRootNodeHash ||
                    this.RecordSealsRootNodeHash.Equals(input.RecordSealsRootNodeHash)
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
                hashCode = (hashCode * 59) + this.Score.GetHashCode();
                hashCode = (hashCode * 59) + this.ActiveScore.GetHashCode();
                hashCode = (hashCode * 59) + this.LegacyScore.GetHashCode();
                hashCode = (hashCode * 59) + this.LifetimeScore.GetHashCode();
                if (this.TrackedRecordHash != null)
                {
                    hashCode = (hashCode * 59) + this.TrackedRecordHash.GetHashCode();
                }
                if (this.Records != null)
                {
                    hashCode = (hashCode * 59) + this.Records.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RecordCategoriesRootNodeHash.GetHashCode();
                hashCode = (hashCode * 59) + this.RecordSealsRootNodeHash.GetHashCode();
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
