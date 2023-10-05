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
    /// DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent
    /// </summary>
    [DataContract(Name = "DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent")]
    public partial class DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent : IEquatable<DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent" /> class.
        /// </summary>
        /// <param name="saleItems">saleItems.</param>
        public DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent(Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> saleItems = default(Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent>))
        {
            this.SaleItems = saleItems;
        }

        /// <summary>
        /// Gets or Sets SaleItems
        /// </summary>
        [DataMember(Name = "saleItems", EmitDefaultValue = false)]
        public Dictionary<string, DestinyEntitiesVendorsDestinyVendorSaleItemComponent> SaleItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent {\n");
            sb.Append("  SaleItems: ").Append(SaleItems).Append("\n");
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
            return this.Equals(input as DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent);
        }

        /// <summary>
        /// Returns true if DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyVendorSaleItemSetComponentOfDestinyVendorSaleItemComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SaleItems == input.SaleItems ||
                    this.SaleItems != null &&
                    input.SaleItems != null &&
                    this.SaleItems.SequenceEqual(input.SaleItems)
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
                if (this.SaleItems != null)
                {
                    hashCode = (hashCode * 59) + this.SaleItems.GetHashCode();
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