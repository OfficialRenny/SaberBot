# WarframeMarket.Api.ItemsApi

All URIs are relative to *https://api.warframe.market/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetItemInfo**](ItemsApi.md#getiteminfo) | **GET** /items/{url_name} | Gets information about an item |
| [**ItemsGet**](ItemsApi.md#itemsget) | **GET** /items | Get list of all tradable items. |
| [**ItemsUrlNameDropsourcesGet**](ItemsApi.md#itemsurlnamedropsourcesget) | **GET** /items/{url_name}/dropsources | Get dropsources for a given item |
| [**ItemsUrlNameOrdersGet**](ItemsApi.md#itemsurlnameordersget) | **GET** /items/{url_name}/orders | Get list of orders for a given item_id |

<a id="getiteminfo"></a>
# **GetItemInfo**
> GetItemInfo200Response GetItemInfo (string urlName, string? platform = null)

Gets information about an item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class GetItemInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new ItemsApi(config);
            var urlName = mirage_prime_systems;  // string | url_name of an item
            var platform = "xbox";  // string? | Asks the server to return content for specified platform, default: `pc`.  (optional) 

            try
            {
                // Gets information about an item
                GetItemInfo200Response result = apiInstance.GetItemInfo(urlName, platform);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.GetItemInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets information about an item
    ApiResponse<GetItemInfo200Response> response = apiInstance.GetItemInfoWithHttpInfo(urlName, platform);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemsApi.GetItemInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlName** | **string** | url_name of an item |  |
| **platform** | **string?** | Asks the server to return content for specified platform, default: &#x60;pc&#x60;.  | [optional]  |

### Return type

[**GetItemInfo200Response**](GetItemInfo200Response.md)

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

<a id="itemsget"></a>
# **ItemsGet**
> ItemsGet200Response ItemsGet (string? language = null)

Get list of all tradable items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class ItemsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new ItemsApi(config);
            var language = "en";  // string? | Asks the server to return content translated into the specified language, default: `en`.  (optional) 

            try
            {
                // Get list of all tradable items.
                ItemsGet200Response result = apiInstance.ItemsGet(language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.ItemsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ItemsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of all tradable items.
    ApiResponse<ItemsGet200Response> response = apiInstance.ItemsGetWithHttpInfo(language);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemsApi.ItemsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **language** | **string?** | Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  | [optional]  |

### Return type

[**ItemsGet200Response**](ItemsGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Succesfull |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="itemsurlnamedropsourcesget"></a>
# **ItemsUrlNameDropsourcesGet**
> ItemsUrlNameDropsourcesGet200Response ItemsUrlNameDropsourcesGet (string urlName, string? language = null, string? include = null)

Get dropsources for a given item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class ItemsUrlNameDropsourcesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new ItemsApi(config);
            var urlName = mirage_prime_systems;  // string | url_name of an item
            var language = "en";  // string? | Asks the server to return content translated into the specified language, default: `en`.  (optional) 
            var include = "item";  // string? | Include additional information. Will add a new response section with all information about requested model.  (optional) 

            try
            {
                // Get dropsources for a given item
                ItemsUrlNameDropsourcesGet200Response result = apiInstance.ItemsUrlNameDropsourcesGet(urlName, language, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.ItemsUrlNameDropsourcesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ItemsUrlNameDropsourcesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get dropsources for a given item
    ApiResponse<ItemsUrlNameDropsourcesGet200Response> response = apiInstance.ItemsUrlNameDropsourcesGetWithHttpInfo(urlName, language, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemsApi.ItemsUrlNameDropsourcesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlName** | **string** | url_name of an item |  |
| **language** | **string?** | Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  | [optional]  |
| **include** | **string?** | Include additional information. Will add a new response section with all information about requested model.  | [optional]  |

### Return type

[**ItemsUrlNameDropsourcesGet200Response**](ItemsUrlNameDropsourcesGet200Response.md)

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

<a id="itemsurlnameordersget"></a>
# **ItemsUrlNameOrdersGet**
> ItemsUrlNameOrdersGet200Response ItemsUrlNameOrdersGet (string urlName, string? platform = null, string? include = null)

Get list of orders for a given item_id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class ItemsUrlNameOrdersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new ItemsApi(config);
            var urlName = mirage_prime_systems;  // string | url_name of an item
            var platform = "xbox";  // string? | Asks the server to return content for specified platform, default: `pc`.  (optional) 
            var include = "item";  // string? | Include additional information. Will add a new response section with all information about requested model.  (optional) 

            try
            {
                // Get list of orders for a given item_id
                ItemsUrlNameOrdersGet200Response result = apiInstance.ItemsUrlNameOrdersGet(urlName, platform, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.ItemsUrlNameOrdersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ItemsUrlNameOrdersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of orders for a given item_id
    ApiResponse<ItemsUrlNameOrdersGet200Response> response = apiInstance.ItemsUrlNameOrdersGetWithHttpInfo(urlName, platform, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemsApi.ItemsUrlNameOrdersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlName** | **string** | url_name of an item |  |
| **platform** | **string?** | Asks the server to return content for specified platform, default: &#x60;pc&#x60;.  | [optional]  |
| **include** | **string?** | Include additional information. Will add a new response section with all information about requested model.  | [optional]  |

### Return type

[**ItemsUrlNameOrdersGet200Response**](ItemsUrlNameOrdersGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation, with &#x60;?include&#x3D;item&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

