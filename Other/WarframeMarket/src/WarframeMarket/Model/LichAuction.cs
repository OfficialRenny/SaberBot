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
    /// LichAuction
    /// </summary>
    [DataContract(Name = "lichAuction")]
    public partial class LichAuction : IEquatable<LichAuction>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Element
        /// </summary>
        [DataMember(Name = "element", EmitDefaultValue = false)]
        public Element? Element { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LichAuction" /> class.
        /// </summary>
        /// <param name="type">type of the item, in this case it&#39;s &#x60;lich&#x60;.</param>
        /// <param name="weaponUrlName">url_name of any Kuva weapon.</param>
        /// <param name="element">element.</param>
        /// <param name="damage">damage.</param>
        /// <param name="ephemera">Lich having Kuva ephemera (based on element) (default to false).</param>
        /// <param name="quirk">url_name of any Kuva quirk (default to &quot;undefined&quot;).</param>
        /// <param name="name">Will not be used for now (?).</param>
        public LichAuction(string type = default(string), string weaponUrlName = default(string), Element? element = default(Element?), int damage = default(int), bool ephemera = false, string quirk = @"undefined", string name = default(string))
        {
            this.Type = type;
            this.WeaponUrlName = weaponUrlName;
            this.Element = element;
            this.Damage = damage;
            this.Ephemera = ephemera;
            // use default value if no "quirk" provided
            this.Quirk = quirk ?? @"undefined";
            this.Name = name;
        }

        /// <summary>
        /// type of the item, in this case it&#39;s &#x60;lich&#x60;
        /// </summary>
        /// <value>type of the item, in this case it&#39;s &#x60;lich&#x60;</value>
        /// <example>lich</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// url_name of any Kuva weapon
        /// </summary>
        /// <value>url_name of any Kuva weapon</value>
        /// <example>kuva_ogris</example>
        [DataMember(Name = "weapon_url_name", EmitDefaultValue = false)]
        public string WeaponUrlName { get; set; }

        /// <summary>
        /// Gets or Sets Damage
        /// </summary>
        [DataMember(Name = "damage", EmitDefaultValue = false)]
        public int Damage { get; set; }

        /// <summary>
        /// Lich having Kuva ephemera (based on element)
        /// </summary>
        /// <value>Lich having Kuva ephemera (based on element)</value>
        /// <example>true</example>
        [DataMember(Name = "ephemera", EmitDefaultValue = true)]
        public bool Ephemera { get; set; }

        /// <summary>
        /// url_name of any Kuva quirk
        /// </summary>
        /// <value>url_name of any Kuva quirk</value>
        /// <example>fear_of_kubrows</example>
        [DataMember(Name = "quirk", EmitDefaultValue = false)]
        public string Quirk { get; set; }

        /// <summary>
        /// Will not be used for now (?)
        /// </summary>
        /// <value>Will not be used for now (?)</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LichAuction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WeaponUrlName: ").Append(WeaponUrlName).Append("\n");
            sb.Append("  Element: ").Append(Element).Append("\n");
            sb.Append("  Damage: ").Append(Damage).Append("\n");
            sb.Append("  Ephemera: ").Append(Ephemera).Append("\n");
            sb.Append("  Quirk: ").Append(Quirk).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as LichAuction);
        }

        /// <summary>
        /// Returns true if LichAuction instances are equal
        /// </summary>
        /// <param name="input">Instance of LichAuction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LichAuction input)
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
                    this.WeaponUrlName == input.WeaponUrlName ||
                    (this.WeaponUrlName != null &&
                    this.WeaponUrlName.Equals(input.WeaponUrlName))
                ) && 
                (
                    this.Element == input.Element ||
                    this.Element.Equals(input.Element)
                ) && 
                (
                    this.Damage == input.Damage ||
                    this.Damage.Equals(input.Damage)
                ) && 
                (
                    this.Ephemera == input.Ephemera ||
                    this.Ephemera.Equals(input.Ephemera)
                ) && 
                (
                    this.Quirk == input.Quirk ||
                    (this.Quirk != null &&
                    this.Quirk.Equals(input.Quirk))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.WeaponUrlName != null)
                {
                    hashCode = (hashCode * 59) + this.WeaponUrlName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Element.GetHashCode();
                hashCode = (hashCode * 59) + this.Damage.GetHashCode();
                hashCode = (hashCode * 59) + this.Ephemera.GetHashCode();
                if (this.Quirk != null)
                {
                    hashCode = (hashCode * 59) + this.Quirk.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
            // Damage (int) maximum
            if (this.Damage > (int)60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Damage, must be a value less than or equal to 60.", new [] { "Damage" });
            }

            // Damage (int) minimum
            if (this.Damage < (int)25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Damage, must be a value greater than or equal to 25.", new [] { "Damage" });
            }

            yield break;
        }
    }

}
