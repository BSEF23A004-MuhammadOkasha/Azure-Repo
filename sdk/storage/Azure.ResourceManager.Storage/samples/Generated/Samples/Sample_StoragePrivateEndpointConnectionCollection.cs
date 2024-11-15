// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Storage.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Storage.Samples
{
    public partial class Sample_StoragePrivateEndpointConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_StorageAccountListPrivateEndpointConnections()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/StorageAccountListPrivateEndpointConnections.json
            // this example is just showing the usage of "PrivateEndpointConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountResource created on azure
            // for more information of creating StorageAccountResource, please refer to the document of StorageAccountResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            ResourceIdentifier storageAccountResourceId = StorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            StorageAccountResource storageAccount = client.GetStorageAccountResource(storageAccountResourceId);

            // get the collection of this StoragePrivateEndpointConnectionResource
            StoragePrivateEndpointConnectionCollection collection = storageAccount.GetStoragePrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (StoragePrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StoragePrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_StorageAccountGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/StorageAccountGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountResource created on azure
            // for more information of creating StorageAccountResource, please refer to the document of StorageAccountResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            ResourceIdentifier storageAccountResourceId = StorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            StorageAccountResource storageAccount = client.GetStorageAccountResource(storageAccountResourceId);

            // get the collection of this StoragePrivateEndpointConnectionResource
            StoragePrivateEndpointConnectionCollection collection = storageAccount.GetStoragePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            StoragePrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StoragePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_StorageAccountGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/StorageAccountGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountResource created on azure
            // for more information of creating StorageAccountResource, please refer to the document of StorageAccountResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            ResourceIdentifier storageAccountResourceId = StorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            StorageAccountResource storageAccount = client.GetStorageAccountResource(storageAccountResourceId);

            // get the collection of this StoragePrivateEndpointConnectionResource
            StoragePrivateEndpointConnectionCollection collection = storageAccount.GetStoragePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_StorageAccountGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/StorageAccountGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountResource created on azure
            // for more information of creating StorageAccountResource, please refer to the document of StorageAccountResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            ResourceIdentifier storageAccountResourceId = StorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            StorageAccountResource storageAccount = client.GetStorageAccountResource(storageAccountResourceId);

            // get the collection of this StoragePrivateEndpointConnectionResource
            StoragePrivateEndpointConnectionCollection collection = storageAccount.GetStoragePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            NullableResponse<StoragePrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            StoragePrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StoragePrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_StorageAccountPutPrivateEndpointConnection()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/StorageAccountPutPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Put" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountResource created on azure
            // for more information of creating StorageAccountResource, please refer to the document of StorageAccountResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "sto9699";
            ResourceIdentifier storageAccountResourceId = StorageAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            StorageAccountResource storageAccount = client.GetStorageAccountResource(storageAccountResourceId);

            // get the collection of this StoragePrivateEndpointConnectionResource
            StoragePrivateEndpointConnectionCollection collection = storageAccount.GetStoragePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            StoragePrivateEndpointConnectionData data = new StoragePrivateEndpointConnectionData()
            {
                ConnectionState = new StoragePrivateLinkServiceConnectionState()
                {
                    Status = StoragePrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<StoragePrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            StoragePrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StoragePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
