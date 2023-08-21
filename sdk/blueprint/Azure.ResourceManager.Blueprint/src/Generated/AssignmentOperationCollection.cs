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

namespace Azure.ResourceManager.Blueprint
{
    /// <summary>
    /// A class representing a collection of <see cref="AssignmentOperationResource" /> and their operations.
    /// Each <see cref="AssignmentOperationResource" /> in the collection will belong to the same instance of <see cref="AssignmentResource" />.
    /// To get an <see cref="AssignmentOperationCollection" /> instance call the GetAssignmentOperations method from an instance of <see cref="AssignmentResource" />.
    /// </summary>
    public partial class AssignmentOperationCollection : ArmCollection, IEnumerable<AssignmentOperationResource>, IAsyncEnumerable<AssignmentOperationResource>
    {
        private readonly ClientDiagnostics _assignmentOperationClientDiagnostics;
        private readonly AssignmentRestOperations _assignmentOperationRestClient;

        /// <summary> Initializes a new instance of the <see cref="AssignmentOperationCollection"/> class for mocking. </summary>
        protected AssignmentOperationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AssignmentOperationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AssignmentOperationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _assignmentOperationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Blueprint", AssignmentOperationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AssignmentOperationResource.ResourceType, out string assignmentOperationApiVersion);
            _assignmentOperationRestClient = new AssignmentRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, assignmentOperationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AssignmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AssignmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a blueprint assignment operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}/assignmentOperations/{assignmentOperationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssignmentOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assignmentOperationName"> Name of the blueprint assignment operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentOperationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentOperationName"/> is null. </exception>
        public virtual async Task<Response<AssignmentOperationResource>> GetAsync(string assignmentOperationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assignmentOperationName, nameof(assignmentOperationName));

            using var scope = _assignmentOperationClientDiagnostics.CreateScope("AssignmentOperationCollection.Get");
            scope.Start();
            try
            {
                var response = await _assignmentOperationRestClient.GetAsync(Id.Parent, Id.Name, assignmentOperationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AssignmentOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a blueprint assignment operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}/assignmentOperations/{assignmentOperationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssignmentOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assignmentOperationName"> Name of the blueprint assignment operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentOperationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentOperationName"/> is null. </exception>
        public virtual Response<AssignmentOperationResource> Get(string assignmentOperationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assignmentOperationName, nameof(assignmentOperationName));

            using var scope = _assignmentOperationClientDiagnostics.CreateScope("AssignmentOperationCollection.Get");
            scope.Start();
            try
            {
                var response = _assignmentOperationRestClient.Get(Id.Parent, Id.Name, assignmentOperationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AssignmentOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List operations for given blueprint assignment within a subscription or a management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}/assignmentOperations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssignmentOperations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AssignmentOperationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AssignmentOperationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _assignmentOperationRestClient.CreateListRequest(Id.Parent, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _assignmentOperationRestClient.CreateListNextPageRequest(nextLink, Id.Parent, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AssignmentOperationResource(Client, AssignmentOperationData.DeserializeAssignmentOperationData(e)), _assignmentOperationClientDiagnostics, Pipeline, "AssignmentOperationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List operations for given blueprint assignment within a subscription or a management group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}/assignmentOperations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssignmentOperations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AssignmentOperationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AssignmentOperationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _assignmentOperationRestClient.CreateListRequest(Id.Parent, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _assignmentOperationRestClient.CreateListNextPageRequest(nextLink, Id.Parent, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AssignmentOperationResource(Client, AssignmentOperationData.DeserializeAssignmentOperationData(e)), _assignmentOperationClientDiagnostics, Pipeline, "AssignmentOperationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}/assignmentOperations/{assignmentOperationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssignmentOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assignmentOperationName"> Name of the blueprint assignment operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentOperationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentOperationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string assignmentOperationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assignmentOperationName, nameof(assignmentOperationName));

            using var scope = _assignmentOperationClientDiagnostics.CreateScope("AssignmentOperationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _assignmentOperationRestClient.GetAsync(Id.Parent, Id.Name, assignmentOperationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}/assignmentOperations/{assignmentOperationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssignmentOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assignmentOperationName"> Name of the blueprint assignment operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentOperationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentOperationName"/> is null. </exception>
        public virtual Response<bool> Exists(string assignmentOperationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assignmentOperationName, nameof(assignmentOperationName));

            using var scope = _assignmentOperationClientDiagnostics.CreateScope("AssignmentOperationCollection.Exists");
            scope.Start();
            try
            {
                var response = _assignmentOperationRestClient.Get(Id.Parent, Id.Name, assignmentOperationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AssignmentOperationResource> IEnumerable<AssignmentOperationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AssignmentOperationResource> IAsyncEnumerable<AssignmentOperationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
