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
    /// UserUserSearchResponseDetail
    /// </summary>
    [DataContract(Name = "User.UserSearchResponseDetail")]
    public partial class UserUserSearchResponseDetail : IEquatable<UserUserSearchResponseDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUserSearchResponseDetail" /> class.
        /// </summary>
        /// <param name="bungieGlobalDisplayName">bungieGlobalDisplayName.</param>
        /// <param name="bungieGlobalDisplayNameCode">bungieGlobalDisplayNameCode.</param>
        /// <param name="bungieNetMembershipId">bungieNetMembershipId.</param>
        /// <param name="destinyMemberships">destinyMemberships.</param>
        public UserUserSearchResponseDetail(string bungieGlobalDisplayName = default(string), int? bungieGlobalDisplayNameCode = default(int?), long? bungieNetMembershipId = default(long?), List<UserUserInfoCard> destinyMemberships = default(List<UserUserInfoCard>))
        {
            this.BungieGlobalDisplayName = bungieGlobalDisplayName;
            this.BungieGlobalDisplayNameCode = bungieGlobalDisplayNameCode;
            this.BungieNetMembershipId = bungieNetMembershipId;
            this.DestinyMemberships = destinyMemberships;
        }

        /// <summary>
        /// Gets or Sets BungieGlobalDisplayName
        /// </summary>
        [DataMember(Name = "bungieGlobalDisplayName", EmitDefaultValue = false)]
        public string BungieGlobalDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets BungieGlobalDisplayNameCode
        /// </summary>
        [DataMember(Name = "bungieGlobalDisplayNameCode", EmitDefaultValue = true)]
        public int? BungieGlobalDisplayNameCode { get; set; }

        /// <summary>
        /// Gets or Sets BungieNetMembershipId
        /// </summary>
        [DataMember(Name = "bungieNetMembershipId", EmitDefaultValue = true)]
        public long? BungieNetMembershipId { get; set; }

        /// <summary>
        /// Gets or Sets DestinyMemberships
        /// </summary>
        [DataMember(Name = "destinyMemberships", EmitDefaultValue = false)]
        public List<UserUserInfoCard> DestinyMemberships { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserUserSearchResponseDetail {\n");
            sb.Append("  BungieGlobalDisplayName: ").Append(BungieGlobalDisplayName).Append("\n");
            sb.Append("  BungieGlobalDisplayNameCode: ").Append(BungieGlobalDisplayNameCode).Append("\n");
            sb.Append("  BungieNetMembershipId: ").Append(BungieNetMembershipId).Append("\n");
            sb.Append("  DestinyMemberships: ").Append(DestinyMemberships).Append("\n");
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
            return this.Equals(input as UserUserSearchResponseDetail);
        }

        /// <summary>
        /// Returns true if UserUserSearchResponseDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of UserUserSearchResponseDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUserSearchResponseDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BungieGlobalDisplayName == input.BungieGlobalDisplayName ||
                    (this.BungieGlobalDisplayName != null &&
                    this.BungieGlobalDisplayName.Equals(input.BungieGlobalDisplayName))
                ) && 
                (
                    this.BungieGlobalDisplayNameCode == input.BungieGlobalDisplayNameCode ||
                    (this.BungieGlobalDisplayNameCode != null &&
                    this.BungieGlobalDisplayNameCode.Equals(input.BungieGlobalDisplayNameCode))
                ) && 
                (
                    this.BungieNetMembershipId == input.BungieNetMembershipId ||
                    (this.BungieNetMembershipId != null &&
                    this.BungieNetMembershipId.Equals(input.BungieNetMembershipId))
                ) && 
                (
                    this.DestinyMemberships == input.DestinyMemberships ||
                    this.DestinyMemberships != null &&
                    input.DestinyMemberships != null &&
                    this.DestinyMemberships.SequenceEqual(input.DestinyMemberships)
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
                if (this.BungieGlobalDisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.BungieGlobalDisplayName.GetHashCode();
                }
                if (this.BungieGlobalDisplayNameCode != null)
                {
                    hashCode = (hashCode * 59) + this.BungieGlobalDisplayNameCode.GetHashCode();
                }
                if (this.BungieNetMembershipId != null)
                {
                    hashCode = (hashCode * 59) + this.BungieNetMembershipId.GetHashCode();
                }
                if (this.DestinyMemberships != null)
                {
                    hashCode = (hashCode * 59) + this.DestinyMemberships.GetHashCode();
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
