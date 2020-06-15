// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Management.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.EventHubs.Tests
{
    [RunFrequency(RunTestFrequency.Manually)]
    [NonParallelizable]
    public abstract class EventHubsManagementClientBase : ManagementRecordedTestBase<EventHubsManagementTestEnvironment>
    {
        private const string ApplicationIdKey = "ApplicationId";
        public static TimeSpan ZeroPollingInterval { get; } = TimeSpan.FromSeconds(0);
        public string TenantId { get; set; }
        public string ApplicationId { get; set; }
        public string Location { get; set; }
        public string SubscriptionId { get; set; }
        public ResourcesManagementClient ResourcesManagementClient { get; set; }
        public EventHubsManagementClient EventHubsManagementClient { get; set; }
        public Operations Operations { get; set; }
        public ResourcesOperations ResourcesOperations { get; set; }
        public ProvidersOperations ResourceProvidersOperations { get; set; }
        public EventHubsOperations EventHubsOperations { get; set; }
        public NamespacesOperations NamespacesOperations { get; set; }
        public ConsumerGroupsOperations ConsumerGroupsOperations { get; set; }
        public DisasterRecoveryConfigsOperations DisasterRecoveryConfigsOperations { get; set; }
        public ResourceGroupsOperations ResourceGroupsOperations { get; set; }
        protected EventHubsManagementClientBase(bool isAsync)
             : base(isAsync)
        {
        }

        protected void InitializeClients()
        {
            this.TenantId = TestEnvironment.TenantId;
            this.SubscriptionId = TestEnvironment.SubscriptionId;
            ResourcesManagementClient = GetResourceManagementClient();
            ResourcesOperations = ResourcesManagementClient.Resources;
            ResourceProvidersOperations = ResourcesManagementClient.Providers;
            ResourceGroupsOperations = ResourcesManagementClient.ResourceGroups;

            EventHubsManagementClient = GetEventHubManagementClient();
            EventHubsOperations = EventHubsManagementClient.EventHubs;
            NamespacesOperations = EventHubsManagementClient.Namespaces;
            ConsumerGroupsOperations = EventHubsManagementClient.ConsumerGroups;
            DisasterRecoveryConfigsOperations = EventHubsManagementClient.DisasterRecoveryConfigs;
            Operations = EventHubsManagementClient.Operations;
        }

        internal EventHubsManagementClient GetEventHubManagementClient()
        {
            return CreateClient<EventHubsManagementClient>(this.SubscriptionId,
                TestEnvironment.Credential,
                Recording.InstrumentClientOptions(new EventHubsManagementClientOptions()));
        }

        public async Task<string> GetLocation()
        {
            var provider = (await ResourceProvidersOperations.GetAsync("Microsoft.EventHub")).Value;
            this.Location = provider.ResourceTypes.Where(
                (resType) =>
                {
                    if (resType.ResourceType == "namespaces")
                        return true;
                    else
                        return false;
                }
                ).First().Locations.FirstOrDefault();
            return Location;
        }

        public void IsDelay(int t)
        {
            if (Mode == RecordedTestMode.Record)
            {
                Task.Delay(t * 1000);
            }
        }
    }
}
