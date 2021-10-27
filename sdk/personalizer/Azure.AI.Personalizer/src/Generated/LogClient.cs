// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Personalizer
{
    /// <summary> The Log service client. </summary>
    internal partial class LogClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal LogRestClient RestClient { get; }

        /// <summary> Initializes a new instance of LogClient for mocking. </summary>
        protected LogClient()
        {
        }

        /// <summary> Initializes a new instance of LogClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public LogClient(string endpoint, TokenCredential credential, PersonalizerClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PersonalizerClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://cognitiveservices.azure.com/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new LogRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of LogClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public LogClient(string endpoint, AzureKeyCredential credential, PersonalizerClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PersonalizerClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, "Ocp-Apim-Subscription-Key"));
            RestClient = new LogRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of LogClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        internal LogClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint)
        {
            RestClient = new LogRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Delete all logs of Rank and Reward calls stored by Personalizer. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LogClient.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete all logs of Rank and Reward calls stored by Personalizer. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LogClient.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get properties of the Personalizer logs. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PersonalizerLogProperties>> GetPropertiesAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LogClient.GetProperties");
            scope.Start();
            try
            {
                return await RestClient.GetPropertiesAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get properties of the Personalizer logs. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PersonalizerLogProperties> GetProperties(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LogClient.GetProperties");
            scope.Start();
            try
            {
                return RestClient.GetProperties(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
