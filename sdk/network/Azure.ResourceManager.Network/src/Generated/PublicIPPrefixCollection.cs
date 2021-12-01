// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
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
    /// <summary> A class representing collection of PublicIPPrefix and their operations over its parent. </summary>
    public partial class PublicIPPrefixCollection : ArmCollection, IEnumerable<PublicIPPrefix>, IAsyncEnumerable<PublicIPPrefix>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PublicIPPrefixesRestOperations _publicIPPrefixesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PublicIPPrefixCollection"/> class for mocking. </summary>
        protected PublicIPPrefixCollection()
        {
        }

        /// <summary> Initializes a new instance of PublicIPPrefixCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PublicIPPrefixCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _publicIPPrefixesRestClient = new PublicIPPrefixesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a static or dynamic public IP prefix. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update public IP prefix operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PublicIPPrefixCreateOrUpdateOperation CreateOrUpdate(string publicIpPrefixName, PublicIPPrefixData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (publicIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(publicIpPrefixName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _publicIPPrefixesRestClient.CreateOrUpdate(Id.ResourceGroupName, publicIpPrefixName, parameters, cancellationToken);
                var operation = new PublicIPPrefixCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _publicIPPrefixesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, publicIpPrefixName, parameters).Request, response);
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

        /// <summary> Creates or updates a static or dynamic public IP prefix. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update public IP prefix operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PublicIPPrefixCreateOrUpdateOperation> CreateOrUpdateAsync(string publicIpPrefixName, PublicIPPrefixData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (publicIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(publicIpPrefixName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _publicIPPrefixesRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, publicIpPrefixName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new PublicIPPrefixCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _publicIPPrefixesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, publicIpPrefixName, parameters).Request, response);
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

        /// <summary> Gets the specified public IP prefix in a specified resource group. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpPrefixName"/> is null. </exception>
        public virtual Response<PublicIPPrefix> Get(string publicIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publicIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(publicIpPrefixName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = _publicIPPrefixesRestClient.Get(Id.ResourceGroupName, publicIpPrefixName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublicIPPrefix(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified public IP prefix in a specified resource group. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpPrefixName"/> is null. </exception>
        public async virtual Task<Response<PublicIPPrefix>> GetAsync(string publicIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publicIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(publicIpPrefixName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = await _publicIPPrefixesRestClient.GetAsync(Id.ResourceGroupName, publicIpPrefixName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PublicIPPrefix(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpPrefixName"/> is null. </exception>
        public virtual Response<PublicIPPrefix> GetIfExists(string publicIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publicIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(publicIpPrefixName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _publicIPPrefixesRestClient.Get(Id.ResourceGroupName, publicIpPrefixName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<PublicIPPrefix>(null, response.GetRawResponse())
                    : Response.FromValue(new PublicIPPrefix(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpPrefixName"/> is null. </exception>
        public async virtual Task<Response<PublicIPPrefix>> GetIfExistsAsync(string publicIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publicIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(publicIpPrefixName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _publicIPPrefixesRestClient.GetAsync(Id.ResourceGroupName, publicIpPrefixName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<PublicIPPrefix>(null, response.GetRawResponse())
                    : Response.FromValue(new PublicIPPrefix(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpPrefixName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string publicIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publicIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(publicIpPrefixName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(publicIpPrefixName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpPrefixName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string publicIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publicIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(publicIpPrefixName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(publicIpPrefixName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all public IP prefixes in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PublicIPPrefix" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PublicIPPrefix> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PublicIPPrefix> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _publicIPPrefixesRestClient.List(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicIPPrefix(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PublicIPPrefix> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _publicIPPrefixesRestClient.ListNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicIPPrefix(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all public IP prefixes in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PublicIPPrefix" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PublicIPPrefix> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PublicIPPrefix>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _publicIPPrefixesRestClient.ListAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicIPPrefix(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PublicIPPrefix>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _publicIPPrefixesRestClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicIPPrefix(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="PublicIPPrefix" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PublicIPPrefix.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="PublicIPPrefix" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PublicIPPrefix.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PublicIPPrefix> IEnumerable<PublicIPPrefix>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PublicIPPrefix> IAsyncEnumerable<PublicIPPrefix>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, PublicIPPrefix, PublicIPPrefixData> Construct() { }
    }
}
