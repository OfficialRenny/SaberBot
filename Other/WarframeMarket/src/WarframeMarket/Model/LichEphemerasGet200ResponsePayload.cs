/*
 * Warframe.market API
 *
 * ## Documentation is under very slow and heavy development  This document will gradually be supplemented and updated over some extended period of time.  ## Unstable endpoints Endpoint that is not stable and probably will be changed in the future will be marked with exclamation sign -> ⚠ 
 *
 * The version of the OpenAPI document: 1.14.0
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
using OpenAPIDateConverter = WarframeMarket.Client.OpenAPIDateConverter;

namespace WarframeMarket.Model
{
    /// <summary>
    /// LichEphemerasGet200ResponsePayload
    /// </summary>
    [DataContract(Name = "_lich_ephemeras_get_200_response_payload")]
    public partial class LichEphemerasGet200ResponsePayload : IEquatable<LichEphemerasGet200ResponsePayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LichEphemerasGet200ResponsePayload" /> class.
        /// </summary>
        /// <param name="ephemeras">ephemeras.</param>
        public LichEphemerasGet200ResponsePayload(List<NemesisEphemera> ephemeras = default(List<NemesisEphemera>))
        {
            this.Ephemeras = ephemeras;
        }

        /// <summary>
        /// Gets or Sets Ephemeras
        /// </summary>
        [DataMember(Name = "ephemeras", EmitDefaultValue = false)]
        public List<NemesisEphemera> Ephemeras { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LichEphemerasGet200ResponsePayload {\n");
            sb.Append("  Ephemeras: ").Append(Ephemeras).Append("\n");
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
            return this.Equals(input as LichEphemerasGet200ResponsePayload);
        }

        /// <summary>
        /// Returns true if LichEphemerasGet200ResponsePayload instances are equal
        /// </summary>
        /// <param name="input">Instance of LichEphemerasGet200ResponsePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LichEphemerasGet200ResponsePayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ephemeras == input.Ephemeras ||
                    this.Ephemeras != null &&
                    input.Ephemeras != null &&
                    this.Ephemeras.SequenceEqual(input.Ephemeras)
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
                if (this.Ephemeras != null)
                {
                    hashCode = (hashCode * 59) + this.Ephemeras.GetHashCode();
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
