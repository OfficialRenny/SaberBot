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
    /// This component contains essential/summary information about the vendor.
    /// </summary>
    [DataContract(Name = "Destiny.Entities.Vendors.DestinyVendorComponent")]
    public partial class DestinyEntitiesVendorsDestinyVendorComponent : IEquatable<DestinyEntitiesVendorsDestinyVendorComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesVendorsDestinyVendorComponent" /> class.
        /// </summary>
        /// <param name="canPurchase">If True, you can purchase from the Vendor..</param>
        /// <param name="progression">progression.</param>
        /// <param name="vendorLocationIndex">An index into the vendor definition&#39;s \&quot;locations\&quot; property array, indicating which location they are at currently. If -1, then the vendor has no known location (and you may choose not to show them in your UI as a result. I mean, it&#39;s your bag honey).</param>
        /// <param name="seasonalRank">If this vendor has a seasonal rank, this will be the calculated value of that rank. How nice is that? I mean, that&#39;s pretty sweeet. It&#39;s a whole 32 bit integer..</param>
        /// <param name="vendorHash">The unique identifier for the vendor. Use it to look up their DestinyVendorDefinition..</param>
        /// <param name="nextRefreshDate">The date when this vendor&#39;s inventory will next rotate/refresh.  Note that this is distinct from the date ranges that the vendor is visible/available in-game: this field indicates the specific time when the vendor&#39;s available items refresh and rotate, regardless of whether the vendor is actually available at that time. Unfortunately, these two values may be (and are, for the case of important vendors like Xur) different.  Issue https://github.com/Bungie-net/api/issues/353 is tracking a fix to start providing visibility date ranges where possible in addition to this refresh date, so that all important dates for vendors are available for use..</param>
        /// <param name="enabled">If True, the Vendor is currently accessible.   If False, they may not actually be visible in the world at the moment..</param>
        public DestinyEntitiesVendorsDestinyVendorComponent(bool canPurchase = default(bool), DestinyDestinyProgression progression = default(DestinyDestinyProgression), int vendorLocationIndex = default(int), int? seasonalRank = default(int?), int vendorHash = default(int), DateTime nextRefreshDate = default(DateTime), bool enabled = default(bool))
        {
            this.CanPurchase = canPurchase;
            this.Progression = progression;
            this.VendorLocationIndex = vendorLocationIndex;
            this.SeasonalRank = seasonalRank;
            this.VendorHash = vendorHash;
            this.NextRefreshDate = nextRefreshDate;
            this.Enabled = enabled;
        }

        /// <summary>
        /// If True, you can purchase from the Vendor.
        /// </summary>
        /// <value>If True, you can purchase from the Vendor.</value>
        [DataMember(Name = "canPurchase", EmitDefaultValue = true)]
        public bool CanPurchase { get; set; }

        /// <summary>
        /// Gets or Sets Progression
        /// </summary>
        [DataMember(Name = "progression", EmitDefaultValue = false)]
        public DestinyDestinyProgression Progression { get; set; }

        /// <summary>
        /// An index into the vendor definition&#39;s \&quot;locations\&quot; property array, indicating which location they are at currently. If -1, then the vendor has no known location (and you may choose not to show them in your UI as a result. I mean, it&#39;s your bag honey)
        /// </summary>
        /// <value>An index into the vendor definition&#39;s \&quot;locations\&quot; property array, indicating which location they are at currently. If -1, then the vendor has no known location (and you may choose not to show them in your UI as a result. I mean, it&#39;s your bag honey)</value>
        [DataMember(Name = "vendorLocationIndex", EmitDefaultValue = false)]
        public int VendorLocationIndex { get; set; }

        /// <summary>
        /// If this vendor has a seasonal rank, this will be the calculated value of that rank. How nice is that? I mean, that&#39;s pretty sweeet. It&#39;s a whole 32 bit integer.
        /// </summary>
        /// <value>If this vendor has a seasonal rank, this will be the calculated value of that rank. How nice is that? I mean, that&#39;s pretty sweeet. It&#39;s a whole 32 bit integer.</value>
        [DataMember(Name = "seasonalRank", EmitDefaultValue = true)]
        public int? SeasonalRank { get; set; }

        /// <summary>
        /// The unique identifier for the vendor. Use it to look up their DestinyVendorDefinition.
        /// </summary>
        /// <value>The unique identifier for the vendor. Use it to look up their DestinyVendorDefinition.</value>
        [DataMember(Name = "vendorHash", EmitDefaultValue = false)]
        public int VendorHash { get; set; }

        /// <summary>
        /// The date when this vendor&#39;s inventory will next rotate/refresh.  Note that this is distinct from the date ranges that the vendor is visible/available in-game: this field indicates the specific time when the vendor&#39;s available items refresh and rotate, regardless of whether the vendor is actually available at that time. Unfortunately, these two values may be (and are, for the case of important vendors like Xur) different.  Issue https://github.com/Bungie-net/api/issues/353 is tracking a fix to start providing visibility date ranges where possible in addition to this refresh date, so that all important dates for vendors are available for use.
        /// </summary>
        /// <value>The date when this vendor&#39;s inventory will next rotate/refresh.  Note that this is distinct from the date ranges that the vendor is visible/available in-game: this field indicates the specific time when the vendor&#39;s available items refresh and rotate, regardless of whether the vendor is actually available at that time. Unfortunately, these two values may be (and are, for the case of important vendors like Xur) different.  Issue https://github.com/Bungie-net/api/issues/353 is tracking a fix to start providing visibility date ranges where possible in addition to this refresh date, so that all important dates for vendors are available for use.</value>
        [DataMember(Name = "nextRefreshDate", EmitDefaultValue = false)]
        public DateTime NextRefreshDate { get; set; }

        /// <summary>
        /// If True, the Vendor is currently accessible.   If False, they may not actually be visible in the world at the moment.
        /// </summary>
        /// <value>If True, the Vendor is currently accessible.   If False, they may not actually be visible in the world at the moment.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyEntitiesVendorsDestinyVendorComponent {\n");
            sb.Append("  CanPurchase: ").Append(CanPurchase).Append("\n");
            sb.Append("  Progression: ").Append(Progression).Append("\n");
            sb.Append("  VendorLocationIndex: ").Append(VendorLocationIndex).Append("\n");
            sb.Append("  SeasonalRank: ").Append(SeasonalRank).Append("\n");
            sb.Append("  VendorHash: ").Append(VendorHash).Append("\n");
            sb.Append("  NextRefreshDate: ").Append(NextRefreshDate).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as DestinyEntitiesVendorsDestinyVendorComponent);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesVendorsDestinyVendorComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesVendorsDestinyVendorComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesVendorsDestinyVendorComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CanPurchase == input.CanPurchase ||
                    this.CanPurchase.Equals(input.CanPurchase)
                ) && 
                (
                    this.Progression == input.Progression ||
                    (this.Progression != null &&
                    this.Progression.Equals(input.Progression))
                ) && 
                (
                    this.VendorLocationIndex == input.VendorLocationIndex ||
                    this.VendorLocationIndex.Equals(input.VendorLocationIndex)
                ) && 
                (
                    this.SeasonalRank == input.SeasonalRank ||
                    (this.SeasonalRank != null &&
                    this.SeasonalRank.Equals(input.SeasonalRank))
                ) && 
                (
                    this.VendorHash == input.VendorHash ||
                    this.VendorHash.Equals(input.VendorHash)
                ) && 
                (
                    this.NextRefreshDate == input.NextRefreshDate ||
                    (this.NextRefreshDate != null &&
                    this.NextRefreshDate.Equals(input.NextRefreshDate))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
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
                hashCode = (hashCode * 59) + this.CanPurchase.GetHashCode();
                if (this.Progression != null)
                {
                    hashCode = (hashCode * 59) + this.Progression.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VendorLocationIndex.GetHashCode();
                if (this.SeasonalRank != null)
                {
                    hashCode = (hashCode * 59) + this.SeasonalRank.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VendorHash.GetHashCode();
                if (this.NextRefreshDate != null)
                {
                    hashCode = (hashCode * 59) + this.NextRefreshDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
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