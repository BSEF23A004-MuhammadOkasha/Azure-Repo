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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HDInsight
{
    /// <summary>
    /// A class representing a collection of <see cref="HDInsightApplicationResource" /> and their operations.
    /// Each <see cref="HDInsightApplicationResource" /> in the collection will belong to the same instance of <see cref="HDInsightClusterResource" />.
    /// To get a <see cref="HDInsightApplicationCollection" /> instance call the GetHDInsightApplications method from an instance of <see cref="HDInsightClusterResource" />.
    /// </summary>
    public partial class HDInsightApplicationCollection : ArmCollection, IEnumerable<HDInsightApplicationResource>, IAsyncEnumerable<HDInsightApplicationResource>
    {
        private readonly ClientDiagnostics _hdInsightApplicationApplicationsClientDiagnostics;
        private readonly ApplicationsRestOperations _hdInsightApplicationApplicationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HDInsightApplicationCollection"/> class for mocking. </summary>
        protected HDInsightApplicationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HDInsightApplicationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HDInsightApplicationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hdInsightApplicationApplicationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HDInsight", HDInsightApplicationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HDInsightApplicationResource.ResourceType, out string hdInsightApplicationApplicationsApiVersion);
            _hdInsightApplicationApplicationsRestClient = new ApplicationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hdInsightApplicationApplicationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HDInsightClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HDInsightClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates applications for the HDInsight cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusters/{clusterName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationName"> The constant value for the application name. </param>
        /// <param name="data"> The application create request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HDInsightApplicationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string applicationName, HDInsightApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hdInsightApplicationApplicationsClientDiagnostics.CreateScope("HDInsightApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hdInsightApplicationApplicationsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HDInsightArmOperation<HDInsightApplicationResource>(new HDInsightApplicationOperationSource(Client), _hdInsightApplicationApplicationsClientDiagnostics, Pipeline, _hdInsightApplicationApplicationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates applications for the HDInsight cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusters/{clusterName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationName"> The constant value for the application name. </param>
        /// <param name="data"> The application create request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HDInsightApplicationResource> CreateOrUpdate(WaitUntil waitUntil, string applicationName, HDInsightApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hdInsightApplicationApplicationsClientDiagnostics.CreateScope("HDInsightApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hdInsightApplicationApplicationsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data, cancellationToken);
                var operation = new HDInsightArmOperation<HDInsightApplicationResource>(new HDInsightApplicationOperationSource(Client), _hdInsightApplicationApplicationsClientDiagnostics, Pipeline, _hdInsightApplicationApplicationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets properties of the specified application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusters/{clusterName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The constant value for the application name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual async Task<Response<HDInsightApplicationResource>> GetAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _hdInsightApplicationApplicationsClientDiagnostics.CreateScope("HDInsightApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = await _hdInsightApplicationApplicationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HDInsightApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of the specified application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusters/{clusterName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The constant value for the application name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual Response<HDInsightApplicationResource> Get(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _hdInsightApplicationApplicationsClientDiagnostics.CreateScope("HDInsightApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = _hdInsightApplicationApplicationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HDInsightApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the applications for the HDInsight cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusters/{clusterName}/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HDInsightApplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HDInsightApplicationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hdInsightApplicationApplicationsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hdInsightApplicationApplicationsRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HDInsightApplicationResource(Client, HDInsightApplicationData.DeserializeHDInsightApplicationData(e)), _hdInsightApplicationApplicationsClientDiagnostics, Pipeline, "HDInsightApplicationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the applications for the HDInsight cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusters/{clusterName}/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HDInsightApplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HDInsightApplicationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hdInsightApplicationApplicationsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hdInsightApplicationApplicationsRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HDInsightApplicationResource(Client, HDInsightApplicationData.DeserializeHDInsightApplicationData(e)), _hdInsightApplicationApplicationsClientDiagnostics, Pipeline, "HDInsightApplicationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusters/{clusterName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The constant value for the application name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _hdInsightApplicationApplicationsClientDiagnostics.CreateScope("HDInsightApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hdInsightApplicationApplicationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusters/{clusterName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The constant value for the application name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _hdInsightApplicationApplicationsClientDiagnostics.CreateScope("HDInsightApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = _hdInsightApplicationApplicationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HDInsightApplicationResource> IEnumerable<HDInsightApplicationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HDInsightApplicationResource> IAsyncEnumerable<HDInsightApplicationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
