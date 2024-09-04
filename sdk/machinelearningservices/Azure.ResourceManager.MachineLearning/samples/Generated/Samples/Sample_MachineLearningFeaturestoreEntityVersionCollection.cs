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
    public partial class Sample_MachineLearningFeaturestoreEntityVersionCollection
    {
        // List Workspace Featurestore Entity Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListWorkspaceFeaturestoreEntityVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/FeaturestoreEntityVersion/list.json
            // this example is just showing the usage of "FeaturestoreEntityVersions_List" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this MachineLearningFeaturestoreEntityVersionResource
            MachineLearningFeaturestoreEntityVersionCollection collection = machineLearningFeatureStoreEntityContainer.GetMachineLearningFeaturestoreEntityVersions();

            // invoke the operation and iterate over the result
            MachineLearningFeaturestoreEntityVersionCollectionGetAllOptions options = new MachineLearningFeaturestoreEntityVersionCollectionGetAllOptions() { Tags = "string", ListViewType = MachineLearningListViewType.ActiveOnly };
            await foreach (MachineLearningFeaturestoreEntityVersionResource item in collection.GetAllAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningFeaturestoreEntityVersionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Workspace Featurestore Entity Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspaceFeaturestoreEntityVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/FeaturestoreEntityVersion/get.json
            // this example is just showing the usage of "FeaturestoreEntityVersions_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this MachineLearningFeaturestoreEntityVersionResource
            MachineLearningFeaturestoreEntityVersionCollection collection = machineLearningFeatureStoreEntityContainer.GetMachineLearningFeaturestoreEntityVersions();

            // invoke the operation
            string version = "string";
            MachineLearningFeaturestoreEntityVersionResource result = await collection.GetAsync(version);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningFeaturestoreEntityVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Workspace Featurestore Entity Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetWorkspaceFeaturestoreEntityVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/FeaturestoreEntityVersion/get.json
            // this example is just showing the usage of "FeaturestoreEntityVersions_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this MachineLearningFeaturestoreEntityVersionResource
            MachineLearningFeaturestoreEntityVersionCollection collection = machineLearningFeatureStoreEntityContainer.GetMachineLearningFeaturestoreEntityVersions();

            // invoke the operation
            string version = "string";
            bool result = await collection.ExistsAsync(version);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Workspace Featurestore Entity Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetWorkspaceFeaturestoreEntityVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/FeaturestoreEntityVersion/get.json
            // this example is just showing the usage of "FeaturestoreEntityVersions_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this MachineLearningFeaturestoreEntityVersionResource
            MachineLearningFeaturestoreEntityVersionCollection collection = machineLearningFeatureStoreEntityContainer.GetMachineLearningFeaturestoreEntityVersions();

            // invoke the operation
            string version = "string";
            NullableResponse<MachineLearningFeaturestoreEntityVersionResource> response = await collection.GetIfExistsAsync(version);
            MachineLearningFeaturestoreEntityVersionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningFeaturestoreEntityVersionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // CreateOrUpdate Workspace Featurestore Entity Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateWorkspaceFeaturestoreEntityVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/FeaturestoreEntityVersion/createOrUpdate.json
            // this example is just showing the usage of "FeaturestoreEntityVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this MachineLearningFeaturestoreEntityVersionResource
            MachineLearningFeaturestoreEntityVersionCollection collection = machineLearningFeatureStoreEntityContainer.GetMachineLearningFeaturestoreEntityVersions();

            // invoke the operation
            string version = "string";
            MachineLearningFeaturestoreEntityVersionData data = new MachineLearningFeaturestoreEntityVersionData(new MachineLearningFeatureStoreEntityVersionProperties()
            {
                IndexColumns =
{
new IndexColumn()
{
ColumnName = "string",
DataType = FeatureDataType.Datetime,
}
},
                IsAnonymous = false,
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
            ArmOperation<MachineLearningFeaturestoreEntityVersionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, version, data);
            MachineLearningFeaturestoreEntityVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningFeaturestoreEntityVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
