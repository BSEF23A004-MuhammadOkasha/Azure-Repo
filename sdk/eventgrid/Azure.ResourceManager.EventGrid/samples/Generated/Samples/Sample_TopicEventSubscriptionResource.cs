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
    public partial class Sample_TopicEventSubscriptionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_TopicEventSubscriptionsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/TopicEventSubscriptions_Get.json
            // this example is just showing the usage of "TopicEventSubscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TopicEventSubscriptionResource created on azure
            // for more information of creating TopicEventSubscriptionResource, please refer to the document of TopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string topicName = "exampleTopic1";
            string eventSubscriptionName = "examplesubscription1";
            ResourceIdentifier topicEventSubscriptionResourceId = TopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, topicName, eventSubscriptionName);
            TopicEventSubscriptionResource topicEventSubscription = client.GetTopicEventSubscriptionResource(topicEventSubscriptionResourceId);

            // invoke the operation
            TopicEventSubscriptionResource result = await topicEventSubscription.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_TopicEventSubscriptionsDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/TopicEventSubscriptions_Delete.json
            // this example is just showing the usage of "TopicEventSubscriptions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TopicEventSubscriptionResource created on azure
            // for more information of creating TopicEventSubscriptionResource, please refer to the document of TopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string topicName = "exampleTopic1";
            string eventSubscriptionName = "examplesubscription1";
            ResourceIdentifier topicEventSubscriptionResourceId = TopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, topicName, eventSubscriptionName);
            TopicEventSubscriptionResource topicEventSubscription = client.GetTopicEventSubscriptionResource(topicEventSubscriptionResourceId);

            // invoke the operation
            await topicEventSubscription.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_TopicEventSubscriptionsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/TopicEventSubscriptions_Update.json
            // this example is just showing the usage of "TopicEventSubscriptions_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TopicEventSubscriptionResource created on azure
            // for more information of creating TopicEventSubscriptionResource, please refer to the document of TopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string topicName = "exampleTopic1";
            string eventSubscriptionName = "exampleEventSubscriptionName1";
            ResourceIdentifier topicEventSubscriptionResourceId = TopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, topicName, eventSubscriptionName);
            TopicEventSubscriptionResource topicEventSubscription = client.GetTopicEventSubscriptionResource(topicEventSubscriptionResourceId);

            // invoke the operation
            EventGridSubscriptionPatch patch = new EventGridSubscriptionPatch
            {
                Destination = new WebHookEventSubscriptionDestination
                {
                    Endpoint = new Uri("https://requestb.in/15ksip71"),
                },
                Filter = new EventSubscriptionFilter
                {
                    SubjectBeginsWith = "existingPrefix",
                    SubjectEndsWith = "newSuffix",
                    IsSubjectCaseSensitive = true,
                },
                Labels = { "label1", "label2" },
            };
            ArmOperation<TopicEventSubscriptionResource> lro = await topicEventSubscription.UpdateAsync(WaitUntil.Completed, patch);
            TopicEventSubscriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetDeliveryAttributes_TopicEventSubscriptionsGetDeliveryAttributes()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/TopicEventSubscriptions_GetDeliveryAttributes.json
            // this example is just showing the usage of "TopicEventSubscriptions_GetDeliveryAttributes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TopicEventSubscriptionResource created on azure
            // for more information of creating TopicEventSubscriptionResource, please refer to the document of TopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string topicName = "exampleTopic1";
            string eventSubscriptionName = "examplesubscription1";
            ResourceIdentifier topicEventSubscriptionResourceId = TopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, topicName, eventSubscriptionName);
            TopicEventSubscriptionResource topicEventSubscription = client.GetTopicEventSubscriptionResource(topicEventSubscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DeliveryAttributeMapping item in topicEventSubscription.GetDeliveryAttributesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetFullUri_TopicEventSubscriptionsGetFullUrl()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/TopicEventSubscriptions_GetFullUrl.json
            // this example is just showing the usage of "TopicEventSubscriptions_GetFullUri" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TopicEventSubscriptionResource created on azure
            // for more information of creating TopicEventSubscriptionResource, please refer to the document of TopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string topicName = "exampleTopic1";
            string eventSubscriptionName = "examplesubscription1";
            ResourceIdentifier topicEventSubscriptionResourceId = TopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, topicName, eventSubscriptionName);
            TopicEventSubscriptionResource topicEventSubscription = client.GetTopicEventSubscriptionResource(topicEventSubscriptionResourceId);

            // invoke the operation
            EventSubscriptionFullUri result = await topicEventSubscription.GetFullUriAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
