// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.DataShare.Samples
{
    public partial class Sample_ProviderShareSubscriptionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ProviderShareSubscriptionsGetByShare()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ProviderShareSubscriptions_GetByShare.json
            // this example is just showing the usage of "ProviderShareSubscriptions_GetByShare" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ProviderShareSubscriptionResource
            ProviderShareSubscriptionCollection collection = dataShare.GetProviderShareSubscriptions();

            // invoke the operation
            string providerShareSubscriptionId = "4256e2cf-0f82-4865-961b-12f83333f487";
            ProviderShareSubscriptionResource result = await collection.GetAsync(providerShareSubscriptionId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProviderShareSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ProviderShareSubscriptionsGetByShare()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ProviderShareSubscriptions_GetByShare.json
            // this example is just showing the usage of "ProviderShareSubscriptions_GetByShare" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ProviderShareSubscriptionResource
            ProviderShareSubscriptionCollection collection = dataShare.GetProviderShareSubscriptions();

            // invoke the operation
            string providerShareSubscriptionId = "4256e2cf-0f82-4865-961b-12f83333f487";
            bool result = await collection.ExistsAsync(providerShareSubscriptionId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ProviderShareSubscriptionsGetByShare()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ProviderShareSubscriptions_GetByShare.json
            // this example is just showing the usage of "ProviderShareSubscriptions_GetByShare" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ProviderShareSubscriptionResource
            ProviderShareSubscriptionCollection collection = dataShare.GetProviderShareSubscriptions();

            // invoke the operation
            string providerShareSubscriptionId = "4256e2cf-0f82-4865-961b-12f83333f487";
            NullableResponse<ProviderShareSubscriptionResource> response = await collection.GetIfExistsAsync(providerShareSubscriptionId);
            ProviderShareSubscriptionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProviderShareSubscriptionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ProviderShareSubscriptionsListByShare()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ProviderShareSubscriptions_ListByShare.json
            // this example is just showing the usage of "ProviderShareSubscriptions_ListByShare" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "12345678-1234-1234-12345678abc";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ProviderShareSubscriptionResource
            ProviderShareSubscriptionCollection collection = dataShare.GetProviderShareSubscriptions();

            // invoke the operation and iterate over the result
            await foreach (ProviderShareSubscriptionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProviderShareSubscriptionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
