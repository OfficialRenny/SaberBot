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
    /// DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Milestones.DestinyMilestoneChallengeActivityPhase")]
    public partial class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase : IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase" /> class.
        /// </summary>
        /// <param name="phaseHash">The hash identifier of the activity&#39;s phase..</param>
        public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase(int phaseHash = default(int))
        {
            this.PhaseHash = phaseHash;
        }

        /// <summary>
        /// The hash identifier of the activity&#39;s phase.
        /// </summary>
        /// <value>The hash identifier of the activity&#39;s phase.</value>
        [DataMember(Name = "phaseHash", EmitDefaultValue = false)]
        public int PhaseHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase {\n");
            sb.Append("  PhaseHash: ").Append(PhaseHash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PhaseHash == input.PhaseHash ||
                    this.PhaseHash.Equals(input.PhaseHash)
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
                hashCode = (hashCode * 59) + this.PhaseHash.GetHashCode();
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
