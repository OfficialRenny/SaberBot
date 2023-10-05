/*
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.18.0
 * Contact: support@bungie.com
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
using OpenAPIDateConverter = Destiny.Client.OpenAPIDateConverter;

namespace Destiny.Model
{
    /// <summary>
    /// TokensPartnerOfferClaimRequest
    /// </summary>
    [DataContract(Name = "Tokens.PartnerOfferClaimRequest")]
    public partial class TokensPartnerOfferClaimRequest : IEquatable<TokensPartnerOfferClaimRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensPartnerOfferClaimRequest" /> class.
        /// </summary>
        /// <param name="partnerOfferId">partnerOfferId.</param>
        /// <param name="bungieNetMembershipId">bungieNetMembershipId.</param>
        /// <param name="transactionId">transactionId.</param>
        public TokensPartnerOfferClaimRequest(string partnerOfferId = default(string), long bungieNetMembershipId = default(long), string transactionId = default(string))
        {
            this.PartnerOfferId = partnerOfferId;
            this.BungieNetMembershipId = bungieNetMembershipId;
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Gets or Sets PartnerOfferId
        /// </summary>
        [DataMember(Name = "PartnerOfferId", EmitDefaultValue = false)]
        public string PartnerOfferId { get; set; }

        /// <summary>
        /// Gets or Sets BungieNetMembershipId
        /// </summary>
        [DataMember(Name = "BungieNetMembershipId", EmitDefaultValue = false)]
        public long BungieNetMembershipId { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name = "TransactionId", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokensPartnerOfferClaimRequest {\n");
            sb.Append("  PartnerOfferId: ").Append(PartnerOfferId).Append("\n");
            sb.Append("  BungieNetMembershipId: ").Append(BungieNetMembershipId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as TokensPartnerOfferClaimRequest);
        }

        /// <summary>
        /// Returns true if TokensPartnerOfferClaimRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TokensPartnerOfferClaimRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokensPartnerOfferClaimRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PartnerOfferId == input.PartnerOfferId ||
                    (this.PartnerOfferId != null &&
                    this.PartnerOfferId.Equals(input.PartnerOfferId))
                ) && 
                (
                    this.BungieNetMembershipId == input.BungieNetMembershipId ||
                    this.BungieNetMembershipId.Equals(input.BungieNetMembershipId)
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                if (this.PartnerOfferId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerOfferId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BungieNetMembershipId.GetHashCode();
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
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
