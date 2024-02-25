# Bluesky.Api.AppBskyFeedApi

All URIs are relative to *https://bsky.social/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppBskyFeedGetActorFeeds**](AppBskyFeedApi.md#appbskyfeedgetactorfeeds) | **GET** /app.bsky.feed.getActorFeeds |  |
| [**AppBskyFeedGetActorLikes**](AppBskyFeedApi.md#appbskyfeedgetactorlikes) | **GET** /app.bsky.feed.getActorLikes |  |
| [**AppBskyFeedGetAuthorFeed**](AppBskyFeedApi.md#appbskyfeedgetauthorfeed) | **GET** /app.bsky.feed.getAuthorFeed |  |
| [**AppBskyFeedGetFeed**](AppBskyFeedApi.md#appbskyfeedgetfeed) | **GET** /app.bsky.feed.getFeed |  |
| [**AppBskyFeedGetFeedGenerator**](AppBskyFeedApi.md#appbskyfeedgetfeedgenerator) | **GET** /app.bsky.feed.getFeedGenerator |  |
| [**AppBskyFeedGetFeedGenerators**](AppBskyFeedApi.md#appbskyfeedgetfeedgenerators) | **GET** /app.bsky.feed.getFeedGenerators |  |
| [**AppBskyFeedGetLikes**](AppBskyFeedApi.md#appbskyfeedgetlikes) | **GET** /app.bsky.feed.getLikes |  |
| [**AppBskyFeedGetListFeed**](AppBskyFeedApi.md#appbskyfeedgetlistfeed) | **GET** /app.bsky.feed.getListFeed |  |
| [**AppBskyFeedGetPostThread**](AppBskyFeedApi.md#appbskyfeedgetpostthread) | **GET** /app.bsky.feed.getPostThread |  |
| [**AppBskyFeedGetPosts**](AppBskyFeedApi.md#appbskyfeedgetposts) | **GET** /app.bsky.feed.getPosts |  |
| [**AppBskyFeedGetRepostedBy**](AppBskyFeedApi.md#appbskyfeedgetrepostedby) | **GET** /app.bsky.feed.getRepostedBy |  |
| [**AppBskyFeedGetSuggestedFeeds**](AppBskyFeedApi.md#appbskyfeedgetsuggestedfeeds) | **GET** /app.bsky.feed.getSuggestedFeeds |  |
| [**AppBskyFeedGetTimeline**](AppBskyFeedApi.md#appbskyfeedgettimeline) | **GET** /app.bsky.feed.getTimeline |  |
| [**AppBskyFeedSearchPosts**](AppBskyFeedApi.md#appbskyfeedsearchposts) | **GET** /app.bsky.feed.searchPosts |  |

<a id="appbskyfeedgetactorfeeds"></a>
# **AppBskyFeedGetActorFeeds**
> AppBskyFeedGetActorFeeds200Response AppBskyFeedGetActorFeeds (string actor, int? limit = null, string? cursor = null)



Get a list of feeds (feed generator records) created by the actor (in the actor's repo).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedGetActorFeedsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var actor = "actor_example";  // string | 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyFeedGetActorFeeds200Response result = apiInstance.AppBskyFeedGetActorFeeds(actor, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetActorFeeds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedGetActorFeedsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedGetActorFeeds200Response> response = apiInstance.AppBskyFeedGetActorFeedsWithHttpInfo(actor, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetActorFeedsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actor** | **string** |  |  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyFeedGetActorFeeds200Response**](AppBskyFeedGetActorFeeds200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appbskyfeedgetactorlikes"></a>
# **AppBskyFeedGetActorLikes**
> AppBskyFeedGetActorLikes200Response AppBskyFeedGetActorLikes (string actor, int? limit = null, string? cursor = null)



Get a list of posts liked by an actor. Does not require auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedGetActorLikesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var actor = "actor_example";  // string | 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyFeedGetActorLikes200Response result = apiInstance.AppBskyFeedGetActorLikes(actor, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetActorLikes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedGetActorLikesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedGetActorLikes200Response> response = apiInstance.AppBskyFeedGetActorLikesWithHttpInfo(actor, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetActorLikesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actor** | **string** |  |  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyFeedGetActorLikes200Response**](AppBskyFeedGetActorLikes200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appbskyfeedgetauthorfeed"></a>
# **AppBskyFeedGetAuthorFeed**
> AppBskyFeedGetActorLikes200Response AppBskyFeedGetAuthorFeed (string actor, int? limit = null, string? cursor = null, string? filter = null)



Get a view of an actor's 'author feed' (post and reposts by the author). Does not require auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedGetAuthorFeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var actor = "actor_example";  // string | 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 
            var filter = "posts_with_replies";  // string? | Combinations of post/repost types to include in response. (optional)  (default to posts_with_replies)

            try
            {
                AppBskyFeedGetActorLikes200Response result = apiInstance.AppBskyFeedGetAuthorFeed(actor, limit, cursor, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetAuthorFeed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedGetAuthorFeedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedGetActorLikes200Response> response = apiInstance.AppBskyFeedGetAuthorFeedWithHttpInfo(actor, limit, cursor, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetAuthorFeedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actor** | **string** |  |  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |
| **filter** | **string?** | Combinations of post/repost types to include in response. | [optional] [default to posts_with_replies] |

### Return type

[**AppBskyFeedGetActorLikes200Response**](AppBskyFeedGetActorLikes200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appbskyfeedgetfeed"></a>
# **AppBskyFeedGetFeed**
> AppBskyFeedGetActorLikes200Response AppBskyFeedGetFeed (string feed, int? limit = null, string? cursor = null)



Get a hydrated feed from an actor's selected feed generator. Implemented by App View.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedGetFeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var feed = "feed_example";  // string | 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyFeedGetActorLikes200Response result = apiInstance.AppBskyFeedGetFeed(feed, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetFeed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedGetFeedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedGetActorLikes200Response> response = apiInstance.AppBskyFeedGetFeedWithHttpInfo(feed, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetFeedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **feed** | **string** |  |  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyFeedGetActorLikes200Response**](AppBskyFeedGetActorLikes200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appbskyfeedgetfeedgenerator"></a>
# **AppBskyFeedGetFeedGenerator**
> AppBskyFeedGetFeedGenerator200Response AppBskyFeedGetFeedGenerator (string feed)



Get information about a feed generator. Implemented by AppView.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedGetFeedGeneratorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var feed = "feed_example";  // string | AT-URI of the feed generator record.

            try
            {
                AppBskyFeedGetFeedGenerator200Response result = apiInstance.AppBskyFeedGetFeedGenerator(feed);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetFeedGenerator: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedGetFeedGeneratorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedGetFeedGenerator200Response> response = apiInstance.AppBskyFeedGetFeedGeneratorWithHttpInfo(feed);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetFeedGeneratorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **feed** | **string** | AT-URI of the feed generator record. |  |

### Return type

[**AppBskyFeedGetFeedGenerator200Response**](AppBskyFeedGetFeedGenerator200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appbskyfeedgetfeedgenerators"></a>
# **AppBskyFeedGetFeedGenerators**
> AppBskyFeedGetFeedGenerators200Response AppBskyFeedGetFeedGenerators (List<string> feeds)



Get information about a list of feed generators.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedGetFeedGeneratorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var feeds = new List<string>(); // List<string> | 

            try
            {
                AppBskyFeedGetFeedGenerators200Response result = apiInstance.AppBskyFeedGetFeedGenerators(feeds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetFeedGenerators: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedGetFeedGeneratorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedGetFeedGenerators200Response> response = apiInstance.AppBskyFeedGetFeedGeneratorsWithHttpInfo(feeds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetFeedGeneratorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **feeds** | [**List&lt;string&gt;**](string.md) |  |  |

### Return type

[**AppBskyFeedGetFeedGenerators200Response**](AppBskyFeedGetFeedGenerators200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appbskyfeedgetlikes"></a>
# **AppBskyFeedGetLikes**
> AppBskyFeedGetLikes200Response AppBskyFeedGetLikes (string uri, string? cid = null, int? limit = null, string? cursor = null)



Get like records which reference a subject (by AT-URI and CID).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedGetLikesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var uri = "uri_example";  // string | AT-URI of the subject (eg, a post record).
            var cid = "cid_example";  // string? | CID of the subject record (aka, specific version of record), to filter likes. (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyFeedGetLikes200Response result = apiInstance.AppBskyFeedGetLikes(uri, cid, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetLikes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedGetLikesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedGetLikes200Response> response = apiInstance.AppBskyFeedGetLikesWithHttpInfo(uri, cid, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetLikesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uri** | **string** | AT-URI of the subject (eg, a post record). |  |
| **cid** | **string?** | CID of the subject record (aka, specific version of record), to filter likes. | [optional]  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyFeedGetLikes200Response**](AppBskyFeedGetLikes200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appbskyfeedgetlistfeed"></a>
# **AppBskyFeedGetListFeed**
> AppBskyFeedGetActorLikes200Response AppBskyFeedGetListFeed (string list, int? limit = null, string? cursor = null)



Get a feed of recent posts from a list (posts and reposts from any actors on the list). Does not require auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedGetListFeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var list = "list_example";  // string | Reference (AT-URI) to the list record.
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyFeedGetActorLikes200Response result = apiInstance.AppBskyFeedGetListFeed(list, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetListFeed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedGetListFeedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedGetActorLikes200Response> response = apiInstance.AppBskyFeedGetListFeedWithHttpInfo(list, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetListFeedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **list** | **string** | Reference (AT-URI) to the list record. |  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyFeedGetActorLikes200Response**](AppBskyFeedGetActorLikes200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appbskyfeedgetpostthread"></a>
# **AppBskyFeedGetPostThread**
> AppBskyFeedGetPostThread200Response AppBskyFeedGetPostThread (string uri, int? depth = null, int? parentHeight = null)



Get posts in a thread. Does not require auth, but additional metadata and filtering will be applied for authed requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedGetPostThreadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var uri = "uri_example";  // string | Reference (AT-URI) to post record.
            var depth = 6;  // int? | How many levels of reply depth should be included in response. (optional)  (default to 6)
            var parentHeight = 80;  // int? | How many levels of parent (and grandparent, etc) post to include. (optional)  (default to 80)

            try
            {
                AppBskyFeedGetPostThread200Response result = apiInstance.AppBskyFeedGetPostThread(uri, depth, parentHeight);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetPostThread: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedGetPostThreadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedGetPostThread200Response> response = apiInstance.AppBskyFeedGetPostThreadWithHttpInfo(uri, depth, parentHeight);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetPostThreadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uri** | **string** | Reference (AT-URI) to post record. |  |
| **depth** | **int?** | How many levels of reply depth should be included in response. | [optional] [default to 6] |
| **parentHeight** | **int?** | How many levels of parent (and grandparent, etc) post to include. | [optional] [default to 80] |

### Return type

[**AppBskyFeedGetPostThread200Response**](AppBskyFeedGetPostThread200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appbskyfeedgetposts"></a>
# **AppBskyFeedGetPosts**
> AppBskyFeedGetPosts200Response AppBskyFeedGetPosts (List<string> uris)



Gets post views for a specified list of posts (by AT-URI). This is sometimes referred to as 'hydrating' a 'feed skeleton'.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedGetPostsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var uris = new List<string>(); // List<string> | List of post AT-URIs to return hydrated views for.

            try
            {
                AppBskyFeedGetPosts200Response result = apiInstance.AppBskyFeedGetPosts(uris);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetPosts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedGetPostsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedGetPosts200Response> response = apiInstance.AppBskyFeedGetPostsWithHttpInfo(uris);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetPostsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uris** | [**List&lt;string&gt;**](string.md) | List of post AT-URIs to return hydrated views for. |  |

### Return type

[**AppBskyFeedGetPosts200Response**](AppBskyFeedGetPosts200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appbskyfeedgetrepostedby"></a>
# **AppBskyFeedGetRepostedBy**
> AppBskyFeedGetRepostedBy200Response AppBskyFeedGetRepostedBy (string uri, string? cid = null, int? limit = null, string? cursor = null)



Get a list of reposts for a given post.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedGetRepostedByExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var uri = "uri_example";  // string | Reference (AT-URI) of post record
            var cid = "cid_example";  // string? | If supplied, filters to reposts of specific version (by CID) of the post record. (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyFeedGetRepostedBy200Response result = apiInstance.AppBskyFeedGetRepostedBy(uri, cid, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetRepostedBy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedGetRepostedByWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedGetRepostedBy200Response> response = apiInstance.AppBskyFeedGetRepostedByWithHttpInfo(uri, cid, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetRepostedByWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uri** | **string** | Reference (AT-URI) of post record |  |
| **cid** | **string?** | If supplied, filters to reposts of specific version (by CID) of the post record. | [optional]  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyFeedGetRepostedBy200Response**](AppBskyFeedGetRepostedBy200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appbskyfeedgetsuggestedfeeds"></a>
# **AppBskyFeedGetSuggestedFeeds**
> AppBskyFeedGetActorFeeds200Response AppBskyFeedGetSuggestedFeeds (int? limit = null, string? cursor = null)



Get a list of suggested feeds (feed generators) for the requesting account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedGetSuggestedFeedsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyFeedGetActorFeeds200Response result = apiInstance.AppBskyFeedGetSuggestedFeeds(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetSuggestedFeeds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedGetSuggestedFeedsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedGetActorFeeds200Response> response = apiInstance.AppBskyFeedGetSuggestedFeedsWithHttpInfo(limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetSuggestedFeedsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyFeedGetActorFeeds200Response**](AppBskyFeedGetActorFeeds200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appbskyfeedgettimeline"></a>
# **AppBskyFeedGetTimeline**
> AppBskyFeedGetActorLikes200Response AppBskyFeedGetTimeline (string? algorithm = null, int? limit = null, string? cursor = null)



Get a view of the requesting account's home timeline. This is expected to be some form of reverse-chronological feed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedGetTimelineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var algorithm = "algorithm_example";  // string? | Variant 'algorithm' for timeline. Implementation-specific. NOTE: most feed flexibility has been moved to feed generator mechanism. (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyFeedGetActorLikes200Response result = apiInstance.AppBskyFeedGetTimeline(algorithm, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetTimeline: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedGetTimelineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedGetActorLikes200Response> response = apiInstance.AppBskyFeedGetTimelineWithHttpInfo(algorithm, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedGetTimelineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **algorithm** | **string?** | Variant &#39;algorithm&#39; for timeline. Implementation-specific. NOTE: most feed flexibility has been moved to feed generator mechanism. | [optional]  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyFeedGetActorLikes200Response**](AppBskyFeedGetActorLikes200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appbskyfeedsearchposts"></a>
# **AppBskyFeedSearchPosts**
> AppBskyFeedSearchPosts200Response AppBskyFeedSearchPosts (string q, int? limit = null, string? cursor = null)



Find posts matching search criteria, returning views of those posts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class AppBskyFeedSearchPostsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyFeedApi(config);
            var q = "q_example";  // string | Search query string; syntax, phrase, boolean, and faceting is unspecified, but Lucene query syntax is recommended.
            var limit = 25;  // int? |  (optional)  (default to 25)
            var cursor = "cursor_example";  // string? | Optional pagination mechanism; may not necessarily allow scrolling through entire result set. (optional) 

            try
            {
                AppBskyFeedSearchPosts200Response result = apiInstance.AppBskyFeedSearchPosts(q, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedSearchPosts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyFeedSearchPostsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedSearchPosts200Response> response = apiInstance.AppBskyFeedSearchPostsWithHttpInfo(q, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyFeedApi.AppBskyFeedSearchPostsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string** | Search query string; syntax, phrase, boolean, and faceting is unspecified, but Lucene query syntax is recommended. |  |
| **limit** | **int?** |  | [optional] [default to 25] |
| **cursor** | **string?** | Optional pagination mechanism; may not necessarily allow scrolling through entire result set. | [optional]  |

### Return type

[**AppBskyFeedSearchPosts200Response**](AppBskyFeedSearchPosts200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

