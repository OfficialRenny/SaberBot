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
    /// AuctionsSearchTypeRivenGet200ResponsePayload
    /// </summary>
    [DataContract(Name = "_auctions_search_type_riven_get_200_response_payload")]
    public partial class AuctionsSearchTypeRivenGet200ResponsePayload : IEquatable<AuctionsSearchTypeRivenGet200ResponsePayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionsSearchTypeRivenGet200ResponsePayload" /> class.
        /// </summary>
        /// <param name="auctions">auctions.</param>
        public AuctionsSearchTypeRivenGet200ResponsePayload(List<AuctionEntryExpanded> auctions = default(List<AuctionEntryExpanded>))
        {
            this.Auctions = auctions;
        }

        /// <summary>
        /// Gets or Sets Auctions
        /// </summary>
        [DataMember(Name = "auctions", EmitDefaultValue = false)]
        public List<AuctionEntryExpanded> Auctions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuctionsSearchTypeRivenGet200ResponsePayload {\n");
            sb.Append("  Auctions: ").Append(Auctions).Append("\n");
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
            return this.Equals(input as AuctionsSearchTypeRivenGet200ResponsePayload);
        }

        /// <summary>
        /// Returns true if AuctionsSearchTypeRivenGet200ResponsePayload instances are equal
        /// </summary>
        /// <param name="input">Instance of AuctionsSearchTypeRivenGet200ResponsePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuctionsSearchTypeRivenGet200ResponsePayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Auctions == input.Auctions ||
                    this.Auctions != null &&
                    input.Auctions != null &&
                    this.Auctions.SequenceEqual(input.Auctions)
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
                if (this.Auctions != null)
                {
                    hashCode = (hashCode * 59) + this.Auctions.GetHashCode();
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
