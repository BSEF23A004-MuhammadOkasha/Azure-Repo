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

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing a collection of <see cref="DevTestLabResource" /> and their operations.
    /// Each <see cref="DevTestLabResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DevTestLabCollection" /> instance call the GetDevTestLabs method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DevTestLabCollection : ArmCollection, IEnumerable<DevTestLabResource>, IAsyncEnumerable<DevTestLabResource>
    {
        private readonly ClientDiagnostics _devTestLabLabsClientDiagnostics;
        private readonly LabsRestOperations _devTestLabLabsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevTestLabCollection"/> class for mocking. </summary>
        protected DevTestLabCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevTestLabCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevTestLabCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devTestLabLabsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", DevTestLabResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevTestLabResource.ResourceType, out string devTestLabLabsApiVersion);
            _devTestLabLabsRestClient = new LabsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devTestLabLabsApiVersion);
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
        /// Create or replace an existing lab. This operation can take a while to complete.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the lab. </param>
        /// <param name="data"> A lab. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevTestLabResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DevTestLabData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabLabsClientDiagnostics.CreateScope("DevTestLabCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devTestLabLabsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation<DevTestLabResource>(new DevTestLabOperationSource(Client), _devTestLabLabsClientDiagnostics, Pipeline, _devTestLabLabsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or replace an existing lab. This operation can take a while to complete.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the lab. </param>
        /// <param name="data"> A lab. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevTestLabResource> CreateOrUpdate(WaitUntil waitUntil, string name, DevTestLabData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabLabsClientDiagnostics.CreateScope("DevTestLabCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devTestLabLabsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken);
                var operation = new DevTestLabsArmOperation<DevTestLabResource>(new DevTestLabOperationSource(Client), _devTestLabLabsClientDiagnostics, Pipeline, _devTestLabLabsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get lab.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the lab. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DevTestLabResource>> GetAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabLabsClientDiagnostics.CreateScope("DevTestLabCollection.Get");
            scope.Start();
            try
            {
                var response = await _devTestLabLabsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get lab.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the lab. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DevTestLabResource> Get(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabLabsClientDiagnostics.CreateScope("DevTestLabCollection.Get");
            scope.Start();
            try
            {
                var response = _devTestLabLabsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List labs in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevTestLabResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevTestLabResource> GetAllAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabLabsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabLabsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, filter, top, orderby);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevTestLabResource(Client, DevTestLabData.DeserializeDevTestLabData(e)), _devTestLabLabsClientDiagnostics, Pipeline, "DevTestLabCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List labs in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevTestLabResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevTestLabResource> GetAll(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabLabsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabLabsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, filter, top, orderby);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevTestLabResource(Client, DevTestLabData.DeserializeDevTestLabData(e)), _devTestLabLabsClientDiagnostics, Pipeline, "DevTestLabCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the lab. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabLabsClientDiagnostics.CreateScope("DevTestLabCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devTestLabLabsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the lab. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabLabsClientDiagnostics.CreateScope("DevTestLabCollection.Exists");
            scope.Start();
            try
            {
                var response = _devTestLabLabsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevTestLabResource> IEnumerable<DevTestLabResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevTestLabResource> IAsyncEnumerable<DevTestLabResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
