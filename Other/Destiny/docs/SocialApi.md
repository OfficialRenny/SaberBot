# Destiny.Api.SocialApi

All URIs are relative to *https://www.bungie.net/Platform*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SocialAcceptFriendRequest**](SocialApi.md#socialacceptfriendrequest) | **POST** /Social/Friends/Requests/Accept/{membershipId}/ |  |
| [**SocialDeclineFriendRequest**](SocialApi.md#socialdeclinefriendrequest) | **POST** /Social/Friends/Requests/Decline/{membershipId}/ |  |
| [**SocialGetFriendList**](SocialApi.md#socialgetfriendlist) | **GET** /Social/Friends/ |  |
| [**SocialGetFriendRequestList**](SocialApi.md#socialgetfriendrequestlist) | **GET** /Social/Friends/Requests/ |  |
| [**SocialGetPlatformFriendList**](SocialApi.md#socialgetplatformfriendlist) | **GET** /Social/PlatformFriends/{friendPlatform}/{page}/ |  |
| [**SocialIssueFriendRequest**](SocialApi.md#socialissuefriendrequest) | **POST** /Social/Friends/Add/{membershipId}/ |  |
| [**SocialRemoveFriend**](SocialApi.md#socialremovefriend) | **POST** /Social/Friends/Remove/{membershipId}/ |  |
| [**SocialRemoveFriendRequest**](SocialApi.md#socialremovefriendrequest) | **POST** /Social/Friends/Requests/Remove/{membershipId}/ |  |

<a id="socialacceptfriendrequest"></a>
# **SocialAcceptFriendRequest**
> GroupV2GetUserClanInviteSetting200Response SocialAcceptFriendRequest (string membershipId)



Accepts a friend relationship with the target user. The user must be on your incoming friend request list, though no error will occur if they are not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class SocialAcceptFriendRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi(config);
            var membershipId = "membershipId_example";  // string | The membership id of the user you wish to accept.

            try
            {
                GroupV2GetUserClanInviteSetting200Response result = apiInstance.SocialAcceptFriendRequest(membershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SocialApi.SocialAcceptFriendRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SocialAcceptFriendRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetUserClanInviteSetting200Response> response = apiInstance.SocialAcceptFriendRequestWithHttpInfo(membershipId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SocialApi.SocialAcceptFriendRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **membershipId** | **string** | The membership id of the user you wish to accept. |  |

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

<a id="socialdeclinefriendrequest"></a>
# **SocialDeclineFriendRequest**
> GroupV2GetUserClanInviteSetting200Response SocialDeclineFriendRequest (string membershipId)



Declines a friend relationship with the target user. The user must be on your incoming friend request list, though no error will occur if they are not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class SocialDeclineFriendRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi(config);
            var membershipId = "membershipId_example";  // string | The membership id of the user you wish to decline.

            try
            {
                GroupV2GetUserClanInviteSetting200Response result = apiInstance.SocialDeclineFriendRequest(membershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SocialApi.SocialDeclineFriendRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SocialDeclineFriendRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetUserClanInviteSetting200Response> response = apiInstance.SocialDeclineFriendRequestWithHttpInfo(membershipId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SocialApi.SocialDeclineFriendRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **membershipId** | **string** | The membership id of the user you wish to decline. |  |

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

<a id="socialgetfriendlist"></a>
# **SocialGetFriendList**
> SocialGetFriendList200Response SocialGetFriendList ()



Returns your Bungie Friend list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class SocialGetFriendListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi(config);

            try
            {
                SocialGetFriendList200Response result = apiInstance.SocialGetFriendList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SocialApi.SocialGetFriendList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SocialGetFriendListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SocialGetFriendList200Response> response = apiInstance.SocialGetFriendListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SocialApi.SocialGetFriendListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SocialGetFriendList200Response**](SocialGetFriendList200Response.md)

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

<a id="socialgetfriendrequestlist"></a>
# **SocialGetFriendRequestList**
> SocialGetFriendRequestList200Response SocialGetFriendRequestList ()



Returns your friend request queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class SocialGetFriendRequestListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi(config);

            try
            {
                SocialGetFriendRequestList200Response result = apiInstance.SocialGetFriendRequestList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SocialApi.SocialGetFriendRequestList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SocialGetFriendRequestListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SocialGetFriendRequestList200Response> response = apiInstance.SocialGetFriendRequestListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SocialApi.SocialGetFriendRequestListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SocialGetFriendRequestList200Response**](SocialGetFriendRequestList200Response.md)

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

<a id="socialgetplatformfriendlist"></a>
# **SocialGetPlatformFriendList**
> SocialGetPlatformFriendList200Response SocialGetPlatformFriendList (int friendPlatform, string page)



Gets the platform friend of the requested type, with additional information if they have Bungie accounts. Must have a recent login session with said platform.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class SocialGetPlatformFriendListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new SocialApi(config);
            var friendPlatform = 56;  // int | The platform friend type.
            var page = "page_example";  // string | The zero based page to return. Page size is 100.

            try
            {
                SocialGetPlatformFriendList200Response result = apiInstance.SocialGetPlatformFriendList(friendPlatform, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SocialApi.SocialGetPlatformFriendList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SocialGetPlatformFriendListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SocialGetPlatformFriendList200Response> response = apiInstance.SocialGetPlatformFriendListWithHttpInfo(friendPlatform, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SocialApi.SocialGetPlatformFriendListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **friendPlatform** | **int** | The platform friend type. |  |
| **page** | **string** | The zero based page to return. Page size is 100. |  |

### Return type

[**SocialGetPlatformFriendList200Response**](SocialGetPlatformFriendList200Response.md)

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

<a id="socialissuefriendrequest"></a>
# **SocialIssueFriendRequest**
> GroupV2GetUserClanInviteSetting200Response SocialIssueFriendRequest (string membershipId)



Requests a friend relationship with the target user. Any of the target user's linked membership ids are valid inputs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class SocialIssueFriendRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi(config);
            var membershipId = "membershipId_example";  // string | The membership id of the user you wish to add.

            try
            {
                GroupV2GetUserClanInviteSetting200Response result = apiInstance.SocialIssueFriendRequest(membershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SocialApi.SocialIssueFriendRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SocialIssueFriendRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetUserClanInviteSetting200Response> response = apiInstance.SocialIssueFriendRequestWithHttpInfo(membershipId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SocialApi.SocialIssueFriendRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **membershipId** | **string** | The membership id of the user you wish to add. |  |

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

<a id="socialremovefriend"></a>
# **SocialRemoveFriend**
> GroupV2GetUserClanInviteSetting200Response SocialRemoveFriend (string membershipId)



Remove a friend relationship with the target user. The user must be on your friend list, though no error will occur if they are not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class SocialRemoveFriendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi(config);
            var membershipId = "membershipId_example";  // string | The membership id of the user you wish to remove.

            try
            {
                GroupV2GetUserClanInviteSetting200Response result = apiInstance.SocialRemoveFriend(membershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SocialApi.SocialRemoveFriend: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SocialRemoveFriendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetUserClanInviteSetting200Response> response = apiInstance.SocialRemoveFriendWithHttpInfo(membershipId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SocialApi.SocialRemoveFriendWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **membershipId** | **string** | The membership id of the user you wish to remove. |  |

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

<a id="socialremovefriendrequest"></a>
# **SocialRemoveFriendRequest**
> GroupV2GetUserClanInviteSetting200Response SocialRemoveFriendRequest (string membershipId)



Remove a friend relationship with the target user. The user must be on your outgoing request friend list, though no error will occur if they are not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class SocialRemoveFriendRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi(config);
            var membershipId = "membershipId_example";  // string | The membership id of the user you wish to remove.

            try
            {
                GroupV2GetUserClanInviteSetting200Response result = apiInstance.SocialRemoveFriendRequest(membershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SocialApi.SocialRemoveFriendRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SocialRemoveFriendRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetUserClanInviteSetting200Response> response = apiInstance.SocialRemoveFriendRequestWithHttpInfo(membershipId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SocialApi.SocialRemoveFriendRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **membershipId** | **string** | The membership id of the user you wish to remove. |  |

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

