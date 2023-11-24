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
using Azure.ResourceManager.MobileNetwork.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A Class representing a MobileNetworkPacketCapture along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MobileNetworkPacketCaptureResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMobileNetworkPacketCaptureResource method.
    /// Otherwise you can get one from its parent resource <see cref="PacketCoreControlPlaneResource"/> using the GetMobileNetworkPacketCapture method.
    /// </summary>
    public partial class MobileNetworkPacketCaptureResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MobileNetworkPacketCaptureResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="packetCoreControlPlaneName"> The packetCoreControlPlaneName. </param>
        /// <param name="packetCaptureName"> The packetCaptureName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string packetCaptureName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCaptures/{packetCaptureName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mobileNetworkPacketCapturePacketCapturesClientDiagnostics;
        private readonly PacketCapturesRestOperations _mobileNetworkPacketCapturePacketCapturesRestClient;
        private readonly MobileNetworkPacketCaptureData _data;

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkPacketCaptureResource"/> class for mocking. </summary>
        protected MobileNetworkPacketCaptureResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkPacketCaptureResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MobileNetworkPacketCaptureResource(ArmClient client, MobileNetworkPacketCaptureData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkPacketCaptureResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MobileNetworkPacketCaptureResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mobileNetworkPacketCapturePacketCapturesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string mobileNetworkPacketCapturePacketCapturesApiVersion);
            _mobileNetworkPacketCapturePacketCapturesRestClient = new PacketCapturesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mobileNetworkPacketCapturePacketCapturesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MobileNetwork/packetCoreControlPlanes/packetCaptures";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MobileNetworkPacketCaptureData Data
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
        /// Gets information about the specified packet capture session.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCaptures/{packetCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MobileNetworkPacketCaptureResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkPacketCapturePacketCapturesClientDiagnostics.CreateScope("MobileNetworkPacketCaptureResource.Get");
            scope.Start();
            try
            {
                var response = await _mobileNetworkPacketCapturePacketCapturesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkPacketCaptureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified packet capture session.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCaptures/{packetCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MobileNetworkPacketCaptureResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkPacketCapturePacketCapturesClientDiagnostics.CreateScope("MobileNetworkPacketCaptureResource.Get");
            scope.Start();
            try
            {
                var response = _mobileNetworkPacketCapturePacketCapturesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkPacketCaptureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified packet capture.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCaptures/{packetCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkPacketCapturePacketCapturesClientDiagnostics.CreateScope("MobileNetworkPacketCaptureResource.Delete");
            scope.Start();
            try
            {
                var response = await _mobileNetworkPacketCapturePacketCapturesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation(_mobileNetworkPacketCapturePacketCapturesClientDiagnostics, Pipeline, _mobileNetworkPacketCapturePacketCapturesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the specified packet capture.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCaptures/{packetCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkPacketCapturePacketCapturesClientDiagnostics.CreateScope("MobileNetworkPacketCaptureResource.Delete");
            scope.Start();
            try
            {
                var response = _mobileNetworkPacketCapturePacketCapturesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MobileNetworkArmOperation(_mobileNetworkPacketCapturePacketCapturesClientDiagnostics, Pipeline, _mobileNetworkPacketCapturePacketCapturesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a packet capture.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCaptures/{packetCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MobileNetworkPacketCaptureResource>> UpdateAsync(WaitUntil waitUntil, MobileNetworkPacketCaptureData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkPacketCapturePacketCapturesClientDiagnostics.CreateScope("MobileNetworkPacketCaptureResource.Update");
            scope.Start();
            try
            {
                var response = await _mobileNetworkPacketCapturePacketCapturesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation<MobileNetworkPacketCaptureResource>(new MobileNetworkPacketCaptureOperationSource(Client), _mobileNetworkPacketCapturePacketCapturesClientDiagnostics, Pipeline, _mobileNetworkPacketCapturePacketCapturesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a packet capture.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCaptures/{packetCaptureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MobileNetworkPacketCaptureResource> Update(WaitUntil waitUntil, MobileNetworkPacketCaptureData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkPacketCapturePacketCapturesClientDiagnostics.CreateScope("MobileNetworkPacketCaptureResource.Update");
            scope.Start();
            try
            {
                var response = _mobileNetworkPacketCapturePacketCapturesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MobileNetworkArmOperation<MobileNetworkPacketCaptureResource>(new MobileNetworkPacketCaptureOperationSource(Client), _mobileNetworkPacketCapturePacketCapturesClientDiagnostics, Pipeline, _mobileNetworkPacketCapturePacketCapturesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Stop a packet capture session.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCaptures/{packetCaptureName}/stop</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_Stop</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<AsyncOperationStatus>> StopAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkPacketCapturePacketCapturesClientDiagnostics.CreateScope("MobileNetworkPacketCaptureResource.Stop");
            scope.Start();
            try
            {
                var response = await _mobileNetworkPacketCapturePacketCapturesRestClient.StopAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation<AsyncOperationStatus>(new AsyncOperationStatusOperationSource(), _mobileNetworkPacketCapturePacketCapturesClientDiagnostics, Pipeline, _mobileNetworkPacketCapturePacketCapturesRestClient.CreateStopRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Stop a packet capture session.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCaptures/{packetCaptureName}/stop</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCaptures_Stop</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<AsyncOperationStatus> Stop(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkPacketCapturePacketCapturesClientDiagnostics.CreateScope("MobileNetworkPacketCaptureResource.Stop");
            scope.Start();
            try
            {
                var response = _mobileNetworkPacketCapturePacketCapturesRestClient.Stop(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MobileNetworkArmOperation<AsyncOperationStatus>(new AsyncOperationStatusOperationSource(), _mobileNetworkPacketCapturePacketCapturesClientDiagnostics, Pipeline, _mobileNetworkPacketCapturePacketCapturesRestClient.CreateStopRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
