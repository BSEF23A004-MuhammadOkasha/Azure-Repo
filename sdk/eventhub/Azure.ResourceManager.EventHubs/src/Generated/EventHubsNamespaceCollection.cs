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

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing a collection of <see cref="EventHubsNamespaceResource"/> and their operations.
    /// Each <see cref="EventHubsNamespaceResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="EventHubsNamespaceCollection"/> instance call the GetEventHubsNamespaces method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class EventHubsNamespaceCollection : ArmCollection, IEnumerable<EventHubsNamespaceResource>, IAsyncEnumerable<EventHubsNamespaceResource>
    {
        private readonly ClientDiagnostics _eventHubsNamespaceNamespacesClientDiagnostics;
        private readonly NamespacesRestOperations _eventHubsNamespaceNamespacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubsNamespaceCollection"/> class for mocking. </summary>
        protected EventHubsNamespaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubsNamespaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventHubsNamespaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubsNamespaceNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubsNamespaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventHubsNamespaceResource.ResourceType, out string eventHubsNamespaceNamespacesApiVersion);
            _eventHubsNamespaceNamespacesRestClient = new NamespacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubsNamespaceNamespacesApiVersion);
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
        /// Creates or updates a namespace. Once created, this namespace's resource manifest is immutable. This operation is idempotent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="data"> Parameters for creating a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventHubsNamespaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string namespaceName, EventHubsNamespaceData data, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (namespaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(namespaceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _eventHubsNamespaceNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubsNamespaceNamespacesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation<EventHubsNamespaceResource>(new EventHubsNamespaceOperationSource(Client), _eventHubsNamespaceNamespacesClientDiagnostics, Pipeline, _eventHubsNamespaceNamespacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a namespace. Once created, this namespace's resource manifest is immutable. This operation is idempotent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="data"> Parameters for creating a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventHubsNamespaceResource> CreateOrUpdate(WaitUntil waitUntil, string namespaceName, EventHubsNamespaceData data, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (namespaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(namespaceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _eventHubsNamespaceNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubsNamespaceNamespacesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, data, cancellationToken);
                var operation = new EventHubsArmOperation<EventHubsNamespaceResource>(new EventHubsNamespaceOperationSource(Client), _eventHubsNamespaceNamespacesClientDiagnostics, Pipeline, _eventHubsNamespaceNamespacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the description of the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual async Task<Response<EventHubsNamespaceResource>> GetAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (namespaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(namespaceName));
            }

            using var scope = _eventHubsNamespaceNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubsNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsNamespaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the description of the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual Response<EventHubsNamespaceResource> Get(string namespaceName, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (namespaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(namespaceName));
            }

            using var scope = _eventHubsNamespaceNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubsNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsNamespaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the available Namespaces within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubsNamespaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubsNamespaceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsNamespaceNamespacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsNamespaceNamespacesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventHubsNamespaceResource(Client, EventHubsNamespaceData.DeserializeEventHubsNamespaceData(e)), _eventHubsNamespaceNamespacesClientDiagnostics, Pipeline, "EventHubsNamespaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the available Namespaces within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubsNamespaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubsNamespaceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsNamespaceNamespacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsNamespaceNamespacesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventHubsNamespaceResource(Client, EventHubsNamespaceData.DeserializeEventHubsNamespaceData(e)), _eventHubsNamespaceNamespacesClientDiagnostics, Pipeline, "EventHubsNamespaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (namespaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(namespaceName));
            }

            using var scope = _eventHubsNamespaceNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventHubsNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string namespaceName, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (namespaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(namespaceName));
            }

            using var scope = _eventHubsNamespaceNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventHubsNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual async Task<NullableResponse<EventHubsNamespaceResource>> GetIfExistsAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (namespaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(namespaceName));
            }

            using var scope = _eventHubsNamespaceNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _eventHubsNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<EventHubsNamespaceResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubsNamespaceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsNamespaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual NullableResponse<EventHubsNamespaceResource> GetIfExists(string namespaceName, CancellationToken cancellationToken = default)
        {
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (namespaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(namespaceName));
            }

            using var scope = _eventHubsNamespaceNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _eventHubsNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<EventHubsNamespaceResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubsNamespaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventHubsNamespaceResource> IEnumerable<EventHubsNamespaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHubsNamespaceResource> IAsyncEnumerable<EventHubsNamespaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
