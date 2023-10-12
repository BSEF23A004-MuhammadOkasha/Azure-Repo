// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ManagedNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="ScopeAssignmentResource" /> and their operations.
    /// Each <see cref="ScopeAssignmentResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="ScopeAssignmentCollection" /> instance call the GetScopeAssignments method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class ScopeAssignmentCollection : ArmCollection, IEnumerable<ScopeAssignmentResource>, IAsyncEnumerable<ScopeAssignmentResource>
    {
        private readonly ClientDiagnostics _scopeAssignmentClientDiagnostics;
        private readonly ScopeAssignmentsRestOperations _scopeAssignmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScopeAssignmentCollection"/> class for mocking. </summary>
        protected ScopeAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScopeAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScopeAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scopeAssignmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetwork", ScopeAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScopeAssignmentResource.ResourceType, out string scopeAssignmentApiVersion);
            _scopeAssignmentRestClient = new ScopeAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scopeAssignmentApiVersion);
        }

        /// <summary>
        /// Creates a scope assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedNetwork/scopeAssignments/{scopeAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scopeAssignmentName"> The name of the scope assignment to create. </param>
        /// <param name="data"> Parameters supplied to the specify which Managed Network this scope is being assigned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScopeAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scopeAssignmentName, ScopeAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeAssignmentName, nameof(scopeAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scopeAssignmentClientDiagnostics.CreateScope("ScopeAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scopeAssignmentRestClient.CreateOrUpdateAsync(Id, scopeAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkArmOperation<ScopeAssignmentResource>(Response.FromValue(new ScopeAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Creates a scope assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedNetwork/scopeAssignments/{scopeAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scopeAssignmentName"> The name of the scope assignment to create. </param>
        /// <param name="data"> Parameters supplied to the specify which Managed Network this scope is being assigned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScopeAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string scopeAssignmentName, ScopeAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeAssignmentName, nameof(scopeAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scopeAssignmentClientDiagnostics.CreateScope("ScopeAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scopeAssignmentRestClient.CreateOrUpdate(Id, scopeAssignmentName, data, cancellationToken);
                var operation = new ManagedNetworkArmOperation<ScopeAssignmentResource>(Response.FromValue(new ScopeAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Get the specified scope assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedNetwork/scopeAssignments/{scopeAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeAssignmentName"> The name of the scope assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeAssignmentName"/> is null. </exception>
        public virtual async Task<Response<ScopeAssignmentResource>> GetAsync(string scopeAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeAssignmentName, nameof(scopeAssignmentName));

            using var scope = _scopeAssignmentClientDiagnostics.CreateScope("ScopeAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _scopeAssignmentRestClient.GetAsync(Id, scopeAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScopeAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified scope assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedNetwork/scopeAssignments/{scopeAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeAssignmentName"> The name of the scope assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeAssignmentName"/> is null. </exception>
        public virtual Response<ScopeAssignmentResource> Get(string scopeAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeAssignmentName, nameof(scopeAssignmentName));

            using var scope = _scopeAssignmentClientDiagnostics.CreateScope("ScopeAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _scopeAssignmentRestClient.Get(Id, scopeAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScopeAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified scope assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedNetwork/scopeAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeAssignments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScopeAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScopeAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scopeAssignmentRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scopeAssignmentRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScopeAssignmentResource(Client, ScopeAssignmentData.DeserializeScopeAssignmentData(e)), _scopeAssignmentClientDiagnostics, Pipeline, "ScopeAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the specified scope assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedNetwork/scopeAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeAssignments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScopeAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScopeAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scopeAssignmentRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scopeAssignmentRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScopeAssignmentResource(Client, ScopeAssignmentData.DeserializeScopeAssignmentData(e)), _scopeAssignmentClientDiagnostics, Pipeline, "ScopeAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedNetwork/scopeAssignments/{scopeAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeAssignmentName"> The name of the scope assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scopeAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeAssignmentName, nameof(scopeAssignmentName));

            using var scope = _scopeAssignmentClientDiagnostics.CreateScope("ScopeAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scopeAssignmentRestClient.GetAsync(Id, scopeAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.ManagedNetwork/scopeAssignments/{scopeAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeAssignmentName"> The name of the scope assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string scopeAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeAssignmentName, nameof(scopeAssignmentName));

            using var scope = _scopeAssignmentClientDiagnostics.CreateScope("ScopeAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _scopeAssignmentRestClient.Get(Id, scopeAssignmentName, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.ManagedNetwork/scopeAssignments/{scopeAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeAssignmentName"> The name of the scope assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeAssignmentName"/> is null. </exception>
        public virtual async Task<NullableResponse<ScopeAssignmentResource>> GetIfExistsAsync(string scopeAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeAssignmentName, nameof(scopeAssignmentName));

            using var scope = _scopeAssignmentClientDiagnostics.CreateScope("ScopeAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _scopeAssignmentRestClient.GetAsync(Id, scopeAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ScopeAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new ScopeAssignmentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.ManagedNetwork/scopeAssignments/{scopeAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScopeAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeAssignmentName"> The name of the scope assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeAssignmentName"/> is null. </exception>
        public virtual NullableResponse<ScopeAssignmentResource> GetIfExists(string scopeAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeAssignmentName, nameof(scopeAssignmentName));

            using var scope = _scopeAssignmentClientDiagnostics.CreateScope("ScopeAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _scopeAssignmentRestClient.Get(Id, scopeAssignmentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ScopeAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new ScopeAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScopeAssignmentResource> IEnumerable<ScopeAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScopeAssignmentResource> IAsyncEnumerable<ScopeAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
