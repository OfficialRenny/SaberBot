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
    /// ItemsUrlNameDropsourcesGet200ResponsePayload
    /// </summary>
    [DataContract(Name = "_items__url_name__dropsources_get_200_response_payload")]
    public partial class ItemsUrlNameDropsourcesGet200ResponsePayload : IEquatable<ItemsUrlNameDropsourcesGet200ResponsePayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsUrlNameDropsourcesGet200ResponsePayload" /> class.
        /// </summary>
        /// <param name="dropsources">dropsources.</param>
        public ItemsUrlNameDropsourcesGet200ResponsePayload(List<ItemsUrlNameDropsourcesGet200ResponsePayloadDropsourcesInner> dropsources = default(List<ItemsUrlNameDropsourcesGet200ResponsePayloadDropsourcesInner>))
        {
            this.Dropsources = dropsources;
        }

        /// <summary>
        /// Gets or Sets Dropsources
        /// </summary>
        [DataMember(Name = "dropsources", EmitDefaultValue = false)]
        public List<ItemsUrlNameDropsourcesGet200ResponsePayloadDropsourcesInner> Dropsources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemsUrlNameDropsourcesGet200ResponsePayload {\n");
            sb.Append("  Dropsources: ").Append(Dropsources).Append("\n");
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
            return this.Equals(input as ItemsUrlNameDropsourcesGet200ResponsePayload);
        }

        /// <summary>
        /// Returns true if ItemsUrlNameDropsourcesGet200ResponsePayload instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemsUrlNameDropsourcesGet200ResponsePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemsUrlNameDropsourcesGet200ResponsePayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Dropsources == input.Dropsources ||
                    this.Dropsources != null &&
                    input.Dropsources != null &&
                    this.Dropsources.SequenceEqual(input.Dropsources)
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
                if (this.Dropsources != null)
                {
                    hashCode = (hashCode * 59) + this.Dropsources.GetHashCode();
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