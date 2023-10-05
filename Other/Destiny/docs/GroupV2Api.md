# Destiny.Api.GroupV2Api

All URIs are relative to *https://www.bungie.net/Platform*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GroupV2AbdicateFoundership**](GroupV2Api.md#groupv2abdicatefoundership) | **POST** /GroupV2/{groupId}/Admin/AbdicateFoundership/{membershipType}/{founderIdNew}/ |  |
| [**GroupV2AddOptionalConversation**](GroupV2Api.md#groupv2addoptionalconversation) | **POST** /GroupV2/{groupId}/OptionalConversations/Add/ |  |
| [**GroupV2ApproveAllPending**](GroupV2Api.md#groupv2approveallpending) | **POST** /GroupV2/{groupId}/Members/ApproveAll/ |  |
| [**GroupV2ApprovePending**](GroupV2Api.md#groupv2approvepending) | **POST** /GroupV2/{groupId}/Members/Approve/{membershipType}/{membershipId}/ |  |
| [**GroupV2ApprovePendingForList**](GroupV2Api.md#groupv2approvependingforlist) | **POST** /GroupV2/{groupId}/Members/ApproveList/ |  |
| [**GroupV2BanMember**](GroupV2Api.md#groupv2banmember) | **POST** /GroupV2/{groupId}/Members/{membershipType}/{membershipId}/Ban/ |  |
| [**GroupV2DenyAllPending**](GroupV2Api.md#groupv2denyallpending) | **POST** /GroupV2/{groupId}/Members/DenyAll/ |  |
| [**GroupV2DenyPendingForList**](GroupV2Api.md#groupv2denypendingforlist) | **POST** /GroupV2/{groupId}/Members/DenyList/ |  |
| [**GroupV2EditClanBanner**](GroupV2Api.md#groupv2editclanbanner) | **POST** /GroupV2/{groupId}/EditClanBanner/ |  |
| [**GroupV2EditFounderOptions**](GroupV2Api.md#groupv2editfounderoptions) | **POST** /GroupV2/{groupId}/EditFounderOptions/ |  |
| [**GroupV2EditGroup**](GroupV2Api.md#groupv2editgroup) | **POST** /GroupV2/{groupId}/Edit/ |  |
| [**GroupV2EditGroupMembership**](GroupV2Api.md#groupv2editgroupmembership) | **POST** /GroupV2/{groupId}/Members/{membershipType}/{membershipId}/SetMembershipType/{memberType}/ |  |
| [**GroupV2EditOptionalConversation**](GroupV2Api.md#groupv2editoptionalconversation) | **POST** /GroupV2/{groupId}/OptionalConversations/Edit/{conversationId}/ |  |
| [**GroupV2GetAdminsAndFounderOfGroup**](GroupV2Api.md#groupv2getadminsandfounderofgroup) | **GET** /GroupV2/{groupId}/AdminsAndFounder/ |  |
| [**GroupV2GetAvailableAvatars**](GroupV2Api.md#groupv2getavailableavatars) | **GET** /GroupV2/GetAvailableAvatars/ |  |
| [**GroupV2GetAvailableThemes**](GroupV2Api.md#groupv2getavailablethemes) | **GET** /GroupV2/GetAvailableThemes/ |  |
| [**GroupV2GetBannedMembersOfGroup**](GroupV2Api.md#groupv2getbannedmembersofgroup) | **GET** /GroupV2/{groupId}/Banned/ |  |
| [**GroupV2GetGroup**](GroupV2Api.md#groupv2getgroup) | **GET** /GroupV2/{groupId}/ |  |
| [**GroupV2GetGroupByName**](GroupV2Api.md#groupv2getgroupbyname) | **GET** /GroupV2/Name/{groupName}/{groupType}/ |  |
| [**GroupV2GetGroupByNameV2**](GroupV2Api.md#groupv2getgroupbynamev2) | **POST** /GroupV2/NameV2/ |  |
| [**GroupV2GetGroupOptionalConversations**](GroupV2Api.md#groupv2getgroupoptionalconversations) | **GET** /GroupV2/{groupId}/OptionalConversations/ |  |
| [**GroupV2GetGroupsForMember**](GroupV2Api.md#groupv2getgroupsformember) | **GET** /GroupV2/User/{membershipType}/{membershipId}/{filter}/{groupType}/ |  |
| [**GroupV2GetInvitedIndividuals**](GroupV2Api.md#groupv2getinvitedindividuals) | **GET** /GroupV2/{groupId}/Members/InvitedIndividuals/ |  |
| [**GroupV2GetMembersOfGroup**](GroupV2Api.md#groupv2getmembersofgroup) | **GET** /GroupV2/{groupId}/Members/ |  |
| [**GroupV2GetPendingMemberships**](GroupV2Api.md#groupv2getpendingmemberships) | **GET** /GroupV2/{groupId}/Members/Pending/ |  |
| [**GroupV2GetPotentialGroupsForMember**](GroupV2Api.md#groupv2getpotentialgroupsformember) | **GET** /GroupV2/User/Potential/{membershipType}/{membershipId}/{filter}/{groupType}/ |  |
| [**GroupV2GetRecommendedGroups**](GroupV2Api.md#groupv2getrecommendedgroups) | **POST** /GroupV2/Recommended/{groupType}/{createDateRange}/ |  |
| [**GroupV2GetUserClanInviteSetting**](GroupV2Api.md#groupv2getuserclaninvitesetting) | **GET** /GroupV2/GetUserClanInviteSetting/{mType}/ |  |
| [**GroupV2GroupSearch**](GroupV2Api.md#groupv2groupsearch) | **POST** /GroupV2/Search/ |  |
| [**GroupV2IndividualGroupInvite**](GroupV2Api.md#groupv2individualgroupinvite) | **POST** /GroupV2/{groupId}/Members/IndividualInvite/{membershipType}/{membershipId}/ |  |
| [**GroupV2IndividualGroupInviteCancel**](GroupV2Api.md#groupv2individualgroupinvitecancel) | **POST** /GroupV2/{groupId}/Members/IndividualInviteCancel/{membershipType}/{membershipId}/ |  |
| [**GroupV2KickMember**](GroupV2Api.md#groupv2kickmember) | **POST** /GroupV2/{groupId}/Members/{membershipType}/{membershipId}/Kick/ |  |
| [**GroupV2RecoverGroupForFounder**](GroupV2Api.md#groupv2recovergroupforfounder) | **GET** /GroupV2/Recover/{membershipType}/{membershipId}/{groupType}/ |  |
| [**GroupV2UnbanMember**](GroupV2Api.md#groupv2unbanmember) | **POST** /GroupV2/{groupId}/Members/{membershipType}/{membershipId}/Unban/ |  |

<a id="groupv2abdicatefoundership"></a>
# **GroupV2AbdicateFoundership**
> GroupV2GetUserClanInviteSetting200Response GroupV2AbdicateFoundership (long founderIdNew, long groupId, int membershipType)



An administrative method to allow the founder of a group or clan to give up their position to another admin permanently.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2AbdicateFoundershipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new GroupV2Api(config);
            var founderIdNew = 789L;  // long | The new founder for this group. Must already be a group admin.
            var groupId = 789L;  // long | The target group id.
            var membershipType = 56;  // int | Membership type of the provided founderIdNew.

            try
            {
                GroupV2GetUserClanInviteSetting200Response result = apiInstance.GroupV2AbdicateFoundership(founderIdNew, groupId, membershipType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2AbdicateFoundership: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2AbdicateFoundershipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetUserClanInviteSetting200Response> response = apiInstance.GroupV2AbdicateFoundershipWithHttpInfo(founderIdNew, groupId, membershipType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2AbdicateFoundershipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **founderIdNew** | **long** | The new founder for this group. Must already be a group admin. |  |
| **groupId** | **long** | The target group id. |  |
| **membershipType** | **int** | Membership type of the provided founderIdNew. |  |

### Return type

[**GroupV2GetUserClanInviteSetting200Response**](GroupV2GetUserClanInviteSetting200Response.md)

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

<a id="groupv2addoptionalconversation"></a>
# **GroupV2AddOptionalConversation**
> ForumGetTopicForContent200Response GroupV2AddOptionalConversation (long groupId, GroupsV2GroupOptionalConversationAddRequest groupsV2GroupOptionalConversationAddRequest)



Add a new optional conversation/chat channel. Requires admin permissions to the group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2AddOptionalConversationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | Group ID of the group to edit.
            var groupsV2GroupOptionalConversationAddRequest = new GroupsV2GroupOptionalConversationAddRequest(); // GroupsV2GroupOptionalConversationAddRequest | 

            try
            {
                ForumGetTopicForContent200Response result = apiInstance.GroupV2AddOptionalConversation(groupId, groupsV2GroupOptionalConversationAddRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2AddOptionalConversation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2AddOptionalConversationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ForumGetTopicForContent200Response> response = apiInstance.GroupV2AddOptionalConversationWithHttpInfo(groupId, groupsV2GroupOptionalConversationAddRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2AddOptionalConversationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | Group ID of the group to edit. |  |
| **groupsV2GroupOptionalConversationAddRequest** | [**GroupsV2GroupOptionalConversationAddRequest**](GroupsV2GroupOptionalConversationAddRequest.md) |  |  |

### Return type

[**ForumGetTopicForContent200Response**](ForumGetTopicForContent200Response.md)

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

<a id="groupv2approveallpending"></a>
# **GroupV2ApproveAllPending**
> GroupV2ApproveAllPending200Response GroupV2ApproveAllPending (long groupId, GroupsV2GroupApplicationRequest groupsV2GroupApplicationRequest)



Approve all of the pending users for the given group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2ApproveAllPendingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | ID of the group.
            var groupsV2GroupApplicationRequest = new GroupsV2GroupApplicationRequest(); // GroupsV2GroupApplicationRequest | 

            try
            {
                GroupV2ApproveAllPending200Response result = apiInstance.GroupV2ApproveAllPending(groupId, groupsV2GroupApplicationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2ApproveAllPending: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2ApproveAllPendingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2ApproveAllPending200Response> response = apiInstance.GroupV2ApproveAllPendingWithHttpInfo(groupId, groupsV2GroupApplicationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2ApproveAllPendingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | ID of the group. |  |
| **groupsV2GroupApplicationRequest** | [**GroupsV2GroupApplicationRequest**](GroupsV2GroupApplicationRequest.md) |  |  |

### Return type

[**GroupV2ApproveAllPending200Response**](GroupV2ApproveAllPending200Response.md)

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

<a id="groupv2approvepending"></a>
# **GroupV2ApprovePending**
> GroupV2GetUserClanInviteSetting200Response GroupV2ApprovePending (long groupId, long membershipId, int membershipType, GroupsV2GroupApplicationRequest groupsV2GroupApplicationRequest)



Approve the given membershipId to join the group/clan as long as they have applied.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2ApprovePendingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | ID of the group.
            var membershipId = 789L;  // long | The membership id being approved.
            var membershipType = 56;  // int | Membership type of the supplied membership ID.
            var groupsV2GroupApplicationRequest = new GroupsV2GroupApplicationRequest(); // GroupsV2GroupApplicationRequest | 

            try
            {
                GroupV2GetUserClanInviteSetting200Response result = apiInstance.GroupV2ApprovePending(groupId, membershipId, membershipType, groupsV2GroupApplicationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2ApprovePending: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2ApprovePendingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetUserClanInviteSetting200Response> response = apiInstance.GroupV2ApprovePendingWithHttpInfo(groupId, membershipId, membershipType, groupsV2GroupApplicationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2ApprovePendingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | ID of the group. |  |
| **membershipId** | **long** | The membership id being approved. |  |
| **membershipType** | **int** | Membership type of the supplied membership ID. |  |
| **groupsV2GroupApplicationRequest** | [**GroupsV2GroupApplicationRequest**](GroupsV2GroupApplicationRequest.md) |  |  |

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

<a id="groupv2approvependingforlist"></a>
# **GroupV2ApprovePendingForList**
> GroupV2ApproveAllPending200Response GroupV2ApprovePendingForList (long groupId, GroupsV2GroupApplicationListRequest groupsV2GroupApplicationListRequest)



Approve all of the pending users for the given group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2ApprovePendingForListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | ID of the group.
            var groupsV2GroupApplicationListRequest = new GroupsV2GroupApplicationListRequest(); // GroupsV2GroupApplicationListRequest | 

            try
            {
                GroupV2ApproveAllPending200Response result = apiInstance.GroupV2ApprovePendingForList(groupId, groupsV2GroupApplicationListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2ApprovePendingForList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2ApprovePendingForListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2ApproveAllPending200Response> response = apiInstance.GroupV2ApprovePendingForListWithHttpInfo(groupId, groupsV2GroupApplicationListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2ApprovePendingForListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | ID of the group. |  |
| **groupsV2GroupApplicationListRequest** | [**GroupsV2GroupApplicationListRequest**](GroupsV2GroupApplicationListRequest.md) |  |  |

### Return type

[**GroupV2ApproveAllPending200Response**](GroupV2ApproveAllPending200Response.md)

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

<a id="groupv2banmember"></a>
# **GroupV2BanMember**
> GroupV2EditGroup200Response GroupV2BanMember (long groupId, long membershipId, int membershipType, GroupsV2GroupBanRequest groupsV2GroupBanRequest)



Bans the requested member from the requested group for the specified period of time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2BanMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | Group ID that has the member to ban.
            var membershipId = 789L;  // long | Membership ID of the member to ban from the group.
            var membershipType = 56;  // int | Membership type of the provided membership ID.
            var groupsV2GroupBanRequest = new GroupsV2GroupBanRequest(); // GroupsV2GroupBanRequest | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.GroupV2BanMember(groupId, membershipId, membershipType, groupsV2GroupBanRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2BanMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2BanMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.GroupV2BanMemberWithHttpInfo(groupId, membershipId, membershipType, groupsV2GroupBanRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2BanMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | Group ID that has the member to ban. |  |
| **membershipId** | **long** | Membership ID of the member to ban from the group. |  |
| **membershipType** | **int** | Membership type of the provided membership ID. |  |
| **groupsV2GroupBanRequest** | [**GroupsV2GroupBanRequest**](GroupsV2GroupBanRequest.md) |  |  |

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

<a id="groupv2denyallpending"></a>
# **GroupV2DenyAllPending**
> GroupV2ApproveAllPending200Response GroupV2DenyAllPending (long groupId, GroupsV2GroupApplicationRequest groupsV2GroupApplicationRequest)



Deny all of the pending users for the given group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2DenyAllPendingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | ID of the group.
            var groupsV2GroupApplicationRequest = new GroupsV2GroupApplicationRequest(); // GroupsV2GroupApplicationRequest | 

            try
            {
                GroupV2ApproveAllPending200Response result = apiInstance.GroupV2DenyAllPending(groupId, groupsV2GroupApplicationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2DenyAllPending: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2DenyAllPendingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2ApproveAllPending200Response> response = apiInstance.GroupV2DenyAllPendingWithHttpInfo(groupId, groupsV2GroupApplicationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2DenyAllPendingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | ID of the group. |  |
| **groupsV2GroupApplicationRequest** | [**GroupsV2GroupApplicationRequest**](GroupsV2GroupApplicationRequest.md) |  |  |

### Return type

[**GroupV2ApproveAllPending200Response**](GroupV2ApproveAllPending200Response.md)

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

<a id="groupv2denypendingforlist"></a>
# **GroupV2DenyPendingForList**
> GroupV2ApproveAllPending200Response GroupV2DenyPendingForList (long groupId, GroupsV2GroupApplicationListRequest groupsV2GroupApplicationListRequest)



Deny all of the pending users for the given group that match the passed-in .

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2DenyPendingForListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | ID of the group.
            var groupsV2GroupApplicationListRequest = new GroupsV2GroupApplicationListRequest(); // GroupsV2GroupApplicationListRequest | 

            try
            {
                GroupV2ApproveAllPending200Response result = apiInstance.GroupV2DenyPendingForList(groupId, groupsV2GroupApplicationListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2DenyPendingForList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2DenyPendingForListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2ApproveAllPending200Response> response = apiInstance.GroupV2DenyPendingForListWithHttpInfo(groupId, groupsV2GroupApplicationListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2DenyPendingForListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | ID of the group. |  |
| **groupsV2GroupApplicationListRequest** | [**GroupsV2GroupApplicationListRequest**](GroupsV2GroupApplicationListRequest.md) |  |  |

### Return type

[**GroupV2ApproveAllPending200Response**](GroupV2ApproveAllPending200Response.md)

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

<a id="groupv2editclanbanner"></a>
# **GroupV2EditClanBanner**
> GroupV2EditGroup200Response GroupV2EditClanBanner (long groupId, GroupsV2ClanBanner groupsV2ClanBanner)



Edit an existing group's clan banner. You must have suitable permissions in the group to perform this operation. All fields are required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2EditClanBannerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | Group ID of the group to edit.
            var groupsV2ClanBanner = new GroupsV2ClanBanner(); // GroupsV2ClanBanner | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.GroupV2EditClanBanner(groupId, groupsV2ClanBanner);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2EditClanBanner: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2EditClanBannerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.GroupV2EditClanBannerWithHttpInfo(groupId, groupsV2ClanBanner);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2EditClanBannerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | Group ID of the group to edit. |  |
| **groupsV2ClanBanner** | [**GroupsV2ClanBanner**](GroupsV2ClanBanner.md) |  |  |

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

<a id="groupv2editfounderoptions"></a>
# **GroupV2EditFounderOptions**
> GroupV2EditGroup200Response GroupV2EditFounderOptions (long groupId, GroupsV2GroupOptionsEditAction groupsV2GroupOptionsEditAction)



Edit group options only available to a founder. You must have suitable permissions in the group to perform this operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2EditFounderOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | Group ID of the group to edit.
            var groupsV2GroupOptionsEditAction = new GroupsV2GroupOptionsEditAction(); // GroupsV2GroupOptionsEditAction | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.GroupV2EditFounderOptions(groupId, groupsV2GroupOptionsEditAction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2EditFounderOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2EditFounderOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.GroupV2EditFounderOptionsWithHttpInfo(groupId, groupsV2GroupOptionsEditAction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2EditFounderOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | Group ID of the group to edit. |  |
| **groupsV2GroupOptionsEditAction** | [**GroupsV2GroupOptionsEditAction**](GroupsV2GroupOptionsEditAction.md) |  |  |

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

<a id="groupv2editgroup"></a>
# **GroupV2EditGroup**
> GroupV2EditGroup200Response GroupV2EditGroup (long groupId, GroupsV2GroupEditAction groupsV2GroupEditAction)



Edit an existing group. You must have suitable permissions in the group to perform this operation. This latest revision will only edit the fields you pass in - pass null for properties you want to leave unaltered.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2EditGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | Group ID of the group to edit.
            var groupsV2GroupEditAction = new GroupsV2GroupEditAction(); // GroupsV2GroupEditAction | 

            try
            {
                GroupV2EditGroup200Response result = apiInstance.GroupV2EditGroup(groupId, groupsV2GroupEditAction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2EditGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2EditGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.GroupV2EditGroupWithHttpInfo(groupId, groupsV2GroupEditAction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2EditGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | Group ID of the group to edit. |  |
| **groupsV2GroupEditAction** | [**GroupsV2GroupEditAction**](GroupsV2GroupEditAction.md) |  |  |

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

<a id="groupv2editgroupmembership"></a>
# **GroupV2EditGroupMembership**
> GroupV2EditGroup200Response GroupV2EditGroupMembership (long groupId, long membershipId, int membershipType, int memberType)



Edit the membership type of a given member. You must have suitable permissions in the group to perform this operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2EditGroupMembershipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | ID of the group to which the member belongs.
            var membershipId = 789L;  // long | Membership ID to modify.
            var membershipType = 56;  // int | Membership type of the provide membership ID.
            var memberType = 56;  // int | New membertype for the specified member.

            try
            {
                GroupV2EditGroup200Response result = apiInstance.GroupV2EditGroupMembership(groupId, membershipId, membershipType, memberType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2EditGroupMembership: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2EditGroupMembershipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.GroupV2EditGroupMembershipWithHttpInfo(groupId, membershipId, membershipType, memberType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2EditGroupMembershipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | ID of the group to which the member belongs. |  |
| **membershipId** | **long** | Membership ID to modify. |  |
| **membershipType** | **int** | Membership type of the provide membership ID. |  |
| **memberType** | **int** | New membertype for the specified member. |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

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

<a id="groupv2editoptionalconversation"></a>
# **GroupV2EditOptionalConversation**
> ForumGetTopicForContent200Response GroupV2EditOptionalConversation (long conversationId, long groupId, GroupsV2GroupOptionalConversationEditRequest groupsV2GroupOptionalConversationEditRequest)



Edit the settings of an optional conversation/chat channel. Requires admin permissions to the group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2EditOptionalConversationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var conversationId = 789L;  // long | Conversation Id of the channel being edited.
            var groupId = 789L;  // long | Group ID of the group to edit.
            var groupsV2GroupOptionalConversationEditRequest = new GroupsV2GroupOptionalConversationEditRequest(); // GroupsV2GroupOptionalConversationEditRequest | 

            try
            {
                ForumGetTopicForContent200Response result = apiInstance.GroupV2EditOptionalConversation(conversationId, groupId, groupsV2GroupOptionalConversationEditRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2EditOptionalConversation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2EditOptionalConversationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ForumGetTopicForContent200Response> response = apiInstance.GroupV2EditOptionalConversationWithHttpInfo(conversationId, groupId, groupsV2GroupOptionalConversationEditRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2EditOptionalConversationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversationId** | **long** | Conversation Id of the channel being edited. |  |
| **groupId** | **long** | Group ID of the group to edit. |  |
| **groupsV2GroupOptionalConversationEditRequest** | [**GroupsV2GroupOptionalConversationEditRequest**](GroupsV2GroupOptionalConversationEditRequest.md) |  |  |

### Return type

[**ForumGetTopicForContent200Response**](ForumGetTopicForContent200Response.md)

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

<a id="groupv2getadminsandfounderofgroup"></a>
# **GroupV2GetAdminsAndFounderOfGroup**
> GroupV2GetMembersOfGroup200Response GroupV2GetAdminsAndFounderOfGroup (int currentpage, long groupId)



Get the list of members in a given group who are of admin level or higher.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetAdminsAndFounderOfGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new GroupV2Api(config);
            var currentpage = 56;  // int | Page number (starting with 1). Each page has a fixed size of 50 items per page.
            var groupId = 789L;  // long | The ID of the group.

            try
            {
                GroupV2GetMembersOfGroup200Response result = apiInstance.GroupV2GetAdminsAndFounderOfGroup(currentpage, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetAdminsAndFounderOfGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetAdminsAndFounderOfGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetMembersOfGroup200Response> response = apiInstance.GroupV2GetAdminsAndFounderOfGroupWithHttpInfo(currentpage, groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetAdminsAndFounderOfGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **currentpage** | **int** | Page number (starting with 1). Each page has a fixed size of 50 items per page. |  |
| **groupId** | **long** | The ID of the group. |  |

### Return type

[**GroupV2GetMembersOfGroup200Response**](GroupV2GetMembersOfGroup200Response.md)

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

<a id="groupv2getavailableavatars"></a>
# **GroupV2GetAvailableAvatars**
> GroupV2GetAvailableAvatars200Response GroupV2GetAvailableAvatars ()



Returns a list of all available group avatars for the signed-in user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetAvailableAvatarsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new GroupV2Api(config);

            try
            {
                GroupV2GetAvailableAvatars200Response result = apiInstance.GroupV2GetAvailableAvatars();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetAvailableAvatars: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetAvailableAvatarsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetAvailableAvatars200Response> response = apiInstance.GroupV2GetAvailableAvatarsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetAvailableAvatarsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GroupV2GetAvailableAvatars200Response**](GroupV2GetAvailableAvatars200Response.md)

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

<a id="groupv2getavailablethemes"></a>
# **GroupV2GetAvailableThemes**
> GroupV2GetAvailableThemes200Response GroupV2GetAvailableThemes ()



Returns a list of all available group themes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetAvailableThemesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new GroupV2Api(config);

            try
            {
                GroupV2GetAvailableThemes200Response result = apiInstance.GroupV2GetAvailableThemes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetAvailableThemes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetAvailableThemesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetAvailableThemes200Response> response = apiInstance.GroupV2GetAvailableThemesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetAvailableThemesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GroupV2GetAvailableThemes200Response**](GroupV2GetAvailableThemes200Response.md)

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

<a id="groupv2getbannedmembersofgroup"></a>
# **GroupV2GetBannedMembersOfGroup**
> GroupV2GetBannedMembersOfGroup200Response GroupV2GetBannedMembersOfGroup (int currentpage, long groupId)



Get the list of banned members in a given group. Only accessible to group Admins and above. Not applicable to all groups. Check group features.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetBannedMembersOfGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var currentpage = 56;  // int | Page number (starting with 1). Each page has a fixed size of 50 entries.
            var groupId = 789L;  // long | Group ID whose banned members you are fetching

            try
            {
                GroupV2GetBannedMembersOfGroup200Response result = apiInstance.GroupV2GetBannedMembersOfGroup(currentpage, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetBannedMembersOfGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetBannedMembersOfGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetBannedMembersOfGroup200Response> response = apiInstance.GroupV2GetBannedMembersOfGroupWithHttpInfo(currentpage, groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetBannedMembersOfGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **currentpage** | **int** | Page number (starting with 1). Each page has a fixed size of 50 entries. |  |
| **groupId** | **long** | Group ID whose banned members you are fetching |  |

### Return type

[**GroupV2GetBannedMembersOfGroup200Response**](GroupV2GetBannedMembersOfGroup200Response.md)

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

<a id="groupv2getgroup"></a>
# **GroupV2GetGroup**
> GroupV2GetGroup200Response GroupV2GetGroup (long groupId)



Get information about a specific group of the given ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | Requested group's id.

            try
            {
                GroupV2GetGroup200Response result = apiInstance.GroupV2GetGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetGroup200Response> response = apiInstance.GroupV2GetGroupWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | Requested group&#39;s id. |  |

### Return type

[**GroupV2GetGroup200Response**](GroupV2GetGroup200Response.md)

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

<a id="groupv2getgroupbyname"></a>
# **GroupV2GetGroupByName**
> GroupV2GetGroup200Response GroupV2GetGroupByName (string groupName, int groupType)



Get information about a specific group with the given name and type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetGroupByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new GroupV2Api(config);
            var groupName = "groupName_example";  // string | Exact name of the group to find.
            var groupType = 56;  // int | Type of group to find.

            try
            {
                GroupV2GetGroup200Response result = apiInstance.GroupV2GetGroupByName(groupName, groupType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroupByName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetGroupByNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetGroup200Response> response = apiInstance.GroupV2GetGroupByNameWithHttpInfo(groupName, groupType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroupByNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupName** | **string** | Exact name of the group to find. |  |
| **groupType** | **int** | Type of group to find. |  |

### Return type

[**GroupV2GetGroup200Response**](GroupV2GetGroup200Response.md)

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

<a id="groupv2getgroupbynamev2"></a>
# **GroupV2GetGroupByNameV2**
> GroupV2GetGroup200Response GroupV2GetGroupByNameV2 (GroupsV2GroupNameSearchRequest groupsV2GroupNameSearchRequest)



Get information about a specific group with the given name and type. The POST version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetGroupByNameV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new GroupV2Api(config);
            var groupsV2GroupNameSearchRequest = new GroupsV2GroupNameSearchRequest(); // GroupsV2GroupNameSearchRequest | 

            try
            {
                GroupV2GetGroup200Response result = apiInstance.GroupV2GetGroupByNameV2(groupsV2GroupNameSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroupByNameV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetGroupByNameV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetGroup200Response> response = apiInstance.GroupV2GetGroupByNameV2WithHttpInfo(groupsV2GroupNameSearchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroupByNameV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupsV2GroupNameSearchRequest** | [**GroupsV2GroupNameSearchRequest**](GroupsV2GroupNameSearchRequest.md) |  |  |

### Return type

[**GroupV2GetGroup200Response**](GroupV2GetGroup200Response.md)

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

<a id="groupv2getgroupoptionalconversations"></a>
# **GroupV2GetGroupOptionalConversations**
> GroupV2GetGroupOptionalConversations200Response GroupV2GetGroupOptionalConversations (long groupId)



Gets a list of available optional conversation channels and their settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetGroupOptionalConversationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | Requested group's id.

            try
            {
                GroupV2GetGroupOptionalConversations200Response result = apiInstance.GroupV2GetGroupOptionalConversations(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroupOptionalConversations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetGroupOptionalConversationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetGroupOptionalConversations200Response> response = apiInstance.GroupV2GetGroupOptionalConversationsWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroupOptionalConversationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | Requested group&#39;s id. |  |

### Return type

[**GroupV2GetGroupOptionalConversations200Response**](GroupV2GetGroupOptionalConversations200Response.md)

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

<a id="groupv2getgroupsformember"></a>
# **GroupV2GetGroupsForMember**
> GroupV2GetGroupsForMember200Response GroupV2GetGroupsForMember (int filter, int groupType, long membershipId, int membershipType)



Get information about the groups that a given member has joined.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetGroupsForMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new GroupV2Api(config);
            var filter = 56;  // int | Filter apply to list of joined groups.
            var groupType = 56;  // int | Type of group the supplied member founded.
            var membershipId = 789L;  // long | Membership ID to for which to find founded groups.
            var membershipType = 56;  // int | Membership type of the supplied membership ID.

            try
            {
                GroupV2GetGroupsForMember200Response result = apiInstance.GroupV2GetGroupsForMember(filter, groupType, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroupsForMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetGroupsForMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetGroupsForMember200Response> response = apiInstance.GroupV2GetGroupsForMemberWithHttpInfo(filter, groupType, membershipId, membershipType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroupsForMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **int** | Filter apply to list of joined groups. |  |
| **groupType** | **int** | Type of group the supplied member founded. |  |
| **membershipId** | **long** | Membership ID to for which to find founded groups. |  |
| **membershipType** | **int** | Membership type of the supplied membership ID. |  |

### Return type

[**GroupV2GetGroupsForMember200Response**](GroupV2GetGroupsForMember200Response.md)

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

<a id="groupv2getinvitedindividuals"></a>
# **GroupV2GetInvitedIndividuals**
> GroupV2GetPendingMemberships200Response GroupV2GetInvitedIndividuals (int currentpage, long groupId)



Get the list of users who have been invited into the group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetInvitedIndividualsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var currentpage = 56;  // int | Page number (starting with 1). Each page has a fixed size of 50 items per page.
            var groupId = 789L;  // long | ID of the group.

            try
            {
                GroupV2GetPendingMemberships200Response result = apiInstance.GroupV2GetInvitedIndividuals(currentpage, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetInvitedIndividuals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetInvitedIndividualsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetPendingMemberships200Response> response = apiInstance.GroupV2GetInvitedIndividualsWithHttpInfo(currentpage, groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetInvitedIndividualsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **currentpage** | **int** | Page number (starting with 1). Each page has a fixed size of 50 items per page. |  |
| **groupId** | **long** | ID of the group. |  |

### Return type

[**GroupV2GetPendingMemberships200Response**](GroupV2GetPendingMemberships200Response.md)

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

<a id="groupv2getmembersofgroup"></a>
# **GroupV2GetMembersOfGroup**
> GroupV2GetMembersOfGroup200Response GroupV2GetMembersOfGroup (int currentpage, long groupId, int? memberType = null, string? nameSearch = null)



Get the list of members in a given group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetMembersOfGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new GroupV2Api(config);
            var currentpage = 56;  // int | Page number (starting with 1). Each page has a fixed size of 50 items per page.
            var groupId = 789L;  // long | The ID of the group.
            var memberType = 56;  // int? | Filter out other member types. Use None for all members. (optional) 
            var nameSearch = "nameSearch_example";  // string? | The name fragment upon which a search should be executed for members with matching display or unique names. (optional) 

            try
            {
                GroupV2GetMembersOfGroup200Response result = apiInstance.GroupV2GetMembersOfGroup(currentpage, groupId, memberType, nameSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetMembersOfGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetMembersOfGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetMembersOfGroup200Response> response = apiInstance.GroupV2GetMembersOfGroupWithHttpInfo(currentpage, groupId, memberType, nameSearch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetMembersOfGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **currentpage** | **int** | Page number (starting with 1). Each page has a fixed size of 50 items per page. |  |
| **groupId** | **long** | The ID of the group. |  |
| **memberType** | **int?** | Filter out other member types. Use None for all members. | [optional]  |
| **nameSearch** | **string?** | The name fragment upon which a search should be executed for members with matching display or unique names. | [optional]  |

### Return type

[**GroupV2GetMembersOfGroup200Response**](GroupV2GetMembersOfGroup200Response.md)

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

<a id="groupv2getpendingmemberships"></a>
# **GroupV2GetPendingMemberships**
> GroupV2GetPendingMemberships200Response GroupV2GetPendingMemberships (int currentpage, long groupId)



Get the list of users who are awaiting a decision on their application to join a given group. Modified to include application info.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetPendingMembershipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var currentpage = 56;  // int | Page number (starting with 1). Each page has a fixed size of 50 items per page.
            var groupId = 789L;  // long | ID of the group.

            try
            {
                GroupV2GetPendingMemberships200Response result = apiInstance.GroupV2GetPendingMemberships(currentpage, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetPendingMemberships: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetPendingMembershipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetPendingMemberships200Response> response = apiInstance.GroupV2GetPendingMembershipsWithHttpInfo(currentpage, groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetPendingMembershipsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **currentpage** | **int** | Page number (starting with 1). Each page has a fixed size of 50 items per page. |  |
| **groupId** | **long** | ID of the group. |  |

### Return type

[**GroupV2GetPendingMemberships200Response**](GroupV2GetPendingMemberships200Response.md)

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

<a id="groupv2getpotentialgroupsformember"></a>
# **GroupV2GetPotentialGroupsForMember**
> GroupV2GetPotentialGroupsForMember200Response GroupV2GetPotentialGroupsForMember (int filter, int groupType, long membershipId, int membershipType)



Get information about the groups that a given member has applied to or been invited to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetPotentialGroupsForMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new GroupV2Api(config);
            var filter = 56;  // int | Filter apply to list of potential joined groups.
            var groupType = 56;  // int | Type of group the supplied member applied.
            var membershipId = 789L;  // long | Membership ID to for which to find applied groups.
            var membershipType = 56;  // int | Membership type of the supplied membership ID.

            try
            {
                GroupV2GetPotentialGroupsForMember200Response result = apiInstance.GroupV2GetPotentialGroupsForMember(filter, groupType, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetPotentialGroupsForMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetPotentialGroupsForMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetPotentialGroupsForMember200Response> response = apiInstance.GroupV2GetPotentialGroupsForMemberWithHttpInfo(filter, groupType, membershipId, membershipType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetPotentialGroupsForMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **int** | Filter apply to list of potential joined groups. |  |
| **groupType** | **int** | Type of group the supplied member applied. |  |
| **membershipId** | **long** | Membership ID to for which to find applied groups. |  |
| **membershipType** | **int** | Membership type of the supplied membership ID. |  |

### Return type

[**GroupV2GetPotentialGroupsForMember200Response**](GroupV2GetPotentialGroupsForMember200Response.md)

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

<a id="groupv2getrecommendedgroups"></a>
# **GroupV2GetRecommendedGroups**
> GroupV2GetRecommendedGroups200Response GroupV2GetRecommendedGroups (int createDateRange, int groupType)



Gets groups recommended for you based on the groups to whom those you follow belong.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetRecommendedGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var createDateRange = 56;  // int | Requested range in which to pull recommended groups
            var groupType = 56;  // int | Type of groups requested

            try
            {
                GroupV2GetRecommendedGroups200Response result = apiInstance.GroupV2GetRecommendedGroups(createDateRange, groupType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetRecommendedGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetRecommendedGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetRecommendedGroups200Response> response = apiInstance.GroupV2GetRecommendedGroupsWithHttpInfo(createDateRange, groupType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetRecommendedGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDateRange** | **int** | Requested range in which to pull recommended groups |  |
| **groupType** | **int** | Type of groups requested |  |

### Return type

[**GroupV2GetRecommendedGroups200Response**](GroupV2GetRecommendedGroups200Response.md)

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

<a id="groupv2getuserclaninvitesetting"></a>
# **GroupV2GetUserClanInviteSetting**
> GroupV2GetUserClanInviteSetting200Response GroupV2GetUserClanInviteSetting (int mType)



Gets the state of the user's clan invite preferences for a particular membership type - true if they wish to be invited to clans, false otherwise.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GetUserClanInviteSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var mType = 56;  // int | The Destiny membership type of the account we wish to access settings.

            try
            {
                GroupV2GetUserClanInviteSetting200Response result = apiInstance.GroupV2GetUserClanInviteSetting(mType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetUserClanInviteSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GetUserClanInviteSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GetUserClanInviteSetting200Response> response = apiInstance.GroupV2GetUserClanInviteSettingWithHttpInfo(mType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GetUserClanInviteSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mType** | **int** | The Destiny membership type of the account we wish to access settings. |  |

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

<a id="groupv2groupsearch"></a>
# **GroupV2GroupSearch**
> GroupV2GroupSearch200Response GroupV2GroupSearch (GroupsV2GroupQuery groupsV2GroupQuery)



Search for Groups.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2GroupSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new GroupV2Api(config);
            var groupsV2GroupQuery = new GroupsV2GroupQuery(); // GroupsV2GroupQuery | 

            try
            {
                GroupV2GroupSearch200Response result = apiInstance.GroupV2GroupSearch(groupsV2GroupQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GroupSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2GroupSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2GroupSearch200Response> response = apiInstance.GroupV2GroupSearchWithHttpInfo(groupsV2GroupQuery);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2GroupSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupsV2GroupQuery** | [**GroupsV2GroupQuery**](GroupsV2GroupQuery.md) |  |  |

### Return type

[**GroupV2GroupSearch200Response**](GroupV2GroupSearch200Response.md)

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

<a id="groupv2individualgroupinvite"></a>
# **GroupV2IndividualGroupInvite**
> GroupV2IndividualGroupInvite200Response GroupV2IndividualGroupInvite (long groupId, long membershipId, int membershipType, GroupsV2GroupApplicationRequest groupsV2GroupApplicationRequest)



Invite a user to join this group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2IndividualGroupInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | ID of the group you would like to join.
            var membershipId = 789L;  // long | Membership id of the account being invited.
            var membershipType = 56;  // int | MembershipType of the account being invited.
            var groupsV2GroupApplicationRequest = new GroupsV2GroupApplicationRequest(); // GroupsV2GroupApplicationRequest | 

            try
            {
                GroupV2IndividualGroupInvite200Response result = apiInstance.GroupV2IndividualGroupInvite(groupId, membershipId, membershipType, groupsV2GroupApplicationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2IndividualGroupInvite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2IndividualGroupInviteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2IndividualGroupInvite200Response> response = apiInstance.GroupV2IndividualGroupInviteWithHttpInfo(groupId, membershipId, membershipType, groupsV2GroupApplicationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2IndividualGroupInviteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | ID of the group you would like to join. |  |
| **membershipId** | **long** | Membership id of the account being invited. |  |
| **membershipType** | **int** | MembershipType of the account being invited. |  |
| **groupsV2GroupApplicationRequest** | [**GroupsV2GroupApplicationRequest**](GroupsV2GroupApplicationRequest.md) |  |  |

### Return type

[**GroupV2IndividualGroupInvite200Response**](GroupV2IndividualGroupInvite200Response.md)

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

<a id="groupv2individualgroupinvitecancel"></a>
# **GroupV2IndividualGroupInviteCancel**
> GroupV2IndividualGroupInvite200Response GroupV2IndividualGroupInviteCancel (long groupId, long membershipId, int membershipType)



Cancels a pending invitation to join a group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2IndividualGroupInviteCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | ID of the group you would like to join.
            var membershipId = 789L;  // long | Membership id of the account being cancelled.
            var membershipType = 56;  // int | MembershipType of the account being cancelled.

            try
            {
                GroupV2IndividualGroupInvite200Response result = apiInstance.GroupV2IndividualGroupInviteCancel(groupId, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2IndividualGroupInviteCancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2IndividualGroupInviteCancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2IndividualGroupInvite200Response> response = apiInstance.GroupV2IndividualGroupInviteCancelWithHttpInfo(groupId, membershipId, membershipType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2IndividualGroupInviteCancelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | ID of the group you would like to join. |  |
| **membershipId** | **long** | Membership id of the account being cancelled. |  |
| **membershipType** | **int** | MembershipType of the account being cancelled. |  |

### Return type

[**GroupV2IndividualGroupInvite200Response**](GroupV2IndividualGroupInvite200Response.md)

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

<a id="groupv2kickmember"></a>
# **GroupV2KickMember**
> GroupV2KickMember200Response GroupV2KickMember (long groupId, long membershipId, int membershipType)



Kick a member from the given group, forcing them to reapply if they wish to re-join the group. You must have suitable permissions in the group to perform this operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2KickMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | Group ID to kick the user from.
            var membershipId = 789L;  // long | Membership ID to kick.
            var membershipType = 56;  // int | Membership type of the provided membership ID.

            try
            {
                GroupV2KickMember200Response result = apiInstance.GroupV2KickMember(groupId, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2KickMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2KickMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2KickMember200Response> response = apiInstance.GroupV2KickMemberWithHttpInfo(groupId, membershipId, membershipType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2KickMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** | Group ID to kick the user from. |  |
| **membershipId** | **long** | Membership ID to kick. |  |
| **membershipType** | **int** | Membership type of the provided membership ID. |  |

### Return type

[**GroupV2KickMember200Response**](GroupV2KickMember200Response.md)

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

<a id="groupv2recovergroupforfounder"></a>
# **GroupV2RecoverGroupForFounder**
> GroupV2RecoverGroupForFounder200Response GroupV2RecoverGroupForFounder (int groupType, long membershipId, int membershipType)



Allows a founder to manually recover a group they can see in game but not on bungie.net

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2RecoverGroupForFounderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new GroupV2Api(config);
            var groupType = 56;  // int | Type of group the supplied member founded.
            var membershipId = 789L;  // long | Membership ID to for which to find founded groups.
            var membershipType = 56;  // int | Membership type of the supplied membership ID.

            try
            {
                GroupV2RecoverGroupForFounder200Response result = apiInstance.GroupV2RecoverGroupForFounder(groupType, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2RecoverGroupForFounder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2RecoverGroupForFounderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2RecoverGroupForFounder200Response> response = apiInstance.GroupV2RecoverGroupForFounderWithHttpInfo(groupType, membershipId, membershipType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2RecoverGroupForFounderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupType** | **int** | Type of group the supplied member founded. |  |
| **membershipId** | **long** | Membership ID to for which to find founded groups. |  |
| **membershipType** | **int** | Membership type of the supplied membership ID. |  |

### Return type

[**GroupV2RecoverGroupForFounder200Response**](GroupV2RecoverGroupForFounder200Response.md)

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

<a id="groupv2unbanmember"></a>
# **GroupV2UnbanMember**
> GroupV2EditGroup200Response GroupV2UnbanMember (long groupId, long membershipId, int membershipType)



Unbans the requested member, allowing them to re-apply for membership.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class GroupV2UnbanMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api(config);
            var groupId = 789L;  // long | 
            var membershipId = 789L;  // long | Membership ID of the member to unban from the group
            var membershipType = 56;  // int | Membership type of the provided membership ID.

            try
            {
                GroupV2EditGroup200Response result = apiInstance.GroupV2UnbanMember(groupId, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2UnbanMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupV2UnbanMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupV2EditGroup200Response> response = apiInstance.GroupV2UnbanMemberWithHttpInfo(groupId, membershipId, membershipType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupV2Api.GroupV2UnbanMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **long** |  |  |
| **membershipId** | **long** | Membership ID of the member to unban from the group |  |
| **membershipType** | **int** | Membership type of the provided membership ID. |  |

### Return type

[**GroupV2EditGroup200Response**](GroupV2EditGroup200Response.md)

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

