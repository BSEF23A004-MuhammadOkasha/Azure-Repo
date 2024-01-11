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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerConnectionPolicyResource"/> and their operations.
    /// Each <see cref="SqlServerConnectionPolicyResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get a <see cref="SqlServerConnectionPolicyCollection"/> instance call the GetSqlServerConnectionPolicies method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class SqlServerConnectionPolicyCollection : ArmCollection, IEnumerable<SqlServerConnectionPolicyResource>, IAsyncEnumerable<SqlServerConnectionPolicyResource>
    {
        private readonly ClientDiagnostics _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics;
        private readonly ServerConnectionPoliciesRestOperations _sqlServerConnectionPolicyServerConnectionPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerConnectionPolicyCollection"/> class for mocking. </summary>
        protected SqlServerConnectionPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerConnectionPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerConnectionPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerConnectionPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerConnectionPolicyResource.ResourceType, out string sqlServerConnectionPolicyServerConnectionPoliciesApiVersion);
            _sqlServerConnectionPolicyServerConnectionPoliciesRestClient = new ServerConnectionPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerConnectionPolicyServerConnectionPoliciesApiVersion);
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
        /// Updates a server connection policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/connectionPolicies/{connectionPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConnectionPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerConnectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="data"> The required parameters for updating a server connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerConnectionPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, ConnectionPolicyName connectionPolicyName, SqlServerConnectionPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics.CreateScope("SqlServerConnectionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerConnectionPolicyResource>(new SqlServerConnectionPolicyOperationSource(Client), _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics, Pipeline, _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates a server connection policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/connectionPolicies/{connectionPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConnectionPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerConnectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="data"> The required parameters for updating a server connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerConnectionPolicyResource> CreateOrUpdate(WaitUntil waitUntil, ConnectionPolicyName connectionPolicyName, SqlServerConnectionPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics.CreateScope("SqlServerConnectionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerConnectionPolicyResource>(new SqlServerConnectionPolicyOperationSource(Client), _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics, Pipeline, _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a server connection policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/connectionPolicies/{connectionPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConnectionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerConnectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerConnectionPolicyResource>> GetAsync(ConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics.CreateScope("SqlServerConnectionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerConnectionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server connection policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/connectionPolicies/{connectionPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConnectionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerConnectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerConnectionPolicyResource> Get(ConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics.CreateScope("SqlServerConnectionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerConnectionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists connection policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/connectionPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConnectionPolicies_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerConnectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerConnectionPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerConnectionPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlServerConnectionPolicyResource(Client, SqlServerConnectionPolicyData.DeserializeSqlServerConnectionPolicyData(e)), _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics, Pipeline, "SqlServerConnectionPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists connection policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/connectionPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConnectionPolicies_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerConnectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerConnectionPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerConnectionPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlServerConnectionPolicyResource(Client, SqlServerConnectionPolicyData.DeserializeSqlServerConnectionPolicyData(e)), _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics, Pipeline, "SqlServerConnectionPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/connectionPolicies/{connectionPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConnectionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerConnectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(ConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics.CreateScope("SqlServerConnectionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/connectionPolicies/{connectionPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConnectionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerConnectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(ConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics.CreateScope("SqlServerConnectionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/connectionPolicies/{connectionPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConnectionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerConnectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<SqlServerConnectionPolicyResource>> GetIfExistsAsync(ConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics.CreateScope("SqlServerConnectionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerConnectionPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerConnectionPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/connectionPolicies/{connectionPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConnectionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerConnectionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<SqlServerConnectionPolicyResource> GetIfExists(ConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerConnectionPolicyServerConnectionPoliciesClientDiagnostics.CreateScope("SqlServerConnectionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerConnectionPolicyServerConnectionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerConnectionPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerConnectionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerConnectionPolicyResource> IEnumerable<SqlServerConnectionPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerConnectionPolicyResource> IAsyncEnumerable<SqlServerConnectionPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
