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
    /// ConfigClanBannerClanBannerDecal
    /// </summary>
    [DataContract(Name = "Config.ClanBanner.ClanBannerDecal")]
    public partial class ConfigClanBannerClanBannerDecal : IEquatable<ConfigClanBannerClanBannerDecal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigClanBannerClanBannerDecal" /> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="foregroundPath">foregroundPath.</param>
        /// <param name="backgroundPath">backgroundPath.</param>
        public ConfigClanBannerClanBannerDecal(string identifier = default(string), string foregroundPath = default(string), string backgroundPath = default(string))
        {
            this.Identifier = identifier;
            this.ForegroundPath = foregroundPath;
            this.BackgroundPath = backgroundPath;
        }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or Sets ForegroundPath
        /// </summary>
        [DataMember(Name = "foregroundPath", EmitDefaultValue = false)]
        public string ForegroundPath { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundPath
        /// </summary>
        [DataMember(Name = "backgroundPath", EmitDefaultValue = false)]
        public string BackgroundPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigClanBannerClanBannerDecal {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  ForegroundPath: ").Append(ForegroundPath).Append("\n");
            sb.Append("  BackgroundPath: ").Append(BackgroundPath).Append("\n");
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
            return this.Equals(input as ConfigClanBannerClanBannerDecal);
        }

        /// <summary>
        /// Returns true if ConfigClanBannerClanBannerDecal instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigClanBannerClanBannerDecal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigClanBannerClanBannerDecal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.ForegroundPath == input.ForegroundPath ||
                    (this.ForegroundPath != null &&
                    this.ForegroundPath.Equals(input.ForegroundPath))
                ) && 
                (
                    this.BackgroundPath == input.BackgroundPath ||
                    (this.BackgroundPath != null &&
                    this.BackgroundPath.Equals(input.BackgroundPath))
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
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                if (this.ForegroundPath != null)
                {
                    hashCode = (hashCode * 59) + this.ForegroundPath.GetHashCode();
                }
                if (this.BackgroundPath != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundPath.GetHashCode();
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
