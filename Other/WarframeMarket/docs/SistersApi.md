# WarframeMarket.Api.SistersApi

All URIs are relative to *https://api.warframe.market/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SisterEphermerasGet**](SistersApi.md#sisterephermerasget) | **GET** /sister/ephermeras | Get a list of sister ephemras. |
| [**SisterQuirksGet**](SistersApi.md#sisterquirksget) | **GET** /sister/quirks | Get a list of sister quirks. |
| [**SisterWeaponsGet**](SistersApi.md#sisterweaponsget) | **GET** /sister/weapons | Get a list of sister weapons. |

<a id="sisterephermerasget"></a>
# **SisterEphermerasGet**
> LichEphemerasGet200Response SisterEphermerasGet (string? language = null)

Get a list of sister ephemras.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class SisterEphermerasGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new SistersApi(config);
            var language = "en";  // string? | Asks the server to return content translated into the specified language, default: `en`.  (optional) 

            try
            {
                // Get a list of sister ephemras.
                LichEphemerasGet200Response result = apiInstance.SisterEphermerasGet(language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SistersApi.SisterEphermerasGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SisterEphermerasGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of sister ephemras.
    ApiResponse<LichEphemerasGet200Response> response = apiInstance.SisterEphermerasGetWithHttpInfo(language);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SistersApi.SisterEphermerasGetWithHttpInfo: " + e.Message);
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

<a id="sisterquirksget"></a>
# **SisterQuirksGet**
> LichQuirksGet200Response SisterQuirksGet (string? language = null)

Get a list of sister quirks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class SisterQuirksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new SistersApi(config);
            var language = "en";  // string? | Asks the server to return content translated into the specified language, default: `en`.  (optional) 

            try
            {
                // Get a list of sister quirks.
                LichQuirksGet200Response result = apiInstance.SisterQuirksGet(language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SistersApi.SisterQuirksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SisterQuirksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of sister quirks.
    ApiResponse<LichQuirksGet200Response> response = apiInstance.SisterQuirksGetWithHttpInfo(language);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SistersApi.SisterQuirksGetWithHttpInfo: " + e.Message);
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

<a id="sisterweaponsget"></a>
# **SisterWeaponsGet**
> LichWeaponsGet200Response SisterWeaponsGet (string? language = null)

Get a list of sister weapons.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class SisterWeaponsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new SistersApi(config);
            var language = "en";  // string? | Asks the server to return content translated into the specified language, default: `en`.  (optional) 

            try
            {
                // Get a list of sister weapons.
                LichWeaponsGet200Response result = apiInstance.SisterWeaponsGet(language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SistersApi.SisterWeaponsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SisterWeaponsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of sister weapons.
    ApiResponse<LichWeaponsGet200Response> response = apiInstance.SisterWeaponsGetWithHttpInfo(language);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SistersApi.SisterWeaponsGetWithHttpInfo: " + e.Message);
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

