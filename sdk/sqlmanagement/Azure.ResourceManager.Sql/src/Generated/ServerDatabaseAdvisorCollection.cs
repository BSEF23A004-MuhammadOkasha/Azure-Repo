// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerDatabaseAdvisor and their operations over its parent. </summary>
    public partial class ServerDatabaseAdvisorCollection : ArmCollection, IEnumerable<ServerDatabaseAdvisor>, IAsyncEnumerable<ServerDatabaseAdvisor>
    {
        private readonly ClientDiagnostics _serverDatabaseAdvisorDatabaseAdvisorsClientDiagnostics;
        private readonly DatabaseAdvisorsRestOperations _serverDatabaseAdvisorDatabaseAdvisorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerDatabaseAdvisorCollection"/> class for mocking. </summary>
        protected ServerDatabaseAdvisorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerDatabaseAdvisorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerDatabaseAdvisorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverDatabaseAdvisorDatabaseAdvisorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerDatabaseAdvisor.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServerDatabaseAdvisor.ResourceType, out string serverDatabaseAdvisorDatabaseAdvisorsApiVersion);
            _serverDatabaseAdvisorDatabaseAdvisorsRestClient = new DatabaseAdvisorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverDatabaseAdvisorDatabaseAdvisorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabase.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a database advisor.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// Operation Id: DatabaseAdvisors_Get
        /// </summary>
        /// <param name="advisorName"> The name of the Database Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual async Task<Response<ServerDatabaseAdvisor>> GetAsync(string advisorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var scope = _serverDatabaseAdvisorDatabaseAdvisorsClientDiagnostics.CreateScope("ServerDatabaseAdvisorCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverDatabaseAdvisorDatabaseAdvisorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advisorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseAdvisor(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database advisor.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// Operation Id: DatabaseAdvisors_Get
        /// </summary>
        /// <param name="advisorName"> The name of the Database Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual Response<ServerDatabaseAdvisor> Get(string advisorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var scope = _serverDatabaseAdvisorDatabaseAdvisorsClientDiagnostics.CreateScope("ServerDatabaseAdvisorCollection.Get");
            scope.Start();
            try
            {
                var response = _serverDatabaseAdvisorDatabaseAdvisorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advisorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseAdvisor(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of database advisors.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors
        /// Operation Id: DatabaseAdvisors_ListByDatabase
        /// </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerDatabaseAdvisor" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerDatabaseAdvisor> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerDatabaseAdvisor>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverDatabaseAdvisorDatabaseAdvisorsClientDiagnostics.CreateScope("ServerDatabaseAdvisorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDatabaseAdvisorDatabaseAdvisorsRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Select(value => new ServerDatabaseAdvisor(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Gets a list of database advisors.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors
        /// Operation Id: DatabaseAdvisors_ListByDatabase
        /// </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerDatabaseAdvisor" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerDatabaseAdvisor> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<ServerDatabaseAdvisor> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverDatabaseAdvisorDatabaseAdvisorsClientDiagnostics.CreateScope("ServerDatabaseAdvisorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDatabaseAdvisorDatabaseAdvisorsRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Select(value => new ServerDatabaseAdvisor(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// Operation Id: DatabaseAdvisors_Get
        /// </summary>
        /// <param name="advisorName"> The name of the Database Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string advisorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var scope = _serverDatabaseAdvisorDatabaseAdvisorsClientDiagnostics.CreateScope("ServerDatabaseAdvisorCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(advisorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// Operation Id: DatabaseAdvisors_Get
        /// </summary>
        /// <param name="advisorName"> The name of the Database Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual Response<bool> Exists(string advisorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var scope = _serverDatabaseAdvisorDatabaseAdvisorsClientDiagnostics.CreateScope("ServerDatabaseAdvisorCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(advisorName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// Operation Id: DatabaseAdvisors_Get
        /// </summary>
        /// <param name="advisorName"> The name of the Database Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual async Task<Response<ServerDatabaseAdvisor>> GetIfExistsAsync(string advisorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var scope = _serverDatabaseAdvisorDatabaseAdvisorsClientDiagnostics.CreateScope("ServerDatabaseAdvisorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverDatabaseAdvisorDatabaseAdvisorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advisorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerDatabaseAdvisor>(null, response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseAdvisor(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advisors/{advisorName}
        /// Operation Id: DatabaseAdvisors_Get
        /// </summary>
        /// <param name="advisorName"> The name of the Database Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual Response<ServerDatabaseAdvisor> GetIfExists(string advisorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var scope = _serverDatabaseAdvisorDatabaseAdvisorsClientDiagnostics.CreateScope("ServerDatabaseAdvisorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverDatabaseAdvisorDatabaseAdvisorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advisorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerDatabaseAdvisor>(null, response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseAdvisor(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerDatabaseAdvisor> IEnumerable<ServerDatabaseAdvisor>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerDatabaseAdvisor> IAsyncEnumerable<ServerDatabaseAdvisor>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
