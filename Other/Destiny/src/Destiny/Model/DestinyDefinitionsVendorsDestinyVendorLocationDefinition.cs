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
    /// These definitions represent vendors&#39; locations and relevant display information at different times in the game.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Vendors.DestinyVendorLocationDefinition")]
    public partial class DestinyDefinitionsVendorsDestinyVendorLocationDefinition : IEquatable<DestinyDefinitionsVendorsDestinyVendorLocationDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsVendorsDestinyVendorLocationDefinition" /> class.
        /// </summary>
        /// <param name="destinationHash">The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry..</param>
        /// <param name="backgroundImagePath">The relative path to the background image representing this Vendor at this location, for use in a banner..</param>
        public DestinyDefinitionsVendorsDestinyVendorLocationDefinition(int destinationHash = default(int), string backgroundImagePath = default(string))
        {
            this.DestinationHash = destinationHash;
            this.BackgroundImagePath = backgroundImagePath;
        }

        /// <summary>
        /// The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry.
        /// </summary>
        /// <value>The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry.</value>
        [DataMember(Name = "destinationHash", EmitDefaultValue = false)]
        public int DestinationHash { get; set; }

        /// <summary>
        /// The relative path to the background image representing this Vendor at this location, for use in a banner.
        /// </summary>
        /// <value>The relative path to the background image representing this Vendor at this location, for use in a banner.</value>
        [DataMember(Name = "backgroundImagePath", EmitDefaultValue = false)]
        public string BackgroundImagePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsVendorsDestinyVendorLocationDefinition {\n");
            sb.Append("  DestinationHash: ").Append(DestinationHash).Append("\n");
            sb.Append("  BackgroundImagePath: ").Append(BackgroundImagePath).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsVendorsDestinyVendorLocationDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsVendorsDestinyVendorLocationDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsVendorsDestinyVendorLocationDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsVendorsDestinyVendorLocationDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DestinationHash == input.DestinationHash ||
                    this.DestinationHash.Equals(input.DestinationHash)
                ) && 
                (
                    this.BackgroundImagePath == input.BackgroundImagePath ||
                    (this.BackgroundImagePath != null &&
                    this.BackgroundImagePath.Equals(input.BackgroundImagePath))
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
                hashCode = (hashCode * 59) + this.DestinationHash.GetHashCode();
                if (this.BackgroundImagePath != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundImagePath.GetHashCode();
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