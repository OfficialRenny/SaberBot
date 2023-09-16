/*
 * Warframe.market API
 *
 * ## Documentation is under very slow and heavy development  This document will gradually be supplemented and updated over some extended period of time.  ## Unstable endpoints Endpoint that is not stable and probably will be changed in the future will be marked with exclamation sign -> ⚠ 
 *
 * The version of the OpenAPI document: 1.14.0
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
using OpenAPIDateConverter = WarframeMarket.Client.OpenAPIDateConverter;

namespace WarframeMarket.Model
{
    /// <summary>
    /// NemesisEphemera
    /// </summary>
    [DataContract(Name = "nemesisEphemera")]
    public partial class NemesisEphemera : IEquatable<NemesisEphemera>, IValidatableObject
    {
        /// <summary>
        /// Defines IconFormat
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IconFormatEnum
        {
            /// <summary>
            /// Enum Land for value: land
            /// </summary>
            [EnumMember(Value = "land")]
            Land = 1,

            /// <summary>
            /// Enum Port for value: port
            /// </summary>
            [EnumMember(Value = "port")]
            Port = 2
        }


        /// <summary>
        /// Gets or Sets IconFormat
        /// </summary>
        /// <example>port</example>
        [DataMember(Name = "icon_format", EmitDefaultValue = false)]
        public IconFormatEnum? IconFormat { get; set; }
        /// <summary>
        /// Defines AnimationFormat
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AnimationFormatEnum
        {
            /// <summary>
            /// Enum Land for value: land
            /// </summary>
            [EnumMember(Value = "land")]
            Land = 1,

            /// <summary>
            /// Enum Port for value: port
            /// </summary>
            [EnumMember(Value = "port")]
            Port = 2
        }


        /// <summary>
        /// Gets or Sets AnimationFormat
        /// </summary>
        [DataMember(Name = "animation_format", EmitDefaultValue = false)]
        public AnimationFormatEnum? AnimationFormat { get; set; }

        /// <summary>
        /// Gets or Sets Element
        /// </summary>
        [DataMember(Name = "element", EmitDefaultValue = false)]
        public Element? Element { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NemesisEphemera" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="urlName">urlName.</param>
        /// <param name="icon">it&#39;s a part of url, if you want to get an image you need to prepend assets root dirrectory: &#x60;http://warframe.market/static/assets/&#x60; .</param>
        /// <param name="iconFormat">iconFormat.</param>
        /// <param name="thumb">thumb of an icon.</param>
        /// <param name="animation">Path to the GIF animatgion of ephemera.</param>
        /// <param name="animationFormat">animationFormat.</param>
        /// <param name="element">element.</param>
        /// <param name="itemName">Name of the ephemera.</param>
        public NemesisEphemera(string id = default(string), string urlName = default(string), string icon = default(string), IconFormatEnum? iconFormat = default(IconFormatEnum?), string thumb = default(string), string animation = default(string), AnimationFormatEnum? animationFormat = default(AnimationFormatEnum?), Element? element = default(Element?), string itemName = default(string))
        {
            this.Id = id;
            this.UrlName = urlName;
            this.Icon = icon;
            this.IconFormat = iconFormat;
            this.Thumb = thumb;
            this.Animation = animation;
            this.AnimationFormat = animationFormat;
            this.Element = element;
            this.ItemName = itemName;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>5e9854b93d9f64004f9136bd</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets UrlName
        /// </summary>
        /// <example>vengeful_shockwave</example>
        [DataMember(Name = "url_name", EmitDefaultValue = false)]
        public string UrlName { get; set; }

        /// <summary>
        /// it&#39;s a part of url, if you want to get an image you need to prepend assets root dirrectory: &#x60;http://warframe.market/static/assets/&#x60; 
        /// </summary>
        /// <value>it&#39;s a part of url, if you want to get an image you need to prepend assets root dirrectory: &#x60;http://warframe.market/static/assets/&#x60; </value>
        /// <example>icons/en/vengeful_shockwave.6020e14eb5e9516d4bc6ccf5023c864c.png</example>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; }

        /// <summary>
        /// thumb of an icon
        /// </summary>
        /// <value>thumb of an icon</value>
        /// <example>icons/en/thumbs/vengeful_shockwave.6020e14eb5e9516d4bc6ccf5023c864c.128x128.png</example>
        [DataMember(Name = "thumb", EmitDefaultValue = false)]
        public string Thumb { get; set; }

        /// <summary>
        /// Path to the GIF animatgion of ephemera
        /// </summary>
        /// <value>Path to the GIF animatgion of ephemera</value>
        /// <example>animations/vengeful_shockwave.971437bf48dec307ed268285b8798228.gif</example>
        [DataMember(Name = "animation", EmitDefaultValue = false)]
        public string Animation { get; set; }

        /// <summary>
        /// Name of the ephemera
        /// </summary>
        /// <value>Name of the ephemera</value>
        /// <example>Vengeful Shockwave Ephemera</example>
        [DataMember(Name = "item_name", EmitDefaultValue = false)]
        public string ItemName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NemesisEphemera {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UrlName: ").Append(UrlName).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  IconFormat: ").Append(IconFormat).Append("\n");
            sb.Append("  Thumb: ").Append(Thumb).Append("\n");
            sb.Append("  Animation: ").Append(Animation).Append("\n");
            sb.Append("  AnimationFormat: ").Append(AnimationFormat).Append("\n");
            sb.Append("  Element: ").Append(Element).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
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
            return this.Equals(input as NemesisEphemera);
        }

        /// <summary>
        /// Returns true if NemesisEphemera instances are equal
        /// </summary>
        /// <param name="input">Instance of NemesisEphemera to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NemesisEphemera input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UrlName == input.UrlName ||
                    (this.UrlName != null &&
                    this.UrlName.Equals(input.UrlName))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.IconFormat == input.IconFormat ||
                    this.IconFormat.Equals(input.IconFormat)
                ) && 
                (
                    this.Thumb == input.Thumb ||
                    (this.Thumb != null &&
                    this.Thumb.Equals(input.Thumb))
                ) && 
                (
                    this.Animation == input.Animation ||
                    (this.Animation != null &&
                    this.Animation.Equals(input.Animation))
                ) && 
                (
                    this.AnimationFormat == input.AnimationFormat ||
                    this.AnimationFormat.Equals(input.AnimationFormat)
                ) && 
                (
                    this.Element == input.Element ||
                    this.Element.Equals(input.Element)
                ) && 
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.UrlName != null)
                {
                    hashCode = (hashCode * 59) + this.UrlName.GetHashCode();
                }
                if (this.Icon != null)
                {
                    hashCode = (hashCode * 59) + this.Icon.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IconFormat.GetHashCode();
                if (this.Thumb != null)
                {
                    hashCode = (hashCode * 59) + this.Thumb.GetHashCode();
                }
                if (this.Animation != null)
                {
                    hashCode = (hashCode * 59) + this.Animation.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AnimationFormat.GetHashCode();
                hashCode = (hashCode * 59) + this.Element.GetHashCode();
                if (this.ItemName != null)
                {
                    hashCode = (hashCode * 59) + this.ItemName.GetHashCode();
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
