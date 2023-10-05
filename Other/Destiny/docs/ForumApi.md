# Destiny.Api.ForumApi

All URIs are relative to *https://www.bungie.net/Platform*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ForumGetCoreTopicsPaged**](ForumApi.md#forumgetcoretopicspaged) | **GET** /Forum/GetCoreTopicsPaged/{page}/{sort}/{quickDate}/{categoryFilter}/ |  |
| [**ForumGetForumTagSuggestions**](ForumApi.md#forumgetforumtagsuggestions) | **GET** /Forum/GetForumTagSuggestions/ |  |
| [**ForumGetPoll**](ForumApi.md#forumgetpoll) | **GET** /Forum/Poll/{topicId}/ |  |
| [**ForumGetPostAndParent**](ForumApi.md#forumgetpostandparent) | **GET** /Forum/GetPostAndParent/{childPostId}/ |  |
| [**ForumGetPostAndParentAwaitingApproval**](ForumApi.md#forumgetpostandparentawaitingapproval) | **GET** /Forum/GetPostAndParentAwaitingApproval/{childPostId}/ |  |
| [**ForumGetPostsThreadedPaged**](ForumApi.md#forumgetpoststhreadedpaged) | **GET** /Forum/GetPostsThreadedPaged/{parentPostId}/{page}/{pageSize}/{replySize}/{getParentPost}/{rootThreadMode}/{sortMode}/ |  |
| [**ForumGetPostsThreadedPagedFromChild**](ForumApi.md#forumgetpoststhreadedpagedfromchild) | **GET** /Forum/GetPostsThreadedPagedFromChild/{childPostId}/{page}/{pageSize}/{replySize}/{rootThreadMode}/{sortMode}/ |  |
| [**ForumGetRecruitmentThreadSummaries**](ForumApi.md#forumgetrecruitmentthreadsummaries) | **POST** /Forum/Recruit/Summaries/ |  |
| [**ForumGetTopicForContent**](ForumApi.md#forumgettopicforcontent) | **GET** /Forum/GetTopicForContent/{contentId}/ |  |
| [**ForumGetTopicsPaged**](ForumApi.md#forumgettopicspaged) | **GET** /Forum/GetTopicsPaged/{page}/{pageSize}/{group}/{sort}/{quickDate}/{categoryFilter}/ |  |

<a id="forumgetcoretopicspaged"></a>
# **ForumGetCoreTopicsPaged**
> ForumGetTopicsPaged200Response ForumGetCoreTopicsPaged (int categoryFilter, int page, int quickDate, int sort, string? locales = null)



Gets a listing of all topics marked as part of the core group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ForumGetCoreTopicsPagedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var categoryFilter = 56;  // int | The category filter.
            var page = 56;  // int | Zero base page
            var quickDate = 56;  // int | The date filter.
            var sort = 56;  // int | The sort mode.
            var locales = "locales_example";  // string? | Comma seperated list of locales posts must match to return in the result list. Default 'en' (optional) 

            try
            {
                ForumGetTopicsPaged200Response result = apiInstance.ForumGetCoreTopicsPaged(categoryFilter, page, quickDate, sort, locales);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetCoreTopicsPaged: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumGetCoreTopicsPagedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ForumGetTopicsPaged200Response> response = apiInstance.ForumGetCoreTopicsPagedWithHttpInfo(categoryFilter, page, quickDate, sort, locales);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ForumGetCoreTopicsPagedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryFilter** | **int** | The category filter. |  |
| **page** | **int** | Zero base page |  |
| **quickDate** | **int** | The date filter. |  |
| **sort** | **int** | The sort mode. |  |
| **locales** | **string?** | Comma seperated list of locales posts must match to return in the result list. Default &#39;en&#39; | [optional]  |

### Return type

[**ForumGetTopicsPaged200Response**](ForumGetTopicsPaged200Response.md)

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

<a id="forumgetforumtagsuggestions"></a>
# **ForumGetForumTagSuggestions**
> ForumGetForumTagSuggestions200Response ForumGetForumTagSuggestions (string? partialtag = null)



Gets tag suggestions based on partial text entry, matching them with other tags previously used in the forums.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ForumGetForumTagSuggestionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var partialtag = "partialtag_example";  // string? | The partial tag input to generate suggestions from. (optional) 

            try
            {
                ForumGetForumTagSuggestions200Response result = apiInstance.ForumGetForumTagSuggestions(partialtag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetForumTagSuggestions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumGetForumTagSuggestionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ForumGetForumTagSuggestions200Response> response = apiInstance.ForumGetForumTagSuggestionsWithHttpInfo(partialtag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ForumGetForumTagSuggestionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **partialtag** | **string?** | The partial tag input to generate suggestions from. | [optional]  |

### Return type

[**ForumGetForumTagSuggestions200Response**](ForumGetForumTagSuggestions200Response.md)

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

<a id="forumgetpoll"></a>
# **ForumGetPoll**
> ForumGetTopicsPaged200Response ForumGetPoll (long topicId)



Gets the specified forum poll.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ForumGetPollExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var topicId = 789L;  // long | The post id of the topic that has the poll.

            try
            {
                ForumGetTopicsPaged200Response result = apiInstance.ForumGetPoll(topicId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPoll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumGetPollWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ForumGetTopicsPaged200Response> response = apiInstance.ForumGetPollWithHttpInfo(topicId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ForumGetPollWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **topicId** | **long** | The post id of the topic that has the poll. |  |

### Return type

[**ForumGetTopicsPaged200Response**](ForumGetTopicsPaged200Response.md)

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

<a id="forumgetpostandparent"></a>
# **ForumGetPostAndParent**
> ForumGetTopicsPaged200Response ForumGetPostAndParent (long childPostId, string? showbanned = null)



Returns the post specified and its immediate parent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ForumGetPostAndParentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var childPostId = 789L;  // long | 
            var showbanned = "showbanned_example";  // string? | If this value is not null or empty, banned posts are requested to be returned (optional) 

            try
            {
                ForumGetTopicsPaged200Response result = apiInstance.ForumGetPostAndParent(childPostId, showbanned);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPostAndParent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumGetPostAndParentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ForumGetTopicsPaged200Response> response = apiInstance.ForumGetPostAndParentWithHttpInfo(childPostId, showbanned);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ForumGetPostAndParentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **childPostId** | **long** |  |  |
| **showbanned** | **string?** | If this value is not null or empty, banned posts are requested to be returned | [optional]  |

### Return type

[**ForumGetTopicsPaged200Response**](ForumGetTopicsPaged200Response.md)

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

<a id="forumgetpostandparentawaitingapproval"></a>
# **ForumGetPostAndParentAwaitingApproval**
> ForumGetTopicsPaged200Response ForumGetPostAndParentAwaitingApproval (long childPostId, string? showbanned = null)



Returns the post specified and its immediate parent of posts that are awaiting approval.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ForumGetPostAndParentAwaitingApprovalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var childPostId = 789L;  // long | 
            var showbanned = "showbanned_example";  // string? | If this value is not null or empty, banned posts are requested to be returned (optional) 

            try
            {
                ForumGetTopicsPaged200Response result = apiInstance.ForumGetPostAndParentAwaitingApproval(childPostId, showbanned);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPostAndParentAwaitingApproval: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumGetPostAndParentAwaitingApprovalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ForumGetTopicsPaged200Response> response = apiInstance.ForumGetPostAndParentAwaitingApprovalWithHttpInfo(childPostId, showbanned);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ForumGetPostAndParentAwaitingApprovalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **childPostId** | **long** |  |  |
| **showbanned** | **string?** | If this value is not null or empty, banned posts are requested to be returned | [optional]  |

### Return type

[**ForumGetTopicsPaged200Response**](ForumGetTopicsPaged200Response.md)

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

<a id="forumgetpoststhreadedpaged"></a>
# **ForumGetPostsThreadedPaged**
> ForumGetTopicsPaged200Response ForumGetPostsThreadedPaged (bool getParentPost, int page, int pageSize, long parentPostId, int replySize, bool rootThreadMode, int sortMode, string? showbanned = null)



Returns a thread of posts at the given parent, optionally returning replies to those posts as well as the original parent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ForumGetPostsThreadedPagedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var getParentPost = true;  // bool | 
            var page = 56;  // int | 
            var pageSize = 56;  // int | 
            var parentPostId = 789L;  // long | 
            var replySize = 56;  // int | 
            var rootThreadMode = true;  // bool | 
            var sortMode = 56;  // int | 
            var showbanned = "showbanned_example";  // string? | If this value is not null or empty, banned posts are requested to be returned (optional) 

            try
            {
                ForumGetTopicsPaged200Response result = apiInstance.ForumGetPostsThreadedPaged(getParentPost, page, pageSize, parentPostId, replySize, rootThreadMode, sortMode, showbanned);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPostsThreadedPaged: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumGetPostsThreadedPagedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ForumGetTopicsPaged200Response> response = apiInstance.ForumGetPostsThreadedPagedWithHttpInfo(getParentPost, page, pageSize, parentPostId, replySize, rootThreadMode, sortMode, showbanned);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ForumGetPostsThreadedPagedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getParentPost** | **bool** |  |  |
| **page** | **int** |  |  |
| **pageSize** | **int** |  |  |
| **parentPostId** | **long** |  |  |
| **replySize** | **int** |  |  |
| **rootThreadMode** | **bool** |  |  |
| **sortMode** | **int** |  |  |
| **showbanned** | **string?** | If this value is not null or empty, banned posts are requested to be returned | [optional]  |

### Return type

[**ForumGetTopicsPaged200Response**](ForumGetTopicsPaged200Response.md)

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

<a id="forumgetpoststhreadedpagedfromchild"></a>
# **ForumGetPostsThreadedPagedFromChild**
> ForumGetTopicsPaged200Response ForumGetPostsThreadedPagedFromChild (long childPostId, int page, int pageSize, int replySize, bool rootThreadMode, int sortMode, string? showbanned = null)



Returns a thread of posts starting at the topicId of the input childPostId, optionally returning replies to those posts as well as the original parent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ForumGetPostsThreadedPagedFromChildExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var childPostId = 789L;  // long | 
            var page = 56;  // int | 
            var pageSize = 56;  // int | 
            var replySize = 56;  // int | 
            var rootThreadMode = true;  // bool | 
            var sortMode = 56;  // int | 
            var showbanned = "showbanned_example";  // string? | If this value is not null or empty, banned posts are requested to be returned (optional) 

            try
            {
                ForumGetTopicsPaged200Response result = apiInstance.ForumGetPostsThreadedPagedFromChild(childPostId, page, pageSize, replySize, rootThreadMode, sortMode, showbanned);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPostsThreadedPagedFromChild: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumGetPostsThreadedPagedFromChildWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ForumGetTopicsPaged200Response> response = apiInstance.ForumGetPostsThreadedPagedFromChildWithHttpInfo(childPostId, page, pageSize, replySize, rootThreadMode, sortMode, showbanned);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ForumGetPostsThreadedPagedFromChildWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **childPostId** | **long** |  |  |
| **page** | **int** |  |  |
| **pageSize** | **int** |  |  |
| **replySize** | **int** |  |  |
| **rootThreadMode** | **bool** |  |  |
| **sortMode** | **int** |  |  |
| **showbanned** | **string?** | If this value is not null or empty, banned posts are requested to be returned | [optional]  |

### Return type

[**ForumGetTopicsPaged200Response**](ForumGetTopicsPaged200Response.md)

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

<a id="forumgetrecruitmentthreadsummaries"></a>
# **ForumGetRecruitmentThreadSummaries**
> ForumGetRecruitmentThreadSummaries200Response ForumGetRecruitmentThreadSummaries (List<long> requestBody)



Allows the caller to get a list of to 25 recruitment thread summary information objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ForumGetRecruitmentThreadSummariesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var requestBody = new List<long>(); // List<long> | 

            try
            {
                ForumGetRecruitmentThreadSummaries200Response result = apiInstance.ForumGetRecruitmentThreadSummaries(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetRecruitmentThreadSummaries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumGetRecruitmentThreadSummariesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ForumGetRecruitmentThreadSummaries200Response> response = apiInstance.ForumGetRecruitmentThreadSummariesWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ForumGetRecruitmentThreadSummariesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;long&gt;**](long.md) |  |  |

### Return type

[**ForumGetRecruitmentThreadSummaries200Response**](ForumGetRecruitmentThreadSummaries200Response.md)

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

<a id="forumgettopicforcontent"></a>
# **ForumGetTopicForContent**
> ForumGetTopicForContent200Response ForumGetTopicForContent (long contentId)



Gets the post Id for the given content item's comments, if it exists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ForumGetTopicForContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var contentId = 789L;  // long | 

            try
            {
                ForumGetTopicForContent200Response result = apiInstance.ForumGetTopicForContent(contentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetTopicForContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumGetTopicForContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ForumGetTopicForContent200Response> response = apiInstance.ForumGetTopicForContentWithHttpInfo(contentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ForumGetTopicForContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentId** | **long** |  |  |

### Return type

[**ForumGetTopicForContent200Response**](ForumGetTopicForContent200Response.md)

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

<a id="forumgettopicspaged"></a>
# **ForumGetTopicsPaged**
> ForumGetTopicsPaged200Response ForumGetTopicsPaged (int categoryFilter, long group, int page, int pageSize, int quickDate, int sort, string? locales = null, string? tagstring = null)



Get topics from any forum.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ForumGetTopicsPagedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var categoryFilter = 56;  // int | A category filter
            var group = 789L;  // long | The group, if any.
            var page = 56;  // int | Zero paged page number
            var pageSize = 56;  // int | Unused
            var quickDate = 56;  // int | A date filter.
            var sort = 56;  // int | The sort mode.
            var locales = "locales_example";  // string? | Comma seperated list of locales posts must match to return in the result list. Default 'en' (optional) 
            var tagstring = "tagstring_example";  // string? | The tags to search, if any. (optional) 

            try
            {
                ForumGetTopicsPaged200Response result = apiInstance.ForumGetTopicsPaged(categoryFilter, group, page, pageSize, quickDate, sort, locales, tagstring);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetTopicsPaged: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForumGetTopicsPagedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ForumGetTopicsPaged200Response> response = apiInstance.ForumGetTopicsPagedWithHttpInfo(categoryFilter, group, page, pageSize, quickDate, sort, locales, tagstring);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ForumGetTopicsPagedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryFilter** | **int** | A category filter |  |
| **group** | **long** | The group, if any. |  |
| **page** | **int** | Zero paged page number |  |
| **pageSize** | **int** | Unused |  |
| **quickDate** | **int** | A date filter. |  |
| **sort** | **int** | The sort mode. |  |
| **locales** | **string?** | Comma seperated list of locales posts must match to return in the result list. Default &#39;en&#39; | [optional]  |
| **tagstring** | **string?** | The tags to search, if any. | [optional]  |

### Return type

[**ForumGetTopicsPaged200Response**](ForumGetTopicsPaged200Response.md)

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

