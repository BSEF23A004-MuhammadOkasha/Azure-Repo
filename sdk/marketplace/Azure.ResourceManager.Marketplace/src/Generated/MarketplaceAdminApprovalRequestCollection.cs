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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A class representing a collection of <see cref="MarketplaceAdminApprovalRequestResource" /> and their operations.
    /// Each <see cref="MarketplaceAdminApprovalRequestResource" /> in the collection will belong to the same instance of <see cref="PrivateStoreResource" />.
    /// To get a <see cref="MarketplaceAdminApprovalRequestCollection" /> instance call the GetMarketplaceAdminApprovalRequests method from an instance of <see cref="PrivateStoreResource" />.
    /// </summary>
    public partial class MarketplaceAdminApprovalRequestCollection : ArmCollection, IEnumerable<MarketplaceAdminApprovalRequestResource>, IAsyncEnumerable<MarketplaceAdminApprovalRequestResource>
    {
        private readonly ClientDiagnostics _marketplaceAdminApprovalRequestPrivateStoreClientDiagnostics;
        private readonly PrivateStoreRestOperations _marketplaceAdminApprovalRequestPrivateStoreRestClient;

        /// <summary> Initializes a new instance of the <see cref="MarketplaceAdminApprovalRequestCollection"/> class for mocking. </summary>
        protected MarketplaceAdminApprovalRequestCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MarketplaceAdminApprovalRequestCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MarketplaceAdminApprovalRequestCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _marketplaceAdminApprovalRequestPrivateStoreClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Marketplace", MarketplaceAdminApprovalRequestResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MarketplaceAdminApprovalRequestResource.ResourceType, out string marketplaceAdminApprovalRequestPrivateStoreApiVersion);
            _marketplaceAdminApprovalRequestPrivateStoreRestClient = new PrivateStoreRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, marketplaceAdminApprovalRequestPrivateStoreApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PrivateStoreResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PrivateStoreResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Update the admin action, weather the request is approved or rejected and the approved plans
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/adminRequestApprovals/{adminRequestApprovalId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_UpdateAdminRequestApproval</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="adminRequestApprovalId"> The admin request approval ID to get create or update. </param>
        /// <param name="data"> The MarketplaceAdminApprovalRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adminRequestApprovalId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adminRequestApprovalId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MarketplaceAdminApprovalRequestResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string adminRequestApprovalId, MarketplaceAdminApprovalRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adminRequestApprovalId, nameof(adminRequestApprovalId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _marketplaceAdminApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceAdminApprovalRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _marketplaceAdminApprovalRequestPrivateStoreRestClient.UpdateAdminRequestApprovalAsync(Guid.Parse(Id.Name), adminRequestApprovalId, data, cancellationToken).ConfigureAwait(false);
                var operation = new MarketplaceArmOperation<MarketplaceAdminApprovalRequestResource>(Response.FromValue(new MarketplaceAdminApprovalRequestResource(Client, response), response.GetRawResponse()));
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
        /// Update the admin action, weather the request is approved or rejected and the approved plans
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/adminRequestApprovals/{adminRequestApprovalId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_UpdateAdminRequestApproval</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="adminRequestApprovalId"> The admin request approval ID to get create or update. </param>
        /// <param name="data"> The MarketplaceAdminApprovalRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adminRequestApprovalId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adminRequestApprovalId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MarketplaceAdminApprovalRequestResource> CreateOrUpdate(WaitUntil waitUntil, string adminRequestApprovalId, MarketplaceAdminApprovalRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adminRequestApprovalId, nameof(adminRequestApprovalId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _marketplaceAdminApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceAdminApprovalRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _marketplaceAdminApprovalRequestPrivateStoreRestClient.UpdateAdminRequestApproval(Guid.Parse(Id.Name), adminRequestApprovalId, data, cancellationToken);
                var operation = new MarketplaceArmOperation<MarketplaceAdminApprovalRequestResource>(Response.FromValue(new MarketplaceAdminApprovalRequestResource(Client, response), response.GetRawResponse()));
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
        /// Get open approval requests
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/adminRequestApprovals/{adminRequestApprovalId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_GetAdminRequestApproval</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adminRequestApprovalId"> The admin request approval ID to get create or update. </param>
        /// <param name="publisherId"> The publisher id of this offer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adminRequestApprovalId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adminRequestApprovalId"/> or <paramref name="publisherId"/> is null. </exception>
        public virtual async Task<Response<MarketplaceAdminApprovalRequestResource>> GetAsync(string adminRequestApprovalId, string publisherId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adminRequestApprovalId, nameof(adminRequestApprovalId));
            Argument.AssertNotNull(publisherId, nameof(publisherId));

            using var scope = _marketplaceAdminApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceAdminApprovalRequestCollection.Get");
            scope.Start();
            try
            {
                var response = await _marketplaceAdminApprovalRequestPrivateStoreRestClient.GetAdminRequestApprovalAsync(Guid.Parse(Id.Name), adminRequestApprovalId, publisherId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceAdminApprovalRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get open approval requests
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/adminRequestApprovals/{adminRequestApprovalId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_GetAdminRequestApproval</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adminRequestApprovalId"> The admin request approval ID to get create or update. </param>
        /// <param name="publisherId"> The publisher id of this offer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adminRequestApprovalId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adminRequestApprovalId"/> or <paramref name="publisherId"/> is null. </exception>
        public virtual Response<MarketplaceAdminApprovalRequestResource> Get(string adminRequestApprovalId, string publisherId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adminRequestApprovalId, nameof(adminRequestApprovalId));
            Argument.AssertNotNull(publisherId, nameof(publisherId));

            using var scope = _marketplaceAdminApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceAdminApprovalRequestCollection.Get");
            scope.Start();
            try
            {
                var response = _marketplaceAdminApprovalRequestPrivateStoreRestClient.GetAdminRequestApproval(Guid.Parse(Id.Name), adminRequestApprovalId, publisherId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceAdminApprovalRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get list of admin request approvals
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/adminRequestApprovals</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_AdminRequestApprovalsList</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MarketplaceAdminApprovalRequestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MarketplaceAdminApprovalRequestResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _marketplaceAdminApprovalRequestPrivateStoreRestClient.CreateAdminRequestApprovalsListRequest(Guid.Parse(Id.Name));
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new MarketplaceAdminApprovalRequestResource(Client, MarketplaceAdminApprovalRequestData.DeserializeMarketplaceAdminApprovalRequestData(e)), _marketplaceAdminApprovalRequestPrivateStoreClientDiagnostics, Pipeline, "MarketplaceAdminApprovalRequestCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get list of admin request approvals
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/adminRequestApprovals</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_AdminRequestApprovalsList</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MarketplaceAdminApprovalRequestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MarketplaceAdminApprovalRequestResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _marketplaceAdminApprovalRequestPrivateStoreRestClient.CreateAdminRequestApprovalsListRequest(Guid.Parse(Id.Name));
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new MarketplaceAdminApprovalRequestResource(Client, MarketplaceAdminApprovalRequestData.DeserializeMarketplaceAdminApprovalRequestData(e)), _marketplaceAdminApprovalRequestPrivateStoreClientDiagnostics, Pipeline, "MarketplaceAdminApprovalRequestCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/adminRequestApprovals/{adminRequestApprovalId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_GetAdminRequestApproval</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adminRequestApprovalId"> The admin request approval ID to get create or update. </param>
        /// <param name="publisherId"> The publisher id of this offer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adminRequestApprovalId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adminRequestApprovalId"/> or <paramref name="publisherId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string adminRequestApprovalId, string publisherId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adminRequestApprovalId, nameof(adminRequestApprovalId));
            Argument.AssertNotNull(publisherId, nameof(publisherId));

            using var scope = _marketplaceAdminApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceAdminApprovalRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = await _marketplaceAdminApprovalRequestPrivateStoreRestClient.GetAdminRequestApprovalAsync(Guid.Parse(Id.Name), adminRequestApprovalId, publisherId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/adminRequestApprovals/{adminRequestApprovalId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStore_GetAdminRequestApproval</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adminRequestApprovalId"> The admin request approval ID to get create or update. </param>
        /// <param name="publisherId"> The publisher id of this offer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adminRequestApprovalId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adminRequestApprovalId"/> or <paramref name="publisherId"/> is null. </exception>
        public virtual Response<bool> Exists(string adminRequestApprovalId, string publisherId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adminRequestApprovalId, nameof(adminRequestApprovalId));
            Argument.AssertNotNull(publisherId, nameof(publisherId));

            using var scope = _marketplaceAdminApprovalRequestPrivateStoreClientDiagnostics.CreateScope("MarketplaceAdminApprovalRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = _marketplaceAdminApprovalRequestPrivateStoreRestClient.GetAdminRequestApproval(Guid.Parse(Id.Name), adminRequestApprovalId, publisherId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MarketplaceAdminApprovalRequestResource> IEnumerable<MarketplaceAdminApprovalRequestResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MarketplaceAdminApprovalRequestResource> IAsyncEnumerable<MarketplaceAdminApprovalRequestResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
