// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseSqlPoolTableCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListTheTablesOfAGivenSchemaInASQLAnalyticsPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/ListSqlPoolTables.json
            // this example is just showing the usage of "SqlPoolTables_ListBySchema" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolSchemaResource created on azure
            // for more information of creating SynapseSqlPoolSchemaResource, please refer to the document of SynapseSqlPoolSchemaResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myRG";
            string workspaceName = "serverName";
            string sqlPoolName = "myDatabase";
            string schemaName = "dbo";
            ResourceIdentifier synapseSqlPoolSchemaResourceId = SynapseSqlPoolSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, schemaName);
            SynapseSqlPoolSchemaResource synapseSqlPoolSchema = client.GetSynapseSqlPoolSchemaResource(synapseSqlPoolSchemaResourceId);

            // get the collection of this SynapseSqlPoolTableResource
            SynapseSqlPoolTableCollection collection = synapseSqlPoolSchema.GetSynapseSqlPoolTables();

            // invoke the operation and iterate over the result
            await foreach (SynapseSqlPoolTableResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseSqlPoolTableData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDatabaseTable()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/SqlPoolTableGet.json
            // this example is just showing the usage of "SqlPoolTables_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolSchemaResource created on azure
            // for more information of creating SynapseSqlPoolSchemaResource, please refer to the document of SynapseSqlPoolSchemaResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myRG";
            string workspaceName = "serverName";
            string sqlPoolName = "myDatabase";
            string schemaName = "dbo";
            ResourceIdentifier synapseSqlPoolSchemaResourceId = SynapseSqlPoolSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, schemaName);
            SynapseSqlPoolSchemaResource synapseSqlPoolSchema = client.GetSynapseSqlPoolSchemaResource(synapseSqlPoolSchemaResourceId);

            // get the collection of this SynapseSqlPoolTableResource
            SynapseSqlPoolTableCollection collection = synapseSqlPoolSchema.GetSynapseSqlPoolTables();

            // invoke the operation
            string tableName = "table1";
            SynapseSqlPoolTableResource result = await collection.GetAsync(tableName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseSqlPoolTableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetDatabaseTable()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/SqlPoolTableGet.json
            // this example is just showing the usage of "SqlPoolTables_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolSchemaResource created on azure
            // for more information of creating SynapseSqlPoolSchemaResource, please refer to the document of SynapseSqlPoolSchemaResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myRG";
            string workspaceName = "serverName";
            string sqlPoolName = "myDatabase";
            string schemaName = "dbo";
            ResourceIdentifier synapseSqlPoolSchemaResourceId = SynapseSqlPoolSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, schemaName);
            SynapseSqlPoolSchemaResource synapseSqlPoolSchema = client.GetSynapseSqlPoolSchemaResource(synapseSqlPoolSchemaResourceId);

            // get the collection of this SynapseSqlPoolTableResource
            SynapseSqlPoolTableCollection collection = synapseSqlPoolSchema.GetSynapseSqlPoolTables();

            // invoke the operation
            string tableName = "table1";
            bool result = await collection.ExistsAsync(tableName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetDatabaseTable()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/SqlPoolTableGet.json
            // this example is just showing the usage of "SqlPoolTables_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolSchemaResource created on azure
            // for more information of creating SynapseSqlPoolSchemaResource, please refer to the document of SynapseSqlPoolSchemaResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myRG";
            string workspaceName = "serverName";
            string sqlPoolName = "myDatabase";
            string schemaName = "dbo";
            ResourceIdentifier synapseSqlPoolSchemaResourceId = SynapseSqlPoolSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, schemaName);
            SynapseSqlPoolSchemaResource synapseSqlPoolSchema = client.GetSynapseSqlPoolSchemaResource(synapseSqlPoolSchemaResourceId);

            // get the collection of this SynapseSqlPoolTableResource
            SynapseSqlPoolTableCollection collection = synapseSqlPoolSchema.GetSynapseSqlPoolTables();

            // invoke the operation
            string tableName = "table1";
            NullableResponse<SynapseSqlPoolTableResource> response = await collection.GetIfExistsAsync(tableName);
            SynapseSqlPoolTableResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseSqlPoolTableData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
