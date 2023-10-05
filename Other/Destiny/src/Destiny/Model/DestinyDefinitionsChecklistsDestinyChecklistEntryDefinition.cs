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
    /// The properties of an individual checklist item. Note that almost everything is optional: it is *highly* variable what kind of data we&#39;ll actually be able to return: at times we may have no other relationships to entities at all.  Whatever UI you build, do it with the knowledge that any given entry might not actually be able to be associated with some other Destiny entity.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Checklists.DestinyChecklistEntryDefinition")]
    public partial class DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition : IEquatable<DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition" /> class.
        /// </summary>
        /// <param name="hash">The identifier for this Checklist entry. Guaranteed unique only within this Checklist Definition, and not globally/for all checklists..</param>
        /// <param name="displayProperties">displayProperties.</param>
        /// <param name="destinationHash">destinationHash.</param>
        /// <param name="locationHash">locationHash.</param>
        /// <param name="bubbleHash">Note that a Bubble&#39;s hash doesn&#39;t uniquely identify a \&quot;top level\&quot; entity in Destiny. Only the combination of location and bubble can uniquely identify a place in the world of Destiny: so if bubbleHash is populated, locationHash must too be populated for it to have any meaning.  You can use this property if it is populated to look up the DestinyLocationDefinition&#39;s associated .locationReleases[].activityBubbleName property..</param>
        /// <param name="activityHash">activityHash.</param>
        /// <param name="itemHash">itemHash.</param>
        /// <param name="vendorHash">vendorHash.</param>
        /// <param name="vendorInteractionIndex">vendorInteractionIndex.</param>
        /// <param name="scope">The scope at which this specific entry can be computed..</param>
        public DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition(int hash = default(int), DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), int? destinationHash = default(int?), int? locationHash = default(int?), int? bubbleHash = default(int?), int? activityHash = default(int?), int? itemHash = default(int?), int? vendorHash = default(int?), int? vendorInteractionIndex = default(int?), int scope = default(int))
        {
            this.Hash = hash;
            this.DisplayProperties = displayProperties;
            this.DestinationHash = destinationHash;
            this.LocationHash = locationHash;
            this.BubbleHash = bubbleHash;
            this.ActivityHash = activityHash;
            this.ItemHash = itemHash;
            this.VendorHash = vendorHash;
            this.VendorInteractionIndex = vendorInteractionIndex;
            this.Scope = scope;
        }

        /// <summary>
        /// The identifier for this Checklist entry. Guaranteed unique only within this Checklist Definition, and not globally/for all checklists.
        /// </summary>
        /// <value>The identifier for this Checklist entry. Guaranteed unique only within this Checklist Definition, and not globally/for all checklists.</value>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public int Hash { get; set; }

        /// <summary>
        /// Gets or Sets DisplayProperties
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// Gets or Sets DestinationHash
        /// </summary>
        [DataMember(Name = "destinationHash", EmitDefaultValue = true)]
        public int? DestinationHash { get; set; }

        /// <summary>
        /// Gets or Sets LocationHash
        /// </summary>
        [DataMember(Name = "locationHash", EmitDefaultValue = true)]
        public int? LocationHash { get; set; }

        /// <summary>
        /// Note that a Bubble&#39;s hash doesn&#39;t uniquely identify a \&quot;top level\&quot; entity in Destiny. Only the combination of location and bubble can uniquely identify a place in the world of Destiny: so if bubbleHash is populated, locationHash must too be populated for it to have any meaning.  You can use this property if it is populated to look up the DestinyLocationDefinition&#39;s associated .locationReleases[].activityBubbleName property.
        /// </summary>
        /// <value>Note that a Bubble&#39;s hash doesn&#39;t uniquely identify a \&quot;top level\&quot; entity in Destiny. Only the combination of location and bubble can uniquely identify a place in the world of Destiny: so if bubbleHash is populated, locationHash must too be populated for it to have any meaning.  You can use this property if it is populated to look up the DestinyLocationDefinition&#39;s associated .locationReleases[].activityBubbleName property.</value>
        [DataMember(Name = "bubbleHash", EmitDefaultValue = true)]
        public int? BubbleHash { get; set; }

        /// <summary>
        /// Gets or Sets ActivityHash
        /// </summary>
        [DataMember(Name = "activityHash", EmitDefaultValue = true)]
        public int? ActivityHash { get; set; }

        /// <summary>
        /// Gets or Sets ItemHash
        /// </summary>
        [DataMember(Name = "itemHash", EmitDefaultValue = true)]
        public int? ItemHash { get; set; }

        /// <summary>
        /// Gets or Sets VendorHash
        /// </summary>
        [DataMember(Name = "vendorHash", EmitDefaultValue = true)]
        public int? VendorHash { get; set; }

        /// <summary>
        /// Gets or Sets VendorInteractionIndex
        /// </summary>
        [DataMember(Name = "vendorInteractionIndex", EmitDefaultValue = true)]
        public int? VendorInteractionIndex { get; set; }

        /// <summary>
        /// The scope at which this specific entry can be computed.
        /// </summary>
        /// <value>The scope at which this specific entry can be computed.</value>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public int Scope { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  DestinationHash: ").Append(DestinationHash).Append("\n");
            sb.Append("  LocationHash: ").Append(LocationHash).Append("\n");
            sb.Append("  BubbleHash: ").Append(BubbleHash).Append("\n");
            sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
            sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
            sb.Append("  VendorHash: ").Append(VendorHash).Append("\n");
            sb.Append("  VendorInteractionIndex: ").Append(VendorInteractionIndex).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsChecklistsDestinyChecklistEntryDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Hash == input.Hash ||
                    this.Hash.Equals(input.Hash)
                ) && 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.DestinationHash == input.DestinationHash ||
                    (this.DestinationHash != null &&
                    this.DestinationHash.Equals(input.DestinationHash))
                ) && 
                (
                    this.LocationHash == input.LocationHash ||
                    (this.LocationHash != null &&
                    this.LocationHash.Equals(input.LocationHash))
                ) && 
                (
                    this.BubbleHash == input.BubbleHash ||
                    (this.BubbleHash != null &&
                    this.BubbleHash.Equals(input.BubbleHash))
                ) && 
                (
                    this.ActivityHash == input.ActivityHash ||
                    (this.ActivityHash != null &&
                    this.ActivityHash.Equals(input.ActivityHash))
                ) && 
                (
                    this.ItemHash == input.ItemHash ||
                    (this.ItemHash != null &&
                    this.ItemHash.Equals(input.ItemHash))
                ) && 
                (
                    this.VendorHash == input.VendorHash ||
                    (this.VendorHash != null &&
                    this.VendorHash.Equals(input.VendorHash))
                ) && 
                (
                    this.VendorInteractionIndex == input.VendorInteractionIndex ||
                    (this.VendorInteractionIndex != null &&
                    this.VendorInteractionIndex.Equals(input.VendorInteractionIndex))
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope.Equals(input.Scope)
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
                hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                if (this.DisplayProperties != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayProperties.GetHashCode();
                }
                if (this.DestinationHash != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationHash.GetHashCode();
                }
                if (this.LocationHash != null)
                {
                    hashCode = (hashCode * 59) + this.LocationHash.GetHashCode();
                }
                if (this.BubbleHash != null)
                {
                    hashCode = (hashCode * 59) + this.BubbleHash.GetHashCode();
                }
                if (this.ActivityHash != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityHash.GetHashCode();
                }
                if (this.ItemHash != null)
                {
                    hashCode = (hashCode * 59) + this.ItemHash.GetHashCode();
                }
                if (this.VendorHash != null)
                {
                    hashCode = (hashCode * 59) + this.VendorHash.GetHashCode();
                }
                if (this.VendorInteractionIndex != null)
                {
                    hashCode = (hashCode * 59) + this.VendorInteractionIndex.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Scope.GetHashCode();
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
