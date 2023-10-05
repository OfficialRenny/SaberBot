# Destiny.Api.Destiny2Api

All URIs are relative to *https://www.bungie.net/Platform*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Destiny2AwaGetActionToken**](Destiny2Api.md#destiny2awagetactiontoken) | **GET** /Destiny2/Awa/GetActionToken/{correlationId}/ |  |
| [**Destiny2AwaInitializeRequest**](Destiny2Api.md#destiny2awainitializerequest) | **POST** /Destiny2/Awa/Initialize/ |  |
| [**Destiny2AwaProvideAuthorizationResult**](Destiny2Api.md#destiny2awaprovideauthorizationresult) | **POST** /Destiny2/Awa/AwaProvideAuthorizationResult/ |  |
| [**Destiny2ClearLoadout**](Destiny2Api.md#destiny2clearloadout) | **POST** /Destiny2/Actions/Loadouts/ClearLoadout/ |  |
| [**Destiny2EquipItem**](Destiny2Api.md#destiny2equipitem) | **POST** /Destiny2/Actions/Items/EquipItem/ |  |
| [**Destiny2EquipItems**](Destiny2Api.md#destiny2equipitems) | **POST** /Destiny2/Actions/Items/EquipItems/ |  |
| [**Destiny2EquipLoadout**](Destiny2Api.md#destiny2equiploadout) | **POST** /Destiny2/Actions/Loadouts/EquipLoadout/ |  |
| [**Destiny2GetActivityHistory**](Destiny2Api.md#destiny2getactivityhistory) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/Activities/ |  |
| [**Destiny2GetCharacter**](Destiny2Api.md#destiny2getcharacter) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/ |  |
| [**Destiny2GetClanAggregateStats**](Destiny2Api.md#destiny2getclanaggregatestats) | **GET** /Destiny2/Stats/AggregateClanStats/{groupId}/ |  |
| [**Destiny2GetClanBannerSource**](Destiny2Api.md#destiny2getclanbannersource) | **GET** /Destiny2/Clan/ClanBannerDictionary/ |  |
| [**Destiny2GetClanLeaderboards**](Destiny2Api.md#destiny2getclanleaderboards) | **GET** /Destiny2/Stats/Leaderboards/Clans/{groupId}/ |  |
| [**Destiny2GetClanWeeklyRewardState**](Destiny2Api.md#destiny2getclanweeklyrewardstate) | **GET** /Destiny2/Clan/{groupId}/WeeklyRewardState/ |  |
| [**Destiny2GetCollectibleNodeDetails**](Destiny2Api.md#destiny2getcollectiblenodedetails) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Collectibles/{collectiblePresentationNodeHash}/ |  |
| [**Destiny2GetDestinyAggregateActivityStats**](Destiny2Api.md#destiny2getdestinyaggregateactivitystats) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/AggregateActivityStats/ |  |
| [**Destiny2GetDestinyEntityDefinition**](Destiny2Api.md#destiny2getdestinyentitydefinition) | **GET** /Destiny2/Manifest/{entityType}/{hashIdentifier}/ |  |
| [**Destiny2GetDestinyManifest**](Destiny2Api.md#destiny2getdestinymanifest) | **GET** /Destiny2/Manifest/ |  |
| [**Destiny2GetHistoricalStats**](Destiny2Api.md#destiny2gethistoricalstats) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/ |  |
| [**Destiny2GetHistoricalStatsDefinition**](Destiny2Api.md#destiny2gethistoricalstatsdefinition) | **GET** /Destiny2/Stats/Definition/ |  |
| [**Destiny2GetHistoricalStatsForAccount**](Destiny2Api.md#destiny2gethistoricalstatsforaccount) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/ |  |
| [**Destiny2GetItem**](Destiny2Api.md#destiny2getitem) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Item/{itemInstanceId}/ |  |
| [**Destiny2GetLeaderboards**](Destiny2Api.md#destiny2getleaderboards) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/Leaderboards/ |  |
| [**Destiny2GetLeaderboardsForCharacter**](Destiny2Api.md#destiny2getleaderboardsforcharacter) | **GET** /Destiny2/Stats/Leaderboards/{membershipType}/{destinyMembershipId}/{characterId}/ |  |
| [**Destiny2GetLinkedProfiles**](Destiny2Api.md#destiny2getlinkedprofiles) | **GET** /Destiny2/{membershipType}/Profile/{membershipId}/LinkedProfiles/ |  |
| [**Destiny2GetPostGameCarnageReport**](Destiny2Api.md#destiny2getpostgamecarnagereport) | **GET** /Destiny2/Stats/PostGameCarnageReport/{activityId}/ |  |
| [**Destiny2GetProfile**](Destiny2Api.md#destiny2getprofile) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/ |  |
| [**Destiny2GetPublicMilestoneContent**](Destiny2Api.md#destiny2getpublicmilestonecontent) | **GET** /Destiny2/Milestones/{milestoneHash}/Content/ |  |
| [**Destiny2GetPublicMilestones**](Destiny2Api.md#destiny2getpublicmilestones) | **GET** /Destiny2/Milestones/ |  |
| [**Destiny2GetPublicVendors**](Destiny2Api.md#destiny2getpublicvendors) | **GET** /Destiny2/Vendors/ |  |
| [**Destiny2GetUniqueWeaponHistory**](Destiny2Api.md#destiny2getuniqueweaponhistory) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/UniqueWeapons/ |  |
| [**Destiny2GetVendor**](Destiny2Api.md#destiny2getvendor) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/{vendorHash}/ |  |
| [**Destiny2GetVendors**](Destiny2Api.md#destiny2getvendors) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/ |  |
| [**Destiny2InsertSocketPlug**](Destiny2Api.md#destiny2insertsocketplug) | **POST** /Destiny2/Actions/Items/InsertSocketPlug/ |  |
| [**Destiny2InsertSocketPlugFree**](Destiny2Api.md#destiny2insertsocketplugfree) | **POST** /Destiny2/Actions/Items/InsertSocketPlugFree/ |  |
| [**Destiny2PullFromPostmaster**](Destiny2Api.md#destiny2pullfrompostmaster) | **POST** /Destiny2/Actions/Items/PullFromPostmaster/ |  |
| [**Destiny2ReportOffensivePostGameCarnageReportPlayer**](Destiny2Api.md#destiny2reportoffensivepostgamecarnagereportplayer) | **POST** /Destiny2/Stats/PostGameCarnageReport/{activityId}/Report/ |  |
| [**Destiny2SearchDestinyEntities**](Destiny2Api.md#destiny2searchdestinyentities) | **GET** /Destiny2/Armory/Search/{type}/{searchTerm}/ |  |
| [**Destiny2SearchDestinyPlayerByBungieName**](Destiny2Api.md#destiny2searchdestinyplayerbybungiename) | **POST** /Destiny2/SearchDestinyPlayerByBungieName/{membershipType}/ |  |
| [**Destiny2SetItemLockState**](Destiny2Api.md#destiny2setitemlockstate) | **POST** /Destiny2/Actions/Items/SetLockState/ |  |
| [**Destiny2SetQuestTrackedState**](Destiny2Api.md#destiny2setquesttrackedstate) | **POST** /Destiny2/Actions/Items/SetTrackedState/ |  |
| [**Destiny2SnapshotLoadout**](Destiny2Api.md#destiny2snapshotloadout) | **POST** /Destiny2/Actions/Loadouts/SnapshotLoadout/ |  |
| [**Destiny2TransferItem**](Destiny2Api.md#destiny2transferitem) | **POST** /Destiny2/Actions/Items/TransferItem/ |  |
| [**Destiny2UpdateLoadoutIdentifiers**](Destiny2Api.md#destiny2updateloadoutidentifiers) | **POST** /Destiny2/Actions/Loadouts/UpdateLoadoutIdentifiers/ |  |

<a id="destiny2awagetactiontoken"></a>
# **Destiny2AwaGetActionToken**
> Destiny2AwaGetActionToken200Response Destiny2AwaGetActionToken (string correlationId)



Returns the action token if user approves the request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2AwaGetActionTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var correlationId = "correlationId_example";  // string | The identifier for the advanced write action request.

            try
            {
                Destiny2AwaGetActionToken200Response result = apiInstance.Destiny2AwaGetActionToken(correlationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2AwaGetActionToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2AwaGetActionTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2AwaGetActionToken200Response> response = apiInstance.Destiny2AwaGetActionTokenWithHttpInfo(correlationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2AwaGetActionTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **correlationId** | **string** | The identifier for the advanced write action request. |  |

### Return type

[**Destiny2AwaGetActionToken200Response**](Destiny2AwaGetActionToken200Response.md)

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

<a id="destiny2awainitializerequest"></a>
# **Destiny2AwaInitializeRequest**
> Destiny2AwaInitializeRequest200Response Destiny2AwaInitializeRequest (DestinyAdvancedAwaPermissionRequested destinyAdvancedAwaPermissionRequested)



Initialize a request to perform an advanced write action.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2AwaInitializeRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var destinyAdvancedAwaPermissionRequested = new DestinyAdvancedAwaPermissionRequested(); // DestinyAdvancedAwaPermissionRequested | 

            try
            {
                Destiny2AwaInitializeRequest200Response result = apiInstance.Destiny2AwaInitializeRequest(destinyAdvancedAwaPermissionRequested);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2AwaInitializeRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2AwaInitializeRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2AwaInitializeRequest200Response> response = apiInstance.Destiny2AwaInitializeRequestWithHttpInfo(destinyAdvancedAwaPermissionRequested);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2AwaInitializeRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyAdvancedAwaPermissionRequested** | [**DestinyAdvancedAwaPermissionRequested**](DestinyAdvancedAwaPermissionRequested.md) |  |  |

### Return type

[**Destiny2AwaInitializeRequest200Response**](Destiny2AwaInitializeRequest200Response.md)

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

<a id="destiny2awaprovideauthorizationresult"></a>
# **Destiny2AwaProvideAuthorizationResult**
> GroupV2EditGroup200Response Destiny2AwaProvideAuthorizationResult (DestinyAdvancedAwaUserResponse destinyAdvancedAwaUserResponse)



Provide the result of the user interaction. Called by the Bungie Destiny App to approve or reject a request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2AwaProvideAuthorizationResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var destinyAdvancedAwaUserResponse = new DestinyAdvancedAwaUserResponse(); // DestinyAdvancedAwaUserResponse | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.Destiny2AwaProvideAuthorizationResult(destinyAdvancedAwaUserResponse);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2AwaProvideAuthorizationResult: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2AwaProvideAuthorizationResultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.Destiny2AwaProvideAuthorizationResultWithHttpInfo(destinyAdvancedAwaUserResponse);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2AwaProvideAuthorizationResultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyAdvancedAwaUserResponse** | [**DestinyAdvancedAwaUserResponse**](DestinyAdvancedAwaUserResponse.md) |  |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2clearloadout"></a>
# **Destiny2ClearLoadout**
> GroupV2EditGroup200Response Destiny2ClearLoadout (DestinyRequestsActionsDestinyLoadoutActionRequest destinyRequestsActionsDestinyLoadoutActionRequest)



Clear the identifiers and items of a loadout.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2ClearLoadoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var destinyRequestsActionsDestinyLoadoutActionRequest = new DestinyRequestsActionsDestinyLoadoutActionRequest(); // DestinyRequestsActionsDestinyLoadoutActionRequest | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.Destiny2ClearLoadout(destinyRequestsActionsDestinyLoadoutActionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2ClearLoadout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2ClearLoadoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.Destiny2ClearLoadoutWithHttpInfo(destinyRequestsActionsDestinyLoadoutActionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2ClearLoadoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsActionsDestinyLoadoutActionRequest** | [**DestinyRequestsActionsDestinyLoadoutActionRequest**](DestinyRequestsActionsDestinyLoadoutActionRequest.md) |  |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

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

<a id="destiny2equipitem"></a>
# **Destiny2EquipItem**
> GroupV2EditGroup200Response Destiny2EquipItem (DestinyRequestsActionsDestinyItemActionRequest destinyRequestsActionsDestinyItemActionRequest)



Equip an item. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2EquipItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var destinyRequestsActionsDestinyItemActionRequest = new DestinyRequestsActionsDestinyItemActionRequest(); // DestinyRequestsActionsDestinyItemActionRequest | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.Destiny2EquipItem(destinyRequestsActionsDestinyItemActionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2EquipItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2EquipItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.Destiny2EquipItemWithHttpInfo(destinyRequestsActionsDestinyItemActionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2EquipItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsActionsDestinyItemActionRequest** | [**DestinyRequestsActionsDestinyItemActionRequest**](DestinyRequestsActionsDestinyItemActionRequest.md) |  |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

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

<a id="destiny2equipitems"></a>
# **Destiny2EquipItems**
> Destiny2EquipItems200Response Destiny2EquipItems (DestinyRequestsActionsDestinyItemSetActionRequest destinyRequestsActionsDestinyItemSetActionRequest)



Equip a list of items by itemInstanceIds. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Any items not found on your character will be ignored.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2EquipItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var destinyRequestsActionsDestinyItemSetActionRequest = new DestinyRequestsActionsDestinyItemSetActionRequest(); // DestinyRequestsActionsDestinyItemSetActionRequest | 

            try
            {
                Destiny2EquipItems200Response result = apiInstance.Destiny2EquipItems(destinyRequestsActionsDestinyItemSetActionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2EquipItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2EquipItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2EquipItems200Response> response = apiInstance.Destiny2EquipItemsWithHttpInfo(destinyRequestsActionsDestinyItemSetActionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2EquipItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsActionsDestinyItemSetActionRequest** | [**DestinyRequestsActionsDestinyItemSetActionRequest**](DestinyRequestsActionsDestinyItemSetActionRequest.md) |  |  |

### Return type

[**Destiny2EquipItems200Response**](Destiny2EquipItems200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The results of a bulk Equipping operation performed through the Destiny API. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2equiploadout"></a>
# **Destiny2EquipLoadout**
> GroupV2EditGroup200Response Destiny2EquipLoadout (DestinyRequestsActionsDestinyLoadoutActionRequest destinyRequestsActionsDestinyLoadoutActionRequest)



Equip a loadout. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2EquipLoadoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var destinyRequestsActionsDestinyLoadoutActionRequest = new DestinyRequestsActionsDestinyLoadoutActionRequest(); // DestinyRequestsActionsDestinyLoadoutActionRequest | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.Destiny2EquipLoadout(destinyRequestsActionsDestinyLoadoutActionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2EquipLoadout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2EquipLoadoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.Destiny2EquipLoadoutWithHttpInfo(destinyRequestsActionsDestinyLoadoutActionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2EquipLoadoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsActionsDestinyLoadoutActionRequest** | [**DestinyRequestsActionsDestinyLoadoutActionRequest**](DestinyRequestsActionsDestinyLoadoutActionRequest.md) |  |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

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

<a id="destiny2getactivityhistory"></a>
# **Destiny2GetActivityHistory**
> Destiny2GetActivityHistory200Response Destiny2GetActivityHistory (long characterId, long destinyMembershipId, int membershipType, int? count = null, int? mode = null, int? page = null)



Gets activity history stats for indicated character.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetActivityHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var characterId = 789L;  // long | The id of the character to retrieve.
            var destinyMembershipId = 789L;  // long | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.
            var count = 56;  // int? | Number of rows to return (optional) 
            var mode = 56;  // int? | A filter for the activity mode to be returned. None returns all activities. See the documentation for DestinyActivityModeType for valid values, and pass in string representation. (optional) 
            var page = 56;  // int? | Page number to return, starting with 0. (optional) 

            try
            {
                Destiny2GetActivityHistory200Response result = apiInstance.Destiny2GetActivityHistory(characterId, destinyMembershipId, membershipType, count, mode, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetActivityHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetActivityHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetActivityHistory200Response> response = apiInstance.Destiny2GetActivityHistoryWithHttpInfo(characterId, destinyMembershipId, membershipType, count, mode, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetActivityHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **characterId** | **long** | The id of the character to retrieve. |  |
| **destinyMembershipId** | **long** | The Destiny membershipId of the user to retrieve. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |
| **count** | **int?** | Number of rows to return | [optional]  |
| **mode** | **int?** | A filter for the activity mode to be returned. None returns all activities. See the documentation for DestinyActivityModeType for valid values, and pass in string representation. | [optional]  |
| **page** | **int?** | Page number to return, starting with 0. | [optional]  |

### Return type

[**Destiny2GetActivityHistory200Response**](Destiny2GetActivityHistory200Response.md)

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

<a id="destiny2getcharacter"></a>
# **Destiny2GetCharacter**
> Destiny2GetCharacter200Response Destiny2GetCharacter (long characterId, long destinyMembershipId, int membershipType, List<int>? components = null)



Returns character information for the supplied character.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetCharacterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var characterId = 789L;  // long | ID of the character.
            var destinyMembershipId = 789L;  // long | Destiny membership ID.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.
            var components = new List<int>?(); // List<int>? | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                Destiny2GetCharacter200Response result = apiInstance.Destiny2GetCharacter(characterId, destinyMembershipId, membershipType, components);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetCharacter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetCharacterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetCharacter200Response> response = apiInstance.Destiny2GetCharacterWithHttpInfo(characterId, destinyMembershipId, membershipType, components);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetCharacterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **characterId** | **long** | ID of the character. |  |
| **destinyMembershipId** | **long** | Destiny membership ID. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |
| **components** | [**List&lt;int&gt;?**](int.md) | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional]  |

### Return type

[**Destiny2GetCharacter200Response**](Destiny2GetCharacter200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response contract for GetDestinyCharacter, with components that can be returned for character and item-level data. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getclanaggregatestats"></a>
# **Destiny2GetClanAggregateStats**
> Destiny2GetClanAggregateStats200Response Destiny2GetClanAggregateStats (long groupId, string? modes = null)



Gets aggregated stats for a clan using the same categories as the clan leaderboards. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetClanAggregateStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var groupId = 789L;  // long | Group ID of the clan whose leaderboards you wish to fetch.
            var modes = "modes_example";  // string? | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 

            try
            {
                Destiny2GetClanAggregateStats200Response result = apiInstance.Destiny2GetClanAggregateStats(groupId, modes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanAggregateStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetClanAggregateStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetClanAggregateStats200Response> response = apiInstance.Destiny2GetClanAggregateStatsWithHttpInfo(groupId, modes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanAggregateStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | Group ID of the clan whose leaderboards you wish to fetch. |  |
| **modes** | **string?** | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional]  |

### Return type

[**Destiny2GetClanAggregateStats200Response**](Destiny2GetClanAggregateStats200Response.md)

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

<a id="destiny2getclanbannersource"></a>
# **Destiny2GetClanBannerSource**
> Destiny2GetClanBannerSource200Response Destiny2GetClanBannerSource ()



Returns the dictionary of values for the Clan Banner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetClanBannerSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);

            try
            {
                Destiny2GetClanBannerSource200Response result = apiInstance.Destiny2GetClanBannerSource();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanBannerSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetClanBannerSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetClanBannerSource200Response> response = apiInstance.Destiny2GetClanBannerSourceWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanBannerSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Destiny2GetClanBannerSource200Response**](Destiny2GetClanBannerSource200Response.md)

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

<a id="destiny2getclanleaderboards"></a>
# **Destiny2GetClanLeaderboards**
> Destiny2GetClanLeaderboards200Response Destiny2GetClanLeaderboards (long groupId, int? maxtop = null, string? modes = null, string? statid = null)



Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetClanLeaderboardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var groupId = 789L;  // long | Group ID of the clan whose leaderboards you wish to fetch.
            var maxtop = 56;  // int? | Maximum number of top players to return. Use a large number to get entire leaderboard. (optional) 
            var modes = "modes_example";  // string? | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var statid = "statid_example";  // string? | ID of stat to return rather than returning all Leaderboard stats. (optional) 

            try
            {
                Destiny2GetClanLeaderboards200Response result = apiInstance.Destiny2GetClanLeaderboards(groupId, maxtop, modes, statid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanLeaderboards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetClanLeaderboardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetClanLeaderboards200Response> response = apiInstance.Destiny2GetClanLeaderboardsWithHttpInfo(groupId, maxtop, modes, statid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanLeaderboardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | Group ID of the clan whose leaderboards you wish to fetch. |  |
| **maxtop** | **int?** | Maximum number of top players to return. Use a large number to get entire leaderboard. | [optional]  |
| **modes** | **string?** | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional]  |
| **statid** | **string?** | ID of stat to return rather than returning all Leaderboard stats. | [optional]  |

### Return type

[**Destiny2GetClanLeaderboards200Response**](Destiny2GetClanLeaderboards200Response.md)

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

<a id="destiny2getclanweeklyrewardstate"></a>
# **Destiny2GetClanWeeklyRewardState**
> Destiny2GetClanWeeklyRewardState200Response Destiny2GetClanWeeklyRewardState (long groupId)



Returns information on the weekly clan rewards and if the clan has earned them or not. Note that this will always report rewards as not redeemed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetClanWeeklyRewardStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var groupId = 789L;  // long | A valid group id of clan.

            try
            {
                Destiny2GetClanWeeklyRewardState200Response result = apiInstance.Destiny2GetClanWeeklyRewardState(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanWeeklyRewardState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetClanWeeklyRewardStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetClanWeeklyRewardState200Response> response = apiInstance.Destiny2GetClanWeeklyRewardStateWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanWeeklyRewardStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | A valid group id of clan. |  |

### Return type

[**Destiny2GetClanWeeklyRewardState200Response**](Destiny2GetClanWeeklyRewardState200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Represents a runtime instance of a user&#39;s milestone status. Live Milestone data should be combined with DestinyMilestoneDefinition data to show the user a picture of what is available for them to do in the game, and their status in regards to said \&quot;things to do.\&quot; Consider it a big, wonky to-do list, or Advisors 3.0 for those who remember the Destiny 1 API. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getcollectiblenodedetails"></a>
# **Destiny2GetCollectibleNodeDetails**
> Destiny2GetCollectibleNodeDetails200Response Destiny2GetCollectibleNodeDetails (long characterId, int collectiblePresentationNodeHash, long destinyMembershipId, int membershipType, List<int>? components = null)



Given a Presentation Node that has Collectibles as direct descendants, this will return item details about those descendants in the context of the requesting character.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetCollectibleNodeDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var characterId = 789L;  // long | The Destiny Character ID of the character for whom we're getting collectible detail info.
            var collectiblePresentationNodeHash = 56;  // int | The hash identifier of the Presentation Node for whom we should return collectible details. Details will only be returned for collectibles that are direct descendants of this node.
            var destinyMembershipId = 789L;  // long | Destiny membership ID of another user. You may be denied.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.
            var components = new List<int>?(); // List<int>? | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                Destiny2GetCollectibleNodeDetails200Response result = apiInstance.Destiny2GetCollectibleNodeDetails(characterId, collectiblePresentationNodeHash, destinyMembershipId, membershipType, components);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetCollectibleNodeDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetCollectibleNodeDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetCollectibleNodeDetails200Response> response = apiInstance.Destiny2GetCollectibleNodeDetailsWithHttpInfo(characterId, collectiblePresentationNodeHash, destinyMembershipId, membershipType, components);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetCollectibleNodeDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **characterId** | **long** | The Destiny Character ID of the character for whom we&#39;re getting collectible detail info. |  |
| **collectiblePresentationNodeHash** | **int** | The hash identifier of the Presentation Node for whom we should return collectible details. Details will only be returned for collectibles that are direct descendants of this node. |  |
| **destinyMembershipId** | **long** | Destiny membership ID of another user. You may be denied. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |
| **components** | [**List&lt;int&gt;?**](int.md) | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional]  |

### Return type

[**Destiny2GetCollectibleNodeDetails200Response**](Destiny2GetCollectibleNodeDetails200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the detailed information about a Collectible Presentation Node and any Collectibles that are direct descendants. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getdestinyaggregateactivitystats"></a>
# **Destiny2GetDestinyAggregateActivityStats**
> Destiny2GetDestinyAggregateActivityStats200Response Destiny2GetDestinyAggregateActivityStats (long characterId, long destinyMembershipId, int membershipType)



Gets all activities the character has participated in together with aggregate statistics for those activities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetDestinyAggregateActivityStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var characterId = 789L;  // long | The specific character whose activities should be returned.
            var destinyMembershipId = 789L;  // long | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.

            try
            {
                Destiny2GetDestinyAggregateActivityStats200Response result = apiInstance.Destiny2GetDestinyAggregateActivityStats(characterId, destinyMembershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetDestinyAggregateActivityStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetDestinyAggregateActivityStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetDestinyAggregateActivityStats200Response> response = apiInstance.Destiny2GetDestinyAggregateActivityStatsWithHttpInfo(characterId, destinyMembershipId, membershipType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetDestinyAggregateActivityStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **characterId** | **long** | The specific character whose activities should be returned. |  |
| **destinyMembershipId** | **long** | The Destiny membershipId of the user to retrieve. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |

### Return type

[**Destiny2GetDestinyAggregateActivityStats200Response**](Destiny2GetDestinyAggregateActivityStats200Response.md)

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

<a id="destiny2getdestinyentitydefinition"></a>
# **Destiny2GetDestinyEntityDefinition**
> Destiny2GetDestinyEntityDefinition200Response Destiny2GetDestinyEntityDefinition (string entityType, int hashIdentifier)



Returns the static definition of an entity of the given Type and hash identifier. Examine the API Documentation for the Type Names of entities that have their own definitions. Note that the return type will always *inherit from* DestinyDefinition, but the specific type returned will be the requested entity type if it can be found. Please don't use this as a chatty alternative to the Manifest database if you require large sets of data, but for simple and one-off accesses this should be handy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetDestinyEntityDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var entityType = "entityType_example";  // string | The type of entity for whom you would like results. These correspond to the entity's definition contract name. For instance, if you are looking for items, this property should be 'DestinyInventoryItemDefinition'. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is tentatively in final form, but there may be bugs that prevent desirable operation.
            var hashIdentifier = 56;  // int | The hash identifier for the specific Entity you want returned.

            try
            {
                Destiny2GetDestinyEntityDefinition200Response result = apiInstance.Destiny2GetDestinyEntityDefinition(entityType, hashIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetDestinyEntityDefinition: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetDestinyEntityDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetDestinyEntityDefinition200Response> response = apiInstance.Destiny2GetDestinyEntityDefinitionWithHttpInfo(entityType, hashIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetDestinyEntityDefinitionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityType** | **string** | The type of entity for whom you would like results. These correspond to the entity&#39;s definition contract name. For instance, if you are looking for items, this property should be &#39;DestinyInventoryItemDefinition&#39;. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is tentatively in final form, but there may be bugs that prevent desirable operation. |  |
| **hashIdentifier** | **int** | The hash identifier for the specific Entity you want returned. |  |

### Return type

[**Destiny2GetDestinyEntityDefinition200Response**](Destiny2GetDestinyEntityDefinition200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Provides common properties for destiny definitions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getdestinymanifest"></a>
# **Destiny2GetDestinyManifest**
> Destiny2GetDestinyManifest200Response Destiny2GetDestinyManifest ()



Returns the current version of the manifest as a json object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetDestinyManifestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);

            try
            {
                Destiny2GetDestinyManifest200Response result = apiInstance.Destiny2GetDestinyManifest();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetDestinyManifest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetDestinyManifestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetDestinyManifest200Response> response = apiInstance.Destiny2GetDestinyManifestWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetDestinyManifestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Destiny2GetDestinyManifest200Response**](Destiny2GetDestinyManifest200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | DestinyManifest is the external-facing contract for just the properties needed by those calling the Destiny Platform. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2gethistoricalstats"></a>
# **Destiny2GetHistoricalStats**
> Destiny2GetHistoricalStats200Response Destiny2GetHistoricalStats (long characterId, long destinyMembershipId, int membershipType, DateTime? dayend = null, DateTime? daystart = null, List<int>? groups = null, List<int>? modes = null, int? periodType = null)



Gets historical stats for indicated character.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetHistoricalStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var characterId = 789L;  // long | The id of the character to retrieve. You can omit this character ID or set it to 0 to get aggregate stats across all characters.
            var destinyMembershipId = 789L;  // long | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.
            var dayend = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Last day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request. (optional) 
            var daystart = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | First day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request. (optional) 
            var groups = new List<int>?(); // List<int>? | Group of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals (optional) 
            var modes = new List<int>?(); // List<int>? | Game modes to return. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var periodType = 56;  // int? | Indicates a specific period type to return. Optional. May be: Daily, AllTime, or Activity (optional) 

            try
            {
                Destiny2GetHistoricalStats200Response result = apiInstance.Destiny2GetHistoricalStats(characterId, destinyMembershipId, membershipType, dayend, daystart, groups, modes, periodType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetHistoricalStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetHistoricalStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetHistoricalStats200Response> response = apiInstance.Destiny2GetHistoricalStatsWithHttpInfo(characterId, destinyMembershipId, membershipType, dayend, daystart, groups, modes, periodType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetHistoricalStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **characterId** | **long** | The id of the character to retrieve. You can omit this character ID or set it to 0 to get aggregate stats across all characters. |  |
| **destinyMembershipId** | **long** | The Destiny membershipId of the user to retrieve. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |
| **dayend** | **DateTime?** | Last day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request. | [optional]  |
| **daystart** | **DateTime?** | First day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request. | [optional]  |
| **groups** | [**List&lt;int&gt;?**](int.md) | Group of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals | [optional]  |
| **modes** | [**List&lt;int&gt;?**](int.md) | Game modes to return. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional]  |
| **periodType** | **int?** | Indicates a specific period type to return. Optional. May be: Daily, AllTime, or Activity | [optional]  |

### Return type

[**Destiny2GetHistoricalStats200Response**](Destiny2GetHistoricalStats200Response.md)

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

<a id="destiny2gethistoricalstatsdefinition"></a>
# **Destiny2GetHistoricalStatsDefinition**
> Destiny2GetHistoricalStatsDefinition200Response Destiny2GetHistoricalStatsDefinition ()



Gets historical stats definitions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetHistoricalStatsDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);

            try
            {
                Destiny2GetHistoricalStatsDefinition200Response result = apiInstance.Destiny2GetHistoricalStatsDefinition();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetHistoricalStatsDefinition: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetHistoricalStatsDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetHistoricalStatsDefinition200Response> response = apiInstance.Destiny2GetHistoricalStatsDefinitionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetHistoricalStatsDefinitionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Destiny2GetHistoricalStatsDefinition200Response**](Destiny2GetHistoricalStatsDefinition200Response.md)

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

<a id="destiny2gethistoricalstatsforaccount"></a>
# **Destiny2GetHistoricalStatsForAccount**
> Destiny2GetHistoricalStatsForAccount200Response Destiny2GetHistoricalStatsForAccount (long destinyMembershipId, int membershipType, List<int>? groups = null)



Gets aggregate historical stats organized around each character for a given account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetHistoricalStatsForAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var destinyMembershipId = 789L;  // long | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.
            var groups = new List<int>?(); // List<int>? | Groups of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals. (optional) 

            try
            {
                Destiny2GetHistoricalStatsForAccount200Response result = apiInstance.Destiny2GetHistoricalStatsForAccount(destinyMembershipId, membershipType, groups);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetHistoricalStatsForAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetHistoricalStatsForAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetHistoricalStatsForAccount200Response> response = apiInstance.Destiny2GetHistoricalStatsForAccountWithHttpInfo(destinyMembershipId, membershipType, groups);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetHistoricalStatsForAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyMembershipId** | **long** | The Destiny membershipId of the user to retrieve. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |
| **groups** | [**List&lt;int&gt;?**](int.md) | Groups of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals. | [optional]  |

### Return type

[**Destiny2GetHistoricalStatsForAccount200Response**](Destiny2GetHistoricalStatsForAccount200Response.md)

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

<a id="destiny2getitem"></a>
# **Destiny2GetItem**
> Destiny2GetItem200Response Destiny2GetItem (long destinyMembershipId, long itemInstanceId, int membershipType, List<int>? components = null)



Retrieve the details of an instanced Destiny Item. An instanced Destiny item is one with an ItemInstanceId. Non-instanced items, such as materials, have no useful instance-specific details and thus are not queryable here.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var destinyMembershipId = 789L;  // long | The membership ID of the destiny profile.
            var itemInstanceId = 789L;  // long | The Instance ID of the destiny item.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.
            var components = new List<int>?(); // List<int>? | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                Destiny2GetItem200Response result = apiInstance.Destiny2GetItem(destinyMembershipId, itemInstanceId, membershipType, components);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetItem200Response> response = apiInstance.Destiny2GetItemWithHttpInfo(destinyMembershipId, itemInstanceId, membershipType, components);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyMembershipId** | **long** | The membership ID of the destiny profile. |  |
| **itemInstanceId** | **long** | The Instance ID of the destiny item. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |
| **components** | [**List&lt;int&gt;?**](int.md) | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional]  |

### Return type

[**Destiny2GetItem200Response**](Destiny2GetItem200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response object for retrieving an individual instanced item. None of these components are relevant for an item that doesn&#39;t have an \&quot;itemInstanceId\&quot;: for those, get your information from the DestinyInventoryDefinition. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getleaderboards"></a>
# **Destiny2GetLeaderboards**
> Destiny2GetClanLeaderboards200Response Destiny2GetLeaderboards (long destinyMembershipId, int membershipType, int? maxtop = null, string? modes = null, string? statid = null)



Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint has not yet been implemented. It is being returned for a preview of future functionality, and for public comment/suggestion/preparation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetLeaderboardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var destinyMembershipId = 789L;  // long | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.
            var maxtop = 56;  // int? | Maximum number of top players to return. Use a large number to get entire leaderboard. (optional) 
            var modes = "modes_example";  // string? | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var statid = "statid_example";  // string? | ID of stat to return rather than returning all Leaderboard stats. (optional) 

            try
            {
                Destiny2GetClanLeaderboards200Response result = apiInstance.Destiny2GetLeaderboards(destinyMembershipId, membershipType, maxtop, modes, statid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetLeaderboards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetLeaderboardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetClanLeaderboards200Response> response = apiInstance.Destiny2GetLeaderboardsWithHttpInfo(destinyMembershipId, membershipType, maxtop, modes, statid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetLeaderboardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyMembershipId** | **long** | The Destiny membershipId of the user to retrieve. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |
| **maxtop** | **int?** | Maximum number of top players to return. Use a large number to get entire leaderboard. | [optional]  |
| **modes** | **string?** | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional]  |
| **statid** | **string?** | ID of stat to return rather than returning all Leaderboard stats. | [optional]  |

### Return type

[**Destiny2GetClanLeaderboards200Response**](Destiny2GetClanLeaderboards200Response.md)

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

<a id="destiny2getleaderboardsforcharacter"></a>
# **Destiny2GetLeaderboardsForCharacter**
> Destiny2GetClanLeaderboards200Response Destiny2GetLeaderboardsForCharacter (long characterId, long destinyMembershipId, int membershipType, int? maxtop = null, string? modes = null, string? statid = null)



Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetLeaderboardsForCharacterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var characterId = 789L;  // long | The specific character to build the leaderboard around for the provided Destiny Membership.
            var destinyMembershipId = 789L;  // long | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.
            var maxtop = 56;  // int? | Maximum number of top players to return. Use a large number to get entire leaderboard. (optional) 
            var modes = "modes_example";  // string? | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var statid = "statid_example";  // string? | ID of stat to return rather than returning all Leaderboard stats. (optional) 

            try
            {
                Destiny2GetClanLeaderboards200Response result = apiInstance.Destiny2GetLeaderboardsForCharacter(characterId, destinyMembershipId, membershipType, maxtop, modes, statid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetLeaderboardsForCharacter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetLeaderboardsForCharacterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetClanLeaderboards200Response> response = apiInstance.Destiny2GetLeaderboardsForCharacterWithHttpInfo(characterId, destinyMembershipId, membershipType, maxtop, modes, statid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetLeaderboardsForCharacterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **characterId** | **long** | The specific character to build the leaderboard around for the provided Destiny Membership. |  |
| **destinyMembershipId** | **long** | The Destiny membershipId of the user to retrieve. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |
| **maxtop** | **int?** | Maximum number of top players to return. Use a large number to get entire leaderboard. | [optional]  |
| **modes** | **string?** | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional]  |
| **statid** | **string?** | ID of stat to return rather than returning all Leaderboard stats. | [optional]  |

### Return type

[**Destiny2GetClanLeaderboards200Response**](Destiny2GetClanLeaderboards200Response.md)

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

<a id="destiny2getlinkedprofiles"></a>
# **Destiny2GetLinkedProfiles**
> Destiny2GetLinkedProfiles200Response Destiny2GetLinkedProfiles (long membershipId, int membershipType, bool? getAllMemberships = null)



Returns a summary information about all profiles linked to the requesting membership type/membership ID that have valid Destiny information. The passed-in Membership Type/Membership ID may be a Bungie.Net membership or a Destiny membership. It only returns the minimal amount of data to begin making more substantive requests, but will hopefully serve as a useful alternative to UserServices for people who just care about Destiny data. Note that it will only return linked accounts whose linkages you are allowed to view.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetLinkedProfilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var membershipId = 789L;  // long | The ID of the membership whose linked Destiny accounts you want returned. Make sure your membership ID matches its Membership Type: don't pass us a PSN membership ID and the XBox membership type, it's not going to work!
            var membershipType = 56;  // int | The type for the membership whose linked Destiny accounts you want returned.
            var getAllMemberships = true;  // bool? | (optional) if set to 'true', all memberships regardless of whether they're obscured by overrides will be returned. Normal privacy restrictions on account linking will still apply no matter what. (optional) 

            try
            {
                Destiny2GetLinkedProfiles200Response result = apiInstance.Destiny2GetLinkedProfiles(membershipId, membershipType, getAllMemberships);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetLinkedProfiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetLinkedProfilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetLinkedProfiles200Response> response = apiInstance.Destiny2GetLinkedProfilesWithHttpInfo(membershipId, membershipType, getAllMemberships);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetLinkedProfilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **membershipId** | **long** | The ID of the membership whose linked Destiny accounts you want returned. Make sure your membership ID matches its Membership Type: don&#39;t pass us a PSN membership ID and the XBox membership type, it&#39;s not going to work! |  |
| **membershipType** | **int** | The type for the membership whose linked Destiny accounts you want returned. |  |
| **getAllMemberships** | **bool?** | (optional) if set to &#39;true&#39;, all memberships regardless of whether they&#39;re obscured by overrides will be returned. Normal privacy restrictions on account linking will still apply no matter what. | [optional]  |

### Return type

[**Destiny2GetLinkedProfiles200Response**](Destiny2GetLinkedProfiles200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | I know what you seek. You seek linked accounts. Found them, you have.  This contract returns a minimal amount of data about Destiny Accounts that are linked through your Bungie.Net account. We will not return accounts in this response whose |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getpostgamecarnagereport"></a>
# **Destiny2GetPostGameCarnageReport**
> Destiny2GetPostGameCarnageReport200Response Destiny2GetPostGameCarnageReport (long activityId)



Gets the available post game carnage report for the activity ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetPostGameCarnageReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var activityId = 789L;  // long | The ID of the activity whose PGCR is requested.

            try
            {
                Destiny2GetPostGameCarnageReport200Response result = apiInstance.Destiny2GetPostGameCarnageReport(activityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetPostGameCarnageReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetPostGameCarnageReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetPostGameCarnageReport200Response> response = apiInstance.Destiny2GetPostGameCarnageReportWithHttpInfo(activityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetPostGameCarnageReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activityId** | **long** | The ID of the activity whose PGCR is requested. |  |

### Return type

[**Destiny2GetPostGameCarnageReport200Response**](Destiny2GetPostGameCarnageReport200Response.md)

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

<a id="destiny2getprofile"></a>
# **Destiny2GetProfile**
> Destiny2GetProfile200Response Destiny2GetProfile (long destinyMembershipId, int membershipType, List<int>? components = null)



Returns Destiny Profile information for the supplied membership.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var destinyMembershipId = 789L;  // long | Destiny membership ID.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.
            var components = new List<int>?(); // List<int>? | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                Destiny2GetProfile200Response result = apiInstance.Destiny2GetProfile(destinyMembershipId, membershipType, components);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetProfile200Response> response = apiInstance.Destiny2GetProfileWithHttpInfo(destinyMembershipId, membershipType, components);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyMembershipId** | **long** | Destiny membership ID. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |
| **components** | [**List&lt;int&gt;?**](int.md) | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional]  |

### Return type

[**Destiny2GetProfile200Response**](Destiny2GetProfile200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response for GetDestinyProfile, with components for character and item-level data. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getpublicmilestonecontent"></a>
# **Destiny2GetPublicMilestoneContent**
> Destiny2GetPublicMilestoneContent200Response Destiny2GetPublicMilestoneContent (int milestoneHash)



Gets custom localized content for the milestone of the given hash, if it exists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetPublicMilestoneContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var milestoneHash = 56;  // int | The identifier for the milestone to be returned.

            try
            {
                Destiny2GetPublicMilestoneContent200Response result = apiInstance.Destiny2GetPublicMilestoneContent(milestoneHash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetPublicMilestoneContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetPublicMilestoneContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetPublicMilestoneContent200Response> response = apiInstance.Destiny2GetPublicMilestoneContentWithHttpInfo(milestoneHash);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetPublicMilestoneContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **milestoneHash** | **int** | The identifier for the milestone to be returned. |  |

### Return type

[**Destiny2GetPublicMilestoneContent200Response**](Destiny2GetPublicMilestoneContent200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Represents localized, extended content related to Milestones. This is intentionally returned by a separate endpoint and not with Character-level Milestone data because we do not put localized data into standard Destiny responses, both for brevity of response and for caching purposes. If you really need this data, hit the Milestone Content endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getpublicmilestones"></a>
# **Destiny2GetPublicMilestones**
> Destiny2GetPublicMilestones200Response Destiny2GetPublicMilestones ()



Gets public information about currently available Milestones.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetPublicMilestonesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);

            try
            {
                Destiny2GetPublicMilestones200Response result = apiInstance.Destiny2GetPublicMilestones();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetPublicMilestones: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetPublicMilestonesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetPublicMilestones200Response> response = apiInstance.Destiny2GetPublicMilestonesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetPublicMilestonesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Destiny2GetPublicMilestones200Response**](Destiny2GetPublicMilestones200Response.md)

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

<a id="destiny2getpublicvendors"></a>
# **Destiny2GetPublicVendors**
> Destiny2GetPublicVendors200Response Destiny2GetPublicVendors (List<int>? components = null)



Get items available from vendors where the vendors have items for sale that are common for everyone. If any portion of the Vendor's available inventory is character or account specific, we will be unable to return their data from this endpoint due to the way that available inventory is computed. As I am often guilty of saying: 'It's a long story...'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetPublicVendorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var components = new List<int>?(); // List<int>? | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                Destiny2GetPublicVendors200Response result = apiInstance.Destiny2GetPublicVendors(components);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetPublicVendors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetPublicVendorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetPublicVendors200Response> response = apiInstance.Destiny2GetPublicVendorsWithHttpInfo(components);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetPublicVendorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **components** | [**List&lt;int&gt;?**](int.md) | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional]  |

### Return type

[**Destiny2GetPublicVendors200Response**](Destiny2GetPublicVendors200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A response containing all valid components for the public Vendors endpoint.   It is a decisively smaller subset of data compared to what we can get when we know the specific user making the request.   If you want any of the other data - item details, whether or not you can buy it, etc... you&#39;ll have to call in the context of a character. I know, sad but true. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getuniqueweaponhistory"></a>
# **Destiny2GetUniqueWeaponHistory**
> Destiny2GetUniqueWeaponHistory200Response Destiny2GetUniqueWeaponHistory (long characterId, long destinyMembershipId, int membershipType)



Gets details about unique weapon usage, including all exotic weapons.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetUniqueWeaponHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var characterId = 789L;  // long | The id of the character to retrieve.
            var destinyMembershipId = 789L;  // long | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.

            try
            {
                Destiny2GetUniqueWeaponHistory200Response result = apiInstance.Destiny2GetUniqueWeaponHistory(characterId, destinyMembershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetUniqueWeaponHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetUniqueWeaponHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetUniqueWeaponHistory200Response> response = apiInstance.Destiny2GetUniqueWeaponHistoryWithHttpInfo(characterId, destinyMembershipId, membershipType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetUniqueWeaponHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **characterId** | **long** | The id of the character to retrieve. |  |
| **destinyMembershipId** | **long** | The Destiny membershipId of the user to retrieve. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |

### Return type

[**Destiny2GetUniqueWeaponHistory200Response**](Destiny2GetUniqueWeaponHistory200Response.md)

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

<a id="destiny2getvendor"></a>
# **Destiny2GetVendor**
> Destiny2GetVendor200Response Destiny2GetVendor (long characterId, long destinyMembershipId, int membershipType, int vendorHash, List<int>? components = null)



Get the details of a specific Vendor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetVendorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var characterId = 789L;  // long | The Destiny Character ID of the character for whom we're getting vendor info.
            var destinyMembershipId = 789L;  // long | Destiny membership ID of another user. You may be denied.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.
            var vendorHash = 56;  // int | The Hash identifier of the Vendor to be returned.
            var components = new List<int>?(); // List<int>? | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                Destiny2GetVendor200Response result = apiInstance.Destiny2GetVendor(characterId, destinyMembershipId, membershipType, vendorHash, components);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetVendor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetVendorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetVendor200Response> response = apiInstance.Destiny2GetVendorWithHttpInfo(characterId, destinyMembershipId, membershipType, vendorHash, components);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetVendorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **characterId** | **long** | The Destiny Character ID of the character for whom we&#39;re getting vendor info. |  |
| **destinyMembershipId** | **long** | Destiny membership ID of another user. You may be denied. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |
| **vendorHash** | **int** | The Hash identifier of the Vendor to be returned. |  |
| **components** | [**List&lt;int&gt;?**](int.md) | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional]  |

### Return type

[**Destiny2GetVendor200Response**](Destiny2GetVendor200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A response containing all of the components for a vendor. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2getvendors"></a>
# **Destiny2GetVendors**
> Destiny2GetVendors200Response Destiny2GetVendors (long characterId, long destinyMembershipId, int membershipType, List<int>? components = null, int? filter = null)



Get currently available vendors from the list of vendors that can possibly have rotating inventory. Note that this does not include things like preview vendors and vendors-as-kiosks, neither of whom have rotating/dynamic inventories. Use their definitions as-is for those.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2GetVendorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var characterId = 789L;  // long | The Destiny Character ID of the character for whom we're getting vendor info.
            var destinyMembershipId = 789L;  // long | Destiny membership ID of another user. You may be denied.
            var membershipType = 56;  // int | A valid non-BungieNet membership type.
            var components = new List<int>?(); // List<int>? | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 
            var filter = 56;  // int? | The filter of what vendors and items to return, if any. (optional) 

            try
            {
                Destiny2GetVendors200Response result = apiInstance.Destiny2GetVendors(characterId, destinyMembershipId, membershipType, components, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetVendors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2GetVendorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2GetVendors200Response> response = apiInstance.Destiny2GetVendorsWithHttpInfo(characterId, destinyMembershipId, membershipType, components, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2GetVendorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **characterId** | **long** | The Destiny Character ID of the character for whom we&#39;re getting vendor info. |  |
| **destinyMembershipId** | **long** | Destiny membership ID of another user. You may be denied. |  |
| **membershipType** | **int** | A valid non-BungieNet membership type. |  |
| **components** | [**List&lt;int&gt;?**](int.md) | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional]  |
| **filter** | **int?** | The filter of what vendors and items to return, if any. | [optional]  |

### Return type

[**Destiny2GetVendors200Response**](Destiny2GetVendors200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A response containing all of the components for all requested vendors. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2insertsocketplug"></a>
# **Destiny2InsertSocketPlug**
> Destiny2InsertSocketPlug200Response Destiny2InsertSocketPlug (DestinyRequestsActionsDestinyInsertPlugsActionRequest destinyRequestsActionsDestinyInsertPlugsActionRequest)



Insert a plug into a socketed item. I know how it sounds, but I assure you it's much more G-rated than you might be guessing. We haven't decided yet whether this will be able to insert plugs that have side effects, but if we do it will require special scope permission for an application attempting to do so. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Request must include proof of permission for 'InsertPlugs' from the account owner.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2InsertSocketPlugExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var destinyRequestsActionsDestinyInsertPlugsActionRequest = new DestinyRequestsActionsDestinyInsertPlugsActionRequest(); // DestinyRequestsActionsDestinyInsertPlugsActionRequest | 

            try
            {
                Destiny2InsertSocketPlug200Response result = apiInstance.Destiny2InsertSocketPlug(destinyRequestsActionsDestinyInsertPlugsActionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2InsertSocketPlug: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2InsertSocketPlugWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2InsertSocketPlug200Response> response = apiInstance.Destiny2InsertSocketPlugWithHttpInfo(destinyRequestsActionsDestinyInsertPlugsActionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2InsertSocketPlugWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsActionsDestinyInsertPlugsActionRequest** | [**DestinyRequestsActionsDestinyInsertPlugsActionRequest**](DestinyRequestsActionsDestinyInsertPlugsActionRequest.md) |  |  |

### Return type

[**Destiny2InsertSocketPlug200Response**](Destiny2InsertSocketPlug200Response.md)

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

<a id="destiny2insertsocketplugfree"></a>
# **Destiny2InsertSocketPlugFree**
> Destiny2InsertSocketPlug200Response Destiny2InsertSocketPlugFree (DestinyRequestsActionsDestinyInsertPlugsFreeActionRequest destinyRequestsActionsDestinyInsertPlugsFreeActionRequest)



Insert a 'free' plug into an item's socket. This does not require 'Advanced Write Action' authorization and is available to 3rd-party apps, but will only work on 'free and reversible' socket actions (Perks, Armor Mods, Shaders, Ornaments, etc.). You must have a valid Destiny Account, and the character must either be in a social space, in orbit, or offline.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2InsertSocketPlugFreeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var destinyRequestsActionsDestinyInsertPlugsFreeActionRequest = new DestinyRequestsActionsDestinyInsertPlugsFreeActionRequest(); // DestinyRequestsActionsDestinyInsertPlugsFreeActionRequest | 

            try
            {
                Destiny2InsertSocketPlug200Response result = apiInstance.Destiny2InsertSocketPlugFree(destinyRequestsActionsDestinyInsertPlugsFreeActionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2InsertSocketPlugFree: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2InsertSocketPlugFreeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2InsertSocketPlug200Response> response = apiInstance.Destiny2InsertSocketPlugFreeWithHttpInfo(destinyRequestsActionsDestinyInsertPlugsFreeActionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2InsertSocketPlugFreeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsActionsDestinyInsertPlugsFreeActionRequest** | [**DestinyRequestsActionsDestinyInsertPlugsFreeActionRequest**](DestinyRequestsActionsDestinyInsertPlugsFreeActionRequest.md) |  |  |

### Return type

[**Destiny2InsertSocketPlug200Response**](Destiny2InsertSocketPlug200Response.md)

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

<a id="destiny2pullfrompostmaster"></a>
# **Destiny2PullFromPostmaster**
> GroupV2EditGroup200Response Destiny2PullFromPostmaster (DestinyRequestsActionsDestinyPostmasterTransferRequest destinyRequestsActionsDestinyPostmasterTransferRequest)



Extract an item from the Postmaster, with whatever implications that may entail. You must have a valid Destiny account. You must also pass BOTH a reference AND an instance ID if it's an instanced item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2PullFromPostmasterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var destinyRequestsActionsDestinyPostmasterTransferRequest = new DestinyRequestsActionsDestinyPostmasterTransferRequest(); // DestinyRequestsActionsDestinyPostmasterTransferRequest | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.Destiny2PullFromPostmaster(destinyRequestsActionsDestinyPostmasterTransferRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2PullFromPostmaster: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2PullFromPostmasterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.Destiny2PullFromPostmasterWithHttpInfo(destinyRequestsActionsDestinyPostmasterTransferRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2PullFromPostmasterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsActionsDestinyPostmasterTransferRequest** | [**DestinyRequestsActionsDestinyPostmasterTransferRequest**](DestinyRequestsActionsDestinyPostmasterTransferRequest.md) |  |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

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

<a id="destiny2reportoffensivepostgamecarnagereportplayer"></a>
# **Destiny2ReportOffensivePostGameCarnageReportPlayer**
> GroupV2EditGroup200Response Destiny2ReportOffensivePostGameCarnageReportPlayer (long activityId, DestinyReportingRequestsDestinyReportOffensePgcrRequest destinyReportingRequestsDestinyReportOffensePgcrRequest)



Report a player that you met in an activity that was engaging in ToS-violating activities. Both you and the offending player must have played in the activityId passed in. Please use this judiciously and only when you have strong suspicions of violation, pretty please.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2ReportOffensivePostGameCarnageReportPlayerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var activityId = 789L;  // long | The ID of the activity where you ran into the brigand that you're reporting.
            var destinyReportingRequestsDestinyReportOffensePgcrRequest = new DestinyReportingRequestsDestinyReportOffensePgcrRequest(); // DestinyReportingRequestsDestinyReportOffensePgcrRequest | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.Destiny2ReportOffensivePostGameCarnageReportPlayer(activityId, destinyReportingRequestsDestinyReportOffensePgcrRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2ReportOffensivePostGameCarnageReportPlayer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2ReportOffensivePostGameCarnageReportPlayerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.Destiny2ReportOffensivePostGameCarnageReportPlayerWithHttpInfo(activityId, destinyReportingRequestsDestinyReportOffensePgcrRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2ReportOffensivePostGameCarnageReportPlayerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activityId** | **long** | The ID of the activity where you ran into the brigand that you&#39;re reporting. |  |
| **destinyReportingRequestsDestinyReportOffensePgcrRequest** | [**DestinyReportingRequestsDestinyReportOffensePgcrRequest**](DestinyReportingRequestsDestinyReportOffensePgcrRequest.md) |  |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

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

<a id="destiny2searchdestinyentities"></a>
# **Destiny2SearchDestinyEntities**
> Destiny2SearchDestinyEntities200Response Destiny2SearchDestinyEntities (string searchTerm, string type, int? page = null)



Gets a page list of Destiny items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2SearchDestinyEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var searchTerm = "searchTerm_example";  // string | The string to use when searching for Destiny entities.
            var type = "type_example";  // string | The type of entity for whom you would like results. These correspond to the entity's definition contract name. For instance, if you are looking for items, this property should be 'DestinyInventoryItemDefinition'.
            var page = 56;  // int? | Page number to return, starting with 0. (optional) 

            try
            {
                Destiny2SearchDestinyEntities200Response result = apiInstance.Destiny2SearchDestinyEntities(searchTerm, type, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2SearchDestinyEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2SearchDestinyEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2SearchDestinyEntities200Response> response = apiInstance.Destiny2SearchDestinyEntitiesWithHttpInfo(searchTerm, type, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2SearchDestinyEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchTerm** | **string** | The string to use when searching for Destiny entities. |  |
| **type** | **string** | The type of entity for whom you would like results. These correspond to the entity&#39;s definition contract name. For instance, if you are looking for items, this property should be &#39;DestinyInventoryItemDefinition&#39;. |  |
| **page** | **int?** | Page number to return, starting with 0. | [optional]  |

### Return type

[**Destiny2SearchDestinyEntities200Response**](Destiny2SearchDestinyEntities200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The results of a search for Destiny content. This will be improved on over time, I&#39;ve been doing some experimenting to see what might be useful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2searchdestinyplayerbybungiename"></a>
# **Destiny2SearchDestinyPlayerByBungieName**
> Destiny2SearchDestinyPlayerByBungieName200Response Destiny2SearchDestinyPlayerByBungieName (int membershipType, UserExactSearchRequest userExactSearchRequest)



Returns a list of Destiny memberships given a global Bungie Display Name. This method will hide overridden memberships due to cross save.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2SearchDestinyPlayerByBungieNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new Destiny2Api(config);
            var membershipType = 56;  // int | A valid non-BungieNet membership type, or All. Indicates which memberships to return. You probably want this set to All.
            var userExactSearchRequest = new UserExactSearchRequest(); // UserExactSearchRequest | 

            try
            {
                Destiny2SearchDestinyPlayerByBungieName200Response result = apiInstance.Destiny2SearchDestinyPlayerByBungieName(membershipType, userExactSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2SearchDestinyPlayerByBungieName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2SearchDestinyPlayerByBungieNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Destiny2SearchDestinyPlayerByBungieName200Response> response = apiInstance.Destiny2SearchDestinyPlayerByBungieNameWithHttpInfo(membershipType, userExactSearchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2SearchDestinyPlayerByBungieNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **membershipType** | **int** | A valid non-BungieNet membership type, or All. Indicates which memberships to return. You probably want this set to All. |  |
| **userExactSearchRequest** | [**UserExactSearchRequest**](UserExactSearchRequest.md) |  |  |

### Return type

[**Destiny2SearchDestinyPlayerByBungieName200Response**](Destiny2SearchDestinyPlayerByBungieName200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="destiny2setitemlockstate"></a>
# **Destiny2SetItemLockState**
> GroupV2EditGroup200Response Destiny2SetItemLockState (DestinyRequestsActionsDestinyItemStateRequest destinyRequestsActionsDestinyItemStateRequest)



Set the Lock State for an instanced item. You must have a valid Destiny Account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2SetItemLockStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var destinyRequestsActionsDestinyItemStateRequest = new DestinyRequestsActionsDestinyItemStateRequest(); // DestinyRequestsActionsDestinyItemStateRequest | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.Destiny2SetItemLockState(destinyRequestsActionsDestinyItemStateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2SetItemLockState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2SetItemLockStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.Destiny2SetItemLockStateWithHttpInfo(destinyRequestsActionsDestinyItemStateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2SetItemLockStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsActionsDestinyItemStateRequest** | [**DestinyRequestsActionsDestinyItemStateRequest**](DestinyRequestsActionsDestinyItemStateRequest.md) |  |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

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

<a id="destiny2setquesttrackedstate"></a>
# **Destiny2SetQuestTrackedState**
> GroupV2EditGroup200Response Destiny2SetQuestTrackedState (DestinyRequestsActionsDestinyItemStateRequest destinyRequestsActionsDestinyItemStateRequest)



Set the Tracking State for an instanced item, if that item is a Quest or Bounty. You must have a valid Destiny Account. Yeah, it's an item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2SetQuestTrackedStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var destinyRequestsActionsDestinyItemStateRequest = new DestinyRequestsActionsDestinyItemStateRequest(); // DestinyRequestsActionsDestinyItemStateRequest | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.Destiny2SetQuestTrackedState(destinyRequestsActionsDestinyItemStateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2SetQuestTrackedState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2SetQuestTrackedStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.Destiny2SetQuestTrackedStateWithHttpInfo(destinyRequestsActionsDestinyItemStateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2SetQuestTrackedStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsActionsDestinyItemStateRequest** | [**DestinyRequestsActionsDestinyItemStateRequest**](DestinyRequestsActionsDestinyItemStateRequest.md) |  |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

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

<a id="destiny2snapshotloadout"></a>
# **Destiny2SnapshotLoadout**
> GroupV2EditGroup200Response Destiny2SnapshotLoadout (DestinyRequestsActionsDestinyLoadoutUpdateActionRequest destinyRequestsActionsDestinyLoadoutUpdateActionRequest)



Snapshot a loadout with the currently equipped items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2SnapshotLoadoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var destinyRequestsActionsDestinyLoadoutUpdateActionRequest = new DestinyRequestsActionsDestinyLoadoutUpdateActionRequest(); // DestinyRequestsActionsDestinyLoadoutUpdateActionRequest | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.Destiny2SnapshotLoadout(destinyRequestsActionsDestinyLoadoutUpdateActionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2SnapshotLoadout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2SnapshotLoadoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.Destiny2SnapshotLoadoutWithHttpInfo(destinyRequestsActionsDestinyLoadoutUpdateActionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2SnapshotLoadoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsActionsDestinyLoadoutUpdateActionRequest** | [**DestinyRequestsActionsDestinyLoadoutUpdateActionRequest**](DestinyRequestsActionsDestinyLoadoutUpdateActionRequest.md) |  |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

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

<a id="destiny2transferitem"></a>
# **Destiny2TransferItem**
> GroupV2EditGroup200Response Destiny2TransferItem (DestinyRequestsDestinyItemTransferRequest destinyRequestsDestinyItemTransferRequest)



Transfer an item to/from your vault. You must have a valid Destiny account. You must also pass BOTH a reference AND an instance ID if it's an instanced item. itshappening.gif

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2TransferItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var destinyRequestsDestinyItemTransferRequest = new DestinyRequestsDestinyItemTransferRequest(); // DestinyRequestsDestinyItemTransferRequest | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.Destiny2TransferItem(destinyRequestsDestinyItemTransferRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2TransferItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2TransferItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.Destiny2TransferItemWithHttpInfo(destinyRequestsDestinyItemTransferRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2TransferItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsDestinyItemTransferRequest** | [**DestinyRequestsDestinyItemTransferRequest**](DestinyRequestsDestinyItemTransferRequest.md) |  |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

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

<a id="destiny2updateloadoutidentifiers"></a>
# **Destiny2UpdateLoadoutIdentifiers**
> GroupV2EditGroup200Response Destiny2UpdateLoadoutIdentifiers (DestinyRequestsActionsDestinyLoadoutUpdateActionRequest destinyRequestsActionsDestinyLoadoutUpdateActionRequest)



Update the color, icon, and name of a loadout.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class Destiny2UpdateLoadoutIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api(config);
            var destinyRequestsActionsDestinyLoadoutUpdateActionRequest = new DestinyRequestsActionsDestinyLoadoutUpdateActionRequest(); // DestinyRequestsActionsDestinyLoadoutUpdateActionRequest | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.Destiny2UpdateLoadoutIdentifiers(destinyRequestsActionsDestinyLoadoutUpdateActionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2UpdateLoadoutIdentifiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Destiny2UpdateLoadoutIdentifiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.Destiny2UpdateLoadoutIdentifiersWithHttpInfo(destinyRequestsActionsDestinyLoadoutUpdateActionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Destiny2Api.Destiny2UpdateLoadoutIdentifiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **destinyRequestsActionsDestinyLoadoutUpdateActionRequest** | [**DestinyRequestsActionsDestinyLoadoutUpdateActionRequest**](DestinyRequestsActionsDestinyLoadoutUpdateActionRequest.md) |  |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

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

