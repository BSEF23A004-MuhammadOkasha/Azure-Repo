// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.StreamAnalytics.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.StreamAnalytics.Samples
{
    public partial class Sample_StreamingJobFunctionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAJavaScriptFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Update_JavaScript.json
            // this example is just showing the usage of "Functions_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobFunctionResource created on azure
            // for more information of creating StreamingJobFunctionResource, please refer to the document of StreamingJobFunctionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg1637";
            string jobName = "sj8653";
            string functionName = "function8197";
            ResourceIdentifier streamingJobFunctionResourceId = StreamingJobFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName, functionName);
            StreamingJobFunctionResource streamingJobFunction = client.GetStreamingJobFunctionResource(streamingJobFunctionResourceId);

            // invoke the operation
            StreamingJobFunctionData data = new StreamingJobFunctionData()
            {
                Properties = new ScalarFunctionProperties()
                {
                    Binding = new JavaScriptFunctionBinding()
                    {
                        Script = "function (a, b) { return a * b; }",
                    },
                },
            };
            StreamingJobFunctionResource result = await streamingJobFunction.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAnAzureMLFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Update_AzureML.json
            // this example is just showing the usage of "Functions_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobFunctionResource created on azure
            // for more information of creating StreamingJobFunctionResource, please refer to the document of StreamingJobFunctionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg7";
            string jobName = "sj9093";
            string functionName = "function588";
            ResourceIdentifier streamingJobFunctionResourceId = StreamingJobFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName, functionName);
            StreamingJobFunctionResource streamingJobFunction = client.GetStreamingJobFunctionResource(streamingJobFunctionResourceId);

            // invoke the operation
            StreamingJobFunctionData data = new StreamingJobFunctionData()
            {
                Properties = new ScalarFunctionProperties()
                {
                    Binding = new EMachineLearningStudioFunctionBinding()
                    {
                        BatchSize = 5000,
                    },
                },
            };
            StreamingJobFunctionResource result = await streamingJobFunction.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Delete.json
            // this example is just showing the usage of "Functions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobFunctionResource created on azure
            // for more information of creating StreamingJobFunctionResource, please refer to the document of StreamingJobFunctionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg1637";
            string jobName = "sj8653";
            string functionName = "function8197";
            ResourceIdentifier streamingJobFunctionResourceId = StreamingJobFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName, functionName);
            StreamingJobFunctionResource streamingJobFunction = client.GetStreamingJobFunctionResource(streamingJobFunctionResourceId);

            // invoke the operation
            await streamingJobFunction.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAJavaScriptFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Get_JavaScript.json
            // this example is just showing the usage of "Functions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobFunctionResource created on azure
            // for more information of creating StreamingJobFunctionResource, please refer to the document of StreamingJobFunctionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg1637";
            string jobName = "sj8653";
            string functionName = "function8197";
            ResourceIdentifier streamingJobFunctionResourceId = StreamingJobFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName, functionName);
            StreamingJobFunctionResource streamingJobFunction = client.GetStreamingJobFunctionResource(streamingJobFunctionResourceId);

            // invoke the operation
            StreamingJobFunctionResource result = await streamingJobFunction.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnAzureMLFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Get_AzureML.json
            // this example is just showing the usage of "Functions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobFunctionResource created on azure
            // for more information of creating StreamingJobFunctionResource, please refer to the document of StreamingJobFunctionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg7";
            string jobName = "sj9093";
            string functionName = "function588";
            ResourceIdentifier streamingJobFunctionResourceId = StreamingJobFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName, functionName);
            StreamingJobFunctionResource streamingJobFunction = client.GetStreamingJobFunctionResource(streamingJobFunctionResourceId);

            // invoke the operation
            StreamingJobFunctionResource result = await streamingJobFunction.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Test_TestTheConnectionForAJavaScriptFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Test_JavaScript.json
            // this example is just showing the usage of "Functions_Test" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobFunctionResource created on azure
            // for more information of creating StreamingJobFunctionResource, please refer to the document of StreamingJobFunctionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg1637";
            string jobName = "sj8653";
            string functionName = "function8197";
            ResourceIdentifier streamingJobFunctionResourceId = StreamingJobFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName, functionName);
            StreamingJobFunctionResource streamingJobFunction = client.GetStreamingJobFunctionResource(streamingJobFunctionResourceId);

            // invoke the operation
            ArmOperation<StreamAnalyticsResourceTestStatus> lro = await streamingJobFunction.TestAsync(WaitUntil.Completed);
            StreamAnalyticsResourceTestStatus result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Test_TestTheConnectionForAnAzureMLFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_Test_AzureML.json
            // this example is just showing the usage of "Functions_Test" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobFunctionResource created on azure
            // for more information of creating StreamingJobFunctionResource, please refer to the document of StreamingJobFunctionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg7";
            string jobName = "sj9093";
            string functionName = "function588";
            ResourceIdentifier streamingJobFunctionResourceId = StreamingJobFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName, functionName);
            StreamingJobFunctionResource streamingJobFunction = client.GetStreamingJobFunctionResource(streamingJobFunctionResourceId);

            // invoke the operation
            ArmOperation<StreamAnalyticsResourceTestStatus> lro = await streamingJobFunction.TestAsync(WaitUntil.Completed);
            StreamAnalyticsResourceTestStatus result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RetrieveDefaultDefinition_RetrieveTheDefaultDefinitionForAnAzureMLFunction()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/Function_RetrieveDefaultDefinition_AzureML.json
            // this example is just showing the usage of "Functions_RetrieveDefaultDefinition" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobFunctionResource created on azure
            // for more information of creating StreamingJobFunctionResource, please refer to the document of StreamingJobFunctionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg7";
            string jobName = "sj9093";
            string functionName = "function588";
            ResourceIdentifier streamingJobFunctionResourceId = StreamingJobFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName, functionName);
            StreamingJobFunctionResource streamingJobFunction = client.GetStreamingJobFunctionResource(streamingJobFunctionResourceId);

            // invoke the operation
            FunctionRetrieveDefaultDefinitionContent content = new MachineLearningStudioFunctionRetrieveDefaultDefinitionContent()
            {
                ExecuteEndpoint = "someAzureMLExecuteEndpointUrl",
                UdfType = StreamingJobFunctionUdfType.Scalar,
            };
            StreamingJobFunctionResource result = await streamingJobFunction.RetrieveDefaultDefinitionAsync(content: content);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
