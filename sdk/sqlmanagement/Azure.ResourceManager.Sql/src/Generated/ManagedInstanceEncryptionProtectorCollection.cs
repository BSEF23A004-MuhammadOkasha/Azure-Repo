// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ManagedInstanceEncryptionProtector and their operations over its parent. </summary>
    public partial class ManagedInstanceEncryptionProtectorCollection : ArmCollection, IEnumerable<ManagedInstanceEncryptionProtector>, IAsyncEnumerable<ManagedInstanceEncryptionProtector>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedInstanceEncryptionProtectorsRestOperations _managedInstanceEncryptionProtectorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceEncryptionProtectorCollection"/> class for mocking. </summary>
        protected ManagedInstanceEncryptionProtectorCollection()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstanceEncryptionProtectorCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagedInstanceEncryptionProtectorCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedInstanceEncryptionProtectorsRestClient = new ManagedInstanceEncryptionProtectorsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ManagedInstance.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/encryptionProtector/{encryptionProtectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceEncryptionProtectors_CreateOrUpdate
        /// <summary> Updates an existing encryption protector. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be updated. </param>
        /// <param name="parameters"> The requested encryption protector resource state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ManagedInstanceEncryptionProtectorCreateOrUpdateOperation CreateOrUpdate(EncryptionProtectorName encryptionProtectorName, ManagedInstanceEncryptionProtectorData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceEncryptionProtectorsRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, encryptionProtectorName, parameters, cancellationToken);
                var operation = new ManagedInstanceEncryptionProtectorCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _managedInstanceEncryptionProtectorsRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, encryptionProtectorName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/encryptionProtector/{encryptionProtectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceEncryptionProtectors_CreateOrUpdate
        /// <summary> Updates an existing encryption protector. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be updated. </param>
        /// <param name="parameters"> The requested encryption protector resource state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ManagedInstanceEncryptionProtectorCreateOrUpdateOperation> CreateOrUpdateAsync(EncryptionProtectorName encryptionProtectorName, ManagedInstanceEncryptionProtectorData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceEncryptionProtectorsRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, encryptionProtectorName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedInstanceEncryptionProtectorCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _managedInstanceEncryptionProtectorsRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, encryptionProtectorName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/encryptionProtector/{encryptionProtectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceEncryptionProtectors_Get
        /// <summary> Gets a managed instance encryption protector. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceEncryptionProtector> Get(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceEncryptionProtectorsRestClient.Get(Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceEncryptionProtector(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/encryptionProtector/{encryptionProtectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceEncryptionProtectors_Get
        /// <summary> Gets a managed instance encryption protector. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceEncryptionProtector>> GetAsync(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceEncryptionProtectorsRestClient.GetAsync(Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceEncryptionProtector(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceEncryptionProtector> GetIfExists(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedInstanceEncryptionProtectorsRestClient.Get(Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ManagedInstanceEncryptionProtector>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedInstanceEncryptionProtector(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceEncryptionProtector>> GetIfExistsAsync(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _managedInstanceEncryptionProtectorsRestClient.GetAsync(Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ManagedInstanceEncryptionProtector>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedInstanceEncryptionProtector(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> CheckIfExists(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(encryptionProtectorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(encryptionProtectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/encryptionProtector
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceEncryptionProtectors_ListByInstance
        /// <summary> Gets a list of managed instance encryption protectors. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceEncryptionProtector" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceEncryptionProtector> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ManagedInstanceEncryptionProtector> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceEncryptionProtectorsRestClient.ListByInstance(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceEncryptionProtector(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceEncryptionProtector> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceEncryptionProtectorsRestClient.ListByInstanceNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceEncryptionProtector(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/encryptionProtector
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedInstanceEncryptionProtectors_ListByInstance
        /// <summary> Gets a list of managed instance encryption protectors. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceEncryptionProtector" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceEncryptionProtector> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstanceEncryptionProtector>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceEncryptionProtectorsRestClient.ListByInstanceAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceEncryptionProtector(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceEncryptionProtector>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceEncryptionProtectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceEncryptionProtectorsRestClient.ListByInstanceNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceEncryptionProtector(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ManagedInstanceEncryptionProtector> IEnumerable<ManagedInstanceEncryptionProtector>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceEncryptionProtector> IAsyncEnumerable<ManagedInstanceEncryptionProtector>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ManagedInstanceEncryptionProtector, ManagedInstanceEncryptionProtectorData> Construct() { }
    }
}
