# Destiny.Api.CommunityContentApi

All URIs are relative to *https://www.bungie.net/Platform*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CommunityContentGetCommunityContent**](CommunityContentApi.md#communitycontentgetcommunitycontent) | **GET** /CommunityContent/Get/{sort}/{mediaFilter}/{page}/ |  |

<a id="communitycontentgetcommunitycontent"></a>
# **CommunityContentGetCommunityContent**
> ForumGetTopicsPaged200Response CommunityContentGetCommunityContent (int mediaFilter, int page, int sort)



Returns community content.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class CommunityContentGetCommunityContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new CommunityContentApi(config);
            var mediaFilter = 56;  // int | The type of media to get
            var page = 56;  // int | Zero based page
            var sort = 56;  // int | The sort mode.

            try
            {
                ForumGetTopicsPaged200Response result = apiInstance.CommunityContentGetCommunityContent(mediaFilter, page, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommunityContentApi.CommunityContentGetCommunityContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommunityContentGetCommunityContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ForumGetTopicsPaged200Response> response = apiInstance.CommunityContentGetCommunityContentWithHttpInfo(mediaFilter, page, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CommunityContentApi.CommunityContentGetCommunityContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mediaFilter** | **int** | The type of media to get |  |
| **page** | **int** | Zero based page |  |
| **sort** | **int** | The sort mode. |  |

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

