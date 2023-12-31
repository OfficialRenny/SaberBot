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
    /// TokensTwitchDropHistoryResponse
    /// </summary>
    [DataContract(Name = "Tokens.TwitchDropHistoryResponse")]
    public partial class TokensTwitchDropHistoryResponse : IEquatable<TokensTwitchDropHistoryResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines ClaimState
        /// </summary>
        public enum ClaimStateEnum: byte
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2
        }


        /// <summary>
        /// Gets or Sets ClaimState
        /// </summary>
        [DataMember(Name = "ClaimState", EmitDefaultValue = true)]
        public ClaimStateEnum? ClaimState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensTwitchDropHistoryResponse" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="claimState">claimState.</param>
        public TokensTwitchDropHistoryResponse(string title = default(string), string description = default(string), DateTime? createdAt = default(DateTime?), ClaimStateEnum? claimState = default(ClaimStateEnum?))
        {
            this.Title = title;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.ClaimState = claimState;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "Title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "CreatedAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokensTwitchDropHistoryResponse {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ClaimState: ").Append(ClaimState).Append("\n");
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
            return this.Equals(input as TokensTwitchDropHistoryResponse);
        }

        /// <summary>
        /// Returns true if TokensTwitchDropHistoryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TokensTwitchDropHistoryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokensTwitchDropHistoryResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ClaimState == input.ClaimState ||
                    this.ClaimState.Equals(input.ClaimState)
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ClaimState.GetHashCode();
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
