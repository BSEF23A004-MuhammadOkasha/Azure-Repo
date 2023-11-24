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

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary>
    /// A class representing a collection of <see cref="DeviceUpdateInstanceResource"/> and their operations.
    /// Each <see cref="DeviceUpdateInstanceResource"/> in the collection will belong to the same instance of <see cref="DeviceUpdateAccountResource"/>.
    /// To get a <see cref="DeviceUpdateInstanceCollection"/> instance call the GetDeviceUpdateInstances method from an instance of <see cref="DeviceUpdateAccountResource"/>.
    /// </summary>
    public partial class DeviceUpdateInstanceCollection : ArmCollection, IEnumerable<DeviceUpdateInstanceResource>, IAsyncEnumerable<DeviceUpdateInstanceResource>
    {
        private readonly ClientDiagnostics _deviceUpdateInstanceInstancesClientDiagnostics;
        private readonly InstancesRestOperations _deviceUpdateInstanceInstancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdateInstanceCollection"/> class for mocking. </summary>
        protected DeviceUpdateInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdateInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeviceUpdateInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceUpdateInstanceInstancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceUpdate", DeviceUpdateInstanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeviceUpdateInstanceResource.ResourceType, out string deviceUpdateInstanceInstancesApiVersion);
            _deviceUpdateInstanceInstancesRestClient = new InstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deviceUpdateInstanceInstancesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DeviceUpdateAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DeviceUpdateAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instances_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="data"> Instance details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DeviceUpdateInstanceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string instanceName, DeviceUpdateInstanceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceUpdateInstanceInstancesClientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deviceUpdateInstanceInstancesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceUpdateArmOperation<DeviceUpdateInstanceResource>(new DeviceUpdateInstanceOperationSource(Client), _deviceUpdateInstanceInstancesClientDiagnostics, Pipeline, _deviceUpdateInstanceInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instances_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="data"> Instance details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DeviceUpdateInstanceResource> CreateOrUpdate(WaitUntil waitUntil, string instanceName, DeviceUpdateInstanceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceUpdateInstanceInstancesClientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deviceUpdateInstanceInstancesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, data, cancellationToken);
                var operation = new DeviceUpdateArmOperation<DeviceUpdateInstanceResource>(new DeviceUpdateInstanceOperationSource(Client), _deviceUpdateInstanceInstancesClientDiagnostics, Pipeline, _deviceUpdateInstanceInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns instance details for the given instance and account name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual async Task<Response<DeviceUpdateInstanceResource>> GetAsync(string instanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));

            using var scope = _deviceUpdateInstanceInstancesClientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _deviceUpdateInstanceInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdateInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns instance details for the given instance and account name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual Response<DeviceUpdateInstanceResource> Get(string instanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));

            using var scope = _deviceUpdateInstanceInstancesClientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _deviceUpdateInstanceInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdateInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns instances for the given account name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/instances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instances_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceUpdateInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeviceUpdateInstanceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceUpdateInstanceInstancesRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deviceUpdateInstanceInstancesRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DeviceUpdateInstanceResource(Client, DeviceUpdateInstanceData.DeserializeDeviceUpdateInstanceData(e)), _deviceUpdateInstanceInstancesClientDiagnostics, Pipeline, "DeviceUpdateInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns instances for the given account name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/instances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instances_ListByAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceUpdateInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeviceUpdateInstanceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceUpdateInstanceInstancesRestClient.CreateListByAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deviceUpdateInstanceInstancesRestClient.CreateListByAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DeviceUpdateInstanceResource(Client, DeviceUpdateInstanceData.DeserializeDeviceUpdateInstanceData(e)), _deviceUpdateInstanceInstancesClientDiagnostics, Pipeline, "DeviceUpdateInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string instanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));

            using var scope = _deviceUpdateInstanceInstancesClientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deviceUpdateInstanceInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string instanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));

            using var scope = _deviceUpdateInstanceInstancesClientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = _deviceUpdateInstanceInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual async Task<NullableResponse<DeviceUpdateInstanceResource>> GetIfExistsAsync(string instanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));

            using var scope = _deviceUpdateInstanceInstancesClientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deviceUpdateInstanceInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DeviceUpdateInstanceResource>(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdateInstanceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/instances/{instanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Instances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceName"> Instance name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceName"/> is null. </exception>
        public virtual NullableResponse<DeviceUpdateInstanceResource> GetIfExists(string instanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));

            using var scope = _deviceUpdateInstanceInstancesClientDiagnostics.CreateScope("DeviceUpdateInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deviceUpdateInstanceInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DeviceUpdateInstanceResource>(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdateInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeviceUpdateInstanceResource> IEnumerable<DeviceUpdateInstanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeviceUpdateInstanceResource> IAsyncEnumerable<DeviceUpdateInstanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
