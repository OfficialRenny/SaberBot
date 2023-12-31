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
    /// AuthSigninPostRequest
    /// </summary>
    [DataContract(Name = "_auth_signin_post_request")]
    public partial class AuthSigninPostRequest : IEquatable<AuthSigninPostRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines AuthType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthTypeEnum
        {
            /// <summary>
            /// Enum Cookie for value: cookie
            /// </summary>
            [EnumMember(Value = "cookie")]
            Cookie = 1,

            /// <summary>
            /// Enum Header for value: header
            /// </summary>
            [EnumMember(Value = "header")]
            Header = 2
        }


        /// <summary>
        /// Gets or Sets AuthType
        /// </summary>
        [DataMember(Name = "auth_type", EmitDefaultValue = false)]
        public AuthTypeEnum? AuthType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthSigninPostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthSigninPostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthSigninPostRequest" /> class.
        /// </summary>
        /// <param name="authType">authType (default to AuthTypeEnum.Cookie).</param>
        /// <param name="email">email (required).</param>
        /// <param name="password">password (required).</param>
        /// <param name="deviceId">Optional device_id, defined on client side.   This param help us to identify your device between login sessions. .</param>
        public AuthSigninPostRequest(AuthTypeEnum? authType = AuthTypeEnum.Cookie, string email = default(string), string password = default(string), string deviceId = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for AuthSigninPostRequest and cannot be null");
            }
            this.Email = email;
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new ArgumentNullException("password is a required property for AuthSigninPostRequest and cannot be null");
            }
            this.Password = password;
            this.AuthType = authType;
            this.DeviceId = deviceId;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Optional device_id, defined on client side.   This param help us to identify your device between login sessions. 
        /// </summary>
        /// <value>Optional device_id, defined on client side.   This param help us to identify your device between login sessions. </value>
        [DataMember(Name = "device_id", EmitDefaultValue = false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthSigninPostRequest {\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
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
            return this.Equals(input as AuthSigninPostRequest);
        }

        /// <summary>
        /// Returns true if AuthSigninPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthSigninPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthSigninPostRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthType == input.AuthType ||
                    this.AuthType.Equals(input.AuthType)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
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
                hashCode = (hashCode * 59) + this.AuthType.GetHashCode();
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.DeviceId != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceId.GetHashCode();
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
