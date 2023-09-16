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
    /// How rare something can be considered
    /// </summary>
    /// <value>How rare something can be considered</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Rarities
    {
        /// <summary>
        /// Enum VeryCommon for value: very_common
        /// </summary>
        [EnumMember(Value = "very_common")]
        VeryCommon = 1,

        /// <summary>
        /// Enum Common for value: common
        /// </summary>
        [EnumMember(Value = "common")]
        Common = 2,

        /// <summary>
        /// Enum Uncommon for value: uncommon
        /// </summary>
        [EnumMember(Value = "uncommon")]
        Uncommon = 3,

        /// <summary>
        /// Enum Rare for value: rare
        /// </summary>
        [EnumMember(Value = "rare")]
        Rare = 4,

        /// <summary>
        /// Enum Legendary for value: legendary
        /// </summary>
        [EnumMember(Value = "legendary")]
        Legendary = 5
    }

}