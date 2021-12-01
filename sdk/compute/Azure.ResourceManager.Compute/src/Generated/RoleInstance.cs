// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A Class representing a RoleInstance along with the instance operations that can be performed on it. </summary>
    public partial class RoleInstance : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CloudServiceRoleInstancesRestOperations _cloudServiceRoleInstancesRestClient;
        private readonly RoleInstanceData _data;

        /// <summary> Initializes a new instance of the <see cref="RoleInstance"/> class for mocking. </summary>
        protected RoleInstance()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RoleInstance"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal RoleInstance(ArmResource options, RoleInstanceData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _cloudServiceRoleInstancesRestClient = new CloudServiceRoleInstancesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="RoleInstance"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RoleInstance(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _cloudServiceRoleInstancesRestClient = new CloudServiceRoleInstancesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="RoleInstance"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RoleInstance(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _cloudServiceRoleInstancesRestClient = new CloudServiceRoleInstancesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/cloudServices/roleInstances";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RoleInstanceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets a role instance from a cloud service. </summary>
        /// <param name="expand"> The expand expression to apply to the operation. &apos;UserData&apos; is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<RoleInstance>> GetAsync(InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceRoleInstancesRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RoleInstance(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a role instance from a cloud service. </summary>
        /// <param name="expand"> The expand expression to apply to the operation. &apos;UserData&apos; is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RoleInstance> Get(InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceRoleInstancesRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleInstance(this, response.Value), response.GetRawResponse());
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

        /// <summary> Deletes a role instance from a cloud service. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<CloudServiceRoleInstanceDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.Delete");
            scope.Start();
            try
            {
                var response = await _cloudServiceRoleInstancesRestClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CloudServiceRoleInstanceDeleteOperation(_clientDiagnostics, Pipeline, _cloudServiceRoleInstancesRestClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a role instance from a cloud service. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual CloudServiceRoleInstanceDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.Delete");
            scope.Start();
            try
            {
                var response = _cloudServiceRoleInstancesRestClient.Delete(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CloudServiceRoleInstanceDeleteOperation(_clientDiagnostics, Pipeline, _cloudServiceRoleInstancesRestClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about the run-time state of a role instance in a cloud service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<RoleInstanceView>> GetInstanceViewAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.GetInstanceView");
            scope.Start();
            try
            {
                var response = await _cloudServiceRoleInstancesRestClient.GetInstanceViewAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about the run-time state of a role instance in a cloud service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RoleInstanceView> GetInstanceView(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.GetInstanceView");
            scope.Start();
            try
            {
                var response = _cloudServiceRoleInstancesRestClient.GetInstanceView(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The Reboot Role Instance asynchronous operation requests a reboot of a role instance in the cloud service. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<CloudServiceRoleInstanceRestartOperation> RestartAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.Restart");
            scope.Start();
            try
            {
                var response = await _cloudServiceRoleInstancesRestClient.RestartAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CloudServiceRoleInstanceRestartOperation(_clientDiagnostics, Pipeline, _cloudServiceRoleInstancesRestClient.CreateRestartRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The Reboot Role Instance asynchronous operation requests a reboot of a role instance in the cloud service. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual CloudServiceRoleInstanceRestartOperation Restart(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.Restart");
            scope.Start();
            try
            {
                var response = _cloudServiceRoleInstancesRestClient.Restart(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CloudServiceRoleInstanceRestartOperation(_clientDiagnostics, Pipeline, _cloudServiceRoleInstancesRestClient.CreateRestartRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The Reimage Role Instance asynchronous operation reinstalls the operating system on instances of web roles or worker roles. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<CloudServiceRoleInstanceReimageOperation> ReimageAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.Reimage");
            scope.Start();
            try
            {
                var response = await _cloudServiceRoleInstancesRestClient.ReimageAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CloudServiceRoleInstanceReimageOperation(_clientDiagnostics, Pipeline, _cloudServiceRoleInstancesRestClient.CreateReimageRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The Reimage Role Instance asynchronous operation reinstalls the operating system on instances of web roles or worker roles. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual CloudServiceRoleInstanceReimageOperation Reimage(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.Reimage");
            scope.Start();
            try
            {
                var response = _cloudServiceRoleInstancesRestClient.Reimage(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CloudServiceRoleInstanceReimageOperation(_clientDiagnostics, Pipeline, _cloudServiceRoleInstancesRestClient.CreateReimageRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The Rebuild Role Instance asynchronous operation reinstalls the operating system on instances of web roles or worker roles and initializes the storage resources that are used by them. If you do not want to initialize storage resources, you can use Reimage Role Instance. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<CloudServiceRoleInstanceRebuildOperation> RebuildAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.Rebuild");
            scope.Start();
            try
            {
                var response = await _cloudServiceRoleInstancesRestClient.RebuildAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CloudServiceRoleInstanceRebuildOperation(_clientDiagnostics, Pipeline, _cloudServiceRoleInstancesRestClient.CreateRebuildRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The Rebuild Role Instance asynchronous operation reinstalls the operating system on instances of web roles or worker roles and initializes the storage resources that are used by them. If you do not want to initialize storage resources, you can use Reimage Role Instance. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual CloudServiceRoleInstanceRebuildOperation Rebuild(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.Rebuild");
            scope.Start();
            try
            {
                var response = _cloudServiceRoleInstancesRestClient.Rebuild(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CloudServiceRoleInstanceRebuildOperation(_clientDiagnostics, Pipeline, _cloudServiceRoleInstancesRestClient.CreateRebuildRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a remote desktop file for a role instance in a cloud service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<Stream>> GetRemoteDesktopFileAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.GetRemoteDesktopFile");
            scope.Start();
            try
            {
                var response = await _cloudServiceRoleInstancesRestClient.GetRemoteDesktopFileAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a remote desktop file for a role instance in a cloud service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Stream> GetRemoteDesktopFile(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RoleInstance.GetRemoteDesktopFile");
            scope.Start();
            try
            {
                var response = _cloudServiceRoleInstancesRestClient.GetRemoteDesktopFile(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
