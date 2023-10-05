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
    /// ForumForumRecruitmentDetail
    /// </summary>
    [DataContract(Name = "Forum.ForumRecruitmentDetail")]
    public partial class ForumForumRecruitmentDetail : IEquatable<ForumForumRecruitmentDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumForumRecruitmentDetail" /> class.
        /// </summary>
        /// <param name="topicId">topicId.</param>
        /// <param name="microphoneRequired">microphoneRequired.</param>
        /// <param name="intensity">intensity.</param>
        /// <param name="tone">tone.</param>
        /// <param name="approved">approved.</param>
        /// <param name="conversationId">conversationId.</param>
        /// <param name="playerSlotsTotal">playerSlotsTotal.</param>
        /// <param name="playerSlotsRemaining">playerSlotsRemaining.</param>
        /// <param name="fireteam">fireteam.</param>
        /// <param name="kickedPlayerIds">kickedPlayerIds.</param>
        public ForumForumRecruitmentDetail(long topicId = default(long), bool microphoneRequired = default(bool), int intensity = default(int), int tone = default(int), bool approved = default(bool), long? conversationId = default(long?), int playerSlotsTotal = default(int), int playerSlotsRemaining = default(int), List<UserGeneralUser> fireteam = default(List<UserGeneralUser>), List<long> kickedPlayerIds = default(List<long>))
        {
            this.TopicId = topicId;
            this.MicrophoneRequired = microphoneRequired;
            this.Intensity = intensity;
            this.Tone = tone;
            this.Approved = approved;
            this.ConversationId = conversationId;
            this.PlayerSlotsTotal = playerSlotsTotal;
            this.PlayerSlotsRemaining = playerSlotsRemaining;
            this.Fireteam = fireteam;
            this.KickedPlayerIds = kickedPlayerIds;
        }

        /// <summary>
        /// Gets or Sets TopicId
        /// </summary>
        [DataMember(Name = "topicId", EmitDefaultValue = false)]
        public long TopicId { get; set; }

        /// <summary>
        /// Gets or Sets MicrophoneRequired
        /// </summary>
        [DataMember(Name = "microphoneRequired", EmitDefaultValue = true)]
        public bool MicrophoneRequired { get; set; }

        /// <summary>
        /// Gets or Sets Intensity
        /// </summary>
        [DataMember(Name = "intensity", EmitDefaultValue = false)]
        public int Intensity { get; set; }

        /// <summary>
        /// Gets or Sets Tone
        /// </summary>
        [DataMember(Name = "tone", EmitDefaultValue = false)]
        public int Tone { get; set; }

        /// <summary>
        /// Gets or Sets Approved
        /// </summary>
        [DataMember(Name = "approved", EmitDefaultValue = true)]
        public bool Approved { get; set; }

        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name = "conversationId", EmitDefaultValue = true)]
        public long? ConversationId { get; set; }

        /// <summary>
        /// Gets or Sets PlayerSlotsTotal
        /// </summary>
        [DataMember(Name = "playerSlotsTotal", EmitDefaultValue = false)]
        public int PlayerSlotsTotal { get; set; }

        /// <summary>
        /// Gets or Sets PlayerSlotsRemaining
        /// </summary>
        [DataMember(Name = "playerSlotsRemaining", EmitDefaultValue = false)]
        public int PlayerSlotsRemaining { get; set; }

        /// <summary>
        /// Gets or Sets Fireteam
        /// </summary>
        [DataMember(Name = "Fireteam", EmitDefaultValue = false)]
        public List<UserGeneralUser> Fireteam { get; set; }

        /// <summary>
        /// Gets or Sets KickedPlayerIds
        /// </summary>
        [DataMember(Name = "kickedPlayerIds", EmitDefaultValue = false)]
        public List<long> KickedPlayerIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ForumForumRecruitmentDetail {\n");
            sb.Append("  TopicId: ").Append(TopicId).Append("\n");
            sb.Append("  MicrophoneRequired: ").Append(MicrophoneRequired).Append("\n");
            sb.Append("  Intensity: ").Append(Intensity).Append("\n");
            sb.Append("  Tone: ").Append(Tone).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  PlayerSlotsTotal: ").Append(PlayerSlotsTotal).Append("\n");
            sb.Append("  PlayerSlotsRemaining: ").Append(PlayerSlotsRemaining).Append("\n");
            sb.Append("  Fireteam: ").Append(Fireteam).Append("\n");
            sb.Append("  KickedPlayerIds: ").Append(KickedPlayerIds).Append("\n");
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
            return this.Equals(input as ForumForumRecruitmentDetail);
        }

        /// <summary>
        /// Returns true if ForumForumRecruitmentDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ForumForumRecruitmentDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForumForumRecruitmentDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TopicId == input.TopicId ||
                    this.TopicId.Equals(input.TopicId)
                ) && 
                (
                    this.MicrophoneRequired == input.MicrophoneRequired ||
                    this.MicrophoneRequired.Equals(input.MicrophoneRequired)
                ) && 
                (
                    this.Intensity == input.Intensity ||
                    this.Intensity.Equals(input.Intensity)
                ) && 
                (
                    this.Tone == input.Tone ||
                    this.Tone.Equals(input.Tone)
                ) && 
                (
                    this.Approved == input.Approved ||
                    this.Approved.Equals(input.Approved)
                ) && 
                (
                    this.ConversationId == input.ConversationId ||
                    (this.ConversationId != null &&
                    this.ConversationId.Equals(input.ConversationId))
                ) && 
                (
                    this.PlayerSlotsTotal == input.PlayerSlotsTotal ||
                    this.PlayerSlotsTotal.Equals(input.PlayerSlotsTotal)
                ) && 
                (
                    this.PlayerSlotsRemaining == input.PlayerSlotsRemaining ||
                    this.PlayerSlotsRemaining.Equals(input.PlayerSlotsRemaining)
                ) && 
                (
                    this.Fireteam == input.Fireteam ||
                    this.Fireteam != null &&
                    input.Fireteam != null &&
                    this.Fireteam.SequenceEqual(input.Fireteam)
                ) && 
                (
                    this.KickedPlayerIds == input.KickedPlayerIds ||
                    this.KickedPlayerIds != null &&
                    input.KickedPlayerIds != null &&
                    this.KickedPlayerIds.SequenceEqual(input.KickedPlayerIds)
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
                hashCode = (hashCode * 59) + this.TopicId.GetHashCode();
                hashCode = (hashCode * 59) + this.MicrophoneRequired.GetHashCode();
                hashCode = (hashCode * 59) + this.Intensity.GetHashCode();
                hashCode = (hashCode * 59) + this.Tone.GetHashCode();
                hashCode = (hashCode * 59) + this.Approved.GetHashCode();
                if (this.ConversationId != null)
                {
                    hashCode = (hashCode * 59) + this.ConversationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PlayerSlotsTotal.GetHashCode();
                hashCode = (hashCode * 59) + this.PlayerSlotsRemaining.GetHashCode();
                if (this.Fireteam != null)
                {
                    hashCode = (hashCode * 59) + this.Fireteam.GetHashCode();
                }
                if (this.KickedPlayerIds != null)
                {
                    hashCode = (hashCode * 59) + this.KickedPlayerIds.GetHashCode();
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
