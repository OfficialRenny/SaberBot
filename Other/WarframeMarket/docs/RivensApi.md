# WarframeMarket.Api.RivensApi

All URIs are relative to *https://api.warframe.market/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RivenAttributesGet**](RivensApi.md#rivenattributesget) | **GET** /riven/attributes | Get a list of riven attributes. |
| [**RivenItemsGet**](RivensApi.md#rivenitemsget) | **GET** /riven/items | Get a list of riven items. |

<a id="rivenattributesget"></a>
# **RivenAttributesGet**
> RivenAttributesGet200Response RivenAttributesGet (string? language = null)

Get a list of riven attributes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class RivenAttributesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new RivensApi(config);
            var language = "en";  // string? | Asks the server to return content translated into the specified language, default: `en`.  (optional) 

            try
            {
                // Get a list of riven attributes.
                RivenAttributesGet200Response result = apiInstance.RivenAttributesGet(language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RivensApi.RivenAttributesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RivenAttributesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of riven attributes.
    ApiResponse<RivenAttributesGet200Response> response = apiInstance.RivenAttributesGetWithHttpInfo(language);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RivensApi.RivenAttributesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string?** | Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  | [optional]  |

### Return type

[**RivenAttributesGet200Response**](RivenAttributesGet200Response.md)

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

<a id="rivenitemsget"></a>
# **RivenItemsGet**
> RivenItemsGet200Response RivenItemsGet (string? language = null)

Get a list of riven items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class RivenItemsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new RivensApi(config);
            var language = "en";  // string? | Asks the server to return content translated into the specified language, default: `en`.  (optional) 

            try
            {
                // Get a list of riven items.
                RivenItemsGet200Response result = apiInstance.RivenItemsGet(language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RivensApi.RivenItemsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RivenItemsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of riven items.
    ApiResponse<RivenItemsGet200Response> response = apiInstance.RivenItemsGetWithHttpInfo(language);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RivensApi.RivenItemsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string?** | Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  | [optional]  |

### Return type

[**RivenItemsGet200Response**](RivenItemsGet200Response.md)

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

