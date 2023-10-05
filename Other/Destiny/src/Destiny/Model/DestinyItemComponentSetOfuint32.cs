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
    /// DestinyItemComponentSetOfuint32
    /// </summary>
    [DataContract(Name = "DestinyItemComponentSetOfuint32")]
    public partial class DestinyItemComponentSetOfuint32 : IEquatable<DestinyItemComponentSetOfuint32>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyItemComponentSetOfuint32" /> class.
        /// </summary>
        /// <param name="instances">instances.</param>
        /// <param name="renderData">renderData.</param>
        /// <param name="stats">stats.</param>
        /// <param name="sockets">sockets.</param>
        /// <param name="reusablePlugs">reusablePlugs.</param>
        /// <param name="plugObjectives">plugObjectives.</param>
        /// <param name="talentGrids">talentGrids.</param>
        /// <param name="plugStates">plugStates.</param>
        /// <param name="objectives">objectives.</param>
        /// <param name="perks">perks.</param>
        public DestinyItemComponentSetOfuint32(DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent instances = default(DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent), DictionaryComponentResponseOfuint32AndDestinyItemRenderComponent renderData = default(DictionaryComponentResponseOfuint32AndDestinyItemRenderComponent), DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent stats = default(DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent), DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent sockets = default(DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent), DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent reusablePlugs = default(DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent), DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent plugObjectives = default(DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent), DictionaryComponentResponseOfuint32AndDestinyItemTalentGridComponent talentGrids = default(DictionaryComponentResponseOfuint32AndDestinyItemTalentGridComponent), DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent plugStates = default(DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent), DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent objectives = default(DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent), DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent perks = default(DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent))
        {
            this.Instances = instances;
            this.RenderData = renderData;
            this.Stats = stats;
            this.Sockets = sockets;
            this.ReusablePlugs = reusablePlugs;
            this.PlugObjectives = plugObjectives;
            this.TalentGrids = talentGrids;
            this.PlugStates = plugStates;
            this.Objectives = objectives;
            this.Perks = perks;
        }

        /// <summary>
        /// Gets or Sets Instances
        /// </summary>
        [DataMember(Name = "instances", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent Instances { get; set; }

        /// <summary>
        /// Gets or Sets RenderData
        /// </summary>
        [DataMember(Name = "renderData", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfuint32AndDestinyItemRenderComponent RenderData { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfuint32AndDestinyItemStatsComponent Stats { get; set; }

        /// <summary>
        /// Gets or Sets Sockets
        /// </summary>
        [DataMember(Name = "sockets", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfuint32AndDestinyItemSocketsComponent Sockets { get; set; }

        /// <summary>
        /// Gets or Sets ReusablePlugs
        /// </summary>
        [DataMember(Name = "reusablePlugs", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfuint32AndDestinyItemReusablePlugsComponent ReusablePlugs { get; set; }

        /// <summary>
        /// Gets or Sets PlugObjectives
        /// </summary>
        [DataMember(Name = "plugObjectives", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugObjectivesComponent PlugObjectives { get; set; }

        /// <summary>
        /// Gets or Sets TalentGrids
        /// </summary>
        [DataMember(Name = "talentGrids", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfuint32AndDestinyItemTalentGridComponent TalentGrids { get; set; }

        /// <summary>
        /// Gets or Sets PlugStates
        /// </summary>
        [DataMember(Name = "plugStates", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent PlugStates { get; set; }

        /// <summary>
        /// Gets or Sets Objectives
        /// </summary>
        [DataMember(Name = "objectives", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfuint32AndDestinyItemObjectivesComponent Objectives { get; set; }

        /// <summary>
        /// Gets or Sets Perks
        /// </summary>
        [DataMember(Name = "perks", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfuint32AndDestinyItemPerksComponent Perks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyItemComponentSetOfuint32 {\n");
            sb.Append("  Instances: ").Append(Instances).Append("\n");
            sb.Append("  RenderData: ").Append(RenderData).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  Sockets: ").Append(Sockets).Append("\n");
            sb.Append("  ReusablePlugs: ").Append(ReusablePlugs).Append("\n");
            sb.Append("  PlugObjectives: ").Append(PlugObjectives).Append("\n");
            sb.Append("  TalentGrids: ").Append(TalentGrids).Append("\n");
            sb.Append("  PlugStates: ").Append(PlugStates).Append("\n");
            sb.Append("  Objectives: ").Append(Objectives).Append("\n");
            sb.Append("  Perks: ").Append(Perks).Append("\n");
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
            return this.Equals(input as DestinyItemComponentSetOfuint32);
        }

        /// <summary>
        /// Returns true if DestinyItemComponentSetOfuint32 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyItemComponentSetOfuint32 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyItemComponentSetOfuint32 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Instances == input.Instances ||
                    (this.Instances != null &&
                    this.Instances.Equals(input.Instances))
                ) && 
                (
                    this.RenderData == input.RenderData ||
                    (this.RenderData != null &&
                    this.RenderData.Equals(input.RenderData))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.Sockets == input.Sockets ||
                    (this.Sockets != null &&
                    this.Sockets.Equals(input.Sockets))
                ) && 
                (
                    this.ReusablePlugs == input.ReusablePlugs ||
                    (this.ReusablePlugs != null &&
                    this.ReusablePlugs.Equals(input.ReusablePlugs))
                ) && 
                (
                    this.PlugObjectives == input.PlugObjectives ||
                    (this.PlugObjectives != null &&
                    this.PlugObjectives.Equals(input.PlugObjectives))
                ) && 
                (
                    this.TalentGrids == input.TalentGrids ||
                    (this.TalentGrids != null &&
                    this.TalentGrids.Equals(input.TalentGrids))
                ) && 
                (
                    this.PlugStates == input.PlugStates ||
                    (this.PlugStates != null &&
                    this.PlugStates.Equals(input.PlugStates))
                ) && 
                (
                    this.Objectives == input.Objectives ||
                    (this.Objectives != null &&
                    this.Objectives.Equals(input.Objectives))
                ) && 
                (
                    this.Perks == input.Perks ||
                    (this.Perks != null &&
                    this.Perks.Equals(input.Perks))
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
                if (this.Instances != null)
                {
                    hashCode = (hashCode * 59) + this.Instances.GetHashCode();
                }
                if (this.RenderData != null)
                {
                    hashCode = (hashCode * 59) + this.RenderData.GetHashCode();
                }
                if (this.Stats != null)
                {
                    hashCode = (hashCode * 59) + this.Stats.GetHashCode();
                }
                if (this.Sockets != null)
                {
                    hashCode = (hashCode * 59) + this.Sockets.GetHashCode();
                }
                if (this.ReusablePlugs != null)
                {
                    hashCode = (hashCode * 59) + this.ReusablePlugs.GetHashCode();
                }
                if (this.PlugObjectives != null)
                {
                    hashCode = (hashCode * 59) + this.PlugObjectives.GetHashCode();
                }
                if (this.TalentGrids != null)
                {
                    hashCode = (hashCode * 59) + this.TalentGrids.GetHashCode();
                }
                if (this.PlugStates != null)
                {
                    hashCode = (hashCode * 59) + this.PlugStates.GetHashCode();
                }
                if (this.Objectives != null)
                {
                    hashCode = (hashCode * 59) + this.Objectives.GetHashCode();
                }
                if (this.Perks != null)
                {
                    hashCode = (hashCode * 59) + this.Perks.GetHashCode();
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
