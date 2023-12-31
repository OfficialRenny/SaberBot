/*
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.18.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Destiny.Client;
using Destiny.Client.Auth;
using Destiny.Model;

namespace Destiny.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAppApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get API usage by application for time frame specified. You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.
        /// </remarks>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId">ID of the application to get usage statistics.</param>
        /// <param name="end">End time for query. Goes to now if not specified. (optional)</param>
        /// <param name="start">Start time for query. Goes to 24 hours ago if not specified. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AppGetApplicationApiUsage200Response</returns>
        AppGetApplicationApiUsage200Response AppGetApplicationApiUsage(int applicationId, DateTime? end = default(DateTime?), DateTime? start = default(DateTime?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get API usage by application for time frame specified. You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.
        /// </remarks>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId">ID of the application to get usage statistics.</param>
        /// <param name="end">End time for query. Goes to now if not specified. (optional)</param>
        /// <param name="start">Start time for query. Goes to 24 hours ago if not specified. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AppGetApplicationApiUsage200Response</returns>
        ApiResponse<AppGetApplicationApiUsage200Response> AppGetApplicationApiUsageWithHttpInfo(int applicationId, DateTime? end = default(DateTime?), DateTime? start = default(DateTime?), int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of applications created by Bungie.
        /// </remarks>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AppGetBungieApplications200Response</returns>
        AppGetBungieApplications200Response AppGetBungieApplications(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of applications created by Bungie.
        /// </remarks>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AppGetBungieApplications200Response</returns>
        ApiResponse<AppGetBungieApplications200Response> AppGetBungieApplicationsWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAppApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get API usage by application for time frame specified. You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.
        /// </remarks>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId">ID of the application to get usage statistics.</param>
        /// <param name="end">End time for query. Goes to now if not specified. (optional)</param>
        /// <param name="start">Start time for query. Goes to 24 hours ago if not specified. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AppGetApplicationApiUsage200Response</returns>
        System.Threading.Tasks.Task<AppGetApplicationApiUsage200Response> AppGetApplicationApiUsageAsync(int applicationId, DateTime? end = default(DateTime?), DateTime? start = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get API usage by application for time frame specified. You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.
        /// </remarks>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId">ID of the application to get usage statistics.</param>
        /// <param name="end">End time for query. Goes to now if not specified. (optional)</param>
        /// <param name="start">Start time for query. Goes to 24 hours ago if not specified. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AppGetApplicationApiUsage200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AppGetApplicationApiUsage200Response>> AppGetApplicationApiUsageWithHttpInfoAsync(int applicationId, DateTime? end = default(DateTime?), DateTime? start = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of applications created by Bungie.
        /// </remarks>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AppGetBungieApplications200Response</returns>
        System.Threading.Tasks.Task<AppGetBungieApplications200Response> AppGetBungieApplicationsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of applications created by Bungie.
        /// </remarks>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AppGetBungieApplications200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AppGetBungieApplications200Response>> AppGetBungieApplicationsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAppApi : IAppApiSync, IAppApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AppApi : IAppApi
    {
        private Destiny.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AppApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AppApi(string basePath)
        {
            this.Configuration = Destiny.Client.Configuration.MergeConfigurations(
                Destiny.Client.GlobalConfiguration.Instance,
                new Destiny.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Destiny.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Destiny.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Destiny.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AppApi(Destiny.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Destiny.Client.Configuration.MergeConfigurations(
                Destiny.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Destiny.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Destiny.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Destiny.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AppApi(Destiny.Client.ISynchronousClient client, Destiny.Client.IAsynchronousClient asyncClient, Destiny.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Destiny.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Destiny.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Destiny.Client.ISynchronousClient Client { get; set; }

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
        public Destiny.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Destiny.Client.ExceptionFactory ExceptionFactory
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
        ///  Get API usage by application for time frame specified. You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.
        /// </summary>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId">ID of the application to get usage statistics.</param>
        /// <param name="end">End time for query. Goes to now if not specified. (optional)</param>
        /// <param name="start">Start time for query. Goes to 24 hours ago if not specified. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AppGetApplicationApiUsage200Response</returns>
        public AppGetApplicationApiUsage200Response AppGetApplicationApiUsage(int applicationId, DateTime? end = default(DateTime?), DateTime? start = default(DateTime?), int operationIndex = 0)
        {
            Destiny.Client.ApiResponse<AppGetApplicationApiUsage200Response> localVarResponse = AppGetApplicationApiUsageWithHttpInfo(applicationId, end, start);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get API usage by application for time frame specified. You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.
        /// </summary>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId">ID of the application to get usage statistics.</param>
        /// <param name="end">End time for query. Goes to now if not specified. (optional)</param>
        /// <param name="start">Start time for query. Goes to 24 hours ago if not specified. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AppGetApplicationApiUsage200Response</returns>
        public Destiny.Client.ApiResponse<AppGetApplicationApiUsage200Response> AppGetApplicationApiUsageWithHttpInfo(int applicationId, DateTime? end = default(DateTime?), DateTime? start = default(DateTime?), int operationIndex = 0)
        {
            Destiny.Client.RequestOptions localVarRequestOptions = new Destiny.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Destiny.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Destiny.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("applicationId", Destiny.Client.ClientUtils.ParameterToString(applicationId)); // path parameter
            if (end != null)
            {
                localVarRequestOptions.QueryParameters.Add(Destiny.Client.ClientUtils.ParameterToMultiMap("", "end", end));
            }
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(Destiny.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            }

            localVarRequestOptions.Operation = "AppApi.AppGetApplicationApiUsage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AppGetApplicationApiUsage200Response>("/App/ApiUsage/{applicationId}/", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AppGetApplicationApiUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Get API usage by application for time frame specified. You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.
        /// </summary>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId">ID of the application to get usage statistics.</param>
        /// <param name="end">End time for query. Goes to now if not specified. (optional)</param>
        /// <param name="start">Start time for query. Goes to 24 hours ago if not specified. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AppGetApplicationApiUsage200Response</returns>
        public async System.Threading.Tasks.Task<AppGetApplicationApiUsage200Response> AppGetApplicationApiUsageAsync(int applicationId, DateTime? end = default(DateTime?), DateTime? start = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Destiny.Client.ApiResponse<AppGetApplicationApiUsage200Response> localVarResponse = await AppGetApplicationApiUsageWithHttpInfoAsync(applicationId, end, start, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get API usage by application for time frame specified. You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.
        /// </summary>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId">ID of the application to get usage statistics.</param>
        /// <param name="end">End time for query. Goes to now if not specified. (optional)</param>
        /// <param name="start">Start time for query. Goes to 24 hours ago if not specified. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AppGetApplicationApiUsage200Response)</returns>
        public async System.Threading.Tasks.Task<Destiny.Client.ApiResponse<AppGetApplicationApiUsage200Response>> AppGetApplicationApiUsageWithHttpInfoAsync(int applicationId, DateTime? end = default(DateTime?), DateTime? start = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Destiny.Client.RequestOptions localVarRequestOptions = new Destiny.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Destiny.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Destiny.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("applicationId", Destiny.Client.ClientUtils.ParameterToString(applicationId)); // path parameter
            if (end != null)
            {
                localVarRequestOptions.QueryParameters.Add(Destiny.Client.ClientUtils.ParameterToMultiMap("", "end", end));
            }
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(Destiny.Client.ClientUtils.ParameterToMultiMap("", "start", start));
            }

            localVarRequestOptions.Operation = "AppApi.AppGetApplicationApiUsage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AppGetApplicationApiUsage200Response>("/App/ApiUsage/{applicationId}/", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AppGetApplicationApiUsage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Get list of applications created by Bungie.
        /// </summary>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AppGetBungieApplications200Response</returns>
        public AppGetBungieApplications200Response AppGetBungieApplications(int operationIndex = 0)
        {
            Destiny.Client.ApiResponse<AppGetBungieApplications200Response> localVarResponse = AppGetBungieApplicationsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get list of applications created by Bungie.
        /// </summary>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AppGetBungieApplications200Response</returns>
        public Destiny.Client.ApiResponse<AppGetBungieApplications200Response> AppGetBungieApplicationsWithHttpInfo(int operationIndex = 0)
        {
            Destiny.Client.RequestOptions localVarRequestOptions = new Destiny.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Destiny.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Destiny.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "AppApi.AppGetBungieApplications";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<AppGetBungieApplications200Response>("/App/FirstParty/", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AppGetBungieApplications", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Get list of applications created by Bungie.
        /// </summary>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AppGetBungieApplications200Response</returns>
        public async System.Threading.Tasks.Task<AppGetBungieApplications200Response> AppGetBungieApplicationsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Destiny.Client.ApiResponse<AppGetBungieApplications200Response> localVarResponse = await AppGetBungieApplicationsWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get list of applications created by Bungie.
        /// </summary>
        /// <exception cref="Destiny.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AppGetBungieApplications200Response)</returns>
        public async System.Threading.Tasks.Task<Destiny.Client.ApiResponse<AppGetBungieApplications200Response>> AppGetBungieApplicationsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Destiny.Client.RequestOptions localVarRequestOptions = new Destiny.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Destiny.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Destiny.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "AppApi.AppGetBungieApplications";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AppGetBungieApplications200Response>("/App/FirstParty/", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AppGetBungieApplications", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
