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
    /// Localized text relevant to a given EMail setting in a given localization. Extra settings specifically for subscriptions.
    /// </summary>
    [DataContract(Name = "User.EMailSettingSubscriptionLocalization")]
    public partial class UserEMailSettingSubscriptionLocalization : IEquatable<UserEMailSettingSubscriptionLocalization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEMailSettingSubscriptionLocalization" /> class.
        /// </summary>
        /// <param name="unknownUserDescription">unknownUserDescription.</param>
        /// <param name="registeredUserDescription">registeredUserDescription.</param>
        /// <param name="unregisteredUserDescription">unregisteredUserDescription.</param>
        /// <param name="unknownUserActionText">unknownUserActionText.</param>
        /// <param name="knownUserActionText">knownUserActionText.</param>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        public UserEMailSettingSubscriptionLocalization(string unknownUserDescription = default(string), string registeredUserDescription = default(string), string unregisteredUserDescription = default(string), string unknownUserActionText = default(string), string knownUserActionText = default(string), string title = default(string), string description = default(string))
        {
            this.UnknownUserDescription = unknownUserDescription;
            this.RegisteredUserDescription = registeredUserDescription;
            this.UnregisteredUserDescription = unregisteredUserDescription;
            this.UnknownUserActionText = unknownUserActionText;
            this.KnownUserActionText = knownUserActionText;
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets UnknownUserDescription
        /// </summary>
        [DataMember(Name = "unknownUserDescription", EmitDefaultValue = false)]
        public string UnknownUserDescription { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredUserDescription
        /// </summary>
        [DataMember(Name = "registeredUserDescription", EmitDefaultValue = false)]
        public string RegisteredUserDescription { get; set; }

        /// <summary>
        /// Gets or Sets UnregisteredUserDescription
        /// </summary>
        [DataMember(Name = "unregisteredUserDescription", EmitDefaultValue = false)]
        public string UnregisteredUserDescription { get; set; }

        /// <summary>
        /// Gets or Sets UnknownUserActionText
        /// </summary>
        [DataMember(Name = "unknownUserActionText", EmitDefaultValue = false)]
        public string UnknownUserActionText { get; set; }

        /// <summary>
        /// Gets or Sets KnownUserActionText
        /// </summary>
        [DataMember(Name = "knownUserActionText", EmitDefaultValue = false)]
        public string KnownUserActionText { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserEMailSettingSubscriptionLocalization {\n");
            sb.Append("  UnknownUserDescription: ").Append(UnknownUserDescription).Append("\n");
            sb.Append("  RegisteredUserDescription: ").Append(RegisteredUserDescription).Append("\n");
            sb.Append("  UnregisteredUserDescription: ").Append(UnregisteredUserDescription).Append("\n");
            sb.Append("  UnknownUserActionText: ").Append(UnknownUserActionText).Append("\n");
            sb.Append("  KnownUserActionText: ").Append(KnownUserActionText).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as UserEMailSettingSubscriptionLocalization);
        }

        /// <summary>
        /// Returns true if UserEMailSettingSubscriptionLocalization instances are equal
        /// </summary>
        /// <param name="input">Instance of UserEMailSettingSubscriptionLocalization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserEMailSettingSubscriptionLocalization input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UnknownUserDescription == input.UnknownUserDescription ||
                    (this.UnknownUserDescription != null &&
                    this.UnknownUserDescription.Equals(input.UnknownUserDescription))
                ) && 
                (
                    this.RegisteredUserDescription == input.RegisteredUserDescription ||
                    (this.RegisteredUserDescription != null &&
                    this.RegisteredUserDescription.Equals(input.RegisteredUserDescription))
                ) && 
                (
                    this.UnregisteredUserDescription == input.UnregisteredUserDescription ||
                    (this.UnregisteredUserDescription != null &&
                    this.UnregisteredUserDescription.Equals(input.UnregisteredUserDescription))
                ) && 
                (
                    this.UnknownUserActionText == input.UnknownUserActionText ||
                    (this.UnknownUserActionText != null &&
                    this.UnknownUserActionText.Equals(input.UnknownUserActionText))
                ) && 
                (
                    this.KnownUserActionText == input.KnownUserActionText ||
                    (this.KnownUserActionText != null &&
                    this.KnownUserActionText.Equals(input.KnownUserActionText))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.UnknownUserDescription != null)
                {
                    hashCode = (hashCode * 59) + this.UnknownUserDescription.GetHashCode();
                }
                if (this.RegisteredUserDescription != null)
                {
                    hashCode = (hashCode * 59) + this.RegisteredUserDescription.GetHashCode();
                }
                if (this.UnregisteredUserDescription != null)
                {
                    hashCode = (hashCode * 59) + this.UnregisteredUserDescription.GetHashCode();
                }
                if (this.UnknownUserActionText != null)
                {
                    hashCode = (hashCode * 59) + this.UnknownUserActionText.GetHashCode();
                }
                if (this.KnownUserActionText != null)
                {
                    hashCode = (hashCode * 59) + this.KnownUserActionText.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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