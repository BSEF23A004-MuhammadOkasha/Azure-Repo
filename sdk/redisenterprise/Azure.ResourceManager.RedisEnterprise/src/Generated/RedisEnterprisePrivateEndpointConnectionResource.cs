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

namespace Azure.ResourceManager.RedisEnterprise
{
    /// <summary>
    /// A Class representing a RedisEnterprisePrivateEndpointConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="RedisEnterprisePrivateEndpointConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetRedisEnterprisePrivateEndpointConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="RedisEnterpriseClusterResource" /> using the GetRedisEnterprisePrivateEndpointConnection method.
    /// </summary>
    public partial class RedisEnterprisePrivateEndpointConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RedisEnterprisePrivateEndpointConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterName, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics;
        private readonly PrivateEndpointConnectionsRestOperations _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsRestClient;
        private readonly RedisEnterprisePrivateEndpointConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="RedisEnterprisePrivateEndpointConnectionResource"/> class for mocking. </summary>
        protected RedisEnterprisePrivateEndpointConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RedisEnterprisePrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RedisEnterprisePrivateEndpointConnectionResource(ArmClient client, RedisEnterprisePrivateEndpointConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RedisEnterprisePrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RedisEnterprisePrivateEndpointConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RedisEnterprise", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
            _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsRestClient = new PrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Cache/redisEnterprise/privateEndpointConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RedisEnterprisePrivateEndpointConnectionData Data
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
        /// Gets the specified private endpoint connection associated with the RedisEnterprise cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RedisEnterprisePrivateEndpointConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("RedisEnterprisePrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RedisEnterprisePrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified private endpoint connection associated with the RedisEnterprise cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RedisEnterprisePrivateEndpointConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("RedisEnterprisePrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RedisEnterprisePrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified private endpoint connection associated with the RedisEnterprise cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("RedisEnterprisePrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new RedisEnterpriseArmOperation(response);
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
        /// Deletes the specified private endpoint connection associated with the RedisEnterprise cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("RedisEnterprisePrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new RedisEnterpriseArmOperation(response);
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
        /// Updates the state of the specified private endpoint connection associated with the RedisEnterprise cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RedisEnterprisePrivateEndpointConnectionResource>> UpdateAsync(WaitUntil waitUntil, RedisEnterprisePrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("RedisEnterprisePrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new RedisEnterpriseArmOperation<RedisEnterprisePrivateEndpointConnectionResource>(new RedisEnterprisePrivateEndpointConnectionOperationSource(Client), _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreatePutRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates the state of the specified private endpoint connection associated with the RedisEnterprise cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RedisEnterprisePrivateEndpointConnectionResource> Update(WaitUntil waitUntil, RedisEnterprisePrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("RedisEnterprisePrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new RedisEnterpriseArmOperation<RedisEnterprisePrivateEndpointConnectionResource>(new RedisEnterprisePrivateEndpointConnectionOperationSource(Client), _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _redisEnterprisePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreatePutRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}
