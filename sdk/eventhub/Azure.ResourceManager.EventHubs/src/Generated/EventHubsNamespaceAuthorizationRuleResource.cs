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
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A Class representing an EventHubsNamespaceAuthorizationRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="EventHubsNamespaceAuthorizationRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetEventHubsNamespaceAuthorizationRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="EventHubsNamespaceResource" /> using the GetEventHubsNamespaceAuthorizationRule method.
    /// </summary>
    public partial class EventHubsNamespaceAuthorizationRuleResource : AuthorizationRuleResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EventHubsNamespaceAuthorizationRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string authorizationRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics;
        private readonly NamespacesRestOperations _eventHubsNamespaceAuthorizationRuleNamespacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubsNamespaceAuthorizationRuleResource"/> class for mocking. </summary>
        protected EventHubsNamespaceAuthorizationRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "EventHubsNamespaceAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EventHubsNamespaceAuthorizationRuleResource(ArmClient client, EventHubsAuthorizationRuleData data) : base(client, data)
        {
            _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string eventHubsNamespaceAuthorizationRuleNamespacesApiVersion);
            _eventHubsNamespaceAuthorizationRuleNamespacesRestClient = new NamespacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubsNamespaceAuthorizationRuleNamespacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubsNamespaceAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EventHubsNamespaceAuthorizationRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string eventHubsNamespaceAuthorizationRuleNamespacesApiVersion);
            _eventHubsNamespaceAuthorizationRuleNamespacesRestClient = new NamespacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubsNamespaceAuthorizationRuleNamespacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventHub/namespaces/authorizationRules";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<AuthorizationRuleResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual new async Task<Response<EventHubsNamespaceAuthorizationRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((EventHubsNamespaceAuthorizationRuleResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<AuthorizationRuleResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual new Response<EventHubsNamespaceAuthorizationRuleResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((EventHubsNamespaceAuthorizationRuleResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Deletes an AuthorizationRule for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_DeleteAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.DeleteAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation(response);
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
        /// Deletes an AuthorizationRule for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_DeleteAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.DeleteAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new EventHubsArmOperation(response);
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
        /// Creates or updates an AuthorizationRule for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The shared access AuthorizationRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventHubsNamespaceAuthorizationRuleResource>> UpdateAsync(WaitUntil waitUntil, EventHubsAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.CreateOrUpdateAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation<EventHubsNamespaceAuthorizationRuleResource>(Response.FromValue(new EventHubsNamespaceAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an AuthorizationRule for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: Namespaces_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The shared access AuthorizationRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventHubsNamespaceAuthorizationRuleResource> Update(WaitUntil waitUntil, EventHubsAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.CreateOrUpdateAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new EventHubsArmOperation<EventHubsNamespaceAuthorizationRuleResource>(Response.FromValue(new EventHubsNamespaceAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Gets the primary and secondary connection strings for the Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: Namespaces_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<EventHubsAccessKeys>> GetKeysCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = await _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the primary and secondary connection strings for the Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: Namespaces_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<EventHubsAccessKeys> GetKeysCore(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the primary or secondary connection strings for the specified Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: Namespaces_RegenerateKeys
        /// </summary>
        /// <param name="content"> Parameters required to regenerate the connection string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<EventHubsAccessKeys>> RegenerateKeysAsync(EventHubsRegenerateAccessKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = await _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.RegenerateKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the primary or secondary connection strings for the specified Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: Namespaces_RegenerateKeys
        /// </summary>
        /// <param name="content"> Parameters required to regenerate the connection string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<EventHubsAccessKeys> RegenerateKeys(EventHubsRegenerateAccessKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.RegenerateKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
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
