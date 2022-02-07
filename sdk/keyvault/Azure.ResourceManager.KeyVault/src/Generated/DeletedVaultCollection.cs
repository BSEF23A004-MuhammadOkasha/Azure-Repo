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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing collection of DeletedVault and their operations over its parent. </summary>
    public partial class DeletedVaultCollection : ArmCollection
    {
        private readonly ClientDiagnostics _deletedVaultVaultsClientDiagnostics;
        private readonly VaultsRestOperations _deletedVaultVaultsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeletedVaultCollection"/> class for mocking. </summary>
        protected DeletedVaultCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedVaultCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeletedVaultCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deletedVaultVaultsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.KeyVault", DeletedVault.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(DeletedVault.ResourceType, out string deletedVaultVaultsApiVersion);
            _deletedVaultVaultsRestClient = new VaultsRestOperations(_deletedVaultVaultsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, deletedVaultVaultsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedVaults/{vaultName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_GetDeleted
        /// <summary> Gets the deleted Azure key vault. </summary>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="vaultName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="vaultName"/> is null. </exception>
        public async virtual Task<Response<DeletedVault>> GetAsync(string location, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _deletedVaultVaultsClientDiagnostics.CreateScope("DeletedVaultCollection.Get");
            scope.Start();
            try
            {
                var response = await _deletedVaultVaultsRestClient.GetDeletedAsync(Id.SubscriptionId, location, vaultName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _deletedVaultVaultsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DeletedVault(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedVaults/{vaultName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_GetDeleted
        /// <summary> Gets the deleted Azure key vault. </summary>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="vaultName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="vaultName"/> is null. </exception>
        public virtual Response<DeletedVault> Get(string location, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _deletedVaultVaultsClientDiagnostics.CreateScope("DeletedVaultCollection.Get");
            scope.Start();
            try
            {
                var response = _deletedVaultVaultsRestClient.GetDeleted(Id.SubscriptionId, location, vaultName, cancellationToken);
                if (response.Value == null)
                    throw _deletedVaultVaultsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedVault(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedVaults/{vaultName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_GetDeleted
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="vaultName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="vaultName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string location, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _deletedVaultVaultsClientDiagnostics.CreateScope("DeletedVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(location, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedVaults/{vaultName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_GetDeleted
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="vaultName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="vaultName"/> is null. </exception>
        public virtual Response<bool> Exists(string location, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _deletedVaultVaultsClientDiagnostics.CreateScope("DeletedVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(location, vaultName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedVaults/{vaultName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_GetDeleted
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="vaultName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="vaultName"/> is null. </exception>
        public async virtual Task<Response<DeletedVault>> GetIfExistsAsync(string location, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _deletedVaultVaultsClientDiagnostics.CreateScope("DeletedVaultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deletedVaultVaultsRestClient.GetDeletedAsync(Id.SubscriptionId, location, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DeletedVault>(null, response.GetRawResponse());
                return Response.FromValue(new DeletedVault(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedVaults/{vaultName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_GetDeleted
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="vaultName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="vaultName"/> is null. </exception>
        public virtual Response<DeletedVault> GetIfExists(string location, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _deletedVaultVaultsClientDiagnostics.CreateScope("DeletedVaultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deletedVaultVaultsRestClient.GetDeleted(Id.SubscriptionId, location, vaultName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DeletedVault>(null, response.GetRawResponse());
                return Response.FromValue(new DeletedVault(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
