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
    /// This describes links between the current graph and others, as well as when that link is relevant.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Director.DestinyLinkedGraphDefinition")]
    public partial class DestinyDefinitionsDirectorDestinyLinkedGraphDefinition : IEquatable<DestinyDefinitionsDirectorDestinyLinkedGraphDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDirectorDestinyLinkedGraphDefinition" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="name">name.</param>
        /// <param name="unlockExpression">unlockExpression.</param>
        /// <param name="linkedGraphId">linkedGraphId.</param>
        /// <param name="linkedGraphs">linkedGraphs.</param>
        /// <param name="overview">overview.</param>
        public DestinyDefinitionsDirectorDestinyLinkedGraphDefinition(string description = default(string), string name = default(string), DestinyDefinitionsDestinyUnlockExpressionDefinition unlockExpression = default(DestinyDefinitionsDestinyUnlockExpressionDefinition), int linkedGraphId = default(int), List<DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition> linkedGraphs = default(List<DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition>), string overview = default(string))
        {
            this.Description = description;
            this.Name = name;
            this.UnlockExpression = unlockExpression;
            this.LinkedGraphId = linkedGraphId;
            this.LinkedGraphs = linkedGraphs;
            this.Overview = overview;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets UnlockExpression
        /// </summary>
        [DataMember(Name = "unlockExpression", EmitDefaultValue = false)]
        public DestinyDefinitionsDestinyUnlockExpressionDefinition UnlockExpression { get; set; }

        /// <summary>
        /// Gets or Sets LinkedGraphId
        /// </summary>
        [DataMember(Name = "linkedGraphId", EmitDefaultValue = false)]
        public int LinkedGraphId { get; set; }

        /// <summary>
        /// Gets or Sets LinkedGraphs
        /// </summary>
        [DataMember(Name = "linkedGraphs", EmitDefaultValue = false)]
        public List<DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition> LinkedGraphs { get; set; }

        /// <summary>
        /// Gets or Sets Overview
        /// </summary>
        [DataMember(Name = "overview", EmitDefaultValue = false)]
        public string Overview { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDirectorDestinyLinkedGraphDefinition {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UnlockExpression: ").Append(UnlockExpression).Append("\n");
            sb.Append("  LinkedGraphId: ").Append(LinkedGraphId).Append("\n");
            sb.Append("  LinkedGraphs: ").Append(LinkedGraphs).Append("\n");
            sb.Append("  Overview: ").Append(Overview).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDirectorDestinyLinkedGraphDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDirectorDestinyLinkedGraphDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDirectorDestinyLinkedGraphDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDirectorDestinyLinkedGraphDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.UnlockExpression == input.UnlockExpression ||
                    (this.UnlockExpression != null &&
                    this.UnlockExpression.Equals(input.UnlockExpression))
                ) && 
                (
                    this.LinkedGraphId == input.LinkedGraphId ||
                    this.LinkedGraphId.Equals(input.LinkedGraphId)
                ) && 
                (
                    this.LinkedGraphs == input.LinkedGraphs ||
                    this.LinkedGraphs != null &&
                    input.LinkedGraphs != null &&
                    this.LinkedGraphs.SequenceEqual(input.LinkedGraphs)
                ) && 
                (
                    this.Overview == input.Overview ||
                    (this.Overview != null &&
                    this.Overview.Equals(input.Overview))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.UnlockExpression != null)
                {
                    hashCode = (hashCode * 59) + this.UnlockExpression.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LinkedGraphId.GetHashCode();
                if (this.LinkedGraphs != null)
                {
                    hashCode = (hashCode * 59) + this.LinkedGraphs.GetHashCode();
                }
                if (this.Overview != null)
                {
                    hashCode = (hashCode * 59) + this.Overview.GetHashCode();
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
