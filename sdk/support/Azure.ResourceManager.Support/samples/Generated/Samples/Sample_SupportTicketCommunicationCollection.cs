// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Support.Samples
{
    public partial class Sample_SupportTicketCommunicationCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListCommunicationsForASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/ListCommunicationsForSubscriptionSupportTicket.json
            // this example is just showing the usage of "Communications_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSupportTicketResource created on azure
            // for more information of creating SubscriptionSupportTicketResource, please refer to the document of SubscriptionSupportTicketResource
            string subscriptionId = "132d901f-189d-4381-9214-fe68e27e05a1";
            string supportTicketName = "testticket";
            ResourceIdentifier subscriptionSupportTicketResourceId = SubscriptionSupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SubscriptionSupportTicketResource subscriptionSupportTicket = client.GetSubscriptionSupportTicketResource(subscriptionSupportTicketResourceId);

            // get the collection of this SupportTicketCommunicationResource
            SupportTicketCommunicationCollection collection = subscriptionSupportTicket.GetSupportTicketCommunications();

            // invoke the operation and iterate over the result
            await foreach (SupportTicketCommunicationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketCommunicationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListWebCommunicationCreatedOnOrAfterASpecificDateForASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/ListWebCommunicationsForSubscriptionSupportTicketCreatedOnOrAfter.json
            // this example is just showing the usage of "Communications_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSupportTicketResource created on azure
            // for more information of creating SubscriptionSupportTicketResource, please refer to the document of SubscriptionSupportTicketResource
            string subscriptionId = "132d901f-189d-4381-9214-fe68e27e05a1";
            string supportTicketName = "testticket";
            ResourceIdentifier subscriptionSupportTicketResourceId = SubscriptionSupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SubscriptionSupportTicketResource subscriptionSupportTicket = client.GetSubscriptionSupportTicketResource(subscriptionSupportTicketResourceId);

            // get the collection of this SupportTicketCommunicationResource
            SupportTicketCommunicationCollection collection = subscriptionSupportTicket.GetSupportTicketCommunications();

            // invoke the operation and iterate over the result
            string filter = "communicationType eq 'web' and createdDate ge 2020-03-10T22:08:51Z";
            await foreach (SupportTicketCommunicationResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketCommunicationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListWebCommunicationsForASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/ListWebCommunicationsForSubscriptionSupportTicket.json
            // this example is just showing the usage of "Communications_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSupportTicketResource created on azure
            // for more information of creating SubscriptionSupportTicketResource, please refer to the document of SubscriptionSupportTicketResource
            string subscriptionId = "132d901f-189d-4381-9214-fe68e27e05a1";
            string supportTicketName = "testticket";
            ResourceIdentifier subscriptionSupportTicketResourceId = SubscriptionSupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SubscriptionSupportTicketResource subscriptionSupportTicket = client.GetSubscriptionSupportTicketResource(subscriptionSupportTicketResourceId);

            // get the collection of this SupportTicketCommunicationResource
            SupportTicketCommunicationCollection collection = subscriptionSupportTicket.GetSupportTicketCommunications();

            // invoke the operation and iterate over the result
            string filter = "communicationType eq 'web'";
            await foreach (SupportTicketCommunicationResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketCommunicationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetCommunicationDetailsForASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/GetCommunicationDetailsForSubscriptionSupportTicket.json
            // this example is just showing the usage of "Communications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSupportTicketResource created on azure
            // for more information of creating SubscriptionSupportTicketResource, please refer to the document of SubscriptionSupportTicketResource
            string subscriptionId = "132d901f-189d-4381-9214-fe68e27e05a1";
            string supportTicketName = "testticket";
            ResourceIdentifier subscriptionSupportTicketResourceId = SubscriptionSupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SubscriptionSupportTicketResource subscriptionSupportTicket = client.GetSubscriptionSupportTicketResource(subscriptionSupportTicketResourceId);

            // get the collection of this SupportTicketCommunicationResource
            SupportTicketCommunicationCollection collection = subscriptionSupportTicket.GetSupportTicketCommunications();

            // invoke the operation
            string communicationName = "testmessage";
            SupportTicketCommunicationResource result = await collection.GetAsync(communicationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketCommunicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetCommunicationDetailsForASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/GetCommunicationDetailsForSubscriptionSupportTicket.json
            // this example is just showing the usage of "Communications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSupportTicketResource created on azure
            // for more information of creating SubscriptionSupportTicketResource, please refer to the document of SubscriptionSupportTicketResource
            string subscriptionId = "132d901f-189d-4381-9214-fe68e27e05a1";
            string supportTicketName = "testticket";
            ResourceIdentifier subscriptionSupportTicketResourceId = SubscriptionSupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SubscriptionSupportTicketResource subscriptionSupportTicket = client.GetSubscriptionSupportTicketResource(subscriptionSupportTicketResourceId);

            // get the collection of this SupportTicketCommunicationResource
            SupportTicketCommunicationCollection collection = subscriptionSupportTicket.GetSupportTicketCommunications();

            // invoke the operation
            string communicationName = "testmessage";
            bool result = await collection.ExistsAsync(communicationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetCommunicationDetailsForASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/GetCommunicationDetailsForSubscriptionSupportTicket.json
            // this example is just showing the usage of "Communications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSupportTicketResource created on azure
            // for more information of creating SubscriptionSupportTicketResource, please refer to the document of SubscriptionSupportTicketResource
            string subscriptionId = "132d901f-189d-4381-9214-fe68e27e05a1";
            string supportTicketName = "testticket";
            ResourceIdentifier subscriptionSupportTicketResourceId = SubscriptionSupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SubscriptionSupportTicketResource subscriptionSupportTicket = client.GetSubscriptionSupportTicketResource(subscriptionSupportTicketResourceId);

            // get the collection of this SupportTicketCommunicationResource
            SupportTicketCommunicationCollection collection = subscriptionSupportTicket.GetSupportTicketCommunications();

            // invoke the operation
            string communicationName = "testmessage";
            NullableResponse<SupportTicketCommunicationResource> response = await collection.GetIfExistsAsync(communicationName);
            SupportTicketCommunicationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketCommunicationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_AddCommunicationToSubscriptionTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/CreateSupportTicketCommunication.json
            // this example is just showing the usage of "Communications_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSupportTicketResource created on azure
            // for more information of creating SubscriptionSupportTicketResource, please refer to the document of SubscriptionSupportTicketResource
            string subscriptionId = "132d901f-189d-4381-9214-fe68e27e05a1";
            string supportTicketName = "testticket";
            ResourceIdentifier subscriptionSupportTicketResourceId = SubscriptionSupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SubscriptionSupportTicketResource subscriptionSupportTicket = client.GetSubscriptionSupportTicketResource(subscriptionSupportTicketResourceId);

            // get the collection of this SupportTicketCommunicationResource
            SupportTicketCommunicationCollection collection = subscriptionSupportTicket.GetSupportTicketCommunications();

            // invoke the operation
            string communicationName = "testcommunication";
            SupportTicketCommunicationData data = new SupportTicketCommunicationData("This is a test message from a customer!", "This is a test message from a customer!")
            {
                Sender = "user@contoso.com",
            };
            ArmOperation<SupportTicketCommunicationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, communicationName, data);
            SupportTicketCommunicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketCommunicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
