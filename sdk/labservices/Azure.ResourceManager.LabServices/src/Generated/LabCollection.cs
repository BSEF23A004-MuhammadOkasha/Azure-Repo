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

namespace Azure.ResourceManager.LabServices
{
    /// <summary>
    /// A class representing a collection of <see cref="LabResource" /> and their operations.
    /// Each <see cref="LabResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="LabCollection" /> instance call the GetLabs method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class LabCollection : ArmCollection, IEnumerable<LabResource>, IAsyncEnumerable<LabResource>
    {
        private readonly ClientDiagnostics _labClientDiagnostics;
        private readonly LabsRestOperations _labRestClient;

        /// <summary> Initializes a new instance of the <see cref="LabCollection"/> class for mocking. </summary>
        protected LabCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LabCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LabCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _labClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.LabServices", LabResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LabResource.ResourceType, out string labApiVersion);
            _labRestClient = new LabsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, labApiVersion);
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
        /// Operation to create or update a lab resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}
        /// Operation Id: Labs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="labName"> The name of the lab that uniquely identifies it within containing lab plan. Used in resource URIs. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LabResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string labName, LabData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _labClientDiagnostics.CreateScope("LabCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _labRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, labName, data, cancellationToken).ConfigureAwait(false);
                var operation = new LabServicesArmOperation<LabResource>(new LabOperationSource(Client), _labClientDiagnostics, Pipeline, _labRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, labName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Operation to create or update a lab resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}
        /// Operation Id: Labs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="labName"> The name of the lab that uniquely identifies it within containing lab plan. Used in resource URIs. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LabResource> CreateOrUpdate(WaitUntil waitUntil, string labName, LabData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _labClientDiagnostics.CreateScope("LabCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _labRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, labName, data, cancellationToken);
                var operation = new LabServicesArmOperation<LabResource>(new LabOperationSource(Client), _labClientDiagnostics, Pipeline, _labRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, labName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Returns the properties of a lab resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}
        /// Operation Id: Labs_Get
        /// </summary>
        /// <param name="labName"> The name of the lab that uniquely identifies it within containing lab plan. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labName"/> is null. </exception>
        public virtual async Task<Response<LabResource>> GetAsync(string labName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));

            using var scope = _labClientDiagnostics.CreateScope("LabCollection.Get");
            scope.Start();
            try
            {
                var response = await _labRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, labName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the properties of a lab resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}
        /// Operation Id: Labs_Get
        /// </summary>
        /// <param name="labName"> The name of the lab that uniquely identifies it within containing lab plan. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labName"/> is null. </exception>
        public virtual Response<LabResource> Get(string labName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));

            using var scope = _labClientDiagnostics.CreateScope("LabCollection.Get");
            scope.Start();
            try
            {
                var response = _labRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, labName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of all labs in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs
        /// Operation Id: Labs_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LabResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LabResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LabResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _labClientDiagnostics.CreateScope("LabCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _labRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LabResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LabResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _labClientDiagnostics.CreateScope("LabCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _labRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LabResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Returns a list of all labs in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs
        /// Operation Id: Labs_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LabResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LabResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<LabResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _labClientDiagnostics.CreateScope("LabCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _labRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LabResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LabResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _labClientDiagnostics.CreateScope("LabCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _labRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LabResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}
        /// Operation Id: Labs_Get
        /// </summary>
        /// <param name="labName"> The name of the lab that uniquely identifies it within containing lab plan. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string labName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));

            using var scope = _labClientDiagnostics.CreateScope("LabCollection.Exists");
            scope.Start();
            try
            {
                var response = await _labRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, labName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}
        /// Operation Id: Labs_Get
        /// </summary>
        /// <param name="labName"> The name of the lab that uniquely identifies it within containing lab plan. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="labName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="labName"/> is null. </exception>
        public virtual Response<bool> Exists(string labName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));

            using var scope = _labClientDiagnostics.CreateScope("LabCollection.Exists");
            scope.Start();
            try
            {
                var response = _labRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, labName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LabResource> IEnumerable<LabResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LabResource> IAsyncEnumerable<LabResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
