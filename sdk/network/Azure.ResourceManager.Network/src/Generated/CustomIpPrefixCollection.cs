// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
    /// <summary> A class representing collection of CustomIpPrefix and their operations over its parent. </summary>
    public partial class CustomIpPrefixCollection : ArmCollection, IEnumerable<CustomIpPrefix>, IAsyncEnumerable<CustomIpPrefix>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CustomIPPrefixesRestOperations _customIPPrefixesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CustomIpPrefixCollection"/> class for mocking. </summary>
        protected CustomIpPrefixCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CustomIpPrefixCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CustomIpPrefixCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(CustomIpPrefix.ResourceType, out string apiVersion);
            _customIPPrefixesRestClient = new CustomIPPrefixesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates a custom IP prefix. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update custom IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual CustomIpPrefixCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string customIpPrefixName, CustomIpPrefixData parameters, CancellationToken cancellationToken = default)
        {
            if (customIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(customIpPrefixName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _customIPPrefixesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, parameters, cancellationToken);
                var operation = new CustomIpPrefixCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _customIPPrefixesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, parameters).Request, response);
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

        /// <summary> Creates or updates a custom IP prefix. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update custom IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<CustomIpPrefixCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string customIpPrefixName, CustomIpPrefixData parameters, CancellationToken cancellationToken = default)
        {
            if (customIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(customIpPrefixName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _customIPPrefixesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new CustomIpPrefixCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _customIPPrefixesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, parameters).Request, response);
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

        /// <summary> Gets the specified custom IP prefix in a specified resource group. </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> is null. </exception>
        public virtual Response<CustomIpPrefix> Get(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (customIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(customIpPrefixName));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = _customIPPrefixesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomIpPrefix(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified custom IP prefix in a specified resource group. </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> is null. </exception>
        public async virtual Task<Response<CustomIpPrefix>> GetAsync(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (customIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(customIpPrefixName));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = await _customIPPrefixesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CustomIpPrefix(this, response.Value), response.GetRawResponse());
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> is null. </exception>
        public virtual Response<CustomIpPrefix> GetIfExists(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (customIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(customIpPrefixName));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _customIPPrefixesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CustomIpPrefix>(null, response.GetRawResponse());
                return Response.FromValue(new CustomIpPrefix(this, response.Value), response.GetRawResponse());
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> is null. </exception>
        public async virtual Task<Response<CustomIpPrefix>> GetIfExistsAsync(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (customIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(customIpPrefixName));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _customIPPrefixesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CustomIpPrefix>(null, response.GetRawResponse());
                return Response.FromValue(new CustomIpPrefix(this, response.Value), response.GetRawResponse());
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> is null. </exception>
        public virtual Response<bool> Exists(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (customIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(customIpPrefixName));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.Exists");
            scope.Start();
            try
            {
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (customIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(customIpPrefixName));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.Exists");
            scope.Start();
            try
            {
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
        public virtual Pageable<CustomIpPrefix> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CustomIpPrefix> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _customIPPrefixesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomIpPrefix(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CustomIpPrefix> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _customIPPrefixesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomIpPrefix(this, value)), response.Value.NextLink, response.GetRawResponse());
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
        public virtual AsyncPageable<CustomIpPrefix> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CustomIpPrefix>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _customIPPrefixesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomIpPrefix(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CustomIpPrefix>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _customIPPrefixesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomIpPrefix(this, value)), response.Value.NextLink, response.GetRawResponse());
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
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.GetAllAsGenericResources");
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
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomIpPrefixCollection.GetAllAsGenericResources");
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

        IEnumerator<CustomIpPrefix> IEnumerable<CustomIpPrefix>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CustomIpPrefix> IAsyncEnumerable<CustomIpPrefix>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, CustomIpPrefix, CustomIpPrefixData> Construct() { }
    }
}
