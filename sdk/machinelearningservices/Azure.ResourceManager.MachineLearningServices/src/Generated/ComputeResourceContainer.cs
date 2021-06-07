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
    /// <summary> A class representing collection of ComputeResource and their operations over a Workspace. </summary>
    public partial class ComputeResourceContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, ComputeResource, ComputeResourceData>
    {
        /// <summary> Initializes a new instance of the <see cref="ComputeResourceContainer"/> class for mocking. </summary>
        protected ComputeResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of ComputeResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ComputeResourceContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private ComputeRestOperations _restClient => new ComputeRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => WorkspaceOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a ComputeResource. Please note some properties can be set only during creation. </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="parameters"> Payload with Machine Learning compute definition. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<ComputeResource> CreateOrUpdate(string computeName, ComputeResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (computeName == null)
                {
                    throw new ArgumentNullException(nameof(computeName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(computeName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ComputeResource. Please note some properties can be set only during creation. </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="parameters"> Payload with Machine Learning compute definition. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<ComputeResource>> CreateOrUpdateAsync(string computeName, ComputeResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (computeName == null)
                {
                    throw new ArgumentNullException(nameof(computeName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(computeName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ComputeResource. Please note some properties can be set only during creation. </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="parameters"> Payload with Machine Learning compute definition. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public ComputeCreateOrUpdateOperation StartCreateOrUpdate(string computeName, ComputeResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (computeName == null)
                {
                    throw new ArgumentNullException(nameof(computeName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, computeName, parameters, cancellationToken: cancellationToken);
                return new ComputeCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, computeName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ComputeResource. Please note some properties can be set only during creation. </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="parameters"> Payload with Machine Learning compute definition. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<ComputeCreateOrUpdateOperation> StartCreateOrUpdateAsync(string computeName, ComputeResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (computeName == null)
                {
                    throw new ArgumentNullException(nameof(computeName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, computeName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new ComputeCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, computeName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public override Response<ComputeResource> Get(string computeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceContainer.Get");
            scope.Start();
            try
            {
                if (computeName == null)
                {
                    throw new ArgumentNullException(nameof(computeName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, computeName, cancellationToken: cancellationToken);
                return Response.FromValue(new ComputeResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async override Task<Response<ComputeResource>> GetAsync(string computeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceContainer.Get");
            scope.Start();
            try
            {
                if (computeName == null)
                {
                    throw new ArgumentNullException(nameof(computeName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, computeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ComputeResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets computes in specified workspace. </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ComputeResource" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<ComputeResource> List(string skip = null, CancellationToken cancellationToken = default)
        {
            Page<ComputeResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ComputeResourceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ComputeResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ComputeResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ComputeResourceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ComputeResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets computes in specified workspace. </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ComputeResource" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<ComputeResource> ListAsync(string skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ComputeResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ComputeResourceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ComputeResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ComputeResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ComputeResourceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ComputeResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of ComputeResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ComputeResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of ComputeResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputeResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ComputeResourceOperations.ResourceType);
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
        // public ArmBuilder<ResourceGroupResourceIdentifier, ComputeResource, ComputeResourceData> Construct() { }
    }
}
