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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ScopeConnectionResource"/> and their operations.
    /// Each <see cref="ScopeConnectionResource"/> in the collection will belong to the same instance of <see cref="NetworkManagerResource"/>.
    /// To get a <see cref="ScopeConnectionCollection"/> instance call the GetScopeConnections method from an instance of <see cref="NetworkManagerResource"/>.
    /// </summary>
    public partial class ScopeConnectionCollection : ArmCollection, IEnumerable<ScopeConnectionResource>, IAsyncEnumerable<ScopeConnectionResource>
    {
        private readonly ClientDiagnostics _scopeConnectionClientDiagnostics;
        private readonly ScopeConnectionsRestOperations _scopeConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScopeConnectionCollection"/> class for mocking. </summary>
        protected ScopeConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScopeConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScopeConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scopeConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ScopeConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScopeConnectionResource.ResourceType, out string scopeConnectionApiVersion);
            _scopeConnectionRestClient = new ScopeConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scopeConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkManagerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkManagerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates scope connection from Network Manager
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/scopeConnections/{scopeConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeConnections_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scopeConnectionName"> Name for the cross-tenant connection. </param>
        /// <param name="data"> Scope connection to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScopeConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scopeConnectionName, ScopeConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeConnectionName, nameof(scopeConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scopeConnectionClientDiagnostics.CreateScope("ScopeConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scopeConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ScopeConnectionResource>(Response.FromValue(new ScopeConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates scope connection from Network Manager
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/scopeConnections/{scopeConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeConnections_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scopeConnectionName"> Name for the cross-tenant connection. </param>
        /// <param name="data"> Scope connection to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScopeConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string scopeConnectionName, ScopeConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeConnectionName, nameof(scopeConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scopeConnectionClientDiagnostics.CreateScope("ScopeConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scopeConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeConnectionName, data, cancellationToken);
                var operation = new NetworkArmOperation<ScopeConnectionResource>(Response.FromValue(new ScopeConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Get specified scope connection created by this Network Manager.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/scopeConnections/{scopeConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeConnectionName"> Name for the cross-tenant connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeConnectionName"/> is null. </exception>
        public virtual async Task<Response<ScopeConnectionResource>> GetAsync(string scopeConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeConnectionName, nameof(scopeConnectionName));

            using var scope = _scopeConnectionClientDiagnostics.CreateScope("ScopeConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _scopeConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScopeConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get specified scope connection created by this Network Manager.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/scopeConnections/{scopeConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeConnectionName"> Name for the cross-tenant connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeConnectionName"/> is null. </exception>
        public virtual Response<ScopeConnectionResource> Get(string scopeConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeConnectionName, nameof(scopeConnectionName));

            using var scope = _scopeConnectionClientDiagnostics.CreateScope("ScopeConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _scopeConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScopeConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all scope connections created by this network manager.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/scopeConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeConnections_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScopeConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScopeConnectionResource> GetAllAsync(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scopeConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scopeConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScopeConnectionResource(Client, ScopeConnectionData.DeserializeScopeConnectionData(e)), _scopeConnectionClientDiagnostics, Pipeline, "ScopeConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all scope connections created by this network manager.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/scopeConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeConnections_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScopeConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScopeConnectionResource> GetAll(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scopeConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scopeConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScopeConnectionResource(Client, ScopeConnectionData.DeserializeScopeConnectionData(e)), _scopeConnectionClientDiagnostics, Pipeline, "ScopeConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/scopeConnections/{scopeConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeConnectionName"> Name for the cross-tenant connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scopeConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeConnectionName, nameof(scopeConnectionName));

            using var scope = _scopeConnectionClientDiagnostics.CreateScope("ScopeConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scopeConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/scopeConnections/{scopeConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeConnectionName"> Name for the cross-tenant connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string scopeConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeConnectionName, nameof(scopeConnectionName));

            using var scope = _scopeConnectionClientDiagnostics.CreateScope("ScopeConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _scopeConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeConnectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/scopeConnections/{scopeConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeConnectionName"> Name for the cross-tenant connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeConnectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<ScopeConnectionResource>> GetIfExistsAsync(string scopeConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeConnectionName, nameof(scopeConnectionName));

            using var scope = _scopeConnectionClientDiagnostics.CreateScope("ScopeConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _scopeConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ScopeConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new ScopeConnectionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/scopeConnections/{scopeConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScopeConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeConnectionName"> Name for the cross-tenant connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeConnectionName"/> is null. </exception>
        public virtual NullableResponse<ScopeConnectionResource> GetIfExists(string scopeConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeConnectionName, nameof(scopeConnectionName));

            using var scope = _scopeConnectionClientDiagnostics.CreateScope("ScopeConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _scopeConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scopeConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ScopeConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new ScopeConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScopeConnectionResource> IEnumerable<ScopeConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScopeConnectionResource> IAsyncEnumerable<ScopeConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
