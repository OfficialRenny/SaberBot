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
    /// AuctionsCreatePost200Response
    /// </summary>
    [DataContract(Name = "_auctions_create_post_200_response")]
    public partial class AuctionsCreatePost200Response : IEquatable<AuctionsCreatePost200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionsCreatePost200Response" /> class.
        /// </summary>
        /// <param name="payload">payload.</param>
        public AuctionsCreatePost200Response(AuctionsCreatePost200ResponsePayload payload = default(AuctionsCreatePost200ResponsePayload))
        {
            this.Payload = payload;
        }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public AuctionsCreatePost200ResponsePayload Payload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuctionsCreatePost200Response {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
            return this.Equals(input as AuctionsCreatePost200Response);
        }

        /// <summary>
        /// Returns true if AuctionsCreatePost200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of AuctionsCreatePost200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuctionsCreatePost200Response input)
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
