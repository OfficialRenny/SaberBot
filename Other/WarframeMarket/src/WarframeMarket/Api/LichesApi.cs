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
    public interface ILichesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a list of lich ephemeras.
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>LichEphemerasGet200Response</returns>
        LichEphemerasGet200Response LichEphemerasGet(string? language = default(string?), int operationIndex = 0);

        /// <summary>
        /// Get a list of lich ephemeras.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of LichEphemerasGet200Response</returns>
        ApiResponse<LichEphemerasGet200Response> LichEphemerasGetWithHttpInfo(string? language = default(string?), int operationIndex = 0);
        /// <summary>
        /// Get a list of lich quirks.
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>LichQuirksGet200Response</returns>
        LichQuirksGet200Response LichQuirksGet(string? language = default(string?), int operationIndex = 0);

        /// <summary>
        /// Get a list of lich quirks.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of LichQuirksGet200Response</returns>
        ApiResponse<LichQuirksGet200Response> LichQuirksGetWithHttpInfo(string? language = default(string?), int operationIndex = 0);
        /// <summary>
        /// Get a list of lich weapons.
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>LichWeaponsGet200Response</returns>
        LichWeaponsGet200Response LichWeaponsGet(string? language = default(string?), int operationIndex = 0);

        /// <summary>
        /// Get a list of lich weapons.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of LichWeaponsGet200Response</returns>
        ApiResponse<LichWeaponsGet200Response> LichWeaponsGetWithHttpInfo(string? language = default(string?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILichesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get a list of lich ephemeras.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LichEphemerasGet200Response</returns>
        System.Threading.Tasks.Task<LichEphemerasGet200Response> LichEphemerasGetAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a list of lich ephemeras.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LichEphemerasGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<LichEphemerasGet200Response>> LichEphemerasGetWithHttpInfoAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a list of lich quirks.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LichQuirksGet200Response</returns>
        System.Threading.Tasks.Task<LichQuirksGet200Response> LichQuirksGetAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a list of lich quirks.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LichQuirksGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<LichQuirksGet200Response>> LichQuirksGetWithHttpInfoAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a list of lich weapons.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LichWeaponsGet200Response</returns>
        System.Threading.Tasks.Task<LichWeaponsGet200Response> LichWeaponsGetAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a list of lich weapons.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LichWeaponsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<LichWeaponsGet200Response>> LichWeaponsGetWithHttpInfoAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILichesApi : ILichesApiSync, ILichesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LichesApi : ILichesApi
    {
        private WarframeMarket.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LichesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LichesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LichesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LichesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="LichesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LichesApi(WarframeMarket.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="LichesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LichesApi(WarframeMarket.Client.ISynchronousClient client, WarframeMarket.Client.IAsynchronousClient asyncClient, WarframeMarket.Client.IReadableConfiguration configuration)
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
        /// Get a list of lich ephemeras. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>LichEphemerasGet200Response</returns>
        public LichEphemerasGet200Response LichEphemerasGet(string? language = default(string?), int operationIndex = 0)
        {
            WarframeMarket.Client.ApiResponse<LichEphemerasGet200Response> localVarResponse = LichEphemerasGetWithHttpInfo(language);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of lich ephemeras. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of LichEphemerasGet200Response</returns>
        public WarframeMarket.Client.ApiResponse<LichEphemerasGet200Response> LichEphemerasGetWithHttpInfo(string? language = default(string?), int operationIndex = 0)
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

            localVarRequestOptions.Operation = "LichesApi.LichEphemerasGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<LichEphemerasGet200Response>("/lich/ephemeras", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LichEphemerasGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of lich ephemeras. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LichEphemerasGet200Response</returns>
        public async System.Threading.Tasks.Task<LichEphemerasGet200Response> LichEphemerasGetAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            WarframeMarket.Client.ApiResponse<LichEphemerasGet200Response> localVarResponse = await LichEphemerasGetWithHttpInfoAsync(language, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of lich ephemeras. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LichEphemerasGet200Response)</returns>
        public async System.Threading.Tasks.Task<WarframeMarket.Client.ApiResponse<LichEphemerasGet200Response>> LichEphemerasGetWithHttpInfoAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Operation = "LichesApi.LichEphemerasGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<LichEphemerasGet200Response>("/lich/ephemeras", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LichEphemerasGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of lich quirks. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>LichQuirksGet200Response</returns>
        public LichQuirksGet200Response LichQuirksGet(string? language = default(string?), int operationIndex = 0)
        {
            WarframeMarket.Client.ApiResponse<LichQuirksGet200Response> localVarResponse = LichQuirksGetWithHttpInfo(language);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of lich quirks. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of LichQuirksGet200Response</returns>
        public WarframeMarket.Client.ApiResponse<LichQuirksGet200Response> LichQuirksGetWithHttpInfo(string? language = default(string?), int operationIndex = 0)
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

            localVarRequestOptions.Operation = "LichesApi.LichQuirksGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<LichQuirksGet200Response>("/lich/quirks", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LichQuirksGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of lich quirks. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LichQuirksGet200Response</returns>
        public async System.Threading.Tasks.Task<LichQuirksGet200Response> LichQuirksGetAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            WarframeMarket.Client.ApiResponse<LichQuirksGet200Response> localVarResponse = await LichQuirksGetWithHttpInfoAsync(language, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of lich quirks. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LichQuirksGet200Response)</returns>
        public async System.Threading.Tasks.Task<WarframeMarket.Client.ApiResponse<LichQuirksGet200Response>> LichQuirksGetWithHttpInfoAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Operation = "LichesApi.LichQuirksGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<LichQuirksGet200Response>("/lich/quirks", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LichQuirksGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of lich weapons. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>LichWeaponsGet200Response</returns>
        public LichWeaponsGet200Response LichWeaponsGet(string? language = default(string?), int operationIndex = 0)
        {
            WarframeMarket.Client.ApiResponse<LichWeaponsGet200Response> localVarResponse = LichWeaponsGetWithHttpInfo(language);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of lich weapons. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of LichWeaponsGet200Response</returns>
        public WarframeMarket.Client.ApiResponse<LichWeaponsGet200Response> LichWeaponsGetWithHttpInfo(string? language = default(string?), int operationIndex = 0)
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

            localVarRequestOptions.Operation = "LichesApi.LichWeaponsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<LichWeaponsGet200Response>("/lich/weapons", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LichWeaponsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of lich weapons. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LichWeaponsGet200Response</returns>
        public async System.Threading.Tasks.Task<LichWeaponsGet200Response> LichWeaponsGetAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            WarframeMarket.Client.ApiResponse<LichWeaponsGet200Response> localVarResponse = await LichWeaponsGetWithHttpInfoAsync(language, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of lich weapons. 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Asks the server to return content translated into the specified language, default: &#x60;en&#x60;.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LichWeaponsGet200Response)</returns>
        public async System.Threading.Tasks.Task<WarframeMarket.Client.ApiResponse<LichWeaponsGet200Response>> LichWeaponsGetWithHttpInfoAsync(string? language = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Operation = "LichesApi.LichWeaponsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<LichWeaponsGet200Response>("/lich/weapons", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LichWeaponsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}