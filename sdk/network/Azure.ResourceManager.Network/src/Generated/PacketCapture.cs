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
    /// <summary> A Class representing a PacketCapture along with the instance operations that can be performed on it. </summary>
    public partial class PacketCapture : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PacketCapturesRestOperations _restClient;
        private readonly PacketCaptureData _data;

        /// <summary> Initializes a new instance of the <see cref="PacketCapture"/> class for mocking. </summary>
        protected PacketCapture()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PacketCapture"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal PacketCapture(ArmResource options, PacketCaptureData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new PacketCapturesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="PacketCapture"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PacketCapture(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new PacketCapturesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/networkWatchers/packetCaptures";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PacketCaptureData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets a packet capture session by name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<PacketCapture>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PacketCapture(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a packet capture session by name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PacketCapture> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PacketCapture(this, response.Value), response.GetRawResponse());
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

        /// <summary> Deletes the specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.Delete");
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

        /// <summary> Deletes the specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.Delete");
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

        /// <summary> Deletes the specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<PacketCaptureDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new PacketCaptureDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PacketCaptureDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new PacketCaptureDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops a specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> StopAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.Stop");
            scope.Start();
            try
            {
                var operation = await StartStopAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops a specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Stop(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.Stop");
            scope.Start();
            try
            {
                var operation = StartStop(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops a specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<PacketCaptureStopOperation> StartStopAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.StartStop");
            scope.Start();
            try
            {
                var response = await _restClient.StopAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new PacketCaptureStopOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops a specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PacketCaptureStopOperation StartStop(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.StartStop");
            scope.Start();
            try
            {
                var response = _restClient.Stop(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new PacketCaptureStopOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query the status of a running packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<PacketCaptureQueryStatusResult>> GetStatusAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.GetStatus");
            scope.Start();
            try
            {
                var operation = await StartGetStatusAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query the status of a running packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PacketCaptureQueryStatusResult> GetStatus(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.GetStatus");
            scope.Start();
            try
            {
                var operation = StartGetStatus(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query the status of a running packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<PacketCaptureGetStatusOperation> StartGetStatusAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.StartGetStatus");
            scope.Start();
            try
            {
                var response = await _restClient.GetStatusAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new PacketCaptureGetStatusOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetStatusRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query the status of a running packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PacketCaptureGetStatusOperation StartGetStatus(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapture.StartGetStatus");
            scope.Start();
            try
            {
                var response = _restClient.GetStatus(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new PacketCaptureGetStatusOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetStatusRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
