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
    /// Only really useful if you&#39;re attempting to render the character&#39;s current appearance in 3D, this returns a bare minimum of information, pre-aggregated, that you&#39;ll need to perform that rendering. Note that you need to combine this with other 3D assets and data from our servers.  Examine the Javascript returned by https://bungie.net/sharedbundle/spasm to see how we use this data, but be warned: the rabbit hole goes pretty deep.
    /// </summary>
    [DataContract(Name = "Destiny.Entities.Characters.DestinyCharacterRenderComponent")]
    public partial class DestinyEntitiesCharactersDestinyCharacterRenderComponent : IEquatable<DestinyEntitiesCharactersDestinyCharacterRenderComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesCharactersDestinyCharacterRenderComponent" /> class.
        /// </summary>
        /// <param name="customDyes">Custom dyes, calculated by iterating over the character&#39;s equipped items. Useful for pre-fetching all of the dye data needed from our server..</param>
        /// <param name="customization">customization.</param>
        /// <param name="peerView">peerView.</param>
        public DestinyEntitiesCharactersDestinyCharacterRenderComponent(List<DestinyDyeReference> customDyes = default(List<DestinyDyeReference>), DestinyCharacterDestinyCharacterCustomization customization = default(DestinyCharacterDestinyCharacterCustomization), DestinyCharacterDestinyCharacterPeerView peerView = default(DestinyCharacterDestinyCharacterPeerView))
        {
            this.CustomDyes = customDyes;
            this.Customization = customization;
            this.PeerView = peerView;
        }

        /// <summary>
        /// Custom dyes, calculated by iterating over the character&#39;s equipped items. Useful for pre-fetching all of the dye data needed from our server.
        /// </summary>
        /// <value>Custom dyes, calculated by iterating over the character&#39;s equipped items. Useful for pre-fetching all of the dye data needed from our server.</value>
        [DataMember(Name = "customDyes", EmitDefaultValue = false)]
        public List<DestinyDyeReference> CustomDyes { get; set; }

        /// <summary>
        /// Gets or Sets Customization
        /// </summary>
        [DataMember(Name = "customization", EmitDefaultValue = false)]
        public DestinyCharacterDestinyCharacterCustomization Customization { get; set; }

        /// <summary>
        /// Gets or Sets PeerView
        /// </summary>
        [DataMember(Name = "peerView", EmitDefaultValue = false)]
        public DestinyCharacterDestinyCharacterPeerView PeerView { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyEntitiesCharactersDestinyCharacterRenderComponent {\n");
            sb.Append("  CustomDyes: ").Append(CustomDyes).Append("\n");
            sb.Append("  Customization: ").Append(Customization).Append("\n");
            sb.Append("  PeerView: ").Append(PeerView).Append("\n");
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
            return this.Equals(input as DestinyEntitiesCharactersDestinyCharacterRenderComponent);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesCharactersDestinyCharacterRenderComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesCharactersDestinyCharacterRenderComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesCharactersDestinyCharacterRenderComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomDyes == input.CustomDyes ||
                    this.CustomDyes != null &&
                    input.CustomDyes != null &&
                    this.CustomDyes.SequenceEqual(input.CustomDyes)
                ) && 
                (
                    this.Customization == input.Customization ||
                    (this.Customization != null &&
                    this.Customization.Equals(input.Customization))
                ) && 
                (
                    this.PeerView == input.PeerView ||
                    (this.PeerView != null &&
                    this.PeerView.Equals(input.PeerView))
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
                if (this.CustomDyes != null)
                {
                    hashCode = (hashCode * 59) + this.CustomDyes.GetHashCode();
                }
                if (this.Customization != null)
                {
                    hashCode = (hashCode * 59) + this.Customization.GetHashCode();
                }
                if (this.PeerView != null)
                {
                    hashCode = (hashCode * 59) + this.PeerView.GetHashCode();
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