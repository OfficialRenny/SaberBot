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
    /// DestinyDefinitionsLoadoutsDestinyLoadoutConstantsDefinition
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Loadouts.DestinyLoadoutConstantsDefinition")]
    public partial class DestinyDefinitionsLoadoutsDestinyLoadoutConstantsDefinition : IEquatable<DestinyDefinitionsLoadoutsDestinyLoadoutConstantsDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsLoadoutsDestinyLoadoutConstantsDefinition" /> class.
        /// </summary>
        /// <param name="displayProperties">displayProperties.</param>
        /// <param name="whiteIconImagePath">This is the same icon as the one in the display properties, offered here as well with a more descriptive name..</param>
        /// <param name="blackIconImagePath">This is a color-inverted version of the whiteIconImagePath..</param>
        /// <param name="loadoutCountPerCharacter">The maximum number of loadouts available to each character. The loadouts component API response can return fewer loadouts than this, as more loadouts are unlocked by reaching higher Guardian Ranks..</param>
        /// <param name="loadoutPreviewFilterOutSocketCategoryHashes">A list of the socket category hashes to be filtered out of loadout item preview displays..</param>
        /// <param name="loadoutPreviewFilterOutSocketTypeHashes">A list of the socket type hashes to be filtered out of loadout item preview displays..</param>
        /// <param name="loadoutNameHashes">A list of the loadout name hashes in index order, for convenience..</param>
        /// <param name="loadoutIconHashes">A list of the loadout icon hashes in index order, for convenience..</param>
        /// <param name="loadoutColorHashes">A list of the loadout color hashes in index order, for convenience..</param>
        /// <param name="hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsLoadoutsDestinyLoadoutConstantsDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), string whiteIconImagePath = default(string), string blackIconImagePath = default(string), int loadoutCountPerCharacter = default(int), List<int> loadoutPreviewFilterOutSocketCategoryHashes = default(List<int>), List<int> loadoutPreviewFilterOutSocketTypeHashes = default(List<int>), List<int> loadoutNameHashes = default(List<int>), List<int> loadoutIconHashes = default(List<int>), List<int> loadoutColorHashes = default(List<int>), int hash = default(int), int index = default(int), bool redacted = default(bool))
        {
            this.DisplayProperties = displayProperties;
            this.WhiteIconImagePath = whiteIconImagePath;
            this.BlackIconImagePath = blackIconImagePath;
            this.LoadoutCountPerCharacter = loadoutCountPerCharacter;
            this.LoadoutPreviewFilterOutSocketCategoryHashes = loadoutPreviewFilterOutSocketCategoryHashes;
            this.LoadoutPreviewFilterOutSocketTypeHashes = loadoutPreviewFilterOutSocketTypeHashes;
            this.LoadoutNameHashes = loadoutNameHashes;
            this.LoadoutIconHashes = loadoutIconHashes;
            this.LoadoutColorHashes = loadoutColorHashes;
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
        /// This is the same icon as the one in the display properties, offered here as well with a more descriptive name.
        /// </summary>
        /// <value>This is the same icon as the one in the display properties, offered here as well with a more descriptive name.</value>
        [DataMember(Name = "whiteIconImagePath", EmitDefaultValue = false)]
        public string WhiteIconImagePath { get; set; }

        /// <summary>
        /// This is a color-inverted version of the whiteIconImagePath.
        /// </summary>
        /// <value>This is a color-inverted version of the whiteIconImagePath.</value>
        [DataMember(Name = "blackIconImagePath", EmitDefaultValue = false)]
        public string BlackIconImagePath { get; set; }

        /// <summary>
        /// The maximum number of loadouts available to each character. The loadouts component API response can return fewer loadouts than this, as more loadouts are unlocked by reaching higher Guardian Ranks.
        /// </summary>
        /// <value>The maximum number of loadouts available to each character. The loadouts component API response can return fewer loadouts than this, as more loadouts are unlocked by reaching higher Guardian Ranks.</value>
        [DataMember(Name = "loadoutCountPerCharacter", EmitDefaultValue = false)]
        public int LoadoutCountPerCharacter { get; set; }

        /// <summary>
        /// A list of the socket category hashes to be filtered out of loadout item preview displays.
        /// </summary>
        /// <value>A list of the socket category hashes to be filtered out of loadout item preview displays.</value>
        [DataMember(Name = "loadoutPreviewFilterOutSocketCategoryHashes", EmitDefaultValue = false)]
        public List<int> LoadoutPreviewFilterOutSocketCategoryHashes { get; set; }

        /// <summary>
        /// A list of the socket type hashes to be filtered out of loadout item preview displays.
        /// </summary>
        /// <value>A list of the socket type hashes to be filtered out of loadout item preview displays.</value>
        [DataMember(Name = "loadoutPreviewFilterOutSocketTypeHashes", EmitDefaultValue = false)]
        public List<int> LoadoutPreviewFilterOutSocketTypeHashes { get; set; }

        /// <summary>
        /// A list of the loadout name hashes in index order, for convenience.
        /// </summary>
        /// <value>A list of the loadout name hashes in index order, for convenience.</value>
        [DataMember(Name = "loadoutNameHashes", EmitDefaultValue = false)]
        public List<int> LoadoutNameHashes { get; set; }

        /// <summary>
        /// A list of the loadout icon hashes in index order, for convenience.
        /// </summary>
        /// <value>A list of the loadout icon hashes in index order, for convenience.</value>
        [DataMember(Name = "loadoutIconHashes", EmitDefaultValue = false)]
        public List<int> LoadoutIconHashes { get; set; }

        /// <summary>
        /// A list of the loadout color hashes in index order, for convenience.
        /// </summary>
        /// <value>A list of the loadout color hashes in index order, for convenience.</value>
        [DataMember(Name = "loadoutColorHashes", EmitDefaultValue = false)]
        public List<int> LoadoutColorHashes { get; set; }

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
            sb.Append("class DestinyDefinitionsLoadoutsDestinyLoadoutConstantsDefinition {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  WhiteIconImagePath: ").Append(WhiteIconImagePath).Append("\n");
            sb.Append("  BlackIconImagePath: ").Append(BlackIconImagePath).Append("\n");
            sb.Append("  LoadoutCountPerCharacter: ").Append(LoadoutCountPerCharacter).Append("\n");
            sb.Append("  LoadoutPreviewFilterOutSocketCategoryHashes: ").Append(LoadoutPreviewFilterOutSocketCategoryHashes).Append("\n");
            sb.Append("  LoadoutPreviewFilterOutSocketTypeHashes: ").Append(LoadoutPreviewFilterOutSocketTypeHashes).Append("\n");
            sb.Append("  LoadoutNameHashes: ").Append(LoadoutNameHashes).Append("\n");
            sb.Append("  LoadoutIconHashes: ").Append(LoadoutIconHashes).Append("\n");
            sb.Append("  LoadoutColorHashes: ").Append(LoadoutColorHashes).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsLoadoutsDestinyLoadoutConstantsDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsLoadoutsDestinyLoadoutConstantsDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsLoadoutsDestinyLoadoutConstantsDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsLoadoutsDestinyLoadoutConstantsDefinition input)
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
                    this.WhiteIconImagePath == input.WhiteIconImagePath ||
                    (this.WhiteIconImagePath != null &&
                    this.WhiteIconImagePath.Equals(input.WhiteIconImagePath))
                ) && 
                (
                    this.BlackIconImagePath == input.BlackIconImagePath ||
                    (this.BlackIconImagePath != null &&
                    this.BlackIconImagePath.Equals(input.BlackIconImagePath))
                ) && 
                (
                    this.LoadoutCountPerCharacter == input.LoadoutCountPerCharacter ||
                    this.LoadoutCountPerCharacter.Equals(input.LoadoutCountPerCharacter)
                ) && 
                (
                    this.LoadoutPreviewFilterOutSocketCategoryHashes == input.LoadoutPreviewFilterOutSocketCategoryHashes ||
                    this.LoadoutPreviewFilterOutSocketCategoryHashes != null &&
                    input.LoadoutPreviewFilterOutSocketCategoryHashes != null &&
                    this.LoadoutPreviewFilterOutSocketCategoryHashes.SequenceEqual(input.LoadoutPreviewFilterOutSocketCategoryHashes)
                ) && 
                (
                    this.LoadoutPreviewFilterOutSocketTypeHashes == input.LoadoutPreviewFilterOutSocketTypeHashes ||
                    this.LoadoutPreviewFilterOutSocketTypeHashes != null &&
                    input.LoadoutPreviewFilterOutSocketTypeHashes != null &&
                    this.LoadoutPreviewFilterOutSocketTypeHashes.SequenceEqual(input.LoadoutPreviewFilterOutSocketTypeHashes)
                ) && 
                (
                    this.LoadoutNameHashes == input.LoadoutNameHashes ||
                    this.LoadoutNameHashes != null &&
                    input.LoadoutNameHashes != null &&
                    this.LoadoutNameHashes.SequenceEqual(input.LoadoutNameHashes)
                ) && 
                (
                    this.LoadoutIconHashes == input.LoadoutIconHashes ||
                    this.LoadoutIconHashes != null &&
                    input.LoadoutIconHashes != null &&
                    this.LoadoutIconHashes.SequenceEqual(input.LoadoutIconHashes)
                ) && 
                (
                    this.LoadoutColorHashes == input.LoadoutColorHashes ||
                    this.LoadoutColorHashes != null &&
                    input.LoadoutColorHashes != null &&
                    this.LoadoutColorHashes.SequenceEqual(input.LoadoutColorHashes)
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
                if (this.WhiteIconImagePath != null)
                {
                    hashCode = (hashCode * 59) + this.WhiteIconImagePath.GetHashCode();
                }
                if (this.BlackIconImagePath != null)
                {
                    hashCode = (hashCode * 59) + this.BlackIconImagePath.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LoadoutCountPerCharacter.GetHashCode();
                if (this.LoadoutPreviewFilterOutSocketCategoryHashes != null)
                {
                    hashCode = (hashCode * 59) + this.LoadoutPreviewFilterOutSocketCategoryHashes.GetHashCode();
                }
                if (this.LoadoutPreviewFilterOutSocketTypeHashes != null)
                {
                    hashCode = (hashCode * 59) + this.LoadoutPreviewFilterOutSocketTypeHashes.GetHashCode();
                }
                if (this.LoadoutNameHashes != null)
                {
                    hashCode = (hashCode * 59) + this.LoadoutNameHashes.GetHashCode();
                }
                if (this.LoadoutIconHashes != null)
                {
                    hashCode = (hashCode * 59) + this.LoadoutIconHashes.GetHashCode();
                }
                if (this.LoadoutColorHashes != null)
                {
                    hashCode = (hashCode * 59) + this.LoadoutColorHashes.GetHashCode();
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
