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
    /// Some items are \&quot;sacks\&quot; - they can be \&quot;opened\&quot; to produce other items. This is information related to its sack status, mostly UI strings. Engrams are an example of items that are considered to be \&quot;Sacks\&quot;.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyItemSackBlockDefinition")]
    public partial class DestinyDefinitionsDestinyItemSackBlockDefinition : IEquatable<DestinyDefinitionsDestinyItemSackBlockDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemSackBlockDefinition" /> class.
        /// </summary>
        /// <param name="detailAction">A description of what will happen when you open the sack. As far as I can tell, this is blank currently. Unknown whether it will eventually be populated with useful info..</param>
        /// <param name="openAction">The localized name of the action being performed when you open the sack..</param>
        /// <param name="selectItemCount">selectItemCount.</param>
        /// <param name="vendorSackType">vendorSackType.</param>
        /// <param name="openOnAcquire">openOnAcquire.</param>
        public DestinyDefinitionsDestinyItemSackBlockDefinition(string detailAction = default(string), string openAction = default(string), int selectItemCount = default(int), string vendorSackType = default(string), bool openOnAcquire = default(bool))
        {
            this.DetailAction = detailAction;
            this.OpenAction = openAction;
            this.SelectItemCount = selectItemCount;
            this.VendorSackType = vendorSackType;
            this.OpenOnAcquire = openOnAcquire;
        }

        /// <summary>
        /// A description of what will happen when you open the sack. As far as I can tell, this is blank currently. Unknown whether it will eventually be populated with useful info.
        /// </summary>
        /// <value>A description of what will happen when you open the sack. As far as I can tell, this is blank currently. Unknown whether it will eventually be populated with useful info.</value>
        [DataMember(Name = "detailAction", EmitDefaultValue = false)]
        public string DetailAction { get; set; }

        /// <summary>
        /// The localized name of the action being performed when you open the sack.
        /// </summary>
        /// <value>The localized name of the action being performed when you open the sack.</value>
        [DataMember(Name = "openAction", EmitDefaultValue = false)]
        public string OpenAction { get; set; }

        /// <summary>
        /// Gets or Sets SelectItemCount
        /// </summary>
        [DataMember(Name = "selectItemCount", EmitDefaultValue = false)]
        public int SelectItemCount { get; set; }

        /// <summary>
        /// Gets or Sets VendorSackType
        /// </summary>
        [DataMember(Name = "vendorSackType", EmitDefaultValue = false)]
        public string VendorSackType { get; set; }

        /// <summary>
        /// Gets or Sets OpenOnAcquire
        /// </summary>
        [DataMember(Name = "openOnAcquire", EmitDefaultValue = true)]
        public bool OpenOnAcquire { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyItemSackBlockDefinition {\n");
            sb.Append("  DetailAction: ").Append(DetailAction).Append("\n");
            sb.Append("  OpenAction: ").Append(OpenAction).Append("\n");
            sb.Append("  SelectItemCount: ").Append(SelectItemCount).Append("\n");
            sb.Append("  VendorSackType: ").Append(VendorSackType).Append("\n");
            sb.Append("  OpenOnAcquire: ").Append(OpenOnAcquire).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyItemSackBlockDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemSackBlockDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemSackBlockDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemSackBlockDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DetailAction == input.DetailAction ||
                    (this.DetailAction != null &&
                    this.DetailAction.Equals(input.DetailAction))
                ) && 
                (
                    this.OpenAction == input.OpenAction ||
                    (this.OpenAction != null &&
                    this.OpenAction.Equals(input.OpenAction))
                ) && 
                (
                    this.SelectItemCount == input.SelectItemCount ||
                    this.SelectItemCount.Equals(input.SelectItemCount)
                ) && 
                (
                    this.VendorSackType == input.VendorSackType ||
                    (this.VendorSackType != null &&
                    this.VendorSackType.Equals(input.VendorSackType))
                ) && 
                (
                    this.OpenOnAcquire == input.OpenOnAcquire ||
                    this.OpenOnAcquire.Equals(input.OpenOnAcquire)
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
                if (this.DetailAction != null)
                {
                    hashCode = (hashCode * 59) + this.DetailAction.GetHashCode();
                }
                if (this.OpenAction != null)
                {
                    hashCode = (hashCode * 59) + this.OpenAction.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SelectItemCount.GetHashCode();
                if (this.VendorSackType != null)
                {
                    hashCode = (hashCode * 59) + this.VendorSackType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OpenOnAcquire.GetHashCode();
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