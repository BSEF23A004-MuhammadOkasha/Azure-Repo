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
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_SiteRecoveryLogicalNetworkCollection
    {
        // Gets the list of logical networks under a fabric.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetsTheListOfLogicalNetworksUnderAFabric()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationLogicalNetworks_ListByReplicationFabrics.json
            // this example is just showing the usage of "ReplicationLogicalNetworks_ListByReplicationFabrics" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryFabricResource created on azure
            // for more information of creating SiteRecoveryFabricResource, please refer to the document of SiteRecoveryFabricResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            ResourceIdentifier siteRecoveryFabricResourceId = SiteRecoveryFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName);
            SiteRecoveryFabricResource siteRecoveryFabric = client.GetSiteRecoveryFabricResource(siteRecoveryFabricResourceId);

            // get the collection of this SiteRecoveryLogicalNetworkResource
            SiteRecoveryLogicalNetworkCollection collection = siteRecoveryFabric.GetSiteRecoveryLogicalNetworks();

            // invoke the operation and iterate over the result
            await foreach (SiteRecoveryLogicalNetworkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SiteRecoveryLogicalNetworkData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets a logical network with specified server id and logical network name.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsALogicalNetworkWithSpecifiedServerIdAndLogicalNetworkName()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationLogicalNetworks_Get.json
            // this example is just showing the usage of "ReplicationLogicalNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryFabricResource created on azure
            // for more information of creating SiteRecoveryFabricResource, please refer to the document of SiteRecoveryFabricResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            ResourceIdentifier siteRecoveryFabricResourceId = SiteRecoveryFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName);
            SiteRecoveryFabricResource siteRecoveryFabric = client.GetSiteRecoveryFabricResource(siteRecoveryFabricResourceId);

            // get the collection of this SiteRecoveryLogicalNetworkResource
            SiteRecoveryLogicalNetworkCollection collection = siteRecoveryFabric.GetSiteRecoveryLogicalNetworks();

            // invoke the operation
            string logicalNetworkName = "87ab394f-165f-4aa9-bd84-b018500b4509";
            SiteRecoveryLogicalNetworkResource result = await collection.GetAsync(logicalNetworkName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryLogicalNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets a logical network with specified server id and logical network name.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsALogicalNetworkWithSpecifiedServerIdAndLogicalNetworkName()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationLogicalNetworks_Get.json
            // this example is just showing the usage of "ReplicationLogicalNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryFabricResource created on azure
            // for more information of creating SiteRecoveryFabricResource, please refer to the document of SiteRecoveryFabricResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            ResourceIdentifier siteRecoveryFabricResourceId = SiteRecoveryFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName);
            SiteRecoveryFabricResource siteRecoveryFabric = client.GetSiteRecoveryFabricResource(siteRecoveryFabricResourceId);

            // get the collection of this SiteRecoveryLogicalNetworkResource
            SiteRecoveryLogicalNetworkCollection collection = siteRecoveryFabric.GetSiteRecoveryLogicalNetworks();

            // invoke the operation
            string logicalNetworkName = "87ab394f-165f-4aa9-bd84-b018500b4509";
            bool result = await collection.ExistsAsync(logicalNetworkName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Gets a logical network with specified server id and logical network name.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetsALogicalNetworkWithSpecifiedServerIdAndLogicalNetworkName()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationLogicalNetworks_Get.json
            // this example is just showing the usage of "ReplicationLogicalNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryFabricResource created on azure
            // for more information of creating SiteRecoveryFabricResource, please refer to the document of SiteRecoveryFabricResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            ResourceIdentifier siteRecoveryFabricResourceId = SiteRecoveryFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName);
            SiteRecoveryFabricResource siteRecoveryFabric = client.GetSiteRecoveryFabricResource(siteRecoveryFabricResourceId);

            // get the collection of this SiteRecoveryLogicalNetworkResource
            SiteRecoveryLogicalNetworkCollection collection = siteRecoveryFabric.GetSiteRecoveryLogicalNetworks();

            // invoke the operation
            string logicalNetworkName = "87ab394f-165f-4aa9-bd84-b018500b4509";
            NullableResponse<SiteRecoveryLogicalNetworkResource> response = await collection.GetIfExistsAsync(logicalNetworkName);
            SiteRecoveryLogicalNetworkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SiteRecoveryLogicalNetworkData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
