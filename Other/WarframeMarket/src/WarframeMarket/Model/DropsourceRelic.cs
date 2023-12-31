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
    /// DropsourceRelic
    /// </summary>
    [DataContract(Name = "DropsourceRelic")]
    public partial class DropsourceRelic : IEquatable<DropsourceRelic>, IValidatableObject
    {
        /// <summary>
        /// How rare item is
        /// </summary>
        /// <value>How rare item is</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RarityEnum
        {
            /// <summary>
            /// Enum Common for value: common
            /// </summary>
            [EnumMember(Value = "common")]
            Common = 1,

            /// <summary>
            /// Enum Uncommon for value: uncommon
            /// </summary>
            [EnumMember(Value = "uncommon")]
            Uncommon = 2,

            /// <summary>
            /// Enum Rare for value: rare
            /// </summary>
            [EnumMember(Value = "rare")]
            Rare = 3
        }


        /// <summary>
        /// How rare item is
        /// </summary>
        /// <value>How rare item is</value>
        [DataMember(Name = "rarity", EmitDefaultValue = false)]
        public RarityEnum? Rarity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DropsourceRelic" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="item">item.</param>
        /// <param name="relic">relic.</param>
        /// <param name="rarity">How rare item is.</param>
        /// <param name="rates">rates.</param>
        /// <param name="id">id.</param>
        public DropsourceRelic(string type = default(string), string item = default(string), string relic = default(string), RarityEnum? rarity = default(RarityEnum?), DropsourceRelicRates rates = default(DropsourceRelicRates), string id = default(string))
        {
            this.Type = type;
            this.Item = item;
            this.Relic = relic;
            this.Rarity = rarity;
            this.Rates = rates;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>relic</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        /// <example>5a2feeb1c2c9e90cbdaa23d2</example>
        [DataMember(Name = "item", EmitDefaultValue = false)]
        public string Item { get; set; }

        /// <summary>
        /// Gets or Sets Relic
        /// </summary>
        /// <example>6054dd405221e30057500f44</example>
        [DataMember(Name = "relic", EmitDefaultValue = false)]
        public string Relic { get; set; }

        /// <summary>
        /// Gets or Sets Rates
        /// </summary>
        [DataMember(Name = "rates", EmitDefaultValue = false)]
        public DropsourceRelicRates Rates { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>5a2feeb1c2c9e90cbdaa23d2</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DropsourceRelic {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Relic: ").Append(Relic).Append("\n");
            sb.Append("  Rarity: ").Append(Rarity).Append("\n");
            sb.Append("  Rates: ").Append(Rates).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as DropsourceRelic);
        }

        /// <summary>
        /// Returns true if DropsourceRelic instances are equal
        /// </summary>
        /// <param name="input">Instance of DropsourceRelic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DropsourceRelic input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                    this.Rarity == input.Rarity ||
                    this.Rarity.Equals(input.Rarity)
                ) && 
                (
                    this.Rates == input.Rates ||
                    (this.Rates != null &&
                    this.Rates.Equals(input.Rates))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Item != null)
                {
                    hashCode = (hashCode * 59) + this.Item.GetHashCode();
                }
                if (this.Relic != null)
                {
                    hashCode = (hashCode * 59) + this.Relic.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rarity.GetHashCode();
                if (this.Rates != null)
                {
                    hashCode = (hashCode * 59) + this.Rates.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
