// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.PostgreSql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.PostgreSql.Samples
{
    public partial class Sample_PostgreSqlServerAdministratorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ServerAdministratorGet()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/ServerAdminGet.json
            // this example is just showing the usage of "ServerAdministrators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerAdministratorResource created on azure
            // for more information of creating PostgreSqlServerAdministratorResource, please refer to the document of PostgreSqlServerAdministratorResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "pgtestsvc4";
            ResourceIdentifier postgreSqlServerAdministratorResourceId = PostgreSqlServerAdministratorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerAdministratorResource postgreSqlServerAdministrator = client.GetPostgreSqlServerAdministratorResource(postgreSqlServerAdministratorResourceId);

            // invoke the operation
            PostgreSqlServerAdministratorResource result = await postgreSqlServerAdministrator.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlServerAdministratorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ServerAdministratorCreate()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/ServerAdminCreateUpdate.json
            // this example is just showing the usage of "ServerAdministrators_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerAdministratorResource created on azure
            // for more information of creating PostgreSqlServerAdministratorResource, please refer to the document of PostgreSqlServerAdministratorResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "pgtestsvc4";
            ResourceIdentifier postgreSqlServerAdministratorResourceId = PostgreSqlServerAdministratorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerAdministratorResource postgreSqlServerAdministrator = client.GetPostgreSqlServerAdministratorResource(postgreSqlServerAdministratorResourceId);

            // invoke the operation
            PostgreSqlServerAdministratorData data = new PostgreSqlServerAdministratorData()
            {
                AdministratorType = PostgreSqlAdministratorType.ActiveDirectory,
                LoginAccountName = "bob@contoso.com",
                SecureId = Guid.Parse("c6b82b90-a647-49cb-8a62-0d2d3cb7ac7c"),
                TenantId = Guid.Parse("c6b82b90-a647-49cb-8a62-0d2d3cb7ac7c"),
            };
            ArmOperation<PostgreSqlServerAdministratorResource> lro = await postgreSqlServerAdministrator.CreateOrUpdateAsync(WaitUntil.Completed, data);
            PostgreSqlServerAdministratorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlServerAdministratorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ServerAdministratorsDelete()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/ServerAdminDelete.json
            // this example is just showing the usage of "ServerAdministrators_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerAdministratorResource created on azure
            // for more information of creating PostgreSqlServerAdministratorResource, please refer to the document of PostgreSqlServerAdministratorResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "pgtestsvc4";
            ResourceIdentifier postgreSqlServerAdministratorResourceId = PostgreSqlServerAdministratorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerAdministratorResource postgreSqlServerAdministrator = client.GetPostgreSqlServerAdministratorResource(postgreSqlServerAdministratorResourceId);

            // invoke the operation
            await postgreSqlServerAdministrator.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
