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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="DataCollectionRuleResource"/> and their operations.
    /// Each <see cref="DataCollectionRuleResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DataCollectionRuleCollection"/> instance call the GetDataCollectionRules method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DataCollectionRuleCollection : ArmCollection, IEnumerable<DataCollectionRuleResource>, IAsyncEnumerable<DataCollectionRuleResource>
    {
        private readonly ClientDiagnostics _dataCollectionRuleClientDiagnostics;
        private readonly DataCollectionRulesRestOperations _dataCollectionRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataCollectionRuleCollection"/> class for mocking. </summary>
        protected DataCollectionRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataCollectionRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataCollectionRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataCollectionRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", DataCollectionRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataCollectionRuleResource.ResourceType, out string dataCollectionRuleApiVersion);
            _dataCollectionRuleRestClient = new DataCollectionRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataCollectionRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a data collection rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRules_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataCollectionRuleName"> The name of the data collection rule. The name is case insensitive. </param>
        /// <param name="data"> The payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataCollectionRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataCollectionRuleName, DataCollectionRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionRuleName, nameof(dataCollectionRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataCollectionRuleClientDiagnostics.CreateScope("DataCollectionRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionRuleName, data, cancellationToken).ConfigureAwait(false);
                var uri = _dataCollectionRuleRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionRuleName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new MonitorArmOperation<DataCollectionRuleResource>(Response.FromValue(new DataCollectionRuleResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Creates or updates a data collection rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRules_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataCollectionRuleName"> The name of the data collection rule. The name is case insensitive. </param>
        /// <param name="data"> The payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataCollectionRuleResource> CreateOrUpdate(WaitUntil waitUntil, string dataCollectionRuleName, DataCollectionRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionRuleName, nameof(dataCollectionRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataCollectionRuleClientDiagnostics.CreateScope("DataCollectionRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionRuleName, data, cancellationToken);
                var uri = _dataCollectionRuleRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionRuleName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new MonitorArmOperation<DataCollectionRuleResource>(Response.FromValue(new DataCollectionRuleResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Returns the specified data collection rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionRuleName"> The name of the data collection rule. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionRuleName"/> is null. </exception>
        public virtual async Task<Response<DataCollectionRuleResource>> GetAsync(string dataCollectionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionRuleName, nameof(dataCollectionRuleName));

            using var scope = _dataCollectionRuleClientDiagnostics.CreateScope("DataCollectionRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataCollectionRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the specified data collection rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionRuleName"> The name of the data collection rule. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionRuleName"/> is null. </exception>
        public virtual Response<DataCollectionRuleResource> Get(string dataCollectionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionRuleName, nameof(dataCollectionRuleName));

            using var scope = _dataCollectionRuleClientDiagnostics.CreateScope("DataCollectionRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataCollectionRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all data collection rules in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRules_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataCollectionRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataCollectionRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataCollectionRuleRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataCollectionRuleRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataCollectionRuleResource(Client, DataCollectionRuleData.DeserializeDataCollectionRuleData(e)), _dataCollectionRuleClientDiagnostics, Pipeline, "DataCollectionRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all data collection rules in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRules_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataCollectionRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataCollectionRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataCollectionRuleRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataCollectionRuleRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataCollectionRuleResource(Client, DataCollectionRuleData.DeserializeDataCollectionRuleData(e)), _dataCollectionRuleClientDiagnostics, Pipeline, "DataCollectionRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionRuleName"> The name of the data collection rule. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataCollectionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionRuleName, nameof(dataCollectionRuleName));

            using var scope = _dataCollectionRuleClientDiagnostics.CreateScope("DataCollectionRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionRuleName"> The name of the data collection rule. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataCollectionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionRuleName, nameof(dataCollectionRuleName));

            using var scope = _dataCollectionRuleClientDiagnostics.CreateScope("DataCollectionRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionRuleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionRuleName"> The name of the data collection rule. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionRuleName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataCollectionRuleResource>> GetIfExistsAsync(string dataCollectionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionRuleName, nameof(dataCollectionRuleName));

            using var scope = _dataCollectionRuleClientDiagnostics.CreateScope("DataCollectionRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataCollectionRuleResource>(response.GetRawResponse());
                return Response.FromValue(new DataCollectionRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dataCollectionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionRuleName"> The name of the data collection rule. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionRuleName"/> is null. </exception>
        public virtual NullableResponse<DataCollectionRuleResource> GetIfExists(string dataCollectionRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionRuleName, nameof(dataCollectionRuleName));

            using var scope = _dataCollectionRuleClientDiagnostics.CreateScope("DataCollectionRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataCollectionRuleResource>(response.GetRawResponse());
                return Response.FromValue(new DataCollectionRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataCollectionRuleResource> IEnumerable<DataCollectionRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataCollectionRuleResource> IAsyncEnumerable<DataCollectionRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
