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
    /// GroupsV2GroupMember
    /// </summary>
    [DataContract(Name = "GroupsV2.GroupMember")]
    public partial class GroupsV2GroupMember : IEquatable<GroupsV2GroupMember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupMember" /> class.
        /// </summary>
        /// <param name="memberType">memberType.</param>
        /// <param name="isOnline">isOnline.</param>
        /// <param name="lastOnlineStatusChange">lastOnlineStatusChange.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="destinyUserInfo">destinyUserInfo.</param>
        /// <param name="bungieNetUserInfo">bungieNetUserInfo.</param>
        /// <param name="joinDate">joinDate.</param>
        public GroupsV2GroupMember(int memberType = default(int), bool isOnline = default(bool), long lastOnlineStatusChange = default(long), long groupId = default(long), GroupsV2GroupUserInfoCard destinyUserInfo = default(GroupsV2GroupUserInfoCard), UserUserInfoCard bungieNetUserInfo = default(UserUserInfoCard), DateTime joinDate = default(DateTime))
        {
            this.MemberType = memberType;
            this.IsOnline = isOnline;
            this.LastOnlineStatusChange = lastOnlineStatusChange;
            this.GroupId = groupId;
            this.DestinyUserInfo = destinyUserInfo;
            this.BungieNetUserInfo = bungieNetUserInfo;
            this.JoinDate = joinDate;
        }

        /// <summary>
        /// Gets or Sets MemberType
        /// </summary>
        [DataMember(Name = "memberType", EmitDefaultValue = false)]
        public int MemberType { get; set; }

        /// <summary>
        /// Gets or Sets IsOnline
        /// </summary>
        [DataMember(Name = "isOnline", EmitDefaultValue = true)]
        public bool IsOnline { get; set; }

        /// <summary>
        /// Gets or Sets LastOnlineStatusChange
        /// </summary>
        [DataMember(Name = "lastOnlineStatusChange", EmitDefaultValue = false)]
        public long LastOnlineStatusChange { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public long GroupId { get; set; }

        /// <summary>
        /// Gets or Sets DestinyUserInfo
        /// </summary>
        [DataMember(Name = "destinyUserInfo", EmitDefaultValue = false)]
        public GroupsV2GroupUserInfoCard DestinyUserInfo { get; set; }

        /// <summary>
        /// Gets or Sets BungieNetUserInfo
        /// </summary>
        [DataMember(Name = "bungieNetUserInfo", EmitDefaultValue = false)]
        public UserUserInfoCard BungieNetUserInfo { get; set; }

        /// <summary>
        /// Gets or Sets JoinDate
        /// </summary>
        [DataMember(Name = "joinDate", EmitDefaultValue = false)]
        public DateTime JoinDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupsV2GroupMember {\n");
            sb.Append("  MemberType: ").Append(MemberType).Append("\n");
            sb.Append("  IsOnline: ").Append(IsOnline).Append("\n");
            sb.Append("  LastOnlineStatusChange: ").Append(LastOnlineStatusChange).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  DestinyUserInfo: ").Append(DestinyUserInfo).Append("\n");
            sb.Append("  BungieNetUserInfo: ").Append(BungieNetUserInfo).Append("\n");
            sb.Append("  JoinDate: ").Append(JoinDate).Append("\n");
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
            return this.Equals(input as GroupsV2GroupMember);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupMember instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupMember input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MemberType == input.MemberType ||
                    this.MemberType.Equals(input.MemberType)
                ) && 
                (
                    this.IsOnline == input.IsOnline ||
                    this.IsOnline.Equals(input.IsOnline)
                ) && 
                (
                    this.LastOnlineStatusChange == input.LastOnlineStatusChange ||
                    this.LastOnlineStatusChange.Equals(input.LastOnlineStatusChange)
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    this.GroupId.Equals(input.GroupId)
                ) && 
                (
                    this.DestinyUserInfo == input.DestinyUserInfo ||
                    (this.DestinyUserInfo != null &&
                    this.DestinyUserInfo.Equals(input.DestinyUserInfo))
                ) && 
                (
                    this.BungieNetUserInfo == input.BungieNetUserInfo ||
                    (this.BungieNetUserInfo != null &&
                    this.BungieNetUserInfo.Equals(input.BungieNetUserInfo))
                ) && 
                (
                    this.JoinDate == input.JoinDate ||
                    (this.JoinDate != null &&
                    this.JoinDate.Equals(input.JoinDate))
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
                hashCode = (hashCode * 59) + this.MemberType.GetHashCode();
                hashCode = (hashCode * 59) + this.IsOnline.GetHashCode();
                hashCode = (hashCode * 59) + this.LastOnlineStatusChange.GetHashCode();
                hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                if (this.DestinyUserInfo != null)
                {
                    hashCode = (hashCode * 59) + this.DestinyUserInfo.GetHashCode();
                }
                if (this.BungieNetUserInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BungieNetUserInfo.GetHashCode();
                }
                if (this.JoinDate != null)
                {
                    hashCode = (hashCode * 59) + this.JoinDate.GetHashCode();
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