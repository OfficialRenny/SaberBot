# Destiny.Api.AppApi

All URIs are relative to *https://www.bungie.net/Platform*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppGetApplicationApiUsage**](AppApi.md#appgetapplicationapiusage) | **GET** /App/ApiUsage/{applicationId}/ |  |
| [**AppGetBungieApplications**](AppApi.md#appgetbungieapplications) | **GET** /App/FirstParty/ |  |

<a id="appgetapplicationapiusage"></a>
# **AppGetApplicationApiUsage**
> AppGetApplicationApiUsage200Response AppGetApplicationApiUsage (int applicationId, DateTime? end = null, DateTime? start = null)



Get API usage by application for time frame specified. You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class AppGetApplicationApiUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppApi(config);
            var applicationId = 56;  // int | ID of the application to get usage statistics.
            var end = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | End time for query. Goes to now if not specified. (optional) 
            var start = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Start time for query. Goes to 24 hours ago if not specified. (optional) 

            try
            {
                AppGetApplicationApiUsage200Response result = apiInstance.AppGetApplicationApiUsage(applicationId, end, start);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppApi.AppGetApplicationApiUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppGetApplicationApiUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppGetApplicationApiUsage200Response> response = apiInstance.AppGetApplicationApiUsageWithHttpInfo(applicationId, end, start);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppApi.AppGetApplicationApiUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **int** | ID of the application to get usage statistics. |  |
| **end** | **DateTime?** | End time for query. Goes to now if not specified. | [optional]  |
| **start** | **DateTime?** | Start time for query. Goes to 24 hours ago if not specified. | [optional]  |

### Return type

[**AppGetApplicationApiUsage200Response**](AppGetApplicationApiUsage200Response.md)

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

<a id="appgetbungieapplications"></a>
# **AppGetBungieApplications**
> AppGetBungieApplications200Response AppGetBungieApplications ()



Get list of applications created by Bungie.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class AppGetBungieApplicationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new AppApi(config);

            try
            {
                AppGetBungieApplications200Response result = apiInstance.AppGetBungieApplications();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppApi.AppGetBungieApplications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppGetBungieApplicationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppGetBungieApplications200Response> response = apiInstance.AppGetBungieApplicationsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppApi.AppGetBungieApplicationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AppGetBungieApplications200Response**](AppGetBungieApplications200Response.md)

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

