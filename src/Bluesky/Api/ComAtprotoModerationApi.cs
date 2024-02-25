/*
 * AT Protocol XRPC API
 *
 * This section contains HTTP API reference docs for Bluesky and AT Protocol lexicons. Generate a bearer token to test API calls directly from the docs.
 *
 * The version of the OpenAPI document: 0.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Bluesky.Client;
using Bluesky.Model;

namespace Bluesky.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IComAtprotoModerationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Submit a moderation report regarding an atproto account or record. Implemented by moderation services (with PDS proxying), and requires auth.
        /// </remarks>
        /// <exception cref="Bluesky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comAtprotoModerationCreateReportRequest"></param>
        /// <returns>ComAtprotoModerationCreateReport200Response</returns>
        ComAtprotoModerationCreateReport200Response ComAtprotoModerationCreateReport(ComAtprotoModerationCreateReportRequest comAtprotoModerationCreateReportRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Submit a moderation report regarding an atproto account or record. Implemented by moderation services (with PDS proxying), and requires auth.
        /// </remarks>
        /// <exception cref="Bluesky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comAtprotoModerationCreateReportRequest"></param>
        /// <returns>ApiResponse of ComAtprotoModerationCreateReport200Response</returns>
        ApiResponse<ComAtprotoModerationCreateReport200Response> ComAtprotoModerationCreateReportWithHttpInfo(ComAtprotoModerationCreateReportRequest comAtprotoModerationCreateReportRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IComAtprotoModerationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Submit a moderation report regarding an atproto account or record. Implemented by moderation services (with PDS proxying), and requires auth.
        /// </remarks>
        /// <exception cref="Bluesky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comAtprotoModerationCreateReportRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ComAtprotoModerationCreateReport200Response</returns>
        System.Threading.Tasks.Task<ComAtprotoModerationCreateReport200Response> ComAtprotoModerationCreateReportAsync(ComAtprotoModerationCreateReportRequest comAtprotoModerationCreateReportRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Submit a moderation report regarding an atproto account or record. Implemented by moderation services (with PDS proxying), and requires auth.
        /// </remarks>
        /// <exception cref="Bluesky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comAtprotoModerationCreateReportRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ComAtprotoModerationCreateReport200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ComAtprotoModerationCreateReport200Response>> ComAtprotoModerationCreateReportWithHttpInfoAsync(ComAtprotoModerationCreateReportRequest comAtprotoModerationCreateReportRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IComAtprotoModerationApi : IComAtprotoModerationApiSync, IComAtprotoModerationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ComAtprotoModerationApi : IDisposable, IComAtprotoModerationApi
    {
        private Bluesky.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoModerationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ComAtprotoModerationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoModerationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ComAtprotoModerationApi(string basePath)
        {
            this.Configuration = Bluesky.Client.Configuration.MergeConfigurations(
                Bluesky.Client.GlobalConfiguration.Instance,
                new Bluesky.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Bluesky.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Bluesky.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoModerationApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ComAtprotoModerationApi(Bluesky.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Bluesky.Client.Configuration.MergeConfigurations(
                Bluesky.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Bluesky.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Bluesky.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoModerationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ComAtprotoModerationApi(Bluesky.Client.ISynchronousClient client, Bluesky.Client.IAsynchronousClient asyncClient, Bluesky.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Bluesky.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public Bluesky.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Bluesky.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Bluesky.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Bluesky.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Bluesky.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  Submit a moderation report regarding an atproto account or record. Implemented by moderation services (with PDS proxying), and requires auth.
        /// </summary>
        /// <exception cref="Bluesky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comAtprotoModerationCreateReportRequest"></param>
        /// <returns>ComAtprotoModerationCreateReport200Response</returns>
        public ComAtprotoModerationCreateReport200Response ComAtprotoModerationCreateReport(ComAtprotoModerationCreateReportRequest comAtprotoModerationCreateReportRequest)
        {
            Bluesky.Client.ApiResponse<ComAtprotoModerationCreateReport200Response> localVarResponse = ComAtprotoModerationCreateReportWithHttpInfo(comAtprotoModerationCreateReportRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Submit a moderation report regarding an atproto account or record. Implemented by moderation services (with PDS proxying), and requires auth.
        /// </summary>
        /// <exception cref="Bluesky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comAtprotoModerationCreateReportRequest"></param>
        /// <returns>ApiResponse of ComAtprotoModerationCreateReport200Response</returns>
        public Bluesky.Client.ApiResponse<ComAtprotoModerationCreateReport200Response> ComAtprotoModerationCreateReportWithHttpInfo(ComAtprotoModerationCreateReportRequest comAtprotoModerationCreateReportRequest)
        {
            // verify the required parameter 'comAtprotoModerationCreateReportRequest' is set
            if (comAtprotoModerationCreateReportRequest == null)
                throw new Bluesky.Client.ApiException(400, "Missing required parameter 'comAtprotoModerationCreateReportRequest' when calling ComAtprotoModerationApi->ComAtprotoModerationCreateReport");

            Bluesky.Client.RequestOptions localVarRequestOptions = new Bluesky.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Bluesky.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Bluesky.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = comAtprotoModerationCreateReportRequest;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ComAtprotoModerationCreateReport200Response>("/com.atproto.moderation.createReport", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ComAtprotoModerationCreateReport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Submit a moderation report regarding an atproto account or record. Implemented by moderation services (with PDS proxying), and requires auth.
        /// </summary>
        /// <exception cref="Bluesky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comAtprotoModerationCreateReportRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ComAtprotoModerationCreateReport200Response</returns>
        public async System.Threading.Tasks.Task<ComAtprotoModerationCreateReport200Response> ComAtprotoModerationCreateReportAsync(ComAtprotoModerationCreateReportRequest comAtprotoModerationCreateReportRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var task = ComAtprotoModerationCreateReportWithHttpInfoAsync(comAtprotoModerationCreateReportRequest, cancellationToken);
#if UNITY_EDITOR || !UNITY_WEBGL
            Bluesky.Client.ApiResponse<ComAtprotoModerationCreateReport200Response> localVarResponse = await task.ConfigureAwait(false);
#else
            Bluesky.Client.ApiResponse<ComAtprotoModerationCreateReport200Response> localVarResponse = await task;
#endif
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Submit a moderation report regarding an atproto account or record. Implemented by moderation services (with PDS proxying), and requires auth.
        /// </summary>
        /// <exception cref="Bluesky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comAtprotoModerationCreateReportRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ComAtprotoModerationCreateReport200Response)</returns>
        public async System.Threading.Tasks.Task<Bluesky.Client.ApiResponse<ComAtprotoModerationCreateReport200Response>> ComAtprotoModerationCreateReportWithHttpInfoAsync(ComAtprotoModerationCreateReportRequest comAtprotoModerationCreateReportRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'comAtprotoModerationCreateReportRequest' is set
            if (comAtprotoModerationCreateReportRequest == null)
                throw new Bluesky.Client.ApiException(400, "Missing required parameter 'comAtprotoModerationCreateReportRequest' when calling ComAtprotoModerationApi->ComAtprotoModerationCreateReport");


            Bluesky.Client.RequestOptions localVarRequestOptions = new Bluesky.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Bluesky.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Bluesky.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = comAtprotoModerationCreateReportRequest;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var task = this.AsynchronousClient.PostAsync<ComAtprotoModerationCreateReport200Response>("/com.atproto.moderation.createReport", localVarRequestOptions, this.Configuration, cancellationToken);

#if UNITY_EDITOR || !UNITY_WEBGL
            var localVarResponse = await task.ConfigureAwait(false);
#else
            var localVarResponse = await task;
#endif

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ComAtprotoModerationCreateReport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}