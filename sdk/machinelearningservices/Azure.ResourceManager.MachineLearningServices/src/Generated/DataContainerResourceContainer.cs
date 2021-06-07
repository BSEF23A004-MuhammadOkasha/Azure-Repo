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
    /// <summary> A class representing collection of DataContainerResource and their operations over a Workspace. </summary>
    public partial class DataContainerResourceContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, DataContainerResource, DataContainerResourceData>
    {
        /// <summary> Initializes a new instance of the <see cref="DataContainerResourceContainer"/> class for mocking. </summary>
        protected DataContainerResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of DataContainerResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DataContainerResourceContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private DataContainersRestOperations _restClient => new DataContainersRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => WorkspaceOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a DataContainerResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<DataContainerResource> CreateOrUpdate(string workspaceName, DataContainer properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataContainerResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (properties == null)
                {
                    throw new ArgumentNullException(nameof(properties));
                }

                return StartCreateOrUpdate(workspaceName, properties, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a DataContainerResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<DataContainerResource>> CreateOrUpdateAsync(string workspaceName, DataContainer properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataContainerResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (properties == null)
                {
                    throw new ArgumentNullException(nameof(properties));
                }

                var operation = await StartCreateOrUpdateAsync(workspaceName, properties, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a DataContainerResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public DataContainersCreateOrUpdateOperation StartCreateOrUpdate(string workspaceName, DataContainer properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataContainerResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (properties == null)
                {
                    throw new ArgumentNullException(nameof(properties));
                }

                var originalResponse = _restClient.CreateOrUpdate(Id.Name, Id.ResourceGroupName, workspaceName, properties, cancellationToken: cancellationToken);
                return new DataContainersCreateOrUpdateOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a DataContainerResource. Please note some properties can be set only during creation. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<DataContainersCreateOrUpdateOperation> StartCreateOrUpdateAsync(string workspaceName, DataContainer properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataContainerResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }
                if (properties == null)
                {
                    throw new ArgumentNullException(nameof(properties));
                }

                var originalResponse = await _restClient.CreateOrUpdateAsync(Id.Name, Id.ResourceGroupName, workspaceName, properties, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new DataContainersCreateOrUpdateOperation(Parent, originalResponse);
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
        public override Response<DataContainerResource> Get(string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataContainerResourceContainer.Get");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }

                var response = _restClient.Get(Id.Name, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(new DataContainerResource(Parent, response.Value), response.GetRawResponse());
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
        public async override Task<Response<DataContainerResource>> GetAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataContainerResourceContainer.Get");
            scope.Start();
            try
            {
                if (workspaceName == null)
                {
                    throw new ArgumentNullException(nameof(workspaceName));
                }

                var response = await _restClient.GetAsync(Id.Name, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DataContainerResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List containers. </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<DataContainerResource> List(string skip = null, CancellationToken cancellationToken = default)
        {
            Page<DataContainerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataContainerResourceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataContainerResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataContainerResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataContainerResourceContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataContainerResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List containers. </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<DataContainerResource> ListAsync(string skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DataContainerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataContainerResourceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataContainerResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataContainerResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataContainerResourceContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataContainerResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of DataContainerResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataContainerResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DataContainerResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of DataContainerResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataContainerResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DataContainerResourceOperations.ResourceType);
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
        // public ArmBuilder<ResourceGroupResourceIdentifier, DataContainerResource, DataContainerResourceData> Construct() { }
    }
}
