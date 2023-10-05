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
    /// Represents a status string that could be conditionally displayed about an activity. Note that externally, you can only see the strings themselves. Internally we combine this information with server state to determine which strings should be shown.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyActivityUnlockStringDefinition")]
    public partial class DestinyDefinitionsDestinyActivityUnlockStringDefinition : IEquatable<DestinyDefinitionsDestinyActivityUnlockStringDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyActivityUnlockStringDefinition" /> class.
        /// </summary>
        /// <param name="displayString">The string to be displayed if the conditions are met..</param>
        public DestinyDefinitionsDestinyActivityUnlockStringDefinition(string displayString = default(string))
        {
            this.DisplayString = displayString;
        }

        /// <summary>
        /// The string to be displayed if the conditions are met.
        /// </summary>
        /// <value>The string to be displayed if the conditions are met.</value>
        [DataMember(Name = "displayString", EmitDefaultValue = false)]
        public string DisplayString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyActivityUnlockStringDefinition {\n");
            sb.Append("  DisplayString: ").Append(DisplayString).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyActivityUnlockStringDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyActivityUnlockStringDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyActivityUnlockStringDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyActivityUnlockStringDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayString == input.DisplayString ||
                    (this.DisplayString != null &&
                    this.DisplayString.Equals(input.DisplayString))
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
                if (this.DisplayString != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayString.GetHashCode();
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