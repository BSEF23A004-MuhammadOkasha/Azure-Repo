// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Automation Client
    /// </summary>
    public partial class AutomationClient : ServiceClient<AutomationClient>, IAutomationClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every service
        /// call.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations.
        /// </summary>
        public virtual IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations.
        /// </summary>
        public virtual IPrivateLinkResourcesOperations PrivateLinkResources { get; private set; }

        /// <summary>
        /// Gets the IPython2PackageOperations.
        /// </summary>
        public virtual IPython2PackageOperations Python2Package { get; private set; }

        /// <summary>
        /// Gets the IAgentRegistrationInformationOperations.
        /// </summary>
        public virtual IAgentRegistrationInformationOperations AgentRegistrationInformation { get; private set; }

        /// <summary>
        /// Gets the IDscNodeOperations.
        /// </summary>
        public virtual IDscNodeOperations DscNode { get; private set; }

        /// <summary>
        /// Gets the INodeReportsOperations.
        /// </summary>
        public virtual INodeReportsOperations NodeReports { get; private set; }

        /// <summary>
        /// Gets the IDscNodeConfigurationOperations.
        /// </summary>
        public virtual IDscNodeConfigurationOperations DscNodeConfiguration { get; private set; }

        /// <summary>
        /// Gets the IDscCompilationJobOperations.
        /// </summary>
        public virtual IDscCompilationJobOperations DscCompilationJob { get; private set; }

        /// <summary>
        /// Gets the IDscCompilationJobStreamOperations.
        /// </summary>
        public virtual IDscCompilationJobStreamOperations DscCompilationJobStream { get; private set; }

        /// <summary>
        /// Gets the INodeCountInformationOperations.
        /// </summary>
        public virtual INodeCountInformationOperations NodeCountInformation { get; private set; }

        /// <summary>
        /// Gets the ISourceControlOperations.
        /// </summary>
        public virtual ISourceControlOperations SourceControl { get; private set; }

        /// <summary>
        /// Gets the ISourceControlSyncJobOperations.
        /// </summary>
        public virtual ISourceControlSyncJobOperations SourceControlSyncJob { get; private set; }

        /// <summary>
        /// Gets the ISourceControlSyncJobStreamsOperations.
        /// </summary>
        public virtual ISourceControlSyncJobStreamsOperations SourceControlSyncJobStreams { get; private set; }

        /// <summary>
        /// Gets the IAutomationAccountOperations.
        /// </summary>
        public virtual IAutomationAccountOperations AutomationAccount { get; private set; }

        /// <summary>
        /// Gets the IStatisticsOperations.
        /// </summary>
        public virtual IStatisticsOperations Statistics { get; private set; }

        /// <summary>
        /// Gets the IUsagesOperations.
        /// </summary>
        public virtual IUsagesOperations Usages { get; private set; }

        /// <summary>
        /// Gets the IKeysOperations.
        /// </summary>
        public virtual IKeysOperations Keys { get; private set; }

        /// <summary>
        /// Gets the ICertificateOperations.
        /// </summary>
        public virtual ICertificateOperations Certificate { get; private set; }

        /// <summary>
        /// Gets the IConnectionOperations.
        /// </summary>
        public virtual IConnectionOperations Connection { get; private set; }

        /// <summary>
        /// Gets the IConnectionTypeOperations.
        /// </summary>
        public virtual IConnectionTypeOperations ConnectionType { get; private set; }

        /// <summary>
        /// Gets the ICredentialOperations.
        /// </summary>
        public virtual ICredentialOperations Credential { get; private set; }

        /// <summary>
        /// Gets the IJobScheduleOperations.
        /// </summary>
        public virtual IJobScheduleOperations JobSchedule { get; private set; }

        /// <summary>
        /// Gets the ILinkedWorkspaceOperations.
        /// </summary>
        public virtual ILinkedWorkspaceOperations LinkedWorkspace { get; private set; }

        /// <summary>
        /// Gets the IActivityOperations.
        /// </summary>
        public virtual IActivityOperations Activity { get; private set; }

        /// <summary>
        /// Gets the IModuleOperations.
        /// </summary>
        public virtual IModuleOperations Module { get; private set; }

        /// <summary>
        /// Gets the IObjectDataTypesOperations.
        /// </summary>
        public virtual IObjectDataTypesOperations ObjectDataTypes { get; private set; }

        /// <summary>
        /// Gets the IFieldsOperations.
        /// </summary>
        public virtual IFieldsOperations Fields { get; private set; }

        /// <summary>
        /// Gets the IScheduleOperations.
        /// </summary>
        public virtual IScheduleOperations Schedule { get; private set; }

        /// <summary>
        /// Gets the IVariableOperations.
        /// </summary>
        public virtual IVariableOperations Variable { get; private set; }

        /// <summary>
        /// Gets the IWatcherOperations.
        /// </summary>
        public virtual IWatcherOperations Watcher { get; private set; }

        /// <summary>
        /// Gets the IDscConfigurationOperations.
        /// </summary>
        public virtual IDscConfigurationOperations DscConfiguration { get; private set; }

        /// <summary>
        /// Gets the IJobOperations.
        /// </summary>
        public virtual IJobOperations Job { get; private set; }

        /// <summary>
        /// Gets the IJobStreamOperations.
        /// </summary>
        public virtual IJobStreamOperations JobStream { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the ISoftwareUpdateConfigurationsOperations.
        /// </summary>
        public virtual ISoftwareUpdateConfigurationsOperations SoftwareUpdateConfigurations { get; private set; }

        /// <summary>
        /// Gets the ISoftwareUpdateConfigurationRunsOperations.
        /// </summary>
        public virtual ISoftwareUpdateConfigurationRunsOperations SoftwareUpdateConfigurationRuns { get; private set; }

        /// <summary>
        /// Gets the ISoftwareUpdateConfigurationMachineRunsOperations.
        /// </summary>
        public virtual ISoftwareUpdateConfigurationMachineRunsOperations SoftwareUpdateConfigurationMachineRuns { get; private set; }

        /// <summary>
        /// Gets the IRunbookDraftOperations.
        /// </summary>
        public virtual IRunbookDraftOperations RunbookDraft { get; private set; }

        /// <summary>
        /// Gets the IRunbookOperations.
        /// </summary>
        public virtual IRunbookOperations Runbook { get; private set; }

        /// <summary>
        /// Gets the ITestJobStreamsOperations.
        /// </summary>
        public virtual ITestJobStreamsOperations TestJobStreams { get; private set; }

        /// <summary>
        /// Gets the ITestJobOperations.
        /// </summary>
        public virtual ITestJobOperations TestJob { get; private set; }

        /// <summary>
        /// Gets the IWebhookOperations.
        /// </summary>
        public virtual IWebhookOperations Webhook { get; private set; }

        /// <summary>
        /// Gets the IHybridRunbookWorkersOperations.
        /// </summary>
        public virtual IHybridRunbookWorkersOperations HybridRunbookWorkers { get; private set; }

        /// <summary>
        /// Gets the IDeletedAutomationAccountsOperations.
        /// </summary>
        public virtual IDeletedAutomationAccountsOperations DeletedAutomationAccounts { get; private set; }

        /// <summary>
        /// Gets the IHybridRunbookWorkerGroupOperations.
        /// </summary>
        public virtual IHybridRunbookWorkerGroupOperations HybridRunbookWorkerGroup { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling AutomationClient.Dispose(). False: will not dispose provided httpClient</param>
        protected AutomationClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected AutomationClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected AutomationClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected AutomationClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected AutomationClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AutomationClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling AutomationClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AutomationClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AutomationClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AutomationClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AutomationClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AutomationClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            PrivateEndpointConnections = new PrivateEndpointConnectionsOperations(this);
            PrivateLinkResources = new PrivateLinkResourcesOperations(this);
            Python2Package = new Python2PackageOperations(this);
            AgentRegistrationInformation = new AgentRegistrationInformationOperations(this);
            DscNode = new DscNodeOperations(this);
            NodeReports = new NodeReportsOperations(this);
            DscNodeConfiguration = new DscNodeConfigurationOperations(this);
            DscCompilationJob = new DscCompilationJobOperations(this);
            DscCompilationJobStream = new DscCompilationJobStreamOperations(this);
            NodeCountInformation = new NodeCountInformationOperations(this);
            SourceControl = new SourceControlOperations(this);
            SourceControlSyncJob = new SourceControlSyncJobOperations(this);
            SourceControlSyncJobStreams = new SourceControlSyncJobStreamsOperations(this);
            AutomationAccount = new AutomationAccountOperations(this);
            Statistics = new StatisticsOperations(this);
            Usages = new UsagesOperations(this);
            Keys = new KeysOperations(this);
            Certificate = new CertificateOperations(this);
            Connection = new ConnectionOperations(this);
            ConnectionType = new ConnectionTypeOperations(this);
            Credential = new CredentialOperations(this);
            JobSchedule = new JobScheduleOperations(this);
            LinkedWorkspace = new LinkedWorkspaceOperations(this);
            Activity = new ActivityOperations(this);
            Module = new ModuleOperations(this);
            ObjectDataTypes = new ObjectDataTypesOperations(this);
            Fields = new FieldsOperations(this);
            Schedule = new ScheduleOperations(this);
            Variable = new VariableOperations(this);
            Watcher = new WatcherOperations(this);
            DscConfiguration = new DscConfigurationOperations(this);
            Job = new JobOperations(this);
            JobStream = new JobStreamOperations(this);
            Operations = new Operations(this);
            SoftwareUpdateConfigurations = new SoftwareUpdateConfigurationsOperations(this);
            SoftwareUpdateConfigurationRuns = new SoftwareUpdateConfigurationRunsOperations(this);
            SoftwareUpdateConfigurationMachineRuns = new SoftwareUpdateConfigurationMachineRunsOperations(this);
            RunbookDraft = new RunbookDraftOperations(this);
            Runbook = new RunbookOperations(this);
            TestJobStreams = new TestJobStreamsOperations(this);
            TestJob = new TestJobOperations(this);
            Webhook = new WebhookOperations(this);
            HybridRunbookWorkers = new HybridRunbookWorkersOperations(this);
            DeletedAutomationAccounts = new DeletedAutomationAccountsOperations(this);
            HybridRunbookWorkerGroup = new HybridRunbookWorkerGroupOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
        /// <summary>
        /// Post operation to serialize or deserialize GraphRunbookContent
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='parameters'>
        /// Input data describing the graphical runbook.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse<GraphicalRunbookContent>> ConvertGraphRunbookContentWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, GraphicalRunbookContent parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (resourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "resourceGroupName");
            }
            if (resourceGroupName != null)
            {
                if (resourceGroupName.Length > 90)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "resourceGroupName", 90);
                }
                if (resourceGroupName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "resourceGroupName", 1);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(resourceGroupName, "^[-\\w\\._]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "resourceGroupName", "^[-\\w\\._]+$");
                }
            }
            if (automationAccountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "automationAccountName");
            }
            if (SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.SubscriptionId");
            }
            if (parameters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "parameters");
            }
            string apiVersion = "2021-06-22";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("automationAccountName", automationAccountName);
                tracingParameters.Add("apiVersion", apiVersion);
                tracingParameters.Add("parameters", parameters);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "ConvertGraphRunbookContent", tracingParameters);
            }
            // Construct URL
            var _baseUrl = BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/convertGraphRunbookContent").ToString();
            _url = _url.Replace("{resourceGroupName}", System.Uri.EscapeDataString(resourceGroupName));
            _url = _url.Replace("{automationAccountName}", System.Uri.EscapeDataString(automationAccountName));
            _url = _url.Replace("{subscriptionId}", System.Uri.EscapeDataString(SubscriptionId));
            List<string> _queryParameters = new List<string>();
            if (apiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", System.Uri.EscapeDataString(apiVersion)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (GenerateClientRequestId != null && GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", AcceptLanguage);
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            if(parameters != null)
            {
                _requestContent = SafeJsonConvert.SerializeObject(parameters, SerializationSettings);
                _httpRequest.Content = new StringContent(_requestContent, System.Text.Encoding.UTF8);
                _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            }
            // Set Credentials
            if (Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            System.Net.HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new ErrorResponseException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    ErrorResponse _errorBody =  SafeJsonConvert.DeserializeObject<ErrorResponse>(_responseContent, DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new AzureOperationResponse<GraphicalRunbookContent>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<GraphicalRunbookContent>(_responseContent, DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
