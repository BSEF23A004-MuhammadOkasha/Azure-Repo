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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing collection of BatchDeploymentTrackedResource and their operations over a BatchEndpointTrackedResource. </summary>
    public partial class BatchDeploymentTrackedResourceContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, BatchDeploymentTrackedResource, BatchDeploymentTrackedResourceData>
    {
        /// <summary> Initializes a new instance of the <see cref="BatchDeploymentTrackedResourceContainer"/> class for mocking. </summary>
        protected BatchDeploymentTrackedResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of BatchDeploymentTrackedResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BatchDeploymentTrackedResourceContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private BatchDeploymentsRestOperations _restClient => new BatchDeploymentsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => BatchEndpointTrackedResourceOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a BatchDeploymentTrackedResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Batch inference deployment definition object. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<BatchDeploymentTrackedResource> CreateOrUpdate(string workspaceName, BatchDeploymentTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (body == null)
                {
                    throw new ArgumentNullException(nameof(body));
                }

                return StartCreateOrUpdate(workspaceName, body, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a BatchDeploymentTrackedResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Batch inference deployment definition object. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<BatchDeploymentTrackedResource>> CreateOrUpdateAsync(string workspaceName, BatchDeploymentTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (body == null)
                {
                    throw new ArgumentNullException(nameof(body));
                }

                var operation = await StartCreateOrUpdateAsync(workspaceName, body, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a BatchDeploymentTrackedResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Batch inference deployment definition object. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public BatchDeploymentsCreateOrUpdateOperation StartCreateOrUpdate(string workspaceName, BatchDeploymentTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (body == null)
                {
                    throw new ArgumentNullException(nameof(body));
                }

                var originalResponse = _restClient.CreateOrUpdate(Id.Parent.Name, Id.Name, Id.ResourceGroupName, workspaceName, body, cancellationToken: cancellationToken);
                return new BatchDeploymentsCreateOrUpdateOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a BatchDeploymentTrackedResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Batch inference deployment definition object. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<BatchDeploymentsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string workspaceName, BatchDeploymentTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (body == null)
                {
                    throw new ArgumentNullException(nameof(body));
                }

                var originalResponse = await _restClient.CreateOrUpdateAsync(Id.Parent.Name, Id.Name, Id.ResourceGroupName, workspaceName, body, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new BatchDeploymentsCreateOrUpdateOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public override Response<BatchDeploymentTrackedResource> Get(string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.Get");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }

                var response = _restClient.Get(Id.Parent.Name, Id.Name, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(new BatchDeploymentTrackedResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async override Task<Response<BatchDeploymentTrackedResource>> GetAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.Get");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }

                var response = await _restClient.GetAsync(Id.Parent.Name, Id.Name, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new BatchDeploymentTrackedResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists Batch inference deployments in the workspace. </summary>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Top of list. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchDeploymentTrackedResource" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<BatchDeploymentTrackedResource> List(string orderBy = null, int? top = null, string skip = null, CancellationToken cancellationToken = default)
        {
            Page<BatchDeploymentTrackedResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.Parent.Name, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchDeploymentTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BatchDeploymentTrackedResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.Parent.Name, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchDeploymentTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists Batch inference deployments in the workspace. </summary>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Top of list. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchDeploymentTrackedResource" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<BatchDeploymentTrackedResource> ListAsync(string orderBy = null, int? top = null, string skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<BatchDeploymentTrackedResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.Parent.Name, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchDeploymentTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BatchDeploymentTrackedResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.Parent.Name, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchDeploymentTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of BatchDeploymentTrackedResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BatchDeploymentTrackedResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of BatchDeploymentTrackedResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BatchDeploymentTrackedResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, BatchDeploymentTrackedResource, BatchDeploymentTrackedResourceData> Construct() { }
    }
}
