# Bluesky.Api.ComAtprotoAdminApi

All URIs are relative to *https://bsky.social/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ComAtprotoAdminCreateCommunicationTemplate**](ComAtprotoAdminApi.md#comatprotoadmincreatecommunicationtemplate) | **POST** /com.atproto.admin.createCommunicationTemplate |  |
| [**ComAtprotoAdminDeleteAccount**](ComAtprotoAdminApi.md#comatprotoadmindeleteaccount) | **POST** /com.atproto.admin.deleteAccount |  |
| [**ComAtprotoAdminDeleteCommunicationTemplate**](ComAtprotoAdminApi.md#comatprotoadmindeletecommunicationtemplate) | **POST** /com.atproto.admin.deleteCommunicationTemplate |  |
| [**ComAtprotoAdminDisableAccountInvites**](ComAtprotoAdminApi.md#comatprotoadmindisableaccountinvites) | **POST** /com.atproto.admin.disableAccountInvites |  |
| [**ComAtprotoAdminDisableInviteCodes**](ComAtprotoAdminApi.md#comatprotoadmindisableinvitecodes) | **POST** /com.atproto.admin.disableInviteCodes |  |
| [**ComAtprotoAdminEmitModerationEvent**](ComAtprotoAdminApi.md#comatprotoadminemitmoderationevent) | **POST** /com.atproto.admin.emitModerationEvent |  |
| [**ComAtprotoAdminEnableAccountInvites**](ComAtprotoAdminApi.md#comatprotoadminenableaccountinvites) | **POST** /com.atproto.admin.enableAccountInvites |  |
| [**ComAtprotoAdminGetAccountInfo**](ComAtprotoAdminApi.md#comatprotoadmingetaccountinfo) | **GET** /com.atproto.admin.getAccountInfo |  |
| [**ComAtprotoAdminGetInviteCodes**](ComAtprotoAdminApi.md#comatprotoadmingetinvitecodes) | **GET** /com.atproto.admin.getInviteCodes |  |
| [**ComAtprotoAdminGetModerationEvent**](ComAtprotoAdminApi.md#comatprotoadmingetmoderationevent) | **GET** /com.atproto.admin.getModerationEvent |  |
| [**ComAtprotoAdminGetRecord**](ComAtprotoAdminApi.md#comatprotoadmingetrecord) | **GET** /com.atproto.admin.getRecord |  |
| [**ComAtprotoAdminGetRepo**](ComAtprotoAdminApi.md#comatprotoadmingetrepo) | **GET** /com.atproto.admin.getRepo |  |
| [**ComAtprotoAdminGetSubjectStatus**](ComAtprotoAdminApi.md#comatprotoadmingetsubjectstatus) | **GET** /com.atproto.admin.getSubjectStatus |  |
| [**ComAtprotoAdminListCommunicationTemplates**](ComAtprotoAdminApi.md#comatprotoadminlistcommunicationtemplates) | **GET** /com.atproto.admin.listCommunicationTemplates |  |
| [**ComAtprotoAdminQueryModerationEvents**](ComAtprotoAdminApi.md#comatprotoadminquerymoderationevents) | **GET** /com.atproto.admin.queryModerationEvents |  |
| [**ComAtprotoAdminQueryModerationStatuses**](ComAtprotoAdminApi.md#comatprotoadminquerymoderationstatuses) | **GET** /com.atproto.admin.queryModerationStatuses |  |
| [**ComAtprotoAdminSearchRepos**](ComAtprotoAdminApi.md#comatprotoadminsearchrepos) | **GET** /com.atproto.admin.searchRepos |  |
| [**ComAtprotoAdminSendEmail**](ComAtprotoAdminApi.md#comatprotoadminsendemail) | **POST** /com.atproto.admin.sendEmail |  |
| [**ComAtprotoAdminUpdateAccountEmail**](ComAtprotoAdminApi.md#comatprotoadminupdateaccountemail) | **POST** /com.atproto.admin.updateAccountEmail |  |
| [**ComAtprotoAdminUpdateAccountHandle**](ComAtprotoAdminApi.md#comatprotoadminupdateaccounthandle) | **POST** /com.atproto.admin.updateAccountHandle |  |
| [**ComAtprotoAdminUpdateAccountPassword**](ComAtprotoAdminApi.md#comatprotoadminupdateaccountpassword) | **POST** /com.atproto.admin.updateAccountPassword |  |
| [**ComAtprotoAdminUpdateCommunicationTemplate**](ComAtprotoAdminApi.md#comatprotoadminupdatecommunicationtemplate) | **POST** /com.atproto.admin.updateCommunicationTemplate |  |
| [**ComAtprotoAdminUpdateSubjectStatus**](ComAtprotoAdminApi.md#comatprotoadminupdatesubjectstatus) | **POST** /com.atproto.admin.updateSubjectStatus |  |

<a id="comatprotoadmincreatecommunicationtemplate"></a>
# **ComAtprotoAdminCreateCommunicationTemplate**
> ComAtprotoAdminDefsCommunicationTemplateView ComAtprotoAdminCreateCommunicationTemplate (ComAtprotoAdminCreateCommunicationTemplateRequest comAtprotoAdminCreateCommunicationTemplateRequest)



Administrative action to create a new, re-usable communication (email for now) template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminCreateCommunicationTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminCreateCommunicationTemplateRequest = new ComAtprotoAdminCreateCommunicationTemplateRequest(); // ComAtprotoAdminCreateCommunicationTemplateRequest | 

            try
            {
                ComAtprotoAdminDefsCommunicationTemplateView result = apiInstance.ComAtprotoAdminCreateCommunicationTemplate(comAtprotoAdminCreateCommunicationTemplateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminCreateCommunicationTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminCreateCommunicationTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminDefsCommunicationTemplateView> response = apiInstance.ComAtprotoAdminCreateCommunicationTemplateWithHttpInfo(comAtprotoAdminCreateCommunicationTemplateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminCreateCommunicationTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminCreateCommunicationTemplateRequest** | [**ComAtprotoAdminCreateCommunicationTemplateRequest**](ComAtprotoAdminCreateCommunicationTemplateRequest.md) |  |  |

### Return type

[**ComAtprotoAdminDefsCommunicationTemplateView**](ComAtprotoAdminDefsCommunicationTemplateView.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoadmindeleteaccount"></a>
# **ComAtprotoAdminDeleteAccount**
> void ComAtprotoAdminDeleteAccount (ComAtprotoAdminDeleteAccountRequest comAtprotoAdminDeleteAccountRequest)



Delete a user account as an administrator.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminDeleteAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminDeleteAccountRequest = new ComAtprotoAdminDeleteAccountRequest(); // ComAtprotoAdminDeleteAccountRequest | 

            try
            {
                apiInstance.ComAtprotoAdminDeleteAccount(comAtprotoAdminDeleteAccountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDeleteAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminDeleteAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminDeleteAccountWithHttpInfo(comAtprotoAdminDeleteAccountRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDeleteAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminDeleteAccountRequest** | [**ComAtprotoAdminDeleteAccountRequest**](ComAtprotoAdminDeleteAccountRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoadmindeletecommunicationtemplate"></a>
# **ComAtprotoAdminDeleteCommunicationTemplate**
> void ComAtprotoAdminDeleteCommunicationTemplate (ComAtprotoAdminDeleteCommunicationTemplateRequest comAtprotoAdminDeleteCommunicationTemplateRequest)



Delete a communication template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminDeleteCommunicationTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminDeleteCommunicationTemplateRequest = new ComAtprotoAdminDeleteCommunicationTemplateRequest(); // ComAtprotoAdminDeleteCommunicationTemplateRequest | 

            try
            {
                apiInstance.ComAtprotoAdminDeleteCommunicationTemplate(comAtprotoAdminDeleteCommunicationTemplateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDeleteCommunicationTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminDeleteCommunicationTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminDeleteCommunicationTemplateWithHttpInfo(comAtprotoAdminDeleteCommunicationTemplateRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDeleteCommunicationTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminDeleteCommunicationTemplateRequest** | [**ComAtprotoAdminDeleteCommunicationTemplateRequest**](ComAtprotoAdminDeleteCommunicationTemplateRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoadmindisableaccountinvites"></a>
# **ComAtprotoAdminDisableAccountInvites**
> void ComAtprotoAdminDisableAccountInvites (ComAtprotoAdminDisableAccountInvitesRequest comAtprotoAdminDisableAccountInvitesRequest)



Disable an account from receiving new invite codes, but does not invalidate existing codes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminDisableAccountInvitesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminDisableAccountInvitesRequest = new ComAtprotoAdminDisableAccountInvitesRequest(); // ComAtprotoAdminDisableAccountInvitesRequest | 

            try
            {
                apiInstance.ComAtprotoAdminDisableAccountInvites(comAtprotoAdminDisableAccountInvitesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDisableAccountInvites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminDisableAccountInvitesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminDisableAccountInvitesWithHttpInfo(comAtprotoAdminDisableAccountInvitesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDisableAccountInvitesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminDisableAccountInvitesRequest** | [**ComAtprotoAdminDisableAccountInvitesRequest**](ComAtprotoAdminDisableAccountInvitesRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoadmindisableinvitecodes"></a>
# **ComAtprotoAdminDisableInviteCodes**
> void ComAtprotoAdminDisableInviteCodes (ComAtprotoAdminDisableInviteCodesRequest comAtprotoAdminDisableInviteCodesRequest)



Disable some set of codes and/or all codes associated with a set of users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminDisableInviteCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminDisableInviteCodesRequest = new ComAtprotoAdminDisableInviteCodesRequest(); // ComAtprotoAdminDisableInviteCodesRequest | 

            try
            {
                apiInstance.ComAtprotoAdminDisableInviteCodes(comAtprotoAdminDisableInviteCodesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDisableInviteCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminDisableInviteCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminDisableInviteCodesWithHttpInfo(comAtprotoAdminDisableInviteCodesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDisableInviteCodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminDisableInviteCodesRequest** | [**ComAtprotoAdminDisableInviteCodesRequest**](ComAtprotoAdminDisableInviteCodesRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoadminemitmoderationevent"></a>
# **ComAtprotoAdminEmitModerationEvent**
> ComAtprotoAdminDefsModEventView ComAtprotoAdminEmitModerationEvent (ComAtprotoAdminEmitModerationEventRequest comAtprotoAdminEmitModerationEventRequest)



Take a moderation action on an actor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminEmitModerationEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminEmitModerationEventRequest = new ComAtprotoAdminEmitModerationEventRequest(); // ComAtprotoAdminEmitModerationEventRequest | 

            try
            {
                ComAtprotoAdminDefsModEventView result = apiInstance.ComAtprotoAdminEmitModerationEvent(comAtprotoAdminEmitModerationEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminEmitModerationEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminEmitModerationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminDefsModEventView> response = apiInstance.ComAtprotoAdminEmitModerationEventWithHttpInfo(comAtprotoAdminEmitModerationEventRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminEmitModerationEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminEmitModerationEventRequest** | [**ComAtprotoAdminEmitModerationEventRequest**](ComAtprotoAdminEmitModerationEventRequest.md) |  |  |

### Return type

[**ComAtprotoAdminDefsModEventView**](ComAtprotoAdminDefsModEventView.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoadminenableaccountinvites"></a>
# **ComAtprotoAdminEnableAccountInvites**
> void ComAtprotoAdminEnableAccountInvites (ComAtprotoAdminEnableAccountInvitesRequest comAtprotoAdminEnableAccountInvitesRequest)



Re-enable an account's ability to receive invite codes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminEnableAccountInvitesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminEnableAccountInvitesRequest = new ComAtprotoAdminEnableAccountInvitesRequest(); // ComAtprotoAdminEnableAccountInvitesRequest | 

            try
            {
                apiInstance.ComAtprotoAdminEnableAccountInvites(comAtprotoAdminEnableAccountInvitesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminEnableAccountInvites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminEnableAccountInvitesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminEnableAccountInvitesWithHttpInfo(comAtprotoAdminEnableAccountInvitesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminEnableAccountInvitesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminEnableAccountInvitesRequest** | [**ComAtprotoAdminEnableAccountInvitesRequest**](ComAtprotoAdminEnableAccountInvitesRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoadmingetaccountinfo"></a>
# **ComAtprotoAdminGetAccountInfo**
> ComAtprotoAdminDefsAccountView ComAtprotoAdminGetAccountInfo (string did)



Get details about an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminGetAccountInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var did = "did_example";  // string | 

            try
            {
                ComAtprotoAdminDefsAccountView result = apiInstance.ComAtprotoAdminGetAccountInfo(did);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetAccountInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminGetAccountInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminDefsAccountView> response = apiInstance.ComAtprotoAdminGetAccountInfoWithHttpInfo(did);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetAccountInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **did** | **string** |  |  |

### Return type

[**ComAtprotoAdminDefsAccountView**](ComAtprotoAdminDefsAccountView.md)

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

<a id="comatprotoadmingetinvitecodes"></a>
# **ComAtprotoAdminGetInviteCodes**
> ComAtprotoAdminGetInviteCodes200Response ComAtprotoAdminGetInviteCodes (string? sort = null, int? limit = null, string? cursor = null)



Get an admin view of invite codes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminGetInviteCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var sort = "recent";  // string? |  (optional)  (default to recent)
            var limit = 100;  // int? |  (optional)  (default to 100)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ComAtprotoAdminGetInviteCodes200Response result = apiInstance.ComAtprotoAdminGetInviteCodes(sort, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetInviteCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminGetInviteCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminGetInviteCodes200Response> response = apiInstance.ComAtprotoAdminGetInviteCodesWithHttpInfo(sort, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetInviteCodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sort** | **string?** |  | [optional] [default to recent] |
| **limit** | **int?** |  | [optional] [default to 100] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ComAtprotoAdminGetInviteCodes200Response**](ComAtprotoAdminGetInviteCodes200Response.md)

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

<a id="comatprotoadmingetmoderationevent"></a>
# **ComAtprotoAdminGetModerationEvent**
> ComAtprotoAdminDefsModEventViewDetail ComAtprotoAdminGetModerationEvent (int id)



Get details about a moderation event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminGetModerationEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var id = 56;  // int | 

            try
            {
                ComAtprotoAdminDefsModEventViewDetail result = apiInstance.ComAtprotoAdminGetModerationEvent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetModerationEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminGetModerationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminDefsModEventViewDetail> response = apiInstance.ComAtprotoAdminGetModerationEventWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetModerationEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**ComAtprotoAdminDefsModEventViewDetail**](ComAtprotoAdminDefsModEventViewDetail.md)

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

<a id="comatprotoadmingetrecord"></a>
# **ComAtprotoAdminGetRecord**
> ComAtprotoAdminDefsRecordViewDetail ComAtprotoAdminGetRecord (string uri, string? cid = null)



Get details about a record.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminGetRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var uri = "uri_example";  // string | 
            var cid = "cid_example";  // string? |  (optional) 

            try
            {
                ComAtprotoAdminDefsRecordViewDetail result = apiInstance.ComAtprotoAdminGetRecord(uri, cid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminGetRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminDefsRecordViewDetail> response = apiInstance.ComAtprotoAdminGetRecordWithHttpInfo(uri, cid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uri** | **string** |  |  |
| **cid** | **string?** |  | [optional]  |

### Return type

[**ComAtprotoAdminDefsRecordViewDetail**](ComAtprotoAdminDefsRecordViewDetail.md)

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

<a id="comatprotoadmingetrepo"></a>
# **ComAtprotoAdminGetRepo**
> ComAtprotoAdminDefsRepoViewDetail ComAtprotoAdminGetRepo (string did)



Get details about a repository.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminGetRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var did = "did_example";  // string | 

            try
            {
                ComAtprotoAdminDefsRepoViewDetail result = apiInstance.ComAtprotoAdminGetRepo(did);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminGetRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminDefsRepoViewDetail> response = apiInstance.ComAtprotoAdminGetRepoWithHttpInfo(did);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **did** | **string** |  |  |

### Return type

[**ComAtprotoAdminDefsRepoViewDetail**](ComAtprotoAdminDefsRepoViewDetail.md)

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

<a id="comatprotoadmingetsubjectstatus"></a>
# **ComAtprotoAdminGetSubjectStatus**
> ComAtprotoAdminGetSubjectStatus200Response ComAtprotoAdminGetSubjectStatus (string? did = null, string? uri = null, string? blob = null)



Get the service-specific admin status of a subject (account, record, or blob).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminGetSubjectStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var did = "did_example";  // string? |  (optional) 
            var uri = "uri_example";  // string? |  (optional) 
            var blob = "blob_example";  // string? |  (optional) 

            try
            {
                ComAtprotoAdminGetSubjectStatus200Response result = apiInstance.ComAtprotoAdminGetSubjectStatus(did, uri, blob);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetSubjectStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminGetSubjectStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminGetSubjectStatus200Response> response = apiInstance.ComAtprotoAdminGetSubjectStatusWithHttpInfo(did, uri, blob);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetSubjectStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **did** | **string?** |  | [optional]  |
| **uri** | **string?** |  | [optional]  |
| **blob** | **string?** |  | [optional]  |

### Return type

[**ComAtprotoAdminGetSubjectStatus200Response**](ComAtprotoAdminGetSubjectStatus200Response.md)

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

<a id="comatprotoadminlistcommunicationtemplates"></a>
# **ComAtprotoAdminListCommunicationTemplates**
> ComAtprotoAdminListCommunicationTemplates200Response ComAtprotoAdminListCommunicationTemplates ()



Get list of all communication templates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminListCommunicationTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);

            try
            {
                ComAtprotoAdminListCommunicationTemplates200Response result = apiInstance.ComAtprotoAdminListCommunicationTemplates();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminListCommunicationTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminListCommunicationTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminListCommunicationTemplates200Response> response = apiInstance.ComAtprotoAdminListCommunicationTemplatesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminListCommunicationTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ComAtprotoAdminListCommunicationTemplates200Response**](ComAtprotoAdminListCommunicationTemplates200Response.md)

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

<a id="comatprotoadminquerymoderationevents"></a>
# **ComAtprotoAdminQueryModerationEvents**
> ComAtprotoAdminQueryModerationEvents200Response ComAtprotoAdminQueryModerationEvents (List<string>? types = null, string? createdBy = null, string? sortDirection = null, DateTime? createdAfter = null, DateTime? createdBefore = null, string? subject = null, bool? includeAllUserRecords = null, int? limit = null, bool? hasComment = null, string? comment = null, List<string>? addedLabels = null, List<string>? removedLabels = null, List<string>? addedTags = null, List<string>? removedTags = null, List<string>? reportTypes = null, string? cursor = null)



List moderation events related to a subject.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminQueryModerationEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var types = new List<string>?(); // List<string>? | The types of events (fully qualified string in the format of com.atproto.admin#modEvent<name>) to filter by. If not specified, all events are returned. (optional) 
            var createdBy = "createdBy_example";  // string? |  (optional) 
            var sortDirection = "\"desc\"";  // string? | Sort direction for the events. Defaults to descending order of created at timestamp. (optional)  (default to "desc")
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Retrieve events created after a given timestamp (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Retrieve events created before a given timestamp (optional) 
            var subject = "subject_example";  // string? |  (optional) 
            var includeAllUserRecords = true;  // bool? | If true, events on all record types (posts, lists, profile etc.) owned by the did are returned (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var hasComment = true;  // bool? | If true, only events with comments are returned (optional) 
            var comment = "comment_example";  // string? | If specified, only events with comments containing the keyword are returned (optional) 
            var addedLabels = new List<string>?(); // List<string>? | If specified, only events where all of these labels were added are returned (optional) 
            var removedLabels = new List<string>?(); // List<string>? | If specified, only events where all of these labels were removed are returned (optional) 
            var addedTags = new List<string>?(); // List<string>? | If specified, only events where all of these tags were added are returned (optional) 
            var removedTags = new List<string>?(); // List<string>? | If specified, only events where all of these tags were removed are returned (optional) 
            var reportTypes = new List<string>?(); // List<string>? |  (optional) 
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ComAtprotoAdminQueryModerationEvents200Response result = apiInstance.ComAtprotoAdminQueryModerationEvents(types, createdBy, sortDirection, createdAfter, createdBefore, subject, includeAllUserRecords, limit, hasComment, comment, addedLabels, removedLabels, addedTags, removedTags, reportTypes, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminQueryModerationEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminQueryModerationEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminQueryModerationEvents200Response> response = apiInstance.ComAtprotoAdminQueryModerationEventsWithHttpInfo(types, createdBy, sortDirection, createdAfter, createdBefore, subject, includeAllUserRecords, limit, hasComment, comment, addedLabels, removedLabels, addedTags, removedTags, reportTypes, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminQueryModerationEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **types** | [**List&lt;string&gt;?**](string.md) | The types of events (fully qualified string in the format of com.atproto.admin#modEvent&lt;name&gt;) to filter by. If not specified, all events are returned. | [optional]  |
| **createdBy** | **string?** |  | [optional]  |
| **sortDirection** | **string?** | Sort direction for the events. Defaults to descending order of created at timestamp. | [optional] [default to &quot;desc&quot;] |
| **createdAfter** | **DateTime?** | Retrieve events created after a given timestamp | [optional]  |
| **createdBefore** | **DateTime?** | Retrieve events created before a given timestamp | [optional]  |
| **subject** | **string?** |  | [optional]  |
| **includeAllUserRecords** | **bool?** | If true, events on all record types (posts, lists, profile etc.) owned by the did are returned | [optional]  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **hasComment** | **bool?** | If true, only events with comments are returned | [optional]  |
| **comment** | **string?** | If specified, only events with comments containing the keyword are returned | [optional]  |
| **addedLabels** | [**List&lt;string&gt;?**](string.md) | If specified, only events where all of these labels were added are returned | [optional]  |
| **removedLabels** | [**List&lt;string&gt;?**](string.md) | If specified, only events where all of these labels were removed are returned | [optional]  |
| **addedTags** | [**List&lt;string&gt;?**](string.md) | If specified, only events where all of these tags were added are returned | [optional]  |
| **removedTags** | [**List&lt;string&gt;?**](string.md) | If specified, only events where all of these tags were removed are returned | [optional]  |
| **reportTypes** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ComAtprotoAdminQueryModerationEvents200Response**](ComAtprotoAdminQueryModerationEvents200Response.md)

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

<a id="comatprotoadminquerymoderationstatuses"></a>
# **ComAtprotoAdminQueryModerationStatuses**
> ComAtprotoAdminQueryModerationStatuses200Response ComAtprotoAdminQueryModerationStatuses (string? subject = null, string? comment = null, DateTime? reportedAfter = null, DateTime? reportedBefore = null, DateTime? reviewedAfter = null, DateTime? reviewedBefore = null, bool? includeMuted = null, string? reviewState = null, List<string>? ignoreSubjects = null, string? lastReviewedBy = null, string? sortField = null, string? sortDirection = null, bool? takendown = null, bool? appealed = null, int? limit = null, List<string>? tags = null, List<string>? excludeTags = null, string? cursor = null)



View moderation statuses of subjects (record or repo).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminQueryModerationStatusesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var subject = "subject_example";  // string? |  (optional) 
            var comment = "comment_example";  // string? | Search subjects by keyword from comments (optional) 
            var reportedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Search subjects reported after a given timestamp (optional) 
            var reportedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Search subjects reported before a given timestamp (optional) 
            var reviewedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Search subjects reviewed after a given timestamp (optional) 
            var reviewedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Search subjects reviewed before a given timestamp (optional) 
            var includeMuted = true;  // bool? | By default, we don't include muted subjects in the results. Set this to true to include them. (optional) 
            var reviewState = "reviewState_example";  // string? | Specify when fetching subjects in a certain state (optional) 
            var ignoreSubjects = new List<string>?(); // List<string>? |  (optional) 
            var lastReviewedBy = "lastReviewedBy_example";  // string? | Get all subject statuses that were reviewed by a specific moderator (optional) 
            var sortField = "\"lastReportedAt\"";  // string? |  (optional)  (default to "lastReportedAt")
            var sortDirection = "\"desc\"";  // string? |  (optional)  (default to "desc")
            var takendown = true;  // bool? | Get subjects that were taken down (optional) 
            var appealed = true;  // bool? | Get subjects in unresolved appealed status (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var tags = new List<string>?(); // List<string>? |  (optional) 
            var excludeTags = new List<string>?(); // List<string>? |  (optional) 
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ComAtprotoAdminQueryModerationStatuses200Response result = apiInstance.ComAtprotoAdminQueryModerationStatuses(subject, comment, reportedAfter, reportedBefore, reviewedAfter, reviewedBefore, includeMuted, reviewState, ignoreSubjects, lastReviewedBy, sortField, sortDirection, takendown, appealed, limit, tags, excludeTags, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminQueryModerationStatuses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminQueryModerationStatusesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminQueryModerationStatuses200Response> response = apiInstance.ComAtprotoAdminQueryModerationStatusesWithHttpInfo(subject, comment, reportedAfter, reportedBefore, reviewedAfter, reviewedBefore, includeMuted, reviewState, ignoreSubjects, lastReviewedBy, sortField, sortDirection, takendown, appealed, limit, tags, excludeTags, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminQueryModerationStatusesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subject** | **string?** |  | [optional]  |
| **comment** | **string?** | Search subjects by keyword from comments | [optional]  |
| **reportedAfter** | **DateTime?** | Search subjects reported after a given timestamp | [optional]  |
| **reportedBefore** | **DateTime?** | Search subjects reported before a given timestamp | [optional]  |
| **reviewedAfter** | **DateTime?** | Search subjects reviewed after a given timestamp | [optional]  |
| **reviewedBefore** | **DateTime?** | Search subjects reviewed before a given timestamp | [optional]  |
| **includeMuted** | **bool?** | By default, we don&#39;t include muted subjects in the results. Set this to true to include them. | [optional]  |
| **reviewState** | **string?** | Specify when fetching subjects in a certain state | [optional]  |
| **ignoreSubjects** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **lastReviewedBy** | **string?** | Get all subject statuses that were reviewed by a specific moderator | [optional]  |
| **sortField** | **string?** |  | [optional] [default to &quot;lastReportedAt&quot;] |
| **sortDirection** | **string?** |  | [optional] [default to &quot;desc&quot;] |
| **takendown** | **bool?** | Get subjects that were taken down | [optional]  |
| **appealed** | **bool?** | Get subjects in unresolved appealed status | [optional]  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **tags** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **excludeTags** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ComAtprotoAdminQueryModerationStatuses200Response**](ComAtprotoAdminQueryModerationStatuses200Response.md)

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

<a id="comatprotoadminsearchrepos"></a>
# **ComAtprotoAdminSearchRepos**
> ComAtprotoAdminSearchRepos200Response ComAtprotoAdminSearchRepos (string? q = null, int? limit = null, string? cursor = null)



Find repositories based on a search term.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminSearchReposExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var q = "q_example";  // string? |  (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ComAtprotoAdminSearchRepos200Response result = apiInstance.ComAtprotoAdminSearchRepos(q, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminSearchRepos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminSearchReposWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminSearchRepos200Response> response = apiInstance.ComAtprotoAdminSearchReposWithHttpInfo(q, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminSearchReposWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string?** |  | [optional]  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ComAtprotoAdminSearchRepos200Response**](ComAtprotoAdminSearchRepos200Response.md)

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

<a id="comatprotoadminsendemail"></a>
# **ComAtprotoAdminSendEmail**
> ComAtprotoAdminSendEmail200Response ComAtprotoAdminSendEmail (ComAtprotoAdminSendEmailRequest comAtprotoAdminSendEmailRequest)



Send email to a user's account email address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminSendEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminSendEmailRequest = new ComAtprotoAdminSendEmailRequest(); // ComAtprotoAdminSendEmailRequest | 

            try
            {
                ComAtprotoAdminSendEmail200Response result = apiInstance.ComAtprotoAdminSendEmail(comAtprotoAdminSendEmailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminSendEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminSendEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminSendEmail200Response> response = apiInstance.ComAtprotoAdminSendEmailWithHttpInfo(comAtprotoAdminSendEmailRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminSendEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminSendEmailRequest** | [**ComAtprotoAdminSendEmailRequest**](ComAtprotoAdminSendEmailRequest.md) |  |  |

### Return type

[**ComAtprotoAdminSendEmail200Response**](ComAtprotoAdminSendEmail200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoadminupdateaccountemail"></a>
# **ComAtprotoAdminUpdateAccountEmail**
> void ComAtprotoAdminUpdateAccountEmail (ComAtprotoAdminUpdateAccountEmailRequest comAtprotoAdminUpdateAccountEmailRequest)



Administrative action to update an account's email.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminUpdateAccountEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminUpdateAccountEmailRequest = new ComAtprotoAdminUpdateAccountEmailRequest(); // ComAtprotoAdminUpdateAccountEmailRequest | 

            try
            {
                apiInstance.ComAtprotoAdminUpdateAccountEmail(comAtprotoAdminUpdateAccountEmailRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateAccountEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminUpdateAccountEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminUpdateAccountEmailWithHttpInfo(comAtprotoAdminUpdateAccountEmailRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateAccountEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminUpdateAccountEmailRequest** | [**ComAtprotoAdminUpdateAccountEmailRequest**](ComAtprotoAdminUpdateAccountEmailRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoadminupdateaccounthandle"></a>
# **ComAtprotoAdminUpdateAccountHandle**
> void ComAtprotoAdminUpdateAccountHandle (ComAtprotoAdminUpdateAccountHandleRequest comAtprotoAdminUpdateAccountHandleRequest)



Administrative action to update an account's handle.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminUpdateAccountHandleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminUpdateAccountHandleRequest = new ComAtprotoAdminUpdateAccountHandleRequest(); // ComAtprotoAdminUpdateAccountHandleRequest | 

            try
            {
                apiInstance.ComAtprotoAdminUpdateAccountHandle(comAtprotoAdminUpdateAccountHandleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateAccountHandle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminUpdateAccountHandleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminUpdateAccountHandleWithHttpInfo(comAtprotoAdminUpdateAccountHandleRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateAccountHandleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminUpdateAccountHandleRequest** | [**ComAtprotoAdminUpdateAccountHandleRequest**](ComAtprotoAdminUpdateAccountHandleRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoadminupdateaccountpassword"></a>
# **ComAtprotoAdminUpdateAccountPassword**
> void ComAtprotoAdminUpdateAccountPassword (ComAtprotoAdminUpdateAccountPasswordRequest comAtprotoAdminUpdateAccountPasswordRequest)



Update the password for a user account as an administrator.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminUpdateAccountPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminUpdateAccountPasswordRequest = new ComAtprotoAdminUpdateAccountPasswordRequest(); // ComAtprotoAdminUpdateAccountPasswordRequest | 

            try
            {
                apiInstance.ComAtprotoAdminUpdateAccountPassword(comAtprotoAdminUpdateAccountPasswordRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateAccountPassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminUpdateAccountPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminUpdateAccountPasswordWithHttpInfo(comAtprotoAdminUpdateAccountPasswordRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateAccountPasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminUpdateAccountPasswordRequest** | [**ComAtprotoAdminUpdateAccountPasswordRequest**](ComAtprotoAdminUpdateAccountPasswordRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoadminupdatecommunicationtemplate"></a>
# **ComAtprotoAdminUpdateCommunicationTemplate**
> ComAtprotoAdminDefsCommunicationTemplateView ComAtprotoAdminUpdateCommunicationTemplate (ComAtprotoAdminUpdateCommunicationTemplateRequest comAtprotoAdminUpdateCommunicationTemplateRequest)



Administrative action to update an existing communication template. Allows passing partial fields to patch specific fields only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminUpdateCommunicationTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminUpdateCommunicationTemplateRequest = new ComAtprotoAdminUpdateCommunicationTemplateRequest(); // ComAtprotoAdminUpdateCommunicationTemplateRequest | 

            try
            {
                ComAtprotoAdminDefsCommunicationTemplateView result = apiInstance.ComAtprotoAdminUpdateCommunicationTemplate(comAtprotoAdminUpdateCommunicationTemplateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateCommunicationTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminUpdateCommunicationTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminDefsCommunicationTemplateView> response = apiInstance.ComAtprotoAdminUpdateCommunicationTemplateWithHttpInfo(comAtprotoAdminUpdateCommunicationTemplateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateCommunicationTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminUpdateCommunicationTemplateRequest** | [**ComAtprotoAdminUpdateCommunicationTemplateRequest**](ComAtprotoAdminUpdateCommunicationTemplateRequest.md) |  |  |

### Return type

[**ComAtprotoAdminDefsCommunicationTemplateView**](ComAtprotoAdminDefsCommunicationTemplateView.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoadminupdatesubjectstatus"></a>
# **ComAtprotoAdminUpdateSubjectStatus**
> ComAtprotoAdminGetSubjectStatus200Response ComAtprotoAdminUpdateSubjectStatus (ComAtprotoAdminGetSubjectStatus200Response comAtprotoAdminGetSubjectStatus200Response)



Update the service-specific admin status of a subject (account, record, or blob).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bluesky.Api;
using Bluesky.Client;
using Bluesky.Model;

namespace Example
{
    public class ComAtprotoAdminUpdateSubjectStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bsky.social/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminGetSubjectStatus200Response = new ComAtprotoAdminGetSubjectStatus200Response(); // ComAtprotoAdminGetSubjectStatus200Response | 

            try
            {
                ComAtprotoAdminGetSubjectStatus200Response result = apiInstance.ComAtprotoAdminUpdateSubjectStatus(comAtprotoAdminGetSubjectStatus200Response);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateSubjectStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminUpdateSubjectStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminGetSubjectStatus200Response> response = apiInstance.ComAtprotoAdminUpdateSubjectStatusWithHttpInfo(comAtprotoAdminGetSubjectStatus200Response);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateSubjectStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminGetSubjectStatus200Response** | [**ComAtprotoAdminGetSubjectStatus200Response**](ComAtprotoAdminGetSubjectStatus200Response.md) |  |  |

### Return type

[**ComAtprotoAdminGetSubjectStatus200Response**](ComAtprotoAdminGetSubjectStatus200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

