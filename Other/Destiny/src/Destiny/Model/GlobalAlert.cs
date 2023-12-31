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
    /// GlobalAlert
    /// </summary>
    [DataContract(Name = "GlobalAlert")]
    public partial class GlobalAlert : IEquatable<GlobalAlert>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalAlert" /> class.
        /// </summary>
        /// <param name="alertKey">alertKey.</param>
        /// <param name="alertHtml">alertHtml.</param>
        /// <param name="alertTimestamp">alertTimestamp.</param>
        /// <param name="alertLink">alertLink.</param>
        /// <param name="alertLevel">alertLevel.</param>
        /// <param name="alertType">alertType.</param>
        /// <param name="streamInfo">streamInfo.</param>
        public GlobalAlert(string alertKey = default(string), string alertHtml = default(string), DateTime alertTimestamp = default(DateTime), string alertLink = default(string), int alertLevel = default(int), int alertType = default(int), StreamInfo streamInfo = default(StreamInfo))
        {
            this.AlertKey = alertKey;
            this.AlertHtml = alertHtml;
            this.AlertTimestamp = alertTimestamp;
            this.AlertLink = alertLink;
            this.AlertLevel = alertLevel;
            this.AlertType = alertType;
            this.StreamInfo = streamInfo;
        }

        /// <summary>
        /// Gets or Sets AlertKey
        /// </summary>
        [DataMember(Name = "AlertKey", EmitDefaultValue = false)]
        public string AlertKey { get; set; }

        /// <summary>
        /// Gets or Sets AlertHtml
        /// </summary>
        [DataMember(Name = "AlertHtml", EmitDefaultValue = false)]
        public string AlertHtml { get; set; }

        /// <summary>
        /// Gets or Sets AlertTimestamp
        /// </summary>
        [DataMember(Name = "AlertTimestamp", EmitDefaultValue = false)]
        public DateTime AlertTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets AlertLink
        /// </summary>
        [DataMember(Name = "AlertLink", EmitDefaultValue = false)]
        public string AlertLink { get; set; }

        /// <summary>
        /// Gets or Sets AlertLevel
        /// </summary>
        [DataMember(Name = "AlertLevel", EmitDefaultValue = false)]
        public int AlertLevel { get; set; }

        /// <summary>
        /// Gets or Sets AlertType
        /// </summary>
        [DataMember(Name = "AlertType", EmitDefaultValue = false)]
        public int AlertType { get; set; }

        /// <summary>
        /// Gets or Sets StreamInfo
        /// </summary>
        [DataMember(Name = "StreamInfo", EmitDefaultValue = false)]
        public StreamInfo StreamInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GlobalAlert {\n");
            sb.Append("  AlertKey: ").Append(AlertKey).Append("\n");
            sb.Append("  AlertHtml: ").Append(AlertHtml).Append("\n");
            sb.Append("  AlertTimestamp: ").Append(AlertTimestamp).Append("\n");
            sb.Append("  AlertLink: ").Append(AlertLink).Append("\n");
            sb.Append("  AlertLevel: ").Append(AlertLevel).Append("\n");
            sb.Append("  AlertType: ").Append(AlertType).Append("\n");
            sb.Append("  StreamInfo: ").Append(StreamInfo).Append("\n");
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
            return this.Equals(input as GlobalAlert);
        }

        /// <summary>
        /// Returns true if GlobalAlert instances are equal
        /// </summary>
        /// <param name="input">Instance of GlobalAlert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlobalAlert input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlertKey == input.AlertKey ||
                    (this.AlertKey != null &&
                    this.AlertKey.Equals(input.AlertKey))
                ) && 
                (
                    this.AlertHtml == input.AlertHtml ||
                    (this.AlertHtml != null &&
                    this.AlertHtml.Equals(input.AlertHtml))
                ) && 
                (
                    this.AlertTimestamp == input.AlertTimestamp ||
                    (this.AlertTimestamp != null &&
                    this.AlertTimestamp.Equals(input.AlertTimestamp))
                ) && 
                (
                    this.AlertLink == input.AlertLink ||
                    (this.AlertLink != null &&
                    this.AlertLink.Equals(input.AlertLink))
                ) && 
                (
                    this.AlertLevel == input.AlertLevel ||
                    this.AlertLevel.Equals(input.AlertLevel)
                ) && 
                (
                    this.AlertType == input.AlertType ||
                    this.AlertType.Equals(input.AlertType)
                ) && 
                (
                    this.StreamInfo == input.StreamInfo ||
                    (this.StreamInfo != null &&
                    this.StreamInfo.Equals(input.StreamInfo))
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
                if (this.AlertKey != null)
                {
                    hashCode = (hashCode * 59) + this.AlertKey.GetHashCode();
                }
                if (this.AlertHtml != null)
                {
                    hashCode = (hashCode * 59) + this.AlertHtml.GetHashCode();
                }
                if (this.AlertTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.AlertTimestamp.GetHashCode();
                }
                if (this.AlertLink != null)
                {
                    hashCode = (hashCode * 59) + this.AlertLink.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AlertLevel.GetHashCode();
                hashCode = (hashCode * 59) + this.AlertType.GetHashCode();
                if (this.StreamInfo != null)
                {
                    hashCode = (hashCode * 59) + this.StreamInfo.GetHashCode();
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
