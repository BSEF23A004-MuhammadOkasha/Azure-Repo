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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="DefaultSecurityRuleResource" /> and their operations.
    /// Each <see cref="DefaultSecurityRuleResource" /> in the collection will belong to the same instance of <see cref="NetworkSecurityGroupResource" />.
    /// To get a <see cref="DefaultSecurityRuleCollection" /> instance call the GetDefaultSecurityRules method from an instance of <see cref="NetworkSecurityGroupResource" />.
    /// </summary>
    public partial class DefaultSecurityRuleCollection : ArmCollection, IEnumerable<DefaultSecurityRuleResource>, IAsyncEnumerable<DefaultSecurityRuleResource>
    {
        private readonly ClientDiagnostics _defaultSecurityRuleClientDiagnostics;
        private readonly DefaultSecurityRulesRestOperations _defaultSecurityRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="DefaultSecurityRuleCollection"/> class for mocking. </summary>
        protected DefaultSecurityRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DefaultSecurityRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DefaultSecurityRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _defaultSecurityRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", DefaultSecurityRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DefaultSecurityRuleResource.ResourceType, out string defaultSecurityRuleApiVersion);
            _defaultSecurityRuleRestClient = new DefaultSecurityRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, defaultSecurityRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkSecurityGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkSecurityGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the specified default network security rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/defaultSecurityRules/{defaultSecurityRuleName}
        /// Operation Id: DefaultSecurityRules_Get
        /// </summary>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="defaultSecurityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="defaultSecurityRuleName"/> is null. </exception>
        public virtual async Task<Response<DefaultSecurityRuleResource>> GetAsync(string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(defaultSecurityRuleName, nameof(defaultSecurityRuleName));

            using var scope = _defaultSecurityRuleClientDiagnostics.CreateScope("DefaultSecurityRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _defaultSecurityRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultSecurityRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DefaultSecurityRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified default network security rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/defaultSecurityRules/{defaultSecurityRuleName}
        /// Operation Id: DefaultSecurityRules_Get
        /// </summary>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="defaultSecurityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="defaultSecurityRuleName"/> is null. </exception>
        public virtual Response<DefaultSecurityRuleResource> Get(string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(defaultSecurityRuleName, nameof(defaultSecurityRuleName));

            using var scope = _defaultSecurityRuleClientDiagnostics.CreateScope("DefaultSecurityRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _defaultSecurityRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultSecurityRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DefaultSecurityRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all default security rules in a network security group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/defaultSecurityRules
        /// Operation Id: DefaultSecurityRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DefaultSecurityRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DefaultSecurityRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DefaultSecurityRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _defaultSecurityRuleClientDiagnostics.CreateScope("DefaultSecurityRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _defaultSecurityRuleRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DefaultSecurityRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DefaultSecurityRuleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _defaultSecurityRuleClientDiagnostics.CreateScope("DefaultSecurityRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _defaultSecurityRuleRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DefaultSecurityRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all default security rules in a network security group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/defaultSecurityRules
        /// Operation Id: DefaultSecurityRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DefaultSecurityRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DefaultSecurityRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DefaultSecurityRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _defaultSecurityRuleClientDiagnostics.CreateScope("DefaultSecurityRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _defaultSecurityRuleRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DefaultSecurityRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DefaultSecurityRuleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _defaultSecurityRuleClientDiagnostics.CreateScope("DefaultSecurityRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _defaultSecurityRuleRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DefaultSecurityRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/defaultSecurityRules/{defaultSecurityRuleName}
        /// Operation Id: DefaultSecurityRules_Get
        /// </summary>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="defaultSecurityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="defaultSecurityRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(defaultSecurityRuleName, nameof(defaultSecurityRuleName));

            using var scope = _defaultSecurityRuleClientDiagnostics.CreateScope("DefaultSecurityRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _defaultSecurityRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultSecurityRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/defaultSecurityRules/{defaultSecurityRuleName}
        /// Operation Id: DefaultSecurityRules_Get
        /// </summary>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="defaultSecurityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="defaultSecurityRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(defaultSecurityRuleName, nameof(defaultSecurityRuleName));

            using var scope = _defaultSecurityRuleClientDiagnostics.CreateScope("DefaultSecurityRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _defaultSecurityRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultSecurityRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DefaultSecurityRuleResource> IEnumerable<DefaultSecurityRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DefaultSecurityRuleResource> IAsyncEnumerable<DefaultSecurityRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
