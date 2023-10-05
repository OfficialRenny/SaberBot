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
    /// The same as GroupV2ClanInfo, but includes any investment data.
    /// </summary>
    [DataContract(Name = "GroupsV2.GroupV2ClanInfoAndInvestment")]
    public partial class GroupsV2GroupV2ClanInfoAndInvestment : IEquatable<GroupsV2GroupV2ClanInfoAndInvestment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupV2ClanInfoAndInvestment" /> class.
        /// </summary>
        /// <param name="d2ClanProgressions">d2ClanProgressions.</param>
        /// <param name="clanCallsign">clanCallsign.</param>
        /// <param name="clanBannerData">clanBannerData.</param>
        public GroupsV2GroupV2ClanInfoAndInvestment(Dictionary<string, DestinyDestinyProgression> d2ClanProgressions = default(Dictionary<string, DestinyDestinyProgression>), string clanCallsign = default(string), GroupsV2ClanBanner clanBannerData = default(GroupsV2ClanBanner))
        {
            this.D2ClanProgressions = d2ClanProgressions;
            this.ClanCallsign = clanCallsign;
            this.ClanBannerData = clanBannerData;
        }

        /// <summary>
        /// Gets or Sets D2ClanProgressions
        /// </summary>
        [DataMember(Name = "d2ClanProgressions", EmitDefaultValue = false)]
        public Dictionary<string, DestinyDestinyProgression> D2ClanProgressions { get; set; }

        /// <summary>
        /// Gets or Sets ClanCallsign
        /// </summary>
        [DataMember(Name = "clanCallsign", EmitDefaultValue = false)]
        public string ClanCallsign { get; set; }

        /// <summary>
        /// Gets or Sets ClanBannerData
        /// </summary>
        [DataMember(Name = "clanBannerData", EmitDefaultValue = false)]
        public GroupsV2ClanBanner ClanBannerData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupsV2GroupV2ClanInfoAndInvestment {\n");
            sb.Append("  D2ClanProgressions: ").Append(D2ClanProgressions).Append("\n");
            sb.Append("  ClanCallsign: ").Append(ClanCallsign).Append("\n");
            sb.Append("  ClanBannerData: ").Append(ClanBannerData).Append("\n");
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
            return this.Equals(input as GroupsV2GroupV2ClanInfoAndInvestment);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupV2ClanInfoAndInvestment instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupV2ClanInfoAndInvestment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupV2ClanInfoAndInvestment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.D2ClanProgressions == input.D2ClanProgressions ||
                    this.D2ClanProgressions != null &&
                    input.D2ClanProgressions != null &&
                    this.D2ClanProgressions.SequenceEqual(input.D2ClanProgressions)
                ) && 
                (
                    this.ClanCallsign == input.ClanCallsign ||
                    (this.ClanCallsign != null &&
                    this.ClanCallsign.Equals(input.ClanCallsign))
                ) && 
                (
                    this.ClanBannerData == input.ClanBannerData ||
                    (this.ClanBannerData != null &&
                    this.ClanBannerData.Equals(input.ClanBannerData))
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
                if (this.D2ClanProgressions != null)
                {
                    hashCode = (hashCode * 59) + this.D2ClanProgressions.GetHashCode();
                }
                if (this.ClanCallsign != null)
                {
                    hashCode = (hashCode * 59) + this.ClanCallsign.GetHashCode();
                }
                if (this.ClanBannerData != null)
                {
                    hashCode = (hashCode * 59) + this.ClanBannerData.GetHashCode();
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
