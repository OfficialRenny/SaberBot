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
    /// A response containing all of the components for a vendor.
    /// </summary>
    [DataContract(Name = "Destiny.Responses.DestinyVendorResponse")]
    public partial class DestinyResponsesDestinyVendorResponse : IEquatable<DestinyResponsesDestinyVendorResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyResponsesDestinyVendorResponse" /> class.
        /// </summary>
        /// <param name="vendor">vendor.</param>
        /// <param name="categories">categories.</param>
        /// <param name="sales">sales.</param>
        /// <param name="itemComponents">itemComponents.</param>
        /// <param name="currencyLookups">currencyLookups.</param>
        /// <param name="stringVariables">stringVariables.</param>
        public DestinyResponsesDestinyVendorResponse(SingleComponentResponseOfDestinyVendorComponent vendor = default(SingleComponentResponseOfDestinyVendorComponent), SingleComponentResponseOfDestinyVendorCategoriesComponent categories = default(SingleComponentResponseOfDestinyVendorCategoriesComponent), DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent sales = default(DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent), DestinyItemComponentSetOfint32 itemComponents = default(DestinyItemComponentSetOfint32), SingleComponentResponseOfDestinyCurrenciesComponent currencyLookups = default(SingleComponentResponseOfDestinyCurrenciesComponent), SingleComponentResponseOfDestinyStringVariablesComponent stringVariables = default(SingleComponentResponseOfDestinyStringVariablesComponent))
        {
            this.Vendor = vendor;
            this.Categories = categories;
            this.Sales = sales;
            this.ItemComponents = itemComponents;
            this.CurrencyLookups = currencyLookups;
            this.StringVariables = stringVariables;
        }

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name = "vendor", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyVendorComponent Vendor { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyVendorCategoriesComponent Categories { get; set; }

        /// <summary>
        /// Gets or Sets Sales
        /// </summary>
        [DataMember(Name = "sales", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent Sales { get; set; }

        /// <summary>
        /// Gets or Sets ItemComponents
        /// </summary>
        [DataMember(Name = "itemComponents", EmitDefaultValue = false)]
        public DestinyItemComponentSetOfint32 ItemComponents { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyLookups
        /// </summary>
        [DataMember(Name = "currencyLookups", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; set; }

        /// <summary>
        /// Gets or Sets StringVariables
        /// </summary>
        [DataMember(Name = "stringVariables", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyStringVariablesComponent StringVariables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyResponsesDestinyVendorResponse {\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Sales: ").Append(Sales).Append("\n");
            sb.Append("  ItemComponents: ").Append(ItemComponents).Append("\n");
            sb.Append("  CurrencyLookups: ").Append(CurrencyLookups).Append("\n");
            sb.Append("  StringVariables: ").Append(StringVariables).Append("\n");
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
            return this.Equals(input as DestinyResponsesDestinyVendorResponse);
        }

        /// <summary>
        /// Returns true if DestinyResponsesDestinyVendorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyResponsesDestinyVendorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyResponsesDestinyVendorResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Vendor == input.Vendor ||
                    (this.Vendor != null &&
                    this.Vendor.Equals(input.Vendor))
                ) && 
                (
                    this.Categories == input.Categories ||
                    (this.Categories != null &&
                    this.Categories.Equals(input.Categories))
                ) && 
                (
                    this.Sales == input.Sales ||
                    (this.Sales != null &&
                    this.Sales.Equals(input.Sales))
                ) && 
                (
                    this.ItemComponents == input.ItemComponents ||
                    (this.ItemComponents != null &&
                    this.ItemComponents.Equals(input.ItemComponents))
                ) && 
                (
                    this.CurrencyLookups == input.CurrencyLookups ||
                    (this.CurrencyLookups != null &&
                    this.CurrencyLookups.Equals(input.CurrencyLookups))
                ) && 
                (
                    this.StringVariables == input.StringVariables ||
                    (this.StringVariables != null &&
                    this.StringVariables.Equals(input.StringVariables))
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
                if (this.Vendor != null)
                {
                    hashCode = (hashCode * 59) + this.Vendor.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.Sales != null)
                {
                    hashCode = (hashCode * 59) + this.Sales.GetHashCode();
                }
                if (this.ItemComponents != null)
                {
                    hashCode = (hashCode * 59) + this.ItemComponents.GetHashCode();
                }
                if (this.CurrencyLookups != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyLookups.GetHashCode();
                }
                if (this.StringVariables != null)
                {
                    hashCode = (hashCode * 59) + this.StringVariables.GetHashCode();
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
