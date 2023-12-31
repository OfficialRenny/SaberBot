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
    /// Returns the detailed information about a Collectible Presentation Node and any Collectibles that are direct descendants.
    /// </summary>
    [DataContract(Name = "Destiny.Responses.DestinyCollectibleNodeDetailResponse")]
    public partial class DestinyResponsesDestinyCollectibleNodeDetailResponse : IEquatable<DestinyResponsesDestinyCollectibleNodeDetailResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyResponsesDestinyCollectibleNodeDetailResponse" /> class.
        /// </summary>
        /// <param name="collectibles">collectibles.</param>
        /// <param name="collectibleItemComponents">collectibleItemComponents.</param>
        public DestinyResponsesDestinyCollectibleNodeDetailResponse(SingleComponentResponseOfDestinyCollectiblesComponent collectibles = default(SingleComponentResponseOfDestinyCollectiblesComponent), DestinyItemComponentSetOfuint32 collectibleItemComponents = default(DestinyItemComponentSetOfuint32))
        {
            this.Collectibles = collectibles;
            this.CollectibleItemComponents = collectibleItemComponents;
        }

        /// <summary>
        /// Gets or Sets Collectibles
        /// </summary>
        [DataMember(Name = "collectibles", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyCollectiblesComponent Collectibles { get; set; }

        /// <summary>
        /// Gets or Sets CollectibleItemComponents
        /// </summary>
        [DataMember(Name = "collectibleItemComponents", EmitDefaultValue = false)]
        public DestinyItemComponentSetOfuint32 CollectibleItemComponents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyResponsesDestinyCollectibleNodeDetailResponse {\n");
            sb.Append("  Collectibles: ").Append(Collectibles).Append("\n");
            sb.Append("  CollectibleItemComponents: ").Append(CollectibleItemComponents).Append("\n");
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
            return this.Equals(input as DestinyResponsesDestinyCollectibleNodeDetailResponse);
        }

        /// <summary>
        /// Returns true if DestinyResponsesDestinyCollectibleNodeDetailResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyResponsesDestinyCollectibleNodeDetailResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyResponsesDestinyCollectibleNodeDetailResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Collectibles == input.Collectibles ||
                    (this.Collectibles != null &&
                    this.Collectibles.Equals(input.Collectibles))
                ) && 
                (
                    this.CollectibleItemComponents == input.CollectibleItemComponents ||
                    (this.CollectibleItemComponents != null &&
                    this.CollectibleItemComponents.Equals(input.CollectibleItemComponents))
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
                if (this.Collectibles != null)
                {
                    hashCode = (hashCode * 59) + this.Collectibles.GetHashCode();
                }
                if (this.CollectibleItemComponents != null)
                {
                    hashCode = (hashCode * 59) + this.CollectibleItemComponents.GetHashCode();
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
