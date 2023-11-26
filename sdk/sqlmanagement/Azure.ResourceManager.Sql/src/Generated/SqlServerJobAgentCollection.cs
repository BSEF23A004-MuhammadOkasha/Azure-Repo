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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerJobAgentResource"/> and their operations.
    /// Each <see cref="SqlServerJobAgentResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get a <see cref="SqlServerJobAgentCollection"/> instance call the GetSqlServerJobAgents method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class SqlServerJobAgentCollection : ArmCollection, IEnumerable<SqlServerJobAgentResource>, IAsyncEnumerable<SqlServerJobAgentResource>
    {
        private readonly ClientDiagnostics _sqlServerJobAgentJobAgentsClientDiagnostics;
        private readonly JobAgentsRestOperations _sqlServerJobAgentJobAgentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobAgentCollection"/> class for mocking. </summary>
        protected SqlServerJobAgentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobAgentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerJobAgentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerJobAgentJobAgentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerJobAgentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerJobAgentResource.ResourceType, out string sqlServerJobAgentJobAgentsApiVersion);
            _sqlServerJobAgentJobAgentsRestClient = new JobAgentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobAgentJobAgentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a job agent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobAgents_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobAgentName"> The name of the job agent to be created or updated. </param>
        /// <param name="data"> The requested job agent resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerJobAgentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string jobAgentName, SqlServerJobAgentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerJobAgentJobAgentsClientDiagnostics.CreateScope("SqlServerJobAgentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerJobAgentJobAgentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerJobAgentResource>(new SqlServerJobAgentOperationSource(Client), _sqlServerJobAgentJobAgentsClientDiagnostics, Pipeline, _sqlServerJobAgentJobAgentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a job agent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobAgents_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobAgentName"> The name of the job agent to be created or updated. </param>
        /// <param name="data"> The requested job agent resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerJobAgentResource> CreateOrUpdate(WaitUntil waitUntil, string jobAgentName, SqlServerJobAgentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerJobAgentJobAgentsClientDiagnostics.CreateScope("SqlServerJobAgentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerJobAgentJobAgentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerJobAgentResource>(new SqlServerJobAgentOperationSource(Client), _sqlServerJobAgentJobAgentsClientDiagnostics, Pipeline, _sqlServerJobAgentJobAgentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a job agent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobAgents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual async Task<Response<SqlServerJobAgentResource>> GetAsync(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _sqlServerJobAgentJobAgentsClientDiagnostics.CreateScope("SqlServerJobAgentCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerJobAgentJobAgentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a job agent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobAgents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual Response<SqlServerJobAgentResource> Get(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _sqlServerJobAgentJobAgentsClientDiagnostics.CreateScope("SqlServerJobAgentCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerJobAgentJobAgentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of job agents in a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobAgents_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerJobAgentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerJobAgentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobAgentJobAgentsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobAgentJobAgentsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerJobAgentResource(Client, SqlServerJobAgentData.DeserializeSqlServerJobAgentData(e)), _sqlServerJobAgentJobAgentsClientDiagnostics, Pipeline, "SqlServerJobAgentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of job agents in a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobAgents_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerJobAgentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerJobAgentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobAgentJobAgentsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobAgentJobAgentsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerJobAgentResource(Client, SqlServerJobAgentData.DeserializeSqlServerJobAgentData(e)), _sqlServerJobAgentJobAgentsClientDiagnostics, Pipeline, "SqlServerJobAgentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobAgents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _sqlServerJobAgentJobAgentsClientDiagnostics.CreateScope("SqlServerJobAgentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobAgentJobAgentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobAgents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _sqlServerJobAgentJobAgentsClientDiagnostics.CreateScope("SqlServerJobAgentCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerJobAgentJobAgentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobAgents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlServerJobAgentResource>> GetIfExistsAsync(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _sqlServerJobAgentJobAgentsClientDiagnostics.CreateScope("SqlServerJobAgentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobAgentJobAgentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerJobAgentResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobAgentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobAgents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual NullableResponse<SqlServerJobAgentResource> GetIfExists(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _sqlServerJobAgentJobAgentsClientDiagnostics.CreateScope("SqlServerJobAgentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerJobAgentJobAgentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerJobAgentResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerJobAgentResource> IEnumerable<SqlServerJobAgentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerJobAgentResource> IAsyncEnumerable<SqlServerJobAgentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
