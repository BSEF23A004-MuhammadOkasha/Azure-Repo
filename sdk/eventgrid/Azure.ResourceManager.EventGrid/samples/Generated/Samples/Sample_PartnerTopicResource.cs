// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventGrid.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_PartnerTopicResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PartnerTopicsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PartnerTopics_Get.json
            // this example is just showing the usage of "PartnerTopics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerTopicResource created on azure
            // for more information of creating PartnerTopicResource, please refer to the document of PartnerTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerTopicName = "examplePartnerTopicName1";
            ResourceIdentifier partnerTopicResourceId = PartnerTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerTopicName);
            PartnerTopicResource partnerTopic = client.GetPartnerTopicResource(partnerTopicResourceId);

            // invoke the operation
            PartnerTopicResource result = await partnerTopic.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_PartnerTopicsDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PartnerTopics_Delete.json
            // this example is just showing the usage of "PartnerTopics_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerTopicResource created on azure
            // for more information of creating PartnerTopicResource, please refer to the document of PartnerTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerTopicName = "examplePartnerTopicName1";
            ResourceIdentifier partnerTopicResourceId = PartnerTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerTopicName);
            PartnerTopicResource partnerTopic = client.GetPartnerTopicResource(partnerTopicResourceId);

            // invoke the operation
            await partnerTopic.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PartnerTopicsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PartnerTopics_Update.json
            // this example is just showing the usage of "PartnerTopics_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerTopicResource created on azure
            // for more information of creating PartnerTopicResource, please refer to the document of PartnerTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerTopicName = "examplePartnerTopicName1";
            ResourceIdentifier partnerTopicResourceId = PartnerTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerTopicName);
            PartnerTopicResource partnerTopic = client.GetPartnerTopicResource(partnerTopicResourceId);

            // invoke the operation
            PartnerTopicPatch patch = new PartnerTopicPatch
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            PartnerTopicResource result = await partnerTopic.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Activate_PartnerTopicsActivate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PartnerTopics_Activate.json
            // this example is just showing the usage of "PartnerTopics_Activate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerTopicResource created on azure
            // for more information of creating PartnerTopicResource, please refer to the document of PartnerTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerTopicName = "examplePartnerTopic1";
            ResourceIdentifier partnerTopicResourceId = PartnerTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerTopicName);
            PartnerTopicResource partnerTopic = client.GetPartnerTopicResource(partnerTopicResourceId);

            // invoke the operation
            PartnerTopicResource result = await partnerTopic.ActivateAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Deactivate_PartnerTopicsDeactivate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PartnerTopics_Deactivate.json
            // this example is just showing the usage of "PartnerTopics_Deactivate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerTopicResource created on azure
            // for more information of creating PartnerTopicResource, please refer to the document of PartnerTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerTopicName = "examplePartnerTopic1";
            ResourceIdentifier partnerTopicResourceId = PartnerTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerTopicName);
            PartnerTopicResource partnerTopic = client.GetPartnerTopicResource(partnerTopicResourceId);

            // invoke the operation
            PartnerTopicResource result = await partnerTopic.DeactivateAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
