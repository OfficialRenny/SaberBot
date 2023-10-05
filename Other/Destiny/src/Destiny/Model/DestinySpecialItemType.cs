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
    /// As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via direct data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
    /// </summary>
    /// <value>As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via direct data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.</value>
    public enum DestinySpecialItemType
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        NUMBER_0 = 0,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        NUMBER_1 = 1,

        /// <summary>
        /// Enum NUMBER_8 for value: 8
        /// </summary>
        NUMBER_8 = 8,

        /// <summary>
        /// Enum NUMBER_9 for value: 9
        /// </summary>
        NUMBER_9 = 9,

        /// <summary>
        /// Enum NUMBER_23 for value: 23
        /// </summary>
        NUMBER_23 = 23,

        /// <summary>
        /// Enum NUMBER_24 for value: 24
        /// </summary>
        NUMBER_24 = 24,

        /// <summary>
        /// Enum NUMBER_25 for value: 25
        /// </summary>
        NUMBER_25 = 25,

        /// <summary>
        /// Enum NUMBER_27 for value: 27
        /// </summary>
        NUMBER_27 = 27,

        /// <summary>
        /// Enum NUMBER_29 for value: 29
        /// </summary>
        NUMBER_29 = 29
    }

}
