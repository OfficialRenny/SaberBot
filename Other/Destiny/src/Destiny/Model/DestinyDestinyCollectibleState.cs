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
    /// A Flags Enumeration/bitmask where each bit represents a different state that the Collectible can be in. A collectible can be in any number of these states, and you can choose to use or ignore any or all of them when making your own UI that shows Collectible info. Our displays are going to honor them, but we&#39;re also the kind of people who only pretend to inhale before quickly passing it to the left. So, you know, do what you got to do.  (All joking aside, please note the caveat I mention around the Invisible flag: there are cases where it is in the best interest of your users to honor these flags even if you&#39;re a \&quot;show all the data\&quot; person. Collector-oriented compulsion is a very unfortunate and real thing, and I would hate to instill that compulsion in others through showing them items that they cannot earn. Please consider this when you are making your own apps/sites.)
    /// </summary>
    /// <value>A Flags Enumeration/bitmask where each bit represents a different state that the Collectible can be in. A collectible can be in any number of these states, and you can choose to use or ignore any or all of them when making your own UI that shows Collectible info. Our displays are going to honor them, but we&#39;re also the kind of people who only pretend to inhale before quickly passing it to the left. So, you know, do what you got to do.  (All joking aside, please note the caveat I mention around the Invisible flag: there are cases where it is in the best interest of your users to honor these flags even if you&#39;re a \&quot;show all the data\&quot; person. Collector-oriented compulsion is a very unfortunate and real thing, and I would hate to instill that compulsion in others through showing them items that they cannot earn. Please consider this when you are making your own apps/sites.)</value>
    public enum DestinyDestinyCollectibleState
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
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        NUMBER_2 = 2,

        /// <summary>
        /// Enum NUMBER_4 for value: 4
        /// </summary>
        NUMBER_4 = 4,

        /// <summary>
        /// Enum NUMBER_8 for value: 8
        /// </summary>
        NUMBER_8 = 8,

        /// <summary>
        /// Enum NUMBER_16 for value: 16
        /// </summary>
        NUMBER_16 = 16,

        /// <summary>
        /// Enum NUMBER_32 for value: 32
        /// </summary>
        NUMBER_32 = 32,

        /// <summary>
        /// Enum NUMBER_64 for value: 64
        /// </summary>
        NUMBER_64 = 64
    }

}