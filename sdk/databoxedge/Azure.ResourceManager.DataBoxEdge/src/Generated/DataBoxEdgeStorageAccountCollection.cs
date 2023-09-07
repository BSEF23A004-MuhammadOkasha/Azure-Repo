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

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing a collection of <see cref="DataBoxEdgeStorageAccountResource" /> and their operations.
    /// Each <see cref="DataBoxEdgeStorageAccountResource" /> in the collection will belong to the same instance of <see cref="DataBoxEdgeDeviceResource" />.
    /// To get a <see cref="DataBoxEdgeStorageAccountCollection" /> instance call the GetDataBoxEdgeStorageAccounts method from an instance of <see cref="DataBoxEdgeDeviceResource" />.
    /// </summary>
    public partial class DataBoxEdgeStorageAccountCollection : ArmCollection, IEnumerable<DataBoxEdgeStorageAccountResource>, IAsyncEnumerable<DataBoxEdgeStorageAccountResource>
    {
        private readonly ClientDiagnostics _dataBoxEdgeStorageAccountStorageAccountsClientDiagnostics;
        private readonly StorageAccountsRestOperations _dataBoxEdgeStorageAccountStorageAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeStorageAccountCollection"/> class for mocking. </summary>
        protected DataBoxEdgeStorageAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeStorageAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataBoxEdgeStorageAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataBoxEdgeStorageAccountStorageAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", DataBoxEdgeStorageAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataBoxEdgeStorageAccountResource.ResourceType, out string dataBoxEdgeStorageAccountStorageAccountsApiVersion);
            _dataBoxEdgeStorageAccountStorageAccountsRestClient = new StorageAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataBoxEdgeStorageAccountStorageAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataBoxEdgeDeviceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataBoxEdgeDeviceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new StorageAccount or updates an existing StorageAccount on the device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageAccountName"> The StorageAccount name. </param>
        /// <param name="data"> The StorageAccount properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataBoxEdgeStorageAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageAccountName, DataBoxEdgeStorageAccountData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeStorageAccountStorageAccountsClientDiagnostics.CreateScope("DataBoxEdgeStorageAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeStorageAccountStorageAccountsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeStorageAccountResource>(new DataBoxEdgeStorageAccountOperationSource(Client), _dataBoxEdgeStorageAccountStorageAccountsClientDiagnostics, Pipeline, _dataBoxEdgeStorageAccountStorageAccountsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new StorageAccount or updates an existing StorageAccount on the device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageAccountName"> The StorageAccount name. </param>
        /// <param name="data"> The StorageAccount properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataBoxEdgeStorageAccountResource> CreateOrUpdate(WaitUntil waitUntil, string storageAccountName, DataBoxEdgeStorageAccountData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeStorageAccountStorageAccountsClientDiagnostics.CreateScope("DataBoxEdgeStorageAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeStorageAccountStorageAccountsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, data, cancellationToken);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeStorageAccountResource>(new DataBoxEdgeStorageAccountOperationSource(Client), _dataBoxEdgeStorageAccountStorageAccountsClientDiagnostics, Pipeline, _dataBoxEdgeStorageAccountStorageAccountsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a StorageAccount by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageAccountName"> The storage account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual async Task<Response<DataBoxEdgeStorageAccountResource>> GetAsync(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _dataBoxEdgeStorageAccountStorageAccountsClientDiagnostics.CreateScope("DataBoxEdgeStorageAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeStorageAccountStorageAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeStorageAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a StorageAccount by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageAccountName"> The storage account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual Response<DataBoxEdgeStorageAccountResource> Get(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _dataBoxEdgeStorageAccountStorageAccountsClientDiagnostics.CreateScope("DataBoxEdgeStorageAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeStorageAccountStorageAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeStorageAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the StorageAccounts in a Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_ListByDataBoxEdgeDevice</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataBoxEdgeStorageAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataBoxEdgeStorageAccountResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataBoxEdgeStorageAccountStorageAccountsRestClient.CreateListByDataBoxEdgeDeviceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataBoxEdgeStorageAccountStorageAccountsRestClient.CreateListByDataBoxEdgeDeviceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataBoxEdgeStorageAccountResource(Client, DataBoxEdgeStorageAccountData.DeserializeDataBoxEdgeStorageAccountData(e)), _dataBoxEdgeStorageAccountStorageAccountsClientDiagnostics, Pipeline, "DataBoxEdgeStorageAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the StorageAccounts in a Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_ListByDataBoxEdgeDevice</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataBoxEdgeStorageAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataBoxEdgeStorageAccountResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataBoxEdgeStorageAccountStorageAccountsRestClient.CreateListByDataBoxEdgeDeviceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataBoxEdgeStorageAccountStorageAccountsRestClient.CreateListByDataBoxEdgeDeviceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataBoxEdgeStorageAccountResource(Client, DataBoxEdgeStorageAccountData.DeserializeDataBoxEdgeStorageAccountData(e)), _dataBoxEdgeStorageAccountStorageAccountsClientDiagnostics, Pipeline, "DataBoxEdgeStorageAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageAccountName"> The storage account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _dataBoxEdgeStorageAccountStorageAccountsClientDiagnostics.CreateScope("DataBoxEdgeStorageAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeStorageAccountStorageAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageAccountName"> The storage account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageAccountName, nameof(storageAccountName));

            using var scope = _dataBoxEdgeStorageAccountStorageAccountsClientDiagnostics.CreateScope("DataBoxEdgeStorageAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeStorageAccountStorageAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageAccountName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataBoxEdgeStorageAccountResource> IEnumerable<DataBoxEdgeStorageAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataBoxEdgeStorageAccountResource> IAsyncEnumerable<DataBoxEdgeStorageAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
