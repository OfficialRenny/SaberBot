# Destiny.Api.PreviewApi

All URIs are relative to *https://www.bungie.net/Platform*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Destiny2GetClanAggregateStats**](PreviewApi.md#destiny2getclanaggregatestats) | **GET** /Destiny2/Stats/AggregateClanStats/{groupId}/ |  |
| [**Destiny2GetClanLeaderboards**](PreviewApi.md#destiny2getclanleaderboards) | **GET** /Destiny2/Stats/Leaderboards/Clans/{groupId}/ |  |
| [**Destiny2GetLeaderboards**](PreviewApi.md#destiny2getleaderboards) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/Leaderboards/ |  |
| [**Destiny2GetLeaderboardsForCharacter**](PreviewApi.md#destiny2getleaderboardsforcharacter) | **GET** /Destiny2/Stats/Leaderboards/{membershipType}/{destinyMembershipId}/{characterId}/ |  |
| [**Destiny2GetPublicVendors**](PreviewApi.md#destiny2getpublicvendors) | **GET** /Destiny2/Vendors/ |  |
| [**Destiny2InsertSocketPlug**](PreviewApi.md#destiny2insertsocketplug) | **POST** /Destiny2/Actions/Items/InsertSocketPlug/ |  |
| [**Destiny2InsertSocketPlugFree**](PreviewApi.md#destiny2insertsocketplugfree) | **POST** /Destiny2/Actions/Items/InsertSocketPlugFree/ |  |

<a id="destiny2getclanaggregatestats"></a>
# **Destiny2GetClanAggregateStats**
> Destiny2GetClanAggregateStats200Response Destiny2GetClanAggregateStats (long groupId, string? modes = null)



Gets aggregated stats for a clan using the same categories as the clan leaderboards. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetClanAggregateStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new PreviewApi(config);
            var groupId = 789L;  // long | Group ID of the clan whose leaderboards you wish to fetch.
            var modes = "modes_example";  // string? | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 

            try
            {
                Destiny2GetClanAggregateStats200Response result = apiInstance.Destiny2GetClanAggregateStats(groupId, modes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreviewApi.Destiny2GetClanAggregateStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetClanAggregateStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetClanAggregateStats200Response> response = apiInstance.Destiny2GetClanAggregateStatsWithHttpInfo(groupId, modes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreviewApi.Destiny2GetClanAggregateStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | Group ID of the clan whose leaderboards you wish to fetch. |  |
| **modes** | **string?** | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional]  |

### Return type

[**Destiny2GetClanAggregateStats200Response**](Destiny2GetClanAggregateStats200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getclanleaderboards"></a>
# **Destiny2GetClanLeaderboards**
> Destiny2GetClanLeaderboards200Response Destiny2GetClanLeaderboards (long groupId, int? maxtop = null, string? modes = null, string? statid = null)



Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetClanLeaderboardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new PreviewApi(config);
            var groupId = 789L;  // long | Group ID of the clan whose leaderboards you wish to fetch.
            var maxtop = 56;  // int? | Maximum number of top players to return. Use a large number to get entire leaderboard. (optional) 
            var modes = "modes_example";  // string? | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var statid = "statid_example";  // string? | ID of stat to return rather than returning all Leaderboard stats. (optional) 

            try
            {
                Destiny2GetClanLeaderboards200Response result = apiInstance.Destiny2GetClanLeaderboards(groupId, maxtop, modes, statid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreviewApi.Destiny2GetClanLeaderboards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetClanLeaderboardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetClanLeaderboards200Response> response = apiInstance.Destiny2GetClanLeaderboardsWithHttpInfo(groupId, maxtop, modes, statid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreviewApi.Destiny2GetClanLeaderboardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | Group ID of the clan whose leaderboards you wish to fetch. |  |
| **maxtop** | **int?** | Maximum number of top players to return. Use a large number to get entire leaderboard. | [optional]  |
| **modes** | **string?** | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional]  |
| **statid** | **string?** | ID of stat to return rather than returning all Leaderboard stats. | [optional]  |

### Return type

[**Destiny2GetClanLeaderboards200Response**](Destiny2GetClanLeaderboards200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getleaderboards"></a>
# **Destiny2GetLeaderboards**
> Destiny2GetClanLeaderboards200Response Destiny2GetLeaderboards (long destinyMembershipId, int membershipType, int? maxtop = null, string? modes = null, string? statid = null)



Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint has not yet been implemented. It is being returned for a preview of future functionality, and for public comment/suggestion/preparation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetLeaderboardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new PreviewApi(config);
            var destinyMembershipId = 789L;  // long | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.
            var maxtop = 56;  // int? | Maximum number of top players to return. Use a large number to get entire leaderboard. (optional) 
            var modes = "modes_example";  // string? | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var statid = "statid_example";  // string? | ID of stat to return rather than returning all Leaderboard stats. (optional) 

            try
            {
                Destiny2GetClanLeaderboards200Response result = apiInstance.Destiny2GetLeaderboards(destinyMembershipId, membershipType, maxtop, modes, statid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreviewApi.Destiny2GetLeaderboards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetLeaderboardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetClanLeaderboards200Response> response = apiInstance.Destiny2GetLeaderboardsWithHttpInfo(destinyMembershipId, membershipType, maxtop, modes, statid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreviewApi.Destiny2GetLeaderboardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyMembershipId** | **long** | The Destiny membershipId of the user to retrieve. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |
| **maxtop** | **int?** | Maximum number of top players to return. Use a large number to get entire leaderboard. | [optional]  |
| **modes** | **string?** | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional]  |
| **statid** | **string?** | ID of stat to return rather than returning all Leaderboard stats. | [optional]  |

### Return type

[**Destiny2GetClanLeaderboards200Response**](Destiny2GetClanLeaderboards200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getleaderboardsforcharacter"></a>
# **Destiny2GetLeaderboardsForCharacter**
> Destiny2GetClanLeaderboards200Response Destiny2GetLeaderboardsForCharacter (long characterId, long destinyMembershipId, int membershipType, int? maxtop = null, string? modes = null, string? statid = null)



Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetLeaderboardsForCharacterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new PreviewApi(config);
            var characterId = 789L;  // long | The specific character to build the leaderboard around for the provided Destiny Membership.
            var destinyMembershipId = 789L;  // long | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.
            var maxtop = 56;  // int? | Maximum number of top players to return. Use a large number to get entire leaderboard. (optional) 
            var modes = "modes_example";  // string? | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var statid = "statid_example";  // string? | ID of stat to return rather than returning all Leaderboard stats. (optional) 

            try
            {
                Destiny2GetClanLeaderboards200Response result = apiInstance.Destiny2GetLeaderboardsForCharacter(characterId, destinyMembershipId, membershipType, maxtop, modes, statid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreviewApi.Destiny2GetLeaderboardsForCharacter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetLeaderboardsForCharacterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetClanLeaderboards200Response> response = apiInstance.Destiny2GetLeaderboardsForCharacterWithHttpInfo(characterId, destinyMembershipId, membershipType, maxtop, modes, statid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreviewApi.Destiny2GetLeaderboardsForCharacterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **characterId** | **long** | The specific character to build the leaderboard around for the provided Destiny Membership. |  |
| **destinyMembershipId** | **long** | The Destiny membershipId of the user to retrieve. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |
| **maxtop** | **int?** | Maximum number of top players to return. Use a large number to get entire leaderboard. | [optional]  |
| **modes** | **string?** | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional]  |
| **statid** | **string?** | ID of stat to return rather than returning all Leaderboard stats. | [optional]  |

### Return type

[**Destiny2GetClanLeaderboards200Response**](Destiny2GetClanLeaderboards200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getpublicvendors"></a>
# **Destiny2GetPublicVendors**
> Destiny2GetPublicVendors200Response Destiny2GetPublicVendors (List<int>? components = null)



Get items available from vendors where the vendors have items for sale that are common for everyone. If any portion of the Vendor's available inventory is character or account specific, we will be unable to return their data from this endpoint due to the way that available inventory is computed. As I am often guilty of saying: 'It's a long story...'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetPublicVendorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new PreviewApi(config);
            var components = new List<int>?(); // List<int>? | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                Destiny2GetPublicVendors200Response result = apiInstance.Destiny2GetPublicVendors(components);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreviewApi.Destiny2GetPublicVendors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetPublicVendorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetPublicVendors200Response> response = apiInstance.Destiny2GetPublicVendorsWithHttpInfo(components);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreviewApi.Destiny2GetPublicVendorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **components** | [**List&lt;int&gt;?**](int.md) | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional]  |

### Return type

[**Destiny2GetPublicVendors200Response**](Destiny2GetPublicVendors200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A response containing all valid components for the public Vendors endpoint.   It is a decisively smaller subset of data compared to what we can get when we know the specific user making the request.   If you want any of the other data - item details, whether or not you can buy it, etc... you&#39;ll have to call in the context of a character. I know, sad but true. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2insertsocketplug"></a>
# **Destiny2InsertSocketPlug**
> Destiny2InsertSocketPlug200Response Destiny2InsertSocketPlug (DestinyRequestsActionsDestinyInsertPlugsActionRequest destinyRequestsActionsDestinyInsertPlugsActionRequest)



Insert a plug into a socketed item. I know how it sounds, but I assure you it's much more G-rated than you might be guessing. We haven't decided yet whether this will be able to insert plugs that have side effects, but if we do it will require special scope permission for an application attempting to do so. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Request must include proof of permission for 'InsertPlugs' from the account owner.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2InsertSocketPlugExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PreviewApi(config);
            var destinyRequestsActionsDestinyInsertPlugsActionRequest = new DestinyRequestsActionsDestinyInsertPlugsActionRequest(); // DestinyRequestsActionsDestinyInsertPlugsActionRequest | 

            try
            {
                Destiny2InsertSocketPlug200Response result = apiInstance.Destiny2InsertSocketPlug(destinyRequestsActionsDestinyInsertPlugsActionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreviewApi.Destiny2InsertSocketPlug: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2InsertSocketPlugWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2InsertSocketPlug200Response> response = apiInstance.Destiny2InsertSocketPlugWithHttpInfo(destinyRequestsActionsDestinyInsertPlugsActionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreviewApi.Destiny2InsertSocketPlugWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsActionsDestinyInsertPlugsActionRequest** | [**DestinyRequestsActionsDestinyInsertPlugsActionRequest**](DestinyRequestsActionsDestinyInsertPlugsActionRequest.md) |  |  |

### Return type

[**Destiny2InsertSocketPlug200Response**](Destiny2InsertSocketPlug200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2insertsocketplugfree"></a>
# **Destiny2InsertSocketPlugFree**
> Destiny2InsertSocketPlug200Response Destiny2InsertSocketPlugFree (DestinyRequestsActionsDestinyInsertPlugsFreeActionRequest destinyRequestsActionsDestinyInsertPlugsFreeActionRequest)



Insert a 'free' plug into an item's socket. This does not require 'Advanced Write Action' authorization and is available to 3rd-party apps, but will only work on 'free and reversible' socket actions (Perks, Armor Mods, Shaders, Ornaments, etc.). You must have a valid Destiny Account, and the character must either be in a social space, in orbit, or offline.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2InsertSocketPlugFreeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PreviewApi(config);
            var destinyRequestsActionsDestinyInsertPlugsFreeActionRequest = new DestinyRequestsActionsDestinyInsertPlugsFreeActionRequest(); // DestinyRequestsActionsDestinyInsertPlugsFreeActionRequest | 

            try
            {
                Destiny2InsertSocketPlug200Response result = apiInstance.Destiny2InsertSocketPlugFree(destinyRequestsActionsDestinyInsertPlugsFreeActionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreviewApi.Destiny2InsertSocketPlugFree: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2InsertSocketPlugFreeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2InsertSocketPlug200Response> response = apiInstance.Destiny2InsertSocketPlugFreeWithHttpInfo(destinyRequestsActionsDestinyInsertPlugsFreeActionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreviewApi.Destiny2InsertSocketPlugFreeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsActionsDestinyInsertPlugsFreeActionRequest** | [**DestinyRequestsActionsDestinyInsertPlugsFreeActionRequest**](DestinyRequestsActionsDestinyInsertPlugsFreeActionRequest.md) |  |  |

### Return type

[**Destiny2InsertSocketPlug200Response**](Destiny2InsertSocketPlug200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

