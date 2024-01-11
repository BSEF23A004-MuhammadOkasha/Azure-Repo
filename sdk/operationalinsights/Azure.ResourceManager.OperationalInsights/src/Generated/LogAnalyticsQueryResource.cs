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

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A Class representing a LogAnalyticsQuery along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="LogAnalyticsQueryResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetLogAnalyticsQueryResource method.
    /// Otherwise you can get one from its parent resource <see cref="LogAnalyticsQueryPackResource"/> using the GetLogAnalyticsQuery method.
    /// </summary>
    public partial class LogAnalyticsQueryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LogAnalyticsQueryResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="queryPackName"> The queryPackName. </param>
        /// <param name="id"> The id. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string queryPackName, string id)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _logAnalyticsQueryQueriesClientDiagnostics;
        private readonly QueriesRestOperations _logAnalyticsQueryQueriesRestClient;
        private readonly LogAnalyticsQueryData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.OperationalInsights/queryPacks/queries";

        /// <summary> Initializes a new instance of the <see cref="LogAnalyticsQueryResource"/> class for mocking. </summary>
        protected LogAnalyticsQueryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogAnalyticsQueryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LogAnalyticsQueryResource(ArmClient client, LogAnalyticsQueryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LogAnalyticsQueryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LogAnalyticsQueryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logAnalyticsQueryQueriesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string logAnalyticsQueryQueriesApiVersion);
            _logAnalyticsQueryQueriesRestClient = new QueriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logAnalyticsQueryQueriesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LogAnalyticsQueryData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a specific Log Analytics Query defined within a Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogAnalyticsQueryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LogAnalyticsQueryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryResource.Get");
            scope.Start();
            try
            {
                var response = await _logAnalyticsQueryQueriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogAnalyticsQueryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific Log Analytics Query defined within a Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogAnalyticsQueryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LogAnalyticsQueryResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryResource.Get");
            scope.Start();
            try
            {
                var response = _logAnalyticsQueryQueriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogAnalyticsQueryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a specific Query defined within an Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogAnalyticsQueryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryResource.Delete");
            scope.Start();
            try
            {
                var response = await _logAnalyticsQueryQueriesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _logAnalyticsQueryQueriesRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new OperationalInsightsArmOperation(response, operationId);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a specific Query defined within an Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogAnalyticsQueryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryResource.Delete");
            scope.Start();
            try
            {
                var response = _logAnalyticsQueryQueriesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _logAnalyticsQueryQueriesRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new OperationalInsightsArmOperation(response, operationId);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Adds or Updates a specific Query within a Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogAnalyticsQueryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Properties that need to be specified to create a new query and add it to a Log Analytics QueryPack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<LogAnalyticsQueryResource>> UpdateAsync(LogAnalyticsQueryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryResource.Update");
            scope.Start();
            try
            {
                var response = await _logAnalyticsQueryQueriesRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new LogAnalyticsQueryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Adds or Updates a specific Query within a Log Analytics QueryPack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/queryPacks/{queryPackName}/queries/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Queries_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogAnalyticsQueryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Properties that need to be specified to create a new query and add it to a Log Analytics QueryPack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<LogAnalyticsQueryResource> Update(LogAnalyticsQueryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _logAnalyticsQueryQueriesClientDiagnostics.CreateScope("LogAnalyticsQueryResource.Update");
            scope.Start();
            try
            {
                var response = _logAnalyticsQueryQueriesRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new LogAnalyticsQueryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
