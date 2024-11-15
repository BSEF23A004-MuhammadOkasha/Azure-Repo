// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_TopicSpaceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_TopicSpacesGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/TopicSpaces_Get.json
            // this example is just showing the usage of "TopicSpaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this TopicSpaceResource
            TopicSpaceCollection collection = eventGridNamespace.GetTopicSpaces();

            // invoke the operation
            string topicSpaceName = "exampleTopicSpaceName1";
            TopicSpaceResource result = await collection.GetAsync(topicSpaceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TopicSpaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_TopicSpacesGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/TopicSpaces_Get.json
            // this example is just showing the usage of "TopicSpaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this TopicSpaceResource
            TopicSpaceCollection collection = eventGridNamespace.GetTopicSpaces();

            // invoke the operation
            string topicSpaceName = "exampleTopicSpaceName1";
            bool result = await collection.ExistsAsync(topicSpaceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_TopicSpacesGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/TopicSpaces_Get.json
            // this example is just showing the usage of "TopicSpaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this TopicSpaceResource
            TopicSpaceCollection collection = eventGridNamespace.GetTopicSpaces();

            // invoke the operation
            string topicSpaceName = "exampleTopicSpaceName1";
            NullableResponse<TopicSpaceResource> response = await collection.GetIfExistsAsync(topicSpaceName);
            TopicSpaceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TopicSpaceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_TopicSpacesCreateOrUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/TopicSpaces_CreateOrUpdate.json
            // this example is just showing the usage of "TopicSpaces_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this TopicSpaceResource
            TopicSpaceCollection collection = eventGridNamespace.GetTopicSpaces();

            // invoke the operation
            string topicSpaceName = "exampleTopicSpaceName1";
            TopicSpaceData data = new TopicSpaceData()
            {
                TopicTemplates =
{
"filter1","filter2"
},
            };
            ArmOperation<TopicSpaceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, topicSpaceName, data);
            TopicSpaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TopicSpaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_TopicSpacesListByNamespace()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/TopicSpaces_ListByNamespace.json
            // this example is just showing the usage of "TopicSpaces_ListByNamespace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "namespace123";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this TopicSpaceResource
            TopicSpaceCollection collection = eventGridNamespace.GetTopicSpaces();

            // invoke the operation and iterate over the result
            await foreach (TopicSpaceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TopicSpaceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
