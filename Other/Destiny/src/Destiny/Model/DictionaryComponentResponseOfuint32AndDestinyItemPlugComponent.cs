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
    /// DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent
    /// </summary>
    [DataContract(Name = "DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent")]
    public partial class DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent : IEquatable<DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="privacy">privacy.</param>
        /// <param name="disabled">If true, this component is disabled..</param>
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent(Dictionary<string, DestinyComponentsItemsDestinyItemPlugComponent> data = default(Dictionary<string, DestinyComponentsItemsDestinyItemPlugComponent>), int privacy = default(int), bool? disabled = default(bool?))
        {
            this.Data = data;
            this.Privacy = privacy;
            this.Disabled = disabled;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Dictionary<string, DestinyComponentsItemsDestinyItemPlugComponent> Data { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name = "privacy", EmitDefaultValue = false)]
        public int Privacy { get; set; }

        /// <summary>
        /// If true, this component is disabled.
        /// </summary>
        /// <value>If true, this component is disabled.</value>
        [DataMember(Name = "disabled", EmitDefaultValue = true)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
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
            return this.Equals(input as DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent);
        }

        /// <summary>
        /// Returns true if DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    this.Privacy.Equals(input.Privacy)
                ) && 
                (
                    this.Disabled == input.Disabled ||
                    (this.Disabled != null &&
                    this.Disabled.Equals(input.Disabled))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Privacy.GetHashCode();
                if (this.Disabled != null)
                {
                    hashCode = (hashCode * 59) + this.Disabled.GetHashCode();
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
