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
    /// Many items can be rendered in 3D. When you request this block, you will obtain the custom data needed to render this specific instance of the item.
    /// </summary>
    [DataContract(Name = "Destiny.Entities.Items.DestinyItemRenderComponent")]
    public partial class DestinyEntitiesItemsDestinyItemRenderComponent : IEquatable<DestinyEntitiesItemsDestinyItemRenderComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesItemsDestinyItemRenderComponent" /> class.
        /// </summary>
        /// <param name="useCustomDyes">If you should use custom dyes on this item, it will be indicated here..</param>
        /// <param name="artRegions">A dictionary for rendering gear components, with:  key &#x3D; Art Arrangement Region Index  value &#x3D; The chosen Arrangement Index for the Region, based on the value of a stat on the item used for making the choice..</param>
        public DestinyEntitiesItemsDestinyItemRenderComponent(bool useCustomDyes = default(bool), Dictionary<string, int> artRegions = default(Dictionary<string, int>))
        {
            this.UseCustomDyes = useCustomDyes;
            this.ArtRegions = artRegions;
        }

        /// <summary>
        /// If you should use custom dyes on this item, it will be indicated here.
        /// </summary>
        /// <value>If you should use custom dyes on this item, it will be indicated here.</value>
        [DataMember(Name = "useCustomDyes", EmitDefaultValue = true)]
        public bool UseCustomDyes { get; set; }

        /// <summary>
        /// A dictionary for rendering gear components, with:  key &#x3D; Art Arrangement Region Index  value &#x3D; The chosen Arrangement Index for the Region, based on the value of a stat on the item used for making the choice.
        /// </summary>
        /// <value>A dictionary for rendering gear components, with:  key &#x3D; Art Arrangement Region Index  value &#x3D; The chosen Arrangement Index for the Region, based on the value of a stat on the item used for making the choice.</value>
        [DataMember(Name = "artRegions", EmitDefaultValue = false)]
        public Dictionary<string, int> ArtRegions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyEntitiesItemsDestinyItemRenderComponent {\n");
            sb.Append("  UseCustomDyes: ").Append(UseCustomDyes).Append("\n");
            sb.Append("  ArtRegions: ").Append(ArtRegions).Append("\n");
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
            return this.Equals(input as DestinyEntitiesItemsDestinyItemRenderComponent);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesItemsDestinyItemRenderComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesItemsDestinyItemRenderComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesItemsDestinyItemRenderComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UseCustomDyes == input.UseCustomDyes ||
                    this.UseCustomDyes.Equals(input.UseCustomDyes)
                ) && 
                (
                    this.ArtRegions == input.ArtRegions ||
                    this.ArtRegions != null &&
                    input.ArtRegions != null &&
                    this.ArtRegions.SequenceEqual(input.ArtRegions)
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
                hashCode = (hashCode * 59) + this.UseCustomDyes.GetHashCode();
                if (this.ArtRegions != null)
                {
                    hashCode = (hashCode * 59) + this.ArtRegions.GetHashCode();
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
