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
    /// A specific reason for being banned. Only accessible under the related category (DestinyReportReasonCategoryDefinition) under which it is shown. Note that this means that report reasons&#39; reasonHash are not globally unique: and indeed, entries like \&quot;Other\&quot; are defined under most categories for example.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Reporting.DestinyReportReasonDefinition")]
    public partial class DestinyDefinitionsReportingDestinyReportReasonDefinition : IEquatable<DestinyDefinitionsReportingDestinyReportReasonDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsReportingDestinyReportReasonDefinition" /> class.
        /// </summary>
        /// <param name="reasonHash">The identifier for the reason: they are only guaranteed unique under the Category in which they are found..</param>
        /// <param name="displayProperties">displayProperties.</param>
        public DestinyDefinitionsReportingDestinyReportReasonDefinition(int reasonHash = default(int), DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition))
        {
            this.ReasonHash = reasonHash;
            this.DisplayProperties = displayProperties;
        }

        /// <summary>
        /// The identifier for the reason: they are only guaranteed unique under the Category in which they are found.
        /// </summary>
        /// <value>The identifier for the reason: they are only guaranteed unique under the Category in which they are found.</value>
        [DataMember(Name = "reasonHash", EmitDefaultValue = false)]
        public int ReasonHash { get; set; }

        /// <summary>
        /// Gets or Sets DisplayProperties
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsReportingDestinyReportReasonDefinition {\n");
            sb.Append("  ReasonHash: ").Append(ReasonHash).Append("\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsReportingDestinyReportReasonDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsReportingDestinyReportReasonDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsReportingDestinyReportReasonDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsReportingDestinyReportReasonDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReasonHash == input.ReasonHash ||
                    this.ReasonHash.Equals(input.ReasonHash)
                ) && 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
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
                hashCode = (hashCode * 59) + this.ReasonHash.GetHashCode();
                if (this.DisplayProperties != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayProperties.GetHashCode();
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
