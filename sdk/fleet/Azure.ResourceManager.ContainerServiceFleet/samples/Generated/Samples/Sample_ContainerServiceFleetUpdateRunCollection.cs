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
using Azure.ResourceManager.ContainerServiceFleet;
using Azure.ResourceManager.ContainerServiceFleet.Models;

namespace Azure.ResourceManager.ContainerServiceFleet.Samples
{
    public partial class Sample_ContainerServiceFleetUpdateRunCollection
    {
        // Lists the UpdateRun resources by fleet.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListsTheUpdateRunResourcesByFleet()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2023-08-15-preview/examples/UpdateRuns_ListByFleet.json
            // this example is just showing the usage of "UpdateRuns_ListByFleet" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetUpdateRunResource
            ContainerServiceFleetUpdateRunCollection collection = containerServiceFleet.GetContainerServiceFleetUpdateRuns();

            // invoke the operation and iterate over the result
            await foreach (ContainerServiceFleetUpdateRunResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerServiceFleetUpdateRunData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets an UpdateRun resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsAnUpdateRunResource()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2023-08-15-preview/examples/UpdateRuns_Get.json
            // this example is just showing the usage of "UpdateRuns_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetUpdateRunResource
            ContainerServiceFleetUpdateRunCollection collection = containerServiceFleet.GetContainerServiceFleetUpdateRuns();

            // invoke the operation
            string updateRunName = "run1";
            ContainerServiceFleetUpdateRunResource result = await collection.GetAsync(updateRunName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceFleetUpdateRunData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets an UpdateRun resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsAnUpdateRunResource()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2023-08-15-preview/examples/UpdateRuns_Get.json
            // this example is just showing the usage of "UpdateRuns_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetUpdateRunResource
            ContainerServiceFleetUpdateRunCollection collection = containerServiceFleet.GetContainerServiceFleetUpdateRuns();

            // invoke the operation
            string updateRunName = "run1";
            bool result = await collection.ExistsAsync(updateRunName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Gets an UpdateRun resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetsAnUpdateRunResource()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2023-08-15-preview/examples/UpdateRuns_Get.json
            // this example is just showing the usage of "UpdateRuns_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetUpdateRunResource
            ContainerServiceFleetUpdateRunCollection collection = containerServiceFleet.GetContainerServiceFleetUpdateRuns();

            // invoke the operation
            string updateRunName = "run1";
            NullableResponse<ContainerServiceFleetUpdateRunResource> response = await collection.GetIfExistsAsync(updateRunName);
            ContainerServiceFleetUpdateRunResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerServiceFleetUpdateRunData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create an UpdateRun.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAnUpdateRun()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2023-08-15-preview/examples/UpdateRuns_CreateOrUpdate.json
            // this example is just showing the usage of "UpdateRuns_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetUpdateRunResource
            ContainerServiceFleetUpdateRunCollection collection = containerServiceFleet.GetContainerServiceFleetUpdateRuns();

            // invoke the operation
            string updateRunName = "run1";
            ContainerServiceFleetUpdateRunData data = new ContainerServiceFleetUpdateRunData()
            {
                UpdateStrategyId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.ContainerService/fleets/myFleet/updateStrategies/strategy1"),
                StrategyStages =
{
new ContainerServiceFleetUpdateStage("stage1")
{
Groups =
{
new ContainerServiceFleetUpdateGroup("group-a")
},
AfterStageWaitInSeconds = 3600,
}
},
                ManagedClusterUpdate = new ContainerServiceFleetManagedClusterUpdate(new ContainerServiceFleetManagedClusterUpgradeSpec(ContainerServiceFleetManagedClusterUpgradeType.Full)
                {
                    KubernetesVersion = "1.26.1",
                })
                {
                    SelectionType = NodeImageSelectionType.Latest,
                },
            };
            ArmOperation<ContainerServiceFleetUpdateRunResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, updateRunName, data);
            ContainerServiceFleetUpdateRunResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceFleetUpdateRunData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
