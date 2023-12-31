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
    /// These definitions represent Factions in the game. Factions have ended up unilaterally being related to Vendors that represent them, but that need not necessarily be the case.  A Faction is really just an entity that has a related progression for which a character can gain experience. In Destiny 1, Dead Orbit was an example of a Faction: there happens to be a Vendor that represents Dead Orbit (and indeed, DestinyVendorDefinition.factionHash defines to this relationship), but Dead Orbit could theoretically exist without the Vendor that provides rewards.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyFactionDefinition")]
    public partial class DestinyDefinitionsDestinyFactionDefinition : IEquatable<DestinyDefinitionsDestinyFactionDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyFactionDefinition" /> class.
        /// </summary>
        /// <param name="displayProperties">displayProperties.</param>
        /// <param name="progressionHash">The hash identifier for the DestinyProgressionDefinition that indicates the character&#39;s relationship with this faction in terms of experience and levels..</param>
        /// <param name="tokenValues">The faction token item hashes, and their respective progression values..</param>
        /// <param name="rewardItemHash">The faction reward item hash, usually an engram..</param>
        /// <param name="rewardVendorHash">The faction reward vendor hash, used for faction engram previews..</param>
        /// <param name="vendors">List of vendors that are associated with this faction. The last vendor that passes the unlock flag checks is the one that should be shown..</param>
        /// <param name="hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsDestinyFactionDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), int progressionHash = default(int), Dictionary<string, int> tokenValues = default(Dictionary<string, int>), int rewardItemHash = default(int), int rewardVendorHash = default(int), List<DestinyDefinitionsDestinyFactionVendorDefinition> vendors = default(List<DestinyDefinitionsDestinyFactionVendorDefinition>), int hash = default(int), int index = default(int), bool redacted = default(bool))
        {
            this.DisplayProperties = displayProperties;
            this.ProgressionHash = progressionHash;
            this.TokenValues = tokenValues;
            this.RewardItemHash = rewardItemHash;
            this.RewardVendorHash = rewardVendorHash;
            this.Vendors = vendors;
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
        /// The hash identifier for the DestinyProgressionDefinition that indicates the character&#39;s relationship with this faction in terms of experience and levels.
        /// </summary>
        /// <value>The hash identifier for the DestinyProgressionDefinition that indicates the character&#39;s relationship with this faction in terms of experience and levels.</value>
        [DataMember(Name = "progressionHash", EmitDefaultValue = false)]
        public int ProgressionHash { get; set; }

        /// <summary>
        /// The faction token item hashes, and their respective progression values.
        /// </summary>
        /// <value>The faction token item hashes, and their respective progression values.</value>
        [DataMember(Name = "tokenValues", EmitDefaultValue = false)]
        public Dictionary<string, int> TokenValues { get; set; }

        /// <summary>
        /// The faction reward item hash, usually an engram.
        /// </summary>
        /// <value>The faction reward item hash, usually an engram.</value>
        [DataMember(Name = "rewardItemHash", EmitDefaultValue = false)]
        public int RewardItemHash { get; set; }

        /// <summary>
        /// The faction reward vendor hash, used for faction engram previews.
        /// </summary>
        /// <value>The faction reward vendor hash, used for faction engram previews.</value>
        [DataMember(Name = "rewardVendorHash", EmitDefaultValue = false)]
        public int RewardVendorHash { get; set; }

        /// <summary>
        /// List of vendors that are associated with this faction. The last vendor that passes the unlock flag checks is the one that should be shown.
        /// </summary>
        /// <value>List of vendors that are associated with this faction. The last vendor that passes the unlock flag checks is the one that should be shown.</value>
        [DataMember(Name = "vendors", EmitDefaultValue = false)]
        public List<DestinyDefinitionsDestinyFactionVendorDefinition> Vendors { get; set; }

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
            sb.Append("class DestinyDefinitionsDestinyFactionDefinition {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  ProgressionHash: ").Append(ProgressionHash).Append("\n");
            sb.Append("  TokenValues: ").Append(TokenValues).Append("\n");
            sb.Append("  RewardItemHash: ").Append(RewardItemHash).Append("\n");
            sb.Append("  RewardVendorHash: ").Append(RewardVendorHash).Append("\n");
            sb.Append("  Vendors: ").Append(Vendors).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyFactionDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyFactionDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyFactionDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyFactionDefinition input)
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
                    this.ProgressionHash == input.ProgressionHash ||
                    this.ProgressionHash.Equals(input.ProgressionHash)
                ) && 
                (
                    this.TokenValues == input.TokenValues ||
                    this.TokenValues != null &&
                    input.TokenValues != null &&
                    this.TokenValues.SequenceEqual(input.TokenValues)
                ) && 
                (
                    this.RewardItemHash == input.RewardItemHash ||
                    this.RewardItemHash.Equals(input.RewardItemHash)
                ) && 
                (
                    this.RewardVendorHash == input.RewardVendorHash ||
                    this.RewardVendorHash.Equals(input.RewardVendorHash)
                ) && 
                (
                    this.Vendors == input.Vendors ||
                    this.Vendors != null &&
                    input.Vendors != null &&
                    this.Vendors.SequenceEqual(input.Vendors)
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
                hashCode = (hashCode * 59) + this.ProgressionHash.GetHashCode();
                if (this.TokenValues != null)
                {
                    hashCode = (hashCode * 59) + this.TokenValues.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RewardItemHash.GetHashCode();
                hashCode = (hashCode * 59) + this.RewardVendorHash.GetHashCode();
                if (this.Vendors != null)
                {
                    hashCode = (hashCode * 59) + this.Vendors.GetHashCode();
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
