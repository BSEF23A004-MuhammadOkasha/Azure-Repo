// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.KeyVault.Samples
{
    public partial class Sample_ManagedHsmResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAnExistingManagedHSMPool()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2023-07-01/examples/ManagedHsm_Update.json
            // this example is just showing the usage of "ManagedHsms_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedHsmResource created on azure
            // for more information of creating ManagedHsmResource, please refer to the document of ManagedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "hsm-group";
            string name = "hsm1";
            ResourceIdentifier managedHsmResourceId = ManagedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ManagedHsmResource managedHsm = client.GetManagedHsmResource(managedHsmResourceId);

            // invoke the operation
            ManagedHsmData data = new ManagedHsmData(new AzureLocation("placeholder"))
            {
                Tags =
{
["Dept"] = "hsm",
["Environment"] = "dogfood",
["Slice"] = "A",
},
            };
            ArmOperation<ManagedHsmResource> lro = await managedHsm.UpdateAsync(WaitUntil.Completed, data);
            ManagedHsmResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedHsmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAManagedHSMPool()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2023-07-01/examples/ManagedHsm_Delete.json
            // this example is just showing the usage of "ManagedHsms_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedHsmResource created on azure
            // for more information of creating ManagedHsmResource, please refer to the document of ManagedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "hsm-group";
            string name = "hsm1";
            ResourceIdentifier managedHsmResourceId = ManagedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ManagedHsmResource managedHsm = client.GetManagedHsmResource(managedHsmResourceId);

            // invoke the operation
            await managedHsm.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RetrieveAManagedHSMPool()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2023-07-01/examples/ManagedHsm_Get.json
            // this example is just showing the usage of "ManagedHsms_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedHsmResource created on azure
            // for more information of creating ManagedHsmResource, please refer to the document of ManagedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "hsm-group";
            string name = "hsm1";
            ResourceIdentifier managedHsmResourceId = ManagedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ManagedHsmResource managedHsm = client.GetManagedHsmResource(managedHsmResourceId);

            // invoke the operation
            ManagedHsmResource result = await managedHsm.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedHsmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetManagedHsms_ListManagedHSMPoolsInASubscription()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2023-07-01/examples/ManagedHsm_ListBySubscription.json
            // this example is just showing the usage of "ManagedHsms_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ManagedHsmResource item in subscriptionResource.GetManagedHsmsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedHsmData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckManagedHsmNameAvailability_ValidateAManagedHsmName()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2023-07-01/examples/ManagedHsm_checkMhsmNameAvailability.json
            // this example is just showing the usage of "ManagedHsms_CheckManagedHsmNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            ManagedHsmNameAvailabilityContent content = new ManagedHsmNameAvailabilityContent("sample-mhsm");
            ManagedHsmNameAvailabilityResult result = await subscriptionResource.CheckManagedHsmNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetMHSMPrivateLinkResourcesByManagedHsmResource_KeyVaultListPrivateLinkResources()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2023-07-01/examples/ManagedHsm_listPrivateLinkResources.json
            // this example is just showing the usage of "MHSMPrivateLinkResources_ListByManagedHsmResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedHsmResource created on azure
            // for more information of creating ManagedHsmResource, please refer to the document of ManagedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            string name = "sample-mhsm";
            ResourceIdentifier managedHsmResourceId = ManagedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ManagedHsmResource managedHsm = client.GetManagedHsmResource(managedHsmResourceId);

            // invoke the operation and iterate over the result
            await foreach (ManagedHsmPrivateLinkResourceData item in managedHsm.GetMHSMPrivateLinkResourcesByManagedHsmResourceAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetMHSMRegionsByResource_ListManagedHSMPoolsInASubscription()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2023-07-01/examples/ManagedHsm_ListRegionsByResource.json
            // this example is just showing the usage of "MHSMRegions_ListByResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedHsmResource created on azure
            // for more information of creating ManagedHsmResource, please refer to the document of ManagedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            string name = "sample-mhsm";
            ResourceIdentifier managedHsmResourceId = ManagedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ManagedHsmResource managedHsm = client.GetManagedHsmResource(managedHsmResourceId);

            // invoke the operation and iterate over the result
            await foreach (ManagedHsmGeoReplicatedRegion item in managedHsm.GetMHSMRegionsByResourceAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
