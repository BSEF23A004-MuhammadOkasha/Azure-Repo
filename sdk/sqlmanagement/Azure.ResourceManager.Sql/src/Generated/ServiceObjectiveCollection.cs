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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServiceObjective and their operations over its parent. </summary>
    public partial class ServiceObjectiveCollection : ArmCollection, IEnumerable<ServiceObjective>, IAsyncEnumerable<ServiceObjective>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ServiceObjectivesRestOperations _serviceObjectivesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceObjectiveCollection"/> class for mocking. </summary>
        protected ServiceObjectiveCollection()
        {
        }

        /// <summary> Initializes a new instance of ServiceObjectiveCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServiceObjectiveCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _serviceObjectivesRestClient = new ServiceObjectivesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Server.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServiceObjectives_Get
        /// <summary> Gets a database service objective. </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual Response<ServiceObjective> Get(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            if (serviceObjectiveName == null)
            {
                throw new ArgumentNullException(nameof(serviceObjectiveName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceObjectiveCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceObjectivesRestClient.Get(Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceObjective(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServiceObjectives_Get
        /// <summary> Gets a database service objective. </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public async virtual Task<Response<ServiceObjective>> GetAsync(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            if (serviceObjectiveName == null)
            {
                throw new ArgumentNullException(nameof(serviceObjectiveName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceObjectiveCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceObjectivesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServiceObjective(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual Response<ServiceObjective> GetIfExists(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            if (serviceObjectiveName == null)
            {
                throw new ArgumentNullException(nameof(serviceObjectiveName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceObjectiveCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceObjectivesRestClient.Get(Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServiceObjective>(null, response.GetRawResponse())
                    : Response.FromValue(new ServiceObjective(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public async virtual Task<Response<ServiceObjective>> GetIfExistsAsync(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            if (serviceObjectiveName == null)
            {
                throw new ArgumentNullException(nameof(serviceObjectiveName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceObjectiveCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _serviceObjectivesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServiceObjective>(null, response.GetRawResponse())
                    : Response.FromValue(new ServiceObjective(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            if (serviceObjectiveName == null)
            {
                throw new ArgumentNullException(nameof(serviceObjectiveName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceObjectiveCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(serviceObjectiveName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            if (serviceObjectiveName == null)
            {
                throw new ArgumentNullException(nameof(serviceObjectiveName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceObjectiveCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(serviceObjectiveName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServiceObjectives_ListByServer
        /// <summary> Returns database service objectives. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceObjective" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceObjective> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServiceObjective> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceObjectiveCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceObjectivesRestClient.ListByServer(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceObjective(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServiceObjectives_ListByServer
        /// <summary> Returns database service objectives. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceObjective" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceObjective> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceObjective>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceObjectiveCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceObjectivesRestClient.ListByServerAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceObjective(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<ServiceObjective> IEnumerable<ServiceObjective>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceObjective> IAsyncEnumerable<ServiceObjective>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ServiceObjective, ServiceObjectiveData> Construct() { }
    }
}
