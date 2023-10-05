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
    /// DestinyRequestsActionsDestinyPostmasterTransferRequest
    /// </summary>
    [DataContract(Name = "Destiny.Requests.Actions.DestinyPostmasterTransferRequest")]
    public partial class DestinyRequestsActionsDestinyPostmasterTransferRequest : IEquatable<DestinyRequestsActionsDestinyPostmasterTransferRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyRequestsActionsDestinyPostmasterTransferRequest" /> class.
        /// </summary>
        /// <param name="itemReferenceHash">itemReferenceHash.</param>
        /// <param name="stackSize">stackSize.</param>
        /// <param name="itemId">The instance ID of the item for this action request..</param>
        /// <param name="characterId">characterId.</param>
        /// <param name="membershipType">membershipType.</param>
        public DestinyRequestsActionsDestinyPostmasterTransferRequest(int itemReferenceHash = default(int), int stackSize = default(int), long itemId = default(long), long characterId = default(long), int membershipType = default(int))
        {
            this.ItemReferenceHash = itemReferenceHash;
            this.StackSize = stackSize;
            this.ItemId = itemId;
            this.CharacterId = characterId;
            this.MembershipType = membershipType;
        }

        /// <summary>
        /// Gets or Sets ItemReferenceHash
        /// </summary>
        [DataMember(Name = "itemReferenceHash", EmitDefaultValue = false)]
        public int ItemReferenceHash { get; set; }

        /// <summary>
        /// Gets or Sets StackSize
        /// </summary>
        [DataMember(Name = "stackSize", EmitDefaultValue = false)]
        public int StackSize { get; set; }

        /// <summary>
        /// The instance ID of the item for this action request.
        /// </summary>
        /// <value>The instance ID of the item for this action request.</value>
        [DataMember(Name = "itemId", EmitDefaultValue = false)]
        public long ItemId { get; set; }

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
            sb.Append("class DestinyRequestsActionsDestinyPostmasterTransferRequest {\n");
            sb.Append("  ItemReferenceHash: ").Append(ItemReferenceHash).Append("\n");
            sb.Append("  StackSize: ").Append(StackSize).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
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
            return this.Equals(input as DestinyRequestsActionsDestinyPostmasterTransferRequest);
        }

        /// <summary>
        /// Returns true if DestinyRequestsActionsDestinyPostmasterTransferRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyRequestsActionsDestinyPostmasterTransferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyRequestsActionsDestinyPostmasterTransferRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemReferenceHash == input.ItemReferenceHash ||
                    this.ItemReferenceHash.Equals(input.ItemReferenceHash)
                ) && 
                (
                    this.StackSize == input.StackSize ||
                    this.StackSize.Equals(input.StackSize)
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    this.ItemId.Equals(input.ItemId)
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
                hashCode = (hashCode * 59) + this.ItemReferenceHash.GetHashCode();
                hashCode = (hashCode * 59) + this.StackSize.GetHashCode();
                hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
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
