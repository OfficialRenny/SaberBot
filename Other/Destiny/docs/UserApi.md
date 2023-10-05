# Destiny.Api.UserApi

All URIs are relative to *https://www.bungie.net/Platform*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserGetAvailableThemes**](UserApi.md#usergetavailablethemes) | **GET** /User/GetAvailableThemes/ |  |
| [**UserGetBungieNetUserById**](UserApi.md#usergetbungienetuserbyid) | **GET** /User/GetBungieNetUserById/{id}/ |  |
| [**UserGetCredentialTypesForTargetAccount**](UserApi.md#usergetcredentialtypesfortargetaccount) | **GET** /User/GetCredentialTypesForTargetAccount/{membershipId}/ |  |
| [**UserGetMembershipDataById**](UserApi.md#usergetmembershipdatabyid) | **GET** /User/GetMembershipsById/{membershipId}/{membershipType}/ |  |
| [**UserGetMembershipDataForCurrentUser**](UserApi.md#usergetmembershipdataforcurrentuser) | **GET** /User/GetMembershipsForCurrentUser/ |  |
| [**UserGetMembershipFromHardLinkedCredential**](UserApi.md#usergetmembershipfromhardlinkedcredential) | **GET** /User/GetMembershipFromHardLinkedCredential/{crType}/{credential}/ |  |
| [**UserGetSanitizedPlatformDisplayNames**](UserApi.md#usergetsanitizedplatformdisplaynames) | **GET** /User/GetSanitizedPlatformDisplayNames/{membershipId}/ |  |
| [**UserSearchByGlobalNamePost**](UserApi.md#usersearchbyglobalnamepost) | **POST** /User/Search/GlobalName/{page}/ |  |
| [**UserSearchByGlobalNamePrefix**](UserApi.md#usersearchbyglobalnameprefix) | **GET** /User/Search/Prefix/{displayNamePrefix}/{page}/ |  |

<a id="usergetavailablethemes"></a>
# **UserGetAvailableThemes**
> UserGetAvailableThemes200Response UserGetAvailableThemes ()



Returns a list of all available user themes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class UserGetAvailableThemesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new UserApi(config);

            try
            {
                UserGetAvailableThemes200Response result = apiInstance.UserGetAvailableThemes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetAvailableThemes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetAvailableThemesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserGetAvailableThemes200Response> response = apiInstance.UserGetAvailableThemesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetAvailableThemesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserGetAvailableThemes200Response**](UserGetAvailableThemes200Response.md)

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

<a id="usergetbungienetuserbyid"></a>
# **UserGetBungieNetUserById**
> UserGetBungieNetUserById200Response UserGetBungieNetUserById (long id)



Loads a bungienet user by membership id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class UserGetBungieNetUserByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new UserApi(config);
            var id = 789L;  // long | The requested Bungie.net membership id.

            try
            {
                UserGetBungieNetUserById200Response result = apiInstance.UserGetBungieNetUserById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetBungieNetUserById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetBungieNetUserByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserGetBungieNetUserById200Response> response = apiInstance.UserGetBungieNetUserByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetBungieNetUserByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The requested Bungie.net membership id. |  |

### Return type

[**UserGetBungieNetUserById200Response**](UserGetBungieNetUserById200Response.md)

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

<a id="usergetcredentialtypesfortargetaccount"></a>
# **UserGetCredentialTypesForTargetAccount**
> UserGetCredentialTypesForTargetAccount200Response UserGetCredentialTypesForTargetAccount (long membershipId)



Returns a list of credential types attached to the requested account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class UserGetCredentialTypesForTargetAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new UserApi(config);
            var membershipId = 789L;  // long | The user's membership id

            try
            {
                UserGetCredentialTypesForTargetAccount200Response result = apiInstance.UserGetCredentialTypesForTargetAccount(membershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetCredentialTypesForTargetAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetCredentialTypesForTargetAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserGetCredentialTypesForTargetAccount200Response> response = apiInstance.UserGetCredentialTypesForTargetAccountWithHttpInfo(membershipId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetCredentialTypesForTargetAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **membershipId** | **long** | The user&#39;s membership id |  |

### Return type

[**UserGetCredentialTypesForTargetAccount200Response**](UserGetCredentialTypesForTargetAccount200Response.md)

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

<a id="usergetmembershipdatabyid"></a>
# **UserGetMembershipDataById**
> UserGetMembershipDataById200Response UserGetMembershipDataById (long membershipId, int membershipType)



Returns a list of accounts associated with the supplied membership ID and membership type. This will include all linked accounts (even when hidden) if supplied credentials permit it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class UserGetMembershipDataByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new UserApi(config);
            var membershipId = 789L;  // long | The membership ID of the target user.
            var membershipType = 56;  // int | Type of the supplied membership ID.

            try
            {
                UserGetMembershipDataById200Response result = apiInstance.UserGetMembershipDataById(membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetMembershipDataById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetMembershipDataByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserGetMembershipDataById200Response> response = apiInstance.UserGetMembershipDataByIdWithHttpInfo(membershipId, membershipType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetMembershipDataByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **membershipId** | **long** | The membership ID of the target user. |  |
| **membershipType** | **int** | Type of the supplied membership ID. |  |

### Return type

[**UserGetMembershipDataById200Response**](UserGetMembershipDataById200Response.md)

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

<a id="usergetmembershipdataforcurrentuser"></a>
# **UserGetMembershipDataForCurrentUser**
> UserGetMembershipDataById200Response UserGetMembershipDataForCurrentUser ()



Returns a list of accounts associated with signed in user. This is useful for OAuth implementations that do not give you access to the token response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class UserGetMembershipDataForCurrentUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi(config);

            try
            {
                UserGetMembershipDataById200Response result = apiInstance.UserGetMembershipDataForCurrentUser();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetMembershipDataForCurrentUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetMembershipDataForCurrentUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserGetMembershipDataById200Response> response = apiInstance.UserGetMembershipDataForCurrentUserWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetMembershipDataForCurrentUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserGetMembershipDataById200Response**](UserGetMembershipDataById200Response.md)

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

<a id="usergetmembershipfromhardlinkedcredential"></a>
# **UserGetMembershipFromHardLinkedCredential**
> UserGetMembershipFromHardLinkedCredential200Response UserGetMembershipFromHardLinkedCredential (string credential, int crType)



Gets any hard linked membership given a credential. Only works for credentials that are public (just SteamID64 right now). Cross Save aware.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class UserGetMembershipFromHardLinkedCredentialExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new UserApi(config);
            var credential = "credential_example";  // string | The credential to look up. Must be a valid SteamID64.
            var crType = 56;  // int | The credential type. 'SteamId' is the only valid value at present.

            try
            {
                UserGetMembershipFromHardLinkedCredential200Response result = apiInstance.UserGetMembershipFromHardLinkedCredential(credential, crType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetMembershipFromHardLinkedCredential: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetMembershipFromHardLinkedCredentialWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserGetMembershipFromHardLinkedCredential200Response> response = apiInstance.UserGetMembershipFromHardLinkedCredentialWithHttpInfo(credential, crType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetMembershipFromHardLinkedCredentialWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **credential** | **string** | The credential to look up. Must be a valid SteamID64. |  |
| **crType** | **int** | The credential type. &#39;SteamId&#39; is the only valid value at present. |  |

### Return type

[**UserGetMembershipFromHardLinkedCredential200Response**](UserGetMembershipFromHardLinkedCredential200Response.md)

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

<a id="usergetsanitizedplatformdisplaynames"></a>
# **UserGetSanitizedPlatformDisplayNames**
> UserGetSanitizedPlatformDisplayNames200Response UserGetSanitizedPlatformDisplayNames (long membershipId)



Gets a list of all display names linked to this membership id but sanitized (profanity filtered). Obeys all visibility rules of calling user and is heavily cached.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class UserGetSanitizedPlatformDisplayNamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new UserApi(config);
            var membershipId = 789L;  // long | The requested membership id to load.

            try
            {
                UserGetSanitizedPlatformDisplayNames200Response result = apiInstance.UserGetSanitizedPlatformDisplayNames(membershipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetSanitizedPlatformDisplayNames: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetSanitizedPlatformDisplayNamesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserGetSanitizedPlatformDisplayNames200Response> response = apiInstance.UserGetSanitizedPlatformDisplayNamesWithHttpInfo(membershipId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetSanitizedPlatformDisplayNamesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **membershipId** | **long** | The requested membership id to load. |  |

### Return type

[**UserGetSanitizedPlatformDisplayNames200Response**](UserGetSanitizedPlatformDisplayNames200Response.md)

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

<a id="usersearchbyglobalnamepost"></a>
# **UserSearchByGlobalNamePost**
> UserSearchByGlobalNamePrefix200Response UserSearchByGlobalNamePost (int page, UserUserSearchPrefixRequest userUserSearchPrefixRequest)



Given the prefix of a global display name, returns all users who share that name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class UserSearchByGlobalNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new UserApi(config);
            var page = 56;  // int | The zero-based page of results you desire.
            var userUserSearchPrefixRequest = new UserUserSearchPrefixRequest(); // UserUserSearchPrefixRequest | 

            try
            {
                UserSearchByGlobalNamePrefix200Response result = apiInstance.UserSearchByGlobalNamePost(page, userUserSearchPrefixRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSearchByGlobalNamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSearchByGlobalNamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSearchByGlobalNamePrefix200Response> response = apiInstance.UserSearchByGlobalNamePostWithHttpInfo(page, userUserSearchPrefixRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserSearchByGlobalNamePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | The zero-based page of results you desire. |  |
| **userUserSearchPrefixRequest** | [**UserUserSearchPrefixRequest**](UserUserSearchPrefixRequest.md) |  |  |

### Return type

[**UserSearchByGlobalNamePrefix200Response**](UserSearchByGlobalNamePrefix200Response.md)

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

<a id="usersearchbyglobalnameprefix"></a>
# **UserSearchByGlobalNamePrefix**
> UserSearchByGlobalNamePrefix200Response UserSearchByGlobalNamePrefix (string displayNamePrefix, int page)



[OBSOLETE] Do not use this to search users, use SearchByGlobalNamePost instead.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class UserSearchByGlobalNamePrefixExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new UserApi(config);
            var displayNamePrefix = "displayNamePrefix_example";  // string | The display name prefix you're looking for.
            var page = 56;  // int | The zero-based page of results you desire.

            try
            {
                UserSearchByGlobalNamePrefix200Response result = apiInstance.UserSearchByGlobalNamePrefix(displayNamePrefix, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSearchByGlobalNamePrefix: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSearchByGlobalNamePrefixWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserSearchByGlobalNamePrefix200Response> response = apiInstance.UserSearchByGlobalNamePrefixWithHttpInfo(displayNamePrefix, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserSearchByGlobalNamePrefixWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **displayNamePrefix** | **string** | The display name prefix you&#39;re looking for. |  |
| **page** | **int** | The zero-based page of results you desire. |  |

### Return type

[**UserSearchByGlobalNamePrefix200Response**](UserSearchByGlobalNamePrefix200Response.md)

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

