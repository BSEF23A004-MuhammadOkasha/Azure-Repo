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
using Azure.ResourceManager.RecoveryServicesBackup;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup.Samples
{
    public partial class Sample_BackupPrivateEndpointConnectionResource
    {
        // Get PrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/PrivateEndpointConnection/GetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupPrivateEndpointConnectionResource created on azure
            // for more information of creating BackupPrivateEndpointConnectionResource, please refer to the document of BackupPrivateEndpointConnectionResource
            string subscriptionId = "04cf684a-d41f-4550-9f70-7708a3a2283b";
            string resourceGroupName = "gaallaRG";
            string vaultName = "gaallavaultbvtd2msi";
            string privateEndpointConnectionName = "gaallatestpe2.5704c932-249a-490b-a142-1396838cd3b";
            ResourceIdentifier backupPrivateEndpointConnectionResourceId = BackupPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, privateEndpointConnectionName);
            BackupPrivateEndpointConnectionResource backupPrivateEndpointConnection = client.GetBackupPrivateEndpointConnectionResource(backupPrivateEndpointConnectionResourceId);

            // invoke the operation
            BackupPrivateEndpointConnectionResource result = await backupPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update PrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdatePrivateEndpointConnection()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/PrivateEndpointConnection/PutPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_Put" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupPrivateEndpointConnectionResource created on azure
            // for more information of creating BackupPrivateEndpointConnectionResource, please refer to the document of BackupPrivateEndpointConnectionResource
            string subscriptionId = "04cf684a-d41f-4550-9f70-7708a3a2283b";
            string resourceGroupName = "gaallaRG";
            string vaultName = "gaallavaultbvtd2msi";
            string privateEndpointConnectionName = "gaallatestpe2.5704c932-249a-490b-a142-1396838cd3b";
            ResourceIdentifier backupPrivateEndpointConnectionResourceId = BackupPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, privateEndpointConnectionName);
            BackupPrivateEndpointConnectionResource backupPrivateEndpointConnection = client.GetBackupPrivateEndpointConnectionResource(backupPrivateEndpointConnectionResourceId);

            // invoke the operation
            BackupPrivateEndpointConnectionData data = new BackupPrivateEndpointConnectionData(new AzureLocation("placeholder"))
            {
                Properties = new BackupPrivateEndpointConnectionProperties()
                {
                    ProvisioningState = BackupPrivateEndpointConnectionProvisioningState.Succeeded,
                    PrivateEndpointId = new ResourceIdentifier("/subscriptions/04cf684a-d41f-4550-9f70-7708a3a2283b/resourceGroups/gaallaRG/providers/Microsoft.Network/privateEndpoints/gaallatestpe3"),
                    GroupIds =
{
VaultSubResourceType.AzureBackupSecondary
},
                    PrivateLinkServiceConnectionState = new RecoveryServicesBackupPrivateLinkServiceConnectionState()
                    {
                        Status = PrivateEndpointConnectionStatus.Approved,
                        Description = "Approved by johndoe@company.com",
                    },
                },
            };
            ArmOperation<BackupPrivateEndpointConnectionResource> lro = await backupPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            BackupPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete PrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletePrivateEndpointConnection()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/PrivateEndpointConnection/DeletePrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupPrivateEndpointConnectionResource created on azure
            // for more information of creating BackupPrivateEndpointConnectionResource, please refer to the document of BackupPrivateEndpointConnectionResource
            string subscriptionId = "04cf684a-d41f-4550-9f70-7708a3a2283b";
            string resourceGroupName = "gaallaRG";
            string vaultName = "gaallavaultbvtd2msi";
            string privateEndpointConnectionName = "gaallatestpe2.5704c932-249a-490b-a142-1396838cd3b";
            ResourceIdentifier backupPrivateEndpointConnectionResourceId = BackupPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, privateEndpointConnectionName);
            BackupPrivateEndpointConnectionResource backupPrivateEndpointConnection = client.GetBackupPrivateEndpointConnectionResource(backupPrivateEndpointConnectionResourceId);

            // invoke the operation
            await backupPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
