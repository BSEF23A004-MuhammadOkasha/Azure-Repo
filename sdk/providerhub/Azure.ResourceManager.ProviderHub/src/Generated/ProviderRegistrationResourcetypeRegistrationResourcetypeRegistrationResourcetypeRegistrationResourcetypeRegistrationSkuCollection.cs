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

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A class representing a collection of <see cref="ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource" /> and their operations.
    /// Each <see cref="ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource" /> in the collection will belong to the same instance of <see cref="ResourceTypeRegistrationResource" />.
    /// To get a <see cref="ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection" /> instance call the GetProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkus method from an instance of <see cref="ResourceTypeRegistrationResource" />.
    /// </summary>
    public partial class ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection : ArmCollection, IEnumerable<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource>, IAsyncEnumerable<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource>
    {
        private readonly ClientDiagnostics _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics;
        private readonly SkusRestOperations _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusRestClient;
        private readonly string _nestedResourceTypeFirst;
        private readonly string _nestedResourceTypeSecond;
        private readonly string _nestedResourceTypeThird;

        /// <summary> Initializes a new instance of the <see cref="ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection"/> class for mocking. </summary>
        protected ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="nestedResourceTypeFirst"> The first child resource type. </param>
        /// <param name="nestedResourceTypeSecond"> The second child resource type. </param>
        /// <param name="nestedResourceTypeThird"> The third child resource type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/> or <paramref name="nestedResourceTypeThird"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="nestedResourceTypeFirst"/>, <paramref name="nestedResourceTypeSecond"/> or <paramref name="nestedResourceTypeThird"/> is an empty string, and was expected to be non-empty. </exception>
        internal ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection(ArmClient client, ResourceIdentifier id, string nestedResourceTypeFirst, string nestedResourceTypeSecond, string nestedResourceTypeThird) : base(client, id)
        {
            _nestedResourceTypeFirst = nestedResourceTypeFirst;
            _nestedResourceTypeSecond = nestedResourceTypeSecond;
            _nestedResourceTypeThird = nestedResourceTypeThird;
            _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource.ResourceType, out string providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusApiVersion);
            _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusRestClient = new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceTypeRegistrationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceTypeRegistrationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the resource type skus in the given resource type.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}
        /// Operation Id: Skus_CreateOrUpdateNestedResourceTypeThird
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sku, SkuResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusRestClient.CreateOrUpdateNestedResourceTypeThirdAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, data, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource>(Response.FromValue(new ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the resource type skus in the given resource type.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}
        /// Operation Id: Skus_CreateOrUpdateNestedResourceTypeThird
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource> CreateOrUpdate(WaitUntil waitUntil, string sku, SkuResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusRestClient.CreateOrUpdateNestedResourceTypeThird(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, data, cancellationToken);
                var operation = new ProviderHubArmOperation<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource>(Response.FromValue(new ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}
        /// Operation Id: Skus_GetNestedResourceTypeThird
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<Response<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource>> GetAsync(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection.Get");
            scope.Start();
            try
            {
                var response = await _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusRestClient.GetNestedResourceTypeThirdAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}
        /// Operation Id: Skus_GetNestedResourceTypeThird
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual Response<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource> Get(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection.Get");
            scope.Start();
            try
            {
                var response = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusRestClient.GetNestedResourceTypeThird(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus
        /// Operation Id: Skus_ListByResourceTypeRegistrationsNestedResourceTypeThird
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusRestClient.ListByResourceTypeRegistrationsNestedResourceTypeThirdAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusRestClient.ListByResourceTypeRegistrationsNestedResourceTypeThirdNextPageAsync(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus
        /// Operation Id: Skus_ListByResourceTypeRegistrationsNestedResourceTypeThird
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusRestClient.ListByResourceTypeRegistrationsNestedResourceTypeThird(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusRestClient.ListByResourceTypeRegistrationsNestedResourceTypeThirdNextPage(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}
        /// Operation Id: Skus_GetNestedResourceTypeThird
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = await _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusRestClient.GetNestedResourceTypeThirdAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/resourcetypeRegistrations/{nestedResourceTypeThird}/skus/{sku}
        /// Operation Id: Skus_GetNestedResourceTypeThird
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual Response<bool> Exists(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusClientDiagnostics.CreateScope("ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = _providerRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuSkusRestClient.GetNestedResourceTypeThird(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, _nestedResourceTypeThird, sku, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource> IEnumerable<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource> IAsyncEnumerable<ProviderRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationResourcetypeRegistrationSkuResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
