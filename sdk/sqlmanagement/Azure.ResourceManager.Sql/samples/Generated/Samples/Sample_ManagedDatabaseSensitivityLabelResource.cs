// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_ManagedDatabaseSensitivityLabelResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsTheSensitivityLabelOfAGivenColumnInAManagedDatabase()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedDatabaseColumnSensitivityLabelGet.json
            // this example is just showing the usage of "ManagedDatabaseSensitivityLabels_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDatabaseSensitivityLabelResource created on azure
            // for more information of creating ManagedDatabaseSensitivityLabelResource, please refer to the document of ManagedDatabaseSensitivityLabelResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myRG";
            string managedInstanceName = "myManagedInstanceName";
            string databaseName = "myDatabase";
            string schemaName = "dbo";
            string tableName = "myTable";
            string columnName = "myColumn";
            SensitivityLabelSource sensitivityLabelSource = SensitivityLabelSource.Current;
            ResourceIdentifier managedDatabaseSensitivityLabelResourceId = ManagedDatabaseSensitivityLabelResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName, sensitivityLabelSource);
            ManagedDatabaseSensitivityLabelResource managedDatabaseSensitivityLabel = client.GetManagedDatabaseSensitivityLabelResource(managedDatabaseSensitivityLabelResourceId);

            // invoke the operation
            ManagedDatabaseSensitivityLabelResource result = await managedDatabaseSensitivityLabel.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SensitivityLabelData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
