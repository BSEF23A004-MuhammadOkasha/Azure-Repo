// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A class representing a collection of <see cref="NestedResourceTypeFirstSkuResource"/> and their operations.
    /// Each <see cref="NestedResourceTypeFirstSkuResource"/> in the collection will belong to the same instance of <see cref="ResourceTypeRegistrationResource"/>.
    /// To get a <see cref="NestedResourceTypeFirstSkuCollection"/> instance call the GetNestedResourceTypeFirstSkus method from an instance of <see cref="ResourceTypeRegistrationResource"/>.
    /// </summary>
    public partial class NestedResourceTypeFirstSkuCollection : ArmCollection, IEnumerable<NestedResourceTypeFirstSkuResource>, IAsyncEnumerable<NestedResourceTypeFirstSkuResource>
    {
        private readonly ClientDiagnostics _nestedResourceTypeFirstSkuSkusClientDiagnostics;
        private readonly SkusRestOperations _nestedResourceTypeFirstSkuSkusRestClient;
        private readonly string _nestedResourceTypeFirst;

        /// <summary> Initializes a new instance of the <see cref="NestedResourceTypeFirstSkuCollection"/> class for mocking. </summary>
        protected NestedResourceTypeFirstSkuCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NestedResourceTypeFirstSkuCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="nestedResourceTypeFirst"> The first child resource type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nestedResourceTypeFirst"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="nestedResourceTypeFirst"/> is an empty string, and was expected to be non-empty. </exception>
        internal NestedResourceTypeFirstSkuCollection(ArmClient client, ResourceIdentifier id, string nestedResourceTypeFirst) : base(client, id)
        {
            _nestedResourceTypeFirst = nestedResourceTypeFirst;
            _nestedResourceTypeFirstSkuSkusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", NestedResourceTypeFirstSkuResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NestedResourceTypeFirstSkuResource.ResourceType, out string nestedResourceTypeFirstSkuSkusApiVersion);
            _nestedResourceTypeFirstSkuSkusRestClient = new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, nestedResourceTypeFirstSkuSkusApiVersion);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_CreateOrUpdateNestedResourceTypeFirst</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeFirstSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NestedResourceTypeFirstSkuResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sku, ResourceTypeSkuData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _nestedResourceTypeFirstSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeFirstSkuCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _nestedResourceTypeFirstSkuSkusRestClient.CreateOrUpdateNestedResourceTypeFirstAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, sku, data, cancellationToken).ConfigureAwait(false);
                var uri = _nestedResourceTypeFirstSkuSkusRestClient.CreateCreateOrUpdateNestedResourceTypeFirstRequestUri(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, sku, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new ProviderHubArmOperation<NestedResourceTypeFirstSkuResource>(Response.FromValue(new NestedResourceTypeFirstSkuResource(Client, response), response.GetRawResponse()), operationId);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_CreateOrUpdateNestedResourceTypeFirst</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeFirstSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NestedResourceTypeFirstSkuResource> CreateOrUpdate(WaitUntil waitUntil, string sku, ResourceTypeSkuData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _nestedResourceTypeFirstSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeFirstSkuCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _nestedResourceTypeFirstSkuSkusRestClient.CreateOrUpdateNestedResourceTypeFirst(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, sku, data, cancellationToken);
                var uri = _nestedResourceTypeFirstSkuSkusRestClient.CreateCreateOrUpdateNestedResourceTypeFirstRequestUri(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, sku, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new ProviderHubArmOperation<NestedResourceTypeFirstSkuResource>(Response.FromValue(new NestedResourceTypeFirstSkuResource(Client, response), response.GetRawResponse()), operationId);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeFirst</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeFirstSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<Response<NestedResourceTypeFirstSkuResource>> GetAsync(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _nestedResourceTypeFirstSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeFirstSkuCollection.Get");
            scope.Start();
            try
            {
                var response = await _nestedResourceTypeFirstSkuSkusRestClient.GetNestedResourceTypeFirstAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, sku, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NestedResourceTypeFirstSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeFirst</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeFirstSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual Response<NestedResourceTypeFirstSkuResource> Get(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _nestedResourceTypeFirstSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeFirstSkuCollection.Get");
            scope.Start();
            try
            {
                var response = _nestedResourceTypeFirstSkuSkusRestClient.GetNestedResourceTypeFirst(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, sku, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NestedResourceTypeFirstSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_ListByResourceTypeRegistrationsNestedResourceTypeFirst</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeFirstSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NestedResourceTypeFirstSkuResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NestedResourceTypeFirstSkuResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _nestedResourceTypeFirstSkuSkusRestClient.CreateListByResourceTypeRegistrationsNestedResourceTypeFirstRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _nestedResourceTypeFirstSkuSkusRestClient.CreateListByResourceTypeRegistrationsNestedResourceTypeFirstNextPageRequest(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NestedResourceTypeFirstSkuResource(Client, ResourceTypeSkuData.DeserializeResourceTypeSkuData(e)), _nestedResourceTypeFirstSkuSkusClientDiagnostics, Pipeline, "NestedResourceTypeFirstSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_ListByResourceTypeRegistrationsNestedResourceTypeFirst</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeFirstSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NestedResourceTypeFirstSkuResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NestedResourceTypeFirstSkuResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _nestedResourceTypeFirstSkuSkusRestClient.CreateListByResourceTypeRegistrationsNestedResourceTypeFirstRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _nestedResourceTypeFirstSkuSkusRestClient.CreateListByResourceTypeRegistrationsNestedResourceTypeFirstNextPageRequest(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NestedResourceTypeFirstSkuResource(Client, ResourceTypeSkuData.DeserializeResourceTypeSkuData(e)), _nestedResourceTypeFirstSkuSkusClientDiagnostics, Pipeline, "NestedResourceTypeFirstSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeFirst</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeFirstSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _nestedResourceTypeFirstSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeFirstSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = await _nestedResourceTypeFirstSkuSkusRestClient.GetNestedResourceTypeFirstAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, sku, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeFirst</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeFirstSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual Response<bool> Exists(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _nestedResourceTypeFirstSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeFirstSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = _nestedResourceTypeFirstSkuSkusRestClient.GetNestedResourceTypeFirst(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, sku, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeFirst</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeFirstSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<NullableResponse<NestedResourceTypeFirstSkuResource>> GetIfExistsAsync(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _nestedResourceTypeFirstSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeFirstSkuCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _nestedResourceTypeFirstSkuSkusRestClient.GetNestedResourceTypeFirstAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, sku, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NestedResourceTypeFirstSkuResource>(response.GetRawResponse());
                return Response.FromValue(new NestedResourceTypeFirstSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeFirst</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeFirstSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual NullableResponse<NestedResourceTypeFirstSkuResource> GetIfExists(string sku, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sku, nameof(sku));

            using var scope = _nestedResourceTypeFirstSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeFirstSkuCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _nestedResourceTypeFirstSkuSkusRestClient.GetNestedResourceTypeFirst(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, sku, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NestedResourceTypeFirstSkuResource>(response.GetRawResponse());
                return Response.FromValue(new NestedResourceTypeFirstSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NestedResourceTypeFirstSkuResource> IEnumerable<NestedResourceTypeFirstSkuResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NestedResourceTypeFirstSkuResource> IAsyncEnumerable<NestedResourceTypeFirstSkuResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
