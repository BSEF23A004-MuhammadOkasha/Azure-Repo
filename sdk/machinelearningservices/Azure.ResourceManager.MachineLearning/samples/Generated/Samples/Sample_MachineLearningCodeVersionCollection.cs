// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningCodeVersionCollection
    {
        // List Workspace Code Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListWorkspaceCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/CodeVersion/list.json
            // this example is just showing the usage of "CodeVersions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningCodeContainerResource created on azure
            // for more information of creating MachineLearningCodeContainerResource, please refer to the document of MachineLearningCodeContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningCodeContainerResourceId = MachineLearningCodeContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningCodeContainerResource machineLearningCodeContainer = client.GetMachineLearningCodeContainerResource(machineLearningCodeContainerResourceId);

            // get the collection of this MachineLearningCodeVersionResource
            MachineLearningCodeVersionCollection collection = machineLearningCodeContainer.GetMachineLearningCodeVersions();

            // invoke the operation and iterate over the result
            string orderBy = "string";
            int? top = 1;
            await foreach (MachineLearningCodeVersionResource item in collection.GetAllAsync(orderBy: orderBy, top: top))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningCodeVersionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Workspace Code Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspaceCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/CodeVersion/get.json
            // this example is just showing the usage of "CodeVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningCodeContainerResource created on azure
            // for more information of creating MachineLearningCodeContainerResource, please refer to the document of MachineLearningCodeContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningCodeContainerResourceId = MachineLearningCodeContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningCodeContainerResource machineLearningCodeContainer = client.GetMachineLearningCodeContainerResource(machineLearningCodeContainerResourceId);

            // get the collection of this MachineLearningCodeVersionResource
            MachineLearningCodeVersionCollection collection = machineLearningCodeContainer.GetMachineLearningCodeVersions();

            // invoke the operation
            string version = "string";
            MachineLearningCodeVersionResource result = await collection.GetAsync(version);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningCodeVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Workspace Code Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetWorkspaceCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/CodeVersion/get.json
            // this example is just showing the usage of "CodeVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningCodeContainerResource created on azure
            // for more information of creating MachineLearningCodeContainerResource, please refer to the document of MachineLearningCodeContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningCodeContainerResourceId = MachineLearningCodeContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningCodeContainerResource machineLearningCodeContainer = client.GetMachineLearningCodeContainerResource(machineLearningCodeContainerResourceId);

            // get the collection of this MachineLearningCodeVersionResource
            MachineLearningCodeVersionCollection collection = machineLearningCodeContainer.GetMachineLearningCodeVersions();

            // invoke the operation
            string version = "string";
            bool result = await collection.ExistsAsync(version);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Workspace Code Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetWorkspaceCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/CodeVersion/get.json
            // this example is just showing the usage of "CodeVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningCodeContainerResource created on azure
            // for more information of creating MachineLearningCodeContainerResource, please refer to the document of MachineLearningCodeContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningCodeContainerResourceId = MachineLearningCodeContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningCodeContainerResource machineLearningCodeContainer = client.GetMachineLearningCodeContainerResource(machineLearningCodeContainerResourceId);

            // get the collection of this MachineLearningCodeVersionResource
            MachineLearningCodeVersionCollection collection = machineLearningCodeContainer.GetMachineLearningCodeVersions();

            // invoke the operation
            string version = "string";
            NullableResponse<MachineLearningCodeVersionResource> response = await collection.GetIfExistsAsync(version);
            MachineLearningCodeVersionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningCodeVersionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // CreateOrUpdate Workspace Code Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateWorkspaceCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/CodeVersion/createOrUpdate.json
            // this example is just showing the usage of "CodeVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningCodeContainerResource created on azure
            // for more information of creating MachineLearningCodeContainerResource, please refer to the document of MachineLearningCodeContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningCodeContainerResourceId = MachineLearningCodeContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningCodeContainerResource machineLearningCodeContainer = client.GetMachineLearningCodeContainerResource(machineLearningCodeContainerResourceId);

            // get the collection of this MachineLearningCodeVersionResource
            MachineLearningCodeVersionCollection collection = machineLearningCodeContainer.GetMachineLearningCodeVersions();

            // invoke the operation
            string version = "string";
            MachineLearningCodeVersionData data = new MachineLearningCodeVersionData(new MachineLearningCodeVersionProperties()
            {
                CodeUri = new Uri("https://blobStorage/folderName"),
                IsAnonymous = false,
                Description = "string",
                Properties =
{
["string"] = "string",
},
                Tags =
{
["string"] = "string",
},
            });
            ArmOperation<MachineLearningCodeVersionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, version, data);
            MachineLearningCodeVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningCodeVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
