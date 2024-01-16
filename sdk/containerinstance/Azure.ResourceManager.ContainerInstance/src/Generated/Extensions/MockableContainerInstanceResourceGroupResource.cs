// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ContainerInstance;

namespace Azure.ResourceManager.ContainerInstance.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableContainerInstanceResourceGroupResource : ArmResource
    {
        private ClientDiagnostics _subnetServiceAssociationLinkClientDiagnostics;
        private SubnetServiceAssociationLinkRestOperations _subnetServiceAssociationLinkRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableContainerInstanceResourceGroupResource"/> class for mocking. </summary>
        protected MockableContainerInstanceResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableContainerInstanceResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableContainerInstanceResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SubnetServiceAssociationLinkClientDiagnostics => _subnetServiceAssociationLinkClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ContainerInstance", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SubnetServiceAssociationLinkRestOperations SubnetServiceAssociationLinkRestClient => _subnetServiceAssociationLinkRestClient ??= new SubnetServiceAssociationLinkRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ContainerGroupResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ContainerGroupResources and their operations over a ContainerGroupResource. </returns>
        public virtual ContainerGroupCollection GetContainerGroups()
        {
            return GetCachedClient(client => new ContainerGroupCollection(client, Id));
        }

        /// <summary>
        /// Gets the properties of the specified container group in the specified subscription and resource group. The operation returns the properties of each container group including containers, image registry credentials, restart policy, IP address type, OS type, state, and volumes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ContainerGroupResource>> GetContainerGroupAsync(string containerGroupName, CancellationToken cancellationToken = default)
        {
            return await GetContainerGroups().GetAsync(containerGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the specified container group in the specified subscription and resource group. The operation returns the properties of each container group including containers, image registry credentials, restart policy, IP address type, OS type, state, and volumes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ContainerGroupResource> GetContainerGroup(string containerGroupName, CancellationToken cancellationToken = default)
        {
            return GetContainerGroups().Get(containerGroupName, cancellationToken);
        }

        /// <summary>
        /// Delete container group virtual network association links. The operation does not delete other resources provided by the user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}/providers/Microsoft.ContainerInstance/serviceAssociationLinks/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubnetServiceAssociationLink_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> or <paramref name="subnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> or <paramref name="subnetName"/> is null. </exception>
        public virtual async Task<ArmOperation> DeleteSubnetServiceAssociationLinkAsync(WaitUntil waitUntil, string virtualNetworkName, string subnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = SubnetServiceAssociationLinkClientDiagnostics.CreateScope("MockableContainerInstanceResourceGroupResource.DeleteSubnetServiceAssociationLink");
            scope.Start();
            try
            {
                var response = await SubnetServiceAssociationLinkRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, subnetName, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerInstanceArmOperation(SubnetServiceAssociationLinkClientDiagnostics, Pipeline, SubnetServiceAssociationLinkRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, subnetName).Request, response, OperationFinalStateVia.Location);
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
        /// Delete container group virtual network association links. The operation does not delete other resources provided by the user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}/providers/Microsoft.ContainerInstance/serviceAssociationLinks/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubnetServiceAssociationLink_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> or <paramref name="subnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> or <paramref name="subnetName"/> is null. </exception>
        public virtual ArmOperation DeleteSubnetServiceAssociationLink(WaitUntil waitUntil, string virtualNetworkName, string subnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));
            Argument.AssertNotNullOrEmpty(subnetName, nameof(subnetName));

            using var scope = SubnetServiceAssociationLinkClientDiagnostics.CreateScope("MockableContainerInstanceResourceGroupResource.DeleteSubnetServiceAssociationLink");
            scope.Start();
            try
            {
                var response = SubnetServiceAssociationLinkRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, subnetName, cancellationToken);
                var operation = new ContainerInstanceArmOperation(SubnetServiceAssociationLinkClientDiagnostics, Pipeline, SubnetServiceAssociationLinkRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, subnetName).Request, response, OperationFinalStateVia.Location);
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
    }
}
