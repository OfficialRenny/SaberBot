# Destiny.Api.ContentApi

All URIs are relative to *https://www.bungie.net/Platform*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContentGetContentById**](ContentApi.md#contentgetcontentbyid) | **GET** /Content/GetContentById/{id}/{locale}/ |  |
| [**ContentGetContentByTagAndType**](ContentApi.md#contentgetcontentbytagandtype) | **GET** /Content/GetContentByTagAndType/{tag}/{type}/{locale}/ |  |
| [**ContentGetContentType**](ContentApi.md#contentgetcontenttype) | **GET** /Content/GetContentType/{type}/ |  |
| [**ContentRssNewsArticles**](ContentApi.md#contentrssnewsarticles) | **GET** /Content/Rss/NewsArticles/{pageToken}/ |  |
| [**ContentSearchContentByTagAndType**](ContentApi.md#contentsearchcontentbytagandtype) | **GET** /Content/SearchContentByTagAndType/{tag}/{type}/{locale}/ |  |
| [**ContentSearchContentWithText**](ContentApi.md#contentsearchcontentwithtext) | **GET** /Content/Search/{locale}/ |  |
| [**ContentSearchHelpArticles**](ContentApi.md#contentsearchhelparticles) | **GET** /Content/SearchHelpArticles/{searchtext}/{size}/ |  |

<a id="contentgetcontentbyid"></a>
# **ContentGetContentById**
> ContentGetContentById200Response ContentGetContentById (long id, string locale, bool? head = null)



Returns a content item referenced by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ContentGetContentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ContentApi(config);
            var id = 789L;  // long | 
            var locale = "locale_example";  // string | 
            var head = true;  // bool? | false (optional) 

            try
            {
                ContentGetContentById200Response result = apiInstance.ContentGetContentById(id, locale, head);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ContentGetContentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentGetContentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentGetContentById200Response> response = apiInstance.ContentGetContentByIdWithHttpInfo(id, locale, head);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentApi.ContentGetContentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **locale** | **string** |  |  |
| **head** | **bool?** | false | [optional]  |

### Return type

[**ContentGetContentById200Response**](ContentGetContentById200Response.md)

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

<a id="contentgetcontentbytagandtype"></a>
# **ContentGetContentByTagAndType**
> ContentGetContentById200Response ContentGetContentByTagAndType (string locale, string tag, string type, bool? head = null)



Returns the newest item that matches a given tag and Content Type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ContentGetContentByTagAndTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ContentApi(config);
            var locale = "locale_example";  // string | 
            var tag = "tag_example";  // string | 
            var type = "type_example";  // string | 
            var head = true;  // bool? | Not used. (optional) 

            try
            {
                ContentGetContentById200Response result = apiInstance.ContentGetContentByTagAndType(locale, tag, type, head);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ContentGetContentByTagAndType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentGetContentByTagAndTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentGetContentById200Response> response = apiInstance.ContentGetContentByTagAndTypeWithHttpInfo(locale, tag, type, head);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentApi.ContentGetContentByTagAndTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locale** | **string** |  |  |
| **tag** | **string** |  |  |
| **type** | **string** |  |  |
| **head** | **bool?** | Not used. | [optional]  |

### Return type

[**ContentGetContentById200Response**](ContentGetContentById200Response.md)

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

<a id="contentgetcontenttype"></a>
# **ContentGetContentType**
> ContentGetContentType200Response ContentGetContentType (string type)



Gets an object describing a particular variant of content.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ContentGetContentTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ContentApi(config);
            var type = "type_example";  // string | 

            try
            {
                ContentGetContentType200Response result = apiInstance.ContentGetContentType(type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ContentGetContentType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentGetContentTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentGetContentType200Response> response = apiInstance.ContentGetContentTypeWithHttpInfo(type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentApi.ContentGetContentTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string** |  |  |

### Return type

[**ContentGetContentType200Response**](ContentGetContentType200Response.md)

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

<a id="contentrssnewsarticles"></a>
# **ContentRssNewsArticles**
> ContentRssNewsArticles200Response ContentRssNewsArticles (string pageToken, string? categoryfilter = null, bool? includebody = null)



Returns a JSON string response that is the RSS feed for news articles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ContentRssNewsArticlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ContentApi(config);
            var pageToken = "pageToken_example";  // string | Zero-based pagination token for paging through result sets.
            var categoryfilter = "categoryfilter_example";  // string? | Optionally filter response to only include news items in a certain category. (optional) 
            var includebody = true;  // bool? | Optionally include full content body for each news item. (optional) 

            try
            {
                ContentRssNewsArticles200Response result = apiInstance.ContentRssNewsArticles(pageToken, categoryfilter, includebody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ContentRssNewsArticles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentRssNewsArticlesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentRssNewsArticles200Response> response = apiInstance.ContentRssNewsArticlesWithHttpInfo(pageToken, categoryfilter, includebody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentApi.ContentRssNewsArticlesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageToken** | **string** | Zero-based pagination token for paging through result sets. |  |
| **categoryfilter** | **string?** | Optionally filter response to only include news items in a certain category. | [optional]  |
| **includebody** | **bool?** | Optionally include full content body for each news item. | [optional]  |

### Return type

[**ContentRssNewsArticles200Response**](ContentRssNewsArticles200Response.md)

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

<a id="contentsearchcontentbytagandtype"></a>
# **ContentSearchContentByTagAndType**
> ContentSearchContentWithText200Response ContentSearchContentByTagAndType (string locale, string tag, string type, int? currentpage = null, bool? head = null, int? itemsperpage = null)



Searches for Content Items that match the given Tag and Content Type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ContentSearchContentByTagAndTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ContentApi(config);
            var locale = "locale_example";  // string | 
            var tag = "tag_example";  // string | 
            var type = "type_example";  // string | 
            var currentpage = 56;  // int? | Page number for the search results starting with page 1. (optional) 
            var head = true;  // bool? | Not used. (optional) 
            var itemsperpage = 56;  // int? | Not used. (optional) 

            try
            {
                ContentSearchContentWithText200Response result = apiInstance.ContentSearchContentByTagAndType(locale, tag, type, currentpage, head, itemsperpage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ContentSearchContentByTagAndType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentSearchContentByTagAndTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentSearchContentWithText200Response> response = apiInstance.ContentSearchContentByTagAndTypeWithHttpInfo(locale, tag, type, currentpage, head, itemsperpage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentApi.ContentSearchContentByTagAndTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locale** | **string** |  |  |
| **tag** | **string** |  |  |
| **type** | **string** |  |  |
| **currentpage** | **int?** | Page number for the search results starting with page 1. | [optional]  |
| **head** | **bool?** | Not used. | [optional]  |
| **itemsperpage** | **int?** | Not used. | [optional]  |

### Return type

[**ContentSearchContentWithText200Response**](ContentSearchContentWithText200Response.md)

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

<a id="contentsearchcontentwithtext"></a>
# **ContentSearchContentWithText**
> ContentSearchContentWithText200Response ContentSearchContentWithText (string locale, string? ctype = null, int? currentpage = null, bool? head = null, string? searchtext = null, string? source = null, string? tag = null)



Gets content based on querystring information passed in. Provides basic search and text search capabilities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ContentSearchContentWithTextExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ContentApi(config);
            var locale = "locale_example";  // string | 
            var ctype = "ctype_example";  // string? | Content type tag: Help, News, etc. Supply multiple ctypes separated by space. (optional) 
            var currentpage = 56;  // int? | Page number for the search results, starting with page 1. (optional) 
            var head = true;  // bool? | Not used. (optional) 
            var searchtext = "searchtext_example";  // string? | Word or phrase for the search. (optional) 
            var source = "source_example";  // string? | For analytics, hint at the part of the app that triggered the search. Optional. (optional) 
            var tag = "tag_example";  // string? | Tag used on the content to be searched. (optional) 

            try
            {
                ContentSearchContentWithText200Response result = apiInstance.ContentSearchContentWithText(locale, ctype, currentpage, head, searchtext, source, tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ContentSearchContentWithText: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentSearchContentWithTextWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentSearchContentWithText200Response> response = apiInstance.ContentSearchContentWithTextWithHttpInfo(locale, ctype, currentpage, head, searchtext, source, tag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentApi.ContentSearchContentWithTextWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locale** | **string** |  |  |
| **ctype** | **string?** | Content type tag: Help, News, etc. Supply multiple ctypes separated by space. | [optional]  |
| **currentpage** | **int?** | Page number for the search results, starting with page 1. | [optional]  |
| **head** | **bool?** | Not used. | [optional]  |
| **searchtext** | **string?** | Word or phrase for the search. | [optional]  |
| **source** | **string?** | For analytics, hint at the part of the app that triggered the search. Optional. | [optional]  |
| **tag** | **string?** | Tag used on the content to be searched. | [optional]  |

### Return type

[**ContentSearchContentWithText200Response**](ContentSearchContentWithText200Response.md)

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

<a id="contentsearchhelparticles"></a>
# **ContentSearchHelpArticles**
> ContentSearchHelpArticles200Response ContentSearchHelpArticles (string searchtext, string size)



Search for Help Articles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Destiny.Api;
using Destiny.Client;
using Destiny.Model;

namespace Example
{
    public class ContentSearchHelpArticlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ContentApi(config);
            var searchtext = "searchtext_example";  // string | 
            var size = "size_example";  // string | 

            try
            {
                ContentSearchHelpArticles200Response result = apiInstance.ContentSearchHelpArticles(searchtext, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ContentSearchHelpArticles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContentSearchHelpArticlesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContentSearchHelpArticles200Response> response = apiInstance.ContentSearchHelpArticlesWithHttpInfo(searchtext, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentApi.ContentSearchHelpArticlesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchtext** | **string** |  |  |
| **size** | **string** |  |  |

### Return type

[**ContentSearchHelpArticles200Response**](ContentSearchHelpArticles200Response.md)

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

