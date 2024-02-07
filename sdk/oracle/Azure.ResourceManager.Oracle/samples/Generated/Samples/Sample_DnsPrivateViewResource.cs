// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Oracle;

namespace Azure.ResourceManager.Oracle.Samples
{
    public partial class Sample_DnsPrivateViewResource
    {
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

            // this example assumes you already have this DnsPrivateViewResource created on azure
            // for more information of creating DnsPrivateViewResource, please refer to the document of DnsPrivateViewResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("eastus");
            string dnsprivateviewocid = "ocid1....aaaaaa";
            ResourceIdentifier dnsPrivateViewResourceId = DnsPrivateViewResource.CreateResourceIdentifier(subscriptionId, location, dnsprivateviewocid);
            DnsPrivateViewResource dnsPrivateView = client.GetDnsPrivateViewResource(dnsPrivateViewResourceId);

            // invoke the operation
            DnsPrivateViewResource result = await dnsPrivateView.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DnsPrivateViewData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
