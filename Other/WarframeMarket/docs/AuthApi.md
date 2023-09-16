# WarframeMarket.Api.AuthApi

All URIs are relative to *https://api.warframe.market/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthRegistrationPost**](AuthApi.md#authregistrationpost) | **POST** /auth/registration | Registration of new user and their device. |
| [**AuthRestorePost**](AuthApi.md#authrestorepost) | **POST** /auth/restore | Password restoration. |
| [**AuthSigninPost**](AuthApi.md#authsigninpost) | **POST** /auth/signin | Simple login. |

<a id="authregistrationpost"></a>
# **AuthRegistrationPost**
> CurrentUser AuthRegistrationPost (AuthRegistrationPostRequest authRegistrationPostRequest)

Registration of new user and their device.

There is 2 types of registration, for web browser and for Android device. Android device could avoid to include reCaptha toke by using secret DeviceKey in the request headers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class AuthRegistrationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new AuthApi(config);
            var authRegistrationPostRequest = new AuthRegistrationPostRequest(); // AuthRegistrationPostRequest | 

            try
            {
                // Registration of new user and their device.
                CurrentUser result = apiInstance.AuthRegistrationPost(authRegistrationPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthRegistrationPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRegistrationPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Registration of new user and their device.
    ApiResponse<CurrentUser> response = apiInstance.AuthRegistrationPostWithHttpInfo(authRegistrationPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthRegistrationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authRegistrationPostRequest** | [**AuthRegistrationPostRequest**](AuthRegistrationPostRequest.md) |  |  |

### Return type

[**CurrentUser**](CurrentUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON representation of currentUser |  * Set-Cookie - If you used auth_type&#x60;&#x3D;&#x60;cookie&#x60;, for web-browser <br>  * Authorization - If you used auth_type&#x60;&#x3D;&#x60;header&#x60;, for devices <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authrestorepost"></a>
# **AuthRestorePost**
> Object AuthRestorePost (AuthRestorePostRequest authRestorePostRequest)

Password restoration.

You will recieve mail with the new password, short after api call.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class AuthRestorePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new AuthApi(config);
            var authRestorePostRequest = new AuthRestorePostRequest(); // AuthRestorePostRequest | 

            try
            {
                // Password restoration.
                Object result = apiInstance.AuthRestorePost(authRestorePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthRestorePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRestorePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Password restoration.
    ApiResponse<Object> response = apiInstance.AuthRestorePostWithHttpInfo(authRestorePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthRestorePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authRestorePostRequest** | [**AuthRestorePostRequest**](AuthRestorePostRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Empty object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authsigninpost"></a>
# **AuthSigninPost**
> CurrentUser AuthSigninPost (AuthSigninPostRequest authSigninPostRequest)

Simple login.

There is 2 ways to maintain authorization: - Through Cookie for Web browsers. - Through Header for other devices. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class AuthSigninPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new AuthApi(config);
            var authSigninPostRequest = new AuthSigninPostRequest(); // AuthSigninPostRequest | 

            try
            {
                // Simple login.
                CurrentUser result = apiInstance.AuthSigninPost(authSigninPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthSigninPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthSigninPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Simple login.
    ApiResponse<CurrentUser> response = apiInstance.AuthSigninPostWithHttpInfo(authSigninPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthSigninPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authSigninPostRequest** | [**AuthSigninPostRequest**](AuthSigninPostRequest.md) |  |  |

### Return type

[**CurrentUser**](CurrentUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON representation of currentUser |  * Set-Cookie - If you used auth_type&#x60;&#x3D;&#x60;cookie&#x60;, for web-browser <br>  * Authorization - If you used auth_type&#x60;&#x3D;&#x60;header&#x60;, for devices <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

