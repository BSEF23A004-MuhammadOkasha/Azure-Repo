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
    public partial class Sample_VpnServerConfigurationPolicyGroupCollection
    {
        // ConfigurationPolicyGroupPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ConfigurationPolicyGroupPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/ConfigurationPolicyGroupPut.json
            // this example is just showing the usage of "ConfigurationPolicyGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnServerConfigurationResource created on azure
            // for more information of creating VpnServerConfigurationResource, please refer to the document of VpnServerConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnServerConfigurationName = "vpnServerConfiguration1";
            ResourceIdentifier vpnServerConfigurationResourceId = VpnServerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnServerConfigurationName);
            VpnServerConfigurationResource vpnServerConfiguration = client.GetVpnServerConfigurationResource(vpnServerConfigurationResourceId);

            // get the collection of this VpnServerConfigurationPolicyGroupResource
            VpnServerConfigurationPolicyGroupCollection collection = vpnServerConfiguration.GetVpnServerConfigurationPolicyGroups();

            // invoke the operation
            string configurationPolicyGroupName = "policyGroup1";
            VpnServerConfigurationPolicyGroupData data = new VpnServerConfigurationPolicyGroupData()
            {
                IsDefault = true,
                Priority = 0,
                PolicyMembers =
{
new VpnServerConfigurationPolicyGroupMember()
{
Name = "policy1",
AttributeType = VpnPolicyMemberAttributeType.RadiusAzureGroupId,
AttributeValue = "6ad1bd08",
},new VpnServerConfigurationPolicyGroupMember()
{
Name = "policy2",
AttributeType = VpnPolicyMemberAttributeType.CertificateGroupId,
AttributeValue = "red.com",
}
},
            };
            ArmOperation<VpnServerConfigurationPolicyGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, configurationPolicyGroupName, data);
            VpnServerConfigurationPolicyGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnServerConfigurationPolicyGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConfigurationPolicyGroupGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ConfigurationPolicyGroupGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/ConfigurationPolicyGroupGet.json
            // this example is just showing the usage of "ConfigurationPolicyGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnServerConfigurationResource created on azure
            // for more information of creating VpnServerConfigurationResource, please refer to the document of VpnServerConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnServerConfigurationName = "vpnServerConfiguration1";
            ResourceIdentifier vpnServerConfigurationResourceId = VpnServerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnServerConfigurationName);
            VpnServerConfigurationResource vpnServerConfiguration = client.GetVpnServerConfigurationResource(vpnServerConfigurationResourceId);

            // get the collection of this VpnServerConfigurationPolicyGroupResource
            VpnServerConfigurationPolicyGroupCollection collection = vpnServerConfiguration.GetVpnServerConfigurationPolicyGroups();

            // invoke the operation
            string configurationPolicyGroupName = "policyGroup1";
            VpnServerConfigurationPolicyGroupResource result = await collection.GetAsync(configurationPolicyGroupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnServerConfigurationPolicyGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConfigurationPolicyGroupGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ConfigurationPolicyGroupGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/ConfigurationPolicyGroupGet.json
            // this example is just showing the usage of "ConfigurationPolicyGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnServerConfigurationResource created on azure
            // for more information of creating VpnServerConfigurationResource, please refer to the document of VpnServerConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnServerConfigurationName = "vpnServerConfiguration1";
            ResourceIdentifier vpnServerConfigurationResourceId = VpnServerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnServerConfigurationName);
            VpnServerConfigurationResource vpnServerConfiguration = client.GetVpnServerConfigurationResource(vpnServerConfigurationResourceId);

            // get the collection of this VpnServerConfigurationPolicyGroupResource
            VpnServerConfigurationPolicyGroupCollection collection = vpnServerConfiguration.GetVpnServerConfigurationPolicyGroups();

            // invoke the operation
            string configurationPolicyGroupName = "policyGroup1";
            bool result = await collection.ExistsAsync(configurationPolicyGroupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ConfigurationPolicyGroupGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ConfigurationPolicyGroupGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/ConfigurationPolicyGroupGet.json
            // this example is just showing the usage of "ConfigurationPolicyGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnServerConfigurationResource created on azure
            // for more information of creating VpnServerConfigurationResource, please refer to the document of VpnServerConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnServerConfigurationName = "vpnServerConfiguration1";
            ResourceIdentifier vpnServerConfigurationResourceId = VpnServerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnServerConfigurationName);
            VpnServerConfigurationResource vpnServerConfiguration = client.GetVpnServerConfigurationResource(vpnServerConfigurationResourceId);

            // get the collection of this VpnServerConfigurationPolicyGroupResource
            VpnServerConfigurationPolicyGroupCollection collection = vpnServerConfiguration.GetVpnServerConfigurationPolicyGroups();

            // invoke the operation
            string configurationPolicyGroupName = "policyGroup1";
            NullableResponse<VpnServerConfigurationPolicyGroupResource> response = await collection.GetIfExistsAsync(configurationPolicyGroupName);
            VpnServerConfigurationPolicyGroupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VpnServerConfigurationPolicyGroupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ConfigurationPolicyGroupListByVpnServerConfiguration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ConfigurationPolicyGroupListByVpnServerConfiguration()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/ConfigurationPolicyGroupListByVpnServerConfiguration.json
            // this example is just showing the usage of "configurationPolicyGroups_ListByVpnServerConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnServerConfigurationResource created on azure
            // for more information of creating VpnServerConfigurationResource, please refer to the document of VpnServerConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnServerConfigurationName = "vpnServerConfiguration1";
            ResourceIdentifier vpnServerConfigurationResourceId = VpnServerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnServerConfigurationName);
            VpnServerConfigurationResource vpnServerConfiguration = client.GetVpnServerConfigurationResource(vpnServerConfigurationResourceId);

            // get the collection of this VpnServerConfigurationPolicyGroupResource
            VpnServerConfigurationPolicyGroupCollection collection = vpnServerConfiguration.GetVpnServerConfigurationPolicyGroups();

            // invoke the operation and iterate over the result
            await foreach (VpnServerConfigurationPolicyGroupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VpnServerConfigurationPolicyGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
