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
using Azure.ResourceManager.MachineLearning;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningFeatureStoreEntityContainerResource
    {
        // Delete Workspace Featurestore Entity Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteWorkspaceFeaturestoreEntityContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/FeaturestoreEntityContainer/delete.json
            // this example is just showing the usage of "FeaturestoreEntityContainers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningFeatureStoreEntityContainerResource created on azure
            // for more information of creating MachineLearningFeatureStoreEntityContainerResource, please refer to the document of MachineLearningFeatureStoreEntityContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningFeatureStoreEntityContainerResourceId = MachineLearningFeatureStoreEntityContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningFeatureStoreEntityContainerResource machineLearningFeatureStoreEntityContainer = client.GetMachineLearningFeatureStoreEntityContainerResource(machineLearningFeatureStoreEntityContainerResourceId);

            // invoke the operation
            await machineLearningFeatureStoreEntityContainer.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // GetEntity Workspace Featurestore Entity Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetEntityWorkspaceFeaturestoreEntityContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/FeaturestoreEntityContainer/getEntity.json
            // this example is just showing the usage of "FeaturestoreEntityContainers_GetEntity" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningFeatureStoreEntityContainerResource created on azure
            // for more information of creating MachineLearningFeatureStoreEntityContainerResource, please refer to the document of MachineLearningFeatureStoreEntityContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningFeatureStoreEntityContainerResourceId = MachineLearningFeatureStoreEntityContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningFeatureStoreEntityContainerResource machineLearningFeatureStoreEntityContainer = client.GetMachineLearningFeatureStoreEntityContainerResource(machineLearningFeatureStoreEntityContainerResourceId);

            // invoke the operation
            MachineLearningFeatureStoreEntityContainerResource result = await machineLearningFeatureStoreEntityContainer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningFeatureStoreEntityContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate Workspace Featurestore Entity Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateWorkspaceFeaturestoreEntityContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/FeaturestoreEntityContainer/createOrUpdate.json
            // this example is just showing the usage of "FeaturestoreEntityContainers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningFeatureStoreEntityContainerResource created on azure
            // for more information of creating MachineLearningFeatureStoreEntityContainerResource, please refer to the document of MachineLearningFeatureStoreEntityContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            ResourceIdentifier machineLearningFeatureStoreEntityContainerResourceId = MachineLearningFeatureStoreEntityContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningFeatureStoreEntityContainerResource machineLearningFeatureStoreEntityContainer = client.GetMachineLearningFeatureStoreEntityContainerResource(machineLearningFeatureStoreEntityContainerResourceId);

            // invoke the operation
            MachineLearningFeatureStoreEntityContainerData data = new MachineLearningFeatureStoreEntityContainerData(new MachineLearningFeatureStoreEntityContainerProperties()
            {
                IsArchived = false,
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
            ArmOperation<MachineLearningFeatureStoreEntityContainerResource> lro = await machineLearningFeatureStoreEntityContainer.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningFeatureStoreEntityContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningFeatureStoreEntityContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
