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
    /// The response object for retrieving an individual instanced item. None of these components are relevant for an item that doesn&#39;t have an \&quot;itemInstanceId\&quot;: for those, get your information from the DestinyInventoryDefinition.
    /// </summary>
    [DataContract(Name = "Destiny.Responses.DestinyItemResponse")]
    public partial class DestinyResponsesDestinyItemResponse : IEquatable<DestinyResponsesDestinyItemResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyResponsesDestinyItemResponse" /> class.
        /// </summary>
        /// <param name="characterId">If the item is on a character, this will return the ID of the character that is holding the item..</param>
        /// <param name="item">item.</param>
        /// <param name="instance">instance.</param>
        /// <param name="objectives">objectives.</param>
        /// <param name="perks">perks.</param>
        /// <param name="renderData">renderData.</param>
        /// <param name="stats">stats.</param>
        /// <param name="talentGrid">talentGrid.</param>
        /// <param name="sockets">sockets.</param>
        /// <param name="reusablePlugs">reusablePlugs.</param>
        /// <param name="plugObjectives">plugObjectives.</param>
        public DestinyResponsesDestinyItemResponse(long? characterId = default(long?), SingleComponentResponseOfDestinyItemComponent item = default(SingleComponentResponseOfDestinyItemComponent), SingleComponentResponseOfDestinyItemInstanceComponent instance = default(SingleComponentResponseOfDestinyItemInstanceComponent), SingleComponentResponseOfDestinyItemObjectivesComponent objectives = default(SingleComponentResponseOfDestinyItemObjectivesComponent), SingleComponentResponseOfDestinyItemPerksComponent perks = default(SingleComponentResponseOfDestinyItemPerksComponent), SingleComponentResponseOfDestinyItemRenderComponent renderData = default(SingleComponentResponseOfDestinyItemRenderComponent), SingleComponentResponseOfDestinyItemStatsComponent stats = default(SingleComponentResponseOfDestinyItemStatsComponent), SingleComponentResponseOfDestinyItemTalentGridComponent talentGrid = default(SingleComponentResponseOfDestinyItemTalentGridComponent), SingleComponentResponseOfDestinyItemSocketsComponent sockets = default(SingleComponentResponseOfDestinyItemSocketsComponent), SingleComponentResponseOfDestinyItemReusablePlugsComponent reusablePlugs = default(SingleComponentResponseOfDestinyItemReusablePlugsComponent), SingleComponentResponseOfDestinyItemPlugObjectivesComponent plugObjectives = default(SingleComponentResponseOfDestinyItemPlugObjectivesComponent))
        {
            this.CharacterId = characterId;
            this.Item = item;
            this.Instance = instance;
            this.Objectives = objectives;
            this.Perks = perks;
            this.RenderData = renderData;
            this.Stats = stats;
            this.TalentGrid = talentGrid;
            this.Sockets = sockets;
            this.ReusablePlugs = reusablePlugs;
            this.PlugObjectives = plugObjectives;
        }

        /// <summary>
        /// If the item is on a character, this will return the ID of the character that is holding the item.
        /// </summary>
        /// <value>If the item is on a character, this will return the ID of the character that is holding the item.</value>
        [DataMember(Name = "characterId", EmitDefaultValue = true)]
        public long? CharacterId { get; set; }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemComponent Item { get; set; }

        /// <summary>
        /// Gets or Sets Instance
        /// </summary>
        [DataMember(Name = "instance", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemInstanceComponent Instance { get; set; }

        /// <summary>
        /// Gets or Sets Objectives
        /// </summary>
        [DataMember(Name = "objectives", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemObjectivesComponent Objectives { get; set; }

        /// <summary>
        /// Gets or Sets Perks
        /// </summary>
        [DataMember(Name = "perks", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemPerksComponent Perks { get; set; }

        /// <summary>
        /// Gets or Sets RenderData
        /// </summary>
        [DataMember(Name = "renderData", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemRenderComponent RenderData { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemStatsComponent Stats { get; set; }

        /// <summary>
        /// Gets or Sets TalentGrid
        /// </summary>
        [DataMember(Name = "talentGrid", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemTalentGridComponent TalentGrid { get; set; }

        /// <summary>
        /// Gets or Sets Sockets
        /// </summary>
        [DataMember(Name = "sockets", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemSocketsComponent Sockets { get; set; }

        /// <summary>
        /// Gets or Sets ReusablePlugs
        /// </summary>
        [DataMember(Name = "reusablePlugs", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemReusablePlugsComponent ReusablePlugs { get; set; }

        /// <summary>
        /// Gets or Sets PlugObjectives
        /// </summary>
        [DataMember(Name = "plugObjectives", EmitDefaultValue = false)]
        public SingleComponentResponseOfDestinyItemPlugObjectivesComponent PlugObjectives { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyResponsesDestinyItemResponse {\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  Objectives: ").Append(Objectives).Append("\n");
            sb.Append("  Perks: ").Append(Perks).Append("\n");
            sb.Append("  RenderData: ").Append(RenderData).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  TalentGrid: ").Append(TalentGrid).Append("\n");
            sb.Append("  Sockets: ").Append(Sockets).Append("\n");
            sb.Append("  ReusablePlugs: ").Append(ReusablePlugs).Append("\n");
            sb.Append("  PlugObjectives: ").Append(PlugObjectives).Append("\n");
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
            return this.Equals(input as DestinyResponsesDestinyItemResponse);
        }

        /// <summary>
        /// Returns true if DestinyResponsesDestinyItemResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyResponsesDestinyItemResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyResponsesDestinyItemResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CharacterId == input.CharacterId ||
                    (this.CharacterId != null &&
                    this.CharacterId.Equals(input.CharacterId))
                ) && 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
                ) && 
                (
                    this.Instance == input.Instance ||
                    (this.Instance != null &&
                    this.Instance.Equals(input.Instance))
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
                    this.TalentGrid == input.TalentGrid ||
                    (this.TalentGrid != null &&
                    this.TalentGrid.Equals(input.TalentGrid))
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
                if (this.CharacterId != null)
                {
                    hashCode = (hashCode * 59) + this.CharacterId.GetHashCode();
                }
                if (this.Item != null)
                {
                    hashCode = (hashCode * 59) + this.Item.GetHashCode();
                }
                if (this.Instance != null)
                {
                    hashCode = (hashCode * 59) + this.Instance.GetHashCode();
                }
                if (this.Objectives != null)
                {
                    hashCode = (hashCode * 59) + this.Objectives.GetHashCode();
                }
                if (this.Perks != null)
                {
                    hashCode = (hashCode * 59) + this.Perks.GetHashCode();
                }
                if (this.RenderData != null)
                {
                    hashCode = (hashCode * 59) + this.RenderData.GetHashCode();
                }
                if (this.Stats != null)
                {
                    hashCode = (hashCode * 59) + this.Stats.GetHashCode();
                }
                if (this.TalentGrid != null)
                {
                    hashCode = (hashCode * 59) + this.TalentGrid.GetHashCode();
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
