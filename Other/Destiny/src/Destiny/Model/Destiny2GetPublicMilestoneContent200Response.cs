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
    /// Destiny2GetPublicMilestoneContent200Response
    /// </summary>
    [DataContract(Name = "Destiny2_GetPublicMilestoneContent_200_response")]
    public partial class Destiny2GetPublicMilestoneContent200Response : IEquatable<Destiny2GetPublicMilestoneContent200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Destiny2GetPublicMilestoneContent200Response" /> class.
        /// </summary>
        /// <param name="response">response.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="throttleSeconds">throttleSeconds.</param>
        /// <param name="errorStatus">errorStatus.</param>
        /// <param name="message">message.</param>
        /// <param name="messageData">messageData.</param>
        /// <param name="detailedErrorTrace">detailedErrorTrace.</param>
        public Destiny2GetPublicMilestoneContent200Response(DestinyMilestonesDestinyMilestoneContent response = default(DestinyMilestonesDestinyMilestoneContent), int errorCode = default(int), int throttleSeconds = default(int), string errorStatus = default(string), string message = default(string), Dictionary<string, string> messageData = default(Dictionary<string, string>), string detailedErrorTrace = default(string))
        {
            this.Response = response;
            this.ErrorCode = errorCode;
            this.ThrottleSeconds = throttleSeconds;
            this.ErrorStatus = errorStatus;
            this.Message = message;
            this.MessageData = messageData;
            this.DetailedErrorTrace = detailedErrorTrace;
        }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name = "Response", EmitDefaultValue = false)]
        public DestinyMilestonesDestinyMilestoneContent Response { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "ErrorCode", EmitDefaultValue = false)]
        public int ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ThrottleSeconds
        /// </summary>
        [DataMember(Name = "ThrottleSeconds", EmitDefaultValue = false)]
        public int ThrottleSeconds { get; set; }

        /// <summary>
        /// Gets or Sets ErrorStatus
        /// </summary>
        [DataMember(Name = "ErrorStatus", EmitDefaultValue = false)]
        public string ErrorStatus { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "Message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets MessageData
        /// </summary>
        [DataMember(Name = "MessageData", EmitDefaultValue = false)]
        public Dictionary<string, string> MessageData { get; set; }

        /// <summary>
        /// Gets or Sets DetailedErrorTrace
        /// </summary>
        [DataMember(Name = "DetailedErrorTrace", EmitDefaultValue = false)]
        public string DetailedErrorTrace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Destiny2GetPublicMilestoneContent200Response {\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ThrottleSeconds: ").Append(ThrottleSeconds).Append("\n");
            sb.Append("  ErrorStatus: ").Append(ErrorStatus).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageData: ").Append(MessageData).Append("\n");
            sb.Append("  DetailedErrorTrace: ").Append(DetailedErrorTrace).Append("\n");
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
            return this.Equals(input as Destiny2GetPublicMilestoneContent200Response);
        }

        /// <summary>
        /// Returns true if Destiny2GetPublicMilestoneContent200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of Destiny2GetPublicMilestoneContent200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Destiny2GetPublicMilestoneContent200Response input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    this.ErrorCode.Equals(input.ErrorCode)
                ) && 
                (
                    this.ThrottleSeconds == input.ThrottleSeconds ||
                    this.ThrottleSeconds.Equals(input.ThrottleSeconds)
                ) && 
                (
                    this.ErrorStatus == input.ErrorStatus ||
                    (this.ErrorStatus != null &&
                    this.ErrorStatus.Equals(input.ErrorStatus))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MessageData == input.MessageData ||
                    this.MessageData != null &&
                    input.MessageData != null &&
                    this.MessageData.SequenceEqual(input.MessageData)
                ) && 
                (
                    this.DetailedErrorTrace == input.DetailedErrorTrace ||
                    (this.DetailedErrorTrace != null &&
                    this.DetailedErrorTrace.Equals(input.DetailedErrorTrace))
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
                if (this.Response != null)
                {
                    hashCode = (hashCode * 59) + this.Response.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                hashCode = (hashCode * 59) + this.ThrottleSeconds.GetHashCode();
                if (this.ErrorStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorStatus.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.MessageData != null)
                {
                    hashCode = (hashCode * 59) + this.MessageData.GetHashCode();
                }
                if (this.DetailedErrorTrace != null)
                {
                    hashCode = (hashCode * 59) + this.DetailedErrorTrace.GetHashCode();
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
