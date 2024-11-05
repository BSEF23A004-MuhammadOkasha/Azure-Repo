// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.EventHubs.Samples
{
    public partial class Sample_EventHubsNamespaceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NameSpaceGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/EHNameSpaceGet.json
            // this example is just showing the usage of "Namespaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceResource created on azure
            // for more information of creating EventHubsNamespaceResource, please refer to the document of EventHubsNamespaceResource
            string subscriptionId = "SampleSubscription";
            string resourceGroupName = "ResurceGroupSample";
            string namespaceName = "NamespaceSample";
            ResourceIdentifier eventHubsNamespaceResourceId = EventHubsNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventHubsNamespaceResource eventHubsNamespace = client.GetEventHubsNamespaceResource(eventHubsNamespaceResourceId);

            // invoke the operation
            EventHubsNamespaceResource result = await eventHubsNamespace.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsNamespaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_NameSpaceDelete()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/EHNameSpaceDelete.json
            // this example is just showing the usage of "Namespaces_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceResource created on azure
            // for more information of creating EventHubsNamespaceResource, please refer to the document of EventHubsNamespaceResource
            string subscriptionId = "SampleSubscription";
            string resourceGroupName = "ResurceGroupSample";
            string namespaceName = "NamespaceSample";
            ResourceIdentifier eventHubsNamespaceResourceId = EventHubsNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventHubsNamespaceResource eventHubsNamespace = client.GetEventHubsNamespaceResource(eventHubsNamespaceResourceId);

            // invoke the operation
            await eventHubsNamespace.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_NamespacesUpdate()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/EHNameSpaceUpdate.json
            // this example is just showing the usage of "Namespaces_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceResource created on azure
            // for more information of creating EventHubsNamespaceResource, please refer to the document of EventHubsNamespaceResource
            string subscriptionId = "SampleSubscription";
            string resourceGroupName = "ResurceGroupSample";
            string namespaceName = "NamespaceSample";
            ResourceIdentifier eventHubsNamespaceResourceId = EventHubsNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventHubsNamespaceResource eventHubsNamespace = client.GetEventHubsNamespaceResource(eventHubsNamespaceResourceId);

            // invoke the operation
            EventHubsNamespaceData data = new EventHubsNamespaceData(new AzureLocation("East US"))
            {
                Identity = new ManagedServiceIdentity(default)
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/SampleSubscription/resourceGroups/ResurceGroupSample/providers/Microsoft.ManagedIdentity/userAssignedIdentities/ud2")] = null
},
                },
            };
            EventHubsNamespaceResource result = await eventHubsNamespace.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsNamespaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetPrivateLinkResources_NameSpacePrivateLinkResourcesGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/PrivateLinkResourcesGet.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceResource created on azure
            // for more information of creating EventHubsNamespaceResource, please refer to the document of EventHubsNamespaceResource
            string subscriptionId = "subID";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-2924";
            ResourceIdentifier eventHubsNamespaceResourceId = EventHubsNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventHubsNamespaceResource eventHubsNamespace = client.GetEventHubsNamespaceResource(eventHubsNamespaceResourceId);

            // invoke the operation and iterate over the result
            await foreach (EventHubsPrivateLinkResourceData item in eventHubsNamespace.GetPrivateLinkResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetNetworkSecurityPerimeterConfigurations_NamspaceNetworkSecurityPerimeterConfigurationList()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/NetworkSecurityPerimeterConfigurationList.json
            // this example is just showing the usage of "NetworkSecurityPerimeterConfiguration_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceResource created on azure
            // for more information of creating EventHubsNamespaceResource, please refer to the document of EventHubsNamespaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SDK-EventHub-4794";
            string namespaceName = "sdk-Namespace-5828";
            ResourceIdentifier eventHubsNamespaceResourceId = EventHubsNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventHubsNamespaceResource eventHubsNamespace = client.GetEventHubsNamespaceResource(eventHubsNamespaceResourceId);

            // invoke the operation and iterate over the result
            await foreach (EventHubsNetworkSecurityPerimeterConfiguration item in eventHubsNamespace.GetNetworkSecurityPerimeterConfigurationsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdateNetworkSecurityPerimeterConfiguration_NetworkSecurityPerimeterConfigurationList()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/NetworkSecurityPerimeterConfigurationReconcile.json
            // this example is just showing the usage of "NetworkSecurityPerimeterConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceResource created on azure
            // for more information of creating EventHubsNamespaceResource, please refer to the document of EventHubsNamespaceResource
            string subscriptionId = "subID";
            string resourceGroupName = "SDK-EventHub-4794";
            string namespaceName = "sdk-Namespace-5828";
            ResourceIdentifier eventHubsNamespaceResourceId = EventHubsNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventHubsNamespaceResource eventHubsNamespace = client.GetEventHubsNamespaceResource(eventHubsNamespaceResourceId);

            // invoke the operation
            string resourceAssociationName = "resourceAssociation1";
            await eventHubsNamespace.CreateOrUpdateNetworkSecurityPerimeterConfigurationAsync(WaitUntil.Completed, resourceAssociationName).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckEventHubsDisasterRecoveryNameAvailability_NamespacesCheckNameAvailability()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/disasterRecoveryConfigs/EHAliasCheckNameAvailability.json
            // this example is just showing the usage of "DisasterRecoveryConfigs_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceResource created on azure
            // for more information of creating EventHubsNamespaceResource, please refer to the document of EventHubsNamespaceResource
            string subscriptionId = "exampleSubscriptionId";
            string resourceGroupName = "exampleResourceGroup";
            string namespaceName = "sdk-Namespace-9080";
            ResourceIdentifier eventHubsNamespaceResourceId = EventHubsNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventHubsNamespaceResource eventHubsNamespace = client.GetEventHubsNamespaceResource(eventHubsNamespaceResourceId);

            // invoke the operation
            EventHubsNameAvailabilityContent content = new EventHubsNameAvailabilityContent("sdk-DisasterRecovery-9474");
            EventHubsNameAvailabilityResult result = await eventHubsNamespace.CheckEventHubsDisasterRecoveryNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
