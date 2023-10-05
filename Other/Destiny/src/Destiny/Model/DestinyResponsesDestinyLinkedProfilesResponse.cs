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
    /// I know what you seek. You seek linked accounts. Found them, you have.  This contract returns a minimal amount of data about Destiny Accounts that are linked through your Bungie.Net account. We will not return accounts in this response whose
    /// </summary>
    [DataContract(Name = "Destiny.Responses.DestinyLinkedProfilesResponse")]
    public partial class DestinyResponsesDestinyLinkedProfilesResponse : IEquatable<DestinyResponsesDestinyLinkedProfilesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyResponsesDestinyLinkedProfilesResponse" /> class.
        /// </summary>
        /// <param name="profiles">Any Destiny account for whom we could successfully pull characters will be returned here, as the Platform-level summary of user data. (no character data, no Destiny account data other than the Membership ID and Type so you can make further queries).</param>
        /// <param name="bnetMembership">bnetMembership.</param>
        /// <param name="profilesWithErrors">This is brief summary info for profiles that we believe have valid Destiny info, but who failed to return data for some other reason and thus we know that subsequent calls for their info will also fail..</param>
        public DestinyResponsesDestinyLinkedProfilesResponse(List<DestinyResponsesDestinyProfileUserInfoCard> profiles = default(List<DestinyResponsesDestinyProfileUserInfoCard>), UserUserInfoCard bnetMembership = default(UserUserInfoCard), List<DestinyResponsesDestinyErrorProfile> profilesWithErrors = default(List<DestinyResponsesDestinyErrorProfile>))
        {
            this.Profiles = profiles;
            this.BnetMembership = bnetMembership;
            this.ProfilesWithErrors = profilesWithErrors;
        }

        /// <summary>
        /// Any Destiny account for whom we could successfully pull characters will be returned here, as the Platform-level summary of user data. (no character data, no Destiny account data other than the Membership ID and Type so you can make further queries)
        /// </summary>
        /// <value>Any Destiny account for whom we could successfully pull characters will be returned here, as the Platform-level summary of user data. (no character data, no Destiny account data other than the Membership ID and Type so you can make further queries)</value>
        [DataMember(Name = "profiles", EmitDefaultValue = false)]
        public List<DestinyResponsesDestinyProfileUserInfoCard> Profiles { get; set; }

        /// <summary>
        /// Gets or Sets BnetMembership
        /// </summary>
        [DataMember(Name = "bnetMembership", EmitDefaultValue = false)]
        public UserUserInfoCard BnetMembership { get; set; }

        /// <summary>
        /// This is brief summary info for profiles that we believe have valid Destiny info, but who failed to return data for some other reason and thus we know that subsequent calls for their info will also fail.
        /// </summary>
        /// <value>This is brief summary info for profiles that we believe have valid Destiny info, but who failed to return data for some other reason and thus we know that subsequent calls for their info will also fail.</value>
        [DataMember(Name = "profilesWithErrors", EmitDefaultValue = false)]
        public List<DestinyResponsesDestinyErrorProfile> ProfilesWithErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyResponsesDestinyLinkedProfilesResponse {\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  BnetMembership: ").Append(BnetMembership).Append("\n");
            sb.Append("  ProfilesWithErrors: ").Append(ProfilesWithErrors).Append("\n");
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
            return this.Equals(input as DestinyResponsesDestinyLinkedProfilesResponse);
        }

        /// <summary>
        /// Returns true if DestinyResponsesDestinyLinkedProfilesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyResponsesDestinyLinkedProfilesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyResponsesDestinyLinkedProfilesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Profiles == input.Profiles ||
                    this.Profiles != null &&
                    input.Profiles != null &&
                    this.Profiles.SequenceEqual(input.Profiles)
                ) && 
                (
                    this.BnetMembership == input.BnetMembership ||
                    (this.BnetMembership != null &&
                    this.BnetMembership.Equals(input.BnetMembership))
                ) && 
                (
                    this.ProfilesWithErrors == input.ProfilesWithErrors ||
                    this.ProfilesWithErrors != null &&
                    input.ProfilesWithErrors != null &&
                    this.ProfilesWithErrors.SequenceEqual(input.ProfilesWithErrors)
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
                if (this.Profiles != null)
                {
                    hashCode = (hashCode * 59) + this.Profiles.GetHashCode();
                }
                if (this.BnetMembership != null)
                {
                    hashCode = (hashCode * 59) + this.BnetMembership.GetHashCode();
                }
                if (this.ProfilesWithErrors != null)
                {
                    hashCode = (hashCode * 59) + this.ProfilesWithErrors.GetHashCode();
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
