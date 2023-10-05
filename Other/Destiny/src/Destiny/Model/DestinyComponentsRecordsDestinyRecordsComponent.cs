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
    /// DestinyComponentsRecordsDestinyRecordsComponent
    /// </summary>
    [DataContract(Name = "Destiny.Components.Records.DestinyRecordsComponent")]
    public partial class DestinyComponentsRecordsDestinyRecordsComponent : IEquatable<DestinyComponentsRecordsDestinyRecordsComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsRecordsDestinyRecordsComponent" /> class.
        /// </summary>
        /// <param name="records">records.</param>
        /// <param name="recordCategoriesRootNodeHash">The hash for the root presentation node definition of Triumph categories..</param>
        /// <param name="recordSealsRootNodeHash">The hash for the root presentation node definition of Triumph Seals..</param>
        public DestinyComponentsRecordsDestinyRecordsComponent(Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> records = default(Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent>), int recordCategoriesRootNodeHash = default(int), int recordSealsRootNodeHash = default(int))
        {
            this.Records = records;
            this.RecordCategoriesRootNodeHash = recordCategoriesRootNodeHash;
            this.RecordSealsRootNodeHash = recordSealsRootNodeHash;
        }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name = "records", EmitDefaultValue = false)]
        public Dictionary<string, DestinyComponentsRecordsDestinyRecordComponent> Records { get; set; }

        /// <summary>
        /// The hash for the root presentation node definition of Triumph categories.
        /// </summary>
        /// <value>The hash for the root presentation node definition of Triumph categories.</value>
        [DataMember(Name = "recordCategoriesRootNodeHash", EmitDefaultValue = false)]
        public int RecordCategoriesRootNodeHash { get; set; }

        /// <summary>
        /// The hash for the root presentation node definition of Triumph Seals.
        /// </summary>
        /// <value>The hash for the root presentation node definition of Triumph Seals.</value>
        [DataMember(Name = "recordSealsRootNodeHash", EmitDefaultValue = false)]
        public int RecordSealsRootNodeHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsRecordsDestinyRecordsComponent {\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  RecordCategoriesRootNodeHash: ").Append(RecordCategoriesRootNodeHash).Append("\n");
            sb.Append("  RecordSealsRootNodeHash: ").Append(RecordSealsRootNodeHash).Append("\n");
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
            return this.Equals(input as DestinyComponentsRecordsDestinyRecordsComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsRecordsDestinyRecordsComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsRecordsDestinyRecordsComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsRecordsDestinyRecordsComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
                ) && 
                (
                    this.RecordCategoriesRootNodeHash == input.RecordCategoriesRootNodeHash ||
                    this.RecordCategoriesRootNodeHash.Equals(input.RecordCategoriesRootNodeHash)
                ) && 
                (
                    this.RecordSealsRootNodeHash == input.RecordSealsRootNodeHash ||
                    this.RecordSealsRootNodeHash.Equals(input.RecordSealsRootNodeHash)
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
                if (this.Records != null)
                {
                    hashCode = (hashCode * 59) + this.Records.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RecordCategoriesRootNodeHash.GetHashCode();
                hashCode = (hashCode * 59) + this.RecordSealsRootNodeHash.GetHashCode();
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
