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
    /// Defines the promotional text, images, and links to preview this season.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Seasons.DestinySeasonPreviewDefinition")]
    public partial class DestinyDefinitionsSeasonsDestinySeasonPreviewDefinition : IEquatable<DestinyDefinitionsSeasonsDestinySeasonPreviewDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsSeasonsDestinySeasonPreviewDefinition" /> class.
        /// </summary>
        /// <param name="description">A localized description of the season..</param>
        /// <param name="linkPath">A relative path to learn more about the season. Web browsers should be automatically redirected to the user&#39;s Bungie.net locale. For example: \&quot;/SeasonOfTheChosen\&quot; will redirect to \&quot;/7/en/Seasons/SeasonOfTheChosen\&quot; for English users..</param>
        /// <param name="videoLink">An optional link to a localized video, probably YouTube..</param>
        /// <param name="images">A list of images to preview the seasonal content. Should have at least three to show..</param>
        public DestinyDefinitionsSeasonsDestinySeasonPreviewDefinition(string description = default(string), string linkPath = default(string), string videoLink = default(string), List<DestinyDefinitionsSeasonsDestinySeasonPreviewImageDefinition> images = default(List<DestinyDefinitionsSeasonsDestinySeasonPreviewImageDefinition>))
        {
            this.Description = description;
            this.LinkPath = linkPath;
            this.VideoLink = videoLink;
            this.Images = images;
        }

        /// <summary>
        /// A localized description of the season.
        /// </summary>
        /// <value>A localized description of the season.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// A relative path to learn more about the season. Web browsers should be automatically redirected to the user&#39;s Bungie.net locale. For example: \&quot;/SeasonOfTheChosen\&quot; will redirect to \&quot;/7/en/Seasons/SeasonOfTheChosen\&quot; for English users.
        /// </summary>
        /// <value>A relative path to learn more about the season. Web browsers should be automatically redirected to the user&#39;s Bungie.net locale. For example: \&quot;/SeasonOfTheChosen\&quot; will redirect to \&quot;/7/en/Seasons/SeasonOfTheChosen\&quot; for English users.</value>
        [DataMember(Name = "linkPath", EmitDefaultValue = false)]
        public string LinkPath { get; set; }

        /// <summary>
        /// An optional link to a localized video, probably YouTube.
        /// </summary>
        /// <value>An optional link to a localized video, probably YouTube.</value>
        [DataMember(Name = "videoLink", EmitDefaultValue = false)]
        public string VideoLink { get; set; }

        /// <summary>
        /// A list of images to preview the seasonal content. Should have at least three to show.
        /// </summary>
        /// <value>A list of images to preview the seasonal content. Should have at least three to show.</value>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<DestinyDefinitionsSeasonsDestinySeasonPreviewImageDefinition> Images { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsSeasonsDestinySeasonPreviewDefinition {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LinkPath: ").Append(LinkPath).Append("\n");
            sb.Append("  VideoLink: ").Append(VideoLink).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsSeasonsDestinySeasonPreviewDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsSeasonsDestinySeasonPreviewDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsSeasonsDestinySeasonPreviewDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsSeasonsDestinySeasonPreviewDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LinkPath == input.LinkPath ||
                    (this.LinkPath != null &&
                    this.LinkPath.Equals(input.LinkPath))
                ) && 
                (
                    this.VideoLink == input.VideoLink ||
                    (this.VideoLink != null &&
                    this.VideoLink.Equals(input.VideoLink))
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.LinkPath != null)
                {
                    hashCode = (hashCode * 59) + this.LinkPath.GetHashCode();
                }
                if (this.VideoLink != null)
                {
                    hashCode = (hashCode * 59) + this.VideoLink.GetHashCode();
                }
                if (this.Images != null)
                {
                    hashCode = (hashCode * 59) + this.Images.GetHashCode();
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
