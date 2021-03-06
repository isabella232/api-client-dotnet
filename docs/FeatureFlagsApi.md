# LaunchDarkly.Api.Api.FeatureFlagsApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CopyFeatureFlag**](FeatureFlagsApi.md#copyfeatureflag) | **POST** /flags/{projectKey}/{featureFlagKey}/copy | Copies the feature flag configuration from one environment to the same feature flag in another environment.
[**DeleteFeatureFlag**](FeatureFlagsApi.md#deletefeatureflag) | **DELETE** /flags/{projectKey}/{featureFlagKey} | Delete a feature flag in all environments. Be careful- - only delete feature flags that are no longer being used by your application.
[**GetExpiringUserTargets**](FeatureFlagsApi.md#getexpiringusertargets) | **GET** /flags/{projectKey}/{featureFlagKey}/expiring-user-targets/{environmentKey} | Get expiring user targets for feature flag
[**GetFeatureFlag**](FeatureFlagsApi.md#getfeatureflag) | **GET** /flags/{projectKey}/{featureFlagKey} | Get a single feature flag by key.
[**GetFeatureFlagChangeRequest**](FeatureFlagsApi.md#getfeatureflagchangerequest) | **GET** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests/{featureFlagChangeRequestId} | Get a single change request for a feature flag
[**GetFeatureFlagChangeRequests**](FeatureFlagsApi.md#getfeatureflagchangerequests) | **GET** /{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests | Get all change requests for a feature flag
[**GetFeatureFlagStatus**](FeatureFlagsApi.md#getfeatureflagstatus) | **GET** /flag-statuses/{projectKey}/{environmentKey}/{featureFlagKey} | Get the status for a particular feature flag.
[**GetFeatureFlagStatusAcrossEnvironments**](FeatureFlagsApi.md#getfeatureflagstatusacrossenvironments) | **GET** /flag-status/{projectKey}/{featureFlagKey} | Get the status for a particular feature flag across environments
[**GetFeatureFlagStatuses**](FeatureFlagsApi.md#getfeatureflagstatuses) | **GET** /flag-statuses/{projectKey}/{environmentKey} | Get a list of statuses for all feature flags. The status includes the last time the feature flag was requested, as well as the state of the flag.
[**GetFeatureFlags**](FeatureFlagsApi.md#getfeatureflags) | **GET** /flags/{projectKey} | Get a list of all features in the given project.
[**PatchExpiringUserTargets**](FeatureFlagsApi.md#patchexpiringusertargets) | **PATCH** /flags/{projectKey}/{featureFlagKey}/expiring-user-targets/{environmentKey} | Update, add, or delete expiring user targets on feature flag
[**PatchFeatureFlag**](FeatureFlagsApi.md#patchfeatureflag) | **PATCH** /flags/{projectKey}/{featureFlagKey} | Perform a partial update to a feature.
[**PostApplyFeatureFlagChangeRequest**](FeatureFlagsApi.md#postapplyfeatureflagchangerequest) | **POST** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests/{featureFlagChangeRequestId}/apply | Apply change request for a feature flag
[**PostFeatureFlag**](FeatureFlagsApi.md#postfeatureflag) | **POST** /flags/{projectKey} | Creates a new feature flag.
[**PostFeatureFlagChangeRequest**](FeatureFlagsApi.md#postfeatureflagchangerequest) | **POST** /{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests | 
[**PostReviewFeatureFlagChangeRequest**](FeatureFlagsApi.md#postreviewfeatureflagchangerequest) | **POST** /projects/{projectKey}/flags/{featureFlagKey}/environments/{environmentKey}/approval-requests/{featureFlagChangeRequestId}/review | Review change request for a feature flag


<a name="copyfeatureflag"></a>
# **CopyFeatureFlag**
> FeatureFlag CopyFeatureFlag (string projectKey, string featureFlagKey, FeatureFlagCopyBody featureFlagCopyBody)

Copies the feature flag configuration from one environment to the same feature flag in another environment.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class CopyFeatureFlagExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.
            var featureFlagCopyBody = new FeatureFlagCopyBody(); // FeatureFlagCopyBody | Copy feature flag configurations between environments.

            try
            {
                // Copies the feature flag configuration from one environment to the same feature flag in another environment.
                FeatureFlag result = apiInstance.CopyFeatureFlag(projectKey, featureFlagKey, featureFlagCopyBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.CopyFeatureFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 
 **featureFlagCopyBody** | [**FeatureFlagCopyBody**](FeatureFlagCopyBody.md)| Copy feature flag configurations between environments. | 

### Return type

[**FeatureFlag**](FeatureFlag.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefeatureflag"></a>
# **DeleteFeatureFlag**
> void DeleteFeatureFlag (string projectKey, string featureFlagKey)

Delete a feature flag in all environments. Be careful- - only delete feature flags that are no longer being used by your application.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class DeleteFeatureFlagExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.

            try
            {
                // Delete a feature flag in all environments. Be careful- - only delete feature flags that are no longer being used by your application.
                apiInstance.DeleteFeatureFlag(projectKey, featureFlagKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.DeleteFeatureFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexpiringusertargets"></a>
# **GetExpiringUserTargets**
> UserTargetingExpirationForFlags GetExpiringUserTargets (string projectKey, string environmentKey, string featureFlagKey)

Get expiring user targets for feature flag

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetExpiringUserTargetsExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.

            try
            {
                // Get expiring user targets for feature flag
                UserTargetingExpirationForFlags result = apiInstance.GetExpiringUserTargets(projectKey, environmentKey, featureFlagKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.GetExpiringUserTargets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 

### Return type

[**UserTargetingExpirationForFlags**](UserTargetingExpirationForFlags.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureflag"></a>
# **GetFeatureFlag**
> FeatureFlag GetFeatureFlag (string projectKey, string featureFlagKey, List<string> env)

Get a single feature flag by key.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetFeatureFlagExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.
            var env = new List<string>(); // List<string> | By default, each feature will include configurations for each environment. You can filter environments with the env query parameter. For example, setting env=[\"production\"] will restrict the returned configurations to just your production environment. (optional) 

            try
            {
                // Get a single feature flag by key.
                FeatureFlag result = apiInstance.GetFeatureFlag(projectKey, featureFlagKey, env);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.GetFeatureFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 
 **env** | [**List<string>**](string.md)| By default, each feature will include configurations for each environment. You can filter environments with the env query parameter. For example, setting env&#x3D;[\&quot;production\&quot;] will restrict the returned configurations to just your production environment. | [optional] 

### Return type

[**FeatureFlag**](FeatureFlag.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureflagchangerequest"></a>
# **GetFeatureFlagChangeRequest**
> FeatureFlagChangeRequests GetFeatureFlagChangeRequest (string projectKey, string featureFlagKey, string environmentKey, string featureFlagChangeRequestId)

Get a single change request for a feature flag

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetFeatureFlagChangeRequestExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var featureFlagChangeRequestId = featureFlagChangeRequestId_example;  // string | The feature flag change request ID

            try
            {
                // Get a single change request for a feature flag
                FeatureFlagChangeRequests result = apiInstance.GetFeatureFlagChangeRequest(projectKey, featureFlagKey, environmentKey, featureFlagChangeRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.GetFeatureFlagChangeRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 
 **featureFlagChangeRequestId** | **string**| The feature flag change request ID | 

### Return type

[**FeatureFlagChangeRequests**](FeatureFlagChangeRequests.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureflagchangerequests"></a>
# **GetFeatureFlagChangeRequests**
> FeatureFlagChangeRequests GetFeatureFlagChangeRequests (string projectKey, string featureFlagKey, string environmentKey)

Get all change requests for a feature flag

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetFeatureFlagChangeRequestsExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.

            try
            {
                // Get all change requests for a feature flag
                FeatureFlagChangeRequests result = apiInstance.GetFeatureFlagChangeRequests(projectKey, featureFlagKey, environmentKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.GetFeatureFlagChangeRequests: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 

### Return type

[**FeatureFlagChangeRequests**](FeatureFlagChangeRequests.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureflagstatus"></a>
# **GetFeatureFlagStatus**
> FeatureFlagStatus GetFeatureFlagStatus (string projectKey, string environmentKey, string featureFlagKey)

Get the status for a particular feature flag.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetFeatureFlagStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.

            try
            {
                // Get the status for a particular feature flag.
                FeatureFlagStatus result = apiInstance.GetFeatureFlagStatus(projectKey, environmentKey, featureFlagKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.GetFeatureFlagStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 

### Return type

[**FeatureFlagStatus**](FeatureFlagStatus.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureflagstatusacrossenvironments"></a>
# **GetFeatureFlagStatusAcrossEnvironments**
> FeatureFlagStatusAcrossEnvironments GetFeatureFlagStatusAcrossEnvironments (string projectKey, string featureFlagKey)

Get the status for a particular feature flag across environments

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetFeatureFlagStatusAcrossEnvironmentsExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.

            try
            {
                // Get the status for a particular feature flag across environments
                FeatureFlagStatusAcrossEnvironments result = apiInstance.GetFeatureFlagStatusAcrossEnvironments(projectKey, featureFlagKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.GetFeatureFlagStatusAcrossEnvironments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 

### Return type

[**FeatureFlagStatusAcrossEnvironments**](FeatureFlagStatusAcrossEnvironments.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureflagstatuses"></a>
# **GetFeatureFlagStatuses**
> FeatureFlagStatuses GetFeatureFlagStatuses (string projectKey, string environmentKey)

Get a list of statuses for all feature flags. The status includes the last time the feature flag was requested, as well as the state of the flag.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetFeatureFlagStatusesExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.

            try
            {
                // Get a list of statuses for all feature flags. The status includes the last time the feature flag was requested, as well as the state of the flag.
                FeatureFlagStatuses result = apiInstance.GetFeatureFlagStatuses(projectKey, environmentKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.GetFeatureFlagStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 

### Return type

[**FeatureFlagStatuses**](FeatureFlagStatuses.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureflags"></a>
# **GetFeatureFlags**
> FeatureFlags GetFeatureFlags (string projectKey, List<string> env, bool? summary, bool? archived, decimal? limit, decimal? offset, string filter, string sort, string tag)

Get a list of all features in the given project.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class GetFeatureFlagsExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var env = new List<string>(); // List<string> | By default, each feature will include configurations for each environment. You can filter environments with the env query parameter. For example, setting env=[\"production\"] will restrict the returned configurations to just your production environment. (optional) 
            var summary = true;  // bool? | By default in api version >= 1, flags will _not_ include their list of prerequisites, targets or rules.  Set summary=0 to include these fields for each flag returned. (optional) 
            var archived = true;  // bool? | When set to 1, only archived flags will be included in the list of flags returned.  By default, archived flags are not included in the list of flags. (optional) 
            var limit = 8.14;  // decimal? | The number of objects to return. Defaults to -1, which returns everything. (optional) 
            var offset = 8.14;  // decimal? | Where to start in the list. This is for use with pagination. For example, an offset of 10 would skip the first 10 items and then return the next limit items. (optional) 
            var filter = filter_example;  // string | A comma-separated list of filters. Each filter is of the form field:value. (optional) 
            var sort = sort_example;  // string | A comma-separated list of fields to sort by. A field prefixed by a - will be sorted in descending order. (optional) 
            var tag = tag_example;  // string | Filter by tag. A tag can be used to group flags across projects. (optional) 

            try
            {
                // Get a list of all features in the given project.
                FeatureFlags result = apiInstance.GetFeatureFlags(projectKey, env, summary, archived, limit, offset, filter, sort, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.GetFeatureFlags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **env** | [**List<string>**](string.md)| By default, each feature will include configurations for each environment. You can filter environments with the env query parameter. For example, setting env&#x3D;[\&quot;production\&quot;] will restrict the returned configurations to just your production environment. | [optional] 
 **summary** | **bool?**| By default in api version &gt;&#x3D; 1, flags will _not_ include their list of prerequisites, targets or rules.  Set summary&#x3D;0 to include these fields for each flag returned. | [optional] 
 **archived** | **bool?**| When set to 1, only archived flags will be included in the list of flags returned.  By default, archived flags are not included in the list of flags. | [optional] 
 **limit** | **decimal?**| The number of objects to return. Defaults to -1, which returns everything. | [optional] 
 **offset** | **decimal?**| Where to start in the list. This is for use with pagination. For example, an offset of 10 would skip the first 10 items and then return the next limit items. | [optional] 
 **filter** | **string**| A comma-separated list of filters. Each filter is of the form field:value. | [optional] 
 **sort** | **string**| A comma-separated list of fields to sort by. A field prefixed by a - will be sorted in descending order. | [optional] 
 **tag** | **string**| Filter by tag. A tag can be used to group flags across projects. | [optional] 

### Return type

[**FeatureFlags**](FeatureFlags.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchexpiringusertargets"></a>
# **PatchExpiringUserTargets**
> UserTargetingExpirationForFlags PatchExpiringUserTargets (string projectKey, string environmentKey, string featureFlagKey, Object semanticPatchWithComment)

Update, add, or delete expiring user targets on feature flag

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PatchExpiringUserTargetsExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.
            var semanticPatchWithComment = ;  // Object | Requires a Semantic Patch representation of the desired changes to the resource. 'https://apidocs.launchdarkly.com/reference#updates-via-semantic-patches'. The addition of comments is also supported.

            try
            {
                // Update, add, or delete expiring user targets on feature flag
                UserTargetingExpirationForFlags result = apiInstance.PatchExpiringUserTargets(projectKey, environmentKey, featureFlagKey, semanticPatchWithComment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.PatchExpiringUserTargets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 
 **semanticPatchWithComment** | **Object**| Requires a Semantic Patch representation of the desired changes to the resource. &#39;https://apidocs.launchdarkly.com/reference#updates-via-semantic-patches&#39;. The addition of comments is also supported. | 

### Return type

[**UserTargetingExpirationForFlags**](UserTargetingExpirationForFlags.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchfeatureflag"></a>
# **PatchFeatureFlag**
> FeatureFlag PatchFeatureFlag (string projectKey, string featureFlagKey, PatchComment patchComment)

Perform a partial update to a feature.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PatchFeatureFlagExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.
            var patchComment = new PatchComment(); // PatchComment | Requires a JSON Patch representation of the desired changes to the project, and an optional comment. 'http://jsonpatch.com/' Feature flag patches also support JSON Merge Patch format. 'https://tools.ietf.org/html/rfc7386' The addition of comments is also supported.

            try
            {
                // Perform a partial update to a feature.
                FeatureFlag result = apiInstance.PatchFeatureFlag(projectKey, featureFlagKey, patchComment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.PatchFeatureFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 
 **patchComment** | [**PatchComment**](PatchComment.md)| Requires a JSON Patch representation of the desired changes to the project, and an optional comment. &#39;http://jsonpatch.com/&#39; Feature flag patches also support JSON Merge Patch format. &#39;https://tools.ietf.org/html/rfc7386&#39; The addition of comments is also supported. | 

### Return type

[**FeatureFlag**](FeatureFlag.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postapplyfeatureflagchangerequest"></a>
# **PostApplyFeatureFlagChangeRequest**
> FeatureFlagChangeRequests PostApplyFeatureFlagChangeRequest (string projectKey, string featureFlagKey, string environmentKey, string featureFlagChangeRequestId, FeatureFlagChangeRequestApplyConfigBody featureFlagChangeRequestApplyConfigBody)

Apply change request for a feature flag

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PostApplyFeatureFlagChangeRequestExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var featureFlagChangeRequestId = featureFlagChangeRequestId_example;  // string | The feature flag change request ID
            var featureFlagChangeRequestApplyConfigBody = new FeatureFlagChangeRequestApplyConfigBody(); // FeatureFlagChangeRequestApplyConfigBody | Apply a new feature flag change request

            try
            {
                // Apply change request for a feature flag
                FeatureFlagChangeRequests result = apiInstance.PostApplyFeatureFlagChangeRequest(projectKey, featureFlagKey, environmentKey, featureFlagChangeRequestId, featureFlagChangeRequestApplyConfigBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.PostApplyFeatureFlagChangeRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 
 **featureFlagChangeRequestId** | **string**| The feature flag change request ID | 
 **featureFlagChangeRequestApplyConfigBody** | [**FeatureFlagChangeRequestApplyConfigBody**](FeatureFlagChangeRequestApplyConfigBody.md)| Apply a new feature flag change request | 

### Return type

[**FeatureFlagChangeRequests**](FeatureFlagChangeRequests.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfeatureflag"></a>
# **PostFeatureFlag**
> FeatureFlag PostFeatureFlag (string projectKey, FeatureFlagBody featureFlagBody, string clone)

Creates a new feature flag.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PostFeatureFlagExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagBody = new FeatureFlagBody(); // FeatureFlagBody | Create a new feature flag.
            var clone = clone_example;  // string | The key of the feature flag to be cloned. The key identifies the flag in your code.  For example, setting clone=flagKey will copy the full targeting configuration for all environments (including on/off state) from the original flag to the new flag. (optional) 

            try
            {
                // Creates a new feature flag.
                FeatureFlag result = apiInstance.PostFeatureFlag(projectKey, featureFlagBody, clone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.PostFeatureFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagBody** | [**FeatureFlagBody**](FeatureFlagBody.md)| Create a new feature flag. | 
 **clone** | **string**| The key of the feature flag to be cloned. The key identifies the flag in your code.  For example, setting clone&#x3D;flagKey will copy the full targeting configuration for all environments (including on/off state) from the original flag to the new flag. | [optional] 

### Return type

[**FeatureFlag**](FeatureFlag.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfeatureflagchangerequest"></a>
# **PostFeatureFlagChangeRequest**
> FeatureFlagChangeRequest PostFeatureFlagChangeRequest (string projectKey, string featureFlagKey, string environmentKey, FeatureFlagChangeRequestConfigBody featureFlagChangeRequestConfigBody)



### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PostFeatureFlagChangeRequestExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var featureFlagChangeRequestConfigBody = new FeatureFlagChangeRequestConfigBody(); // FeatureFlagChangeRequestConfigBody | Create a new feature flag change request (optional) 

            try
            {
                FeatureFlagChangeRequest result = apiInstance.PostFeatureFlagChangeRequest(projectKey, featureFlagKey, environmentKey, featureFlagChangeRequestConfigBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.PostFeatureFlagChangeRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 
 **featureFlagChangeRequestConfigBody** | [**FeatureFlagChangeRequestConfigBody**](FeatureFlagChangeRequestConfigBody.md)| Create a new feature flag change request | [optional] 

### Return type

[**FeatureFlagChangeRequest**](FeatureFlagChangeRequest.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postreviewfeatureflagchangerequest"></a>
# **PostReviewFeatureFlagChangeRequest**
> FeatureFlagChangeRequests PostReviewFeatureFlagChangeRequest (string projectKey, string featureFlagKey, string environmentKey, string featureFlagChangeRequestId, FeatureFlagChangeRequestReviewConfigBody featureFlagChangeRequestReviewConfigBody)

Review change request for a feature flag

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarkly.Api.Api;
using LaunchDarkly.Api.Client;
using LaunchDarkly.Api.Model;

namespace Example
{
    public class PostReviewFeatureFlagChangeRequestExample
    {
        public void main()
        {
            
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var featureFlagChangeRequestId = featureFlagChangeRequestId_example;  // string | The feature flag change request ID
            var featureFlagChangeRequestReviewConfigBody = new FeatureFlagChangeRequestReviewConfigBody(); // FeatureFlagChangeRequestReviewConfigBody | Review a feature flag change request

            try
            {
                // Review change request for a feature flag
                FeatureFlagChangeRequests result = apiInstance.PostReviewFeatureFlagChangeRequest(projectKey, featureFlagKey, environmentKey, featureFlagChangeRequestId, featureFlagChangeRequestReviewConfigBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.PostReviewFeatureFlagChangeRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 
 **featureFlagChangeRequestId** | **string**| The feature flag change request ID | 
 **featureFlagChangeRequestReviewConfigBody** | [**FeatureFlagChangeRequestReviewConfigBody**](FeatureFlagChangeRequestReviewConfigBody.md)| Review a feature flag change request | 

### Return type

[**FeatureFlagChangeRequests**](FeatureFlagChangeRequests.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

