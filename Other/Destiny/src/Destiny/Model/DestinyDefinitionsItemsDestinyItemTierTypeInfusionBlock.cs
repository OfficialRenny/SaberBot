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
    /// DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Items.DestinyItemTierTypeInfusionBlock")]
    public partial class DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock : IEquatable<DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock" /> class.
        /// </summary>
        /// <param name="baseQualityTransferRatio">The default portion of quality that will transfer from the infuser to the infusee item. (InfuserQuality - InfuseeQuality) * baseQualityTransferRatio &#x3D; base quality transferred..</param>
        /// <param name="minimumQualityIncrement">As long as InfuserQuality &gt; InfuseeQuality, the amount of quality bestowed is guaranteed to be at least this value, even if the transferRatio would dictate that it should be less. The total amount of quality that ends up in the Infusee cannot exceed the Infuser&#39;s quality however (for instance, if you infuse a 300 item with a 301 item and the minimum quality increment is 10, the infused item will not end up with 310 quality).</param>
        public DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock(float baseQualityTransferRatio = default(float), int minimumQualityIncrement = default(int))
        {
            this.BaseQualityTransferRatio = baseQualityTransferRatio;
            this.MinimumQualityIncrement = minimumQualityIncrement;
        }

        /// <summary>
        /// The default portion of quality that will transfer from the infuser to the infusee item. (InfuserQuality - InfuseeQuality) * baseQualityTransferRatio &#x3D; base quality transferred.
        /// </summary>
        /// <value>The default portion of quality that will transfer from the infuser to the infusee item. (InfuserQuality - InfuseeQuality) * baseQualityTransferRatio &#x3D; base quality transferred.</value>
        [DataMember(Name = "baseQualityTransferRatio", EmitDefaultValue = false)]
        public float BaseQualityTransferRatio { get; set; }

        /// <summary>
        /// As long as InfuserQuality &gt; InfuseeQuality, the amount of quality bestowed is guaranteed to be at least this value, even if the transferRatio would dictate that it should be less. The total amount of quality that ends up in the Infusee cannot exceed the Infuser&#39;s quality however (for instance, if you infuse a 300 item with a 301 item and the minimum quality increment is 10, the infused item will not end up with 310 quality)
        /// </summary>
        /// <value>As long as InfuserQuality &gt; InfuseeQuality, the amount of quality bestowed is guaranteed to be at least this value, even if the transferRatio would dictate that it should be less. The total amount of quality that ends up in the Infusee cannot exceed the Infuser&#39;s quality however (for instance, if you infuse a 300 item with a 301 item and the minimum quality increment is 10, the infused item will not end up with 310 quality)</value>
        [DataMember(Name = "minimumQualityIncrement", EmitDefaultValue = false)]
        public int MinimumQualityIncrement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock {\n");
            sb.Append("  BaseQualityTransferRatio: ").Append(BaseQualityTransferRatio).Append("\n");
            sb.Append("  MinimumQualityIncrement: ").Append(MinimumQualityIncrement).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BaseQualityTransferRatio == input.BaseQualityTransferRatio ||
                    this.BaseQualityTransferRatio.Equals(input.BaseQualityTransferRatio)
                ) && 
                (
                    this.MinimumQualityIncrement == input.MinimumQualityIncrement ||
                    this.MinimumQualityIncrement.Equals(input.MinimumQualityIncrement)
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
                hashCode = (hashCode * 59) + this.BaseQualityTransferRatio.GetHashCode();
                hashCode = (hashCode * 59) + this.MinimumQualityIncrement.GetHashCode();
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
