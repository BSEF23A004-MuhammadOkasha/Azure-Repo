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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A Class representing a MachineLearningRegistryDataContainer along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MachineLearningRegistryDataContainerResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMachineLearningRegistryDataContainerResource method.
    /// Otherwise you can get one from its parent resource <see cref="MachineLearningRegistryResource" /> using the GetMachineLearningRegistryDataContainer method.
    /// </summary>
    public partial class MachineLearningRegistryDataContainerResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MachineLearningRegistryDataContainerResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string registryName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics;
        private readonly RegistryDataContainersRestOperations _machineLearningRegistryDataContainerRegistryDataContainersRestClient;
        private readonly MachineLearningDataContainerData _data;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryDataContainerResource"/> class for mocking. </summary>
        protected MachineLearningRegistryDataContainerResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MachineLearningRegistryDataContainerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MachineLearningRegistryDataContainerResource(ArmClient client, MachineLearningDataContainerData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryDataContainerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MachineLearningRegistryDataContainerResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string machineLearningRegistryDataContainerRegistryDataContainersApiVersion);
            _machineLearningRegistryDataContainerRegistryDataContainersRestClient = new RegistryDataContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningRegistryDataContainerRegistryDataContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/registries/data";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MachineLearningDataContainerData Data
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

        /// <summary> Gets a collection of MachineLearningRegistryDataVersionResources in the MachineLearningRegistryDataContainer. </summary>
        /// <returns> An object representing collection of MachineLearningRegistryDataVersionResources and their operations over a MachineLearningRegistryDataVersionResource. </returns>
        public virtual MachineLearningRegistryDataVersionCollection GetMachineLearningRegistryDataVersions()
        {
            return GetCachedClient(client => new MachineLearningRegistryDataVersionCollection(client, Id));
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MachineLearningRegistryDataVersionResource>> GetMachineLearningRegistryDataVersionAsync(string version, CancellationToken cancellationToken = default)
        {
            return await GetMachineLearningRegistryDataVersions().GetAsync(version, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MachineLearningRegistryDataVersionResource> GetMachineLearningRegistryDataVersion(string version, CancellationToken cancellationToken = default)
        {
            return GetMachineLearningRegistryDataVersions().Get(version, cancellationToken);
        }

        /// <summary>
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MachineLearningRegistryDataContainerResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerResource.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryDataContainerRegistryDataContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryDataContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MachineLearningRegistryDataContainerResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerResource.Get");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryDataContainerRegistryDataContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryDataContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerResource.Delete");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryDataContainerRegistryDataContainersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation(_machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics, Pipeline, _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerResource.Delete");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryDataContainerRegistryDataContainersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MachineLearningArmOperation(_machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics, Pipeline, _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningRegistryDataContainerResource>> UpdateAsync(WaitUntil waitUntil, MachineLearningDataContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerResource.Update");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryDataContainerResource>(new MachineLearningRegistryDataContainerOperationSource(Client), _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics, Pipeline, _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningRegistryDataContainerResource> Update(WaitUntil waitUntil, MachineLearningDataContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerResource.Update");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryDataContainerResource>(new MachineLearningRegistryDataContainerOperationSource(Client), _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics, Pipeline, _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
