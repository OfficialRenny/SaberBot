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
    /// An intrinsic perk on an item, and the requirements for it to be activated.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyItemPerkEntryDefinition")]
    public partial class DestinyDefinitionsDestinyItemPerkEntryDefinition : IEquatable<DestinyDefinitionsDestinyItemPerkEntryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemPerkEntryDefinition" /> class.
        /// </summary>
        /// <param name="requirementDisplayString">If this perk is not active, this is the string to show for why it&#39;s not providing its benefits..</param>
        /// <param name="perkHash">A hash identifier for the DestinySandboxPerkDefinition being provided on the item..</param>
        /// <param name="perkVisibility">Indicates whether this perk should be shown, or if it should be shown disabled..</param>
        public DestinyDefinitionsDestinyItemPerkEntryDefinition(string requirementDisplayString = default(string), int perkHash = default(int), int perkVisibility = default(int))
        {
            this.RequirementDisplayString = requirementDisplayString;
            this.PerkHash = perkHash;
            this.PerkVisibility = perkVisibility;
        }

        /// <summary>
        /// If this perk is not active, this is the string to show for why it&#39;s not providing its benefits.
        /// </summary>
        /// <value>If this perk is not active, this is the string to show for why it&#39;s not providing its benefits.</value>
        [DataMember(Name = "requirementDisplayString", EmitDefaultValue = false)]
        public string RequirementDisplayString { get; set; }

        /// <summary>
        /// A hash identifier for the DestinySandboxPerkDefinition being provided on the item.
        /// </summary>
        /// <value>A hash identifier for the DestinySandboxPerkDefinition being provided on the item.</value>
        [DataMember(Name = "perkHash", EmitDefaultValue = false)]
        public int PerkHash { get; set; }

        /// <summary>
        /// Indicates whether this perk should be shown, or if it should be shown disabled.
        /// </summary>
        /// <value>Indicates whether this perk should be shown, or if it should be shown disabled.</value>
        [DataMember(Name = "perkVisibility", EmitDefaultValue = false)]
        public int PerkVisibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyItemPerkEntryDefinition {\n");
            sb.Append("  RequirementDisplayString: ").Append(RequirementDisplayString).Append("\n");
            sb.Append("  PerkHash: ").Append(PerkHash).Append("\n");
            sb.Append("  PerkVisibility: ").Append(PerkVisibility).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyItemPerkEntryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemPerkEntryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemPerkEntryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemPerkEntryDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequirementDisplayString == input.RequirementDisplayString ||
                    (this.RequirementDisplayString != null &&
                    this.RequirementDisplayString.Equals(input.RequirementDisplayString))
                ) && 
                (
                    this.PerkHash == input.PerkHash ||
                    this.PerkHash.Equals(input.PerkHash)
                ) && 
                (
                    this.PerkVisibility == input.PerkVisibility ||
                    this.PerkVisibility.Equals(input.PerkVisibility)
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
                if (this.RequirementDisplayString != null)
                {
                    hashCode = (hashCode * 59) + this.RequirementDisplayString.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PerkHash.GetHashCode();
                hashCode = (hashCode * 59) + this.PerkVisibility.GetHashCode();
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
