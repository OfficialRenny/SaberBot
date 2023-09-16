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
    /// Dropsource
    /// </summary>
    [DataContract(Name = "Dropsource")]
    public partial class Dropsource : IEquatable<Dropsource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dropsource" /> class.
        /// </summary>
        /// <param name="missions">missions.</param>
        /// <param name="relics">relics.</param>
        /// <param name="npc">npc.</param>
        public Dropsource(List<DropsourceMissionsInner> missions = default(List<DropsourceMissionsInner>), List<DropsourceRelicsInner> relics = default(List<DropsourceRelicsInner>), List<DropsourceNpcInner> npc = default(List<DropsourceNpcInner>))
        {
            this.Missions = missions;
            this.Relics = relics;
            this.Npc = npc;
        }

        /// <summary>
        /// Gets or Sets Missions
        /// </summary>
        [DataMember(Name = "missions", EmitDefaultValue = false)]
        public List<DropsourceMissionsInner> Missions { get; set; }

        /// <summary>
        /// Gets or Sets Relics
        /// </summary>
        [DataMember(Name = "relics", EmitDefaultValue = false)]
        public List<DropsourceRelicsInner> Relics { get; set; }

        /// <summary>
        /// Gets or Sets Npc
        /// </summary>
        [DataMember(Name = "npc", EmitDefaultValue = false)]
        public List<DropsourceNpcInner> Npc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Dropsource {\n");
            sb.Append("  Missions: ").Append(Missions).Append("\n");
            sb.Append("  Relics: ").Append(Relics).Append("\n");
            sb.Append("  Npc: ").Append(Npc).Append("\n");
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
            return this.Equals(input as Dropsource);
        }

        /// <summary>
        /// Returns true if Dropsource instances are equal
        /// </summary>
        /// <param name="input">Instance of Dropsource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dropsource input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Missions == input.Missions ||
                    this.Missions != null &&
                    input.Missions != null &&
                    this.Missions.SequenceEqual(input.Missions)
                ) && 
                (
                    this.Relics == input.Relics ||
                    this.Relics != null &&
                    input.Relics != null &&
                    this.Relics.SequenceEqual(input.Relics)
                ) && 
                (
                    this.Npc == input.Npc ||
                    this.Npc != null &&
                    input.Npc != null &&
                    this.Npc.SequenceEqual(input.Npc)
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
                if (this.Missions != null)
                {
                    hashCode = (hashCode * 59) + this.Missions.GetHashCode();
                }
                if (this.Relics != null)
                {
                    hashCode = (hashCode * 59) + this.Relics.GetHashCode();
                }
                if (this.Npc != null)
                {
                    hashCode = (hashCode * 59) + this.Npc.GetHashCode();
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
