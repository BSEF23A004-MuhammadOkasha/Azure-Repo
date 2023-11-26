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
using Azure.ResourceManager.Redis.Models;

namespace Azure.ResourceManager.Redis
{
    /// <summary>
    /// A class representing a collection of <see cref="RedisPatchScheduleResource"/> and their operations.
    /// Each <see cref="RedisPatchScheduleResource"/> in the collection will belong to the same instance of <see cref="RedisResource"/>.
    /// To get a <see cref="RedisPatchScheduleCollection"/> instance call the GetRedisPatchSchedules method from an instance of <see cref="RedisResource"/>.
    /// </summary>
    public partial class RedisPatchScheduleCollection : ArmCollection, IEnumerable<RedisPatchScheduleResource>, IAsyncEnumerable<RedisPatchScheduleResource>
    {
        private readonly ClientDiagnostics _redisPatchSchedulePatchSchedulesClientDiagnostics;
        private readonly PatchSchedulesRestOperations _redisPatchSchedulePatchSchedulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="RedisPatchScheduleCollection"/> class for mocking. </summary>
        protected RedisPatchScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RedisPatchScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RedisPatchScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _redisPatchSchedulePatchSchedulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Redis", RedisPatchScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RedisPatchScheduleResource.ResourceType, out string redisPatchSchedulePatchSchedulesApiVersion);
            _redisPatchSchedulePatchSchedulesRestClient = new PatchSchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, redisPatchSchedulePatchSchedulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RedisResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RedisResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or replace the patching schedule for Redis cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/patchSchedules/{default}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PatchSchedules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="defaultName"> Default string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="data"> Parameters to set the patching schedule for Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RedisPatchScheduleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, RedisPatchScheduleDefaultName defaultName, RedisPatchScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _redisPatchSchedulePatchSchedulesClientDiagnostics.CreateScope("RedisPatchScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _redisPatchSchedulePatchSchedulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RedisArmOperation<RedisPatchScheduleResource>(Response.FromValue(new RedisPatchScheduleResource(Client, response), response.GetRawResponse()));
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
        /// Create or replace the patching schedule for Redis cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/patchSchedules/{default}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PatchSchedules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="defaultName"> Default string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="data"> Parameters to set the patching schedule for Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RedisPatchScheduleResource> CreateOrUpdate(WaitUntil waitUntil, RedisPatchScheduleDefaultName defaultName, RedisPatchScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _redisPatchSchedulePatchSchedulesClientDiagnostics.CreateScope("RedisPatchScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _redisPatchSchedulePatchSchedulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultName, data, cancellationToken);
                var operation = new RedisArmOperation<RedisPatchScheduleResource>(Response.FromValue(new RedisPatchScheduleResource(Client, response), response.GetRawResponse()));
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
        /// Gets the patching schedule of a redis cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/patchSchedules/{default}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PatchSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="defaultName"> Default string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RedisPatchScheduleResource>> GetAsync(RedisPatchScheduleDefaultName defaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _redisPatchSchedulePatchSchedulesClientDiagnostics.CreateScope("RedisPatchScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _redisPatchSchedulePatchSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RedisPatchScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the patching schedule of a redis cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/patchSchedules/{default}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PatchSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="defaultName"> Default string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RedisPatchScheduleResource> Get(RedisPatchScheduleDefaultName defaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _redisPatchSchedulePatchSchedulesClientDiagnostics.CreateScope("RedisPatchScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _redisPatchSchedulePatchSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RedisPatchScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all patch schedules in the specified redis cache (there is only one).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/patchSchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PatchSchedules_ListByRedisResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RedisPatchScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RedisPatchScheduleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _redisPatchSchedulePatchSchedulesRestClient.CreateListByRedisResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _redisPatchSchedulePatchSchedulesRestClient.CreateListByRedisResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RedisPatchScheduleResource(Client, RedisPatchScheduleData.DeserializeRedisPatchScheduleData(e)), _redisPatchSchedulePatchSchedulesClientDiagnostics, Pipeline, "RedisPatchScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all patch schedules in the specified redis cache (there is only one).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/patchSchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PatchSchedules_ListByRedisResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RedisPatchScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RedisPatchScheduleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _redisPatchSchedulePatchSchedulesRestClient.CreateListByRedisResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _redisPatchSchedulePatchSchedulesRestClient.CreateListByRedisResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RedisPatchScheduleResource(Client, RedisPatchScheduleData.DeserializeRedisPatchScheduleData(e)), _redisPatchSchedulePatchSchedulesClientDiagnostics, Pipeline, "RedisPatchScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/patchSchedules/{default}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PatchSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="defaultName"> Default string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(RedisPatchScheduleDefaultName defaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _redisPatchSchedulePatchSchedulesClientDiagnostics.CreateScope("RedisPatchScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _redisPatchSchedulePatchSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/patchSchedules/{default}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PatchSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="defaultName"> Default string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(RedisPatchScheduleDefaultName defaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _redisPatchSchedulePatchSchedulesClientDiagnostics.CreateScope("RedisPatchScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _redisPatchSchedulePatchSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/patchSchedules/{default}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PatchSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="defaultName"> Default string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<RedisPatchScheduleResource>> GetIfExistsAsync(RedisPatchScheduleDefaultName defaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _redisPatchSchedulePatchSchedulesClientDiagnostics.CreateScope("RedisPatchScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _redisPatchSchedulePatchSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RedisPatchScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new RedisPatchScheduleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/patchSchedules/{default}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PatchSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="defaultName"> Default string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<RedisPatchScheduleResource> GetIfExists(RedisPatchScheduleDefaultName defaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _redisPatchSchedulePatchSchedulesClientDiagnostics.CreateScope("RedisPatchScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _redisPatchSchedulePatchSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, defaultName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RedisPatchScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new RedisPatchScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RedisPatchScheduleResource> IEnumerable<RedisPatchScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RedisPatchScheduleResource> IAsyncEnumerable<RedisPatchScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
