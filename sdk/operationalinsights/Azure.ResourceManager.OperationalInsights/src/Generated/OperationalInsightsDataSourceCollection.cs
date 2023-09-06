// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="OperationalInsightsDataSourceResource" /> and their operations.
    /// Each <see cref="OperationalInsightsDataSourceResource" /> in the collection will belong to the same instance of <see cref="OperationalInsightsWorkspaceResource" />.
    /// To get an <see cref="OperationalInsightsDataSourceCollection" /> instance call the GetOperationalInsightsDataSources method from an instance of <see cref="OperationalInsightsWorkspaceResource" />.
    /// </summary>
    public partial class OperationalInsightsDataSourceCollection : ArmCollection
    {
        private readonly ClientDiagnostics _operationalInsightsDataSourceDataSourcesClientDiagnostics;
        private readonly DataSourcesRestOperations _operationalInsightsDataSourceDataSourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsDataSourceCollection"/> class for mocking. </summary>
        protected OperationalInsightsDataSourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsDataSourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OperationalInsightsDataSourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _operationalInsightsDataSourceDataSourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", OperationalInsightsDataSourceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OperationalInsightsDataSourceResource.ResourceType, out string operationalInsightsDataSourceDataSourcesApiVersion);
            _operationalInsightsDataSourceDataSourcesRestClient = new DataSourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, operationalInsightsDataSourceDataSourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OperationalInsightsWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OperationalInsightsWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a data source.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataSources/{dataSourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSources_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataSourceName"> The name of the datasource resource. </param>
        /// <param name="data"> The parameters required to create or update a datasource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<OperationalInsightsDataSourceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataSourceName, OperationalInsightsDataSourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSourceName, nameof(dataSourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _operationalInsightsDataSourceDataSourcesClientDiagnostics.CreateScope("OperationalInsightsDataSourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _operationalInsightsDataSourceDataSourcesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new OperationalInsightsArmOperation<OperationalInsightsDataSourceResource>(Response.FromValue(new OperationalInsightsDataSourceResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a data source.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataSources/{dataSourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSources_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataSourceName"> The name of the datasource resource. </param>
        /// <param name="data"> The parameters required to create or update a datasource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<OperationalInsightsDataSourceResource> CreateOrUpdate(WaitUntil waitUntil, string dataSourceName, OperationalInsightsDataSourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSourceName, nameof(dataSourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _operationalInsightsDataSourceDataSourcesClientDiagnostics.CreateScope("OperationalInsightsDataSourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _operationalInsightsDataSourceDataSourcesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceName, data, cancellationToken);
                var operation = new OperationalInsightsArmOperation<OperationalInsightsDataSourceResource>(Response.FromValue(new OperationalInsightsDataSourceResource(Client, response), response.GetRawResponse()));
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
        /// Gets a datasource instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataSources/{dataSourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSourceName"> Name of the datasource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceName"/> is null. </exception>
        public virtual async Task<Response<OperationalInsightsDataSourceResource>> GetAsync(string dataSourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSourceName, nameof(dataSourceName));

            using var scope = _operationalInsightsDataSourceDataSourcesClientDiagnostics.CreateScope("OperationalInsightsDataSourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _operationalInsightsDataSourceDataSourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsDataSourceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a datasource instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataSources/{dataSourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSourceName"> Name of the datasource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceName"/> is null. </exception>
        public virtual Response<OperationalInsightsDataSourceResource> Get(string dataSourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSourceName, nameof(dataSourceName));

            using var scope = _operationalInsightsDataSourceDataSourcesClientDiagnostics.CreateScope("OperationalInsightsDataSourceCollection.Get");
            scope.Start();
            try
            {
                var response = _operationalInsightsDataSourceDataSourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsDataSourceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the first page of data source instances in a workspace with the link to the next page.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataSources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSources_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="skipToken"> Starting point of the collection of data source instances. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filter"/> is null. </exception>
        /// <returns> An async collection of <see cref="OperationalInsightsDataSourceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OperationalInsightsDataSourceResource> GetAllAsync(string filter, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(filter, nameof(filter));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _operationalInsightsDataSourceDataSourcesRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _operationalInsightsDataSourceDataSourcesRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new OperationalInsightsDataSourceResource(Client, OperationalInsightsDataSourceData.DeserializeOperationalInsightsDataSourceData(e)), _operationalInsightsDataSourceDataSourcesClientDiagnostics, Pipeline, "OperationalInsightsDataSourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the first page of data source instances in a workspace with the link to the next page.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataSources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSources_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="skipToken"> Starting point of the collection of data source instances. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filter"/> is null. </exception>
        /// <returns> A collection of <see cref="OperationalInsightsDataSourceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OperationalInsightsDataSourceResource> GetAll(string filter, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(filter, nameof(filter));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _operationalInsightsDataSourceDataSourcesRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _operationalInsightsDataSourceDataSourcesRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new OperationalInsightsDataSourceResource(Client, OperationalInsightsDataSourceData.DeserializeOperationalInsightsDataSourceData(e)), _operationalInsightsDataSourceDataSourcesClientDiagnostics, Pipeline, "OperationalInsightsDataSourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataSources/{dataSourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSourceName"> Name of the datasource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataSourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSourceName, nameof(dataSourceName));

            using var scope = _operationalInsightsDataSourceDataSourcesClientDiagnostics.CreateScope("OperationalInsightsDataSourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _operationalInsightsDataSourceDataSourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/dataSources/{dataSourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSourceName"> Name of the datasource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataSourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataSourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataSourceName, nameof(dataSourceName));

            using var scope = _operationalInsightsDataSourceDataSourcesClientDiagnostics.CreateScope("OperationalInsightsDataSourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _operationalInsightsDataSourceDataSourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataSourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
