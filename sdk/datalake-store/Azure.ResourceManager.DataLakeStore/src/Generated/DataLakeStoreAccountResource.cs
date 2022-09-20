// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataLakeStore.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataLakeStore
{
    /// <summary>
    /// A Class representing a DataLakeStoreAccount along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DataLakeStoreAccountResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDataLakeStoreAccountResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetDataLakeStoreAccount method.
    /// </summary>
    public partial class DataLakeStoreAccountResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataLakeStoreAccountResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataLakeStoreAccountAccountsClientDiagnostics;
        private readonly AccountsRestOperations _dataLakeStoreAccountAccountsRestClient;
        private readonly DataLakeStoreAccountData _data;

        /// <summary> Initializes a new instance of the <see cref="DataLakeStoreAccountResource"/> class for mocking. </summary>
        protected DataLakeStoreAccountResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataLakeStoreAccountResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataLakeStoreAccountResource(ArmClient client, DataLakeStoreAccountData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeStoreAccountResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataLakeStoreAccountResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataLakeStoreAccountAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeStore", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataLakeStoreAccountAccountsApiVersion);
            _dataLakeStoreAccountAccountsRestClient = new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataLakeStoreAccountAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataLakeStore/accounts";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataLakeStoreAccountData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of FirewallRuleResources in the DataLakeStoreAccount. </summary>
        /// <returns> An object representing collection of FirewallRuleResources and their operations over a FirewallRuleResource. </returns>
        public virtual FirewallRuleCollection GetFirewallRules()
        {
            return GetCachedClient(Client => new FirewallRuleCollection(Client, Id));
        }

        /// <summary>
        /// Gets the specified Data Lake Store firewall rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/firewallRules/{firewallRuleName}
        /// Operation Id: FirewallRules_Get
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<FirewallRuleResource>> GetFirewallRuleAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            return await GetFirewallRules().GetAsync(firewallRuleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Data Lake Store firewall rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/firewallRules/{firewallRuleName}
        /// Operation Id: FirewallRules_Get
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<FirewallRuleResource> GetFirewallRule(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            return GetFirewallRules().Get(firewallRuleName, cancellationToken);
        }

        /// <summary> Gets a collection of VirtualNetworkRuleResources in the DataLakeStoreAccount. </summary>
        /// <returns> An object representing collection of VirtualNetworkRuleResources and their operations over a VirtualNetworkRuleResource. </returns>
        public virtual VirtualNetworkRuleCollection GetVirtualNetworkRules()
        {
            return GetCachedClient(Client => new VirtualNetworkRuleCollection(Client, Id));
        }

        /// <summary>
        /// Gets the specified Data Lake Store virtual network rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<VirtualNetworkRuleResource>> GetVirtualNetworkRuleAsync(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            return await GetVirtualNetworkRules().GetAsync(virtualNetworkRuleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Data Lake Store virtual network rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<VirtualNetworkRuleResource> GetVirtualNetworkRule(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            return GetVirtualNetworkRules().Get(virtualNetworkRuleName, cancellationToken);
        }

        /// <summary> Gets a collection of TrustedIdProviderResources in the DataLakeStoreAccount. </summary>
        /// <returns> An object representing collection of TrustedIdProviderResources and their operations over a TrustedIdProviderResource. </returns>
        public virtual TrustedIdProviderCollection GetTrustedIdProviders()
        {
            return GetCachedClient(Client => new TrustedIdProviderCollection(Client, Id));
        }

        /// <summary>
        /// Gets the specified Data Lake Store trusted identity provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}
        /// Operation Id: TrustedIdProviders_Get
        /// </summary>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TrustedIdProviderResource>> GetTrustedIdProviderAsync(string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            return await GetTrustedIdProviders().GetAsync(trustedIdProviderName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Data Lake Store trusted identity provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/trustedIdProviders/{trustedIdProviderName}
        /// Operation Id: TrustedIdProviders_Get
        /// </summary>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedIdProviderName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<TrustedIdProviderResource> GetTrustedIdProvider(string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            return GetTrustedIdProviders().Get(trustedIdProviderName, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Data Lake Store account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataLakeStoreAccountResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountResource.Get");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Data Lake Store account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataLakeStoreAccountResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountResource.Get");
            scope.Start();
            try
            {
                var response = _dataLakeStoreAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified Data Lake Store account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}
        /// Operation Id: Accounts_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountResource.Delete");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreAccountAccountsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeStoreArmOperation(_dataLakeStoreAccountAccountsClientDiagnostics, Pipeline, _dataLakeStoreAccountAccountsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified Data Lake Store account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}
        /// Operation Id: Accounts_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountResource.Delete");
            scope.Start();
            try
            {
                var response = _dataLakeStoreAccountAccountsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new DataLakeStoreArmOperation(_dataLakeStoreAccountAccountsClientDiagnostics, Pipeline, _dataLakeStoreAccountAccountsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the specified Data Lake Store account information.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}
        /// Operation Id: Accounts_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Parameters supplied to update the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<DataLakeStoreAccountResource>> UpdateAsync(WaitUntil waitUntil, DataLakeStoreAccountPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountResource.Update");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreAccountAccountsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeStoreArmOperation<DataLakeStoreAccountResource>(new DataLakeStoreAccountOperationSource(Client), _dataLakeStoreAccountAccountsClientDiagnostics, Pipeline, _dataLakeStoreAccountAccountsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Updates the specified Data Lake Store account information.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}
        /// Operation Id: Accounts_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Parameters supplied to update the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<DataLakeStoreAccountResource> Update(WaitUntil waitUntil, DataLakeStoreAccountPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountResource.Update");
            scope.Start();
            try
            {
                var response = _dataLakeStoreAccountAccountsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken);
                var operation = new DataLakeStoreArmOperation<DataLakeStoreAccountResource>(new DataLakeStoreAccountOperationSource(Client), _dataLakeStoreAccountAccountsClientDiagnostics, Pipeline, _dataLakeStoreAccountAccountsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Attempts to enable a user managed Key Vault for encryption of the specified Data Lake Store account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/enableKeyVault
        /// Operation Id: Accounts_EnableKeyVault
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> EnableKeyVaultAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountResource.EnableKeyVault");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreAccountAccountsRestClient.EnableKeyVaultAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Attempts to enable a user managed Key Vault for encryption of the specified Data Lake Store account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/enableKeyVault
        /// Operation Id: Accounts_EnableKeyVault
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response EnableKeyVault(CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeStoreAccountAccountsClientDiagnostics.CreateScope("DataLakeStoreAccountResource.EnableKeyVault");
            scope.Start();
            try
            {
                var response = _dataLakeStoreAccountAccountsRestClient.EnableKeyVault(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
