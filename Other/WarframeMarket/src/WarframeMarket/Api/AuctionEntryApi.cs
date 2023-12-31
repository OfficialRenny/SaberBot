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
    public interface IAuctionEntryApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets auction bids by auction Id
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="include">Include additional information.   Will add a new response section with all information about requested model.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AuctionsEntryAuctionIdBidsGet200Response</returns>
        AuctionsEntryAuctionIdBidsGet200Response AuctionsEntryAuctionIdBidsGet(string auctionId, string? include = default(string?), int operationIndex = 0);

        /// <summary>
        /// Gets auction bids by auction Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="include">Include additional information.   Will add a new response section with all information about requested model.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AuctionsEntryAuctionIdBidsGet200Response</returns>
        ApiResponse<AuctionsEntryAuctionIdBidsGet200Response> AuctionsEntryAuctionIdBidsGetWithHttpInfo(string auctionId, string? include = default(string?), int operationIndex = 0);
        /// <summary>
        /// Gets information about auction by auction Id
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AuctionsEntryAuctionIdGet200Response</returns>
        AuctionsEntryAuctionIdGet200Response AuctionsEntryAuctionIdGet(string auctionId, int operationIndex = 0);

        /// <summary>
        /// Gets information about auction by auction Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AuctionsEntryAuctionIdGet200Response</returns>
        ApiResponse<AuctionsEntryAuctionIdGet200Response> AuctionsEntryAuctionIdGetWithHttpInfo(string auctionId, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuctionEntryApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Gets auction bids by auction Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="include">Include additional information.   Will add a new response section with all information about requested model.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuctionsEntryAuctionIdBidsGet200Response</returns>
        System.Threading.Tasks.Task<AuctionsEntryAuctionIdBidsGet200Response> AuctionsEntryAuctionIdBidsGetAsync(string auctionId, string? include = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets auction bids by auction Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="include">Include additional information.   Will add a new response section with all information about requested model.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuctionsEntryAuctionIdBidsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuctionsEntryAuctionIdBidsGet200Response>> AuctionsEntryAuctionIdBidsGetWithHttpInfoAsync(string auctionId, string? include = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets information about auction by auction Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuctionsEntryAuctionIdGet200Response</returns>
        System.Threading.Tasks.Task<AuctionsEntryAuctionIdGet200Response> AuctionsEntryAuctionIdGetAsync(string auctionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets information about auction by auction Id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuctionsEntryAuctionIdGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuctionsEntryAuctionIdGet200Response>> AuctionsEntryAuctionIdGetWithHttpInfoAsync(string auctionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuctionEntryApi : IAuctionEntryApiSync, IAuctionEntryApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuctionEntryApi : IAuctionEntryApi
    {
        private WarframeMarket.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionEntryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuctionEntryApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionEntryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuctionEntryApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AuctionEntryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuctionEntryApi(WarframeMarket.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AuctionEntryApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuctionEntryApi(WarframeMarket.Client.ISynchronousClient client, WarframeMarket.Client.IAsynchronousClient asyncClient, WarframeMarket.Client.IReadableConfiguration configuration)
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
        /// Gets auction bids by auction Id 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="include">Include additional information.   Will add a new response section with all information about requested model.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AuctionsEntryAuctionIdBidsGet200Response</returns>
        public AuctionsEntryAuctionIdBidsGet200Response AuctionsEntryAuctionIdBidsGet(string auctionId, string? include = default(string?), int operationIndex = 0)
        {
            WarframeMarket.Client.ApiResponse<AuctionsEntryAuctionIdBidsGet200Response> localVarResponse = AuctionsEntryAuctionIdBidsGetWithHttpInfo(auctionId, include);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets auction bids by auction Id 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="include">Include additional information.   Will add a new response section with all information about requested model.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AuctionsEntryAuctionIdBidsGet200Response</returns>
        public WarframeMarket.Client.ApiResponse<AuctionsEntryAuctionIdBidsGet200Response> AuctionsEntryAuctionIdBidsGetWithHttpInfo(string auctionId, string? include = default(string?), int operationIndex = 0)
        {
            // verify the required parameter 'auctionId' is set
            if (auctionId == null)
            {
                throw new WarframeMarket.Client.ApiException(400, "Missing required parameter 'auctionId' when calling AuctionEntryApi->AuctionsEntryAuctionIdBidsGet");
            }

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

            localVarRequestOptions.PathParameters.Add("auction_id", WarframeMarket.Client.ClientUtils.ParameterToString(auctionId)); // path parameter
            if (include != null)
            {
                localVarRequestOptions.QueryParameters.Add(WarframeMarket.Client.ClientUtils.ParameterToMultiMap("", "include", include));
            }

            localVarRequestOptions.Operation = "AuctionEntryApi.AuctionsEntryAuctionIdBidsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<AuctionsEntryAuctionIdBidsGet200Response>("/auctions/entry/{auction_id}/bids", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AuctionsEntryAuctionIdBidsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets auction bids by auction Id 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="include">Include additional information.   Will add a new response section with all information about requested model.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuctionsEntryAuctionIdBidsGet200Response</returns>
        public async System.Threading.Tasks.Task<AuctionsEntryAuctionIdBidsGet200Response> AuctionsEntryAuctionIdBidsGetAsync(string auctionId, string? include = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            WarframeMarket.Client.ApiResponse<AuctionsEntryAuctionIdBidsGet200Response> localVarResponse = await AuctionsEntryAuctionIdBidsGetWithHttpInfoAsync(auctionId, include, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets auction bids by auction Id 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="include">Include additional information.   Will add a new response section with all information about requested model.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuctionsEntryAuctionIdBidsGet200Response)</returns>
        public async System.Threading.Tasks.Task<WarframeMarket.Client.ApiResponse<AuctionsEntryAuctionIdBidsGet200Response>> AuctionsEntryAuctionIdBidsGetWithHttpInfoAsync(string auctionId, string? include = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'auctionId' is set
            if (auctionId == null)
            {
                throw new WarframeMarket.Client.ApiException(400, "Missing required parameter 'auctionId' when calling AuctionEntryApi->AuctionsEntryAuctionIdBidsGet");
            }


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

            localVarRequestOptions.PathParameters.Add("auction_id", WarframeMarket.Client.ClientUtils.ParameterToString(auctionId)); // path parameter
            if (include != null)
            {
                localVarRequestOptions.QueryParameters.Add(WarframeMarket.Client.ClientUtils.ParameterToMultiMap("", "include", include));
            }

            localVarRequestOptions.Operation = "AuctionEntryApi.AuctionsEntryAuctionIdBidsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AuctionsEntryAuctionIdBidsGet200Response>("/auctions/entry/{auction_id}/bids", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AuctionsEntryAuctionIdBidsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets information about auction by auction Id 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AuctionsEntryAuctionIdGet200Response</returns>
        public AuctionsEntryAuctionIdGet200Response AuctionsEntryAuctionIdGet(string auctionId, int operationIndex = 0)
        {
            WarframeMarket.Client.ApiResponse<AuctionsEntryAuctionIdGet200Response> localVarResponse = AuctionsEntryAuctionIdGetWithHttpInfo(auctionId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets information about auction by auction Id 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AuctionsEntryAuctionIdGet200Response</returns>
        public WarframeMarket.Client.ApiResponse<AuctionsEntryAuctionIdGet200Response> AuctionsEntryAuctionIdGetWithHttpInfo(string auctionId, int operationIndex = 0)
        {
            // verify the required parameter 'auctionId' is set
            if (auctionId == null)
            {
                throw new WarframeMarket.Client.ApiException(400, "Missing required parameter 'auctionId' when calling AuctionEntryApi->AuctionsEntryAuctionIdGet");
            }

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

            localVarRequestOptions.PathParameters.Add("auction_id", WarframeMarket.Client.ClientUtils.ParameterToString(auctionId)); // path parameter

            localVarRequestOptions.Operation = "AuctionEntryApi.AuctionsEntryAuctionIdGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<AuctionsEntryAuctionIdGet200Response>("/auctions/entry/{auction_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AuctionsEntryAuctionIdGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets information about auction by auction Id 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuctionsEntryAuctionIdGet200Response</returns>
        public async System.Threading.Tasks.Task<AuctionsEntryAuctionIdGet200Response> AuctionsEntryAuctionIdGetAsync(string auctionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            WarframeMarket.Client.ApiResponse<AuctionsEntryAuctionIdGet200Response> localVarResponse = await AuctionsEntryAuctionIdGetWithHttpInfoAsync(auctionId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets information about auction by auction Id 
        /// </summary>
        /// <exception cref="WarframeMarket.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="auctionId">ObjectId of auction</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuctionsEntryAuctionIdGet200Response)</returns>
        public async System.Threading.Tasks.Task<WarframeMarket.Client.ApiResponse<AuctionsEntryAuctionIdGet200Response>> AuctionsEntryAuctionIdGetWithHttpInfoAsync(string auctionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'auctionId' is set
            if (auctionId == null)
            {
                throw new WarframeMarket.Client.ApiException(400, "Missing required parameter 'auctionId' when calling AuctionEntryApi->AuctionsEntryAuctionIdGet");
            }


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

            localVarRequestOptions.PathParameters.Add("auction_id", WarframeMarket.Client.ClientUtils.ParameterToString(auctionId)); // path parameter

            localVarRequestOptions.Operation = "AuctionEntryApi.AuctionsEntryAuctionIdGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AuctionsEntryAuctionIdGet200Response>("/auctions/entry/{auction_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AuctionsEntryAuctionIdGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
