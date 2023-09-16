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
    /// UserShort
    /// </summary>
    [DataContract(Name = "userShort")]
    public partial class UserShort : IEquatable<UserShort>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Ingame for value: ingame
            /// </summary>
            [EnumMember(Value = "ingame")]
            Ingame = 1,

            /// <summary>
            /// Enum Online for value: online
            /// </summary>
            [EnumMember(Value = "online")]
            Online = 2,

            /// <summary>
            /// Enum Offline for value: offline
            /// </summary>
            [EnumMember(Value = "offline")]
            Offline = 3
        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        /// <example>online</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserShort" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="ingameName">ingameName.</param>
        /// <param name="status">status.</param>
        /// <param name="region">region.</param>
        /// <param name="reputation">reputation.</param>
        /// <param name="avatar">avatar.</param>
        /// <param name="lastSeen">lastSeen.</param>
        public UserShort(string id = default(string), string ingameName = default(string), StatusEnum? status = default(StatusEnum?), string region = default(string), int reputation = default(int), string avatar = default(string), DateTime? lastSeen = default(DateTime?))
        {
            this.Id = id;
            this.IngameName = ingameName;
            this.Status = status;
            this.Region = region;
            this.Reputation = reputation;
            this.Avatar = avatar;
            this.LastSeen = lastSeen;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>54e0cdf8e77989024a1e34b2</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IngameName
        /// </summary>
        /// <example>KycKyc</example>
        [DataMember(Name = "ingame_name", EmitDefaultValue = false)]
        public string IngameName { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        /// <example>en</example>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets Reputation
        /// </summary>
        /// <example>12</example>
        [DataMember(Name = "reputation", EmitDefaultValue = false)]
        public int Reputation { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        /// <example>user/avatar/54e0cdf8e77989024a1e34b2.png?0148cdbc2f95ae09d1b7dc863bbff8a9</example>
        [DataMember(Name = "avatar", EmitDefaultValue = true)]
        public string Avatar { get; set; }

        /// <summary>
        /// Gets or Sets LastSeen
        /// </summary>
        /// <example>2021-03-15T15:53:16.133Z</example>
        [DataMember(Name = "last_seen", EmitDefaultValue = true)]
        public DateTime? LastSeen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserShort {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IngameName: ").Append(IngameName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Reputation: ").Append(Reputation).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
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
            return this.Equals(input as UserShort);
        }

        /// <summary>
        /// Returns true if UserShort instances are equal
        /// </summary>
        /// <param name="input">Instance of UserShort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserShort input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IngameName == input.IngameName ||
                    (this.IngameName != null &&
                    this.IngameName.Equals(input.IngameName))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Reputation == input.Reputation ||
                    this.Reputation.Equals(input.Reputation)
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.LastSeen == input.LastSeen ||
                    (this.LastSeen != null &&
                    this.LastSeen.Equals(input.LastSeen))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.IngameName != null)
                {
                    hashCode = (hashCode * 59) + this.IngameName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Reputation.GetHashCode();
                if (this.Avatar != null)
                {
                    hashCode = (hashCode * 59) + this.Avatar.GetHashCode();
                }
                if (this.LastSeen != null)
                {
                    hashCode = (hashCode * 59) + this.LastSeen.GetHashCode();
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
