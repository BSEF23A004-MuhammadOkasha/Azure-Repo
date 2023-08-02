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

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkGroupStaticMemberCollection
    {
        // StaticMembersGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StaticMembersGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkManagerStaticMemberGet.json
            // this example is just showing the usage of "StaticMembers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkGroupResource created on azure
            // for more information of creating NetworkGroupResource, please refer to the document of NetworkGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string networkGroupName = "testNetworkGroup";
            ResourceIdentifier networkGroupResourceId = NetworkGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, networkGroupName);
            NetworkGroupResource networkGroup = client.GetNetworkGroupResource(networkGroupResourceId);

            // get the collection of this NetworkGroupStaticMemberResource
            NetworkGroupStaticMemberCollection collection = networkGroup.GetNetworkGroupStaticMembers();

            // invoke the operation
            string staticMemberName = "testStaticMember";
            NetworkGroupStaticMemberResource result = await collection.GetAsync(staticMemberName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkGroupStaticMemberData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StaticMembersGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_StaticMembersGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkManagerStaticMemberGet.json
            // this example is just showing the usage of "StaticMembers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkGroupResource created on azure
            // for more information of creating NetworkGroupResource, please refer to the document of NetworkGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string networkGroupName = "testNetworkGroup";
            ResourceIdentifier networkGroupResourceId = NetworkGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, networkGroupName);
            NetworkGroupResource networkGroup = client.GetNetworkGroupResource(networkGroupResourceId);

            // get the collection of this NetworkGroupStaticMemberResource
            NetworkGroupStaticMemberCollection collection = networkGroup.GetNetworkGroupStaticMembers();

            // invoke the operation
            string staticMemberName = "testStaticMember";
            bool result = await collection.ExistsAsync(staticMemberName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // StaticMemberPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StaticMemberPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkManagerStaticMemberPut.json
            // this example is just showing the usage of "StaticMembers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkGroupResource created on azure
            // for more information of creating NetworkGroupResource, please refer to the document of NetworkGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string networkGroupName = "testNetworkGroup";
            ResourceIdentifier networkGroupResourceId = NetworkGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, networkGroupName);
            NetworkGroupResource networkGroup = client.GetNetworkGroupResource(networkGroupResourceId);

            // get the collection of this NetworkGroupStaticMemberResource
            NetworkGroupStaticMemberCollection collection = networkGroup.GetNetworkGroupStaticMembers();

            // invoke the operation
            string staticMemberName = "testStaticMember";
            NetworkGroupStaticMemberData data = new NetworkGroupStaticMemberData()
            {
                ResourceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroup/rg1/providers/Microsoft.Network/virtualnetworks/vnet1"),
            };
            ArmOperation<NetworkGroupStaticMemberResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, staticMemberName, data);
            NetworkGroupStaticMemberResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkGroupStaticMemberData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StaticMembersList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_StaticMembersList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkManagerStaticMemberList.json
            // this example is just showing the usage of "StaticMembers_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkGroupResource created on azure
            // for more information of creating NetworkGroupResource, please refer to the document of NetworkGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string networkGroupName = "testNetworkGroup";
            ResourceIdentifier networkGroupResourceId = NetworkGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, networkGroupName);
            NetworkGroupResource networkGroup = client.GetNetworkGroupResource(networkGroupResourceId);

            // get the collection of this NetworkGroupStaticMemberResource
            NetworkGroupStaticMemberCollection collection = networkGroup.GetNetworkGroupStaticMembers();

            // invoke the operation and iterate over the result
            await foreach (NetworkGroupStaticMemberResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkGroupStaticMemberData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
