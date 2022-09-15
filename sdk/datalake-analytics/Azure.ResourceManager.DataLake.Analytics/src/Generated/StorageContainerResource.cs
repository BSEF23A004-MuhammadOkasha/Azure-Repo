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
using Azure.ResourceManager.DataLake.Analytics.Models;

namespace Azure.ResourceManager.DataLake.Analytics
{
    /// <summary>
    /// A Class representing a StorageContainer along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="StorageContainerResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetStorageContainerResource method.
    /// Otherwise you can get one from its parent resource <see cref="StorageAccountInformationResource" /> using the GetStorageContainer method.
    /// </summary>
    public partial class StorageContainerResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StorageContainerResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string storageAccountName, string containerName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}/containers/{containerName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _storageContainerStorageAccountsClientDiagnostics;
        private readonly StorageAccountsRestOperations _storageContainerStorageAccountsRestClient;
        private readonly StorageContainerData _data;

        /// <summary> Initializes a new instance of the <see cref="StorageContainerResource"/> class for mocking. </summary>
        protected StorageContainerResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StorageContainerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StorageContainerResource(ArmClient client, StorageContainerData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StorageContainerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StorageContainerResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageContainerStorageAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLake.Analytics", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string storageContainerStorageAccountsApiVersion);
            _storageContainerStorageAccountsRestClient = new StorageAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageContainerStorageAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataLakeAnalytics/accounts/storageAccounts/containers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StorageContainerData Data
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

        /// <summary>
        /// Gets the specified Azure Storage container associated with the given Data Lake Analytics and Azure Storage accounts.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}/containers/{containerName}
        /// Operation Id: StorageAccounts_GetStorageContainer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageContainerResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _storageContainerStorageAccountsClientDiagnostics.CreateScope("StorageContainerResource.Get");
            scope.Start();
            try
            {
                var response = await _storageContainerStorageAccountsRestClient.GetStorageContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Azure Storage container associated with the given Data Lake Analytics and Azure Storage accounts.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}/containers/{containerName}
        /// Operation Id: StorageAccounts_GetStorageContainer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageContainerResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _storageContainerStorageAccountsClientDiagnostics.CreateScope("StorageContainerResource.Get");
            scope.Start();
            try
            {
                var response = _storageContainerStorageAccountsRestClient.GetStorageContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the SAS token associated with the specified Data Lake Analytics and Azure Storage account and container combination.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}/containers/{containerName}/listSasTokens
        /// Operation Id: StorageAccounts_ListSasTokens
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SasTokenInformation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SasTokenInformation> GetSasTokensAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SasTokenInformation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _storageContainerStorageAccountsClientDiagnostics.CreateScope("StorageContainerResource.GetSasTokens");
                scope.Start();
                try
                {
                    var response = await _storageContainerStorageAccountsRestClient.ListSasTokensAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SasTokenInformation>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _storageContainerStorageAccountsClientDiagnostics.CreateScope("StorageContainerResource.GetSasTokens");
                scope.Start();
                try
                {
                    var response = await _storageContainerStorageAccountsRestClient.ListSasTokensNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Gets the SAS token associated with the specified Data Lake Analytics and Azure Storage account and container combination.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}/containers/{containerName}/listSasTokens
        /// Operation Id: StorageAccounts_ListSasTokens
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SasTokenInformation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SasTokenInformation> GetSasTokens(CancellationToken cancellationToken = default)
        {
            Page<SasTokenInformation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _storageContainerStorageAccountsClientDiagnostics.CreateScope("StorageContainerResource.GetSasTokens");
                scope.Start();
                try
                {
                    var response = _storageContainerStorageAccountsRestClient.ListSasTokens(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SasTokenInformation> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _storageContainerStorageAccountsClientDiagnostics.CreateScope("StorageContainerResource.GetSasTokens");
                scope.Start();
                try
                {
                    var response = _storageContainerStorageAccountsRestClient.ListSasTokensNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
