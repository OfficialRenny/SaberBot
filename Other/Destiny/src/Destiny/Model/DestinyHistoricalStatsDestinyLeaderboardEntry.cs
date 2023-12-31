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
    /// DestinyHistoricalStatsDestinyLeaderboardEntry
    /// </summary>
    [DataContract(Name = "Destiny.HistoricalStats.DestinyLeaderboardEntry")]
    public partial class DestinyHistoricalStatsDestinyLeaderboardEntry : IEquatable<DestinyHistoricalStatsDestinyLeaderboardEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyHistoricalStatsDestinyLeaderboardEntry" /> class.
        /// </summary>
        /// <param name="rank">Where this player ranks on the leaderboard. A value of 1 is the top rank..</param>
        /// <param name="player">player.</param>
        /// <param name="characterId">ID of the player&#39;s best character for the reported stat..</param>
        /// <param name="value">value.</param>
        public DestinyHistoricalStatsDestinyLeaderboardEntry(int rank = default(int), DestinyHistoricalStatsDestinyPlayer player = default(DestinyHistoricalStatsDestinyPlayer), long characterId = default(long), DestinyHistoricalStatsDestinyHistoricalStatsValue value = default(DestinyHistoricalStatsDestinyHistoricalStatsValue))
        {
            this.Rank = rank;
            this.Player = player;
            this.CharacterId = characterId;
            this.Value = value;
        }

        /// <summary>
        /// Where this player ranks on the leaderboard. A value of 1 is the top rank.
        /// </summary>
        /// <value>Where this player ranks on the leaderboard. A value of 1 is the top rank.</value>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        public int Rank { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        public DestinyHistoricalStatsDestinyPlayer Player { get; set; }

        /// <summary>
        /// ID of the player&#39;s best character for the reported stat.
        /// </summary>
        /// <value>ID of the player&#39;s best character for the reported stat.</value>
        [DataMember(Name = "characterId", EmitDefaultValue = false)]
        public long CharacterId { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public DestinyHistoricalStatsDestinyHistoricalStatsValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyHistoricalStatsDestinyLeaderboardEntry {\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as DestinyHistoricalStatsDestinyLeaderboardEntry);
        }

        /// <summary>
        /// Returns true if DestinyHistoricalStatsDestinyLeaderboardEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyHistoricalStatsDestinyLeaderboardEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyHistoricalStatsDestinyLeaderboardEntry input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Rank == input.Rank ||
                    this.Rank.Equals(input.Rank)
                ) && 
                (
                    this.Player == input.Player ||
                    (this.Player != null &&
                    this.Player.Equals(input.Player))
                ) && 
                (
                    this.CharacterId == input.CharacterId ||
                    this.CharacterId.Equals(input.CharacterId)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                hashCode = (hashCode * 59) + this.Rank.GetHashCode();
                if (this.Player != null)
                {
                    hashCode = (hashCode * 59) + this.Player.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CharacterId.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
