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
    /// A Kiosk is a Vendor (DestinyVendorDefinition) that sells items based on whether you have already acquired that item before.  This component returns information about what Kiosk items are available to you on a *Profile* level. It is theoretically possible for Kiosks to have items gated by specific Character as well. If you ever have those, you will find them on the individual character&#39;s DestinyCharacterKiosksComponent.  Note that, because this component returns vendorItemIndexes (that is to say, indexes into the Kiosk Vendor&#39;s itemList property), these results are necessarily content version dependent. Make sure that you have the latest version of the content manifest databases before using this data.
    /// </summary>
    [DataContract(Name = "Destiny.Components.Kiosks.DestinyKiosksComponent")]
    public partial class DestinyComponentsKiosksDestinyKiosksComponent : IEquatable<DestinyComponentsKiosksDestinyKiosksComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsKiosksDestinyKiosksComponent" /> class.
        /// </summary>
        /// <param name="kioskItems">A dictionary keyed by the Kiosk Vendor&#39;s hash identifier (use it to look up the DestinyVendorDefinition for the relevant kiosk vendor), and whose value is a list of all the items that the user can \&quot;see\&quot; in the Kiosk, and any other interesting metadata..</param>
        public DestinyComponentsKiosksDestinyKiosksComponent(Dictionary<string, List<DestinyComponentsKiosksDestinyKioskItem>> kioskItems = default(Dictionary<string, List<DestinyComponentsKiosksDestinyKioskItem>>))
        {
            this.KioskItems = kioskItems;
        }

        /// <summary>
        /// A dictionary keyed by the Kiosk Vendor&#39;s hash identifier (use it to look up the DestinyVendorDefinition for the relevant kiosk vendor), and whose value is a list of all the items that the user can \&quot;see\&quot; in the Kiosk, and any other interesting metadata.
        /// </summary>
        /// <value>A dictionary keyed by the Kiosk Vendor&#39;s hash identifier (use it to look up the DestinyVendorDefinition for the relevant kiosk vendor), and whose value is a list of all the items that the user can \&quot;see\&quot; in the Kiosk, and any other interesting metadata.</value>
        [DataMember(Name = "kioskItems", EmitDefaultValue = false)]
        public Dictionary<string, List<DestinyComponentsKiosksDestinyKioskItem>> KioskItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsKiosksDestinyKiosksComponent {\n");
            sb.Append("  KioskItems: ").Append(KioskItems).Append("\n");
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
            return this.Equals(input as DestinyComponentsKiosksDestinyKiosksComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsKiosksDestinyKiosksComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsKiosksDestinyKiosksComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsKiosksDestinyKiosksComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KioskItems == input.KioskItems ||
                    this.KioskItems != null &&
                    input.KioskItems != null &&
                    this.KioskItems.SequenceEqual(input.KioskItems)
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
                if (this.KioskItems != null)
                {
                    hashCode = (hashCode * 59) + this.KioskItems.GetHashCode();
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
