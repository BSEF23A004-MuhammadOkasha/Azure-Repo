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
    public partial class Sample_BackendAddressPoolResource
    {
        // Query inbound NAT rule port mapping
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetInboundNatRulePortMappingsLoadBalancer_QueryInboundNATRulePortMapping()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/QueryInboundNatRulePortMapping.json
            // this example is just showing the usage of "LoadBalancers_ListInboundNatRulePortMappings" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackendAddressPoolResource created on azure
            // for more information of creating BackendAddressPoolResource, please refer to the document of BackendAddressPoolResource
            string subscriptionId = "subid";
            string groupName = "rg1";
            string loadBalancerName = "lb1";
            string backendPoolName = "bp1";
            ResourceIdentifier backendAddressPoolResourceId = BackendAddressPoolResource.CreateResourceIdentifier(subscriptionId, groupName, loadBalancerName, backendPoolName);
            BackendAddressPoolResource backendAddressPool = client.GetBackendAddressPoolResource(backendAddressPoolResourceId);

            // invoke the operation
            QueryInboundNatRulePortMappingContent content = new QueryInboundNatRulePortMappingContent()
            {
                IPAddress = "10.0.0.4",
            };
            ArmOperation<BackendAddressInboundNatRulePortMappings> lro = await backendAddressPool.GetInboundNatRulePortMappingsLoadBalancerAsync(WaitUntil.Completed, content);
            BackendAddressInboundNatRulePortMappings result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // LoadBalancer with BackendAddressPool with BackendAddresses
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_LoadBalancerWithBackendAddressPoolWithBackendAddresses()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/LBBackendAddressPoolWithBackendAddressesGet.json
            // this example is just showing the usage of "LoadBalancerBackendAddressPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackendAddressPoolResource created on azure
            // for more information of creating BackendAddressPoolResource, please refer to the document of BackendAddressPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string loadBalancerName = "lb";
            string backendAddressPoolName = "backend";
            ResourceIdentifier backendAddressPoolResourceId = BackendAddressPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName, backendAddressPoolName);
            BackendAddressPoolResource backendAddressPool = client.GetBackendAddressPoolResource(backendAddressPoolResourceId);

            // invoke the operation
            BackendAddressPoolResource result = await backendAddressPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackendAddressPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LoadBalancerBackendAddressPoolGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_LoadBalancerBackendAddressPoolGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/LoadBalancerBackendAddressPoolGet.json
            // this example is just showing the usage of "LoadBalancerBackendAddressPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackendAddressPoolResource created on azure
            // for more information of creating BackendAddressPoolResource, please refer to the document of BackendAddressPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string loadBalancerName = "lb";
            string backendAddressPoolName = "backend";
            ResourceIdentifier backendAddressPoolResourceId = BackendAddressPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName, backendAddressPoolName);
            BackendAddressPoolResource backendAddressPool = client.GetBackendAddressPoolResource(backendAddressPoolResourceId);

            // invoke the operation
            BackendAddressPoolResource result = await backendAddressPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackendAddressPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update load balancer backend pool with backend addresses containing virtual network and  IP address.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateLoadBalancerBackendPoolWithBackendAddressesContainingVirtualNetworkAndIPAddress()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/LBBackendAddressPoolWithBackendAddressesPut.json
            // this example is just showing the usage of "LoadBalancerBackendAddressPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackendAddressPoolResource created on azure
            // for more information of creating BackendAddressPoolResource, please refer to the document of BackendAddressPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string loadBalancerName = "lb";
            string backendAddressPoolName = "backend";
            ResourceIdentifier backendAddressPoolResourceId = BackendAddressPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName, backendAddressPoolName);
            BackendAddressPoolResource backendAddressPool = client.GetBackendAddressPoolResource(backendAddressPoolResourceId);

            // invoke the operation
            BackendAddressPoolData data = new BackendAddressPoolData()
            {
                LoadBalancerBackendAddresses =
{
new LoadBalancerBackendAddress()
{
Name = "address1",
VirtualNetworkId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/vnetlb"),
IPAddress = "10.0.0.4",
},new LoadBalancerBackendAddress()
{
Name = "address2",
VirtualNetworkId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/vnetlb"),
IPAddress = "10.0.0.5",
}
},
            };
            ArmOperation<BackendAddressPoolResource> lro = await backendAddressPool.UpdateAsync(WaitUntil.Completed, data);
            BackendAddressPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackendAddressPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BackendAddressPoolDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_BackendAddressPoolDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/LoadBalancerBackendAddressPoolDelete.json
            // this example is just showing the usage of "LoadBalancerBackendAddressPools_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackendAddressPoolResource created on azure
            // for more information of creating BackendAddressPoolResource, please refer to the document of BackendAddressPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string loadBalancerName = "lb";
            string backendAddressPoolName = "backend";
            ResourceIdentifier backendAddressPoolResourceId = BackendAddressPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName, backendAddressPoolName);
            BackendAddressPoolResource backendAddressPool = client.GetBackendAddressPoolResource(backendAddressPoolResourceId);

            // invoke the operation
            await backendAddressPool.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
