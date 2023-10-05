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
    /// DestinyComponentsLoadoutsDestinyLoadoutsComponent
    /// </summary>
    [DataContract(Name = "Destiny.Components.Loadouts.DestinyLoadoutsComponent")]
    public partial class DestinyComponentsLoadoutsDestinyLoadoutsComponent : IEquatable<DestinyComponentsLoadoutsDestinyLoadoutsComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsLoadoutsDestinyLoadoutsComponent" /> class.
        /// </summary>
        /// <param name="loadouts">loadouts.</param>
        public DestinyComponentsLoadoutsDestinyLoadoutsComponent(List<DestinyComponentsLoadoutsDestinyLoadoutComponent> loadouts = default(List<DestinyComponentsLoadoutsDestinyLoadoutComponent>))
        {
            this.Loadouts = loadouts;
        }

        /// <summary>
        /// Gets or Sets Loadouts
        /// </summary>
        [DataMember(Name = "loadouts", EmitDefaultValue = false)]
        public List<DestinyComponentsLoadoutsDestinyLoadoutComponent> Loadouts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsLoadoutsDestinyLoadoutsComponent {\n");
            sb.Append("  Loadouts: ").Append(Loadouts).Append("\n");
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
            return this.Equals(input as DestinyComponentsLoadoutsDestinyLoadoutsComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsLoadoutsDestinyLoadoutsComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsLoadoutsDestinyLoadoutsComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsLoadoutsDestinyLoadoutsComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Loadouts == input.Loadouts ||
                    this.Loadouts != null &&
                    input.Loadouts != null &&
                    this.Loadouts.SequenceEqual(input.Loadouts)
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
                if (this.Loadouts != null)
                {
                    hashCode = (hashCode * 59) + this.Loadouts.GetHashCode();
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