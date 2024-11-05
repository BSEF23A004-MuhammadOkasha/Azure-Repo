// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Elastic.Samples
{
    public partial class Sample_MonitoringTagRuleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_TagRulesCreateOrUpdate()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/preview/2024-06-15-preview/examples/TagRules_CreateOrUpdate.json
            // this example is just showing the usage of "TagRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitorResource = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // get the collection of this MonitoringTagRuleResource
            MonitoringTagRuleCollection collection = elasticMonitorResource.GetMonitoringTagRules();

            // invoke the operation
            string ruleSetName = "default";
            MonitoringTagRuleData data = new MonitoringTagRuleData();
            ArmOperation<MonitoringTagRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ruleSetName, data);
            MonitoringTagRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MonitoringTagRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_TagRulesGet()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/preview/2024-06-15-preview/examples/TagRules_Get.json
            // this example is just showing the usage of "TagRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitorResource = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // get the collection of this MonitoringTagRuleResource
            MonitoringTagRuleCollection collection = elasticMonitorResource.GetMonitoringTagRules();

            // invoke the operation
            string ruleSetName = "default";
            MonitoringTagRuleResource result = await collection.GetAsync(ruleSetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MonitoringTagRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_TagRulesList()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/preview/2024-06-15-preview/examples/TagRules_List.json
            // this example is just showing the usage of "TagRules_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitorResource = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // get the collection of this MonitoringTagRuleResource
            MonitoringTagRuleCollection collection = elasticMonitorResource.GetMonitoringTagRules();

            // invoke the operation and iterate over the result
            await foreach (MonitoringTagRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MonitoringTagRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_TagRulesGet()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/preview/2024-06-15-preview/examples/TagRules_Get.json
            // this example is just showing the usage of "TagRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitorResource = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // get the collection of this MonitoringTagRuleResource
            MonitoringTagRuleCollection collection = elasticMonitorResource.GetMonitoringTagRules();

            // invoke the operation
            string ruleSetName = "default";
            bool result = await collection.ExistsAsync(ruleSetName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_TagRulesGet()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/preview/2024-06-15-preview/examples/TagRules_Get.json
            // this example is just showing the usage of "TagRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitorResource = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // get the collection of this MonitoringTagRuleResource
            MonitoringTagRuleCollection collection = elasticMonitorResource.GetMonitoringTagRules();

            // invoke the operation
            string ruleSetName = "default";
            NullableResponse<MonitoringTagRuleResource> response = await collection.GetIfExistsAsync(ruleSetName);
            MonitoringTagRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MonitoringTagRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
