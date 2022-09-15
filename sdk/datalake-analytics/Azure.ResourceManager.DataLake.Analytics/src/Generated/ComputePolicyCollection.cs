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
using Azure.ResourceManager.DataLake.Analytics.Models;

namespace Azure.ResourceManager.DataLake.Analytics
{
    /// <summary>
    /// A class representing a collection of <see cref="ComputePolicyResource" /> and their operations.
    /// Each <see cref="ComputePolicyResource" /> in the collection will belong to the same instance of <see cref="DataLakeAnalyticsAccountResource" />.
    /// To get a <see cref="ComputePolicyCollection" /> instance call the GetComputePolicies method from an instance of <see cref="DataLakeAnalyticsAccountResource" />.
    /// </summary>
    public partial class ComputePolicyCollection : ArmCollection, IEnumerable<ComputePolicyResource>, IAsyncEnumerable<ComputePolicyResource>
    {
        private readonly ClientDiagnostics _computePolicyClientDiagnostics;
        private readonly ComputePoliciesRestOperations _computePolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ComputePolicyCollection"/> class for mocking. </summary>
        protected ComputePolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ComputePolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ComputePolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _computePolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLake.Analytics", ComputePolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ComputePolicyResource.ResourceType, out string computePolicyApiVersion);
            _computePolicyRestClient = new ComputePoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, computePolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataLakeAnalyticsAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataLakeAnalyticsAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the specified compute policy. During update, the compute policy with the specified name will be replaced with this new compute policy. An account supports, at most, 50 policies
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}
        /// Operation Id: ComputePolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="computePolicyName"> The name of the compute policy to create or update. </param>
        /// <param name="content"> Parameters supplied to create or update the compute policy. The max degree of parallelism per job property, min priority per job property, or both must be present. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ComputePolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string computePolicyName, ComputePolicyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computePolicyName, nameof(computePolicyName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _computePolicyClientDiagnostics.CreateScope("ComputePolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _computePolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computePolicyName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AnalyticsArmOperation<ComputePolicyResource>(Response.FromValue(new ComputePolicyResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the specified compute policy. During update, the compute policy with the specified name will be replaced with this new compute policy. An account supports, at most, 50 policies
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}
        /// Operation Id: ComputePolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="computePolicyName"> The name of the compute policy to create or update. </param>
        /// <param name="content"> Parameters supplied to create or update the compute policy. The max degree of parallelism per job property, min priority per job property, or both must be present. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ComputePolicyResource> CreateOrUpdate(WaitUntil waitUntil, string computePolicyName, ComputePolicyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computePolicyName, nameof(computePolicyName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _computePolicyClientDiagnostics.CreateScope("ComputePolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _computePolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computePolicyName, content, cancellationToken);
                var operation = new AnalyticsArmOperation<ComputePolicyResource>(Response.FromValue(new ComputePolicyResource(Client, response), response.GetRawResponse()));
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
        /// Gets the specified Data Lake Analytics compute policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}
        /// Operation Id: ComputePolicies_Get
        /// </summary>
        /// <param name="computePolicyName"> The name of the compute policy to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> is null. </exception>
        public virtual async Task<Response<ComputePolicyResource>> GetAsync(string computePolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computePolicyName, nameof(computePolicyName));

            using var scope = _computePolicyClientDiagnostics.CreateScope("ComputePolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _computePolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computePolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ComputePolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Data Lake Analytics compute policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}
        /// Operation Id: ComputePolicies_Get
        /// </summary>
        /// <param name="computePolicyName"> The name of the compute policy to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> is null. </exception>
        public virtual Response<ComputePolicyResource> Get(string computePolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computePolicyName, nameof(computePolicyName));

            using var scope = _computePolicyClientDiagnostics.CreateScope("ComputePolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _computePolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computePolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ComputePolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Data Lake Analytics compute policies within the specified Data Lake Analytics account. An account supports, at most, 50 policies
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies
        /// Operation Id: ComputePolicies_ListByAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ComputePolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ComputePolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ComputePolicyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _computePolicyClientDiagnostics.CreateScope("ComputePolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _computePolicyRestClient.ListByAccountAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ComputePolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ComputePolicyResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _computePolicyClientDiagnostics.CreateScope("ComputePolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _computePolicyRestClient.ListByAccountNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ComputePolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists the Data Lake Analytics compute policies within the specified Data Lake Analytics account. An account supports, at most, 50 policies
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies
        /// Operation Id: ComputePolicies_ListByAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ComputePolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ComputePolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ComputePolicyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _computePolicyClientDiagnostics.CreateScope("ComputePolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _computePolicyRestClient.ListByAccount(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ComputePolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ComputePolicyResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _computePolicyClientDiagnostics.CreateScope("ComputePolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _computePolicyRestClient.ListByAccountNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ComputePolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}
        /// Operation Id: ComputePolicies_Get
        /// </summary>
        /// <param name="computePolicyName"> The name of the compute policy to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string computePolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computePolicyName, nameof(computePolicyName));

            using var scope = _computePolicyClientDiagnostics.CreateScope("ComputePolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _computePolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computePolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}
        /// Operation Id: ComputePolicies_Get
        /// </summary>
        /// <param name="computePolicyName"> The name of the compute policy to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string computePolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computePolicyName, nameof(computePolicyName));

            using var scope = _computePolicyClientDiagnostics.CreateScope("ComputePolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _computePolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computePolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ComputePolicyResource> IEnumerable<ComputePolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ComputePolicyResource> IAsyncEnumerable<ComputePolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
