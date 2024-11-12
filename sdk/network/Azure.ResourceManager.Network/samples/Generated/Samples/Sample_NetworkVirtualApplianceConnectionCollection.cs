// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkVirtualApplianceConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_NetworkVirtualApplianceConnectionPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkVirtualApplianceConnectionPut.json
            // this example is just showing the usage of "NetworkVirtualApplianceConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva1";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this NetworkVirtualApplianceConnectionResource
            NetworkVirtualApplianceConnectionCollection collection = networkVirtualAppliance.GetNetworkVirtualApplianceConnections();

            // invoke the operation
            string connectionName = "connection1";
            NetworkVirtualApplianceConnectionData data = new NetworkVirtualApplianceConnectionData()
            {
                NamePropertiesName = "connection1",
                Asn = 64512L,
                TunnelIdentifier = 0L,
                BgpPeerAddress =
{
"169.254.16.13","169.254.16.14"
},
                EnableInternetSecurity = false,
                ConnectionRoutingConfiguration = new RoutingConfiguration()
                {
                    AssociatedRouteTableId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/hubRouteTables/hubRouteTable1"),
                    PropagatedRouteTables = new PropagatedRouteTable()
                    {
                        Labels =
{
"label1"
},
                        Ids =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/hubRouteTables/hubRouteTable1"),
}
},
                    },
                    InboundRouteMapId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/routeMaps/routeMap1"),
                    OutboundRouteMapId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/routeMaps/routeMap2"),
                },
                Name = "connection1",
            };
            ArmOperation<NetworkVirtualApplianceConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, connectionName, data);
            NetworkVirtualApplianceConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkVirtualApplianceConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NetworkVirtualApplianceConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkVirtualApplianceConnectionGet.json
            // this example is just showing the usage of "NetworkVirtualApplianceConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva1";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this NetworkVirtualApplianceConnectionResource
            NetworkVirtualApplianceConnectionCollection collection = networkVirtualAppliance.GetNetworkVirtualApplianceConnections();

            // invoke the operation
            string connectionName = "connection1";
            NetworkVirtualApplianceConnectionResource result = await collection.GetAsync(connectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkVirtualApplianceConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_NetworkVirtualApplianceConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkVirtualApplianceConnectionGet.json
            // this example is just showing the usage of "NetworkVirtualApplianceConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva1";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this NetworkVirtualApplianceConnectionResource
            NetworkVirtualApplianceConnectionCollection collection = networkVirtualAppliance.GetNetworkVirtualApplianceConnections();

            // invoke the operation
            string connectionName = "connection1";
            bool result = await collection.ExistsAsync(connectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_NetworkVirtualApplianceConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkVirtualApplianceConnectionGet.json
            // this example is just showing the usage of "NetworkVirtualApplianceConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva1";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this NetworkVirtualApplianceConnectionResource
            NetworkVirtualApplianceConnectionCollection collection = networkVirtualAppliance.GetNetworkVirtualApplianceConnections();

            // invoke the operation
            string connectionName = "connection1";
            NullableResponse<NetworkVirtualApplianceConnectionResource> response = await collection.GetIfExistsAsync(connectionName);
            NetworkVirtualApplianceConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkVirtualApplianceConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_NetworkVirtualApplianceConnectionList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkVirtualApplianceConnectionList.json
            // this example is just showing the usage of "NetworkVirtualApplianceConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva1";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this NetworkVirtualApplianceConnectionResource
            NetworkVirtualApplianceConnectionCollection collection = networkVirtualAppliance.GetNetworkVirtualApplianceConnections();

            // invoke the operation and iterate over the result
            await foreach (NetworkVirtualApplianceConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkVirtualApplianceConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
