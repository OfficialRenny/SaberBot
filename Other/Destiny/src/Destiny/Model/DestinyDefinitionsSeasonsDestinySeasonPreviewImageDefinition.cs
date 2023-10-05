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
    /// Defines the thumbnail icon, high-res image, and video link for promotional images
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Seasons.DestinySeasonPreviewImageDefinition")]
    public partial class DestinyDefinitionsSeasonsDestinySeasonPreviewImageDefinition : IEquatable<DestinyDefinitionsSeasonsDestinySeasonPreviewImageDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsSeasonsDestinySeasonPreviewImageDefinition" /> class.
        /// </summary>
        /// <param name="thumbnailImage">A thumbnail icon path to preview seasonal content, probably 480x270..</param>
        /// <param name="highResImage">An optional path to a high-resolution image, probably 1920x1080..</param>
        public DestinyDefinitionsSeasonsDestinySeasonPreviewImageDefinition(string thumbnailImage = default(string), string highResImage = default(string))
        {
            this.ThumbnailImage = thumbnailImage;
            this.HighResImage = highResImage;
        }

        /// <summary>
        /// A thumbnail icon path to preview seasonal content, probably 480x270.
        /// </summary>
        /// <value>A thumbnail icon path to preview seasonal content, probably 480x270.</value>
        [DataMember(Name = "thumbnailImage", EmitDefaultValue = false)]
        public string ThumbnailImage { get; set; }

        /// <summary>
        /// An optional path to a high-resolution image, probably 1920x1080.
        /// </summary>
        /// <value>An optional path to a high-resolution image, probably 1920x1080.</value>
        [DataMember(Name = "highResImage", EmitDefaultValue = false)]
        public string HighResImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsSeasonsDestinySeasonPreviewImageDefinition {\n");
            sb.Append("  ThumbnailImage: ").Append(ThumbnailImage).Append("\n");
            sb.Append("  HighResImage: ").Append(HighResImage).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsSeasonsDestinySeasonPreviewImageDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsSeasonsDestinySeasonPreviewImageDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsSeasonsDestinySeasonPreviewImageDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsSeasonsDestinySeasonPreviewImageDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ThumbnailImage == input.ThumbnailImage ||
                    (this.ThumbnailImage != null &&
                    this.ThumbnailImage.Equals(input.ThumbnailImage))
                ) && 
                (
                    this.HighResImage == input.HighResImage ||
                    (this.HighResImage != null &&
                    this.HighResImage.Equals(input.HighResImage))
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
                if (this.ThumbnailImage != null)
                {
                    hashCode = (hashCode * 59) + this.ThumbnailImage.GetHashCode();
                }
                if (this.HighResImage != null)
                {
                    hashCode = (hashCode * 59) + this.HighResImage.GetHashCode();
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