// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.ServiceBus;
using Azure.ResourceManager.ServiceBus.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.ServiceBus.Tests.Mock
{
    /// <summary> Test for ServiceBusPrivateEndpointConnectionCollection. </summary>
    public partial class ServiceBusPrivateEndpointConnectionCollectionMockTests : MockTestBase
    {
        public ServiceBusPrivateEndpointConnectionCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: NameSpacePrivateEndPointConnectionCreate

            var serviceBusNamespaceResourceId = ServiceBus.ServiceBusNamespaceResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ArunMonocle", "sdk-Namespace-2924");
            var serviceBusNamespaceResource = GetArmClient().GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);
            var collection = serviceBusNamespaceResource.GetServiceBusPrivateEndpointConnections();
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, "privateEndpointConnectionName", new ServiceBusPrivateEndpointConnectionData()
            {
                PrivateEndpointId = new ResourceIdentifier("/subscriptions/dbedb4e0-40e6-4145-81f3-f1314c150774/resourceGroups/SDK-ServiceBus-8396/providers/Microsoft.Network/privateEndpoints/sdk-Namespace-2847"),
                ConnectionState = new ServiceBusPrivateLinkServiceConnectionState()
                {
                    Status = ServiceBusPrivateLinkConnectionStatus.Rejected,
                    Description = "testing",
                },
                ProvisioningState = ServiceBusPrivateEndpointConnectionProvisioningState.Succeeded,
            });
        }

        [RecordedTest]
        public async Task Exists()
        {
            // Example: NameSpacePrivateEndPointConnectionGet

            var serviceBusNamespaceResourceId = ServiceBus.ServiceBusNamespaceResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "SDK-ServiceBus-4794", "sdk-Namespace-5828");
            var serviceBusNamespaceResource = GetArmClient().GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);
            var collection = serviceBusNamespaceResource.GetServiceBusPrivateEndpointConnections();
            await collection.ExistsAsync("privateEndpointConnectionName");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: NameSpacePrivateEndPointConnectionGet

            var serviceBusNamespaceResourceId = ServiceBus.ServiceBusNamespaceResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "SDK-ServiceBus-4794", "sdk-Namespace-5828");
            var serviceBusNamespaceResource = GetArmClient().GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);
            var collection = serviceBusNamespaceResource.GetServiceBusPrivateEndpointConnections();
            await collection.GetAsync("privateEndpointConnectionName");
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: NameSpaceCreate

            var serviceBusNamespaceResourceId = ServiceBus.ServiceBusNamespaceResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "SDK-ServiceBus-4794", "sdk-Namespace-5828");
            var serviceBusNamespaceResource = GetArmClient().GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);
            var collection = serviceBusNamespaceResource.GetServiceBusPrivateEndpointConnections();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
