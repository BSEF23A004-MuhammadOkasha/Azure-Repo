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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of WebApplicationFirewallPolicy and their operations over its parent. </summary>
    public partial class WebApplicationFirewallPolicyCollection : ArmCollection, IEnumerable<WebApplicationFirewallPolicy>, IAsyncEnumerable<WebApplicationFirewallPolicy>
    {
        private readonly ClientDiagnostics _webApplicationFirewallPolicyClientDiagnostics;
        private readonly WebApplicationFirewallPoliciesRestOperations _webApplicationFirewallPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebApplicationFirewallPolicyCollection"/> class for mocking. </summary>
        protected WebApplicationFirewallPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebApplicationFirewallPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebApplicationFirewallPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webApplicationFirewallPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", WebApplicationFirewallPolicy.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebApplicationFirewallPolicy.ResourceType, out string webApplicationFirewallPolicyApiVersion);
            _webApplicationFirewallPolicyRestClient = new WebApplicationFirewallPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webApplicationFirewallPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or update policy with specified rule set name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: WebApplicationFirewallPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="parameters"> Policy to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<WebApplicationFirewallPolicy>> CreateOrUpdateAsync(WaitUntil waitUntil, string policyName, WebApplicationFirewallPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webApplicationFirewallPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<WebApplicationFirewallPolicy>(Response.FromValue(new WebApplicationFirewallPolicy(Client, response), response.GetRawResponse()));
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
        /// Creates or update policy with specified rule set name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: WebApplicationFirewallPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="parameters"> Policy to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<WebApplicationFirewallPolicy> CreateOrUpdate(WaitUntil waitUntil, string policyName, WebApplicationFirewallPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webApplicationFirewallPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, policyName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<WebApplicationFirewallPolicy>(Response.FromValue(new WebApplicationFirewallPolicy(Client, response), response.GetRawResponse()));
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
        /// Retrieve protection policy with specified name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: WebApplicationFirewallPolicies_Get
        /// </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<WebApplicationFirewallPolicy>> GetAsync(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _webApplicationFirewallPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebApplicationFirewallPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: WebApplicationFirewallPolicies_Get
        /// </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<WebApplicationFirewallPolicy> Get(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _webApplicationFirewallPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebApplicationFirewallPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the protection policies within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies
        /// Operation Id: WebApplicationFirewallPolicies_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebApplicationFirewallPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebApplicationFirewallPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<WebApplicationFirewallPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webApplicationFirewallPolicyRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WebApplicationFirewallPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WebApplicationFirewallPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webApplicationFirewallPolicyRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WebApplicationFirewallPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all of the protection policies within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies
        /// Operation Id: WebApplicationFirewallPolicies_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebApplicationFirewallPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebApplicationFirewallPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<WebApplicationFirewallPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webApplicationFirewallPolicyRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WebApplicationFirewallPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WebApplicationFirewallPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webApplicationFirewallPolicyRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WebApplicationFirewallPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: WebApplicationFirewallPolicies_Get
        /// </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: WebApplicationFirewallPolicies_Get
        /// </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(policyName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: WebApplicationFirewallPolicies_Get
        /// </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<WebApplicationFirewallPolicy>> GetIfExistsAsync(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webApplicationFirewallPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<WebApplicationFirewallPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new WebApplicationFirewallPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: WebApplicationFirewallPolicies_Get
        /// </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<WebApplicationFirewallPolicy> GetIfExists(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webApplicationFirewallPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<WebApplicationFirewallPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new WebApplicationFirewallPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebApplicationFirewallPolicy> IEnumerable<WebApplicationFirewallPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebApplicationFirewallPolicy> IAsyncEnumerable<WebApplicationFirewallPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
