# WarframeMarket.Api.PushNotificationsApi

All URIs are relative to *https://api.warframe.market/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SettingsNotificationsPushDelete**](PushNotificationsApi.md#settingsnotificationspushdelete) | **DELETE** /settings/notifications/push | Push Unsubscribe |
| [**SettingsNotificationsPushGet**](PushNotificationsApi.md#settingsnotificationspushget) | **GET** /settings/notifications/push | Get subscription |
| [**SettingsNotificationsPushPost**](PushNotificationsApi.md#settingsnotificationspushpost) | **POST** /settings/notifications/push | Push subscribe |

<a id="settingsnotificationspushdelete"></a>
# **SettingsNotificationsPushDelete**
> SettingsNotificationsPushPost200Response SettingsNotificationsPushDelete ()

Push Unsubscribe

Unflag `subscribed` in our DB from currentUser.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class SettingsNotificationsPushDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("JWT", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("JWT", "Bearer");
            // Configure API key authorization: JWTHeader
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PushNotificationsApi(config);

            try
            {
                // Push Unsubscribe
                SettingsNotificationsPushPost200Response result = apiInstance.SettingsNotificationsPushDelete();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PushNotificationsApi.SettingsNotificationsPushDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SettingsNotificationsPushDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Push Unsubscribe
    ApiResponse<SettingsNotificationsPushPost200Response> response = apiInstance.SettingsNotificationsPushDeleteWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PushNotificationsApi.SettingsNotificationsPushDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SettingsNotificationsPushPost200Response**](SettingsNotificationsPushPost200Response.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [JWTHeader](../README.md#JWTHeader)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="settingsnotificationspushget"></a>
# **SettingsNotificationsPushGet**
> void SettingsNotificationsPushGet ()

Get subscription

Not implemented

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class SettingsNotificationsPushGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("JWT", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("JWT", "Bearer");
            // Configure API key authorization: JWTHeader
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PushNotificationsApi(config);

            try
            {
                // Get subscription
                apiInstance.SettingsNotificationsPushGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PushNotificationsApi.SettingsNotificationsPushGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SettingsNotificationsPushGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get subscription
    apiInstance.SettingsNotificationsPushGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PushNotificationsApi.SettingsNotificationsPushGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[CookieAuth](../README.md#CookieAuth), [JWTHeader](../README.md#JWTHeader)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Nothing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="settingsnotificationspushpost"></a>
# **SettingsNotificationsPushPost**
> SettingsNotificationsPushPost200Response SettingsNotificationsPushPost (SettingsNotificationsPushPostRequest? settingsNotificationsPushPostRequest = null)

Push subscribe

There is 3 formats, for web for android   Web usage: - -- -- -- -- ``` {     'device': 'web'     'subscription':         {         \"endpointeger\":\"https://fcm.googleapis.com/fcm/send/...\",         \"keys\":{             \"p256dh\":\"BBya_RhGe...\",             \"auth\":\"2PFoLO3K...\"             }         } } ```  Android usage: - -- -- -- -- ```   {     'device': 'android'     'subscription':         {         \"push_token\":\"asdnOIHSD2134...\"         } } ``` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class SettingsNotificationsPushPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("JWT", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("JWT", "Bearer");
            // Configure API key authorization: JWTHeader
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PushNotificationsApi(config);
            var settingsNotificationsPushPostRequest = new SettingsNotificationsPushPostRequest?(); // SettingsNotificationsPushPostRequest? |  (optional) 

            try
            {
                // Push subscribe
                SettingsNotificationsPushPost200Response result = apiInstance.SettingsNotificationsPushPost(settingsNotificationsPushPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PushNotificationsApi.SettingsNotificationsPushPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SettingsNotificationsPushPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Push subscribe
    ApiResponse<SettingsNotificationsPushPost200Response> response = apiInstance.SettingsNotificationsPushPostWithHttpInfo(settingsNotificationsPushPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PushNotificationsApi.SettingsNotificationsPushPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settingsNotificationsPushPostRequest** | [**SettingsNotificationsPushPostRequest?**](SettingsNotificationsPushPostRequest?.md) |  | [optional]  |

### Return type

[**SettingsNotificationsPushPost200Response**](SettingsNotificationsPushPost200Response.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [JWTHeader](../README.md#JWTHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

