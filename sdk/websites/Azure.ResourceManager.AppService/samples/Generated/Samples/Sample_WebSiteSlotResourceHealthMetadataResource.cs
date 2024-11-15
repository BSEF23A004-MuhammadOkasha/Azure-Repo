// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_WebSiteSlotResourceHealthMetadataResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetResourceHealthMetadata()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/GetResourceHealthMetadataBySite.json
            // this example is just showing the usage of "ResourceHealthMetadata_GetBySiteSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResourceHealthMetadataResource created on azure
            // for more information of creating WebSiteSlotResourceHealthMetadataResource, please refer to the document of WebSiteSlotResourceHealthMetadataResource
            string subscriptionId = "4adb32ad-8327-4cbb-b775-b84b4465bb38";
            string resourceGroupName = "Default-Web-NorthCentralUS";
            string name = "newsiteinnewASE-NCUS";
            string slot = "Production";
            ResourceIdentifier webSiteSlotResourceHealthMetadataResourceId = WebSiteSlotResourceHealthMetadataResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, slot);
            WebSiteSlotResourceHealthMetadataResource webSiteSlotResourceHealthMetadata = client.GetWebSiteSlotResourceHealthMetadataResource(webSiteSlotResourceHealthMetadataResourceId);

            // invoke the operation
            WebSiteSlotResourceHealthMetadataResource result = await webSiteSlotResourceHealthMetadata.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceHealthMetadataData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
