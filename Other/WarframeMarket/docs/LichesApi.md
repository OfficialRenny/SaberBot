# WarframeMarket.Api.LichesApi

All URIs are relative to *https://api.warframe.market/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LichEphemerasGet**](LichesApi.md#lichephemerasget) | **GET** /lich/ephemeras | Get a list of lich ephemeras. |
| [**LichQuirksGet**](LichesApi.md#lichquirksget) | **GET** /lich/quirks | Get a list of lich quirks. |
| [**LichWeaponsGet**](LichesApi.md#lichweaponsget) | **GET** /lich/weapons | Get a list of lich weapons. |

<a id="lichephemerasget"></a>
# **LichEphemerasGet**
> LichEphemerasGet200Response LichEphemerasGet (string? language = null)

Get a list of lich ephemeras.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class LichEphemerasGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new LichesApi(config);
            var language = "en";  // string? | Asks the server to return content translated into the specified language, default: `en`.  (optional) 

            try
            {
                // Get a list of lich ephemeras.
                LichEphemerasGet200Response result = apiInstance.LichEphemerasGet(language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LichesApi.LichEphemerasGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LichEphemerasGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of lich ephemeras.
    ApiResponse<LichEphemerasGet200Response> response = apiInstance.LichEphemerasGetWithHttpInfo(language);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LichesApi.LichEphemerasGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string?** | Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  | [optional]  |

### Return type

[**LichEphemerasGet200Response**](LichEphemerasGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="lichquirksget"></a>
# **LichQuirksGet**
> LichQuirksGet200Response LichQuirksGet (string? language = null)

Get a list of lich quirks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class LichQuirksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new LichesApi(config);
            var language = "en";  // string? | Asks the server to return content translated into the specified language, default: `en`.  (optional) 

            try
            {
                // Get a list of lich quirks.
                LichQuirksGet200Response result = apiInstance.LichQuirksGet(language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LichesApi.LichQuirksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LichQuirksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of lich quirks.
    ApiResponse<LichQuirksGet200Response> response = apiInstance.LichQuirksGetWithHttpInfo(language);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LichesApi.LichQuirksGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string?** | Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  | [optional]  |

### Return type

[**LichQuirksGet200Response**](LichQuirksGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="lichweaponsget"></a>
# **LichWeaponsGet**
> LichWeaponsGet200Response LichWeaponsGet (string? language = null)

Get a list of lich weapons.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class LichWeaponsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new LichesApi(config);
            var language = "en";  // string? | Asks the server to return content translated into the specified language, default: `en`.  (optional) 

            try
            {
                // Get a list of lich weapons.
                LichWeaponsGet200Response result = apiInstance.LichWeaponsGet(language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LichesApi.LichWeaponsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LichWeaponsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of lich weapons.
    ApiResponse<LichWeaponsGet200Response> response = apiInstance.LichWeaponsGetWithHttpInfo(language);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LichesApi.LichWeaponsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string?** | Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  | [optional]  |

### Return type

[**LichWeaponsGet200Response**](LichWeaponsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

