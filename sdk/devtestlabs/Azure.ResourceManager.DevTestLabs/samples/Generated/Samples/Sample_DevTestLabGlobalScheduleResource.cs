// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DevTestLabs.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DevTestLabs.Samples
{
    public partial class Sample_DevTestLabGlobalScheduleResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GlobalSchedulesGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/GlobalSchedules_Get.json
            // this example is just showing the usage of "GlobalSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabGlobalScheduleResource created on azure
            // for more information of creating DevTestLabGlobalScheduleResource, please refer to the document of DevTestLabGlobalScheduleResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string name = "labvmautostart";
            ResourceIdentifier devTestLabGlobalScheduleResourceId = DevTestLabGlobalScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            DevTestLabGlobalScheduleResource devTestLabGlobalSchedule = client.GetDevTestLabGlobalScheduleResource(devTestLabGlobalScheduleResourceId);

            // invoke the operation
            DevTestLabGlobalScheduleResource result = await devTestLabGlobalSchedule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_GlobalSchedulesDelete()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/GlobalSchedules_Delete.json
            // this example is just showing the usage of "GlobalSchedules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabGlobalScheduleResource created on azure
            // for more information of creating DevTestLabGlobalScheduleResource, please refer to the document of DevTestLabGlobalScheduleResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string name = "labvmautostart";
            ResourceIdentifier devTestLabGlobalScheduleResourceId = DevTestLabGlobalScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            DevTestLabGlobalScheduleResource devTestLabGlobalSchedule = client.GetDevTestLabGlobalScheduleResource(devTestLabGlobalScheduleResourceId);

            // invoke the operation
            await devTestLabGlobalSchedule.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_GlobalSchedulesUpdate()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/GlobalSchedules_Update.json
            // this example is just showing the usage of "GlobalSchedules_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabGlobalScheduleResource created on azure
            // for more information of creating DevTestLabGlobalScheduleResource, please refer to the document of DevTestLabGlobalScheduleResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string name = "labvmautostart";
            ResourceIdentifier devTestLabGlobalScheduleResourceId = DevTestLabGlobalScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            DevTestLabGlobalScheduleResource devTestLabGlobalSchedule = client.GetDevTestLabGlobalScheduleResource(devTestLabGlobalScheduleResourceId);

            // invoke the operation
            DevTestLabSchedulePatch patch = new DevTestLabSchedulePatch
            {
                Tags =
{
["tagName1"] = "tagValue1"
},
            };
            DevTestLabGlobalScheduleResource result = await devTestLabGlobalSchedule.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Execute_GlobalSchedulesExecute()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/GlobalSchedules_Execute.json
            // this example is just showing the usage of "GlobalSchedules_Execute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabGlobalScheduleResource created on azure
            // for more information of creating DevTestLabGlobalScheduleResource, please refer to the document of DevTestLabGlobalScheduleResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string name = "labvmautostart";
            ResourceIdentifier devTestLabGlobalScheduleResourceId = DevTestLabGlobalScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            DevTestLabGlobalScheduleResource devTestLabGlobalSchedule = client.GetDevTestLabGlobalScheduleResource(devTestLabGlobalScheduleResourceId);

            // invoke the operation
            await devTestLabGlobalSchedule.ExecuteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Retarget_GlobalSchedulesRetarget()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/GlobalSchedules_Retarget.json
            // this example is just showing the usage of "GlobalSchedules_Retarget" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabGlobalScheduleResource created on azure
            // for more information of creating DevTestLabGlobalScheduleResource, please refer to the document of DevTestLabGlobalScheduleResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string name = "{scheduleName}";
            ResourceIdentifier devTestLabGlobalScheduleResourceId = DevTestLabGlobalScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            DevTestLabGlobalScheduleResource devTestLabGlobalSchedule = client.GetDevTestLabGlobalScheduleResource(devTestLabGlobalScheduleResourceId);

            // invoke the operation
            DevTestLabGlobalScheduleRetargetContent content = new DevTestLabGlobalScheduleRetargetContent
            {
                CurrentResourceId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourcegroups/resourceGroupName/providers/microsoft.devtestlab/labs/{targetLab}"),
                TargetResourceId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourcegroups/resourceGroupName/providers/microsoft.devtestlab/labs/{currentLab}"),
            };
            await devTestLabGlobalSchedule.RetargetAsync(WaitUntil.Completed, content).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }
    }
}
