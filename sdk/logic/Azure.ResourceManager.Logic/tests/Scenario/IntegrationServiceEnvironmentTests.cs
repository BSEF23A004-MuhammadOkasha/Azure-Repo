﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Logic.Tests
{
    internal class IntegrationServiceEnvironmentTests : LogicManagementTestBase
    {
        private ResourceIdentifier _resourceGroupIdentifier;
        private ResourceGroupResource _resourceGroup;

        private IntegrationServiceEnvironmentCollection _integrationServiceEnvironmentCollection => _resourceGroup.GetIntegrationServiceEnvironments();

        public IntegrationServiceEnvironmentTests(bool isAsync) : base(isAsync)
        {
        }

        [OneTimeSetUp]
        public async Task GlobalSetup()
        {
            var rgLro = await (await GlobalClient.GetDefaultSubscriptionAsync()).GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Started, SessionRecording.GenerateAssetName(ResourceGroupNamePrefix), new ResourceGroupData(AzureLocation.CentralUS));
            _resourceGroupIdentifier = rgLro.Value.Id;
            await StopSessionRecordingAsync();
        }

        [SetUp]
        public async Task SetUp()
        {
            _resourceGroup = await Client.GetResourceGroupResource(_resourceGroupIdentifier).GetAsync();
        }

        [RecordedTest]
        public async Task IntegrationServiceEnvironment_E2E()
        {
            var _vnet = await CreateDefaultNetwork(_resourceGroup, "vnet5951");

            // Create - It will take 6 hours to create
            string serviceEnviromentName = "serviceEnviroment0000";
            IntegrationServiceEnvironmentData data = new IntegrationServiceEnvironmentData(AzureLocation.CentralUS)
            {
                Sku = new IntegrationServiceEnvironmentSku()
                {
                    Capacity = 0,
                    Name = IntegrationServiceEnvironmentSkuName.Developer
                },
                Properties = new IntegrationServiceEnvironmentProperties()
                {
                    NetworkConfiguration = new IntegrationServiceNetworkConfiguration(),
                }
            };
            data.Properties.NetworkConfiguration.Subnets.Add(new LogicResourceReference() { Id = _vnet.Data.Subnets[0].Id });
            data.Properties.NetworkConfiguration.Subnets.Add(new LogicResourceReference() { Id = _vnet.Data.Subnets[1].Id });
            data.Properties.NetworkConfiguration.Subnets.Add(new LogicResourceReference() { Id = _vnet.Data.Subnets[2].Id });
            data.Properties.NetworkConfiguration.Subnets.Add(new LogicResourceReference() { Id = _vnet.Data.Subnets[3].Id });
            var serviceEnviroment = await _integrationServiceEnvironmentCollection.CreateOrUpdateAsync(WaitUntil.Completed, serviceEnviromentName, data);
            Assert.IsNotNull(serviceEnviroment);
            Assert.AreEqual(serviceEnviromentName, serviceEnviroment.Value.Data.Name);

            // Exist
            bool flag = await _integrationServiceEnvironmentCollection.ExistsAsync(serviceEnviromentName);
            Assert.IsTrue(flag);

            // Get
            var getResponse = await _integrationServiceEnvironmentCollection.GetAsync(serviceEnviromentName);
            Assert.IsNotNull(getResponse);
            Assert.AreEqual(serviceEnviromentName, getResponse.Value.Data.Name);

            // GetAll
            var list = await _integrationServiceEnvironmentCollection.GetAllAsync().ToEnumerableAsync();
            Assert.IsNotEmpty(list);

            // Delete
            await serviceEnviroment.Value.DeleteAsync(WaitUntil.Completed);
            flag = await _integrationServiceEnvironmentCollection.ExistsAsync(serviceEnviromentName);
            Assert.IsFalse(flag);
        }
    }
}
