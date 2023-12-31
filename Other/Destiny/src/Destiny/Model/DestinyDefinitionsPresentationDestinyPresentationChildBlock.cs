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
    /// DestinyDefinitionsPresentationDestinyPresentationChildBlock
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Presentation.DestinyPresentationChildBlock")]
    public partial class DestinyDefinitionsPresentationDestinyPresentationChildBlock : IEquatable<DestinyDefinitionsPresentationDestinyPresentationChildBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsPresentationDestinyPresentationChildBlock" /> class.
        /// </summary>
        /// <param name="presentationNodeType">presentationNodeType.</param>
        /// <param name="parentPresentationNodeHashes">parentPresentationNodeHashes.</param>
        /// <param name="displayStyle">displayStyle.</param>
        public DestinyDefinitionsPresentationDestinyPresentationChildBlock(int presentationNodeType = default(int), List<int> parentPresentationNodeHashes = default(List<int>), int displayStyle = default(int))
        {
            this.PresentationNodeType = presentationNodeType;
            this.ParentPresentationNodeHashes = parentPresentationNodeHashes;
            this.DisplayStyle = displayStyle;
        }

        /// <summary>
        /// Gets or Sets PresentationNodeType
        /// </summary>
        [DataMember(Name = "presentationNodeType", EmitDefaultValue = false)]
        public int PresentationNodeType { get; set; }

        /// <summary>
        /// Gets or Sets ParentPresentationNodeHashes
        /// </summary>
        [DataMember(Name = "parentPresentationNodeHashes", EmitDefaultValue = false)]
        public List<int> ParentPresentationNodeHashes { get; set; }

        /// <summary>
        /// Gets or Sets DisplayStyle
        /// </summary>
        [DataMember(Name = "displayStyle", EmitDefaultValue = false)]
        public int DisplayStyle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsPresentationDestinyPresentationChildBlock {\n");
            sb.Append("  PresentationNodeType: ").Append(PresentationNodeType).Append("\n");
            sb.Append("  ParentPresentationNodeHashes: ").Append(ParentPresentationNodeHashes).Append("\n");
            sb.Append("  DisplayStyle: ").Append(DisplayStyle).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsPresentationDestinyPresentationChildBlock);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsPresentationDestinyPresentationChildBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsPresentationDestinyPresentationChildBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationChildBlock input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PresentationNodeType == input.PresentationNodeType ||
                    this.PresentationNodeType.Equals(input.PresentationNodeType)
                ) && 
                (
                    this.ParentPresentationNodeHashes == input.ParentPresentationNodeHashes ||
                    this.ParentPresentationNodeHashes != null &&
                    input.ParentPresentationNodeHashes != null &&
                    this.ParentPresentationNodeHashes.SequenceEqual(input.ParentPresentationNodeHashes)
                ) && 
                (
                    this.DisplayStyle == input.DisplayStyle ||
                    this.DisplayStyle.Equals(input.DisplayStyle)
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
                hashCode = (hashCode * 59) + this.PresentationNodeType.GetHashCode();
                if (this.ParentPresentationNodeHashes != null)
                {
                    hashCode = (hashCode * 59) + this.ParentPresentationNodeHashes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DisplayStyle.GetHashCode();
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
