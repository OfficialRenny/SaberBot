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
    /// DestinyRequestsActionsDestinyInsertPlugsActionRequest
    /// </summary>
    [DataContract(Name = "Destiny.Requests.Actions.DestinyInsertPlugsActionRequest")]
    public partial class DestinyRequestsActionsDestinyInsertPlugsActionRequest : IEquatable<DestinyRequestsActionsDestinyInsertPlugsActionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyRequestsActionsDestinyInsertPlugsActionRequest" /> class.
        /// </summary>
        /// <param name="actionToken">Action token provided by the AwaGetActionToken API call..</param>
        /// <param name="itemInstanceId">The instance ID of the item having a plug inserted. Only instanced items can have sockets..</param>
        /// <param name="plug">plug.</param>
        /// <param name="characterId">characterId.</param>
        /// <param name="membershipType">membershipType.</param>
        public DestinyRequestsActionsDestinyInsertPlugsActionRequest(string actionToken = default(string), long itemInstanceId = default(long), DestinyRequestsActionsDestinyInsertPlugsRequestEntry plug = default(DestinyRequestsActionsDestinyInsertPlugsRequestEntry), long characterId = default(long), int membershipType = default(int))
        {
            this.ActionToken = actionToken;
            this.ItemInstanceId = itemInstanceId;
            this.Plug = plug;
            this.CharacterId = characterId;
            this.MembershipType = membershipType;
        }

        /// <summary>
        /// Action token provided by the AwaGetActionToken API call.
        /// </summary>
        /// <value>Action token provided by the AwaGetActionToken API call.</value>
        [DataMember(Name = "actionToken", EmitDefaultValue = false)]
        public string ActionToken { get; set; }

        /// <summary>
        /// The instance ID of the item having a plug inserted. Only instanced items can have sockets.
        /// </summary>
        /// <value>The instance ID of the item having a plug inserted. Only instanced items can have sockets.</value>
        [DataMember(Name = "itemInstanceId", EmitDefaultValue = false)]
        public long ItemInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets Plug
        /// </summary>
        [DataMember(Name = "plug", EmitDefaultValue = false)]
        public DestinyRequestsActionsDestinyInsertPlugsRequestEntry Plug { get; set; }

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
            sb.Append("class DestinyRequestsActionsDestinyInsertPlugsActionRequest {\n");
            sb.Append("  ActionToken: ").Append(ActionToken).Append("\n");
            sb.Append("  ItemInstanceId: ").Append(ItemInstanceId).Append("\n");
            sb.Append("  Plug: ").Append(Plug).Append("\n");
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
            return this.Equals(input as DestinyRequestsActionsDestinyInsertPlugsActionRequest);
        }

        /// <summary>
        /// Returns true if DestinyRequestsActionsDestinyInsertPlugsActionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyRequestsActionsDestinyInsertPlugsActionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyRequestsActionsDestinyInsertPlugsActionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActionToken == input.ActionToken ||
                    (this.ActionToken != null &&
                    this.ActionToken.Equals(input.ActionToken))
                ) && 
                (
                    this.ItemInstanceId == input.ItemInstanceId ||
                    this.ItemInstanceId.Equals(input.ItemInstanceId)
                ) && 
                (
                    this.Plug == input.Plug ||
                    (this.Plug != null &&
                    this.Plug.Equals(input.Plug))
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
                if (this.ActionToken != null)
                {
                    hashCode = (hashCode * 59) + this.ActionToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemInstanceId.GetHashCode();
                if (this.Plug != null)
                {
                    hashCode = (hashCode * 59) + this.Plug.GetHashCode();
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