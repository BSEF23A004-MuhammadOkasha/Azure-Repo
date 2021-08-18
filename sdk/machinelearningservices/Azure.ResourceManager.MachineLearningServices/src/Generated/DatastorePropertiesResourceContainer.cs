// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing collection of DatastorePropertiesResource and their operations over a Workspace. </summary>
    public partial class DatastorePropertiesResourceContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="DatastorePropertiesResourceContainer"/> class for mocking. </summary>
        protected DatastorePropertiesResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of DatastorePropertiesResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DatastorePropertiesResourceContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private DatastoresRestOperations _restClient => new DatastoresRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => WorkspaceOperations.ResourceType;

        // Container level operations.

        /// <summary> Create or update datastore. </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="skipValidation"> Flag to skip validation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        public virtual Response<DatastorePropertiesResource> CreateOrUpdate(string name, DatastoreProperties properties, bool? skipValidation = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(name, properties, skipValidation, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update datastore. </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="skipValidation"> Flag to skip validation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        public async virtual Task<Response<DatastorePropertiesResource>> CreateOrUpdateAsync(string name, DatastoreProperties properties, bool? skipValidation = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(name, properties, skipValidation, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update datastore. </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="skipValidation"> Flag to skip validation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        public virtual DatastoreCreateOrUpdateOperation StartCreateOrUpdate(string name, DatastoreProperties properties, bool? skipValidation = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, name, properties, skipValidation, cancellationToken);
                return new DatastoreCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update datastore. </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="skipValidation"> Flag to skip validation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        public async virtual Task<DatastoreCreateOrUpdateOperation> StartCreateOrUpdateAsync(string name, DatastoreProperties properties, bool? skipValidation = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, name, properties, skipValidation, cancellationToken).ConfigureAwait(false);
                return new DatastoreCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<DatastorePropertiesResource> Get(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.Get");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatastorePropertiesResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<DatastorePropertiesResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.Get");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DatastorePropertiesResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<DatastorePropertiesResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DatastorePropertiesResource>(null, response.GetRawResponse())
                    : Response.FromValue(new DatastorePropertiesResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<DatastorePropertiesResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DatastorePropertiesResource>(null, response.GetRawResponse())
                    : Response.FromValue(new DatastorePropertiesResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Datastore name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List datastores. </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="count"> Maximum number of results to return. </param>
        /// <param name="isDefault"> Filter down to the workspace default datastore. </param>
        /// <param name="names"> Names of datastores to return. </param>
        /// <param name="searchText"> Text to search for in the datastore names. </param>
        /// <param name="orderBy"> Order by property (createdtime | modifiedtime | name). </param>
        /// <param name="orderByAsc"> Order by property in ascending order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatastorePropertiesResource" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<DatastorePropertiesResource> GetAll(string skip = null, int? count = null, bool? isDefault = null, IEnumerable<string> names = null, string searchText = null, string orderBy = null, bool? orderByAsc = null, CancellationToken cancellationToken = default)
        {
            Page<DatastorePropertiesResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, skip, count, isDefault, names, searchText, orderBy, orderByAsc, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DatastorePropertiesResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DatastorePropertiesResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, skip, count, isDefault, names, searchText, orderBy, orderByAsc, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DatastorePropertiesResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List datastores. </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="count"> Maximum number of results to return. </param>
        /// <param name="isDefault"> Filter down to the workspace default datastore. </param>
        /// <param name="names"> Names of datastores to return. </param>
        /// <param name="searchText"> Text to search for in the datastore names. </param>
        /// <param name="orderBy"> Order by property (createdtime | modifiedtime | name). </param>
        /// <param name="orderByAsc"> Order by property in ascending order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatastorePropertiesResource" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<DatastorePropertiesResource> GetAllAsync(string skip = null, int? count = null, bool? isDefault = null, IEnumerable<string> names = null, string searchText = null, string orderBy = null, bool? orderByAsc = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DatastorePropertiesResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, skip, count, isDefault, names, searchText, orderBy, orderByAsc, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DatastorePropertiesResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DatastorePropertiesResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, skip, count, isDefault, names, searchText, orderBy, orderByAsc, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DatastorePropertiesResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="DatastorePropertiesResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DatastorePropertiesResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DatastorePropertiesResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DatastorePropertiesResourceContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DatastorePropertiesResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, DatastorePropertiesResource, DatastorePropertiesResourceData> Construct() { }
    }
}
