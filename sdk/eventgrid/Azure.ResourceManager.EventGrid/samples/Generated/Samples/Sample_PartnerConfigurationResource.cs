// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventGrid.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_PartnerConfigurationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PartnerConfigurationsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PartnerConfigurations_Get.json
            // this example is just showing the usage of "PartnerConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerConfigurationResource created on azure
            // for more information of creating PartnerConfigurationResource, please refer to the document of PartnerConfigurationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            ResourceIdentifier partnerConfigurationResourceId = PartnerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            PartnerConfigurationResource partnerConfiguration = client.GetPartnerConfigurationResource(partnerConfigurationResourceId);

            // invoke the operation
            PartnerConfigurationResource result = await partnerConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_PartnerConfigurationsDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PartnerConfigurations_Delete.json
            // this example is just showing the usage of "PartnerConfigurations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerConfigurationResource created on azure
            // for more information of creating PartnerConfigurationResource, please refer to the document of PartnerConfigurationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            ResourceIdentifier partnerConfigurationResourceId = PartnerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            PartnerConfigurationResource partnerConfiguration = client.GetPartnerConfigurationResource(partnerConfigurationResourceId);

            // invoke the operation
            await partnerConfiguration.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PartnerConfigurationsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PartnerConfigurations_Update.json
            // this example is just showing the usage of "PartnerConfigurations_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerConfigurationResource created on azure
            // for more information of creating PartnerConfigurationResource, please refer to the document of PartnerConfigurationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            ResourceIdentifier partnerConfigurationResourceId = PartnerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            PartnerConfigurationResource partnerConfiguration = client.GetPartnerConfigurationResource(partnerConfigurationResourceId);

            // invoke the operation
            PartnerConfigurationPatch patch = new PartnerConfigurationPatch
            {
                Tags =
{
["tag1"] = "value11",
["tag2"] = "value22"
},
                DefaultMaximumExpirationTimeInDays = 100,
            };
            ArmOperation<PartnerConfigurationResource> lro = await partnerConfiguration.UpdateAsync(WaitUntil.Completed, patch);
            PartnerConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PartnerConfigurationsCreateOrUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PartnerConfigurations_CreateOrUpdate.json
            // this example is just showing the usage of "PartnerConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerConfigurationResource created on azure
            // for more information of creating PartnerConfigurationResource, please refer to the document of PartnerConfigurationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            ResourceIdentifier partnerConfigurationResourceId = PartnerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            PartnerConfigurationResource partnerConfiguration = client.GetPartnerConfigurationResource(partnerConfigurationResourceId);

            // invoke the operation
            PartnerConfigurationData data = new PartnerConfigurationData(default)
            {
                PartnerAuthorization = new PartnerAuthorization
                {
                    DefaultMaximumExpirationTimeInDays = 10,
                    AuthorizedPartnersList = {new EventGridPartnerContent
{
PartnerRegistrationImmutableId = Guid.Parse("941892bc-f5d0-4d1c-8fb5-477570fc2b71"),
PartnerName = "Contoso.Finance",
AuthorizationExpireOn = default,
}, new EventGridPartnerContent
{
PartnerRegistrationImmutableId = Guid.Parse("5362bdb6-ce3e-4d0d-9a5b-3eb92c8aab38"),
PartnerName = "fabrikam.HR",
AuthorizationExpireOn = default,
}},
                },
            };
            ArmOperation<PartnerConfigurationResource> lro = await partnerConfiguration.CreateOrUpdateAsync(WaitUntil.Completed, data);
            PartnerConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task AuthorizePartner_PartnerConfigurationsAuthorizePartner()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PartnerConfigurations_AuthorizePartner.json
            // this example is just showing the usage of "PartnerConfigurations_AuthorizePartner" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerConfigurationResource created on azure
            // for more information of creating PartnerConfigurationResource, please refer to the document of PartnerConfigurationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            ResourceIdentifier partnerConfigurationResourceId = PartnerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            PartnerConfigurationResource partnerConfiguration = client.GetPartnerConfigurationResource(partnerConfigurationResourceId);

            // invoke the operation
            EventGridPartnerContent content = new EventGridPartnerContent
            {
                PartnerRegistrationImmutableId = Guid.Parse("941892bc-f5d0-4d1c-8fb5-477570fc2b71"),
                PartnerName = "Contoso.Finance",
                AuthorizationExpireOn = default,
            };
            PartnerConfigurationResource result = await partnerConfiguration.AuthorizePartnerAsync(content);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UnauthorizePartner_PartnerConfigurationsUnauthorizePartner()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PartnerConfigurations_UnauthorizePartner.json
            // this example is just showing the usage of "PartnerConfigurations_UnauthorizePartner" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerConfigurationResource created on azure
            // for more information of creating PartnerConfigurationResource, please refer to the document of PartnerConfigurationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            ResourceIdentifier partnerConfigurationResourceId = PartnerConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            PartnerConfigurationResource partnerConfiguration = client.GetPartnerConfigurationResource(partnerConfigurationResourceId);

            // invoke the operation
            EventGridPartnerContent content = new EventGridPartnerContent
            {
                PartnerRegistrationImmutableId = Guid.Parse("941892bc-f5d0-4d1c-8fb5-477570fc2b71"),
                PartnerName = "Contoso.Finance",
                AuthorizationExpireOn = default,
            };
            PartnerConfigurationResource result = await partnerConfiguration.UnauthorizePartnerAsync(content);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
