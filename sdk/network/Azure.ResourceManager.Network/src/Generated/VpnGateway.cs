// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a VpnGateway along with the instance operations that can be performed on it. </summary>
    public partial class VpnGateway : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VpnGatewaysRestOperations _restClient;
        private readonly VpnGatewayData _data;

        /// <summary> Initializes a new instance of the <see cref="VpnGateway"/> class for mocking. </summary>
        protected VpnGateway()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VpnGateway"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal VpnGateway(ArmResource options, VpnGatewayData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new VpnGatewaysRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="VpnGateway"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VpnGateway(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new VpnGatewaysRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/vpnGateways";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VpnGatewayData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Retrieves the details of a virtual wan vpn gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VpnGateway>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VpnGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a virtual wan vpn gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnGateway> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes a virtual wan vpn gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a virtual wan vpn gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a virtual wan vpn gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnGatewayDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new VpnGatewayDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a virtual wan vpn gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnGatewayDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new VpnGatewayDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates virtual wan vpn gateway tags. </summary>
        /// <param name="vpnGatewayParameters"> Parameters supplied to update a virtual wan vpn gateway tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnGatewayParameters"/> is null. </exception>
        public async virtual Task<Response<VpnGateway>> UpdateTagsAsync(TagsObject vpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (vpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGateway.UpdateTags");
            scope.Start();
            try
            {
                var operation = await StartUpdateTagsAsync(vpnGatewayParameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates virtual wan vpn gateway tags. </summary>
        /// <param name="vpnGatewayParameters"> Parameters supplied to update a virtual wan vpn gateway tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnGatewayParameters"/> is null. </exception>
        public virtual Response<VpnGateway> UpdateTags(TagsObject vpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (vpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGateway.UpdateTags");
            scope.Start();
            try
            {
                var operation = StartUpdateTags(vpnGatewayParameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates virtual wan vpn gateway tags. </summary>
        /// <param name="vpnGatewayParameters"> Parameters supplied to update a virtual wan vpn gateway tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnGatewayParameters"/> is null. </exception>
        public async virtual Task<VpnGatewayUpdateTagsOperation> StartUpdateTagsAsync(TagsObject vpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (vpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartUpdateTags");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, vpnGatewayParameters, cancellationToken).ConfigureAwait(false);
                return new VpnGatewayUpdateTagsOperation(this, _clientDiagnostics, Pipeline, _restClient.CreateUpdateTagsRequest(Id.ResourceGroupName, Id.Name, vpnGatewayParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates virtual wan vpn gateway tags. </summary>
        /// <param name="vpnGatewayParameters"> Parameters supplied to update a virtual wan vpn gateway tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnGatewayParameters"/> is null. </exception>
        public virtual VpnGatewayUpdateTagsOperation StartUpdateTags(TagsObject vpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (vpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartUpdateTags");
            scope.Start();
            try
            {
                var response = _restClient.UpdateTags(Id.ResourceGroupName, Id.Name, vpnGatewayParameters, cancellationToken);
                return new VpnGatewayUpdateTagsOperation(this, _clientDiagnostics, Pipeline, _restClient.CreateUpdateTagsRequest(Id.ResourceGroupName, Id.Name, vpnGatewayParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets the primary of the vpn gateway in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VpnGatewayData>> ResetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Reset");
            scope.Start();
            try
            {
                var operation = await StartResetAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets the primary of the vpn gateway in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnGatewayData> Reset(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.Reset");
            scope.Start();
            try
            {
                var operation = StartReset(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets the primary of the vpn gateway in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnGatewayResetOperation> StartResetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartReset");
            scope.Start();
            try
            {
                var response = await _restClient.ResetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new VpnGatewayResetOperation(_clientDiagnostics, Pipeline, _restClient.CreateResetRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets the primary of the vpn gateway in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnGatewayResetOperation StartReset(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartReset");
            scope.Start();
            try
            {
                var response = _restClient.Reset(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new VpnGatewayResetOperation(_clientDiagnostics, Pipeline, _restClient.CreateResetRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts packet capture on vpn gateway in the specified resource group. </summary>
        /// <param name="parameters"> Vpn gateway packet capture parameters supplied to start packet capture on vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<string>> StartPacketCaptureAsync(VpnGatewayPacketCaptureStartParameters parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartPacketCapture");
            scope.Start();
            try
            {
                var operation = await StartStartPacketCaptureAsync(parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts packet capture on vpn gateway in the specified resource group. </summary>
        /// <param name="parameters"> Vpn gateway packet capture parameters supplied to start packet capture on vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> StartPacketCapture(VpnGatewayPacketCaptureStartParameters parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartPacketCapture");
            scope.Start();
            try
            {
                var operation = StartStartPacketCapture(parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts packet capture on vpn gateway in the specified resource group. </summary>
        /// <param name="parameters"> Vpn gateway packet capture parameters supplied to start packet capture on vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnGatewayStartPacketCaptureOperation> StartStartPacketCaptureAsync(VpnGatewayPacketCaptureStartParameters parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartStartPacketCapture");
            scope.Start();
            try
            {
                var response = await _restClient.StartPacketCaptureAsync(Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return new VpnGatewayStartPacketCaptureOperation(_clientDiagnostics, Pipeline, _restClient.CreateStartPacketCaptureRequest(Id.ResourceGroupName, Id.Name, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts packet capture on vpn gateway in the specified resource group. </summary>
        /// <param name="parameters"> Vpn gateway packet capture parameters supplied to start packet capture on vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnGatewayStartPacketCaptureOperation StartStartPacketCapture(VpnGatewayPacketCaptureStartParameters parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartStartPacketCapture");
            scope.Start();
            try
            {
                var response = _restClient.StartPacketCapture(Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return new VpnGatewayStartPacketCaptureOperation(_clientDiagnostics, Pipeline, _restClient.CreateStartPacketCaptureRequest(Id.ResourceGroupName, Id.Name, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops packet capture on vpn gateway in the specified resource group. </summary>
        /// <param name="parameters"> Vpn gateway packet capture parameters supplied to stop packet capture on vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<string>> StopPacketCaptureAsync(VpnGatewayPacketCaptureStopParameters parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StopPacketCapture");
            scope.Start();
            try
            {
                var operation = await StartStopPacketCaptureAsync(parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops packet capture on vpn gateway in the specified resource group. </summary>
        /// <param name="parameters"> Vpn gateway packet capture parameters supplied to stop packet capture on vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> StopPacketCapture(VpnGatewayPacketCaptureStopParameters parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StopPacketCapture");
            scope.Start();
            try
            {
                var operation = StartStopPacketCapture(parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops packet capture on vpn gateway in the specified resource group. </summary>
        /// <param name="parameters"> Vpn gateway packet capture parameters supplied to stop packet capture on vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnGatewayStopPacketCaptureOperation> StartStopPacketCaptureAsync(VpnGatewayPacketCaptureStopParameters parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartStopPacketCapture");
            scope.Start();
            try
            {
                var response = await _restClient.StopPacketCaptureAsync(Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return new VpnGatewayStopPacketCaptureOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopPacketCaptureRequest(Id.ResourceGroupName, Id.Name, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops packet capture on vpn gateway in the specified resource group. </summary>
        /// <param name="parameters"> Vpn gateway packet capture parameters supplied to stop packet capture on vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnGatewayStopPacketCaptureOperation StartStopPacketCapture(VpnGatewayPacketCaptureStopParameters parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGateway.StartStopPacketCapture");
            scope.Start();
            try
            {
                var response = _restClient.StopPacketCapture(Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return new VpnGatewayStopPacketCaptureOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopPacketCaptureRequest(Id.ResourceGroupName, Id.Name, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of VpnConnections in the VpnGateway. </summary>
        /// <returns> An object representing collection of VpnConnections and their operations over a VpnGateway. </returns>
        public VpnConnectionContainer GetVpnConnections()
        {
            return new VpnConnectionContainer(this);
        }

        /// <summary> Gets a list of VpnGatewayNatRules in the VpnGateway. </summary>
        /// <returns> An object representing collection of VpnGatewayNatRules and their operations over a VpnGateway. </returns>
        public VpnGatewayNatRuleContainer GetVpnGatewayNatRules()
        {
            return new VpnGatewayNatRuleContainer(this);
        }
    }
}
