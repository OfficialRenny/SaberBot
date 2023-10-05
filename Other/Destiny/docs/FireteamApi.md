# Destiny.Api.FireteamApi

All URIs are relative to *https://www.bungie.net/Platform*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FireteamGetActivePrivateClanFireteamCount**](FireteamApi.md#fireteamgetactiveprivateclanfireteamcount) | **GET** /Fireteam/Clan/{groupId}/ActiveCount/ |  |
| [**FireteamGetAvailableClanFireteams**](FireteamApi.md#fireteamgetavailableclanfireteams) | **GET** /Fireteam/Clan/{groupId}/Available/{platform}/{activityType}/{dateRange}/{slotFilter}/{publicOnly}/{page}/ |  |
| [**FireteamGetClanFireteam**](FireteamApi.md#fireteamgetclanfireteam) | **GET** /Fireteam/Clan/{groupId}/Summary/{fireteamId}/ |  |
| [**FireteamGetMyClanFireteams**](FireteamApi.md#fireteamgetmyclanfireteams) | **GET** /Fireteam/Clan/{groupId}/My/{platform}/{includeClosed}/{page}/ |  |
| [**FireteamSearchPublicAvailableClanFireteams**](FireteamApi.md#fireteamsearchpublicavailableclanfireteams) | **GET** /Fireteam/Search/Available/{platform}/{activityType}/{dateRange}/{slotFilter}/{page}/ |  |

<a id="fireteamgetactiveprivateclanfireteamcount"></a>
# **FireteamGetActivePrivateClanFireteamCount**
> GroupV2EditGroup200Response FireteamGetActivePrivateClanFireteamCount (long groupId)



Gets a count of all active non-public fireteams for the specified clan. Maximum value returned is 25.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class FireteamGetActivePrivateClanFireteamCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FireteamApi(config);
            var groupId = 789L;  // long | The group id of the clan.

            try
            {
                GroupV2EditGroup200Response result = apiInstance.FireteamGetActivePrivateClanFireteamCount(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FireteamApi.FireteamGetActivePrivateClanFireteamCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FireteamGetActivePrivateClanFireteamCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.FireteamGetActivePrivateClanFireteamCountWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FireteamApi.FireteamGetActivePrivateClanFireteamCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | The group id of the clan. |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fireteamgetavailableclanfireteams"></a>
# **FireteamGetAvailableClanFireteams**
> FireteamGetAvailableClanFireteams200Response FireteamGetAvailableClanFireteams (int activityType, int dateRange, long groupId, int page, int platform, int publicOnly, int slotFilter, bool? excludeImmediate = null, string? langFilter = null)



Gets a listing of all of this clan's fireteams that are have available slots. Caller is not checked for join criteria so caching is maximized.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class FireteamGetAvailableClanFireteamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FireteamApi(config);
            var activityType = 56;  // int | The activity type to filter by.
            var dateRange = 56;  // int | The date range to grab available fireteams.
            var groupId = 789L;  // long | The group id of the clan.
            var page = 56;  // int | Zero based page
            var platform = 56;  // int | The platform filter.
            var publicOnly = 56;  // int | Determines public/private filtering.
            var slotFilter = 56;  // int | Filters based on available slots
            var excludeImmediate = true;  // bool? | If you wish the result to exclude immediate fireteams, set this to true. Immediate-only can be forced using the dateRange enum. (optional) 
            var langFilter = "langFilter_example";  // string? | An optional language filter. (optional) 

            try
            {
                FireteamGetAvailableClanFireteams200Response result = apiInstance.FireteamGetAvailableClanFireteams(activityType, dateRange, groupId, page, platform, publicOnly, slotFilter, excludeImmediate, langFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FireteamApi.FireteamGetAvailableClanFireteams: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FireteamGetAvailableClanFireteamsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FireteamGetAvailableClanFireteams200Response> response = apiInstance.FireteamGetAvailableClanFireteamsWithHttpInfo(activityType, dateRange, groupId, page, platform, publicOnly, slotFilter, excludeImmediate, langFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FireteamApi.FireteamGetAvailableClanFireteamsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activityType** | **int** | The activity type to filter by. |  |
| **dateRange** | **int** | The date range to grab available fireteams. |  |
| **groupId** | **long** | The group id of the clan. |  |
| **page** | **int** | Zero based page |  |
| **platform** | **int** | The platform filter. |  |
| **publicOnly** | **int** | Determines public/private filtering. |  |
| **slotFilter** | **int** | Filters based on available slots |  |
| **excludeImmediate** | **bool?** | If you wish the result to exclude immediate fireteams, set this to true. Immediate-only can be forced using the dateRange enum. | [optional]  |
| **langFilter** | **string?** | An optional language filter. | [optional]  |

### Return type

[**FireteamGetAvailableClanFireteams200Response**](FireteamGetAvailableClanFireteams200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fireteamgetclanfireteam"></a>
# **FireteamGetClanFireteam**
> FireteamGetClanFireteam200Response FireteamGetClanFireteam (long fireteamId, long groupId)



Gets a specific fireteam.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class FireteamGetClanFireteamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FireteamApi(config);
            var fireteamId = 789L;  // long | The unique id of the fireteam.
            var groupId = 789L;  // long | The group id of the clan.

            try
            {
                FireteamGetClanFireteam200Response result = apiInstance.FireteamGetClanFireteam(fireteamId, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FireteamApi.FireteamGetClanFireteam: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FireteamGetClanFireteamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FireteamGetClanFireteam200Response> response = apiInstance.FireteamGetClanFireteamWithHttpInfo(fireteamId, groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FireteamApi.FireteamGetClanFireteamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fireteamId** | **long** | The unique id of the fireteam. |  |
| **groupId** | **long** | The group id of the clan. |  |

### Return type

[**FireteamGetClanFireteam200Response**](FireteamGetClanFireteam200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fireteamgetmyclanfireteams"></a>
# **FireteamGetMyClanFireteams**
> FireteamGetMyClanFireteams200Response FireteamGetMyClanFireteams (long groupId, bool includeClosed, int page, int platform, bool? groupFilter = null, string? langFilter = null)



Gets a listing of all fireteams that caller is an applicant, a member, or an alternate of.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class FireteamGetMyClanFireteamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FireteamApi(config);
            var groupId = 789L;  // long | The group id of the clan. (This parameter is ignored unless the optional query parameter groupFilter is true).
            var includeClosed = true;  // bool | If true, return fireteams that have been closed.
            var page = 56;  // int | Deprecated parameter, ignored.
            var platform = 56;  // int | The platform filter.
            var groupFilter = true;  // bool? | If true, filter by clan. Otherwise, ignore the clan and show all of the user's fireteams. (optional) 
            var langFilter = "langFilter_example";  // string? | An optional language filter. (optional) 

            try
            {
                FireteamGetMyClanFireteams200Response result = apiInstance.FireteamGetMyClanFireteams(groupId, includeClosed, page, platform, groupFilter, langFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FireteamApi.FireteamGetMyClanFireteams: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FireteamGetMyClanFireteamsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FireteamGetMyClanFireteams200Response> response = apiInstance.FireteamGetMyClanFireteamsWithHttpInfo(groupId, includeClosed, page, platform, groupFilter, langFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FireteamApi.FireteamGetMyClanFireteamsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | The group id of the clan. (This parameter is ignored unless the optional query parameter groupFilter is true). |  |
| **includeClosed** | **bool** | If true, return fireteams that have been closed. |  |
| **page** | **int** | Deprecated parameter, ignored. |  |
| **platform** | **int** | The platform filter. |  |
| **groupFilter** | **bool?** | If true, filter by clan. Otherwise, ignore the clan and show all of the user&#39;s fireteams. | [optional]  |
| **langFilter** | **string?** | An optional language filter. | [optional]  |

### Return type

[**FireteamGetMyClanFireteams200Response**](FireteamGetMyClanFireteams200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fireteamsearchpublicavailableclanfireteams"></a>
# **FireteamSearchPublicAvailableClanFireteams**
> FireteamGetAvailableClanFireteams200Response FireteamSearchPublicAvailableClanFireteams (int activityType, int dateRange, int page, int platform, int slotFilter, bool? excludeImmediate = null, string? langFilter = null)



Gets a listing of all public fireteams starting now with open slots. Caller is not checked for join criteria so caching is maximized.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class FireteamSearchPublicAvailableClanFireteamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FireteamApi(config);
            var activityType = 56;  // int | The activity type to filter by.
            var dateRange = 56;  // int | The date range to grab available fireteams.
            var page = 56;  // int | Zero based page
            var platform = 56;  // int | The platform filter.
            var slotFilter = 56;  // int | Filters based on available slots
            var excludeImmediate = true;  // bool? | If you wish the result to exclude immediate fireteams, set this to true. Immediate-only can be forced using the dateRange enum. (optional) 
            var langFilter = "langFilter_example";  // string? | An optional language filter. (optional) 

            try
            {
                FireteamGetAvailableClanFireteams200Response result = apiInstance.FireteamSearchPublicAvailableClanFireteams(activityType, dateRange, page, platform, slotFilter, excludeImmediate, langFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FireteamApi.FireteamSearchPublicAvailableClanFireteams: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FireteamSearchPublicAvailableClanFireteamsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FireteamGetAvailableClanFireteams200Response> response = apiInstance.FireteamSearchPublicAvailableClanFireteamsWithHttpInfo(activityType, dateRange, page, platform, slotFilter, excludeImmediate, langFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FireteamApi.FireteamSearchPublicAvailableClanFireteamsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activityType** | **int** | The activity type to filter by. |  |
| **dateRange** | **int** | The date range to grab available fireteams. |  |
| **page** | **int** | Zero based page |  |
| **platform** | **int** | The platform filter. |  |
| **slotFilter** | **int** | Filters based on available slots |  |
| **excludeImmediate** | **bool?** | If you wish the result to exclude immediate fireteams, set this to true. Immediate-only can be forced using the dateRange enum. | [optional]  |
| **langFilter** | **string?** | An optional language filter. | [optional]  |

### Return type

[**FireteamGetAvailableClanFireteams200Response**](FireteamGetAvailableClanFireteams200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

