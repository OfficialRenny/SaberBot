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
    /// DestinyComponentsKiosksDestinyKioskItem
    /// </summary>
    [DataContract(Name = "Destiny.Components.Kiosks.DestinyKioskItem")]
    public partial class DestinyComponentsKiosksDestinyKioskItem : IEquatable<DestinyComponentsKiosksDestinyKioskItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsKiosksDestinyKioskItem" /> class.
        /// </summary>
        /// <param name="index">The index of the item in the related DestinyVendorDefintion&#39;s itemList property, representing the sale..</param>
        /// <param name="canAcquire">If true, the user can not only see the item, but they can acquire it. It is possible that a user can see a kiosk item and not be able to acquire it..</param>
        /// <param name="failureIndexes">Indexes into failureStrings for the Vendor, indicating the reasons why it failed if any..</param>
        /// <param name="flavorObjective">flavorObjective.</param>
        public DestinyComponentsKiosksDestinyKioskItem(int index = default(int), bool canAcquire = default(bool), List<int> failureIndexes = default(List<int>), DestinyQuestsDestinyObjectiveProgress flavorObjective = default(DestinyQuestsDestinyObjectiveProgress))
        {
            this.Index = index;
            this.CanAcquire = canAcquire;
            this.FailureIndexes = failureIndexes;
            this.FlavorObjective = flavorObjective;
        }

        /// <summary>
        /// The index of the item in the related DestinyVendorDefintion&#39;s itemList property, representing the sale.
        /// </summary>
        /// <value>The index of the item in the related DestinyVendorDefintion&#39;s itemList property, representing the sale.</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// If true, the user can not only see the item, but they can acquire it. It is possible that a user can see a kiosk item and not be able to acquire it.
        /// </summary>
        /// <value>If true, the user can not only see the item, but they can acquire it. It is possible that a user can see a kiosk item and not be able to acquire it.</value>
        [DataMember(Name = "canAcquire", EmitDefaultValue = true)]
        public bool CanAcquire { get; set; }

        /// <summary>
        /// Indexes into failureStrings for the Vendor, indicating the reasons why it failed if any.
        /// </summary>
        /// <value>Indexes into failureStrings for the Vendor, indicating the reasons why it failed if any.</value>
        [DataMember(Name = "failureIndexes", EmitDefaultValue = false)]
        public List<int> FailureIndexes { get; set; }

        /// <summary>
        /// Gets or Sets FlavorObjective
        /// </summary>
        [DataMember(Name = "flavorObjective", EmitDefaultValue = false)]
        public DestinyQuestsDestinyObjectiveProgress FlavorObjective { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsKiosksDestinyKioskItem {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  CanAcquire: ").Append(CanAcquire).Append("\n");
            sb.Append("  FailureIndexes: ").Append(FailureIndexes).Append("\n");
            sb.Append("  FlavorObjective: ").Append(FlavorObjective).Append("\n");
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
            return this.Equals(input as DestinyComponentsKiosksDestinyKioskItem);
        }

        /// <summary>
        /// Returns true if DestinyComponentsKiosksDestinyKioskItem instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsKiosksDestinyKioskItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsKiosksDestinyKioskItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.CanAcquire == input.CanAcquire ||
                    this.CanAcquire.Equals(input.CanAcquire)
                ) && 
                (
                    this.FailureIndexes == input.FailureIndexes ||
                    this.FailureIndexes != null &&
                    input.FailureIndexes != null &&
                    this.FailureIndexes.SequenceEqual(input.FailureIndexes)
                ) && 
                (
                    this.FlavorObjective == input.FlavorObjective ||
                    (this.FlavorObjective != null &&
                    this.FlavorObjective.Equals(input.FlavorObjective))
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
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this.CanAcquire.GetHashCode();
                if (this.FailureIndexes != null)
                {
                    hashCode = (hashCode * 59) + this.FailureIndexes.GetHashCode();
                }
                if (this.FlavorObjective != null)
                {
                    hashCode = (hashCode * 59) + this.FlavorObjective.GetHashCode();
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