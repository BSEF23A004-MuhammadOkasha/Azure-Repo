// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningServerlessEndpointCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListWorkspaceServerlessEndpoint()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/ServerlessEndpoint/list.json
            // this example is just showing the usage of "ServerlessEndpoints_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this MachineLearningServerlessEndpointResource
            MachineLearningServerlessEndpointCollection collection = machineLearningWorkspace.GetMachineLearningServerlessEndpoints();

            // invoke the operation and iterate over the result
            await foreach (MachineLearningServerlessEndpointResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningServerlessEndpointData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetWorkspaceServerlessEndpoint()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/ServerlessEndpoint/get.json
            // this example is just showing the usage of "ServerlessEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this MachineLearningServerlessEndpointResource
            MachineLearningServerlessEndpointCollection collection = machineLearningWorkspace.GetMachineLearningServerlessEndpoints();

            // invoke the operation
            string name = "string";
            MachineLearningServerlessEndpointResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningServerlessEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetWorkspaceServerlessEndpoint()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/ServerlessEndpoint/get.json
            // this example is just showing the usage of "ServerlessEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this MachineLearningServerlessEndpointResource
            MachineLearningServerlessEndpointCollection collection = machineLearningWorkspace.GetMachineLearningServerlessEndpoints();

            // invoke the operation
            string name = "string";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetWorkspaceServerlessEndpoint()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/ServerlessEndpoint/get.json
            // this example is just showing the usage of "ServerlessEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this MachineLearningServerlessEndpointResource
            MachineLearningServerlessEndpointCollection collection = machineLearningWorkspace.GetMachineLearningServerlessEndpoints();

            // invoke the operation
            string name = "string";
            NullableResponse<MachineLearningServerlessEndpointResource> response = await collection.GetIfExistsAsync(name);
            MachineLearningServerlessEndpointResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningServerlessEndpointData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateWorkspaceServerlessEndpoint()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/ServerlessEndpoint/createOrUpdate.json
            // this example is just showing the usage of "ServerlessEndpoints_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this MachineLearningServerlessEndpointResource
            MachineLearningServerlessEndpointCollection collection = machineLearningWorkspace.GetMachineLearningServerlessEndpoints();

            // invoke the operation
            string name = "string";
            MachineLearningServerlessEndpointData data = new MachineLearningServerlessEndpointData(new AzureLocation("string"), new ServerlessEndpointProperties(ServerlessInferenceEndpointAuthMode.Key)
            {
                ModelId = "string",
                ContentSafetyStatus = ContentSafetyStatus.Enabled,
            })
            {
                Kind = "string",
                Identity = new ManagedServiceIdentity("SystemAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("string")] = new UserAssignedIdentity(),
},
                },
                Sku = new MachineLearningSku("string")
                {
                    Tier = MachineLearningSkuTier.Standard,
                    Size = "string",
                    Family = "string",
                    Capacity = 1,
                },
                Tags =
{
},
            };
            ArmOperation<MachineLearningServerlessEndpointResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            MachineLearningServerlessEndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningServerlessEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
