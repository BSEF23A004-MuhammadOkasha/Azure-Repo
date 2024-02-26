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

namespace Azure.ResourceManager.MixedReality
{
    /// <summary>
    /// A class representing a collection of <see cref="SpatialAnchorsAccountResource"/> and their operations.
    /// Each <see cref="SpatialAnchorsAccountResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="SpatialAnchorsAccountCollection"/> instance call the GetSpatialAnchorsAccounts method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class SpatialAnchorsAccountCollection : ArmCollection, IEnumerable<SpatialAnchorsAccountResource>, IAsyncEnumerable<SpatialAnchorsAccountResource>
    {
        private readonly ClientDiagnostics _spatialAnchorsAccountClientDiagnostics;
        private readonly SpatialAnchorsAccountsRestOperations _spatialAnchorsAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="SpatialAnchorsAccountCollection"/> class for mocking. </summary>
        protected SpatialAnchorsAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SpatialAnchorsAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SpatialAnchorsAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _spatialAnchorsAccountClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MixedReality", SpatialAnchorsAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SpatialAnchorsAccountResource.ResourceType, out string spatialAnchorsAccountApiVersion);
            _spatialAnchorsAccountRestClient = new SpatialAnchorsAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, spatialAnchorsAccountApiVersion);
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
        /// Creating or Updating a Spatial Anchors Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpatialAnchorsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="data"> Spatial Anchors Account parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SpatialAnchorsAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string accountName, SpatialAnchorsAccountData data, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _spatialAnchorsAccountRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MixedRealityArmOperation<SpatialAnchorsAccountResource>(Response.FromValue(new SpatialAnchorsAccountResource(Client, response), response.GetRawResponse()));
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
        /// Creating or Updating a Spatial Anchors Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpatialAnchorsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="data"> Spatial Anchors Account parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SpatialAnchorsAccountResource> CreateOrUpdate(WaitUntil waitUntil, string accountName, SpatialAnchorsAccountData data, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _spatialAnchorsAccountRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, accountName, data, cancellationToken);
                var operation = new MixedRealityArmOperation<SpatialAnchorsAccountResource>(Response.FromValue(new SpatialAnchorsAccountResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve a Spatial Anchors Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpatialAnchorsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<SpatialAnchorsAccountResource>> GetAsync(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _spatialAnchorsAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SpatialAnchorsAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a Spatial Anchors Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpatialAnchorsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<SpatialAnchorsAccountResource> Get(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _spatialAnchorsAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SpatialAnchorsAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Resources by Resource Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpatialAnchorsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SpatialAnchorsAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SpatialAnchorsAccountResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _spatialAnchorsAccountRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _spatialAnchorsAccountRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SpatialAnchorsAccountResource(Client, SpatialAnchorsAccountData.DeserializeSpatialAnchorsAccountData(e)), _spatialAnchorsAccountClientDiagnostics, Pipeline, "SpatialAnchorsAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Resources by Resource Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpatialAnchorsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SpatialAnchorsAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SpatialAnchorsAccountResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _spatialAnchorsAccountRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _spatialAnchorsAccountRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SpatialAnchorsAccountResource(Client, SpatialAnchorsAccountData.DeserializeSpatialAnchorsAccountData(e)), _spatialAnchorsAccountClientDiagnostics, Pipeline, "SpatialAnchorsAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpatialAnchorsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _spatialAnchorsAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpatialAnchorsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<bool> Exists(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _spatialAnchorsAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpatialAnchorsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<NullableResponse<SpatialAnchorsAccountResource>> GetIfExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _spatialAnchorsAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SpatialAnchorsAccountResource>(response.GetRawResponse());
                return Response.FromValue(new SpatialAnchorsAccountResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/spatialAnchorsAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpatialAnchorsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual NullableResponse<SpatialAnchorsAccountResource> GetIfExists(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var scope = _spatialAnchorsAccountClientDiagnostics.CreateScope("SpatialAnchorsAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _spatialAnchorsAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SpatialAnchorsAccountResource>(response.GetRawResponse());
                return Response.FromValue(new SpatialAnchorsAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SpatialAnchorsAccountResource> IEnumerable<SpatialAnchorsAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SpatialAnchorsAccountResource> IAsyncEnumerable<SpatialAnchorsAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
