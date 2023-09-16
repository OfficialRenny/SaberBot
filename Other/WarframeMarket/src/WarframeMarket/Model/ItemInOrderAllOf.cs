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
    /// ItemInOrderAllOf
    /// </summary>
    [DataContract(Name = "ItemInOrder_allOf")]
    public partial class ItemInOrderAllOf : IEquatable<ItemInOrderAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemInOrderAllOf" /> class.
        /// </summary>
        /// <param name="en">en.</param>
        /// <param name="ru">ru.</param>
        /// <param name="ko">ko.</param>
        /// <param name="fr">fr.</param>
        /// <param name="de">de.</param>
        /// <param name="sv">sv.</param>
        /// <param name="zhHant">zhHant.</param>
        /// <param name="zhHans">zhHans.</param>
        /// <param name="pt">pt.</param>
        /// <param name="es">es.</param>
        /// <param name="pl">pl.</param>
        public ItemInOrderAllOf(ItemInOrderAllOfEn en = default(ItemInOrderAllOfEn), ItemInOrderAllOfRu ru = default(ItemInOrderAllOfRu), ItemInOrderAllOfKo ko = default(ItemInOrderAllOfKo), ItemInOrderAllOfFr fr = default(ItemInOrderAllOfFr), ItemInOrderAllOfDe de = default(ItemInOrderAllOfDe), ItemInOrderAllOfEn sv = default(ItemInOrderAllOfEn), ItemInOrderAllOfZhHant zhHant = default(ItemInOrderAllOfZhHant), ItemInOrderAllOfZhHans zhHans = default(ItemInOrderAllOfZhHans), ItemInOrderAllOfPt pt = default(ItemInOrderAllOfPt), ItemInOrderAllOfEs es = default(ItemInOrderAllOfEs), ItemInOrderAllOfPl pl = default(ItemInOrderAllOfPl))
        {
            this.En = en;
            this.Ru = ru;
            this.Ko = ko;
            this.Fr = fr;
            this.De = de;
            this.Sv = sv;
            this.ZhHant = zhHant;
            this.ZhHans = zhHans;
            this.Pt = pt;
            this.Es = es;
            this.Pl = pl;
        }

        /// <summary>
        /// Gets or Sets En
        /// </summary>
        [DataMember(Name = "en", EmitDefaultValue = false)]
        public ItemInOrderAllOfEn En { get; set; }

        /// <summary>
        /// Gets or Sets Ru
        /// </summary>
        [DataMember(Name = "ru", EmitDefaultValue = false)]
        public ItemInOrderAllOfRu Ru { get; set; }

        /// <summary>
        /// Gets or Sets Ko
        /// </summary>
        [DataMember(Name = "ko", EmitDefaultValue = false)]
        public ItemInOrderAllOfKo Ko { get; set; }

        /// <summary>
        /// Gets or Sets Fr
        /// </summary>
        [DataMember(Name = "fr", EmitDefaultValue = false)]
        public ItemInOrderAllOfFr Fr { get; set; }

        /// <summary>
        /// Gets or Sets De
        /// </summary>
        [DataMember(Name = "de", EmitDefaultValue = false)]
        public ItemInOrderAllOfDe De { get; set; }

        /// <summary>
        /// Gets or Sets Sv
        /// </summary>
        [DataMember(Name = "sv", EmitDefaultValue = false)]
        public ItemInOrderAllOfEn Sv { get; set; }

        /// <summary>
        /// Gets or Sets ZhHant
        /// </summary>
        [DataMember(Name = "zh_hant", EmitDefaultValue = false)]
        public ItemInOrderAllOfZhHant ZhHant { get; set; }

        /// <summary>
        /// Gets or Sets ZhHans
        /// </summary>
        [DataMember(Name = "zh_hans", EmitDefaultValue = false)]
        public ItemInOrderAllOfZhHans ZhHans { get; set; }

        /// <summary>
        /// Gets or Sets Pt
        /// </summary>
        [DataMember(Name = "pt", EmitDefaultValue = false)]
        public ItemInOrderAllOfPt Pt { get; set; }

        /// <summary>
        /// Gets or Sets Es
        /// </summary>
        [DataMember(Name = "es", EmitDefaultValue = false)]
        public ItemInOrderAllOfEs Es { get; set; }

        /// <summary>
        /// Gets or Sets Pl
        /// </summary>
        [DataMember(Name = "pl", EmitDefaultValue = false)]
        public ItemInOrderAllOfPl Pl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemInOrderAllOf {\n");
            sb.Append("  En: ").Append(En).Append("\n");
            sb.Append("  Ru: ").Append(Ru).Append("\n");
            sb.Append("  Ko: ").Append(Ko).Append("\n");
            sb.Append("  Fr: ").Append(Fr).Append("\n");
            sb.Append("  De: ").Append(De).Append("\n");
            sb.Append("  Sv: ").Append(Sv).Append("\n");
            sb.Append("  ZhHant: ").Append(ZhHant).Append("\n");
            sb.Append("  ZhHans: ").Append(ZhHans).Append("\n");
            sb.Append("  Pt: ").Append(Pt).Append("\n");
            sb.Append("  Es: ").Append(Es).Append("\n");
            sb.Append("  Pl: ").Append(Pl).Append("\n");
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
            return this.Equals(input as ItemInOrderAllOf);
        }

        /// <summary>
        /// Returns true if ItemInOrderAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemInOrderAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemInOrderAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.En == input.En ||
                    (this.En != null &&
                    this.En.Equals(input.En))
                ) && 
                (
                    this.Ru == input.Ru ||
                    (this.Ru != null &&
                    this.Ru.Equals(input.Ru))
                ) && 
                (
                    this.Ko == input.Ko ||
                    (this.Ko != null &&
                    this.Ko.Equals(input.Ko))
                ) && 
                (
                    this.Fr == input.Fr ||
                    (this.Fr != null &&
                    this.Fr.Equals(input.Fr))
                ) && 
                (
                    this.De == input.De ||
                    (this.De != null &&
                    this.De.Equals(input.De))
                ) && 
                (
                    this.Sv == input.Sv ||
                    (this.Sv != null &&
                    this.Sv.Equals(input.Sv))
                ) && 
                (
                    this.ZhHant == input.ZhHant ||
                    (this.ZhHant != null &&
                    this.ZhHant.Equals(input.ZhHant))
                ) && 
                (
                    this.ZhHans == input.ZhHans ||
                    (this.ZhHans != null &&
                    this.ZhHans.Equals(input.ZhHans))
                ) && 
                (
                    this.Pt == input.Pt ||
                    (this.Pt != null &&
                    this.Pt.Equals(input.Pt))
                ) && 
                (
                    this.Es == input.Es ||
                    (this.Es != null &&
                    this.Es.Equals(input.Es))
                ) && 
                (
                    this.Pl == input.Pl ||
                    (this.Pl != null &&
                    this.Pl.Equals(input.Pl))
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
                if (this.En != null)
                {
                    hashCode = (hashCode * 59) + this.En.GetHashCode();
                }
                if (this.Ru != null)
                {
                    hashCode = (hashCode * 59) + this.Ru.GetHashCode();
                }
                if (this.Ko != null)
                {
                    hashCode = (hashCode * 59) + this.Ko.GetHashCode();
                }
                if (this.Fr != null)
                {
                    hashCode = (hashCode * 59) + this.Fr.GetHashCode();
                }
                if (this.De != null)
                {
                    hashCode = (hashCode * 59) + this.De.GetHashCode();
                }
                if (this.Sv != null)
                {
                    hashCode = (hashCode * 59) + this.Sv.GetHashCode();
                }
                if (this.ZhHant != null)
                {
                    hashCode = (hashCode * 59) + this.ZhHant.GetHashCode();
                }
                if (this.ZhHans != null)
                {
                    hashCode = (hashCode * 59) + this.ZhHans.GetHashCode();
                }
                if (this.Pt != null)
                {
                    hashCode = (hashCode * 59) + this.Pt.GetHashCode();
                }
                if (this.Es != null)
                {
                    hashCode = (hashCode * 59) + this.Es.GetHashCode();
                }
                if (this.Pl != null)
                {
                    hashCode = (hashCode * 59) + this.Pl.GetHashCode();
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
