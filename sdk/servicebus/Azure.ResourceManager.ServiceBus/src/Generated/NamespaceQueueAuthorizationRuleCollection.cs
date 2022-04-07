// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing a collection of <see cref="NamespaceQueueAuthorizationRuleResource" /> and their operations.
    /// Each <see cref="NamespaceQueueAuthorizationRuleResource" /> in the collection will belong to the same instance of <see cref="ServiceBusQueueResource" />.
    /// To get a <see cref="NamespaceQueueAuthorizationRuleCollection" /> instance call the GetNamespaceQueueAuthorizationRules method from an instance of <see cref="ServiceBusQueueResource" />.
    /// </summary>
    public partial class NamespaceQueueAuthorizationRuleCollection : ArmCollection, IEnumerable<NamespaceQueueAuthorizationRuleResource>, IAsyncEnumerable<NamespaceQueueAuthorizationRuleResource>
    {
        private readonly ClientDiagnostics _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics;
        private readonly QueueAuthorizationRulesRestOperations _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NamespaceQueueAuthorizationRuleCollection"/> class for mocking. </summary>
        protected NamespaceQueueAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NamespaceQueueAuthorizationRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NamespaceQueueAuthorizationRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", NamespaceQueueAuthorizationRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NamespaceQueueAuthorizationRuleResource.ResourceType, out string namespaceQueueAuthorizationRuleQueueAuthorizationRulesApiVersion);
            _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient = new QueueAuthorizationRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, namespaceQueueAuthorizationRuleQueueAuthorizationRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceBusQueueResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceBusQueueResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates an authorization rule for a queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="data"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NamespaceQueueAuthorizationRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string authorizationRuleName, ServiceBusAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<NamespaceQueueAuthorizationRuleResource>(Response.FromValue(new NamespaceQueueAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates an authorization rule for a queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="data"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NamespaceQueueAuthorizationRuleResource> CreateOrUpdate(WaitUntil waitUntil, string authorizationRuleName, ServiceBusAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, data, cancellationToken);
                var operation = new ServiceBusArmOperation<NamespaceQueueAuthorizationRuleResource>(Response.FromValue(new NamespaceQueueAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Gets an authorization rule for a queue by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Get
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<NamespaceQueueAuthorizationRuleResource>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceQueueAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an authorization rule for a queue by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Get
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<NamespaceQueueAuthorizationRuleResource> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceQueueAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all authorization rules for a queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules
        /// Operation Id: QueueAuthorizationRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NamespaceQueueAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NamespaceQueueAuthorizationRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NamespaceQueueAuthorizationRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceQueueAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NamespaceQueueAuthorizationRuleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceQueueAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all authorization rules for a queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules
        /// Operation Id: QueueAuthorizationRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NamespaceQueueAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NamespaceQueueAuthorizationRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NamespaceQueueAuthorizationRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceQueueAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NamespaceQueueAuthorizationRuleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceQueueAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Get
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Get
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NamespaceQueueAuthorizationRuleResource> IEnumerable<NamespaceQueueAuthorizationRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NamespaceQueueAuthorizationRuleResource> IAsyncEnumerable<NamespaceQueueAuthorizationRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
