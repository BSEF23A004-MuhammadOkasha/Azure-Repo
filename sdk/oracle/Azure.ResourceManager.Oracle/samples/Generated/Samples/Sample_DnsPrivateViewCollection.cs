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
using Azure.ResourceManager.Oracle;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Oracle.Samples
{
    public partial class Sample_DnsPrivateViewCollection
    {
        // List DnsPrivateViews by location
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListDnsPrivateViewsByLocation()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/preview/2023-09-01-preview/examples/dnsPrivateViews_listByLocation.json
            // this example is just showing the usage of "DnsPrivateViews_ListByLocation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this DnsPrivateViewResource
            AzureLocation location = new AzureLocation("eastus");
            DnsPrivateViewCollection collection = subscriptionResource.GetDnsPrivateViews(location);

            // invoke the operation and iterate over the result
            await foreach (DnsPrivateViewResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DnsPrivateViewData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a DnsPrivateView by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetADnsPrivateViewByName()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/preview/2023-09-01-preview/examples/dnsPrivateViews_get.json
            // this example is just showing the usage of "DnsPrivateViews_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this DnsPrivateViewResource
            AzureLocation location = new AzureLocation("eastus");
            DnsPrivateViewCollection collection = subscriptionResource.GetDnsPrivateViews(location);

            // invoke the operation
            string dnsprivateviewocid = "ocid1....aaaaaa";
            DnsPrivateViewResource result = await collection.GetAsync(dnsprivateviewocid);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DnsPrivateViewData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a DnsPrivateView by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetADnsPrivateViewByName()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/preview/2023-09-01-preview/examples/dnsPrivateViews_get.json
            // this example is just showing the usage of "DnsPrivateViews_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this DnsPrivateViewResource
            AzureLocation location = new AzureLocation("eastus");
            DnsPrivateViewCollection collection = subscriptionResource.GetDnsPrivateViews(location);

            // invoke the operation
            string dnsprivateviewocid = "ocid1....aaaaaa";
            bool result = await collection.ExistsAsync(dnsprivateviewocid);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a DnsPrivateView by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetADnsPrivateViewByName()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/preview/2023-09-01-preview/examples/dnsPrivateViews_get.json
            // this example is just showing the usage of "DnsPrivateViews_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this DnsPrivateViewResource
            AzureLocation location = new AzureLocation("eastus");
            DnsPrivateViewCollection collection = subscriptionResource.GetDnsPrivateViews(location);

            // invoke the operation
            string dnsprivateviewocid = "ocid1....aaaaaa";
            NullableResponse<DnsPrivateViewResource> response = await collection.GetIfExistsAsync(dnsprivateviewocid);
            DnsPrivateViewResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DnsPrivateViewData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
