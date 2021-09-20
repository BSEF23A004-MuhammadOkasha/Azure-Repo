// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Core.Experimental.Tests
{
    /// <summary> The PetStore service client. </summary>
    public partial class PetStoreClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://example.azurepetshop.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;
        private Dictionary<string, ResponseClassifier> _responseClassifierCache;

        /// <summary> Initializes a new instance of PetStoreClient for mocking. </summary>
        protected PetStoreClient()
        {
        }

        /// <summary> Initializes a new instance of PetStoreClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public PetStoreClient(Uri endpoint, TokenCredential credential, PetStoreClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PetStoreClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            var authPolicy = new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            this.endpoint = endpoint;
            apiVersion = options.Version;

            _responseClassifierCache = CreateResponseClassifierCache();
        }

        private Dictionary<string, ResponseClassifier> CreateResponseClassifierCache()
        {
            Dictionary<string, ResponseClassifier> cache = new();

            // Add a RequestOptions per method
            cache["GetPet"] = new GetPetResponseClassifier(_clientDiagnostics);

            // Code generator will not generate new classifier types for classifiers
            // with duplicate status code logic, but will reuse previously-generated
            // ones.  It will need to identify duplicates.

            return cache;
        }

        /// <summary> Get a pet by its Id. </summary>
        /// <param name="id"> Id of pet to return. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetPetAsync(string id, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using HttpMessage message = CreateGetPetRequest(id, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PetStoreClient.GetPet");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options?.CancellationToken ?? default).ConfigureAwait(false);
                var statusOption = options?.StatusOption ?? ResponseStatusOption.ThrowOnError;

                if (statusOption == ResponseStatusOption.SuppressExceptions)
                {
                    return message.Response;
                }
                else
                {
                    if (!message.ResponseClassifier.IsErrorResponse(message))
                    {
                        return message.Response;
                    }
                    else
                    {
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a pet by its Id. </summary>
        /// <param name="id"> Id of pet to return. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetPet(string id, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using HttpMessage message = CreateGetPetRequest(id, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PetStoreClient.GetPet");
            scope.Start();
            try
            {
                Pipeline.Send(message, options?.CancellationToken ?? default);
                var statusOption = options?.StatusOption ?? ResponseStatusOption.ThrowOnError;

                if (statusOption == ResponseStatusOption.SuppressExceptions)
                {
                    return message.Response;
                }
                else
                {
                    // This will change to message.Response.IsError in a later PR
                    if (!message.ResponseClassifier.IsErrorResponse(message))
                    {
                        return message.Response;
                    }
                    else
                    {
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetPet"/> and <see cref="GetPetAsync"/> operations. </summary>
        /// <param name="id"> Id of pet to return. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetPetRequest(string id, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/pets/", false);
            uri.AppendPath(id, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            message.ResponseClassifier = _responseClassifierCache["GetPet"];
            return message;
        }

        private class GetPetResponseClassifier : ResponseClassifier
        {
            private ClientDiagnostics _clientDiagnostics;

            public GetPetResponseClassifier(ClientDiagnostics clientDiagnostics)
            {
                _clientDiagnostics = clientDiagnostics;
            }

            public override bool IsErrorResponse(HttpMessage message)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return false;
                    default:
                        return true;
                }
            }
        }
    }
}
