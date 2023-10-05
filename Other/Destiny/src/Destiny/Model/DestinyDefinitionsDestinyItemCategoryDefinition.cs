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
    /// In an attempt to categorize items by type, usage, and other interesting properties, we created DestinyItemCategoryDefinition: information about types that is assembled using a set of heuristics that examine the properties of an item such as what inventory bucket it&#39;s in, its item type name, and whether it has or is missing certain blocks of data.  This heuristic is imperfect, however. If you find an item miscategorized, let us know on the Bungie API forums!  We then populate all of the categories that we think an item belongs to in its DestinyInventoryItemDefinition.itemCategoryHashes property. You can use that to provide your own custom item filtering, sorting, aggregating... go nuts on it! And let us know if you see more categories that you wish would be added!
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyItemCategoryDefinition")]
    public partial class DestinyDefinitionsDestinyItemCategoryDefinition : IEquatable<DestinyDefinitionsDestinyItemCategoryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemCategoryDefinition" /> class.
        /// </summary>
        /// <param name="displayProperties">displayProperties.</param>
        /// <param name="visible">If True, this category should be visible in UI. Sometimes we make categories that we don&#39;t think are interesting externally. It&#39;s up to you if you want to skip on showing them..</param>
        /// <param name="deprecated">If True, this category has been deprecated: it may have no items left, or there may be only legacy items that remain in it which are no longer relevant to the game..</param>
        /// <param name="shortTitle">A shortened version of the title. The reason why we have this is because the Armory in German had titles that were too long to display in our UI, so these were localized abbreviated versions of those categories. The property still exists today, even though the Armory doesn&#39;t exist for D2... yet..</param>
        /// <param name="itemTypeRegex">The janky regular expression we used against the item type to try and discern whether the item belongs to this category..</param>
        /// <param name="grantDestinyBreakerType">If the item in question has this category, it also should have this breaker type..</param>
        /// <param name="plugCategoryIdentifier">If the item is a plug, this is the identifier we expect to find associated with it if it is in this category..</param>
        /// <param name="itemTypeRegexNot">If the item type matches this janky regex, it does *not* belong to this category..</param>
        /// <param name="originBucketIdentifier">If the item belongs to this bucket, it does belong to this category..</param>
        /// <param name="grantDestinyItemType">If an item belongs to this category, it will also receive this item type. This is now how DestinyItemType is populated for items: it used to be an even jankier process, but that&#39;s a story that requires more alcohol..</param>
        /// <param name="grantDestinySubType">If an item belongs to this category, it will also receive this subtype enum value.  I know what you&#39;re thinking - what if it belongs to multiple categories that provide sub-types?  The last one processed wins, as is the case with all of these \&quot;grant\&quot; enums. Now you can see one reason why we moved away from these enums... but they&#39;re so convenient when they work, aren&#39;t they?.</param>
        /// <param name="grantDestinyClass">If an item belongs to this category, it will also get this class restriction enum value.  See the other \&quot;grant\&quot;-prefixed properties on this definition for my color commentary..</param>
        /// <param name="traitId">The traitId that can be found on items that belong to this category..</param>
        /// <param name="groupedCategoryHashes">If this category is a \&quot;parent\&quot; category of other categories, those children will have their hashes listed in rendering order here, and can be looked up using these hashes against DestinyItemCategoryDefinition.  In this way, you can build up a visual hierarchy of item categories. That&#39;s what we did, and you can do it too. I believe in you. Yes, you, Carl.  (I hope someone named Carl reads this someday).</param>
        /// <param name="parentCategoryHashes">All item category hashes of \&quot;parent\&quot; categories: categories that contain this as a child through the hierarchy of groupedCategoryHashes. It&#39;s a bit redundant, but having this child-centric list speeds up some calculations..</param>
        /// <param name="groupCategoryOnly">If true, this category is only used for grouping, and should not be evaluated with its own checks. Rather, the item only has this category if it has one of its child categories..</param>
        /// <param name="hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsDestinyItemCategoryDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), bool visible = default(bool), bool deprecated = default(bool), string shortTitle = default(string), string itemTypeRegex = default(string), int grantDestinyBreakerType = default(int), string plugCategoryIdentifier = default(string), string itemTypeRegexNot = default(string), string originBucketIdentifier = default(string), int grantDestinyItemType = default(int), int grantDestinySubType = default(int), int grantDestinyClass = default(int), string traitId = default(string), List<int> groupedCategoryHashes = default(List<int>), List<int> parentCategoryHashes = default(List<int>), bool groupCategoryOnly = default(bool), int hash = default(int), int index = default(int), bool redacted = default(bool))
        {
            this.DisplayProperties = displayProperties;
            this.Visible = visible;
            this.Deprecated = deprecated;
            this.ShortTitle = shortTitle;
            this.ItemTypeRegex = itemTypeRegex;
            this.GrantDestinyBreakerType = grantDestinyBreakerType;
            this.PlugCategoryIdentifier = plugCategoryIdentifier;
            this.ItemTypeRegexNot = itemTypeRegexNot;
            this.OriginBucketIdentifier = originBucketIdentifier;
            this.GrantDestinyItemType = grantDestinyItemType;
            this.GrantDestinySubType = grantDestinySubType;
            this.GrantDestinyClass = grantDestinyClass;
            this.TraitId = traitId;
            this.GroupedCategoryHashes = groupedCategoryHashes;
            this.ParentCategoryHashes = parentCategoryHashes;
            this.GroupCategoryOnly = groupCategoryOnly;
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
        /// If True, this category should be visible in UI. Sometimes we make categories that we don&#39;t think are interesting externally. It&#39;s up to you if you want to skip on showing them.
        /// </summary>
        /// <value>If True, this category should be visible in UI. Sometimes we make categories that we don&#39;t think are interesting externally. It&#39;s up to you if you want to skip on showing them.</value>
        [DataMember(Name = "visible", EmitDefaultValue = true)]
        public bool Visible { get; set; }

        /// <summary>
        /// If True, this category has been deprecated: it may have no items left, or there may be only legacy items that remain in it which are no longer relevant to the game.
        /// </summary>
        /// <value>If True, this category has been deprecated: it may have no items left, or there may be only legacy items that remain in it which are no longer relevant to the game.</value>
        [DataMember(Name = "deprecated", EmitDefaultValue = true)]
        public bool Deprecated { get; set; }

        /// <summary>
        /// A shortened version of the title. The reason why we have this is because the Armory in German had titles that were too long to display in our UI, so these were localized abbreviated versions of those categories. The property still exists today, even though the Armory doesn&#39;t exist for D2... yet.
        /// </summary>
        /// <value>A shortened version of the title. The reason why we have this is because the Armory in German had titles that were too long to display in our UI, so these were localized abbreviated versions of those categories. The property still exists today, even though the Armory doesn&#39;t exist for D2... yet.</value>
        [DataMember(Name = "shortTitle", EmitDefaultValue = false)]
        public string ShortTitle { get; set; }

        /// <summary>
        /// The janky regular expression we used against the item type to try and discern whether the item belongs to this category.
        /// </summary>
        /// <value>The janky regular expression we used against the item type to try and discern whether the item belongs to this category.</value>
        [DataMember(Name = "itemTypeRegex", EmitDefaultValue = false)]
        public string ItemTypeRegex { get; set; }

        /// <summary>
        /// If the item in question has this category, it also should have this breaker type.
        /// </summary>
        /// <value>If the item in question has this category, it also should have this breaker type.</value>
        [DataMember(Name = "grantDestinyBreakerType", EmitDefaultValue = false)]
        public int GrantDestinyBreakerType { get; set; }

        /// <summary>
        /// If the item is a plug, this is the identifier we expect to find associated with it if it is in this category.
        /// </summary>
        /// <value>If the item is a plug, this is the identifier we expect to find associated with it if it is in this category.</value>
        [DataMember(Name = "plugCategoryIdentifier", EmitDefaultValue = false)]
        public string PlugCategoryIdentifier { get; set; }

        /// <summary>
        /// If the item type matches this janky regex, it does *not* belong to this category.
        /// </summary>
        /// <value>If the item type matches this janky regex, it does *not* belong to this category.</value>
        [DataMember(Name = "itemTypeRegexNot", EmitDefaultValue = false)]
        public string ItemTypeRegexNot { get; set; }

        /// <summary>
        /// If the item belongs to this bucket, it does belong to this category.
        /// </summary>
        /// <value>If the item belongs to this bucket, it does belong to this category.</value>
        [DataMember(Name = "originBucketIdentifier", EmitDefaultValue = false)]
        public string OriginBucketIdentifier { get; set; }

        /// <summary>
        /// If an item belongs to this category, it will also receive this item type. This is now how DestinyItemType is populated for items: it used to be an even jankier process, but that&#39;s a story that requires more alcohol.
        /// </summary>
        /// <value>If an item belongs to this category, it will also receive this item type. This is now how DestinyItemType is populated for items: it used to be an even jankier process, but that&#39;s a story that requires more alcohol.</value>
        [DataMember(Name = "grantDestinyItemType", EmitDefaultValue = false)]
        public int GrantDestinyItemType { get; set; }

        /// <summary>
        /// If an item belongs to this category, it will also receive this subtype enum value.  I know what you&#39;re thinking - what if it belongs to multiple categories that provide sub-types?  The last one processed wins, as is the case with all of these \&quot;grant\&quot; enums. Now you can see one reason why we moved away from these enums... but they&#39;re so convenient when they work, aren&#39;t they?
        /// </summary>
        /// <value>If an item belongs to this category, it will also receive this subtype enum value.  I know what you&#39;re thinking - what if it belongs to multiple categories that provide sub-types?  The last one processed wins, as is the case with all of these \&quot;grant\&quot; enums. Now you can see one reason why we moved away from these enums... but they&#39;re so convenient when they work, aren&#39;t they?</value>
        [DataMember(Name = "grantDestinySubType", EmitDefaultValue = false)]
        public int GrantDestinySubType { get; set; }

        /// <summary>
        /// If an item belongs to this category, it will also get this class restriction enum value.  See the other \&quot;grant\&quot;-prefixed properties on this definition for my color commentary.
        /// </summary>
        /// <value>If an item belongs to this category, it will also get this class restriction enum value.  See the other \&quot;grant\&quot;-prefixed properties on this definition for my color commentary.</value>
        [DataMember(Name = "grantDestinyClass", EmitDefaultValue = false)]
        public int GrantDestinyClass { get; set; }

        /// <summary>
        /// The traitId that can be found on items that belong to this category.
        /// </summary>
        /// <value>The traitId that can be found on items that belong to this category.</value>
        [DataMember(Name = "traitId", EmitDefaultValue = false)]
        public string TraitId { get; set; }

        /// <summary>
        /// If this category is a \&quot;parent\&quot; category of other categories, those children will have their hashes listed in rendering order here, and can be looked up using these hashes against DestinyItemCategoryDefinition.  In this way, you can build up a visual hierarchy of item categories. That&#39;s what we did, and you can do it too. I believe in you. Yes, you, Carl.  (I hope someone named Carl reads this someday)
        /// </summary>
        /// <value>If this category is a \&quot;parent\&quot; category of other categories, those children will have their hashes listed in rendering order here, and can be looked up using these hashes against DestinyItemCategoryDefinition.  In this way, you can build up a visual hierarchy of item categories. That&#39;s what we did, and you can do it too. I believe in you. Yes, you, Carl.  (I hope someone named Carl reads this someday)</value>
        [DataMember(Name = "groupedCategoryHashes", EmitDefaultValue = false)]
        public List<int> GroupedCategoryHashes { get; set; }

        /// <summary>
        /// All item category hashes of \&quot;parent\&quot; categories: categories that contain this as a child through the hierarchy of groupedCategoryHashes. It&#39;s a bit redundant, but having this child-centric list speeds up some calculations.
        /// </summary>
        /// <value>All item category hashes of \&quot;parent\&quot; categories: categories that contain this as a child through the hierarchy of groupedCategoryHashes. It&#39;s a bit redundant, but having this child-centric list speeds up some calculations.</value>
        [DataMember(Name = "parentCategoryHashes", EmitDefaultValue = false)]
        public List<int> ParentCategoryHashes { get; set; }

        /// <summary>
        /// If true, this category is only used for grouping, and should not be evaluated with its own checks. Rather, the item only has this category if it has one of its child categories.
        /// </summary>
        /// <value>If true, this category is only used for grouping, and should not be evaluated with its own checks. Rather, the item only has this category if it has one of its child categories.</value>
        [DataMember(Name = "groupCategoryOnly", EmitDefaultValue = true)]
        public bool GroupCategoryOnly { get; set; }

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
            sb.Append("class DestinyDefinitionsDestinyItemCategoryDefinition {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  Deprecated: ").Append(Deprecated).Append("\n");
            sb.Append("  ShortTitle: ").Append(ShortTitle).Append("\n");
            sb.Append("  ItemTypeRegex: ").Append(ItemTypeRegex).Append("\n");
            sb.Append("  GrantDestinyBreakerType: ").Append(GrantDestinyBreakerType).Append("\n");
            sb.Append("  PlugCategoryIdentifier: ").Append(PlugCategoryIdentifier).Append("\n");
            sb.Append("  ItemTypeRegexNot: ").Append(ItemTypeRegexNot).Append("\n");
            sb.Append("  OriginBucketIdentifier: ").Append(OriginBucketIdentifier).Append("\n");
            sb.Append("  GrantDestinyItemType: ").Append(GrantDestinyItemType).Append("\n");
            sb.Append("  GrantDestinySubType: ").Append(GrantDestinySubType).Append("\n");
            sb.Append("  GrantDestinyClass: ").Append(GrantDestinyClass).Append("\n");
            sb.Append("  TraitId: ").Append(TraitId).Append("\n");
            sb.Append("  GroupedCategoryHashes: ").Append(GroupedCategoryHashes).Append("\n");
            sb.Append("  ParentCategoryHashes: ").Append(ParentCategoryHashes).Append("\n");
            sb.Append("  GroupCategoryOnly: ").Append(GroupCategoryOnly).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyItemCategoryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemCategoryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemCategoryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemCategoryDefinition input)
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
                    this.Visible == input.Visible ||
                    this.Visible.Equals(input.Visible)
                ) && 
                (
                    this.Deprecated == input.Deprecated ||
                    this.Deprecated.Equals(input.Deprecated)
                ) && 
                (
                    this.ShortTitle == input.ShortTitle ||
                    (this.ShortTitle != null &&
                    this.ShortTitle.Equals(input.ShortTitle))
                ) && 
                (
                    this.ItemTypeRegex == input.ItemTypeRegex ||
                    (this.ItemTypeRegex != null &&
                    this.ItemTypeRegex.Equals(input.ItemTypeRegex))
                ) && 
                (
                    this.GrantDestinyBreakerType == input.GrantDestinyBreakerType ||
                    this.GrantDestinyBreakerType.Equals(input.GrantDestinyBreakerType)
                ) && 
                (
                    this.PlugCategoryIdentifier == input.PlugCategoryIdentifier ||
                    (this.PlugCategoryIdentifier != null &&
                    this.PlugCategoryIdentifier.Equals(input.PlugCategoryIdentifier))
                ) && 
                (
                    this.ItemTypeRegexNot == input.ItemTypeRegexNot ||
                    (this.ItemTypeRegexNot != null &&
                    this.ItemTypeRegexNot.Equals(input.ItemTypeRegexNot))
                ) && 
                (
                    this.OriginBucketIdentifier == input.OriginBucketIdentifier ||
                    (this.OriginBucketIdentifier != null &&
                    this.OriginBucketIdentifier.Equals(input.OriginBucketIdentifier))
                ) && 
                (
                    this.GrantDestinyItemType == input.GrantDestinyItemType ||
                    this.GrantDestinyItemType.Equals(input.GrantDestinyItemType)
                ) && 
                (
                    this.GrantDestinySubType == input.GrantDestinySubType ||
                    this.GrantDestinySubType.Equals(input.GrantDestinySubType)
                ) && 
                (
                    this.GrantDestinyClass == input.GrantDestinyClass ||
                    this.GrantDestinyClass.Equals(input.GrantDestinyClass)
                ) && 
                (
                    this.TraitId == input.TraitId ||
                    (this.TraitId != null &&
                    this.TraitId.Equals(input.TraitId))
                ) && 
                (
                    this.GroupedCategoryHashes == input.GroupedCategoryHashes ||
                    this.GroupedCategoryHashes != null &&
                    input.GroupedCategoryHashes != null &&
                    this.GroupedCategoryHashes.SequenceEqual(input.GroupedCategoryHashes)
                ) && 
                (
                    this.ParentCategoryHashes == input.ParentCategoryHashes ||
                    this.ParentCategoryHashes != null &&
                    input.ParentCategoryHashes != null &&
                    this.ParentCategoryHashes.SequenceEqual(input.ParentCategoryHashes)
                ) && 
                (
                    this.GroupCategoryOnly == input.GroupCategoryOnly ||
                    this.GroupCategoryOnly.Equals(input.GroupCategoryOnly)
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
                hashCode = (hashCode * 59) + this.Visible.GetHashCode();
                hashCode = (hashCode * 59) + this.Deprecated.GetHashCode();
                if (this.ShortTitle != null)
                {
                    hashCode = (hashCode * 59) + this.ShortTitle.GetHashCode();
                }
                if (this.ItemTypeRegex != null)
                {
                    hashCode = (hashCode * 59) + this.ItemTypeRegex.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GrantDestinyBreakerType.GetHashCode();
                if (this.PlugCategoryIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.PlugCategoryIdentifier.GetHashCode();
                }
                if (this.ItemTypeRegexNot != null)
                {
                    hashCode = (hashCode * 59) + this.ItemTypeRegexNot.GetHashCode();
                }
                if (this.OriginBucketIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.OriginBucketIdentifier.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GrantDestinyItemType.GetHashCode();
                hashCode = (hashCode * 59) + this.GrantDestinySubType.GetHashCode();
                hashCode = (hashCode * 59) + this.GrantDestinyClass.GetHashCode();
                if (this.TraitId != null)
                {
                    hashCode = (hashCode * 59) + this.TraitId.GetHashCode();
                }
                if (this.GroupedCategoryHashes != null)
                {
                    hashCode = (hashCode * 59) + this.GroupedCategoryHashes.GetHashCode();
                }
                if (this.ParentCategoryHashes != null)
                {
                    hashCode = (hashCode * 59) + this.ParentCategoryHashes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GroupCategoryOnly.GetHashCode();
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