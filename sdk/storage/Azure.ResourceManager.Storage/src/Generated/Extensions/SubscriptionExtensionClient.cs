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
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    internal partial class SubscriptionExtensionClient : ArmResource
    {
        private ClientDiagnostics _skusClientDiagnostics;
        private SkusRestOperations _skusRestClient;
        private ClientDiagnostics _storageAccountClientDiagnostics;
        private StorageAccountsRestOperations _storageAccountRestClient;
        private ClientDiagnostics _deletedAccountClientDiagnostics;
        private DeletedAccountsRestOperations _deletedAccountRestClient;
        private ClientDiagnostics _usagesClientDiagnostics;
        private UsagesRestOperations _usagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class for mocking. </summary>
        protected SubscriptionExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SkusClientDiagnostics => _skusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Storage", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private SkusRestOperations SkusRestClient => _skusRestClient ??= new SkusRestOperations(SkusClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics StorageAccountClientDiagnostics => _storageAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Storage", StorageAccount.ResourceType.Namespace, DiagnosticOptions);
        private StorageAccountsRestOperations StorageAccountRestClient => _storageAccountRestClient ??= new StorageAccountsRestOperations(StorageAccountClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(StorageAccount.ResourceType));
        private ClientDiagnostics DeletedAccountClientDiagnostics => _deletedAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Storage", DeletedAccount.ResourceType.Namespace, DiagnosticOptions);
        private DeletedAccountsRestOperations DeletedAccountRestClient => _deletedAccountRestClient ??= new DeletedAccountsRestOperations(DeletedAccountClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(DeletedAccount.ResourceType));
        private ClientDiagnostics UsagesClientDiagnostics => _usagesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Storage", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private UsagesRestOperations UsagesRestClient => _usagesRestClient ??= new UsagesRestOperations(UsagesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            Client.TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DeletedAccounts in the DeletedAccount. </summary>
        /// <returns> An object representing collection of DeletedAccounts and their operations over a DeletedAccount. </returns>
        public virtual DeletedAccountCollection GetDeletedAccounts()
        {
            return new DeletedAccountCollection(Client, Id);
        }

        /// <summary>
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SkuInformation> GetSkusAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SkuInformation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SkusClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetSkus");
                scope.Start();
                try
                {
                    var response = await SkusRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Lists the available SKUs supported by Microsoft.Storage for given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SkuInformation> GetSkus(CancellationToken cancellationToken = default)
        {
            Page<SkuInformation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SkusClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetSkus");
                scope.Start();
                try
                {
                    var response = SkusRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Checks that the storage account name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/checkNameAvailability
        /// Operation Id: StorageAccounts_CheckNameAvailability
        /// </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<CheckNameAvailabilityResult>> CheckStorageAccountNameAvailabilityAsync(StorageAccountCheckNameAvailabilityParameters accountName, CancellationToken cancellationToken = default)
        {
            using var scope = StorageAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.CheckStorageAccountNameAvailability");
            scope.Start();
            try
            {
                var response = await StorageAccountRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, accountName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the storage account name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/checkNameAvailability
        /// Operation Id: StorageAccounts_CheckNameAvailability
        /// </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameAvailabilityResult> CheckStorageAccountNameAvailability(StorageAccountCheckNameAvailabilityParameters accountName, CancellationToken cancellationToken = default)
        {
            using var scope = StorageAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.CheckStorageAccountNameAvailability");
            scope.Start();
            try
            {
                var response = StorageAccountRestClient.CheckNameAvailability(Id.SubscriptionId, accountName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// Operation Id: StorageAccounts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageAccount> GetStorageAccountsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StorageAccount>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = StorageAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetStorageAccounts");
                scope.Start();
                try
                {
                    var response = await StorageAccountRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StorageAccount>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = StorageAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetStorageAccounts");
                scope.Start();
                try
                {
                    var response = await StorageAccountRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all the storage accounts available under the subscription. Note that storage keys are not returned; use the ListKeys operation for this.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// Operation Id: StorageAccounts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageAccount> GetStorageAccounts(CancellationToken cancellationToken = default)
        {
            Page<StorageAccount> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = StorageAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetStorageAccounts");
                scope.Start();
                try
                {
                    var response = StorageAccountRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StorageAccount> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = StorageAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetStorageAccounts");
                scope.Start();
                try
                {
                    var response = StorageAccountRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists deleted accounts under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/deletedAccounts
        /// Operation Id: DeletedAccounts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedAccount> GetDeletedAccountsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeletedAccount>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DeletedAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeletedAccounts");
                scope.Start();
                try
                {
                    var response = await DeletedAccountRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedAccount(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeletedAccount>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DeletedAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeletedAccounts");
                scope.Start();
                try
                {
                    var response = await DeletedAccountRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedAccount(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists deleted accounts under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/deletedAccounts
        /// Operation Id: DeletedAccounts_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedAccount> GetDeletedAccounts(CancellationToken cancellationToken = default)
        {
            Page<DeletedAccount> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DeletedAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeletedAccounts");
                scope.Start();
                try
                {
                    var response = DeletedAccountRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedAccount(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeletedAccount> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DeletedAccountClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeletedAccounts");
                scope.Start();
                try
                {
                    var response = DeletedAccountRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedAccount(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// Operation Id: Usages_ListByLocation
        /// </summary>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Usage> GetUsagesByLocationAsync(string location, CancellationToken cancellationToken = default)
        {
            async Task<Page<Usage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = UsagesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetUsagesByLocation");
                scope.Start();
                try
                {
                    var response = await UsagesRestClient.ListByLocationAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// Operation Id: Usages_ListByLocation
        /// </summary>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Usage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Usage> GetUsagesByLocation(string location, CancellationToken cancellationToken = default)
        {
            Page<Usage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = UsagesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetUsagesByLocation");
                scope.Start();
                try
                {
                    var response = UsagesRestClient.ListByLocation(Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
