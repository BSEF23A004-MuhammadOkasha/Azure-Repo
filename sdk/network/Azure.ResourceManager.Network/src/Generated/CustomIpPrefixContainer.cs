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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of CustomIpPrefix and their operations over a ResourceGroup. </summary>
    public partial class CustomIpPrefixContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CustomIPPrefixesRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="CustomIpPrefixContainer"/> class for mocking. </summary>
        protected CustomIpPrefixContainer()
        {
        }

        /// <summary> Initializes a new instance of CustomIpPrefixContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CustomIpPrefixContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new CustomIPPrefixesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a custom IP prefix. </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update custom IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<CustomIpPrefix> CreateOrUpdate(string customIpPrefixName, CustomIpPrefixData parameters, CancellationToken cancellationToken = default)
        {
            if (customIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(customIpPrefixName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(customIpPrefixName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a custom IP prefix. </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update custom IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<CustomIpPrefix>> CreateOrUpdateAsync(string customIpPrefixName, CustomIpPrefixData parameters, CancellationToken cancellationToken = default)
        {
            if (customIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(customIpPrefixName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(customIpPrefixName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a custom IP prefix. </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update custom IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual CustomIPPrefixCreateOrUpdateOperation StartCreateOrUpdate(string customIpPrefixName, CustomIpPrefixData parameters, CancellationToken cancellationToken = default)
        {
            if (customIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(customIpPrefixName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, customIpPrefixName, parameters, cancellationToken);
                return new CustomIPPrefixCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, customIpPrefixName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a custom IP prefix. </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update custom IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<CustomIPPrefixCreateOrUpdateOperation> StartCreateOrUpdateAsync(string customIpPrefixName, CustomIpPrefixData parameters, CancellationToken cancellationToken = default)
        {
            if (customIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(customIpPrefixName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, customIpPrefixName, parameters, cancellationToken).ConfigureAwait(false);
                return new CustomIPPrefixCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, customIpPrefixName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<CustomIpPrefix> Get(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.Get");
            scope.Start();
            try
            {
                if (customIpPrefixName == null)
                {
                    throw new ArgumentNullException(nameof(customIpPrefixName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, customIpPrefixName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomIpPrefix(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<CustomIpPrefix>> GetAsync(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.Get");
            scope.Start();
            try
            {
                if (customIpPrefixName == null)
                {
                    throw new ArgumentNullException(nameof(customIpPrefixName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, customIpPrefixName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CustomIpPrefix(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<CustomIpPrefix> GetIfExists(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.GetIfExists");
            scope.Start();
            try
            {
                if (customIpPrefixName == null)
                {
                    throw new ArgumentNullException(nameof(customIpPrefixName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, customIpPrefixName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<CustomIpPrefix>(null, response.GetRawResponse())
                    : Response.FromValue(new CustomIpPrefix(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<CustomIpPrefix>> GetIfExistsAsync(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.GetIfExists");
            scope.Start();
            try
            {
                if (customIpPrefixName == null)
                {
                    throw new ArgumentNullException(nameof(customIpPrefixName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, customIpPrefixName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<CustomIpPrefix>(null, response.GetRawResponse())
                    : Response.FromValue(new CustomIpPrefix(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (customIpPrefixName == null)
                {
                    throw new ArgumentNullException(nameof(customIpPrefixName));
                }

                var response = GetIfExists(customIpPrefixName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (customIpPrefixName == null)
                {
                    throw new ArgumentNullException(nameof(customIpPrefixName));
                }

                var response = await GetIfExistsAsync(customIpPrefixName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all custom IP prefixes in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CustomIpPrefix" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<CustomIpPrefix> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CustomIpPrefix> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomIpPrefix(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CustomIpPrefix> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomIpPrefix(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all custom IP prefixes in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CustomIpPrefix" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<CustomIpPrefix> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CustomIpPrefix>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomIpPrefix(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CustomIpPrefix>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomIpPrefix(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="CustomIpPrefix" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(CustomIpPrefix.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="CustomIpPrefix" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(CustomIpPrefix.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, CustomIpPrefix, CustomIpPrefixData> Construct() { }
    }
}
