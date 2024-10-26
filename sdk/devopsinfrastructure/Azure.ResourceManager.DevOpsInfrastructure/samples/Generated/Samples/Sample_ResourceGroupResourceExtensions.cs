// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DevOpsInfrastructure.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DevOpsInfrastructure.Samples
{
    public partial class Sample_ResourceGroupResourceExtensions
    {
        // ImageVersions_ListByImage
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetImageVersionsByImage_ImageVersionsListByImage()
        {
            // Generated from example definition: 2024-10-19/ImageVersions_ListByImage.json
            // this example is just showing the usage of "ImageVersion_ListByImage" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a2e95d27-c161-4b61-bda4-11512c14c2c2";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            string imageName = "windows-2022";
            await foreach (DevOpsImageVersion item in resourceGroupResource.GetImageVersionsByImageAsync(imageName))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
