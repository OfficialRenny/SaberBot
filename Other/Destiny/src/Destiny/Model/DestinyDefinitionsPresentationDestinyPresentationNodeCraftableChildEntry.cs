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
    /// DestinyDefinitionsPresentationDestinyPresentationNodeCraftableChildEntry
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Presentation.DestinyPresentationNodeCraftableChildEntry")]
    public partial class DestinyDefinitionsPresentationDestinyPresentationNodeCraftableChildEntry : IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeCraftableChildEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsPresentationDestinyPresentationNodeCraftableChildEntry" /> class.
        /// </summary>
        /// <param name="craftableItemHash">craftableItemHash.</param>
        /// <param name="nodeDisplayPriority">Use this value to sort the presentation node children in ascending order..</param>
        public DestinyDefinitionsPresentationDestinyPresentationNodeCraftableChildEntry(int craftableItemHash = default(int), int nodeDisplayPriority = default(int))
        {
            this.CraftableItemHash = craftableItemHash;
            this.NodeDisplayPriority = nodeDisplayPriority;
        }

        /// <summary>
        /// Gets or Sets CraftableItemHash
        /// </summary>
        [DataMember(Name = "craftableItemHash", EmitDefaultValue = false)]
        public int CraftableItemHash { get; set; }

        /// <summary>
        /// Use this value to sort the presentation node children in ascending order.
        /// </summary>
        /// <value>Use this value to sort the presentation node children in ascending order.</value>
        [DataMember(Name = "nodeDisplayPriority", EmitDefaultValue = false)]
        public int NodeDisplayPriority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsPresentationDestinyPresentationNodeCraftableChildEntry {\n");
            sb.Append("  CraftableItemHash: ").Append(CraftableItemHash).Append("\n");
            sb.Append("  NodeDisplayPriority: ").Append(NodeDisplayPriority).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsPresentationDestinyPresentationNodeCraftableChildEntry);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsPresentationDestinyPresentationNodeCraftableChildEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsPresentationDestinyPresentationNodeCraftableChildEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeCraftableChildEntry input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CraftableItemHash == input.CraftableItemHash ||
                    this.CraftableItemHash.Equals(input.CraftableItemHash)
                ) && 
                (
                    this.NodeDisplayPriority == input.NodeDisplayPriority ||
                    this.NodeDisplayPriority.Equals(input.NodeDisplayPriority)
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
                hashCode = (hashCode * 59) + this.CraftableItemHash.GetHashCode();
                hashCode = (hashCode * 59) + this.NodeDisplayPriority.GetHashCode();
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
