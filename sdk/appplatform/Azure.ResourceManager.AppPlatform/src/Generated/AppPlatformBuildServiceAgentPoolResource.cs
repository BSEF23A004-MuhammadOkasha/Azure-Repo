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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A Class representing an AppPlatformBuildServiceAgentPool along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AppPlatformBuildServiceAgentPoolResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAppPlatformBuildServiceAgentPoolResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppPlatformBuildServiceResource"/> using the GetAppPlatformBuildServiceAgentPool method.
    /// </summary>
    public partial class AppPlatformBuildServiceAgentPoolResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AppPlatformBuildServiceAgentPoolResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="buildServiceName"> The buildServiceName. </param>
        /// <param name="agentPoolName"> The agentPoolName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string agentPoolName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics;
        private readonly BuildServiceAgentPoolRestOperations _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient;
        private readonly AppPlatformBuildServiceAgentPoolData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppPlatform/Spring/buildServices/agentPools";

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildServiceAgentPoolResource"/> class for mocking. </summary>
        protected AppPlatformBuildServiceAgentPoolResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildServiceAgentPoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AppPlatformBuildServiceAgentPoolResource(ArmClient client, AppPlatformBuildServiceAgentPoolData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildServiceAgentPoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppPlatformBuildServiceAgentPoolResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string appPlatformBuildServiceAgentPoolBuildServiceAgentPoolApiVersion);
            _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient = new BuildServiceAgentPoolRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformBuildServiceAgentPoolBuildServiceAgentPoolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppPlatformBuildServiceAgentPoolData Data
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
        /// Get build service agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuildServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppPlatformBuildServiceAgentPoolResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics.CreateScope("AppPlatformBuildServiceAgentPoolResource.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get build service agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuildServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppPlatformBuildServiceAgentPoolResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics.CreateScope("AppPlatformBuildServiceAgentPoolResource.Get");
            scope.Start();
            try
            {
                var response = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update build service agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_UpdatePut</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuildServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformBuildServiceAgentPoolResource>> UpdateAsync(WaitUntil waitUntil, AppPlatformBuildServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics.CreateScope("AppPlatformBuildServiceAgentPoolResource.Update");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.UpdatePutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformBuildServiceAgentPoolResource>(new AppPlatformBuildServiceAgentPoolOperationSource(Client), _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics, Pipeline, _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.CreateUpdatePutRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update build service agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_UpdatePut</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuildServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformBuildServiceAgentPoolResource> Update(WaitUntil waitUntil, AppPlatformBuildServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics.CreateScope("AppPlatformBuildServiceAgentPoolResource.Update");
            scope.Start();
            try
            {
                var response = _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.UpdatePut(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformBuildServiceAgentPoolResource>(new AppPlatformBuildServiceAgentPoolOperationSource(Client), _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolClientDiagnostics, Pipeline, _appPlatformBuildServiceAgentPoolBuildServiceAgentPoolRestClient.CreateUpdatePutRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
