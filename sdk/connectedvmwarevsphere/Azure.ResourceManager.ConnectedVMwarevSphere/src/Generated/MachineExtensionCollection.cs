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

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineExtensionResource" /> and their operations.
    /// Each <see cref="MachineExtensionResource" /> in the collection will belong to the same instance of <see cref="VirtualMachineResource" />.
    /// To get a <see cref="MachineExtensionCollection" /> instance call the GetMachineExtensions method from an instance of <see cref="VirtualMachineResource" />.
    /// </summary>
    public partial class MachineExtensionCollection : ArmCollection, IEnumerable<MachineExtensionResource>, IAsyncEnumerable<MachineExtensionResource>
    {
        private readonly ClientDiagnostics _machineExtensionClientDiagnostics;
        private readonly MachineExtensionsRestOperations _machineExtensionRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineExtensionCollection"/> class for mocking. </summary>
        protected MachineExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineExtensionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", MachineExtensionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineExtensionResource.ResourceType, out string machineExtensionApiVersion);
            _machineExtensionRestClient = new MachineExtensionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineExtensionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachineResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachineResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update the extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="data"> Parameters supplied to the Create Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string extensionName, MachineExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineExtensionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<MachineExtensionResource>(new MachineExtensionOperationSource(Client), _machineExtensionClientDiagnostics, Pipeline, _machineExtensionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// The operation to create or update the extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="data"> Parameters supplied to the Create Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineExtensionResource> CreateOrUpdate(WaitUntil waitUntil, string extensionName, MachineExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineExtensionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, data, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<MachineExtensionResource>(new MachineExtensionOperationSource(Client), _machineExtensionClientDiagnostics, Pipeline, _machineExtensionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// The operation to get the extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<MachineExtensionResource>> GetAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineExtensionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<MachineExtensionResource> Get(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _machineExtensionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get all extensions of a non-Azure machine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineExtensionResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineExtensionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineExtensionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new MachineExtensionResource(Client, MachineExtensionData.DeserializeMachineExtensionData(e)), _machineExtensionClientDiagnostics, Pipeline, "MachineExtensionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The operation to get all extensions of a non-Azure machine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineExtensionResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineExtensionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineExtensionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new MachineExtensionResource(Client, MachineExtensionData.DeserializeMachineExtensionData(e)), _machineExtensionClientDiagnostics, Pipeline, "MachineExtensionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineExtensionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _machineExtensionClientDiagnostics.CreateScope("MachineExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineExtensionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineExtensionResource> IEnumerable<MachineExtensionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineExtensionResource> IAsyncEnumerable<MachineExtensionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
