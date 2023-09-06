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

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="PostgreSqlLtrServerBackupOperationResource" /> and their operations.
    /// Each <see cref="PostgreSqlLtrServerBackupOperationResource" /> in the collection will belong to the same instance of <see cref="PostgreSqlFlexibleServerResource" />.
    /// To get a <see cref="PostgreSqlLtrServerBackupOperationCollection" /> instance call the GetPostgreSqlLtrServerBackupOperations method from an instance of <see cref="PostgreSqlFlexibleServerResource" />.
    /// </summary>
    public partial class PostgreSqlLtrServerBackupOperationCollection : ArmCollection, IEnumerable<PostgreSqlLtrServerBackupOperationResource>, IAsyncEnumerable<PostgreSqlLtrServerBackupOperationResource>
    {
        private readonly ClientDiagnostics _postgreSqlLtrServerBackupOperationltrBackupOperationsClientDiagnostics;
        private readonly LtrBackupRestOperations _postgreSqlLtrServerBackupOperationltrBackupOperationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlLtrServerBackupOperationCollection"/> class for mocking. </summary>
        protected PostgreSqlLtrServerBackupOperationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlLtrServerBackupOperationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PostgreSqlLtrServerBackupOperationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlLtrServerBackupOperationltrBackupOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", PostgreSqlLtrServerBackupOperationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PostgreSqlLtrServerBackupOperationResource.ResourceType, out string postgreSqlLtrServerBackupOperationltrBackupOperationsApiVersion);
            _postgreSqlLtrServerBackupOperationltrBackupOperationsRestClient = new LtrBackupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlLtrServerBackupOperationltrBackupOperationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PostgreSqlFlexibleServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PostgreSqlFlexibleServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the result of the give long term retention backup operation for the flexible server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/ltrBackupOperations/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ltrBackupOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlLtrServerBackupOperationResource>> GetAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _postgreSqlLtrServerBackupOperationltrBackupOperationsClientDiagnostics.CreateScope("PostgreSqlLtrServerBackupOperationCollection.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlLtrServerBackupOperationltrBackupOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlLtrServerBackupOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the result of the give long term retention backup operation for the flexible server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/ltrBackupOperations/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ltrBackupOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<PostgreSqlLtrServerBackupOperationResource> Get(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _postgreSqlLtrServerBackupOperationltrBackupOperationsClientDiagnostics.CreateScope("PostgreSqlLtrServerBackupOperationCollection.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlLtrServerBackupOperationltrBackupOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlLtrServerBackupOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the result of the give long term retention backup operations for the flexible server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/ltrBackupOperations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ltrBackupOperations_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlLtrServerBackupOperationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlLtrServerBackupOperationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlLtrServerBackupOperationltrBackupOperationsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlLtrServerBackupOperationltrBackupOperationsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new PostgreSqlLtrServerBackupOperationResource(Client, PostgreSqlLtrServerBackupOperationData.DeserializePostgreSqlLtrServerBackupOperationData(e)), _postgreSqlLtrServerBackupOperationltrBackupOperationsClientDiagnostics, Pipeline, "PostgreSqlLtrServerBackupOperationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the result of the give long term retention backup operations for the flexible server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/ltrBackupOperations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ltrBackupOperations_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlLtrServerBackupOperationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlLtrServerBackupOperationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlLtrServerBackupOperationltrBackupOperationsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlLtrServerBackupOperationltrBackupOperationsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new PostgreSqlLtrServerBackupOperationResource(Client, PostgreSqlLtrServerBackupOperationData.DeserializePostgreSqlLtrServerBackupOperationData(e)), _postgreSqlLtrServerBackupOperationltrBackupOperationsClientDiagnostics, Pipeline, "PostgreSqlLtrServerBackupOperationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/ltrBackupOperations/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ltrBackupOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _postgreSqlLtrServerBackupOperationltrBackupOperationsClientDiagnostics.CreateScope("PostgreSqlLtrServerBackupOperationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _postgreSqlLtrServerBackupOperationltrBackupOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/ltrBackupOperations/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ltrBackupOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _postgreSqlLtrServerBackupOperationltrBackupOperationsClientDiagnostics.CreateScope("PostgreSqlLtrServerBackupOperationCollection.Exists");
            scope.Start();
            try
            {
                var response = _postgreSqlLtrServerBackupOperationltrBackupOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PostgreSqlLtrServerBackupOperationResource> IEnumerable<PostgreSqlLtrServerBackupOperationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PostgreSqlLtrServerBackupOperationResource> IAsyncEnumerable<PostgreSqlLtrServerBackupOperationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
