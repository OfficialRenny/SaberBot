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
    /// DestinyComponentsItemsDestinyItemPlugObjectivesComponent
    /// </summary>
    [DataContract(Name = "Destiny.Components.Items.DestinyItemPlugObjectivesComponent")]
    public partial class DestinyComponentsItemsDestinyItemPlugObjectivesComponent : IEquatable<DestinyComponentsItemsDestinyItemPlugObjectivesComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsItemsDestinyItemPlugObjectivesComponent" /> class.
        /// </summary>
        /// <param name="objectivesPerPlug">This set of data is keyed by the Item Hash (DestinyInventoryItemDefinition) of the plug whose objectives are being returned, with the value being the list of those objectives.   What if two plugs with the same hash are returned for an item, you ask?   Good question! They share the same item-scoped state, and as such would have identical objective state as a result. How&#39;s that for convenient.   Sometimes, Plugs may have objectives: generally, these are used for flavor and display purposes. For instance, a Plug might be tracking the number of PVP kills you have made. It will use the parent item&#39;s data about that tracking status to determine what to show, and will generally show it using the DestinyObjectiveDefinition&#39;s progressDescription property. Refer to the plug&#39;s itemHash and objective property for more information if you would like to display even more data..</param>
        public DestinyComponentsItemsDestinyItemPlugObjectivesComponent(Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>> objectivesPerPlug = default(Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>>))
        {
            this.ObjectivesPerPlug = objectivesPerPlug;
        }

        /// <summary>
        /// This set of data is keyed by the Item Hash (DestinyInventoryItemDefinition) of the plug whose objectives are being returned, with the value being the list of those objectives.   What if two plugs with the same hash are returned for an item, you ask?   Good question! They share the same item-scoped state, and as such would have identical objective state as a result. How&#39;s that for convenient.   Sometimes, Plugs may have objectives: generally, these are used for flavor and display purposes. For instance, a Plug might be tracking the number of PVP kills you have made. It will use the parent item&#39;s data about that tracking status to determine what to show, and will generally show it using the DestinyObjectiveDefinition&#39;s progressDescription property. Refer to the plug&#39;s itemHash and objective property for more information if you would like to display even more data.
        /// </summary>
        /// <value>This set of data is keyed by the Item Hash (DestinyInventoryItemDefinition) of the plug whose objectives are being returned, with the value being the list of those objectives.   What if two plugs with the same hash are returned for an item, you ask?   Good question! They share the same item-scoped state, and as such would have identical objective state as a result. How&#39;s that for convenient.   Sometimes, Plugs may have objectives: generally, these are used for flavor and display purposes. For instance, a Plug might be tracking the number of PVP kills you have made. It will use the parent item&#39;s data about that tracking status to determine what to show, and will generally show it using the DestinyObjectiveDefinition&#39;s progressDescription property. Refer to the plug&#39;s itemHash and objective property for more information if you would like to display even more data.</value>
        [DataMember(Name = "objectivesPerPlug", EmitDefaultValue = false)]
        public Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>> ObjectivesPerPlug { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsItemsDestinyItemPlugObjectivesComponent {\n");
            sb.Append("  ObjectivesPerPlug: ").Append(ObjectivesPerPlug).Append("\n");
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
            return this.Equals(input as DestinyComponentsItemsDestinyItemPlugObjectivesComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsItemsDestinyItemPlugObjectivesComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsItemsDestinyItemPlugObjectivesComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsItemsDestinyItemPlugObjectivesComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ObjectivesPerPlug == input.ObjectivesPerPlug ||
                    this.ObjectivesPerPlug != null &&
                    input.ObjectivesPerPlug != null &&
                    this.ObjectivesPerPlug.SequenceEqual(input.ObjectivesPerPlug)
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
                if (this.ObjectivesPerPlug != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectivesPerPlug.GetHashCode();
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