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

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="DscNodeResource" /> and their operations.
    /// Each <see cref="DscNodeResource" /> in the collection will belong to the same instance of <see cref="AutomationAccountResource" />.
    /// To get a <see cref="DscNodeCollection" /> instance call the GetDscNodes method from an instance of <see cref="AutomationAccountResource" />.
    /// </summary>
    public partial class DscNodeCollection : ArmCollection, IEnumerable<DscNodeResource>, IAsyncEnumerable<DscNodeResource>
    {
        private readonly ClientDiagnostics _dscNodeClientDiagnostics;
        private readonly DscNodeRestOperations _dscNodeRestClient;

        /// <summary> Initializes a new instance of the <see cref="DscNodeCollection"/> class for mocking. </summary>
        protected DscNodeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DscNodeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DscNodeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dscNodeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", DscNodeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DscNodeResource.ResourceType, out string dscNodeApiVersion);
            _dscNodeRestClient = new DscNodeRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dscNodeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieve the dsc node identified by node id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodes/{nodeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNode_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeId"> The node id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeId"/> is null. </exception>
        public virtual async Task<Response<DscNodeResource>> GetAsync(string nodeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeId, nameof(nodeId));

            using var scope = _dscNodeClientDiagnostics.CreateScope("DscNodeCollection.Get");
            scope.Start();
            try
            {
                var response = await _dscNodeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DscNodeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the dsc node identified by node id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodes/{nodeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNode_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeId"> The node id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeId"/> is null. </exception>
        public virtual Response<DscNodeResource> Get(string nodeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeId, nameof(nodeId));

            using var scope = _dscNodeClientDiagnostics.CreateScope("DscNodeCollection.Get");
            scope.Start();
            try
            {
                var response = _dscNodeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DscNodeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of dsc nodes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNode_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="skip"> The number of rows to skip. </param>
        /// <param name="top"> The number of rows to take. </param>
        /// <param name="inlinecount"> Return total rows. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DscNodeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DscNodeResource> GetAllAsync(string filter = null, int? skip = null, int? top = null, string inlinecount = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dscNodeRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, skip, top, inlinecount);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dscNodeRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, skip, top, inlinecount);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DscNodeResource(Client, DscNodeData.DeserializeDscNodeData(e)), _dscNodeClientDiagnostics, Pipeline, "DscNodeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of dsc nodes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNode_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="skip"> The number of rows to skip. </param>
        /// <param name="top"> The number of rows to take. </param>
        /// <param name="inlinecount"> Return total rows. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DscNodeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DscNodeResource> GetAll(string filter = null, int? skip = null, int? top = null, string inlinecount = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dscNodeRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, skip, top, inlinecount);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dscNodeRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, skip, top, inlinecount);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DscNodeResource(Client, DscNodeData.DeserializeDscNodeData(e)), _dscNodeClientDiagnostics, Pipeline, "DscNodeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodes/{nodeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNode_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeId"> The node id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string nodeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeId, nameof(nodeId));

            using var scope = _dscNodeClientDiagnostics.CreateScope("DscNodeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dscNodeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodes/{nodeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNode_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeId"> The node id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeId"/> is null. </exception>
        public virtual Response<bool> Exists(string nodeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeId, nameof(nodeId));

            using var scope = _dscNodeClientDiagnostics.CreateScope("DscNodeCollection.Exists");
            scope.Start();
            try
            {
                var response = _dscNodeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DscNodeResource> IEnumerable<DscNodeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DscNodeResource> IAsyncEnumerable<DscNodeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
