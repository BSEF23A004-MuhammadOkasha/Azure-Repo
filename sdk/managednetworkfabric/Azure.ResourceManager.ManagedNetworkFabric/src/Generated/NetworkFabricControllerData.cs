// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabricController data model.
    /// The Network Fabric Controller resource definition.
    /// </summary>
    public partial class NetworkFabricControllerData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkFabricControllerData. </summary>
        /// <param name="location"> The location. </param>
        public NetworkFabricControllerData(AzureLocation location) : base(location)
        {
            InfrastructureExpressRouteConnections = new ChangeTrackingList<ExpressRouteConnectionInformation>();
            WorkloadExpressRouteConnections = new ChangeTrackingList<ExpressRouteConnectionInformation>();
            NetworkFabricIds = new ChangeTrackingList<ResourceIdentifier>();
            TenantInternetGatewayIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of NetworkFabricControllerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="infrastructureExpressRouteConnections"> As part of an update, the Infrastructure ExpressRoute CircuitID should be provided to create and Provision a NFC. This Express route is dedicated for Infrastructure services. (This is a Mandatory attribute). </param>
        /// <param name="workloadExpressRouteConnections"> As part of an update, the workload ExpressRoute CircuitID should be provided to create and Provision a NFC. This Express route is dedicated for Workload services. (This is a Mandatory attribute). </param>
        /// <param name="infrastructureServices"> InfrastructureServices IP ranges. </param>
        /// <param name="workloadServices"> WorkloadServices IP ranges. </param>
        /// <param name="managedResourceGroupConfiguration"> Managed Resource Group configuration properties. </param>
        /// <param name="networkFabricIds"> The NF-ID will be an input parameter used by the NF to link and get associated with the parent NFC Service. </param>
        /// <param name="isWorkloadManagementNetwork"> A workload management network is required for all the tenant (workload) traffic. This traffic is only dedicated for Tenant workloads which are required to access internet or any other MSFT/Public endpoints. This is used for the backward compatibility. </param>
        /// <param name="isWorkloadManagementNetworkEnabled"> A workload management network is required for all the tenant (workload) traffic. This traffic is only dedicated for Tenant workloads which are required to access internet or any other MSFT/Public endpoints. </param>
        /// <param name="tenantInternetGatewayIds"> List of tenant InternetGateway resource IDs. </param>
        /// <param name="ipv4AddressSpace"> IPv4 Network Fabric Controller Address Space. </param>
        /// <param name="ipv6AddressSpace"> IPv6 Network Fabric Controller Address Space. </param>
        /// <param name="nfcSku"> Network Fabric Controller SKU. </param>
        /// <param name="provisioningState"> Provides you the latest status of the NFC service, whether it is Accepted, updating, Succeeded or Failed. During this process, the states keep changing based on the status of NFC provisioning. </param>
        internal NetworkFabricControllerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, IList<ExpressRouteConnectionInformation> infrastructureExpressRouteConnections, IList<ExpressRouteConnectionInformation> workloadExpressRouteConnections, NetworkFabricControllerServices infrastructureServices, NetworkFabricControllerServices workloadServices, ManagedResourceGroupConfiguration managedResourceGroupConfiguration, IReadOnlyList<ResourceIdentifier> networkFabricIds, bool? isWorkloadManagementNetwork, IsWorkloadManagementNetworkEnabled? isWorkloadManagementNetworkEnabled, IReadOnlyList<ResourceIdentifier> tenantInternetGatewayIds, string ipv4AddressSpace, string ipv6AddressSpace, NetworkFabricControllerSKU? nfcSku, NetworkFabricProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            InfrastructureExpressRouteConnections = infrastructureExpressRouteConnections;
            WorkloadExpressRouteConnections = workloadExpressRouteConnections;
            InfrastructureServices = infrastructureServices;
            WorkloadServices = workloadServices;
            ManagedResourceGroupConfiguration = managedResourceGroupConfiguration;
            NetworkFabricIds = networkFabricIds;
            IsWorkloadManagementNetwork = isWorkloadManagementNetwork;
            IsWorkloadManagementNetworkEnabled = isWorkloadManagementNetworkEnabled;
            TenantInternetGatewayIds = tenantInternetGatewayIds;
            IPv4AddressSpace = ipv4AddressSpace;
            IPv6AddressSpace = ipv6AddressSpace;
            NfcSku = nfcSku;
            ProvisioningState = provisioningState;
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> As part of an update, the Infrastructure ExpressRoute CircuitID should be provided to create and Provision a NFC. This Express route is dedicated for Infrastructure services. (This is a Mandatory attribute). </summary>
        public IList<ExpressRouteConnectionInformation> InfrastructureExpressRouteConnections { get; }
        /// <summary> As part of an update, the workload ExpressRoute CircuitID should be provided to create and Provision a NFC. This Express route is dedicated for Workload services. (This is a Mandatory attribute). </summary>
        public IList<ExpressRouteConnectionInformation> WorkloadExpressRouteConnections { get; }
        /// <summary> InfrastructureServices IP ranges. </summary>
        public NetworkFabricControllerServices InfrastructureServices { get; }
        /// <summary> WorkloadServices IP ranges. </summary>
        public NetworkFabricControllerServices WorkloadServices { get; }
        /// <summary> Managed Resource Group configuration properties. </summary>
        public ManagedResourceGroupConfiguration ManagedResourceGroupConfiguration { get; set; }
        /// <summary> The NF-ID will be an input parameter used by the NF to link and get associated with the parent NFC Service. </summary>
        public IReadOnlyList<ResourceIdentifier> NetworkFabricIds { get; }
        /// <summary> A workload management network is required for all the tenant (workload) traffic. This traffic is only dedicated for Tenant workloads which are required to access internet or any other MSFT/Public endpoints. This is used for the backward compatibility. </summary>
        public bool? IsWorkloadManagementNetwork { get; }
        /// <summary> A workload management network is required for all the tenant (workload) traffic. This traffic is only dedicated for Tenant workloads which are required to access internet or any other MSFT/Public endpoints. </summary>
        public IsWorkloadManagementNetworkEnabled? IsWorkloadManagementNetworkEnabled { get; set; }
        /// <summary> List of tenant InternetGateway resource IDs. </summary>
        public IReadOnlyList<ResourceIdentifier> TenantInternetGatewayIds { get; }
        /// <summary> IPv4 Network Fabric Controller Address Space. </summary>
        public string IPv4AddressSpace { get; set; }
        /// <summary> IPv6 Network Fabric Controller Address Space. </summary>
        public string IPv6AddressSpace { get; set; }
        /// <summary> Network Fabric Controller SKU. </summary>
        public NetworkFabricControllerSKU? NfcSku { get; set; }
        /// <summary> Provides you the latest status of the NFC service, whether it is Accepted, updating, Succeeded or Failed. During this process, the states keep changing based on the status of NFC provisioning. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
    }
}
