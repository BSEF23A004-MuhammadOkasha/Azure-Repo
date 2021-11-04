// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of VirtualNetworkRule and their operations over its parent. </summary>
    public partial class VirtualNetworkRuleCollection : ArmCollection, IEnumerable<VirtualNetworkRule>, IAsyncEnumerable<VirtualNetworkRule>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualNetworkRulesRestOperations _virtualNetworkRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkRuleCollection"/> class for mocking. </summary>
        protected VirtualNetworkRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkRuleCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkRuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _virtualNetworkRulesRestClient = new VirtualNetworkRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Server.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: VirtualNetworkRules_CreateOrUpdate
        /// <summary> Creates or updates an existing virtual network rule. </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="parameters"> The requested virtual Network Rule Resource state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualNetworkRuleCreateOrUpdateOperation CreateOrUpdate(string virtualNetworkRuleName, VirtualNetworkRuleData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkRuleName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkRuleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkRulesRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, parameters, cancellationToken);
                var operation = new VirtualNetworkRuleCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualNetworkRulesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: VirtualNetworkRules_CreateOrUpdate
        /// <summary> Creates or updates an existing virtual network rule. </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="parameters"> The requested virtual Network Rule Resource state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkRuleCreateOrUpdateOperation> CreateOrUpdateAsync(string virtualNetworkRuleName, VirtualNetworkRuleData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkRuleName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkRuleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRulesRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualNetworkRuleCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualNetworkRulesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: VirtualNetworkRules_Get
        /// <summary> Gets a virtual network rule. </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual Response<VirtualNetworkRule> Get(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkRuleName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkRulesRestClient.Get(Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: VirtualNetworkRules_Get
        /// <summary> Gets a virtual network rule. </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkRule>> GetAsync(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkRuleName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRulesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual Response<VirtualNetworkRule> GetIfExists(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkRuleName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkRulesRestClient.Get(Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkRule>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkRule>> GetIfExistsAsync(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkRuleName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkRuleCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRulesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkRule>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkRuleName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkRuleCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualNetworkRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkRuleName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkRuleCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualNetworkRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: VirtualNetworkRules_ListByServer
        /// <summary> Gets a list of virtual network rules in a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkRulesRestClient.ListByServer(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkRulesRestClient.ListByServerNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: VirtualNetworkRules_ListByServer
        /// <summary> Gets a list of virtual network rules in a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkRulesRestClient.ListByServerAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkRulesRestClient.ListByServerNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<VirtualNetworkRule> IEnumerable<VirtualNetworkRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkRule> IAsyncEnumerable<VirtualNetworkRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, VirtualNetworkRule, VirtualNetworkRuleData> Construct() { }
    }
}
