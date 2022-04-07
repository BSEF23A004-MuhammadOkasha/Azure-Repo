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

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary>
    /// A class representing a collection of <see cref="PrivateEndpointConnectionProxyResource" /> and their operations.
    /// Each <see cref="PrivateEndpointConnectionProxyResource" /> in the collection will belong to the same instance of <see cref="DeviceUpdateAccountResource" />.
    /// To get a <see cref="PrivateEndpointConnectionProxyCollection" /> instance call the GetPrivateEndpointConnectionProxies method from an instance of <see cref="DeviceUpdateAccountResource" />.
    /// </summary>
    public partial class PrivateEndpointConnectionProxyCollection : ArmCollection, IEnumerable<PrivateEndpointConnectionProxyResource>, IAsyncEnumerable<PrivateEndpointConnectionProxyResource>
    {
        private readonly ClientDiagnostics _privateEndpointConnectionProxyClientDiagnostics;
        private readonly PrivateEndpointConnectionProxiesRestOperations _privateEndpointConnectionProxyRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionProxyCollection"/> class for mocking. </summary>
        protected PrivateEndpointConnectionProxyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionProxyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PrivateEndpointConnectionProxyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateEndpointConnectionProxyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceUpdate", PrivateEndpointConnectionProxyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PrivateEndpointConnectionProxyResource.ResourceType, out string privateEndpointConnectionProxyApiVersion);
            _privateEndpointConnectionProxyRestClient = new PrivateEndpointConnectionProxiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, privateEndpointConnectionProxyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DeviceUpdateAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DeviceUpdateAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Creates or updates the specified private endpoint connection proxy resource associated with the device update account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}
        /// Operation Id: PrivateEndpointConnectionProxies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateEndpointConnectionProxyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointConnectionProxyId, PrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, data, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceUpdateArmOperation<PrivateEndpointConnectionProxyResource>(new PrivateEndpointConnectionProxyOperationSource(Client), _privateEndpointConnectionProxyClientDiagnostics, Pipeline, _privateEndpointConnectionProxyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// (INTERNAL - DO NOT USE) Creates or updates the specified private endpoint connection proxy resource associated with the device update account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}
        /// Operation Id: PrivateEndpointConnectionProxies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PrivateEndpointConnectionProxyResource> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointConnectionProxyId, PrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, data, cancellationToken);
                var operation = new DeviceUpdateArmOperation<PrivateEndpointConnectionProxyResource>(new PrivateEndpointConnectionProxyOperationSource(Client), _privateEndpointConnectionProxyClientDiagnostics, Pipeline, _privateEndpointConnectionProxyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}
        /// Operation Id: PrivateEndpointConnectionProxies_Get
        /// </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public virtual async Task<Response<PrivateEndpointConnectionProxyResource>> GetAsync(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnectionProxyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}
        /// Operation Id: PrivateEndpointConnectionProxies_Get
        /// </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public virtual Response<PrivateEndpointConnectionProxyResource> Get(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.Get");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnectionProxyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) List all private endpoint connection proxies in a device update account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies
        /// Operation Id: PrivateEndpointConnectionProxies_ListByAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateEndpointConnectionProxyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateEndpointConnectionProxyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateEndpointConnectionProxyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateEndpointConnectionProxyRestClient.ListByAccountAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnectionProxyResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) List all private endpoint connection proxies in a device update account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies
        /// Operation Id: PrivateEndpointConnectionProxies_ListByAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateEndpointConnectionProxyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateEndpointConnectionProxyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PrivateEndpointConnectionProxyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateEndpointConnectionProxyRestClient.ListByAccount(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnectionProxyResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}
        /// Operation Id: PrivateEndpointConnectionProxies_Get
        /// </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}
        /// Operation Id: PrivateEndpointConnectionProxies_Get
        /// </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionProxyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionProxyId, nameof(privateEndpointConnectionProxyId));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.Exists");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateEndpointConnectionProxyResource> IEnumerable<PrivateEndpointConnectionProxyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateEndpointConnectionProxyResource> IAsyncEnumerable<PrivateEndpointConnectionProxyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
