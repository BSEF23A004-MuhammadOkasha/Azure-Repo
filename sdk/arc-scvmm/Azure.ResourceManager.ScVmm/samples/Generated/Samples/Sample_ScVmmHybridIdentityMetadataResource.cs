// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ScVmm.Samples
{
    public partial class Sample_ScVmmHybridIdentityMetadataResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetHybridIdentityMetadata()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/GetVmInstanceHybridIdentityMetadata.json
            // this example is just showing the usage of "VirtualMachineInstanceHybridIdentityMetadata_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmHybridIdentityMetadataResource created on azure
            // for more information of creating ScVmmHybridIdentityMetadataResource, please refer to the document of ScVmmHybridIdentityMetadataResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.HybridCompute/machines/DemoVM";
            ResourceIdentifier scVmmHybridIdentityMetadataResourceId = ScVmmHybridIdentityMetadataResource.CreateResourceIdentifier(resourceUri);
            ScVmmHybridIdentityMetadataResource scVmmHybridIdentityMetadata = client.GetScVmmHybridIdentityMetadataResource(scVmmHybridIdentityMetadataResourceId);

            // invoke the operation
            ScVmmHybridIdentityMetadataResource result = await scVmmHybridIdentityMetadata.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmHybridIdentityMetadataData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
