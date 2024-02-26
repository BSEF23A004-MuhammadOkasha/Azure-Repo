// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
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
    /// A Class representing a VmInstanceGuestAgent along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="VmInstanceGuestAgentResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetVmInstanceGuestAgentResource method.
    /// Otherwise you can get one from its parent resource <see cref="VMwareVmInstanceResource"/> using the GetVmInstanceGuestAgent method.
    /// </summary>
    public partial class VmInstanceGuestAgentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VmInstanceGuestAgentResource"/> instance. </summary>
        /// <param name="resourceUri"> The resourceUri. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceUri)
        {
            var resourceId = $"{resourceUri}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineInstances/default/guestAgents/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _vmInstanceGuestAgentVmInstanceGuestAgentsClientDiagnostics;
        private readonly VMInstanceGuestAgentsRestOperations _vmInstanceGuestAgentVmInstanceGuestAgentsRestClient;
        private readonly VmInstanceGuestAgentData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ConnectedVMwarevSphere/virtualMachineInstances/guestAgents";

        /// <summary> Initializes a new instance of the <see cref="VmInstanceGuestAgentResource"/> class for mocking. </summary>
        protected VmInstanceGuestAgentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VmInstanceGuestAgentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VmInstanceGuestAgentResource(ArmClient client, VmInstanceGuestAgentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VmInstanceGuestAgentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VmInstanceGuestAgentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vmInstanceGuestAgentVmInstanceGuestAgentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string vmInstanceGuestAgentVmInstanceGuestAgentsApiVersion);
            _vmInstanceGuestAgentVmInstanceGuestAgentsRestClient = new VMInstanceGuestAgentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vmInstanceGuestAgentVmInstanceGuestAgentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VmInstanceGuestAgentData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Implements GuestAgent GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineInstances/default/guestAgents/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VMInstanceGuestAgents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VmInstanceGuestAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VmInstanceGuestAgentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _vmInstanceGuestAgentVmInstanceGuestAgentsClientDiagnostics.CreateScope("VmInstanceGuestAgentResource.Get");
            scope.Start();
            try
            {
                var response = await _vmInstanceGuestAgentVmInstanceGuestAgentsRestClient.GetAsync(Id.Parent.Parent, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VmInstanceGuestAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements GuestAgent GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineInstances/default/guestAgents/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VMInstanceGuestAgents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VmInstanceGuestAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VmInstanceGuestAgentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _vmInstanceGuestAgentVmInstanceGuestAgentsClientDiagnostics.CreateScope("VmInstanceGuestAgentResource.Get");
            scope.Start();
            try
            {
                var response = _vmInstanceGuestAgentVmInstanceGuestAgentsRestClient.Get(Id.Parent.Parent, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VmInstanceGuestAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements GuestAgent DELETE method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineInstances/default/guestAgents/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VMInstanceGuestAgents_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VmInstanceGuestAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _vmInstanceGuestAgentVmInstanceGuestAgentsClientDiagnostics.CreateScope("VmInstanceGuestAgentResource.Delete");
            scope.Start();
            try
            {
                var response = await _vmInstanceGuestAgentVmInstanceGuestAgentsRestClient.DeleteAsync(Id.Parent.Parent, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation(_vmInstanceGuestAgentVmInstanceGuestAgentsClientDiagnostics, Pipeline, _vmInstanceGuestAgentVmInstanceGuestAgentsRestClient.CreateDeleteRequest(Id.Parent.Parent).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements GuestAgent DELETE method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineInstances/default/guestAgents/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VMInstanceGuestAgents_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VmInstanceGuestAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _vmInstanceGuestAgentVmInstanceGuestAgentsClientDiagnostics.CreateScope("VmInstanceGuestAgentResource.Delete");
            scope.Start();
            try
            {
                var response = _vmInstanceGuestAgentVmInstanceGuestAgentsRestClient.Delete(Id.Parent.Parent, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation(_vmInstanceGuestAgentVmInstanceGuestAgentsClientDiagnostics, Pipeline, _vmInstanceGuestAgentVmInstanceGuestAgentsRestClient.CreateDeleteRequest(Id.Parent.Parent).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create Or Update GuestAgent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineInstances/default/guestAgents/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VMInstanceGuestAgents_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VmInstanceGuestAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VmInstanceGuestAgentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, VmInstanceGuestAgentData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _vmInstanceGuestAgentVmInstanceGuestAgentsClientDiagnostics.CreateScope("VmInstanceGuestAgentResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vmInstanceGuestAgentVmInstanceGuestAgentsRestClient.CreateAsync(Id.Parent.Parent, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<VmInstanceGuestAgentResource>(new VmInstanceGuestAgentOperationSource(Client), _vmInstanceGuestAgentVmInstanceGuestAgentsClientDiagnostics, Pipeline, _vmInstanceGuestAgentVmInstanceGuestAgentsRestClient.CreateCreateRequest(Id.Parent.Parent, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Or Update GuestAgent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineInstances/default/guestAgents/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VMInstanceGuestAgents_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VmInstanceGuestAgentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VmInstanceGuestAgentResource> CreateOrUpdate(WaitUntil waitUntil, VmInstanceGuestAgentData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _vmInstanceGuestAgentVmInstanceGuestAgentsClientDiagnostics.CreateScope("VmInstanceGuestAgentResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vmInstanceGuestAgentVmInstanceGuestAgentsRestClient.Create(Id.Parent.Parent, data, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<VmInstanceGuestAgentResource>(new VmInstanceGuestAgentOperationSource(Client), _vmInstanceGuestAgentVmInstanceGuestAgentsClientDiagnostics, Pipeline, _vmInstanceGuestAgentVmInstanceGuestAgentsRestClient.CreateCreateRequest(Id.Parent.Parent, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
