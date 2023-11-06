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
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Samples
{
    public partial class Sample_LocalRulestackFqdnCollection
    {
        // FqdnListLocalRulestack_ListByLocalRulestacks_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_FqdnListLocalRulestackListByLocalRulestacksMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListLocalRulestack_ListByLocalRulestacks_MaximumSet_Gen.json
            // this example is just showing the usage of "FqdnListLocalRulestack_ListByLocalRulestacks" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "rgopenapi";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackFqdnResource
            LocalRulestackFqdnCollection collection = localRulestack.GetLocalRulestackFqdns();

            // invoke the operation and iterate over the result
            await foreach (LocalRulestackFqdnResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LocalRulestackFqdnData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // FqdnListLocalRulestack_ListByLocalRulestacks_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_FqdnListLocalRulestackListByLocalRulestacksMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListLocalRulestack_ListByLocalRulestacks_MinimumSet_Gen.json
            // this example is just showing the usage of "FqdnListLocalRulestack_ListByLocalRulestacks" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "rgopenapi";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackFqdnResource
            LocalRulestackFqdnCollection collection = localRulestack.GetLocalRulestackFqdns();

            // invoke the operation and iterate over the result
            await foreach (LocalRulestackFqdnResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LocalRulestackFqdnData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // FqdnListLocalRulestack_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FqdnListLocalRulestackGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListLocalRulestack_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FqdnListLocalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "rgopenapi";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackFqdnResource
            LocalRulestackFqdnCollection collection = localRulestack.GetLocalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            LocalRulestackFqdnResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulestackFqdnData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FqdnListLocalRulestack_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_FqdnListLocalRulestackGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListLocalRulestack_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FqdnListLocalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "rgopenapi";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackFqdnResource
            LocalRulestackFqdnCollection collection = localRulestack.GetLocalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // FqdnListLocalRulestack_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_FqdnListLocalRulestackGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListLocalRulestack_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FqdnListLocalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "rgopenapi";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackFqdnResource
            LocalRulestackFqdnCollection collection = localRulestack.GetLocalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            NullableResponse<LocalRulestackFqdnResource> response = await collection.GetIfExistsAsync(name);
            LocalRulestackFqdnResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LocalRulestackFqdnData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // FqdnListLocalRulestack_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FqdnListLocalRulestackGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListLocalRulestack_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "FqdnListLocalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "rgopenapi";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackFqdnResource
            LocalRulestackFqdnCollection collection = localRulestack.GetLocalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            LocalRulestackFqdnResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulestackFqdnData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FqdnListLocalRulestack_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_FqdnListLocalRulestackGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListLocalRulestack_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "FqdnListLocalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "rgopenapi";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackFqdnResource
            LocalRulestackFqdnCollection collection = localRulestack.GetLocalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // FqdnListLocalRulestack_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_FqdnListLocalRulestackGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListLocalRulestack_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "FqdnListLocalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "rgopenapi";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackFqdnResource
            LocalRulestackFqdnCollection collection = localRulestack.GetLocalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            NullableResponse<LocalRulestackFqdnResource> response = await collection.GetIfExistsAsync(name);
            LocalRulestackFqdnResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LocalRulestackFqdnData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // FqdnListLocalRulestack_CreateOrUpdate_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_FqdnListLocalRulestackCreateOrUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListLocalRulestack_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "FqdnListLocalRulestack_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "rgopenapi";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackFqdnResource
            LocalRulestackFqdnCollection collection = localRulestack.GetLocalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            LocalRulestackFqdnData data = new LocalRulestackFqdnData(new string[]
            {
"string1","string2"
            })
            {
                Description = "string",
                ETag = new ETag("aaaaaaaaaaaaaaaaaa"),
                AuditComment = "string",
            };
            ArmOperation<LocalRulestackFqdnResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            LocalRulestackFqdnResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulestackFqdnData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FqdnListLocalRulestack_CreateOrUpdate_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_FqdnListLocalRulestackCreateOrUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListLocalRulestack_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "FqdnListLocalRulestack_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulestackResource created on azure
            // for more information of creating LocalRulestackResource, please refer to the document of LocalRulestackResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "rgopenapi";
            string localRulestackName = "lrs1";
            ResourceIdentifier localRulestackResourceId = LocalRulestackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName);
            LocalRulestackResource localRulestack = client.GetLocalRulestackResource(localRulestackResourceId);

            // get the collection of this LocalRulestackFqdnResource
            LocalRulestackFqdnCollection collection = localRulestack.GetLocalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            LocalRulestackFqdnData data = new LocalRulestackFqdnData(new string[]
            {
"string1","string2"
            });
            ArmOperation<LocalRulestackFqdnResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            LocalRulestackFqdnResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulestackFqdnData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
