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
    /// <summary> A class representing collection of PrivateLinkService and their operations over its parent. </summary>
    public partial class PrivateLinkServiceCollection : ArmCollection, IEnumerable<PrivateLinkService>, IAsyncEnumerable<PrivateLinkService>
    {
        private readonly ClientDiagnostics _privateLinkServiceClientDiagnostics;
        private readonly PrivateLinkServicesRestOperations _privateLinkServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateLinkServiceCollection"/> class for mocking. </summary>
        protected PrivateLinkServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateLinkServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PrivateLinkServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateLinkServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", PrivateLinkService.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(PrivateLinkService.ResourceType, out string privateLinkServiceApiVersion);
            _privateLinkServiceRestClient = new PrivateLinkServicesRestOperations(_privateLinkServiceClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, privateLinkServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates an private link service in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="parameters"> Parameters supplied to the create or update private link service operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PrivateLinkServiceCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string serviceName, PrivateLinkServiceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateLinkServiceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new PrivateLinkServiceCreateOrUpdateOperation(Client, _privateLinkServiceClientDiagnostics, Pipeline, _privateLinkServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceName, parameters).Request, response);
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

        /// <summary> Creates or updates an private link service in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="parameters"> Parameters supplied to the create or update private link service operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PrivateLinkServiceCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string serviceName, PrivateLinkServiceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateLinkServiceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, serviceName, parameters, cancellationToken);
                var operation = new PrivateLinkServiceCreateOrUpdateOperation(Client, _privateLinkServiceClientDiagnostics, Pipeline, _privateLinkServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceName, parameters).Request, response);
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

        /// <summary> Gets the specified private link service by resource group. </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public async virtual Task<Response<PrivateLinkService>> GetAsync(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateLinkServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _privateLinkServiceClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PrivateLinkService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified private link service by resource group. </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<PrivateLinkService> Get(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _privateLinkServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken);
                if (response.Value == null)
                    throw _privateLinkServiceClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateLinkService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all private link services in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateLinkService" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateLinkService> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateLinkService>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateLinkServiceRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLinkService(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PrivateLinkService>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateLinkServiceRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLinkService(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all private link services in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateLinkService" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateLinkService> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PrivateLinkService> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateLinkServiceRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLinkService(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PrivateLinkService> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateLinkServiceRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLinkService(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(serviceName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(serviceName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public async virtual Task<Response<PrivateLinkService>> GetIfExistsAsync(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _privateLinkServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<PrivateLinkService>(null, response.GetRawResponse());
                return Response.FromValue(new PrivateLinkService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<PrivateLinkService> GetIfExists(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _privateLinkServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<PrivateLinkService>(null, response.GetRawResponse());
                return Response.FromValue(new PrivateLinkService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateLinkService> IEnumerable<PrivateLinkService>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateLinkService> IAsyncEnumerable<PrivateLinkService>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
