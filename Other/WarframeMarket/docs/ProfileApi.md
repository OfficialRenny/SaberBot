# WarframeMarket.Api.ProfileApi

All URIs are relative to *https://api.warframe.market/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProfileOrdersPost**](ProfileApi.md#profileorderspost) | **POST** /profile/orders | Create an order |

<a id="profileorderspost"></a>
# **ProfileOrdersPost**
> ProfileOrdersPost200Response ProfileOrdersPost (ProfileOrdersPostRequest profileOrdersPostRequest, string? language = null)

Create an order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class ProfileOrdersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new ProfileApi(config);
            var profileOrdersPostRequest = new ProfileOrdersPostRequest(); // ProfileOrdersPostRequest | 
            var language = "en";  // string? | Asks the server to return content translated into the specified language, default: `en`.  (optional) 

            try
            {
                // Create an order
                ProfileOrdersPost200Response result = apiInstance.ProfileOrdersPost(profileOrdersPostRequest, language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ProfileOrdersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileOrdersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an order
    ApiResponse<ProfileOrdersPost200Response> response = apiInstance.ProfileOrdersPostWithHttpInfo(profileOrdersPostRequest, language);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.ProfileOrdersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileOrdersPostRequest** | [**ProfileOrdersPostRequest**](ProfileOrdersPostRequest.md) |  |  |
| **language** | **string?** | Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  | [optional]  |

### Return type

[**ProfileOrdersPost200Response**](ProfileOrdersPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

