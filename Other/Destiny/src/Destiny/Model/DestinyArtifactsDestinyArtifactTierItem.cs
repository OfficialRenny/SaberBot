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
    /// DestinyArtifactsDestinyArtifactTierItem
    /// </summary>
    [DataContract(Name = "Destiny.Artifacts.DestinyArtifactTierItem")]
    public partial class DestinyArtifactsDestinyArtifactTierItem : IEquatable<DestinyArtifactsDestinyArtifactTierItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyArtifactsDestinyArtifactTierItem" /> class.
        /// </summary>
        /// <param name="itemHash">itemHash.</param>
        /// <param name="isActive">isActive.</param>
        public DestinyArtifactsDestinyArtifactTierItem(int itemHash = default(int), bool isActive = default(bool))
        {
            this.ItemHash = itemHash;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Gets or Sets ItemHash
        /// </summary>
        [DataMember(Name = "itemHash", EmitDefaultValue = false)]
        public int ItemHash { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyArtifactsDestinyArtifactTierItem {\n");
            sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
            return this.Equals(input as DestinyArtifactsDestinyArtifactTierItem);
        }

        /// <summary>
        /// Returns true if DestinyArtifactsDestinyArtifactTierItem instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyArtifactsDestinyArtifactTierItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyArtifactsDestinyArtifactTierItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemHash == input.ItemHash ||
                    this.ItemHash.Equals(input.ItemHash)
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
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
                hashCode = (hashCode * 59) + this.ItemHash.GetHashCode();
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
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
