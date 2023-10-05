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
    /// GroupsV2GroupApplicationResponse
    /// </summary>
    [DataContract(Name = "GroupsV2.GroupApplicationResponse")]
    public partial class GroupsV2GroupApplicationResponse : IEquatable<GroupsV2GroupApplicationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupApplicationResponse" /> class.
        /// </summary>
        /// <param name="resolution">resolution.</param>
        public GroupsV2GroupApplicationResponse(int resolution = default(int))
        {
            this.Resolution = resolution;
        }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name = "resolution", EmitDefaultValue = false)]
        public int Resolution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupsV2GroupApplicationResponse {\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
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
            return this.Equals(input as GroupsV2GroupApplicationResponse);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupApplicationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupApplicationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupApplicationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Resolution == input.Resolution ||
                    this.Resolution.Equals(input.Resolution)
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
                hashCode = (hashCode * 59) + this.Resolution.GetHashCode();
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
