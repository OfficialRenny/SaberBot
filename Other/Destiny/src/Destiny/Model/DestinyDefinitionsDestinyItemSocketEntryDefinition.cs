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
    /// The definition information for a specific socket on an item. This will determine how the socket behaves in-game.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyItemSocketEntryDefinition")]
    public partial class DestinyDefinitionsDestinyItemSocketEntryDefinition : IEquatable<DestinyDefinitionsDestinyItemSocketEntryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemSocketEntryDefinition" /> class.
        /// </summary>
        /// <param name="socketTypeHash">All sockets have a type, and this is the hash identifier for this particular type. Use it to look up the DestinySocketTypeDefinition: read there for more information on how socket types affect the behavior of the socket..</param>
        /// <param name="singleInitialItemHash">If a valid hash, this is the hash identifier for the DestinyInventoryItemDefinition representing the Plug that will be initially inserted into the item on item creation. Otherwise, this Socket will either start without a plug inserted, or will have one randomly inserted..</param>
        /// <param name="reusablePlugItems">This is a list of pre-determined plugs that can *always* be plugged into this socket, without the character having the plug in their inventory.  If this list is populated, you will not be allowed to plug an arbitrary item in the socket: you will only be able to choose from one of these reusable plugs..</param>
        /// <param name="preventInitializationOnVendorPurchase">If this is true, then the socket will not be initialized with a plug if the item is purchased from a Vendor.  Remember that Vendors are much more than conceptual vendors: they include \&quot;Collection Kiosks\&quot; and other entities. See DestinyVendorDefinition for more information..</param>
        /// <param name="hidePerksInItemTooltip">If this is true, the perks provided by this socket shouldn&#39;t be shown in the item&#39;s tooltip. This might be useful if it&#39;s providing a hidden bonus, or if the bonus is less important than other benefits on the item..</param>
        /// <param name="plugSources">Indicates where you should go to get plugs for this socket. This will affect how you populate your UI, as well as what plugs are valid for this socket. It&#39;s an alternative to having to check for the existence of certain properties (reusablePlugItems for example) to infer where plugs should come from..</param>
        /// <param name="reusablePlugSetHash">If this socket&#39;s plugs come from a reusable DestinyPlugSetDefinition, this is the identifier for that set. We added this concept to reduce some major duplication that&#39;s going to come from sockets as replacements for what was once implemented as large sets of items and kiosks (like Emotes).   As of Shadowkeep, these will come up much more frequently and be driven by game content rather than custom curation..</param>
        /// <param name="randomizedPlugSetHash">This field replaces \&quot;randomizedPlugItems\&quot; as of Shadowkeep launch. If a socket has randomized plugs, this is a pointer to the set of plugs that could be used, as defined in DestinyPlugSetDefinition.   If null, the item has no randomized plugs..</param>
        /// <param name="defaultVisible">If true, then this socket is visible in the item&#39;s \&quot;default\&quot; state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you&#39;re looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see..</param>
        public DestinyDefinitionsDestinyItemSocketEntryDefinition(int socketTypeHash = default(int), int singleInitialItemHash = default(int), List<DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition> reusablePlugItems = default(List<DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition>), bool preventInitializationOnVendorPurchase = default(bool), bool hidePerksInItemTooltip = default(bool), int plugSources = default(int), int? reusablePlugSetHash = default(int?), int? randomizedPlugSetHash = default(int?), bool defaultVisible = default(bool))
        {
            this.SocketTypeHash = socketTypeHash;
            this.SingleInitialItemHash = singleInitialItemHash;
            this.ReusablePlugItems = reusablePlugItems;
            this.PreventInitializationOnVendorPurchase = preventInitializationOnVendorPurchase;
            this.HidePerksInItemTooltip = hidePerksInItemTooltip;
            this.PlugSources = plugSources;
            this.ReusablePlugSetHash = reusablePlugSetHash;
            this.RandomizedPlugSetHash = randomizedPlugSetHash;
            this.DefaultVisible = defaultVisible;
        }

        /// <summary>
        /// All sockets have a type, and this is the hash identifier for this particular type. Use it to look up the DestinySocketTypeDefinition: read there for more information on how socket types affect the behavior of the socket.
        /// </summary>
        /// <value>All sockets have a type, and this is the hash identifier for this particular type. Use it to look up the DestinySocketTypeDefinition: read there for more information on how socket types affect the behavior of the socket.</value>
        [DataMember(Name = "socketTypeHash", EmitDefaultValue = false)]
        public int SocketTypeHash { get; set; }

        /// <summary>
        /// If a valid hash, this is the hash identifier for the DestinyInventoryItemDefinition representing the Plug that will be initially inserted into the item on item creation. Otherwise, this Socket will either start without a plug inserted, or will have one randomly inserted.
        /// </summary>
        /// <value>If a valid hash, this is the hash identifier for the DestinyInventoryItemDefinition representing the Plug that will be initially inserted into the item on item creation. Otherwise, this Socket will either start without a plug inserted, or will have one randomly inserted.</value>
        [DataMember(Name = "singleInitialItemHash", EmitDefaultValue = false)]
        public int SingleInitialItemHash { get; set; }

        /// <summary>
        /// This is a list of pre-determined plugs that can *always* be plugged into this socket, without the character having the plug in their inventory.  If this list is populated, you will not be allowed to plug an arbitrary item in the socket: you will only be able to choose from one of these reusable plugs.
        /// </summary>
        /// <value>This is a list of pre-determined plugs that can *always* be plugged into this socket, without the character having the plug in their inventory.  If this list is populated, you will not be allowed to plug an arbitrary item in the socket: you will only be able to choose from one of these reusable plugs.</value>
        [DataMember(Name = "reusablePlugItems", EmitDefaultValue = false)]
        public List<DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition> ReusablePlugItems { get; set; }

        /// <summary>
        /// If this is true, then the socket will not be initialized with a plug if the item is purchased from a Vendor.  Remember that Vendors are much more than conceptual vendors: they include \&quot;Collection Kiosks\&quot; and other entities. See DestinyVendorDefinition for more information.
        /// </summary>
        /// <value>If this is true, then the socket will not be initialized with a plug if the item is purchased from a Vendor.  Remember that Vendors are much more than conceptual vendors: they include \&quot;Collection Kiosks\&quot; and other entities. See DestinyVendorDefinition for more information.</value>
        [DataMember(Name = "preventInitializationOnVendorPurchase", EmitDefaultValue = true)]
        public bool PreventInitializationOnVendorPurchase { get; set; }

        /// <summary>
        /// If this is true, the perks provided by this socket shouldn&#39;t be shown in the item&#39;s tooltip. This might be useful if it&#39;s providing a hidden bonus, or if the bonus is less important than other benefits on the item.
        /// </summary>
        /// <value>If this is true, the perks provided by this socket shouldn&#39;t be shown in the item&#39;s tooltip. This might be useful if it&#39;s providing a hidden bonus, or if the bonus is less important than other benefits on the item.</value>
        [DataMember(Name = "hidePerksInItemTooltip", EmitDefaultValue = true)]
        public bool HidePerksInItemTooltip { get; set; }

        /// <summary>
        /// Indicates where you should go to get plugs for this socket. This will affect how you populate your UI, as well as what plugs are valid for this socket. It&#39;s an alternative to having to check for the existence of certain properties (reusablePlugItems for example) to infer where plugs should come from.
        /// </summary>
        /// <value>Indicates where you should go to get plugs for this socket. This will affect how you populate your UI, as well as what plugs are valid for this socket. It&#39;s an alternative to having to check for the existence of certain properties (reusablePlugItems for example) to infer where plugs should come from.</value>
        [DataMember(Name = "plugSources", EmitDefaultValue = false)]
        public int PlugSources { get; set; }

        /// <summary>
        /// If this socket&#39;s plugs come from a reusable DestinyPlugSetDefinition, this is the identifier for that set. We added this concept to reduce some major duplication that&#39;s going to come from sockets as replacements for what was once implemented as large sets of items and kiosks (like Emotes).   As of Shadowkeep, these will come up much more frequently and be driven by game content rather than custom curation.
        /// </summary>
        /// <value>If this socket&#39;s plugs come from a reusable DestinyPlugSetDefinition, this is the identifier for that set. We added this concept to reduce some major duplication that&#39;s going to come from sockets as replacements for what was once implemented as large sets of items and kiosks (like Emotes).   As of Shadowkeep, these will come up much more frequently and be driven by game content rather than custom curation.</value>
        [DataMember(Name = "reusablePlugSetHash", EmitDefaultValue = true)]
        public int? ReusablePlugSetHash { get; set; }

        /// <summary>
        /// This field replaces \&quot;randomizedPlugItems\&quot; as of Shadowkeep launch. If a socket has randomized plugs, this is a pointer to the set of plugs that could be used, as defined in DestinyPlugSetDefinition.   If null, the item has no randomized plugs.
        /// </summary>
        /// <value>This field replaces \&quot;randomizedPlugItems\&quot; as of Shadowkeep launch. If a socket has randomized plugs, this is a pointer to the set of plugs that could be used, as defined in DestinyPlugSetDefinition.   If null, the item has no randomized plugs.</value>
        [DataMember(Name = "randomizedPlugSetHash", EmitDefaultValue = true)]
        public int? RandomizedPlugSetHash { get; set; }

        /// <summary>
        /// If true, then this socket is visible in the item&#39;s \&quot;default\&quot; state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you&#39;re looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.
        /// </summary>
        /// <value>If true, then this socket is visible in the item&#39;s \&quot;default\&quot; state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you&#39;re looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.</value>
        [DataMember(Name = "defaultVisible", EmitDefaultValue = true)]
        public bool DefaultVisible { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyItemSocketEntryDefinition {\n");
            sb.Append("  SocketTypeHash: ").Append(SocketTypeHash).Append("\n");
            sb.Append("  SingleInitialItemHash: ").Append(SingleInitialItemHash).Append("\n");
            sb.Append("  ReusablePlugItems: ").Append(ReusablePlugItems).Append("\n");
            sb.Append("  PreventInitializationOnVendorPurchase: ").Append(PreventInitializationOnVendorPurchase).Append("\n");
            sb.Append("  HidePerksInItemTooltip: ").Append(HidePerksInItemTooltip).Append("\n");
            sb.Append("  PlugSources: ").Append(PlugSources).Append("\n");
            sb.Append("  ReusablePlugSetHash: ").Append(ReusablePlugSetHash).Append("\n");
            sb.Append("  RandomizedPlugSetHash: ").Append(RandomizedPlugSetHash).Append("\n");
            sb.Append("  DefaultVisible: ").Append(DefaultVisible).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyItemSocketEntryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemSocketEntryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemSocketEntryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemSocketEntryDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SocketTypeHash == input.SocketTypeHash ||
                    this.SocketTypeHash.Equals(input.SocketTypeHash)
                ) && 
                (
                    this.SingleInitialItemHash == input.SingleInitialItemHash ||
                    this.SingleInitialItemHash.Equals(input.SingleInitialItemHash)
                ) && 
                (
                    this.ReusablePlugItems == input.ReusablePlugItems ||
                    this.ReusablePlugItems != null &&
                    input.ReusablePlugItems != null &&
                    this.ReusablePlugItems.SequenceEqual(input.ReusablePlugItems)
                ) && 
                (
                    this.PreventInitializationOnVendorPurchase == input.PreventInitializationOnVendorPurchase ||
                    this.PreventInitializationOnVendorPurchase.Equals(input.PreventInitializationOnVendorPurchase)
                ) && 
                (
                    this.HidePerksInItemTooltip == input.HidePerksInItemTooltip ||
                    this.HidePerksInItemTooltip.Equals(input.HidePerksInItemTooltip)
                ) && 
                (
                    this.PlugSources == input.PlugSources ||
                    this.PlugSources.Equals(input.PlugSources)
                ) && 
                (
                    this.ReusablePlugSetHash == input.ReusablePlugSetHash ||
                    (this.ReusablePlugSetHash != null &&
                    this.ReusablePlugSetHash.Equals(input.ReusablePlugSetHash))
                ) && 
                (
                    this.RandomizedPlugSetHash == input.RandomizedPlugSetHash ||
                    (this.RandomizedPlugSetHash != null &&
                    this.RandomizedPlugSetHash.Equals(input.RandomizedPlugSetHash))
                ) && 
                (
                    this.DefaultVisible == input.DefaultVisible ||
                    this.DefaultVisible.Equals(input.DefaultVisible)
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
                hashCode = (hashCode * 59) + this.SocketTypeHash.GetHashCode();
                hashCode = (hashCode * 59) + this.SingleInitialItemHash.GetHashCode();
                if (this.ReusablePlugItems != null)
                {
                    hashCode = (hashCode * 59) + this.ReusablePlugItems.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PreventInitializationOnVendorPurchase.GetHashCode();
                hashCode = (hashCode * 59) + this.HidePerksInItemTooltip.GetHashCode();
                hashCode = (hashCode * 59) + this.PlugSources.GetHashCode();
                if (this.ReusablePlugSetHash != null)
                {
                    hashCode = (hashCode * 59) + this.ReusablePlugSetHash.GetHashCode();
                }
                if (this.RandomizedPlugSetHash != null)
                {
                    hashCode = (hashCode * 59) + this.RandomizedPlugSetHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DefaultVisible.GetHashCode();
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
