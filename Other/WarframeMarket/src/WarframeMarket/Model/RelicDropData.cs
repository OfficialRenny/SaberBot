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
    /// What you can get from this relic
    /// </summary>
    [DataContract(Name = "RelicDropData")]
    public partial class RelicDropData : IEquatable<RelicDropData>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Relic for value: relic
            /// </summary>
            [EnumMember(Value = "relic")]
            Relic = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or Sets Rarity
        /// </summary>
        [DataMember(Name = "rarity", EmitDefaultValue = false)]
        public Rarities? Rarity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelicDropData" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="item">id of an item.</param>
        /// <param name="relic">id of a relic.</param>
        /// <param name="rates">rates.</param>
        /// <param name="rarity">rarity.</param>
        public RelicDropData(TypeEnum? type = default(TypeEnum?), string item = default(string), string relic = default(string), RelicDropDataRates rates = default(RelicDropDataRates), Rarities? rarity = default(Rarities?))
        {
            this.Type = type;
            this.Item = item;
            this.Relic = relic;
            this.Rates = rates;
            this.Rarity = rarity;
        }

        /// <summary>
        /// id of an item
        /// </summary>
        /// <value>id of an item</value>
        /// <example>5a2feeb1c2c9e90cbdaa23d2</example>
        [DataMember(Name = "item", EmitDefaultValue = false)]
        public string Item { get; set; }

        /// <summary>
        /// id of a relic
        /// </summary>
        /// <value>id of a relic</value>
        /// <example>5a2feeb1c2c9e90cbdaa23d2</example>
        [DataMember(Name = "relic", EmitDefaultValue = false)]
        public string Relic { get; set; }

        /// <summary>
        /// Gets or Sets Rates
        /// </summary>
        [DataMember(Name = "rates", EmitDefaultValue = false)]
        public RelicDropDataRates Rates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RelicDropData {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Relic: ").Append(Relic).Append("\n");
            sb.Append("  Rates: ").Append(Rates).Append("\n");
            sb.Append("  Rarity: ").Append(Rarity).Append("\n");
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
            return this.Equals(input as RelicDropData);
        }

        /// <summary>
        /// Returns true if RelicDropData instances are equal
        /// </summary>
        /// <param name="input">Instance of RelicDropData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelicDropData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
                ) && 
                (
                    this.Relic == input.Relic ||
                    (this.Relic != null &&
                    this.Relic.Equals(input.Relic))
                ) && 
                (
                    this.Rates == input.Rates ||
                    (this.Rates != null &&
                    this.Rates.Equals(input.Rates))
                ) && 
                (
                    this.Rarity == input.Rarity ||
                    this.Rarity.Equals(input.Rarity)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Item != null)
                {
                    hashCode = (hashCode * 59) + this.Item.GetHashCode();
                }
                if (this.Relic != null)
                {
                    hashCode = (hashCode * 59) + this.Relic.GetHashCode();
                }
                if (this.Rates != null)
                {
                    hashCode = (hashCode * 59) + this.Rates.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rarity.GetHashCode();
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
