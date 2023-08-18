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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseDatabasePrincipalAssignmentResource" /> and their operations.
    /// Each <see cref="SynapseDatabasePrincipalAssignmentResource" /> in the collection will belong to the same instance of <see cref="SynapseDatabaseResource" />.
    /// To get a <see cref="SynapseDatabasePrincipalAssignmentCollection" /> instance call the GetSynapseDatabasePrincipalAssignments method from an instance of <see cref="SynapseDatabaseResource" />.
    /// </summary>
    public partial class SynapseDatabasePrincipalAssignmentCollection : ArmCollection, IEnumerable<SynapseDatabasePrincipalAssignmentResource>, IAsyncEnumerable<SynapseDatabasePrincipalAssignmentResource>
    {
        private readonly ClientDiagnostics _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsClientDiagnostics;
        private readonly KustoPoolDatabasePrincipalAssignmentsRestOperations _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseDatabasePrincipalAssignmentCollection"/> class for mocking. </summary>
        protected SynapseDatabasePrincipalAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseDatabasePrincipalAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseDatabasePrincipalAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseDatabasePrincipalAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseDatabasePrincipalAssignmentResource.ResourceType, out string synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsApiVersion);
            _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsRestClient = new KustoPoolDatabasePrincipalAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a Kusto pool database principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/databases/{databaseName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolDatabasePrincipalAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="data"> The Kusto principalAssignments parameters supplied for the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseDatabasePrincipalAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string principalAssignmentName, SynapseDatabasePrincipalAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsClientDiagnostics.CreateScope("SynapseDatabasePrincipalAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, principalAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseDatabasePrincipalAssignmentResource>(new SynapseDatabasePrincipalAssignmentOperationSource(Client), _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsClientDiagnostics, Pipeline, _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, principalAssignmentName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Creates a Kusto pool database principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/databases/{databaseName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolDatabasePrincipalAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="data"> The Kusto principalAssignments parameters supplied for the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseDatabasePrincipalAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string principalAssignmentName, SynapseDatabasePrincipalAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsClientDiagnostics.CreateScope("SynapseDatabasePrincipalAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, principalAssignmentName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseDatabasePrincipalAssignmentResource>(new SynapseDatabasePrincipalAssignmentOperationSource(Client), _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsClientDiagnostics, Pipeline, _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, principalAssignmentName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Gets a Kusto pool database principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/databases/{databaseName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolDatabasePrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual async Task<Response<SynapseDatabasePrincipalAssignmentResource>> GetAsync(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsClientDiagnostics.CreateScope("SynapseDatabasePrincipalAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, principalAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseDatabasePrincipalAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Kusto pool database principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/databases/{databaseName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolDatabasePrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual Response<SynapseDatabasePrincipalAssignmentResource> Get(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsClientDiagnostics.CreateScope("SynapseDatabasePrincipalAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, principalAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseDatabasePrincipalAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Kusto pool database principalAssignments.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/databases/{databaseName}/principalAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolDatabasePrincipalAssignments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseDatabasePrincipalAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseDatabasePrincipalAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new SynapseDatabasePrincipalAssignmentResource(Client, SynapseDatabasePrincipalAssignmentData.DeserializeSynapseDatabasePrincipalAssignmentData(e)), _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsClientDiagnostics, Pipeline, "SynapseDatabasePrincipalAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all Kusto pool database principalAssignments.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/databases/{databaseName}/principalAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolDatabasePrincipalAssignments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseDatabasePrincipalAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseDatabasePrincipalAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, null, e => new SynapseDatabasePrincipalAssignmentResource(Client, SynapseDatabasePrincipalAssignmentData.DeserializeSynapseDatabasePrincipalAssignmentData(e)), _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsClientDiagnostics, Pipeline, "SynapseDatabasePrincipalAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/databases/{databaseName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolDatabasePrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsClientDiagnostics.CreateScope("SynapseDatabasePrincipalAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, principalAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/databases/{databaseName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolDatabasePrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsClientDiagnostics.CreateScope("SynapseDatabasePrincipalAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseDatabasePrincipalAssignmentKustoPoolDatabasePrincipalAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, principalAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseDatabasePrincipalAssignmentResource> IEnumerable<SynapseDatabasePrincipalAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseDatabasePrincipalAssignmentResource> IAsyncEnumerable<SynapseDatabasePrincipalAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
