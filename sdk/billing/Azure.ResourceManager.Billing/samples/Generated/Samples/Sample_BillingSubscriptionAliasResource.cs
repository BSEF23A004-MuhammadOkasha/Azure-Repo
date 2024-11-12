// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingSubscriptionAliasResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BillingSubscriptionAliasGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingSubscriptionAliasGet.json
            // this example is just showing the usage of "BillingSubscriptionsAliases_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingSubscriptionAliasResource created on azure
            // for more information of creating BillingSubscriptionAliasResource, please refer to the document of BillingSubscriptionAliasResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string aliasName = "c356b7c7-7545-4686-b843-c1a49cf853fc";
            ResourceIdentifier billingSubscriptionAliasResourceId = BillingSubscriptionAliasResource.CreateResourceIdentifier(billingAccountName, aliasName);
            BillingSubscriptionAliasResource billingSubscriptionAlias = client.GetBillingSubscriptionAliasResource(billingSubscriptionAliasResourceId);

            // invoke the operation
            BillingSubscriptionAliasResource result = await billingSubscriptionAlias.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingSubscriptionAliasData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_BillingSubscriptionAliasCreateOrUpdate()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingSubscriptionAliasCreateOrUpdate.json
            // this example is just showing the usage of "BillingSubscriptionsAliases_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingSubscriptionAliasResource created on azure
            // for more information of creating BillingSubscriptionAliasResource, please refer to the document of BillingSubscriptionAliasResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string aliasName = "c356b7c7-7545-4686-b843-c1a49cf853fc";
            ResourceIdentifier billingSubscriptionAliasResourceId = BillingSubscriptionAliasResource.CreateResourceIdentifier(billingAccountName, aliasName);
            BillingSubscriptionAliasResource billingSubscriptionAlias = client.GetBillingSubscriptionAliasResource(billingSubscriptionAliasResourceId);

            // invoke the operation
            BillingSubscriptionAliasData data = new BillingSubscriptionAliasData()
            {
                BillingFrequency = "P1M",
                DisplayName = "Subscription 3",
                Quantity = 1L,
                SkuId = "0001",
                TermDuration = XmlConvert.ToTimeSpan("P1M"),
            };
            ArmOperation<BillingSubscriptionAliasResource> lro = await billingSubscriptionAlias.UpdateAsync(WaitUntil.Completed, data);
            BillingSubscriptionAliasResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingSubscriptionAliasData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
