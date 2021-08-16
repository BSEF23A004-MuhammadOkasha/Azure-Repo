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
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A Class representing a DeletedVault along with the instance operations that can be performed on it. </summary>
    public partial class DeletedVault : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DeletedVaultsRestOperations _restClient;
        private readonly DeletedVaultData _data;

        /// <summary> Initializes a new instance of the <see cref="DeletedVault"/> class for mocking. </summary>
        protected DeletedVault()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DeletedVault"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal DeletedVault(ArmResource options, DeletedVaultData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new DeletedVaultsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedVault"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeletedVault(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new DeletedVaultsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.KeyVault/deletedVaults";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DeletedVaultData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets the deleted Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DeletedVault>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedVault.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DeletedVault(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the deleted Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeletedVault> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedVault.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedVault(this, response.Value), response.GetRawResponse());
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

        /// <summary> Permanently deletes the specified vault. aka Purges the deleted Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> PurgeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedVault.Purge");
            scope.Start();
            try
            {
                var operation = await StartPurgeAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Permanently deletes the specified vault. aka Purges the deleted Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Purge(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedVault.Purge");
            scope.Start();
            try
            {
                var operation = StartPurge(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Permanently deletes the specified vault. aka Purges the deleted Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<DeletedVaultPurgeOperation> StartPurgeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedVault.StartPurge");
            scope.Start();
            try
            {
                var response = await _restClient.PurgeAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new DeletedVaultPurgeOperation(_clientDiagnostics, Pipeline, _restClient.CreatePurgeRequest(Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Permanently deletes the specified vault. aka Purges the deleted Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DeletedVaultPurgeOperation StartPurge(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedVault.StartPurge");
            scope.Start();
            try
            {
                var response = _restClient.Purge(Id.Parent.Name, Id.Name, cancellationToken);
                return new DeletedVaultPurgeOperation(_clientDiagnostics, Pipeline, _restClient.CreatePurgeRequest(Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
