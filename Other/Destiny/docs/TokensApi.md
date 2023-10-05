# Destiny.Api.TokensApi

All URIs are relative to *https://www.bungie.net/Platform*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TokensApplyMissingPartnerOffersWithoutClaim**](TokensApi.md#tokensapplymissingpartnerofferswithoutclaim) | **POST** /Tokens/Partner/ApplyMissingOffers/{partnerApplicationId}/{targetBnetMembershipId}/ |  |
| [**TokensClaimPartnerOffer**](TokensApi.md#tokensclaimpartneroffer) | **POST** /Tokens/Partner/ClaimOffer/ |  |
| [**TokensForceDropsRepair**](TokensApi.md#tokensforcedropsrepair) | **POST** /Tokens/Partner/ForceDropsRepair/ |  |
| [**TokensGetBungieRewardsForPlatformUser**](TokensApi.md#tokensgetbungierewardsforplatformuser) | **GET** /Tokens/Rewards/GetRewardsForPlatformUser/{membershipId}/{membershipType}/ |  |
| [**TokensGetBungieRewardsForUser**](TokensApi.md#tokensgetbungierewardsforuser) | **GET** /Tokens/Rewards/GetRewardsForUser/{membershipId}/ |  |
| [**TokensGetBungieRewardsList**](TokensApi.md#tokensgetbungierewardslist) | **GET** /Tokens/Rewards/BungieRewards/ |  |
| [**TokensGetPartnerOfferSkuHistory**](TokensApi.md#tokensgetpartnerofferskuhistory) | **GET** /Tokens/Partner/History/{partnerApplicationId}/{targetBnetMembershipId}/ |  |
| [**TokensGetPartnerRewardHistory**](TokensApi.md#tokensgetpartnerrewardhistory) | **GET** /Tokens/Partner/History/{targetBnetMembershipId}/Application/{partnerApplicationId}/ |  |

<a id="tokensapplymissingpartnerofferswithoutclaim"></a>
# **TokensApplyMissingPartnerOffersWithoutClaim**
> GroupV2GetUserClanInviteSetting200Response TokensApplyMissingPartnerOffersWithoutClaim (int partnerApplicationId, long targetBnetMembershipId)



Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class TokensApplyMissingPartnerOffersWithoutClaimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(config);
            var partnerApplicationId = 56;  // int | The partner application identifier.
            var targetBnetMembershipId = 789L;  // long | The bungie.net user to apply missing offers to. If not self, elevated permissions are required.

            try
            {
                GroupV2GetUserClanInviteSetting200Response result = apiInstance.TokensApplyMissingPartnerOffersWithoutClaim(partnerApplicationId, targetBnetMembershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensApplyMissingPartnerOffersWithoutClaim: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokensApplyMissingPartnerOffersWithoutClaimWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetUserClanInviteSetting200Response> response = apiInstance.TokensApplyMissingPartnerOffersWithoutClaimWithHttpInfo(partnerApplicationId, targetBnetMembershipId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.TokensApplyMissingPartnerOffersWithoutClaimWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **partnerApplicationId** | **int** | The partner application identifier. |  |
| **targetBnetMembershipId** | **long** | The bungie.net user to apply missing offers to. If not self, elevated permissions are required. |  |

### Return type

[**GroupV2GetUserClanInviteSetting200Response**](GroupV2GetUserClanInviteSetting200Response.md)

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

<a id="tokensclaimpartneroffer"></a>
# **TokensClaimPartnerOffer**
> GroupV2GetUserClanInviteSetting200Response TokensClaimPartnerOffer (TokensPartnerOfferClaimRequest tokensPartnerOfferClaimRequest)



Claim a partner offer as the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class TokensClaimPartnerOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(config);
            var tokensPartnerOfferClaimRequest = new TokensPartnerOfferClaimRequest(); // TokensPartnerOfferClaimRequest | 

            try
            {
                GroupV2GetUserClanInviteSetting200Response result = apiInstance.TokensClaimPartnerOffer(tokensPartnerOfferClaimRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensClaimPartnerOffer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokensClaimPartnerOfferWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetUserClanInviteSetting200Response> response = apiInstance.TokensClaimPartnerOfferWithHttpInfo(tokensPartnerOfferClaimRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.TokensClaimPartnerOfferWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tokensPartnerOfferClaimRequest** | [**TokensPartnerOfferClaimRequest**](TokensPartnerOfferClaimRequest.md) |  |  |

### Return type

[**GroupV2GetUserClanInviteSetting200Response**](GroupV2GetUserClanInviteSetting200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tokensforcedropsrepair"></a>
# **TokensForceDropsRepair**
> GroupV2GetUserClanInviteSetting200Response TokensForceDropsRepair ()



Twitch Drops self-repair function - scans twitch for drops not marked as fulfilled and resyncs them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class TokensForceDropsRepairExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(config);

            try
            {
                GroupV2GetUserClanInviteSetting200Response result = apiInstance.TokensForceDropsRepair();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensForceDropsRepair: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokensForceDropsRepairWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetUserClanInviteSetting200Response> response = apiInstance.TokensForceDropsRepairWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.TokensForceDropsRepairWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GroupV2GetUserClanInviteSetting200Response**](GroupV2GetUserClanInviteSetting200Response.md)

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

<a id="tokensgetbungierewardsforplatformuser"></a>
# **TokensGetBungieRewardsForPlatformUser**
> TokensGetBungieRewardsForUser200Response TokensGetBungieRewardsForPlatformUser (long membershipId, int membershipType)



Returns the bungie rewards for the targeted user when a platform membership Id and Type are used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class TokensGetBungieRewardsForPlatformUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(config);
            var membershipId = 789L;  // long | users platform membershipId for requested user rewards. If not self, elevated permissions are required.
            var membershipType = 56;  // int | The target Destiny 2 membership type.

            try
            {
                TokensGetBungieRewardsForUser200Response result = apiInstance.TokensGetBungieRewardsForPlatformUser(membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensGetBungieRewardsForPlatformUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokensGetBungieRewardsForPlatformUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TokensGetBungieRewardsForUser200Response> response = apiInstance.TokensGetBungieRewardsForPlatformUserWithHttpInfo(membershipId, membershipType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.TokensGetBungieRewardsForPlatformUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **membershipId** | **long** | users platform membershipId for requested user rewards. If not self, elevated permissions are required. |  |
| **membershipType** | **int** | The target Destiny 2 membership type. |  |

### Return type

[**TokensGetBungieRewardsForUser200Response**](TokensGetBungieRewardsForUser200Response.md)

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

<a id="tokensgetbungierewardsforuser"></a>
# **TokensGetBungieRewardsForUser**
> TokensGetBungieRewardsForUser200Response TokensGetBungieRewardsForUser (long membershipId)



Returns the bungie rewards for the targeted user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class TokensGetBungieRewardsForUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(config);
            var membershipId = 789L;  // long | bungie.net user membershipId for requested user rewards. If not self, elevated permissions are required.

            try
            {
                TokensGetBungieRewardsForUser200Response result = apiInstance.TokensGetBungieRewardsForUser(membershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensGetBungieRewardsForUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokensGetBungieRewardsForUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TokensGetBungieRewardsForUser200Response> response = apiInstance.TokensGetBungieRewardsForUserWithHttpInfo(membershipId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.TokensGetBungieRewardsForUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **membershipId** | **long** | bungie.net user membershipId for requested user rewards. If not self, elevated permissions are required. |  |

### Return type

[**TokensGetBungieRewardsForUser200Response**](TokensGetBungieRewardsForUser200Response.md)

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

<a id="tokensgetbungierewardslist"></a>
# **TokensGetBungieRewardsList**
> TokensGetBungieRewardsForUser200Response TokensGetBungieRewardsList ()



Returns a list of the current bungie rewards

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class TokensGetBungieRewardsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new TokensApi(config);

            try
            {
                TokensGetBungieRewardsForUser200Response result = apiInstance.TokensGetBungieRewardsList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensGetBungieRewardsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokensGetBungieRewardsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TokensGetBungieRewardsForUser200Response> response = apiInstance.TokensGetBungieRewardsListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.TokensGetBungieRewardsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TokensGetBungieRewardsForUser200Response**](TokensGetBungieRewardsForUser200Response.md)

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

<a id="tokensgetpartnerofferskuhistory"></a>
# **TokensGetPartnerOfferSkuHistory**
> TokensGetPartnerOfferSkuHistory200Response TokensGetPartnerOfferSkuHistory (int partnerApplicationId, long targetBnetMembershipId)



Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class TokensGetPartnerOfferSkuHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(config);
            var partnerApplicationId = 56;  // int | The partner application identifier.
            var targetBnetMembershipId = 789L;  // long | The bungie.net user to apply missing offers to. If not self, elevated permissions are required.

            try
            {
                TokensGetPartnerOfferSkuHistory200Response result = apiInstance.TokensGetPartnerOfferSkuHistory(partnerApplicationId, targetBnetMembershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensGetPartnerOfferSkuHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokensGetPartnerOfferSkuHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TokensGetPartnerOfferSkuHistory200Response> response = apiInstance.TokensGetPartnerOfferSkuHistoryWithHttpInfo(partnerApplicationId, targetBnetMembershipId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.TokensGetPartnerOfferSkuHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **partnerApplicationId** | **int** | The partner application identifier. |  |
| **targetBnetMembershipId** | **long** | The bungie.net user to apply missing offers to. If not self, elevated permissions are required. |  |

### Return type

[**TokensGetPartnerOfferSkuHistory200Response**](TokensGetPartnerOfferSkuHistory200Response.md)

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

<a id="tokensgetpartnerrewardhistory"></a>
# **TokensGetPartnerRewardHistory**
> TokensGetPartnerRewardHistory200Response TokensGetPartnerRewardHistory (int partnerApplicationId, long targetBnetMembershipId)



Returns the partner rewards history of the targeted user, both partner offers and Twitch drops.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class TokensGetPartnerRewardHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(config);
            var partnerApplicationId = 56;  // int | The partner application identifier.
            var targetBnetMembershipId = 789L;  // long | The bungie.net user to return reward history for.

            try
            {
                TokensGetPartnerRewardHistory200Response result = apiInstance.TokensGetPartnerRewardHistory(partnerApplicationId, targetBnetMembershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensGetPartnerRewardHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokensGetPartnerRewardHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TokensGetPartnerRewardHistory200Response> response = apiInstance.TokensGetPartnerRewardHistoryWithHttpInfo(partnerApplicationId, targetBnetMembershipId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.TokensGetPartnerRewardHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **partnerApplicationId** | **int** | The partner application identifier. |  |
| **targetBnetMembershipId** | **long** | The bungie.net user to return reward history for. |  |

### Return type

[**TokensGetPartnerRewardHistory200Response**](TokensGetPartnerRewardHistory200Response.md)

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

