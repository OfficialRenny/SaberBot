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
    /// DestinyRequestsActionsDestinyItemSetActionRequest
    /// </summary>
    [DataContract(Name = "Destiny.Requests.Actions.DestinyItemSetActionRequest")]
    public partial class DestinyRequestsActionsDestinyItemSetActionRequest : IEquatable<DestinyRequestsActionsDestinyItemSetActionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyRequestsActionsDestinyItemSetActionRequest" /> class.
        /// </summary>
        /// <param name="itemIds">itemIds.</param>
        /// <param name="characterId">characterId.</param>
        /// <param name="membershipType">membershipType.</param>
        public DestinyRequestsActionsDestinyItemSetActionRequest(List<long> itemIds = default(List<long>), long characterId = default(long), int membershipType = default(int))
        {
            this.ItemIds = itemIds;
            this.CharacterId = characterId;
            this.MembershipType = membershipType;
        }

        /// <summary>
        /// Gets or Sets ItemIds
        /// </summary>
        [DataMember(Name = "itemIds", EmitDefaultValue = false)]
        public List<long> ItemIds { get; set; }

        /// <summary>
        /// Gets or Sets CharacterId
        /// </summary>
        [DataMember(Name = "characterId", EmitDefaultValue = false)]
        public long CharacterId { get; set; }

        /// <summary>
        /// Gets or Sets MembershipType
        /// </summary>
        [DataMember(Name = "membershipType", EmitDefaultValue = false)]
        public int MembershipType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyRequestsActionsDestinyItemSetActionRequest {\n");
            sb.Append("  ItemIds: ").Append(ItemIds).Append("\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
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
            return this.Equals(input as DestinyRequestsActionsDestinyItemSetActionRequest);
        }

        /// <summary>
        /// Returns true if DestinyRequestsActionsDestinyItemSetActionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyRequestsActionsDestinyItemSetActionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyRequestsActionsDestinyItemSetActionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemIds == input.ItemIds ||
                    this.ItemIds != null &&
                    input.ItemIds != null &&
                    this.ItemIds.SequenceEqual(input.ItemIds)
                ) && 
                (
                    this.CharacterId == input.CharacterId ||
                    this.CharacterId.Equals(input.CharacterId)
                ) && 
                (
                    this.MembershipType == input.MembershipType ||
                    this.MembershipType.Equals(input.MembershipType)
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
                if (this.ItemIds != null)
                {
                    hashCode = (hashCode * 59) + this.ItemIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CharacterId.GetHashCode();
                hashCode = (hashCode * 59) + this.MembershipType.GetHashCode();
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
