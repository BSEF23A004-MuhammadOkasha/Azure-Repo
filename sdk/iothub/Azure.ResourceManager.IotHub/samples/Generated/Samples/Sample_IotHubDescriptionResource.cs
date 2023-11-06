// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.IotHub;
using Azure.ResourceManager.IotHub.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.IotHub.Samples
{
    public partial class Sample_IotHubDescriptionResource
    {
        // IotHubResource_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_IotHubResourceGet()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_get.json
            // this example is just showing the usage of "IotHubResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation
            IotHubDescriptionResource result = await iotHubDescription.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotHubDescriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // IotHubResource_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_IotHubResourceUpdate()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_patch.json
            // this example is just showing the usage of "IotHubResource_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "myHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation
            IotHubDescriptionPatch patch = new IotHubDescriptionPatch()
            {
                Tags =
{
["foo"] = "bar",
},
            };
            ArmOperation<IotHubDescriptionResource> lro = await iotHubDescription.UpdateAsync(WaitUntil.Completed, patch);
            IotHubDescriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotHubDescriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // IotHubResource_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_IotHubResourceDelete()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_delete.json
            // this example is just showing the usage of "IotHubResource_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation
            ArmOperation<IotHubDescriptionResource> lro = await iotHubDescription.DeleteAsync(WaitUntil.Completed);
            IotHubDescriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotHubDescriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // IotHubResource_ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIotHubDescriptions_IotHubResourceListBySubscription()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_listbysubscription.json
            // this example is just showing the usage of "IotHubResource_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (IotHubDescriptionResource item in subscriptionResource.GetIotHubDescriptionsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IotHubDescriptionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // IotHubResource_GetStats
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetStats_IotHubResourceGetStats()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_stats.json
            // this example is just showing the usage of "IotHubResource_GetStats" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation
            IotHubRegistryStatistics result = await iotHubDescription.GetStatsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // IotHubResource_GetValidSkus
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetValidSkus_IotHubResourceGetValidSkus()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_getskus.json
            // this example is just showing the usage of "IotHubResource_GetValidSkus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (IotHubSkuDescription item in iotHubDescription.GetValidSkusAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // IotHubResource_ListJobs
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetJobs_IotHubResourceListJobs()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_listjobs.json
            // this example is just showing the usage of "IotHubResource_ListJobs" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (IotHubJobInfo item in iotHubDescription.GetJobsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // IotHubResource_GetJob
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetJob_IotHubResourceGetJob()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_getjob.json
            // this example is just showing the usage of "IotHubResource_GetJob" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation
            string jobId = "test";
            IotHubJobInfo result = await iotHubDescription.GetJobAsync(jobId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // IotHubResource_GetQuotaMetrics
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetQuotaMetrics_IotHubResourceGetQuotaMetrics()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_quotametrics.json
            // this example is just showing the usage of "IotHubResource_GetQuotaMetrics" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (IotHubQuotaMetricInfo item in iotHubDescription.GetQuotaMetricsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // IotHubResource_GetEndpointHealth
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEndpointHealth_IotHubResourceGetEndpointHealth()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_routingendpointhealth.json
            // this example is just showing the usage of "IotHubResource_GetEndpointHealth" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string iotHubName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, iotHubName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (IotHubEndpointHealthInfo item in iotHubDescription.GetEndpointHealthAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // IotHubResource_CheckNameAvailability
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckIotHubNameAvailability_IotHubResourceCheckNameAvailability()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/checkNameAvailability.json
            // this example is just showing the usage of "IotHubResource_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            IotHubNameAvailabilityContent content = new IotHubNameAvailabilityContent("test-request");
            IotHubNameAvailabilityResponse result = await subscriptionResource.CheckIotHubNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // IotHubResource_TestAllRoutes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task TestAllRoutes_IotHubResourceTestAllRoutes()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_testallroutes.json
            // this example is just showing the usage of "IotHubResource_TestAllRoutes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string iotHubName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, iotHubName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation
            IotHubTestAllRoutesContent content = new IotHubTestAllRoutesContent()
            {
                RoutingSource = IotHubRoutingSource.DeviceMessages,
                Message = new RoutingMessage()
                {
                    Body = "Body of message",
                    AppProperties =
{
["key1"] = "value1",
},
                    SystemProperties =
{
["key1"] = "value1",
},
                },
            };
            IotHubTestAllRoutesResult result = await iotHubDescription.TestAllRoutesAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // IotHubResource_TestRoute
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task TestRoute_IotHubResourceTestRoute()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_testnewroute.json
            // this example is just showing the usage of "IotHubResource_TestRoute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string iotHubName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, iotHubName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation
            IotHubTestRouteContent content = new IotHubTestRouteContent(new RoutingRuleProperties("Routeid", IotHubRoutingSource.DeviceMessages, new string[]
            {
"id1"
            }, true))
            {
                Message = new RoutingMessage()
                {
                    Body = "Body of message",
                    AppProperties =
{
["key1"] = "value1",
},
                    SystemProperties =
{
["key1"] = "value1",
},
                },
            };
            IotHubTestRouteResult result = await iotHubDescription.TestRouteAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // IotHubResource_ListKeys
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetKeys_IotHubResourceListKeys()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_listkeys.json
            // this example is just showing the usage of "IotHubResource_ListKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SharedAccessSignatureAuthorizationRule item in iotHubDescription.GetKeysAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // IotHubResource_GetKeysForKeyName
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetKeysForKeyName_IotHubResourceGetKeysForKeyName()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_getkey.json
            // this example is just showing the usage of "IotHubResource_GetKeysForKeyName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation
            string keyName = "iothubowner";
            SharedAccessSignatureAuthorizationRule result = await iotHubDescription.GetKeysForKeyNameAsync(keyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // IotHubResource_ExportDevices
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ExportDevices_IotHubResourceExportDevices()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_exportdevices.json
            // this example is just showing the usage of "IotHubResource_ExportDevices" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation
            ExportDevicesContent content = new ExportDevicesContent(new Uri("testBlob"), true);
            IotHubJobInfo result = await iotHubDescription.ExportDevicesAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // IotHubResource_ImportDevices
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ImportDevices_IotHubResourceImportDevices()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/iothub_importdevices.json
            // this example is just showing the usage of "IotHubResource_ImportDevices" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation
            IotHubImportDevicesContent content = new IotHubImportDevicesContent(new Uri("testBlob"), new Uri("testBlob"));
            IotHubJobInfo result = await iotHubDescription.ImportDevicesAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // IotHub_ManualFailover
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ManualFailoverIotHub_IotHubManualFailover()
        {
            // Generated from example definition: specification/iothub/resource-manager/Microsoft.Devices/stable/2023-06-30/examples/IotHub_ManualFailover.json
            // this example is just showing the usage of "IotHub_ManualFailover" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotHubDescriptionResource created on azure
            // for more information of creating IotHubDescriptionResource, please refer to the document of IotHubDescriptionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string iotHubName = "testHub";
            ResourceIdentifier iotHubDescriptionResourceId = IotHubDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, iotHubName);
            IotHubDescriptionResource iotHubDescription = client.GetIotHubDescriptionResource(iotHubDescriptionResourceId);

            // invoke the operation
            IotHubFailoverContent content = new IotHubFailoverContent("testHub");
            await iotHubDescription.ManualFailoverIotHubAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }
    }
}
