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
    /// ItemsUrlNameOrdersGet200Response
    /// </summary>
    [DataContract(Name = "_items__url_name__orders_get_200_response")]
    public partial class ItemsUrlNameOrdersGet200Response : IEquatable<ItemsUrlNameOrdersGet200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsUrlNameOrdersGet200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemsUrlNameOrdersGet200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsUrlNameOrdersGet200Response" /> class.
        /// </summary>
        /// <param name="payload">payload (required).</param>
        /// <param name="include">include.</param>
        public ItemsUrlNameOrdersGet200Response(ItemsUrlNameOrdersGet200ResponsePayload payload = default(ItemsUrlNameOrdersGet200ResponsePayload), GetItemInfo200ResponsePayload include = default(GetItemInfo200ResponsePayload))
        {
            // to ensure "payload" is required (not null)
            if (payload == null)
            {
                throw new ArgumentNullException("payload is a required property for ItemsUrlNameOrdersGet200Response and cannot be null");
            }
            this.Payload = payload;
            this.Include = include;
        }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", IsRequired = true, EmitDefaultValue = true)]
        public ItemsUrlNameOrdersGet200ResponsePayload Payload { get; set; }

        /// <summary>
        /// Gets or Sets Include
        /// </summary>
        [DataMember(Name = "include", EmitDefaultValue = false)]
        public GetItemInfo200ResponsePayload Include { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemsUrlNameOrdersGet200Response {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Include: ").Append(Include).Append("\n");
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
            return this.Equals(input as ItemsUrlNameOrdersGet200Response);
        }

        /// <summary>
        /// Returns true if ItemsUrlNameOrdersGet200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemsUrlNameOrdersGet200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemsUrlNameOrdersGet200Response input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) && 
                (
                    this.Include == input.Include ||
                    (this.Include != null &&
                    this.Include.Equals(input.Include))
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
                if (this.Payload != null)
                {
                    hashCode = (hashCode * 59) + this.Payload.GetHashCode();
                }
                if (this.Include != null)
                {
                    hashCode = (hashCode * 59) + this.Include.GetHashCode();
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
