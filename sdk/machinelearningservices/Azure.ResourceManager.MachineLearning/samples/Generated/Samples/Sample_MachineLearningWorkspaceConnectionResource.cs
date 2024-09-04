// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningWorkspaceConnectionResource
    {
        // DeleteWorkspaceConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteWorkspaceConnection()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/WorkspaceConnection/delete.json
            // this example is just showing the usage of "WorkspaceConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceConnectionResource created on azure
            // for more information of creating MachineLearningWorkspaceConnectionResource, please refer to the document of MachineLearningWorkspaceConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup-1";
            string workspaceName = "workspace-1";
            string connectionName = "connection-1";
            ResourceIdentifier machineLearningWorkspaceConnectionResourceId = MachineLearningWorkspaceConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, connectionName);
            MachineLearningWorkspaceConnectionResource machineLearningWorkspaceConnection = client.GetMachineLearningWorkspaceConnectionResource(machineLearningWorkspaceConnectionResourceId);

            // invoke the operation
            await machineLearningWorkspaceConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // GetWorkspaceConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspaceConnection()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/WorkspaceConnection/get.json
            // this example is just showing the usage of "WorkspaceConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceConnectionResource created on azure
            // for more information of creating MachineLearningWorkspaceConnectionResource, please refer to the document of MachineLearningWorkspaceConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup-1";
            string workspaceName = "workspace-1";
            string connectionName = "connection-1";
            ResourceIdentifier machineLearningWorkspaceConnectionResourceId = MachineLearningWorkspaceConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, connectionName);
            MachineLearningWorkspaceConnectionResource machineLearningWorkspaceConnection = client.GetMachineLearningWorkspaceConnectionResource(machineLearningWorkspaceConnectionResourceId);

            // invoke the operation
            MachineLearningWorkspaceConnectionResource result = await machineLearningWorkspaceConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningWorkspaceConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // UpdateWorkspaceConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateWorkspaceConnection()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/WorkspaceConnection/update.json
            // this example is just showing the usage of "WorkspaceConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceConnectionResource created on azure
            // for more information of creating MachineLearningWorkspaceConnectionResource, please refer to the document of MachineLearningWorkspaceConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "workspace-1";
            string connectionName = "connection-1";
            ResourceIdentifier machineLearningWorkspaceConnectionResourceId = MachineLearningWorkspaceConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, connectionName);
            MachineLearningWorkspaceConnectionResource machineLearningWorkspaceConnection = client.GetMachineLearningWorkspaceConnectionResource(machineLearningWorkspaceConnectionResourceId);

            // invoke the operation
            MachineLearningWorkspaceConnectionPatch patch = new MachineLearningWorkspaceConnectionPatch()
            {
                Properties = new AccessKeyAuthTypeWorkspaceConnectionProperties()
                {
                    Credentials = new WorkspaceConnectionAccessKey()
                    {
                        AccessKeyId = "some_string",
                        SecretAccessKey = "some_string",
                    },
                    Category = MachineLearningConnectionCategory.AdlsGen2,
                    ExpiryOn = DateTimeOffset.Parse("2020-01-01T00:00:00Z"),
                    Metadata =
{
},
                    Target = "some_string",
                },
            };
            MachineLearningWorkspaceConnectionResource result = await machineLearningWorkspaceConnection.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningWorkspaceConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetWorkspaceConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSecrets_GetWorkspaceConnection()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/WorkspaceConnection/listSecrets.json
            // this example is just showing the usage of "WorkspaceConnections_ListSecrets" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceConnectionResource created on azure
            // for more information of creating MachineLearningWorkspaceConnectionResource, please refer to the document of MachineLearningWorkspaceConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "workspace-1";
            string connectionName = "connection-1";
            ResourceIdentifier machineLearningWorkspaceConnectionResourceId = MachineLearningWorkspaceConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, connectionName);
            MachineLearningWorkspaceConnectionResource machineLearningWorkspaceConnection = client.GetMachineLearningWorkspaceConnectionResource(machineLearningWorkspaceConnectionResourceId);

            // invoke the operation
            MachineLearningWorkspaceConnectionResource result = await machineLearningWorkspaceConnection.GetSecretsAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningWorkspaceConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TestWorkspaceConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task TestConnection_TestWorkspaceConnection()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/WorkspaceConnection/testConnection.json
            // this example is just showing the usage of "WorkspaceConnections_TestConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceConnectionResource created on azure
            // for more information of creating MachineLearningWorkspaceConnectionResource, please refer to the document of MachineLearningWorkspaceConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup-1";
            string workspaceName = "workspace-1";
            string connectionName = "connection-1";
            ResourceIdentifier machineLearningWorkspaceConnectionResourceId = MachineLearningWorkspaceConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, connectionName);
            MachineLearningWorkspaceConnectionResource machineLearningWorkspaceConnection = client.GetMachineLearningWorkspaceConnectionResource(machineLearningWorkspaceConnectionResourceId);

            // invoke the operation
            MachineLearningWorkspaceConnectionData data = new MachineLearningWorkspaceConnectionData(new MachineLearningNoneAuthTypeWorkspaceConnection()
            {
                Category = MachineLearningConnectionCategory.ContainerRegistry,
                ExpiryOn = DateTimeOffset.Parse("2024-03-15T14:30:00Z"),
                Target = "target_url",
            });
            await machineLearningWorkspaceConnection.TestConnectionAsync(WaitUntil.Completed, data: data);

            Console.WriteLine($"Succeeded");
        }

        // Get Azure OpenAI Connection Models
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetModelsConnections_GetAzureOpenAIConnectionModels()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/WorkspaceConnection/getModels.json
            // this example is just showing the usage of "Connection_GetModels" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceConnectionResource created on azure
            // for more information of creating MachineLearningWorkspaceConnectionResource, please refer to the document of MachineLearningWorkspaceConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "aml-workspace-name";
            string connectionName = "testConnection";
            ResourceIdentifier machineLearningWorkspaceConnectionResourceId = MachineLearningWorkspaceConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, connectionName);
            MachineLearningWorkspaceConnectionResource machineLearningWorkspaceConnection = client.GetMachineLearningWorkspaceConnectionResource(machineLearningWorkspaceConnectionResourceId);

            // invoke the operation and iterate over the result
            await foreach (EndpointModelProperties item in machineLearningWorkspaceConnection.GetModelsConnectionsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
