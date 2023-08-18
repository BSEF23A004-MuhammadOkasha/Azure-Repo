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
    /// <summary> The Dataset service client. </summary>
    public partial class DatasetClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DatasetRestClient RestClient { get; }

        /// <summary> Initializes a new instance of DatasetClient for mocking. </summary>
        protected DatasetClient()
        {
        }

        /// <summary> Initializes a new instance of DatasetClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public DatasetClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
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
            RestClient = new DatasetRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of DatasetClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal DatasetClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            RestClient = new DatasetRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DatasetResource>> GetDatasetAsync(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DatasetClient.GetDataset");
            scope.Start();
            try
            {
                return await RestClient.GetDatasetAsync(datasetName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatasetResource> GetDataset(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DatasetClient.GetDataset");
            scope.Start();
            try
            {
                return RestClient.GetDataset(datasetName, ifNoneMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists datasets. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DatasetResource> GetDatasetsByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetDatasetsByWorkspaceRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetDatasetsByWorkspaceNextPageRequest(nextLink);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, DatasetResource.DeserializeDatasetResource, _clientDiagnostics, _pipeline, "DatasetClient.GetDatasetsByWorkspace", "value", "nextLink", cancellationToken);
        }

        /// <summary> Lists datasets. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DatasetResource> GetDatasetsByWorkspace(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetDatasetsByWorkspaceRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetDatasetsByWorkspaceNextPageRequest(nextLink);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, DatasetResource.DeserializeDatasetResource, _clientDiagnostics, _pipeline, "DatasetClient.GetDatasetsByWorkspace", "value", "nextLink", cancellationToken);
        }

        /// <summary> Creates or updates a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="dataset"> Dataset resource definition. </param>
        /// <param name="ifMatch"> ETag of the dataset entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> or <paramref name="dataset"/> is null. </exception>
        public virtual async Task<DatasetCreateOrUpdateDatasetOperation> StartCreateOrUpdateDatasetAsync(string datasetName, DatasetResource dataset, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }
            if (dataset == null)
            {
                throw new ArgumentNullException(nameof(dataset));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetClient.StartCreateOrUpdateDataset");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateDatasetAsync(datasetName, dataset, ifMatch, cancellationToken).ConfigureAwait(false);
                return new DatasetCreateOrUpdateDatasetOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateDatasetRequest(datasetName, dataset, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="dataset"> Dataset resource definition. </param>
        /// <param name="ifMatch"> ETag of the dataset entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> or <paramref name="dataset"/> is null. </exception>
        public virtual DatasetCreateOrUpdateDatasetOperation StartCreateOrUpdateDataset(string datasetName, DatasetResource dataset, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }
            if (dataset == null)
            {
                throw new ArgumentNullException(nameof(dataset));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetClient.StartCreateOrUpdateDataset");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdateDataset(datasetName, dataset, ifMatch, cancellationToken);
                return new DatasetCreateOrUpdateDatasetOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateDatasetRequest(datasetName, dataset, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public virtual async Task<DatasetDeleteDatasetOperation> StartDeleteDatasetAsync(string datasetName, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetClient.StartDeleteDataset");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteDatasetAsync(datasetName, cancellationToken).ConfigureAwait(false);
                return new DatasetDeleteDatasetOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteDatasetRequest(datasetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public virtual DatasetDeleteDatasetOperation StartDeleteDataset(string datasetName, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetClient.StartDeleteDataset");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DeleteDataset(datasetName, cancellationToken);
                return new DatasetDeleteDatasetOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteDatasetRequest(datasetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Renames a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> or <paramref name="request"/> is null. </exception>
        public virtual async Task<DatasetRenameDatasetOperation> StartRenameDatasetAsync(string datasetName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetClient.StartRenameDataset");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.RenameDatasetAsync(datasetName, request, cancellationToken).ConfigureAwait(false);
                return new DatasetRenameDatasetOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenameDatasetRequest(datasetName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Renames a dataset. </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> or <paramref name="request"/> is null. </exception>
        public virtual DatasetRenameDatasetOperation StartRenameDataset(string datasetName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (datasetName == null)
            {
                throw new ArgumentNullException(nameof(datasetName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("DatasetClient.StartRenameDataset");
            scope.Start();
            try
            {
                var originalResponse = RestClient.RenameDataset(datasetName, request, cancellationToken);
                return new DatasetRenameDatasetOperation(_clientDiagnostics, _pipeline, RestClient.CreateRenameDatasetRequest(datasetName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
