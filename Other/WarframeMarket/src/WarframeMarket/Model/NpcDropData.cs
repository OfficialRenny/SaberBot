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
    /// What you can get from this npc
    /// </summary>
    [DataContract(Name = "NpcDropData")]
    public partial class NpcDropData : IEquatable<NpcDropData>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Npc for value: npc
            /// </summary>
            [EnumMember(Value = "npc")]
            Npc = 1
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
        /// Initializes a new instance of the <see cref="NpcDropData" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="item">id of an item.</param>
        /// <param name="npc">id of an npc.</param>
        /// <param name="rate">Chance to get item on kill.</param>
        /// <param name="rarity">rarity.</param>
        public NpcDropData(TypeEnum? type = default(TypeEnum?), string item = default(string), string npc = default(string), decimal rate = default(decimal), Rarities? rarity = default(Rarities?))
        {
            this.Type = type;
            this.Item = item;
            this.Npc = npc;
            this.Rate = rate;
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
        /// id of an npc
        /// </summary>
        /// <value>id of an npc</value>
        /// <example>5a2feeb1c2c9e90cbdaa23d2</example>
        [DataMember(Name = "npc", EmitDefaultValue = false)]
        public string Npc { get; set; }

        /// <summary>
        /// Chance to get item on kill
        /// </summary>
        /// <value>Chance to get item on kill</value>
        /// <example>4.5</example>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        public decimal Rate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NpcDropData {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Npc: ").Append(Npc).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
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
            return this.Equals(input as NpcDropData);
        }

        /// <summary>
        /// Returns true if NpcDropData instances are equal
        /// </summary>
        /// <param name="input">Instance of NpcDropData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NpcDropData input)
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
                    this.Npc == input.Npc ||
                    (this.Npc != null &&
                    this.Npc.Equals(input.Npc))
                ) && 
                (
                    this.Rate == input.Rate ||
                    this.Rate.Equals(input.Rate)
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
                if (this.Npc != null)
                {
                    hashCode = (hashCode * 59) + this.Npc.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rate.GetHashCode();
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
