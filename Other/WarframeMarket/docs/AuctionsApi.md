# WarframeMarket.Api.AuctionsApi

All URIs are relative to *https://api.warframe.market/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuctionsCreatePost**](AuctionsApi.md#auctionscreatepost) | **POST** /auctions/create | ⚠ Auction creation. |
| [**AuctionsSearchtypelichGet**](AuctionsApi.md#auctionssearchtypelichget) | **GET** /auctions/search?type&#x3D;lich | Get a list of lich auctions by given search params. |
| [**AuctionsSearchtyperivenGet**](AuctionsApi.md#auctionssearchtyperivenget) | **GET** /auctions/search?type&#x3D;riven | Get a list of riven auctions by given search params. |

<a id="auctionscreatepost"></a>
# **AuctionsCreatePost**
> AuctionsCreatePost200Response AuctionsCreatePost (AuctionsCreatePostRequest auctionsCreatePostRequest)

⚠ Auction creation.

Create auction, for riven or lich item types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class AuctionsCreatePostExample
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

            var apiInstance = new AuctionsApi(config);
            var auctionsCreatePostRequest = new AuctionsCreatePostRequest(); // AuctionsCreatePostRequest | Info about auction and item

            try
            {
                // ⚠ Auction creation.
                AuctionsCreatePost200Response result = apiInstance.AuctionsCreatePost(auctionsCreatePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuctionsApi.AuctionsCreatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuctionsCreatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ⚠ Auction creation.
    ApiResponse<AuctionsCreatePost200Response> response = apiInstance.AuctionsCreatePostWithHttpInfo(auctionsCreatePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuctionsApi.AuctionsCreatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **auctionsCreatePostRequest** | [**AuctionsCreatePostRequest**](AuctionsCreatePostRequest.md) | Info about auction and item |  |

### Return type

[**AuctionsCreatePost200Response**](AuctionsCreatePost200Response.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [JWTHeader](../README.md#JWTHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="auctionssearchtypelichget"></a>
# **AuctionsSearchtypelichGet**
> AuctionsSearchTypeRivenGet200Response AuctionsSearchtypelichGet (string? platform = null, string? buyoutPolicy = null, string? weaponUrlName = null, Element? element = null, bool? ephemera = null, int? damageMin = null, int? damageMax = null, string? quirk = null, string? sortBy = null)

Get a list of lich auctions by given search params.

Auctions from banned users will be excluded. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class AuctionsSearchtypelichGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new AuctionsApi(config);
            var platform = "xbox";  // string? | Asks the server to return content for specified platform, default: `pc`.  (optional) 
            var buyoutPolicy = "with";  // string? | auction type, if not specified implied: all (optional) 
            var weaponUrlName = "weaponUrlName_example";  // string? | lich weapon `url_name` property (optional) 
            var element = new Element?(); // Element? | lich element (optional) 
            var ephemera = true;  // bool? | lich is having ephemera   ephemera is based on lich element.  (optional) 
            var damageMin = 56;  // int? | Minimum bonus damage value of desirable lich (optional) 
            var damageMax = 56;  // int? | Minimum bonus damage value of desirable lich (optional) 
            var quirk = "quirk_example";  // string? | Lich quirk `url_name` property (optional) 
            var sortBy = "price_desc";  // string? | Sorting, by prices or by weapon damage bonus value, ascending and descending. (optional) 

            try
            {
                // Get a list of lich auctions by given search params.
                AuctionsSearchTypeRivenGet200Response result = apiInstance.AuctionsSearchtypelichGet(platform, buyoutPolicy, weaponUrlName, element, ephemera, damageMin, damageMax, quirk, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuctionsApi.AuctionsSearchtypelichGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuctionsSearchtypelichGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of lich auctions by given search params.
    ApiResponse<AuctionsSearchTypeRivenGet200Response> response = apiInstance.AuctionsSearchtypelichGetWithHttpInfo(platform, buyoutPolicy, weaponUrlName, element, ephemera, damageMin, damageMax, quirk, sortBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuctionsApi.AuctionsSearchtypelichGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **platform** | **string?** | Asks the server to return content for specified platform, default: &#x60;pc&#x60;.  | [optional]  |
| **buyoutPolicy** | **string?** | auction type, if not specified implied: all | [optional]  |
| **weaponUrlName** | **string?** | lich weapon &#x60;url_name&#x60; property | [optional]  |
| **element** | [**Element?**](Element?.md) | lich element | [optional]  |
| **ephemera** | **bool?** | lich is having ephemera   ephemera is based on lich element.  | [optional]  |
| **damageMin** | **int?** | Minimum bonus damage value of desirable lich | [optional]  |
| **damageMax** | **int?** | Minimum bonus damage value of desirable lich | [optional]  |
| **quirk** | **string?** | Lich quirk &#x60;url_name&#x60; property | [optional]  |
| **sortBy** | **string?** | Sorting, by prices or by weapon damage bonus value, ascending and descending. | [optional]  |

### Return type

[**AuctionsSearchTypeRivenGet200Response**](AuctionsSearchTypeRivenGet200Response.md)

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

<a id="auctionssearchtyperivenget"></a>
# **AuctionsSearchtyperivenGet**
> AuctionsSearchTypeRivenGet200Response AuctionsSearchtyperivenGet (string? platform = null, string? buyoutPolicy = null, string? weaponUrlName = null, string? positiveStats = null, string? negativeStats = null, string? operation = null, int? masteryRankMin = null, int? masteryRankMax = null, int? reRollsMin = null, int? reRollsMax = null, string? modRank = null, string? polarity = null, string? sortBy = null)

Get a list of riven auctions by given search params.

Auctions from banned users will be excluded.   You must specify weapon or one positive atttribute, at least. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using WarframeMarket.Api;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace Example
{
    public class AuctionsSearchtyperivenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.warframe.market/v1";
            var apiInstance = new AuctionsApi(config);
            var platform = "xbox";  // string? | Asks the server to return content for specified platform, default: `pc`.  (optional) 
            var buyoutPolicy = "with";  // string? | auction type, if not specified implied: all (optional) 
            var weaponUrlName = "weaponUrlName_example";  // string? | riven weapon `url_name` property (optional) 
            var positiveStats = "positiveStats_example";  // string? | Positive attributes in for of string: `attr1,attr2,attr3`  (optional) 
            var negativeStats = "negativeStats_example";  // string? | Negative attributes in for of string: `attr1,attr2,attr3` For None use the string: `None`  (optional) 
            var operation = "anyOf";  // string? | Not used on the frontend right now, becuse this is not a very usefull flag. Used in conjuction with positive stats, like:  - `allOf` will get riven auction that contains all of defined positive attributes - `anyOf` will get riven auction that contains any of defined positive attributes  Default value is `allOf`  (optional) 
            var masteryRankMin = 56;  // int? | Minimum rank value of riven mod (optional) 
            var masteryRankMax = 56;  // int? | Maximum rank value of riven mod (optional) 
            var reRollsMin = 56;  // int? | Minimum amount of rolls (optional) 
            var reRollsMax = 56;  // int? | Maximum amount of rolls (optional) 
            var modRank = "any";  // string? | Should mod be maxed or whatever. (optional) 
            var polarity = "madurai";  // string? |  (optional) 
            var sortBy = "price_desc";  // string? | Sorting, by prices or by attributes value, ascending and descending. (optional) 

            try
            {
                // Get a list of riven auctions by given search params.
                AuctionsSearchTypeRivenGet200Response result = apiInstance.AuctionsSearchtyperivenGet(platform, buyoutPolicy, weaponUrlName, positiveStats, negativeStats, operation, masteryRankMin, masteryRankMax, reRollsMin, reRollsMax, modRank, polarity, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuctionsApi.AuctionsSearchtyperivenGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuctionsSearchtyperivenGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of riven auctions by given search params.
    ApiResponse<AuctionsSearchTypeRivenGet200Response> response = apiInstance.AuctionsSearchtyperivenGetWithHttpInfo(platform, buyoutPolicy, weaponUrlName, positiveStats, negativeStats, operation, masteryRankMin, masteryRankMax, reRollsMin, reRollsMax, modRank, polarity, sortBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuctionsApi.AuctionsSearchtyperivenGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **platform** | **string?** | Asks the server to return content for specified platform, default: &#x60;pc&#x60;.  | [optional]  |
| **buyoutPolicy** | **string?** | auction type, if not specified implied: all | [optional]  |
| **weaponUrlName** | **string?** | riven weapon &#x60;url_name&#x60; property | [optional]  |
| **positiveStats** | **string?** | Positive attributes in for of string: &#x60;attr1,attr2,attr3&#x60;  | [optional]  |
| **negativeStats** | **string?** | Negative attributes in for of string: &#x60;attr1,attr2,attr3&#x60; For None use the string: &#x60;None&#x60;  | [optional]  |
| **operation** | **string?** | Not used on the frontend right now, becuse this is not a very usefull flag. Used in conjuction with positive stats, like:  - &#x60;allOf&#x60; will get riven auction that contains all of defined positive attributes - &#x60;anyOf&#x60; will get riven auction that contains any of defined positive attributes  Default value is &#x60;allOf&#x60;  | [optional]  |
| **masteryRankMin** | **int?** | Minimum rank value of riven mod | [optional]  |
| **masteryRankMax** | **int?** | Maximum rank value of riven mod | [optional]  |
| **reRollsMin** | **int?** | Minimum amount of rolls | [optional]  |
| **reRollsMax** | **int?** | Maximum amount of rolls | [optional]  |
| **modRank** | **string?** | Should mod be maxed or whatever. | [optional]  |
| **polarity** | **string?** |  | [optional]  |
| **sortBy** | **string?** | Sorting, by prices or by attributes value, ascending and descending. | [optional]  |

### Return type

[**AuctionsSearchTypeRivenGet200Response**](AuctionsSearchTypeRivenGet200Response.md)

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

