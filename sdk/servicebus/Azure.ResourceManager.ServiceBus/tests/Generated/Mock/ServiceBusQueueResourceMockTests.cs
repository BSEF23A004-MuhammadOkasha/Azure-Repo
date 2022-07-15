// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core.TestFramework;
using Azure.ResourceManager.ServiceBus;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.ServiceBus.Tests.Mock
{
    /// <summary> Test for ServiceBusQueueResource. </summary>
    public partial class ServiceBusQueueResourceMockTests : MockTestBase
    {
        public ServiceBusQueueResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: QueueDelete

            var serviceBusQueueResourceId = ServiceBus.ServiceBusQueueResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ArunMonocle", "sdk-Namespace-183", "sdk-Queues-8708");
            var serviceBusQueueResource = GetArmClient().GetServiceBusQueueResource(serviceBusQueueResourceId);
            await serviceBusQueueResource.DeleteAsync(WaitUntil.Completed);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: QueueGet

            var serviceBusQueueResourceId = ServiceBus.ServiceBusQueueResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ArunMonocle", "sdk-Namespace-3174", "sdk-Queues-5647");
            var serviceBusQueueResource = GetArmClient().GetServiceBusQueueResource(serviceBusQueueResourceId);
            await serviceBusQueueResource.GetAsync();
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: QueueCreate

            var serviceBusQueueResourceId = ServiceBus.ServiceBusQueueResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ArunMonocle", "sdk-Namespace-3174", "sdk-Queues-5647");
            var serviceBusQueueResource = GetArmClient().GetServiceBusQueueResource(serviceBusQueueResourceId);
            await serviceBusQueueResource.UpdateAsync(WaitUntil.Completed, new ServiceBusQueueData()
            {
                EnablePartitioning = true,
            });
        }
    }
}
