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
    /// Properties of a DestinyInventoryItemDefinition that store all of the information we were able to discern about how the item spawns, and where you can find the item.  Items will have many of these sources, one per level at which it spawns, to try and give more granular data about where items spawn for specific level ranges.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Sources.DestinyItemSourceDefinition")]
    public partial class DestinyDefinitionsSourcesDestinyItemSourceDefinition : IEquatable<DestinyDefinitionsSourcesDestinyItemSourceDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsSourcesDestinyItemSourceDefinition" /> class.
        /// </summary>
        /// <param name="level">The level at which the item spawns. Essentially the Primary Key for this source data: there will be multiple of these source entries per item that has source data, grouped by the level at which the item spawns..</param>
        /// <param name="minQuality">The minimum Quality at which the item spawns for this level. Examine DestinyInventoryItemDefinition for more information about what Quality means. Just don&#39;t ask Phaedrus about it, he&#39;ll never stop talking and you&#39;ll have to write a book about it..</param>
        /// <param name="maxQuality">The maximum quality at which the item spawns for this level..</param>
        /// <param name="minLevelRequired">The minimum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing..</param>
        /// <param name="maxLevelRequired">The maximum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing..</param>
        /// <param name="computedStats">The stats computed for this level/quality range..</param>
        /// <param name="sourceHashes">The DestinyRewardSourceDefinitions found that can spawn the item at this level..</param>
        public DestinyDefinitionsSourcesDestinyItemSourceDefinition(int level = default(int), int minQuality = default(int), int maxQuality = default(int), int minLevelRequired = default(int), int maxLevelRequired = default(int), Dictionary<string, DestinyDefinitionsDestinyInventoryItemStatDefinition> computedStats = default(Dictionary<string, DestinyDefinitionsDestinyInventoryItemStatDefinition>), List<int> sourceHashes = default(List<int>))
        {
            this.Level = level;
            this.MinQuality = minQuality;
            this.MaxQuality = maxQuality;
            this.MinLevelRequired = minLevelRequired;
            this.MaxLevelRequired = maxLevelRequired;
            this.ComputedStats = computedStats;
            this.SourceHashes = sourceHashes;
        }

        /// <summary>
        /// The level at which the item spawns. Essentially the Primary Key for this source data: there will be multiple of these source entries per item that has source data, grouped by the level at which the item spawns.
        /// </summary>
        /// <value>The level at which the item spawns. Essentially the Primary Key for this source data: there will be multiple of these source entries per item that has source data, grouped by the level at which the item spawns.</value>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public int Level { get; set; }

        /// <summary>
        /// The minimum Quality at which the item spawns for this level. Examine DestinyInventoryItemDefinition for more information about what Quality means. Just don&#39;t ask Phaedrus about it, he&#39;ll never stop talking and you&#39;ll have to write a book about it.
        /// </summary>
        /// <value>The minimum Quality at which the item spawns for this level. Examine DestinyInventoryItemDefinition for more information about what Quality means. Just don&#39;t ask Phaedrus about it, he&#39;ll never stop talking and you&#39;ll have to write a book about it.</value>
        [DataMember(Name = "minQuality", EmitDefaultValue = false)]
        public int MinQuality { get; set; }

        /// <summary>
        /// The maximum quality at which the item spawns for this level.
        /// </summary>
        /// <value>The maximum quality at which the item spawns for this level.</value>
        [DataMember(Name = "maxQuality", EmitDefaultValue = false)]
        public int MaxQuality { get; set; }

        /// <summary>
        /// The minimum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.
        /// </summary>
        /// <value>The minimum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.</value>
        [DataMember(Name = "minLevelRequired", EmitDefaultValue = false)]
        public int MinLevelRequired { get; set; }

        /// <summary>
        /// The maximum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.
        /// </summary>
        /// <value>The maximum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.</value>
        [DataMember(Name = "maxLevelRequired", EmitDefaultValue = false)]
        public int MaxLevelRequired { get; set; }

        /// <summary>
        /// The stats computed for this level/quality range.
        /// </summary>
        /// <value>The stats computed for this level/quality range.</value>
        [DataMember(Name = "computedStats", EmitDefaultValue = false)]
        public Dictionary<string, DestinyDefinitionsDestinyInventoryItemStatDefinition> ComputedStats { get; set; }

        /// <summary>
        /// The DestinyRewardSourceDefinitions found that can spawn the item at this level.
        /// </summary>
        /// <value>The DestinyRewardSourceDefinitions found that can spawn the item at this level.</value>
        [DataMember(Name = "sourceHashes", EmitDefaultValue = false)]
        public List<int> SourceHashes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsSourcesDestinyItemSourceDefinition {\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  MinQuality: ").Append(MinQuality).Append("\n");
            sb.Append("  MaxQuality: ").Append(MaxQuality).Append("\n");
            sb.Append("  MinLevelRequired: ").Append(MinLevelRequired).Append("\n");
            sb.Append("  MaxLevelRequired: ").Append(MaxLevelRequired).Append("\n");
            sb.Append("  ComputedStats: ").Append(ComputedStats).Append("\n");
            sb.Append("  SourceHashes: ").Append(SourceHashes).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsSourcesDestinyItemSourceDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsSourcesDestinyItemSourceDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsSourcesDestinyItemSourceDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsSourcesDestinyItemSourceDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Level == input.Level ||
                    this.Level.Equals(input.Level)
                ) && 
                (
                    this.MinQuality == input.MinQuality ||
                    this.MinQuality.Equals(input.MinQuality)
                ) && 
                (
                    this.MaxQuality == input.MaxQuality ||
                    this.MaxQuality.Equals(input.MaxQuality)
                ) && 
                (
                    this.MinLevelRequired == input.MinLevelRequired ||
                    this.MinLevelRequired.Equals(input.MinLevelRequired)
                ) && 
                (
                    this.MaxLevelRequired == input.MaxLevelRequired ||
                    this.MaxLevelRequired.Equals(input.MaxLevelRequired)
                ) && 
                (
                    this.ComputedStats == input.ComputedStats ||
                    this.ComputedStats != null &&
                    input.ComputedStats != null &&
                    this.ComputedStats.SequenceEqual(input.ComputedStats)
                ) && 
                (
                    this.SourceHashes == input.SourceHashes ||
                    this.SourceHashes != null &&
                    input.SourceHashes != null &&
                    this.SourceHashes.SequenceEqual(input.SourceHashes)
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
                hashCode = (hashCode * 59) + this.Level.GetHashCode();
                hashCode = (hashCode * 59) + this.MinQuality.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxQuality.GetHashCode();
                hashCode = (hashCode * 59) + this.MinLevelRequired.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxLevelRequired.GetHashCode();
                if (this.ComputedStats != null)
                {
                    hashCode = (hashCode * 59) + this.ComputedStats.GetHashCode();
                }
                if (this.SourceHashes != null)
                {
                    hashCode = (hashCode * 59) + this.SourceHashes.GetHashCode();
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