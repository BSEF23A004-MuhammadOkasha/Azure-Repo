// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_DiskImageResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdatesTagsOfAnImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/imageExamples/Image_Update.json
            // this example is just showing the usage of "Images_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiskImageResource created on azure
            // for more information of creating DiskImageResource, please refer to the document of DiskImageResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string imageName = "myImage";
            ResourceIdentifier diskImageResourceId = DiskImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, imageName);
            DiskImageResource diskImage = client.GetDiskImageResource(diskImageResourceId);

            // invoke the operation
            DiskImagePatch patch = new DiskImagePatch()
            {
                SourceVirtualMachineId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/virtualMachines/myVM"),
                HyperVGeneration = HyperVGeneration.V1,
                Tags =
{
["department"] = "HR",
},
            };
            ArmOperation<DiskImageResource> lro = await diskImage.UpdateAsync(WaitUntil.Completed, patch);
            DiskImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ImageDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/imageExamples/Images_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "Images_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiskImageResource created on azure
            // for more information of creating DiskImageResource, please refer to the document of DiskImageResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string imageName = "aaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier diskImageResourceId = DiskImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, imageName);
            DiskImageResource diskImage = client.GetDiskImageResource(diskImageResourceId);

            // invoke the operation
            await diskImage.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ImageDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/imageExamples/Images_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "Images_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiskImageResource created on azure
            // for more information of creating DiskImageResource, please refer to the document of DiskImageResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string imageName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier diskImageResourceId = DiskImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, imageName);
            DiskImageResource diskImage = client.GetDiskImageResource(diskImageResourceId);

            // invoke the operation
            await diskImage.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetInformationAboutAVirtualMachineImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/imageExamples/Image_Get.json
            // this example is just showing the usage of "Images_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiskImageResource created on azure
            // for more information of creating DiskImageResource, please refer to the document of DiskImageResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string imageName = "myImage";
            ResourceIdentifier diskImageResourceId = DiskImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, imageName);
            DiskImageResource diskImage = client.GetDiskImageResource(diskImageResourceId);

            // invoke the operation
            DiskImageResource result = await diskImage.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetDiskImages_ListAllVirtualMachineImagesInASubscription()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/imageExamples/Image_ListBySubscription.json
            // this example is just showing the usage of "Images_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DiskImageResource item in subscriptionResource.GetDiskImagesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiskImageData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
