# WarframeMarket.Api.AuctionEntryApi

All URIs are relative to *https://api.warframe.market/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuctionsEntryAuctionIdBidsGet**](AuctionEntryApi.md#auctionsentryauctionidbidsget) | **GET** /auctions/entry/{auction_id}/bids | Gets auction bids by auction Id |
| [**AuctionsEntryAuctionIdGet**](AuctionEntryApi.md#auctionsentryauctionidget) | **GET** /auctions/entry/{auction_id} | Gets information about auction by auction Id |

<a id="auctionsentryauctionidbidsget"></a>
# **AuctionsEntryAuctionIdBidsGet**
> AuctionsEntryAuctionIdBidsGet200Response AuctionsEntryAuctionIdBidsGet (string auctionId, string? include = null)

Gets auction bids by auction Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class AuctionsEntryAuctionIdBidsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new AuctionEntryApi(config);
            var auctionId = "auctionId_example";  // string | ObjectId of auction
            var include = "auction";  // string? | Include additional information.   Will add a new response section with all information about requested model.  (optional) 

            try
            {
                // Gets auction bids by auction Id
                AuctionsEntryAuctionIdBidsGet200Response result = apiInstance.AuctionsEntryAuctionIdBidsGet(auctionId, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuctionEntryApi.AuctionsEntryAuctionIdBidsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuctionsEntryAuctionIdBidsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets auction bids by auction Id
    ApiResponse<AuctionsEntryAuctionIdBidsGet200Response> response = apiInstance.AuctionsEntryAuctionIdBidsGetWithHttpInfo(auctionId, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuctionEntryApi.AuctionsEntryAuctionIdBidsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **auctionId** | **string** | ObjectId of auction |  |
| **include** | **string?** | Include additional information.   Will add a new response section with all information about requested model.  | [optional]  |

### Return type

[**AuctionsEntryAuctionIdBidsGet200Response**](AuctionsEntryAuctionIdBidsGet200Response.md)

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

<a id="auctionsentryauctionidget"></a>
# **AuctionsEntryAuctionIdGet**
> AuctionsEntryAuctionIdGet200Response AuctionsEntryAuctionIdGet (string auctionId)

Gets information about auction by auction Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class AuctionsEntryAuctionIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new AuctionEntryApi(config);
            var auctionId = "auctionId_example";  // string | ObjectId of auction

            try
            {
                // Gets information about auction by auction Id
                AuctionsEntryAuctionIdGet200Response result = apiInstance.AuctionsEntryAuctionIdGet(auctionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuctionEntryApi.AuctionsEntryAuctionIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuctionsEntryAuctionIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets information about auction by auction Id
    ApiResponse<AuctionsEntryAuctionIdGet200Response> response = apiInstance.AuctionsEntryAuctionIdGetWithHttpInfo(auctionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuctionEntryApi.AuctionsEntryAuctionIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **auctionId** | **string** | ObjectId of auction |  |

### Return type

[**AuctionsEntryAuctionIdGet200Response**](AuctionsEntryAuctionIdGet200Response.md)

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

