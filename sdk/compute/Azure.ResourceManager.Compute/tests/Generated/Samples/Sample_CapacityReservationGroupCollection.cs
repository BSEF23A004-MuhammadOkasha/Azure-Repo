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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_CapacityReservationGroupCollection
    {
        // Create or update a capacity reservation group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateACapacityReservationGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/examples/capacityReservationExamples/CapacityReservationGroup_CreateOrUpdate.json
            // this example is just showing the usage of "CapacityReservationGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CapacityReservationGroupResource
            CapacityReservationGroupCollection collection = resourceGroupResource.GetCapacityReservationGroups();

            // invoke the operation
            string capacityReservationGroupName = "myCapacityReservationGroup";
            CapacityReservationGroupData data = new CapacityReservationGroupData(new AzureLocation("westus"))
            {
                Zones =
{
"1","2"
},
                Tags =
{
["department"] = "finance",
},
            };
            ArmOperation<CapacityReservationGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, capacityReservationGroupName, data);
            CapacityReservationGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CapacityReservationGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a capacity reservation Group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetACapacityReservationGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/examples/capacityReservationExamples/CapacityReservationGroup_Get.json
            // this example is just showing the usage of "CapacityReservationGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CapacityReservationGroupResource
            CapacityReservationGroupCollection collection = resourceGroupResource.GetCapacityReservationGroups();

            // invoke the operation
            string capacityReservationGroupName = "myCapacityReservationGroup";
            CapacityReservationGroupResource result = await collection.GetAsync(capacityReservationGroupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CapacityReservationGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a capacity reservation Group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetACapacityReservationGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/examples/capacityReservationExamples/CapacityReservationGroup_Get.json
            // this example is just showing the usage of "CapacityReservationGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CapacityReservationGroupResource
            CapacityReservationGroupCollection collection = resourceGroupResource.GetCapacityReservationGroups();

            // invoke the operation
            string capacityReservationGroupName = "myCapacityReservationGroup";
            bool result = await collection.ExistsAsync(capacityReservationGroupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // List capacity reservation groups in resource group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListCapacityReservationGroupsInResourceGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/examples/capacityReservationExamples/CapacityReservationGroup_ListByResourceGroup.json
            // this example is just showing the usage of "CapacityReservationGroups_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CapacityReservationGroupResource
            CapacityReservationGroupCollection collection = resourceGroupResource.GetCapacityReservationGroups();

            // invoke the operation and iterate over the result
            CapacityReservationGroupGetExpand? expand = CapacityReservationGroupGetExpand.VirtualMachinesRef;
            await foreach (CapacityReservationGroupResource item in collection.GetAllAsync(expand: expand))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CapacityReservationGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
