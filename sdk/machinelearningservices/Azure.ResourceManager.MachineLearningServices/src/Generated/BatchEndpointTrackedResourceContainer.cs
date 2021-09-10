// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing collection of BatchEndpointTrackedResource and their operations over a Workspace. </summary>
    public partial class BatchEndpointTrackedResourceContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly BatchEndpointsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="BatchEndpointTrackedResourceContainer"/> class for mocking. </summary>
        protected BatchEndpointTrackedResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of BatchEndpointTrackedResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BatchEndpointTrackedResourceContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new BatchEndpointsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Workspace.ResourceType;

        // Container level operations.

        /// <summary> Creates a batch inference endpoint (asynchronous). </summary>
        /// <param name="endpointName"> Name for the Batch inference endpoint. </param>
        /// <param name="body"> Batch inference endpoint definition object. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="body"/> is null. </exception>
        public virtual BatchEndpointCreateOrUpdateOperation CreateOrUpdate(string endpointName, BatchEndpointTrackedResourceData body, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("BatchEndpointTrackedResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, endpointName, body, cancellationToken);
                var operation = new BatchEndpointCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, endpointName, body).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a batch inference endpoint (asynchronous). </summary>
        /// <param name="endpointName"> Name for the Batch inference endpoint. </param>
        /// <param name="body"> Batch inference endpoint definition object. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="body"/> is null. </exception>
        public async virtual Task<BatchEndpointCreateOrUpdateOperation> CreateOrUpdateAsync(string endpointName, BatchEndpointTrackedResourceData body, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("BatchEndpointTrackedResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, endpointName, body, cancellationToken).ConfigureAwait(false);
                var operation = new BatchEndpointCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, endpointName, body).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<BatchEndpointTrackedResource> Get(string endpointName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchEndpointTrackedResourceContainer.Get");
            scope.Start();
            try
            {
                if (endpointName == null)
                {
                    throw new ArgumentNullException(nameof(endpointName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchEndpointTrackedResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<BatchEndpointTrackedResource>> GetAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchEndpointTrackedResourceContainer.Get");
            scope.Start();
            try
            {
                if (endpointName == null)
                {
                    throw new ArgumentNullException(nameof(endpointName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BatchEndpointTrackedResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<BatchEndpointTrackedResource> GetIfExists(string endpointName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchEndpointTrackedResourceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (endpointName == null)
                {
                    throw new ArgumentNullException(nameof(endpointName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<BatchEndpointTrackedResource>(null, response.GetRawResponse())
                    : Response.FromValue(new BatchEndpointTrackedResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<BatchEndpointTrackedResource>> GetIfExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchEndpointTrackedResourceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (endpointName == null)
                {
                    throw new ArgumentNullException(nameof(endpointName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<BatchEndpointTrackedResource>(null, response.GetRawResponse())
                    : Response.FromValue(new BatchEndpointTrackedResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string endpointName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchEndpointTrackedResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (endpointName == null)
                {
                    throw new ArgumentNullException(nameof(endpointName));
                }

                var response = GetIfExists(endpointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchEndpointTrackedResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (endpointName == null)
                {
                    throw new ArgumentNullException(nameof(endpointName));
                }

                var response = await GetIfExistsAsync(endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists Batch inference endpoint in the workspace. </summary>
        /// <param name="count"> Number of endpoints to be retrieved in a page of results. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchEndpointTrackedResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BatchEndpointTrackedResource> GetAll(int? count = null, string skip = null, CancellationToken cancellationToken = default)
        {
            Page<BatchEndpointTrackedResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BatchEndpointTrackedResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, count, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchEndpointTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BatchEndpointTrackedResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BatchEndpointTrackedResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, count, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchEndpointTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists Batch inference endpoint in the workspace. </summary>
        /// <param name="count"> Number of endpoints to be retrieved in a page of results. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchEndpointTrackedResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BatchEndpointTrackedResource> GetAllAsync(int? count = null, string skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<BatchEndpointTrackedResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BatchEndpointTrackedResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, count, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchEndpointTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BatchEndpointTrackedResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BatchEndpointTrackedResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, count, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchEndpointTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, BatchEndpointTrackedResource, BatchEndpointTrackedResourceData> Construct() { }
    }
}
