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

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="BackupRecoveryPointResource"/> and their operations.
    /// Each <see cref="BackupRecoveryPointResource"/> in the collection will belong to the same instance of <see cref="BackupProtectedItemResource"/>.
    /// To get a <see cref="BackupRecoveryPointCollection"/> instance call the GetBackupRecoveryPoints method from an instance of <see cref="BackupProtectedItemResource"/>.
    /// </summary>
    public partial class BackupRecoveryPointCollection : ArmCollection, IEnumerable<BackupRecoveryPointResource>, IAsyncEnumerable<BackupRecoveryPointResource>
    {
        private readonly ClientDiagnostics _backupRecoveryPointRecoveryPointsClientDiagnostics;
        private readonly RecoveryPointsRestOperations _backupRecoveryPointRecoveryPointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BackupRecoveryPointCollection"/> class for mocking. </summary>
        protected BackupRecoveryPointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackupRecoveryPointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BackupRecoveryPointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _backupRecoveryPointRecoveryPointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", BackupRecoveryPointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BackupRecoveryPointResource.ResourceType, out string backupRecoveryPointRecoveryPointsApiVersion);
            _backupRecoveryPointRecoveryPointsRestClient = new RecoveryPointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupRecoveryPointRecoveryPointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BackupProtectedItemResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BackupProtectedItemResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Provides the information of the backed up data identified using RecoveryPointID. This is an asynchronous operation.
        /// To know the status of the operation, call the GetProtectedItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointId"> RecoveryPointID represents the backed up data to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public virtual async Task<Response<BackupRecoveryPointResource>> GetAsync(string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var scope = _backupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("BackupRecoveryPointCollection.Get");
            scope.Start();
            try
            {
                var response = await _backupRecoveryPointRecoveryPointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recoveryPointId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides the information of the backed up data identified using RecoveryPointID. This is an asynchronous operation.
        /// To know the status of the operation, call the GetProtectedItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointId"> RecoveryPointID represents the backed up data to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public virtual Response<BackupRecoveryPointResource> Get(string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var scope = _backupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("BackupRecoveryPointCollection.Get");
            scope.Start();
            try
            {
                var response = _backupRecoveryPointRecoveryPointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recoveryPointId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the backup copies for the backed up item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BackupRecoveryPointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BackupRecoveryPointResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _backupRecoveryPointRecoveryPointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _backupRecoveryPointRecoveryPointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new BackupRecoveryPointResource(Client, BackupRecoveryPointData.DeserializeBackupRecoveryPointData(e)), _backupRecoveryPointRecoveryPointsClientDiagnostics, Pipeline, "BackupRecoveryPointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the backup copies for the backed up item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BackupRecoveryPointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BackupRecoveryPointResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _backupRecoveryPointRecoveryPointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _backupRecoveryPointRecoveryPointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new BackupRecoveryPointResource(Client, BackupRecoveryPointData.DeserializeBackupRecoveryPointData(e)), _backupRecoveryPointRecoveryPointsClientDiagnostics, Pipeline, "BackupRecoveryPointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointId"> RecoveryPointID represents the backed up data to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var scope = _backupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("BackupRecoveryPointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _backupRecoveryPointRecoveryPointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recoveryPointId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointId"> RecoveryPointID represents the backed up data to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public virtual Response<bool> Exists(string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var scope = _backupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("BackupRecoveryPointCollection.Exists");
            scope.Start();
            try
            {
                var response = _backupRecoveryPointRecoveryPointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recoveryPointId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointId"> RecoveryPointID represents the backed up data to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public virtual async Task<NullableResponse<BackupRecoveryPointResource>> GetIfExistsAsync(string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var scope = _backupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("BackupRecoveryPointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _backupRecoveryPointRecoveryPointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recoveryPointId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BackupRecoveryPointResource>(response.GetRawResponse());
                return Response.FromValue(new BackupRecoveryPointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoveryPointId"> RecoveryPointID represents the backed up data to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public virtual NullableResponse<BackupRecoveryPointResource> GetIfExists(string recoveryPointId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPointId, nameof(recoveryPointId));

            using var scope = _backupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("BackupRecoveryPointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _backupRecoveryPointRecoveryPointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, recoveryPointId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BackupRecoveryPointResource>(response.GetRawResponse());
                return Response.FromValue(new BackupRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BackupRecoveryPointResource> IEnumerable<BackupRecoveryPointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BackupRecoveryPointResource> IAsyncEnumerable<BackupRecoveryPointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
