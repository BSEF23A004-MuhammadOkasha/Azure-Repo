﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Core;
using Azure.ResourceManager.Maintenance.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Maintenance.Tests
{
    public sealed class MaintanenceConfigurationCancellationTests : MaintenanceManagementTestBase
    {
        private SubscriptionResource _subscription;
        private ResourceGroupResource _resourceGroup;
        private MaintenanceApplyUpdateCollection _configCollection;

        public MaintanenceConfigurationCancellationTests(bool isAsync) : base(isAsync) //, RecordedTestMode.Record)
        { }

        [SetUp]
        public async Task Setup()
        {
            _subscription = await Client.GetDefaultSubscriptionAsync();

            _resourceGroup = await CreateResourceGroup(
               _subscription,
               "Maintenance-RG-",
               new AzureLocation("centraluseuap"));

            _configCollection = _resourceGroup.GetMaintenanceApplyUpdates();
        }

        [TearDown]
        public async Task TearDown()
        {
            await _resourceGroup.DeleteAsync(WaitUntil.Completed);
        }

        [RecordedTest]
        public async Task MaintenanceConfigurationCancelTest()
        {
            string resourceName = Recording.GenerateAssetName("maintenance-config-");

            DateTime startOn = DateTime.UtcNow.AddMinutes(12);
            MaintenanceConfigurationResource config = await CreateMaintenanceConfiguration(resourceName, startOn);
            Assert.IsNotEmpty(config.Data.Id);

            MaintenanceApplyUpdateData data = new MaintenanceApplyUpdateData()
            {
                Status = MaintenanceUpdateStatus.Cancel,
            };
            string providerName = "Microsoft.Maintenance";
            string resourceType = "maintenanceConfigurations";
            string applyUpdateName = $"{startOn:yyyyMMddHHmm00}";

            // wait 2 minutes
            await Delay(2 * 60 * 1000);

            // cancel the maintenance
            ArmOperation<MaintenanceApplyUpdateResource> lro = await _configCollection.CreateOrUpdateAsync(WaitUntil.Completed, providerName, resourceType, resourceName, applyUpdateName, data);
            MaintenanceApplyUpdateResource result = lro.Value;

            Assert.IsTrue(result.HasData);
            Assert.AreEqual(result.Data.Status, MaintenanceUpdateStatus.Cancelled);
        }

        private async Task<MaintenanceConfigurationResource> CreateMaintenanceConfiguration(string resourceName, DateTime startOn)
        {
            MaintenanceConfigurationData data = new MaintenanceConfigurationData(new AzureLocation("centraluseuap"))
            {
                Namespace = "Microsoft.Maintenance",
                MaintenanceScope = MaintenanceScope.InGuestPatch,
                Visibility = MaintenanceConfigurationVisibility.Custom,
                StartOn = startOn,
                ExpireOn = DateTimeOffset.Parse("9999-12-31 00:00"),
                Duration = TimeSpan.Parse("03:00"),
                TimeZone = "UTC",
                RecurEvery = "Day",
                InstallPatches = new MaintenancePatchConfiguration(MaintenanceRebootOption.Always,
                    new MaintenanceWindowsPatchSettings(new List<string>(), new List<string>(), new List<string>() { "Security", "Critical" }, false),
                    new MaintenanceLinuxPatchSettings(new List<string>(), new List<string>(), new List<string>() { "Security", "Critical" }))
            };
            data.ExtensionProperties.Add("InGuestPatchMode", "User");

            ArmOperation<MaintenanceConfigurationResource> lro = await _resourceGroup.GetMaintenanceConfigurations().CreateOrUpdateAsync(WaitUntil.Completed, resourceName, data);

            return lro.Value;
        }
    }
}
