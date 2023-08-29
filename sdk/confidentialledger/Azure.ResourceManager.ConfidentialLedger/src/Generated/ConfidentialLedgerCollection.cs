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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConfidentialLedger
{
    /// <summary>
    /// A class representing a collection of <see cref="ConfidentialLedgerResource" /> and their operations.
    /// Each <see cref="ConfidentialLedgerResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ConfidentialLedgerCollection" /> instance call the GetConfidentialLedgers method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ConfidentialLedgerCollection : ArmCollection, IEnumerable<ConfidentialLedgerResource>, IAsyncEnumerable<ConfidentialLedgerResource>
    {
        private readonly ClientDiagnostics _confidentialLedgerLedgerClientDiagnostics;
        private readonly LedgerRestOperations _confidentialLedgerLedgerRestClient;

        /// <summary> Initializes a new instance of the <see cref="ConfidentialLedgerCollection"/> class for mocking. </summary>
        protected ConfidentialLedgerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConfidentialLedgerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ConfidentialLedgerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _confidentialLedgerLedgerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConfidentialLedger", ConfidentialLedgerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ConfidentialLedgerResource.ResourceType, out string confidentialLedgerLedgerApiVersion);
            _confidentialLedgerLedgerRestClient = new LedgerRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, confidentialLedgerLedgerApiVersion);
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
        /// Creates a  Confidential Ledger with the specified ledger parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/ledgers/{ledgerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ledgerName"> Name of the Confidential Ledger. </param>
        /// <param name="data"> Confidential Ledger Create Request Body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ledgerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ledgerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ConfidentialLedgerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ledgerName, ConfidentialLedgerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ledgerName, nameof(ledgerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _confidentialLedgerLedgerClientDiagnostics.CreateScope("ConfidentialLedgerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _confidentialLedgerLedgerRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, ledgerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConfidentialLedgerArmOperation<ConfidentialLedgerResource>(new ConfidentialLedgerOperationSource(Client), _confidentialLedgerLedgerClientDiagnostics, Pipeline, _confidentialLedgerLedgerRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, ledgerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a  Confidential Ledger with the specified ledger parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/ledgers/{ledgerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ledgerName"> Name of the Confidential Ledger. </param>
        /// <param name="data"> Confidential Ledger Create Request Body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ledgerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ledgerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ConfidentialLedgerResource> CreateOrUpdate(WaitUntil waitUntil, string ledgerName, ConfidentialLedgerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ledgerName, nameof(ledgerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _confidentialLedgerLedgerClientDiagnostics.CreateScope("ConfidentialLedgerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _confidentialLedgerLedgerRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, ledgerName, data, cancellationToken);
                var operation = new ConfidentialLedgerArmOperation<ConfidentialLedgerResource>(new ConfidentialLedgerOperationSource(Client), _confidentialLedgerLedgerClientDiagnostics, Pipeline, _confidentialLedgerLedgerRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, ledgerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the properties of a Confidential Ledger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/ledgers/{ledgerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerName"> Name of the Confidential Ledger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ledgerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ledgerName"/> is null. </exception>
        public virtual async Task<Response<ConfidentialLedgerResource>> GetAsync(string ledgerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ledgerName, nameof(ledgerName));

            using var scope = _confidentialLedgerLedgerClientDiagnostics.CreateScope("ConfidentialLedgerCollection.Get");
            scope.Start();
            try
            {
                var response = await _confidentialLedgerLedgerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ledgerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfidentialLedgerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of a Confidential Ledger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/ledgers/{ledgerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerName"> Name of the Confidential Ledger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ledgerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ledgerName"/> is null. </exception>
        public virtual Response<ConfidentialLedgerResource> Get(string ledgerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ledgerName, nameof(ledgerName));

            using var scope = _confidentialLedgerLedgerClientDiagnostics.CreateScope("ConfidentialLedgerCollection.Get");
            scope.Start();
            try
            {
                var response = _confidentialLedgerLedgerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ledgerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfidentialLedgerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of all Confidential Ledgers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/ledgers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the list operation. eg. $filter=ledgerType eq 'Public'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfidentialLedgerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConfidentialLedgerResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _confidentialLedgerLedgerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _confidentialLedgerLedgerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ConfidentialLedgerResource(Client, ConfidentialLedgerData.DeserializeConfidentialLedgerData(e)), _confidentialLedgerLedgerClientDiagnostics, Pipeline, "ConfidentialLedgerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves the properties of all Confidential Ledgers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/ledgers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the list operation. eg. $filter=ledgerType eq 'Public'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfidentialLedgerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConfidentialLedgerResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _confidentialLedgerLedgerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _confidentialLedgerLedgerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ConfidentialLedgerResource(Client, ConfidentialLedgerData.DeserializeConfidentialLedgerData(e)), _confidentialLedgerLedgerClientDiagnostics, Pipeline, "ConfidentialLedgerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/ledgers/{ledgerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerName"> Name of the Confidential Ledger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ledgerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ledgerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ledgerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ledgerName, nameof(ledgerName));

            using var scope = _confidentialLedgerLedgerClientDiagnostics.CreateScope("ConfidentialLedgerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _confidentialLedgerLedgerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ledgerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConfidentialLedger/ledgers/{ledgerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Ledger_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerName"> Name of the Confidential Ledger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ledgerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ledgerName"/> is null. </exception>
        public virtual Response<bool> Exists(string ledgerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ledgerName, nameof(ledgerName));

            using var scope = _confidentialLedgerLedgerClientDiagnostics.CreateScope("ConfidentialLedgerCollection.Exists");
            scope.Start();
            try
            {
                var response = _confidentialLedgerLedgerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ledgerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ConfidentialLedgerResource> IEnumerable<ConfidentialLedgerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ConfidentialLedgerResource> IAsyncEnumerable<ConfidentialLedgerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
