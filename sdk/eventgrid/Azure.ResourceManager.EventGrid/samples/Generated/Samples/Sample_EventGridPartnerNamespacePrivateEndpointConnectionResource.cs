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
    public partial class Sample_EventGridPartnerNamespacePrivateEndpointConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PrivateEndpointConnections_Get.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridPartnerNamespacePrivateEndpointConnectionResource created on azure
            // for more information of creating EventGridPartnerNamespacePrivateEndpointConnectionResource, please refer to the document of EventGridPartnerNamespacePrivateEndpointConnectionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string parentName = "exampletopic1";
            string privateEndpointConnectionName = "BMTPE5.8A30D251-4C61-489D-A1AA-B37C4A329B8B";
            ResourceIdentifier eventGridPartnerNamespacePrivateEndpointConnectionResourceId = EventGridPartnerNamespacePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentName, privateEndpointConnectionName);
            EventGridPartnerNamespacePrivateEndpointConnectionResource eventGridPartnerNamespacePrivateEndpointConnection = client.GetEventGridPartnerNamespacePrivateEndpointConnectionResource(eventGridPartnerNamespacePrivateEndpointConnectionResourceId);

            // invoke the operation
            EventGridPartnerNamespacePrivateEndpointConnectionResource result = await eventGridPartnerNamespacePrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_PrivateEndpointConnectionsDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PrivateEndpointConnections_Delete.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridPartnerNamespacePrivateEndpointConnectionResource created on azure
            // for more information of creating EventGridPartnerNamespacePrivateEndpointConnectionResource, please refer to the document of EventGridPartnerNamespacePrivateEndpointConnectionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string parentName = "exampletopic1";
            string privateEndpointConnectionName = "BMTPE5.8A30D251-4C61-489D-A1AA-B37C4A329B8B";
            ResourceIdentifier eventGridPartnerNamespacePrivateEndpointConnectionResourceId = EventGridPartnerNamespacePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentName, privateEndpointConnectionName);
            EventGridPartnerNamespacePrivateEndpointConnectionResource eventGridPartnerNamespacePrivateEndpointConnection = client.GetEventGridPartnerNamespacePrivateEndpointConnectionResource(eventGridPartnerNamespacePrivateEndpointConnectionResourceId);

            // invoke the operation
            await eventGridPartnerNamespacePrivateEndpointConnection.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PrivateEndpointConnectionsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/PrivateEndpointConnections_Update.json
            // this example is just showing the usage of "PrivateEndpointConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridPartnerNamespacePrivateEndpointConnectionResource created on azure
            // for more information of creating EventGridPartnerNamespacePrivateEndpointConnectionResource, please refer to the document of EventGridPartnerNamespacePrivateEndpointConnectionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string parentName = "exampletopic1";
            string privateEndpointConnectionName = "BMTPE5.8A30D251-4C61-489D-A1AA-B37C4A329B8B";
            ResourceIdentifier eventGridPartnerNamespacePrivateEndpointConnectionResourceId = EventGridPartnerNamespacePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentName, privateEndpointConnectionName);
            EventGridPartnerNamespacePrivateEndpointConnectionResource eventGridPartnerNamespacePrivateEndpointConnection = client.GetEventGridPartnerNamespacePrivateEndpointConnectionResource(eventGridPartnerNamespacePrivateEndpointConnectionResourceId);

            // invoke the operation
            EventGridPrivateEndpointConnectionData data = new EventGridPrivateEndpointConnectionData
            {
                ConnectionState = new EventGridPrivateEndpointConnectionState
                {
                    Status = EventGridPrivateEndpointPersistedConnectionStatus.Approved,
                    Description = "approving connection",
                    ActionsRequired = "None",
                },
            };
            ArmOperation<EventGridPartnerNamespacePrivateEndpointConnectionResource> lro = await eventGridPartnerNamespacePrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            EventGridPartnerNamespacePrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
