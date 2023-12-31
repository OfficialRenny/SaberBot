/*
 * Warframe.market API
 *
 * ## Documentation is under very slow and heavy development  This document will gradually be supplemented and updated over some extended period of time.  ## Unstable endpoints Endpoint that is not stable and probably will be changed in the future will be marked with exclamation sign -> ⚠ 
 *
 * The version of the OpenAPI document: 1.14.0
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
using OpenAPIDateConverter = WarframeMarket.Client.OpenAPIDateConverter;

namespace WarframeMarket.Model
{
    /// <summary>
    /// DropsourceRelicRates
    /// </summary>
    [DataContract(Name = "DropsourceRelic_rates")]
    public partial class DropsourceRelicRates : IEquatable<DropsourceRelicRates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DropsourceRelicRates" /> class.
        /// </summary>
        /// <param name="intact">intact.</param>
        /// <param name="exceptional">exceptional.</param>
        /// <param name="flawless">flawless.</param>
        /// <param name="radiant">radiant.</param>
        public DropsourceRelicRates(decimal intact = default(decimal), decimal exceptional = default(decimal), decimal flawless = default(decimal), decimal radiant = default(decimal))
        {
            this.Intact = intact;
            this.Exceptional = exceptional;
            this.Flawless = flawless;
            this.Radiant = radiant;
        }

        /// <summary>
        /// Gets or Sets Intact
        /// </summary>
        /// <example>11.0</example>
        [DataMember(Name = "intact", EmitDefaultValue = false)]
        public decimal Intact { get; set; }

        /// <summary>
        /// Gets or Sets Exceptional
        /// </summary>
        /// <example>13.0</example>
        [DataMember(Name = "exceptional", EmitDefaultValue = false)]
        public decimal Exceptional { get; set; }

        /// <summary>
        /// Gets or Sets Flawless
        /// </summary>
        /// <example>17.0</example>
        [DataMember(Name = "flawless", EmitDefaultValue = false)]
        public decimal Flawless { get; set; }

        /// <summary>
        /// Gets or Sets Radiant
        /// </summary>
        /// <example>20.0</example>
        [DataMember(Name = "radiant", EmitDefaultValue = false)]
        public decimal Radiant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DropsourceRelicRates {\n");
            sb.Append("  Intact: ").Append(Intact).Append("\n");
            sb.Append("  Exceptional: ").Append(Exceptional).Append("\n");
            sb.Append("  Flawless: ").Append(Flawless).Append("\n");
            sb.Append("  Radiant: ").Append(Radiant).Append("\n");
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
            return this.Equals(input as DropsourceRelicRates);
        }

        /// <summary>
        /// Returns true if DropsourceRelicRates instances are equal
        /// </summary>
        /// <param name="input">Instance of DropsourceRelicRates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DropsourceRelicRates input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Intact == input.Intact ||
                    this.Intact.Equals(input.Intact)
                ) && 
                (
                    this.Exceptional == input.Exceptional ||
                    this.Exceptional.Equals(input.Exceptional)
                ) && 
                (
                    this.Flawless == input.Flawless ||
                    this.Flawless.Equals(input.Flawless)
                ) && 
                (
                    this.Radiant == input.Radiant ||
                    this.Radiant.Equals(input.Radiant)
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
                hashCode = (hashCode * 59) + this.Intact.GetHashCode();
                hashCode = (hashCode * 59) + this.Exceptional.GetHashCode();
                hashCode = (hashCode * 59) + this.Flawless.GetHashCode();
                hashCode = (hashCode * 59) + this.Radiant.GetHashCode();
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
