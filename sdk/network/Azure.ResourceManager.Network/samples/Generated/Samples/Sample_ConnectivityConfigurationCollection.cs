// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ConnectivityConfigurationCollection
    {
        // ConnectivityConfigurationsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ConnectivityConfigurationsGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/NetworkManagerConnectivityConfigurationGet.json
            // this example is just showing the usage of "ConnectivityConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this ConnectivityConfigurationResource
            ConnectivityConfigurationCollection collection = networkManager.GetConnectivityConfigurations();

            // invoke the operation
            string configurationName = "myTestConnectivityConfig";
            ConnectivityConfigurationResource result = await collection.GetAsync(configurationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectivityConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConnectivityConfigurationsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ConnectivityConfigurationsGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/NetworkManagerConnectivityConfigurationGet.json
            // this example is just showing the usage of "ConnectivityConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this ConnectivityConfigurationResource
            ConnectivityConfigurationCollection collection = networkManager.GetConnectivityConfigurations();

            // invoke the operation
            string configurationName = "myTestConnectivityConfig";
            bool result = await collection.ExistsAsync(configurationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ConnectivityConfigurationsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ConnectivityConfigurationsGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/NetworkManagerConnectivityConfigurationGet.json
            // this example is just showing the usage of "ConnectivityConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this ConnectivityConfigurationResource
            ConnectivityConfigurationCollection collection = networkManager.GetConnectivityConfigurations();

            // invoke the operation
            string configurationName = "myTestConnectivityConfig";
            NullableResponse<ConnectivityConfigurationResource> response = await collection.GetIfExistsAsync(configurationName);
            ConnectivityConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConnectivityConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ConnectivityConfigurationsPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ConnectivityConfigurationsPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/NetworkManagerConnectivityConfigurationPut.json
            // this example is just showing the usage of "ConnectivityConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this ConnectivityConfigurationResource
            ConnectivityConfigurationCollection collection = networkManager.GetConnectivityConfigurations();

            // invoke the operation
            string configurationName = "myTestConnectivityConfig";
            ConnectivityConfigurationData data = new ConnectivityConfigurationData()
            {
                Description = "Sample Configuration",
                ConnectivityTopology = ConnectivityTopology.HubAndSpoke,
                Hubs =
{
new ConnectivityHub()
{
ResourceId = new ResourceIdentifier("subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.Network/virtualNetworks/myTestConnectivityConfig"),
ResourceType = new ResourceType("Microsoft.Network/virtualNetworks"),
}
},
                IsGlobal = GlobalMeshSupportFlag.True,
                AppliesToGroups =
{
new ConnectivityGroupItem("subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.Network/networkManagers/testNetworkManager/networkGroups/group1",GroupConnectivity.None)
{
UseHubGateway = HubGatewayUsageFlag.True,
IsGlobal = GlobalMeshSupportFlag.False,
}
},
                DeleteExistingPeering = DeleteExistingPeering.True,
            };
            ArmOperation<ConnectivityConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, configurationName, data);
            ConnectivityConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectivityConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConnectivityConfigurationsList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ConnectivityConfigurationsList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/NetworkManagerConnectivityConfigurationList.json
            // this example is just showing the usage of "ConnectivityConfigurations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this ConnectivityConfigurationResource
            ConnectivityConfigurationCollection collection = networkManager.GetConnectivityConfigurations();

            // invoke the operation and iterate over the result
            await foreach (ConnectivityConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConnectivityConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
