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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    /// <summary>
    /// A class representing a collection of <see cref="VaultModelResource" /> and their operations.
    /// Each <see cref="VaultModelResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="VaultModelCollection" /> instance call the GetVaultModels method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class VaultModelCollection : ArmCollection, IEnumerable<VaultModelResource>, IAsyncEnumerable<VaultModelResource>
    {
        private readonly ClientDiagnostics _vaultModelVaultClientDiagnostics;
        private readonly VaultRestOperations _vaultModelVaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="VaultModelCollection"/> class for mocking. </summary>
        protected VaultModelCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VaultModelCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VaultModelCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vaultModelVaultClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", VaultModelResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VaultModelResource.ResourceType, out string vaultModelVaultApiVersion);
            _vaultModelVaultRestClient = new VaultRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vaultModelVaultApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="data"> Vault properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VaultModelResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vaultName, VaultModelData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vaultModelVaultClientDiagnostics.CreateScope("VaultModelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vaultModelVaultRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesDataReplicationArmOperation<VaultModelResource>(new VaultModelOperationSource(Client), _vaultModelVaultClientDiagnostics, Pipeline, _vaultModelVaultRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="data"> Vault properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VaultModelResource> CreateOrUpdate(WaitUntil waitUntil, string vaultName, VaultModelData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vaultModelVaultClientDiagnostics.CreateScope("VaultModelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vaultModelVaultRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data, cancellationToken);
                var operation = new RecoveryServicesDataReplicationArmOperation<VaultModelResource>(new VaultModelOperationSource(Client), _vaultModelVaultClientDiagnostics, Pipeline, _vaultModelVaultRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<VaultModelResource>> GetAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _vaultModelVaultClientDiagnostics.CreateScope("VaultModelCollection.Get");
            scope.Start();
            try
            {
                var response = await _vaultModelVaultRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VaultModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual Response<VaultModelResource> Get(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _vaultModelVaultClientDiagnostics.CreateScope("VaultModelCollection.Get");
            scope.Start();
            try
            {
                var response = _vaultModelVaultRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VaultModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of vaults in the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> Continuation token from the previous call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VaultModelResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VaultModelResource> GetAllAsync(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vaultModelVaultRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vaultModelVaultRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, continuationToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VaultModelResource(Client, VaultModelData.DeserializeVaultModelData(e)), _vaultModelVaultClientDiagnostics, Pipeline, "VaultModelCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of vaults in the given subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> Continuation token from the previous call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VaultModelResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VaultModelResource> GetAll(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vaultModelVaultRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vaultModelVaultRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, continuationToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VaultModelResource(Client, VaultModelData.DeserializeVaultModelData(e)), _vaultModelVaultClientDiagnostics, Pipeline, "VaultModelCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _vaultModelVaultClientDiagnostics.CreateScope("VaultModelCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vaultModelVaultRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual Response<bool> Exists(string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _vaultModelVaultClientDiagnostics.CreateScope("VaultModelCollection.Exists");
            scope.Start();
            try
            {
                var response = _vaultModelVaultRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VaultModelResource> IEnumerable<VaultModelResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VaultModelResource> IAsyncEnumerable<VaultModelResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
