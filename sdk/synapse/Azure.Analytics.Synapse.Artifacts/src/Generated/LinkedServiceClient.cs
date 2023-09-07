// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The LinkedService service client. </summary>
    public partial class LinkedServiceClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal LinkedServiceRestClient RestClient { get; }

        /// <summary> Initializes a new instance of LinkedServiceClient for mocking. </summary>
        protected LinkedServiceClient()
        {
        }

        /// <summary> Initializes a new instance of LinkedServiceClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public LinkedServiceClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new LinkedServiceRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of LinkedServiceClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal LinkedServiceClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            RestClient = new LinkedServiceRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="ifNoneMatch"> ETag of the linked service entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LinkedServiceResource>> GetLinkedServiceAsync(string linkedServiceName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkedServiceClient.GetLinkedService");
            scope.Start();
            try
            {
                return await RestClient.GetLinkedServiceAsync(linkedServiceName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="ifNoneMatch"> ETag of the linked service entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LinkedServiceResource> GetLinkedService(string linkedServiceName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkedServiceClient.GetLinkedService");
            scope.Start();
            try
            {
                return RestClient.GetLinkedService(linkedServiceName, ifNoneMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists linked services. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<LinkedServiceResource> GetLinkedServicesByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetLinkedServicesByWorkspaceRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetLinkedServicesByWorkspaceNextPageRequest(nextLink);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, LinkedServiceResource.DeserializeLinkedServiceResource, _clientDiagnostics, _pipeline, "LinkedServiceClient.GetLinkedServicesByWorkspace", "value", "nextLink", cancellationToken);
        }

        /// <summary> Lists linked services. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<LinkedServiceResource> GetLinkedServicesByWorkspace(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetLinkedServicesByWorkspaceRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetLinkedServicesByWorkspaceNextPageRequest(nextLink);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, LinkedServiceResource.DeserializeLinkedServiceResource, _clientDiagnostics, _pipeline, "LinkedServiceClient.GetLinkedServicesByWorkspace", "value", "nextLink", cancellationToken);
        }

        /// <summary> Creates or updates a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="linkedService"> Linked service resource definition. </param>
        /// <param name="ifMatch"> ETag of the linkedService entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="linkedService"/> is null. </exception>
        public virtual async Task<LinkedServiceCreateOrUpdateLinkedServiceOperation> StartCreateOrUpdateLinkedServiceAsync(string linkedServiceName, LinkedServiceResource linkedService, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (linkedService == null)
            {
                throw new ArgumentNullException(nameof(linkedService));
            }

            using var scope = _clientDiagnostics.CreateScope("LinkedServiceClient.StartCreateOrUpdateLinkedService");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateLinkedServiceAsync(linkedServiceName, linkedService, ifMatch, cancellationToken).ConfigureAwait(false);
                return new LinkedServiceCreateOrUpdateLinkedServiceOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateLinkedServiceRequest(linkedServiceName, linkedService, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="linkedService"> Linked service resource definition. </param>
        /// <param name="ifMatch"> ETag of the linkedService entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="linkedService"/> is null. </exception>
        public virtual LinkedServiceCreateOrUpdateLinkedServiceOperation StartCreateOrUpdateLinkedService(string linkedServiceName, LinkedServiceResource linkedService, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (linkedService == null)
            {
                throw new ArgumentNullException(nameof(linkedService));
            }

            using var scope = _clientDiagnostics.CreateScope("LinkedServiceClient.StartCreateOrUpdateLinkedService");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdateLinkedService(linkedServiceName, linkedService, ifMatch, cancellationToken);
                return new LinkedServiceCreateOrUpdateLinkedServiceOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateLinkedServiceRequest(linkedServiceName, linkedService, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public virtual async Task<LinkedServiceDeleteLinkedServiceOperation> StartDeleteLinkedServiceAsync(string linkedServiceName, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("LinkedServiceClient.StartDeleteLinkedService");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteLinkedServiceAsync(linkedServiceName, cancellationToken).ConfigureAwait(false);
                return new LinkedServiceDeleteLinkedServiceOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteLinkedServiceRequest(linkedServiceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public virtual LinkedServiceDeleteLinkedServiceOperation StartDeleteLinkedService(string linkedServiceName, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("LinkedServiceClient.StartDeleteLinkedService");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DeleteLinkedService(linkedServiceName, cancellationToken);
                return new LinkedServiceDeleteLinkedServiceOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteLinkedServiceRequest(linkedServiceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Renames a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="request"/> is null. </exception>
        public virtual async Task<LinkedServiceRenameLinkedServiceOperation> StartRenameLinkedServiceAsync(string linkedServiceName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("LinkedServiceClient.StartRenameLinkedService");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.RenameLinkedServiceAsync(linkedServiceName, request, cancellationToken).ConfigureAwait(false);
                return new LinkedServiceRenameLinkedServiceOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenameLinkedServiceRequest(linkedServiceName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Renames a linked service. </summary>
        /// <param name="linkedServiceName"> The linked service name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="request"/> is null. </exception>
        public virtual LinkedServiceRenameLinkedServiceOperation StartRenameLinkedService(string linkedServiceName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("LinkedServiceClient.StartRenameLinkedService");
            scope.Start();
            try
            {
                var originalResponse = RestClient.RenameLinkedService(linkedServiceName, request, cancellationToken);
                return new LinkedServiceRenameLinkedServiceOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenameLinkedServiceRequest(linkedServiceName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
