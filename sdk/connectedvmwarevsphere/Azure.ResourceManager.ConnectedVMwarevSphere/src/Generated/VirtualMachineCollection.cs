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

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing collection of VirtualMachine and their operations over its parent. </summary>
    public partial class VirtualMachineCollection : ArmCollection, IEnumerable<VirtualMachine>, IAsyncEnumerable<VirtualMachine>
    {
        private readonly ClientDiagnostics _virtualMachineClientDiagnostics;
        private readonly VirtualMachinesRestOperations _virtualMachineRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineCollection"/> class for mocking. </summary>
        protected VirtualMachineCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualMachineCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VirtualMachine.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualMachine.ResourceType, out string virtualMachineApiVersion);
            _virtualMachineRestClient = new VirtualMachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualMachineApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Or Update virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// Operation Id: VirtualMachines_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualMachineName"> Name of the virtual machine resource. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualMachine>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualMachineName, VirtualMachineData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, body, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<VirtualMachine>(new VirtualMachineOperationSource(Client), _virtualMachineClientDiagnostics, Pipeline, _virtualMachineRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, body).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Or Update virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// Operation Id: VirtualMachines_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualMachineName"> Name of the virtual machine resource. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        public virtual ArmOperation<VirtualMachine> CreateOrUpdate(WaitUntil waitUntil, string virtualMachineName, VirtualMachineData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, body, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<VirtualMachine>(new VirtualMachineOperationSource(Client), _virtualMachineClientDiagnostics, Pipeline, _virtualMachineRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, body).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements virtual machine GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="virtualMachineName"> Name of the virtual machine resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachine>> GetAsync(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachine(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements virtual machine GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="virtualMachineName"> Name of the virtual machine resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        public virtual Response<VirtualMachine> Get(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachine(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of virtualMachines in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines
        /// Operation Id: VirtualMachines_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachine" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachine> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachine>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachine(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachine>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachine(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List of virtualMachines in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines
        /// Operation Id: VirtualMachines_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachine" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachine> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualMachine> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachine(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachine> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachine(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="virtualMachineName"> Name of the virtual machine resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualMachineName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="virtualMachineName"> Name of the virtual machine resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualMachineName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="virtualMachineName"> Name of the virtual machine resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachine>> GetIfExistsAsync(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachine>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachine(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="virtualMachineName"> Name of the virtual machine resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        public virtual Response<VirtualMachine> GetIfExists(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var scope = _virtualMachineClientDiagnostics.CreateScope("VirtualMachineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachine>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachine(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachine> IEnumerable<VirtualMachine>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachine> IAsyncEnumerable<VirtualMachine>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
