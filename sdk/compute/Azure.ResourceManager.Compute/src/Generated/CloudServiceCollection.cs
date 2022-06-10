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

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="CloudServiceResource" /> and their operations.
    /// Each <see cref="CloudServiceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="CloudServiceCollection" /> instance call the GetCloudServices method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class CloudServiceCollection : ArmCollection, IEnumerable<CloudServiceResource>, IAsyncEnumerable<CloudServiceResource>
    {
        private readonly ClientDiagnostics _cloudServiceClientDiagnostics;
        private readonly CloudServicesRestOperations _cloudServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="CloudServiceCollection"/> class for mocking. </summary>
        protected CloudServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CloudServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CloudServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cloudServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", CloudServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CloudServiceResource.ResourceType, out string cloudServiceApiVersion);
            _cloudServiceRestClient = new CloudServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cloudServiceApiVersion);
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
        /// Create or update a cloud service. Please note some properties can be set only during cloud service creation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="data"> The cloud service object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual async Task<ArmOperation<CloudServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string cloudServiceName, CloudServiceData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cloudServiceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<CloudServiceResource>(new CloudServiceOperationSource(Client), _cloudServiceClientDiagnostics, Pipeline, _cloudServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a cloud service. Please note some properties can be set only during cloud service creation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="data"> The cloud service object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual ArmOperation<CloudServiceResource> CreateOrUpdate(WaitUntil waitUntil, string cloudServiceName, CloudServiceData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cloudServiceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, data, cancellationToken);
                var operation = new ComputeArmOperation<CloudServiceResource>(new CloudServiceOperationSource(Client), _cloudServiceClientDiagnostics, Pipeline, _cloudServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Display information about a cloud service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_Get
        /// </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual async Task<Response<CloudServiceResource>> GetAsync(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Display information about a cloud service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_Get
        /// </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual Response<CloudServiceResource> Get(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all cloud services under a resource group. Use nextLink property in the response to get the next page of Cloud Services. Do this till nextLink is null to fetch all the Cloud Services.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices
        /// Operation Id: CloudServices_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CloudServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CloudServiceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CloudServiceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of all cloud services under a resource group. Use nextLink property in the response to get the next page of Cloud Services. Do this till nextLink is null to fetch all the Cloud Services.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices
        /// Operation Id: CloudServices_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CloudServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CloudServiceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CloudServiceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_Get
        /// </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cloudServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_Get
        /// </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _cloudServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CloudServiceResource> IEnumerable<CloudServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CloudServiceResource> IAsyncEnumerable<CloudServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
