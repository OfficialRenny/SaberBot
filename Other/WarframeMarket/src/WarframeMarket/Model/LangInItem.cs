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
    /// LangInItem
    /// </summary>
    [DataContract(Name = "langInItem")]
    public partial class LangInItem : IEquatable<LangInItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LangInItem" /> class.
        /// </summary>
        /// <param name="itemName">itemName.</param>
        /// <param name="description">description.</param>
        /// <param name="wikiLink">wikiLink.</param>
        /// <param name="drop">drop.</param>
        public LangInItem(string itemName = default(string), string description = default(string), string wikiLink = default(string), List<LangInItemDropInner> drop = default(List<LangInItemDropInner>))
        {
            this.ItemName = itemName;
            this.Description = description;
            this.WikiLink = wikiLink;
            this.Drop = drop;
        }

        /// <summary>
        /// Gets or Sets ItemName
        /// </summary>
        /// <example>Axi A1 Relic</example>
        [DataMember(Name = "item_name", EmitDefaultValue = false)]
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /// <example>An artifact containing Orokin secrets. It can only be opened through the power of the Void.</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets WikiLink
        /// </summary>
        /// <example>https://warframe.fandom.com/wiki/Void_Relic</example>
        [DataMember(Name = "wiki_link", EmitDefaultValue = true)]
        public string WikiLink { get; set; }

        /// <summary>
        /// Gets or Sets Drop
        /// </summary>
        [DataMember(Name = "drop", EmitDefaultValue = false)]
        public List<LangInItemDropInner> Drop { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LangInItem {\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WikiLink: ").Append(WikiLink).Append("\n");
            sb.Append("  Drop: ").Append(Drop).Append("\n");
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
            return this.Equals(input as LangInItem);
        }

        /// <summary>
        /// Returns true if LangInItem instances are equal
        /// </summary>
        /// <param name="input">Instance of LangInItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LangInItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.WikiLink == input.WikiLink ||
                    (this.WikiLink != null &&
                    this.WikiLink.Equals(input.WikiLink))
                ) && 
                (
                    this.Drop == input.Drop ||
                    this.Drop != null &&
                    input.Drop != null &&
                    this.Drop.SequenceEqual(input.Drop)
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
                if (this.ItemName != null)
                {
                    hashCode = (hashCode * 59) + this.ItemName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.WikiLink != null)
                {
                    hashCode = (hashCode * 59) + this.WikiLink.GetHashCode();
                }
                if (this.Drop != null)
                {
                    hashCode = (hashCode * 59) + this.Drop.GetHashCode();
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
