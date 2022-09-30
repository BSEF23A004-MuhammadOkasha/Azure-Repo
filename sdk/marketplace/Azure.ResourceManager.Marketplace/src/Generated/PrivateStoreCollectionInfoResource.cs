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
using Azure.ResourceManager.Marketplace.Models;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A Class representing a PrivateStoreCollectionInfo along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PrivateStoreCollectionInfoResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPrivateStoreCollectionInfoResource method.
    /// Otherwise you can get one from its parent resource <see cref="PrivateStoreResource" /> using the GetPrivateStoreCollectionInfo method.
    /// </summary>
    public partial class PrivateStoreCollectionInfoResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PrivateStoreCollectionInfoResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(Guid privateStoreId, Guid collectionId)
        {
            var resourceId = $"/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics;
        private readonly PrivateStoreCollectionRestOperations _privateStoreCollectionInfoPrivateStoreCollectionRestClient;
        private readonly PrivateStoreCollectionInfoData _data;

        /// <summary> Initializes a new instance of the <see cref="PrivateStoreCollectionInfoResource"/> class for mocking. </summary>
        protected PrivateStoreCollectionInfoResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PrivateStoreCollectionInfoResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PrivateStoreCollectionInfoResource(ArmClient client, PrivateStoreCollectionInfoData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateStoreCollectionInfoResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PrivateStoreCollectionInfoResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Marketplace", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string privateStoreCollectionInfoPrivateStoreCollectionApiVersion);
            _privateStoreCollectionInfoPrivateStoreCollectionRestClient = new PrivateStoreCollectionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, privateStoreCollectionInfoPrivateStoreCollectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Marketplace/privateStores/collections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PrivateStoreCollectionInfoData Data
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

        /// <summary> Gets a collection of PrivateStoreOfferResources in the PrivateStoreCollectionInfo. </summary>
        /// <returns> An object representing collection of PrivateStoreOfferResources and their operations over a PrivateStoreOfferResource. </returns>
        public virtual PrivateStoreOfferCollection GetPrivateStoreOffers()
        {
            return GetCachedClient(Client => new PrivateStoreOfferCollection(Client, Id));
        }

        /// <summary>
        /// Gets information about a specific offer.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}
        /// Operation Id: PrivateStoreCollectionOffer_Get
        /// </summary>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PrivateStoreOfferResource>> GetPrivateStoreOfferAsync(string offerId, CancellationToken cancellationToken = default)
        {
            return await GetPrivateStoreOffers().GetAsync(offerId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a specific offer.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}
        /// Operation Id: PrivateStoreCollectionOffer_Get
        /// </summary>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<PrivateStoreOfferResource> GetPrivateStoreOffer(string offerId, CancellationToken cancellationToken = default)
        {
            return GetPrivateStoreOffers().Get(offerId, cancellationToken);
        }

        /// <summary>
        /// Gets private store collection
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}
        /// Operation Id: PrivateStoreCollection_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateStoreCollectionInfoResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.Get");
            scope.Start();
            try
            {
                var response = await _privateStoreCollectionInfoPrivateStoreCollectionRestClient.GetAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateStoreCollectionInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets private store collection
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}
        /// Operation Id: PrivateStoreCollection_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateStoreCollectionInfoResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.Get");
            scope.Start();
            try
            {
                var response = _privateStoreCollectionInfoPrivateStoreCollectionRestClient.Get(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateStoreCollectionInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a collection from the given private store.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}
        /// Operation Id: PrivateStoreCollection_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.Delete");
            scope.Start();
            try
            {
                var response = await _privateStoreCollectionInfoPrivateStoreCollectionRestClient.DeleteAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                var operation = new MarketplaceArmOperation(response);
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
        /// Delete a collection from the given private store.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}
        /// Operation Id: PrivateStoreCollection_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.Delete");
            scope.Start();
            try
            {
                var response = _privateStoreCollectionInfoPrivateStoreCollectionRestClient.Delete(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken);
                var operation = new MarketplaceArmOperation(response);
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
        /// Create or update private store collection
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}
        /// Operation Id: PrivateStoreCollection_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> The PrivateStoreCollectionInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateStoreCollectionInfoResource>> UpdateAsync(WaitUntil waitUntil, PrivateStoreCollectionInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.Update");
            scope.Start();
            try
            {
                var response = await _privateStoreCollectionInfoPrivateStoreCollectionRestClient.CreateOrUpdateAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), info, cancellationToken).ConfigureAwait(false);
                var operation = new MarketplaceArmOperation<PrivateStoreCollectionInfoResource>(Response.FromValue(new PrivateStoreCollectionInfoResource(Client, response), response.GetRawResponse()));
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
        /// Create or update private store collection
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}
        /// Operation Id: PrivateStoreCollection_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> The PrivateStoreCollectionInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        public virtual ArmOperation<PrivateStoreCollectionInfoResource> Update(WaitUntil waitUntil, PrivateStoreCollectionInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.Update");
            scope.Start();
            try
            {
                var response = _privateStoreCollectionInfoPrivateStoreCollectionRestClient.CreateOrUpdate(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), info, cancellationToken);
                var operation = new MarketplaceArmOperation<PrivateStoreCollectionInfoResource>(Response.FromValue(new PrivateStoreCollectionInfoResource(Client, response), response.GetRawResponse()));
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
        /// transferring offers (copy or move) from source collection to target collection(s)
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/transferOffers
        /// Operation Id: PrivateStoreCollection_TransferOffers
        /// </summary>
        /// <param name="content"> The TransferOffersContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TransferOffersResult>> TransferOffersAsync(TransferOffersContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.TransferOffers");
            scope.Start();
            try
            {
                var response = await _privateStoreCollectionInfoPrivateStoreCollectionRestClient.TransferOffersAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// transferring offers (copy or move) from source collection to target collection(s)
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/transferOffers
        /// Operation Id: PrivateStoreCollection_TransferOffers
        /// </summary>
        /// <param name="content"> The TransferOffersContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TransferOffersResult> TransferOffers(TransferOffersContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.TransferOffers");
            scope.Start();
            try
            {
                var response = _privateStoreCollectionInfoPrivateStoreCollectionRestClient.TransferOffers(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete all existing offers from the collection and enable approve all items.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/approveAllItems
        /// Operation Id: PrivateStoreCollection_ApproveAllItems
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateStoreCollectionInfoResource>> ApproveAllItemsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.ApproveAllItems");
            scope.Start();
            try
            {
                var response = await _privateStoreCollectionInfoPrivateStoreCollectionRestClient.ApproveAllItemsAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PrivateStoreCollectionInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete all existing offers from the collection and enable approve all items.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/approveAllItems
        /// Operation Id: PrivateStoreCollection_ApproveAllItems
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateStoreCollectionInfoResource> ApproveAllItems(CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.ApproveAllItems");
            scope.Start();
            try
            {
                var response = _privateStoreCollectionInfoPrivateStoreCollectionRestClient.ApproveAllItems(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken);
                return Response.FromValue(new PrivateStoreCollectionInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Disable approve all items for the collection.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/disableApproveAllItems
        /// Operation Id: PrivateStoreCollection_DisableApproveAllItems
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateStoreCollectionInfoResource>> DisableApproveAllItemsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.DisableApproveAllItems");
            scope.Start();
            try
            {
                var response = await _privateStoreCollectionInfoPrivateStoreCollectionRestClient.DisableApproveAllItemsAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PrivateStoreCollectionInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Disable approve all items for the collection.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/disableApproveAllItems
        /// Operation Id: PrivateStoreCollection_DisableApproveAllItems
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateStoreCollectionInfoResource> DisableApproveAllItems(CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.DisableApproveAllItems");
            scope.Start();
            try
            {
                var response = _privateStoreCollectionInfoPrivateStoreCollectionRestClient.DisableApproveAllItems(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), cancellationToken);
                return Response.FromValue(new PrivateStoreCollectionInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete Private store collection. This is a workaround.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}
        /// Operation Id: PrivateStoreCollection_Post
        /// </summary>
        /// <param name="payload"> The PrivateStoreOperation to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(PrivateStoreOperation? payload = null, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.Delete");
            scope.Start();
            try
            {
                var response = await _privateStoreCollectionInfoPrivateStoreCollectionRestClient.PostAsync(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), payload, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete Private store collection. This is a workaround.
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}
        /// Operation Id: PrivateStoreCollection_Post
        /// </summary>
        /// <param name="payload"> The PrivateStoreOperation to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(PrivateStoreOperation? payload = null, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreCollectionInfoPrivateStoreCollectionClientDiagnostics.CreateScope("PrivateStoreCollectionInfoResource.Delete");
            scope.Start();
            try
            {
                var response = _privateStoreCollectionInfoPrivateStoreCollectionRestClient.Post(Guid.Parse(Id.Parent.Name), Guid.Parse(Id.Name), payload, cancellationToken);
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
