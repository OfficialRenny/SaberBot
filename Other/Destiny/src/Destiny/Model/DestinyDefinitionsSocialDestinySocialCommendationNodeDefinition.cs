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
    /// DestinyDefinitionsSocialDestinySocialCommendationNodeDefinition
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Social.DestinySocialCommendationNodeDefinition")]
    public partial class DestinyDefinitionsSocialDestinySocialCommendationNodeDefinition : IEquatable<DestinyDefinitionsSocialDestinySocialCommendationNodeDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsSocialDestinySocialCommendationNodeDefinition" /> class.
        /// </summary>
        /// <param name="displayProperties">displayProperties.</param>
        /// <param name="color">color.</param>
        /// <param name="parentCommendationNodeHash">parentCommendationNodeHash.</param>
        /// <param name="childCommendationNodeHashes">A list of hashes that map to child commendation nodes. Only the root commendations node is expected to have child nodes..</param>
        /// <param name="childCommendationHashes">A list of hashes that map to child commendations..</param>
        /// <param name="hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsSocialDestinySocialCommendationNodeDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), DestinyMiscDestinyColor color = default(DestinyMiscDestinyColor), int parentCommendationNodeHash = default(int), List<int> childCommendationNodeHashes = default(List<int>), List<int> childCommendationHashes = default(List<int>), int hash = default(int), int index = default(int), bool redacted = default(bool))
        {
            this.DisplayProperties = displayProperties;
            this.Color = color;
            this.ParentCommendationNodeHash = parentCommendationNodeHash;
            this.ChildCommendationNodeHashes = childCommendationNodeHashes;
            this.ChildCommendationHashes = childCommendationHashes;
            this.Hash = hash;
            this.Index = index;
            this.Redacted = redacted;
        }

        /// <summary>
        /// Gets or Sets DisplayProperties
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public DestinyMiscDestinyColor Color { get; set; }

        /// <summary>
        /// Gets or Sets ParentCommendationNodeHash
        /// </summary>
        [DataMember(Name = "parentCommendationNodeHash", EmitDefaultValue = false)]
        public int ParentCommendationNodeHash { get; set; }

        /// <summary>
        /// A list of hashes that map to child commendation nodes. Only the root commendations node is expected to have child nodes.
        /// </summary>
        /// <value>A list of hashes that map to child commendation nodes. Only the root commendations node is expected to have child nodes.</value>
        [DataMember(Name = "childCommendationNodeHashes", EmitDefaultValue = false)]
        public List<int> ChildCommendationNodeHashes { get; set; }

        /// <summary>
        /// A list of hashes that map to child commendations.
        /// </summary>
        /// <value>A list of hashes that map to child commendations.</value>
        [DataMember(Name = "childCommendationHashes", EmitDefaultValue = false)]
        public List<int> ChildCommendationHashes { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public int Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        /// <value>The index of the entity as it was found in the investment tables.</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
        [DataMember(Name = "redacted", EmitDefaultValue = true)]
        public bool Redacted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsSocialDestinySocialCommendationNodeDefinition {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  ParentCommendationNodeHash: ").Append(ParentCommendationNodeHash).Append("\n");
            sb.Append("  ChildCommendationNodeHashes: ").Append(ChildCommendationNodeHashes).Append("\n");
            sb.Append("  ChildCommendationHashes: ").Append(ChildCommendationHashes).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsSocialDestinySocialCommendationNodeDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsSocialDestinySocialCommendationNodeDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsSocialDestinySocialCommendationNodeDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsSocialDestinySocialCommendationNodeDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.ParentCommendationNodeHash == input.ParentCommendationNodeHash ||
                    this.ParentCommendationNodeHash.Equals(input.ParentCommendationNodeHash)
                ) && 
                (
                    this.ChildCommendationNodeHashes == input.ChildCommendationNodeHashes ||
                    this.ChildCommendationNodeHashes != null &&
                    input.ChildCommendationNodeHashes != null &&
                    this.ChildCommendationNodeHashes.SequenceEqual(input.ChildCommendationNodeHashes)
                ) && 
                (
                    this.ChildCommendationHashes == input.ChildCommendationHashes ||
                    this.ChildCommendationHashes != null &&
                    input.ChildCommendationHashes != null &&
                    this.ChildCommendationHashes.SequenceEqual(input.ChildCommendationHashes)
                ) && 
                (
                    this.Hash == input.Hash ||
                    this.Hash.Equals(input.Hash)
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Redacted == input.Redacted ||
                    this.Redacted.Equals(input.Redacted)
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
                if (this.DisplayProperties != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayProperties.GetHashCode();
                }
                if (this.Color != null)
                {
                    hashCode = (hashCode * 59) + this.Color.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ParentCommendationNodeHash.GetHashCode();
                if (this.ChildCommendationNodeHashes != null)
                {
                    hashCode = (hashCode * 59) + this.ChildCommendationNodeHashes.GetHashCode();
                }
                if (this.ChildCommendationHashes != null)
                {
                    hashCode = (hashCode * 59) + this.ChildCommendationHashes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this.Redacted.GetHashCode();
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
