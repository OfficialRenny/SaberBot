/*
 * Warframe.market API
 *
 * ## Documentation is under very slow and heavy development  This document will gradually be supplemented and updated over some extended period of time.  ## Unstable endpoints Endpoint that is not stable and probably will be changed in the future will be marked with exclamation sign -> ⚠ 
 *
 * The version of the OpenAPI document: 1.14.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using WarframeMarket.Client;
using WarframeMarket.Model;

namespace WarframeMarket.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRivensApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a list of riven attributes.
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RivenAttributesGet200Response</returns>
        RivenAttributesGet200Response RivenAttributesGet(string? language = default(string?), int operationIndex = 0);

        /// <summary>
        /// Get a list of riven attributes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RivenAttributesGet200Response</returns>
        ApiResponse<RivenAttributesGet200Response> RivenAttributesGetWithHttpInfo(string? language = default(string?), int operationIndex = 0);
        /// <summary>
        /// Get a list of riven items.
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RivenItemsGet200Response</returns>
        RivenItemsGet200Response RivenItemsGet(string? language = default(string?), int operationIndex = 0);

        /// <summary>
        /// Get a list of riven items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RivenItemsGet200Response</returns>
        ApiResponse<RivenItemsGet200Response> RivenItemsGetWithHttpInfo(string? language = default(string?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRivensApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get a list of riven attributes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RivenAttributesGet200Response</returns>
        System.Threading.Tasks.Task<RivenAttributesGet200Response> RivenAttributesGetAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a list of riven attributes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RivenAttributesGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<RivenAttributesGet200Response>> RivenAttributesGetWithHttpInfoAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a list of riven items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RivenItemsGet200Response</returns>
        System.Threading.Tasks.Task<RivenItemsGet200Response> RivenItemsGetAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a list of riven items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RivenItemsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<RivenItemsGet200Response>> RivenItemsGetWithHttpInfoAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRivensApi : IRivensApiSync, IRivensApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RivensApi : IRivensApi
    {
        private WarframeMarket.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RivensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RivensApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RivensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RivensApi(string basePath)
        {
            this.Configuration = WarframeMarket.Client.Configuration.MergeConfigurations(
                WarframeMarket.Client.GlobalConfiguration.Instance,
                new WarframeMarket.Client.Configuration { BasePath = basePath }
            );
            this.Client = new WarframeMarket.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new WarframeMarket.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = WarframeMarket.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RivensApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RivensApi(WarframeMarket.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = WarframeMarket.Client.Configuration.MergeConfigurations(
                WarframeMarket.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new WarframeMarket.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new WarframeMarket.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = WarframeMarket.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RivensApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public RivensApi(WarframeMarket.Client.ISynchronousClient client, WarframeMarket.Client.IAsynchronousClient asyncClient, WarframeMarket.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = WarframeMarket.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public WarframeMarket.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public WarframeMarket.Client.ISynchronousClient Client { get; set; }

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
        public WarframeMarket.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public WarframeMarket.Client.ExceptionFactory ExceptionFactory
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
        /// Get a list of riven attributes. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RivenAttributesGet200Response</returns>
        public RivenAttributesGet200Response RivenAttributesGet(string? language = default(string?), int operationIndex = 0)
        {
            WarframeMarket.Client.ApiResponse<RivenAttributesGet200Response> localVarResponse = RivenAttributesGetWithHttpInfo(language);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of riven attributes. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RivenAttributesGet200Response</returns>
        public WarframeMarket.Client.ApiResponse<RivenAttributesGet200Response> RivenAttributesGetWithHttpInfo(string? language = default(string?), int operationIndex = 0)
        {
            WarframeMarket.Client.RequestOptions localVarRequestOptions = new WarframeMarket.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = WarframeMarket.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = WarframeMarket.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (language != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Language", WarframeMarket.Client.ClientUtils.ParameterToString(language)); // header parameter
            }

            localVarRequestOptions.Operation = "RivensApi.RivenAttributesGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<RivenAttributesGet200Response>("/riven/attributes", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RivenAttributesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of riven attributes. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RivenAttributesGet200Response</returns>
        public async System.Threading.Tasks.Task<RivenAttributesGet200Response> RivenAttributesGetAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            WarframeMarket.Client.ApiResponse<RivenAttributesGet200Response> localVarResponse = await RivenAttributesGetWithHttpInfoAsync(language, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of riven attributes. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RivenAttributesGet200Response)</returns>
        public async System.Threading.Tasks.Task<WarframeMarket.Client.ApiResponse<RivenAttributesGet200Response>> RivenAttributesGetWithHttpInfoAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            WarframeMarket.Client.RequestOptions localVarRequestOptions = new WarframeMarket.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = WarframeMarket.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = WarframeMarket.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (language != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Language", WarframeMarket.Client.ClientUtils.ParameterToString(language)); // header parameter
            }

            localVarRequestOptions.Operation = "RivensApi.RivenAttributesGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<RivenAttributesGet200Response>("/riven/attributes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RivenAttributesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of riven items. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RivenItemsGet200Response</returns>
        public RivenItemsGet200Response RivenItemsGet(string? language = default(string?), int operationIndex = 0)
        {
            WarframeMarket.Client.ApiResponse<RivenItemsGet200Response> localVarResponse = RivenItemsGetWithHttpInfo(language);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of riven items. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RivenItemsGet200Response</returns>
        public WarframeMarket.Client.ApiResponse<RivenItemsGet200Response> RivenItemsGetWithHttpInfo(string? language = default(string?), int operationIndex = 0)
        {
            WarframeMarket.Client.RequestOptions localVarRequestOptions = new WarframeMarket.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = WarframeMarket.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = WarframeMarket.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (language != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Language", WarframeMarket.Client.ClientUtils.ParameterToString(language)); // header parameter
            }

            localVarRequestOptions.Operation = "RivensApi.RivenItemsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<RivenItemsGet200Response>("/riven/items", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RivenItemsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of riven items. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RivenItemsGet200Response</returns>
        public async System.Threading.Tasks.Task<RivenItemsGet200Response> RivenItemsGetAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            WarframeMarket.Client.ApiResponse<RivenItemsGet200Response> localVarResponse = await RivenItemsGetWithHttpInfoAsync(language, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of riven items. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RivenItemsGet200Response)</returns>
        public async System.Threading.Tasks.Task<WarframeMarket.Client.ApiResponse<RivenItemsGet200Response>> RivenItemsGetWithHttpInfoAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            WarframeMarket.Client.RequestOptions localVarRequestOptions = new WarframeMarket.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = WarframeMarket.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = WarframeMarket.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (language != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Language", WarframeMarket.Client.ClientUtils.ParameterToString(language)); // header parameter
            }

            localVarRequestOptions.Operation = "RivensApi.RivenItemsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<RivenItemsGet200Response>("/riven/items", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RivenItemsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}