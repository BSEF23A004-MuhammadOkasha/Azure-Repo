// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Redis.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Redis.Samples
{
    public partial class Sample_RedisPrivateEndpointConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RedisCacheGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-03-01/examples/RedisCacheGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisPrivateEndpointConnectionResource created on azure
            // for more information of creating RedisPrivateEndpointConnectionResource, please refer to the document of RedisPrivateEndpointConnectionResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rgtest01";
            string cacheName = "cachetest01";
            string privateEndpointConnectionName = "pectest01";
            ResourceIdentifier redisPrivateEndpointConnectionResourceId = RedisPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName, privateEndpointConnectionName);
            RedisPrivateEndpointConnectionResource redisPrivateEndpointConnection = client.GetRedisPrivateEndpointConnectionResource(redisPrivateEndpointConnectionResourceId);

            // invoke the operation
            RedisPrivateEndpointConnectionResource result = await redisPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_RedisCachePutPrivateEndpointConnection()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-03-01/examples/RedisCachePutPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Put" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisPrivateEndpointConnectionResource created on azure
            // for more information of creating RedisPrivateEndpointConnectionResource, please refer to the document of RedisPrivateEndpointConnectionResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rgtest01";
            string cacheName = "cachetest01";
            string privateEndpointConnectionName = "pectest01";
            ResourceIdentifier redisPrivateEndpointConnectionResourceId = RedisPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName, privateEndpointConnectionName);
            RedisPrivateEndpointConnectionResource redisPrivateEndpointConnection = client.GetRedisPrivateEndpointConnectionResource(redisPrivateEndpointConnectionResourceId);

            // invoke the operation
            RedisPrivateEndpointConnectionData data = new RedisPrivateEndpointConnectionData()
            {
                RedisPrivateLinkServiceConnectionState = new RedisPrivateLinkServiceConnectionState()
                {
                    Status = RedisPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<RedisPrivateEndpointConnectionResource> lro = await redisPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            RedisPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_RedisCacheDeletePrivateEndpointConnection()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-03-01/examples/RedisCacheDeletePrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisPrivateEndpointConnectionResource created on azure
            // for more information of creating RedisPrivateEndpointConnectionResource, please refer to the document of RedisPrivateEndpointConnectionResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rgtest01";
            string cacheName = "cachetest01";
            string privateEndpointConnectionName = "pectest01";
            ResourceIdentifier redisPrivateEndpointConnectionResourceId = RedisPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName, privateEndpointConnectionName);
            RedisPrivateEndpointConnectionResource redisPrivateEndpointConnection = client.GetRedisPrivateEndpointConnectionResource(redisPrivateEndpointConnectionResourceId);

            // invoke the operation
            await redisPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
