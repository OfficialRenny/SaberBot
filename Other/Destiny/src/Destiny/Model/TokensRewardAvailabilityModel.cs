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
    /// TokensRewardAvailabilityModel
    /// </summary>
    [DataContract(Name = "Tokens.RewardAvailabilityModel")]
    public partial class TokensRewardAvailabilityModel : IEquatable<TokensRewardAvailabilityModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensRewardAvailabilityModel" /> class.
        /// </summary>
        /// <param name="hasExistingCode">hasExistingCode.</param>
        /// <param name="recordDefinitions">recordDefinitions.</param>
        /// <param name="collectibleDefinitions">collectibleDefinitions.</param>
        /// <param name="isOffer">isOffer.</param>
        /// <param name="hasOffer">hasOffer.</param>
        /// <param name="offerApplied">offerApplied.</param>
        /// <param name="decryptedToken">decryptedToken.</param>
        /// <param name="isLoyaltyReward">isLoyaltyReward.</param>
        /// <param name="shopifyEndDate">shopifyEndDate.</param>
        /// <param name="gameEarnByDate">gameEarnByDate.</param>
        /// <param name="redemptionEndDate">redemptionEndDate.</param>
        public TokensRewardAvailabilityModel(bool hasExistingCode = default(bool), List<DestinyDefinitionsRecordsDestinyRecordDefinition> recordDefinitions = default(List<DestinyDefinitionsRecordsDestinyRecordDefinition>), List<TokensCollectibleDefinitions> collectibleDefinitions = default(List<TokensCollectibleDefinitions>), bool isOffer = default(bool), bool hasOffer = default(bool), bool offerApplied = default(bool), string decryptedToken = default(string), bool isLoyaltyReward = default(bool), DateTime? shopifyEndDate = default(DateTime?), DateTime gameEarnByDate = default(DateTime), DateTime redemptionEndDate = default(DateTime))
        {
            this.HasExistingCode = hasExistingCode;
            this.RecordDefinitions = recordDefinitions;
            this.CollectibleDefinitions = collectibleDefinitions;
            this.IsOffer = isOffer;
            this.HasOffer = hasOffer;
            this.OfferApplied = offerApplied;
            this.DecryptedToken = decryptedToken;
            this.IsLoyaltyReward = isLoyaltyReward;
            this.ShopifyEndDate = shopifyEndDate;
            this.GameEarnByDate = gameEarnByDate;
            this.RedemptionEndDate = redemptionEndDate;
        }

        /// <summary>
        /// Gets or Sets HasExistingCode
        /// </summary>
        [DataMember(Name = "HasExistingCode", EmitDefaultValue = true)]
        public bool HasExistingCode { get; set; }

        /// <summary>
        /// Gets or Sets RecordDefinitions
        /// </summary>
        [DataMember(Name = "RecordDefinitions", EmitDefaultValue = false)]
        public List<DestinyDefinitionsRecordsDestinyRecordDefinition> RecordDefinitions { get; set; }

        /// <summary>
        /// Gets or Sets CollectibleDefinitions
        /// </summary>
        [DataMember(Name = "CollectibleDefinitions", EmitDefaultValue = false)]
        public List<TokensCollectibleDefinitions> CollectibleDefinitions { get; set; }

        /// <summary>
        /// Gets or Sets IsOffer
        /// </summary>
        [DataMember(Name = "IsOffer", EmitDefaultValue = true)]
        public bool IsOffer { get; set; }

        /// <summary>
        /// Gets or Sets HasOffer
        /// </summary>
        [DataMember(Name = "HasOffer", EmitDefaultValue = true)]
        public bool HasOffer { get; set; }

        /// <summary>
        /// Gets or Sets OfferApplied
        /// </summary>
        [DataMember(Name = "OfferApplied", EmitDefaultValue = true)]
        public bool OfferApplied { get; set; }

        /// <summary>
        /// Gets or Sets DecryptedToken
        /// </summary>
        [DataMember(Name = "DecryptedToken", EmitDefaultValue = false)]
        public string DecryptedToken { get; set; }

        /// <summary>
        /// Gets or Sets IsLoyaltyReward
        /// </summary>
        [DataMember(Name = "IsLoyaltyReward", EmitDefaultValue = true)]
        public bool IsLoyaltyReward { get; set; }

        /// <summary>
        /// Gets or Sets ShopifyEndDate
        /// </summary>
        [DataMember(Name = "ShopifyEndDate", EmitDefaultValue = true)]
        public DateTime? ShopifyEndDate { get; set; }

        /// <summary>
        /// Gets or Sets GameEarnByDate
        /// </summary>
        [DataMember(Name = "GameEarnByDate", EmitDefaultValue = false)]
        public DateTime GameEarnByDate { get; set; }

        /// <summary>
        /// Gets or Sets RedemptionEndDate
        /// </summary>
        [DataMember(Name = "RedemptionEndDate", EmitDefaultValue = false)]
        public DateTime RedemptionEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokensRewardAvailabilityModel {\n");
            sb.Append("  HasExistingCode: ").Append(HasExistingCode).Append("\n");
            sb.Append("  RecordDefinitions: ").Append(RecordDefinitions).Append("\n");
            sb.Append("  CollectibleDefinitions: ").Append(CollectibleDefinitions).Append("\n");
            sb.Append("  IsOffer: ").Append(IsOffer).Append("\n");
            sb.Append("  HasOffer: ").Append(HasOffer).Append("\n");
            sb.Append("  OfferApplied: ").Append(OfferApplied).Append("\n");
            sb.Append("  DecryptedToken: ").Append(DecryptedToken).Append("\n");
            sb.Append("  IsLoyaltyReward: ").Append(IsLoyaltyReward).Append("\n");
            sb.Append("  ShopifyEndDate: ").Append(ShopifyEndDate).Append("\n");
            sb.Append("  GameEarnByDate: ").Append(GameEarnByDate).Append("\n");
            sb.Append("  RedemptionEndDate: ").Append(RedemptionEndDate).Append("\n");
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
            return this.Equals(input as TokensRewardAvailabilityModel);
        }

        /// <summary>
        /// Returns true if TokensRewardAvailabilityModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TokensRewardAvailabilityModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokensRewardAvailabilityModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HasExistingCode == input.HasExistingCode ||
                    this.HasExistingCode.Equals(input.HasExistingCode)
                ) && 
                (
                    this.RecordDefinitions == input.RecordDefinitions ||
                    this.RecordDefinitions != null &&
                    input.RecordDefinitions != null &&
                    this.RecordDefinitions.SequenceEqual(input.RecordDefinitions)
                ) && 
                (
                    this.CollectibleDefinitions == input.CollectibleDefinitions ||
                    this.CollectibleDefinitions != null &&
                    input.CollectibleDefinitions != null &&
                    this.CollectibleDefinitions.SequenceEqual(input.CollectibleDefinitions)
                ) && 
                (
                    this.IsOffer == input.IsOffer ||
                    this.IsOffer.Equals(input.IsOffer)
                ) && 
                (
                    this.HasOffer == input.HasOffer ||
                    this.HasOffer.Equals(input.HasOffer)
                ) && 
                (
                    this.OfferApplied == input.OfferApplied ||
                    this.OfferApplied.Equals(input.OfferApplied)
                ) && 
                (
                    this.DecryptedToken == input.DecryptedToken ||
                    (this.DecryptedToken != null &&
                    this.DecryptedToken.Equals(input.DecryptedToken))
                ) && 
                (
                    this.IsLoyaltyReward == input.IsLoyaltyReward ||
                    this.IsLoyaltyReward.Equals(input.IsLoyaltyReward)
                ) && 
                (
                    this.ShopifyEndDate == input.ShopifyEndDate ||
                    (this.ShopifyEndDate != null &&
                    this.ShopifyEndDate.Equals(input.ShopifyEndDate))
                ) && 
                (
                    this.GameEarnByDate == input.GameEarnByDate ||
                    (this.GameEarnByDate != null &&
                    this.GameEarnByDate.Equals(input.GameEarnByDate))
                ) && 
                (
                    this.RedemptionEndDate == input.RedemptionEndDate ||
                    (this.RedemptionEndDate != null &&
                    this.RedemptionEndDate.Equals(input.RedemptionEndDate))
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
                hashCode = (hashCode * 59) + this.HasExistingCode.GetHashCode();
                if (this.RecordDefinitions != null)
                {
                    hashCode = (hashCode * 59) + this.RecordDefinitions.GetHashCode();
                }
                if (this.CollectibleDefinitions != null)
                {
                    hashCode = (hashCode * 59) + this.CollectibleDefinitions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsOffer.GetHashCode();
                hashCode = (hashCode * 59) + this.HasOffer.GetHashCode();
                hashCode = (hashCode * 59) + this.OfferApplied.GetHashCode();
                if (this.DecryptedToken != null)
                {
                    hashCode = (hashCode * 59) + this.DecryptedToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsLoyaltyReward.GetHashCode();
                if (this.ShopifyEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.ShopifyEndDate.GetHashCode();
                }
                if (this.GameEarnByDate != null)
                {
                    hashCode = (hashCode * 59) + this.GameEarnByDate.GetHashCode();
                }
                if (this.RedemptionEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.RedemptionEndDate.GetHashCode();
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
