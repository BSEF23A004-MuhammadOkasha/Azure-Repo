// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Billing.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingCustomerCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CustomersGetByBillingAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/customersGetByBillingAccount.json
            // this example is just showing the usage of "Customers_GetByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingCustomerResource
            BillingCustomerCollection collection = billingAccount.GetBillingCustomers();

            // invoke the operation
            string customerName = "11111111-1111-1111-1111-111111111111";
            BillingCustomerResource result = await collection.GetAsync(customerName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingCustomerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_CustomersGetByBillingAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/customersGetByBillingAccount.json
            // this example is just showing the usage of "Customers_GetByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingCustomerResource
            BillingCustomerCollection collection = billingAccount.GetBillingCustomers();

            // invoke the operation
            string customerName = "11111111-1111-1111-1111-111111111111";
            bool result = await collection.ExistsAsync(customerName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_CustomersGetByBillingAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/customersGetByBillingAccount.json
            // this example is just showing the usage of "Customers_GetByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingCustomerResource
            BillingCustomerCollection collection = billingAccount.GetBillingCustomers();

            // invoke the operation
            string customerName = "11111111-1111-1111-1111-111111111111";
            NullableResponse<BillingCustomerResource> response = await collection.GetIfExistsAsync(customerName);
            BillingCustomerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingCustomerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_CustomersListByBillingAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/customersListByBillingAccount.json
            // this example is just showing the usage of "Customers_ListByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingCustomerResource
            BillingCustomerCollection collection = billingAccount.GetBillingCustomers();

            // invoke the operation and iterate over the result
            BillingCustomerCollectionGetAllOptions options = new BillingCustomerCollectionGetAllOptions() { };
            await foreach (BillingCustomerResource item in collection.GetAllAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingCustomerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_CustomersListByBillingAccountWithExpand()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/customersListByBillingAccountWithExpand.json
            // this example is just showing the usage of "Customers_ListByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingCustomerResource
            BillingCustomerCollection collection = billingAccount.GetBillingCustomers();

            // invoke the operation and iterate over the result
            BillingCustomerCollectionGetAllOptions options = new BillingCustomerCollectionGetAllOptions() { Expand = "enabledAzurePlans,resellers" };
            await foreach (BillingCustomerResource item in collection.GetAllAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingCustomerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
