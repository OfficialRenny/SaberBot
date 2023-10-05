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
    /// Information about milestones, presented in a character state-agnostic manner. Combine this data with DestinyMilestoneDefinition to get a full picture of the milestone, which is basically a checklist of things to do in the game. Think of this as GetPublicAdvisors 3.0, for those who used the Destiny 1 API.
    /// </summary>
    [DataContract(Name = "Destiny.Milestones.DestinyPublicMilestone")]
    public partial class DestinyMilestonesDestinyPublicMilestone : IEquatable<DestinyMilestonesDestinyPublicMilestone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyMilestonesDestinyPublicMilestone" /> class.
        /// </summary>
        /// <param name="milestoneHash">The hash identifier for the milestone. Use it to look up the DestinyMilestoneDefinition for static data about the Milestone..</param>
        /// <param name="availableQuests">A milestone not need have even a single quest, but if there are active quests they will be returned here..</param>
        /// <param name="activities">activities.</param>
        /// <param name="vendorHashes">Sometimes milestones - or activities active in milestones - will have relevant vendors. These are the vendors that are currently relevant.  Deprecated, already, for the sake of the new \&quot;vendors\&quot; property that has more data. What was I thinking..</param>
        /// <param name="vendors">This is why we can&#39;t have nice things. This is the ordered list of vendors to be shown that relate to this milestone, potentially along with other interesting data..</param>
        /// <param name="startDate">If known, this is the date when the Milestone started/became active..</param>
        /// <param name="endDate">If known, this is the date when the Milestone will expire/recycle/end..</param>
        /// <param name="order">Used for ordering milestones in a display to match how we order them in BNet. May pull from static data, or possibly in the future from dynamic information..</param>
        public DestinyMilestonesDestinyPublicMilestone(int milestoneHash = default(int), List<DestinyMilestonesDestinyPublicMilestoneQuest> availableQuests = default(List<DestinyMilestonesDestinyPublicMilestoneQuest>), List<DestinyMilestonesDestinyPublicMilestoneChallengeActivity> activities = default(List<DestinyMilestonesDestinyPublicMilestoneChallengeActivity>), List<int> vendorHashes = default(List<int>), List<DestinyMilestonesDestinyPublicMilestoneVendor> vendors = default(List<DestinyMilestonesDestinyPublicMilestoneVendor>), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), int order = default(int))
        {
            this.MilestoneHash = milestoneHash;
            this.AvailableQuests = availableQuests;
            this.Activities = activities;
            this.VendorHashes = vendorHashes;
            this.Vendors = vendors;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Order = order;
        }

        /// <summary>
        /// The hash identifier for the milestone. Use it to look up the DestinyMilestoneDefinition for static data about the Milestone.
        /// </summary>
        /// <value>The hash identifier for the milestone. Use it to look up the DestinyMilestoneDefinition for static data about the Milestone.</value>
        [DataMember(Name = "milestoneHash", EmitDefaultValue = false)]
        public int MilestoneHash { get; set; }

        /// <summary>
        /// A milestone not need have even a single quest, but if there are active quests they will be returned here.
        /// </summary>
        /// <value>A milestone not need have even a single quest, but if there are active quests they will be returned here.</value>
        [DataMember(Name = "availableQuests", EmitDefaultValue = false)]
        public List<DestinyMilestonesDestinyPublicMilestoneQuest> AvailableQuests { get; set; }

        /// <summary>
        /// Gets or Sets Activities
        /// </summary>
        [DataMember(Name = "activities", EmitDefaultValue = false)]
        public List<DestinyMilestonesDestinyPublicMilestoneChallengeActivity> Activities { get; set; }

        /// <summary>
        /// Sometimes milestones - or activities active in milestones - will have relevant vendors. These are the vendors that are currently relevant.  Deprecated, already, for the sake of the new \&quot;vendors\&quot; property that has more data. What was I thinking.
        /// </summary>
        /// <value>Sometimes milestones - or activities active in milestones - will have relevant vendors. These are the vendors that are currently relevant.  Deprecated, already, for the sake of the new \&quot;vendors\&quot; property that has more data. What was I thinking.</value>
        [DataMember(Name = "vendorHashes", EmitDefaultValue = false)]
        public List<int> VendorHashes { get; set; }

        /// <summary>
        /// This is why we can&#39;t have nice things. This is the ordered list of vendors to be shown that relate to this milestone, potentially along with other interesting data.
        /// </summary>
        /// <value>This is why we can&#39;t have nice things. This is the ordered list of vendors to be shown that relate to this milestone, potentially along with other interesting data.</value>
        [DataMember(Name = "vendors", EmitDefaultValue = false)]
        public List<DestinyMilestonesDestinyPublicMilestoneVendor> Vendors { get; set; }

        /// <summary>
        /// If known, this is the date when the Milestone started/became active.
        /// </summary>
        /// <value>If known, this is the date when the Milestone started/became active.</value>
        [DataMember(Name = "startDate", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// If known, this is the date when the Milestone will expire/recycle/end.
        /// </summary>
        /// <value>If known, this is the date when the Milestone will expire/recycle/end.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Used for ordering milestones in a display to match how we order them in BNet. May pull from static data, or possibly in the future from dynamic information.
        /// </summary>
        /// <value>Used for ordering milestones in a display to match how we order them in BNet. May pull from static data, or possibly in the future from dynamic information.</value>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyMilestonesDestinyPublicMilestone {\n");
            sb.Append("  MilestoneHash: ").Append(MilestoneHash).Append("\n");
            sb.Append("  AvailableQuests: ").Append(AvailableQuests).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
            sb.Append("  VendorHashes: ").Append(VendorHashes).Append("\n");
            sb.Append("  Vendors: ").Append(Vendors).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as DestinyMilestonesDestinyPublicMilestone);
        }

        /// <summary>
        /// Returns true if DestinyMilestonesDestinyPublicMilestone instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyMilestonesDestinyPublicMilestone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyMilestonesDestinyPublicMilestone input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MilestoneHash == input.MilestoneHash ||
                    this.MilestoneHash.Equals(input.MilestoneHash)
                ) && 
                (
                    this.AvailableQuests == input.AvailableQuests ||
                    this.AvailableQuests != null &&
                    input.AvailableQuests != null &&
                    this.AvailableQuests.SequenceEqual(input.AvailableQuests)
                ) && 
                (
                    this.Activities == input.Activities ||
                    this.Activities != null &&
                    input.Activities != null &&
                    this.Activities.SequenceEqual(input.Activities)
                ) && 
                (
                    this.VendorHashes == input.VendorHashes ||
                    this.VendorHashes != null &&
                    input.VendorHashes != null &&
                    this.VendorHashes.SequenceEqual(input.VendorHashes)
                ) && 
                (
                    this.Vendors == input.Vendors ||
                    this.Vendors != null &&
                    input.Vendors != null &&
                    this.Vendors.SequenceEqual(input.Vendors)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
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
                hashCode = (hashCode * 59) + this.MilestoneHash.GetHashCode();
                if (this.AvailableQuests != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableQuests.GetHashCode();
                }
                if (this.Activities != null)
                {
                    hashCode = (hashCode * 59) + this.Activities.GetHashCode();
                }
                if (this.VendorHashes != null)
                {
                    hashCode = (hashCode * 59) + this.VendorHashes.GetHashCode();
                }
                if (this.Vendors != null)
                {
                    hashCode = (hashCode * 59) + this.Vendors.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
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
