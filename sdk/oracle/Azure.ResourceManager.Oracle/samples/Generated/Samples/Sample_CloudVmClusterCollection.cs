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
using Azure.ResourceManager.Oracle;
using Azure.ResourceManager.Oracle.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Oracle.Samples
{
    public partial class Sample_CloudVmClusterCollection
    {
        // List VM Clusters by resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListVMClustersByResourceGroup()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/preview/2023-09-01-preview/examples/vmClusters_listByResourceGroup.json
            // this example is just showing the usage of "CloudVmClusters_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudVmClusterResource
            CloudVmClusterCollection collection = resourceGroupResource.GetCloudVmClusters();

            // invoke the operation and iterate over the result
            await foreach (CloudVmClusterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CloudVmClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get VM Cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVMCluster()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/preview/2023-09-01-preview/examples/vmClusters_get.json
            // this example is just showing the usage of "CloudVmClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudVmClusterResource
            CloudVmClusterCollection collection = resourceGroupResource.GetCloudVmClusters();

            // invoke the operation
            string cloudvmclustername = "cluster1";
            CloudVmClusterResource result = await collection.GetAsync(cloudvmclustername);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudVmClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get VM Cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetVMCluster()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/preview/2023-09-01-preview/examples/vmClusters_get.json
            // this example is just showing the usage of "CloudVmClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudVmClusterResource
            CloudVmClusterCollection collection = resourceGroupResource.GetCloudVmClusters();

            // invoke the operation
            string cloudvmclustername = "cluster1";
            bool result = await collection.ExistsAsync(cloudvmclustername);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get VM Cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetVMCluster()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/preview/2023-09-01-preview/examples/vmClusters_get.json
            // this example is just showing the usage of "CloudVmClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudVmClusterResource
            CloudVmClusterCollection collection = resourceGroupResource.GetCloudVmClusters();

            // invoke the operation
            string cloudvmclustername = "cluster1";
            NullableResponse<CloudVmClusterResource> response = await collection.GetIfExistsAsync(cloudvmclustername);
            CloudVmClusterResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CloudVmClusterData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create VM Cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateVMCluster()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/preview/2023-09-01-preview/examples/vmClusters_create.json
            // this example is just showing the usage of "CloudVmClusters_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudVmClusterResource
            CloudVmClusterCollection collection = resourceGroupResource.GetCloudVmClusters();

            // invoke the operation
            string cloudvmclustername = "cluster1";
            CloudVmClusterData data = new CloudVmClusterData(new AzureLocation("eastus"))
            {
                DataStorageSizeInTbs = 1000,
                DbNodeStorageSizeInGbs = 1000,
                MemorySizeInGbs = 1000,
                TimeZone = "UTC",
                Hostname = "hostname1",
                Domain = "domain1",
                CpuCoreCount = 2,
                OcpuCount = 3,
                ClusterName = "cluster1",
                DataStoragePercentage = 100,
                IsLocalBackupEnabled = false,
                CloudExadataInfrastructureId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg000/providers/Oracle.Database/cloudExadataInfrastructures/infra1"),
                IsSparseDiskgroupEnabled = false,
                SshPublicKeys =
{
"ssh-key 1"
},
                LicenseModel = LicenseModel.LicenseIncluded,
                ScanListenerPortTcp = 1050,
                ScanListenerPortTcpSsl = 1025,
                VnetId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg000/providers/Microsoft.Network/virtualNetworks/vnet1"),
                GiVersion = "19.0.0.0",
                SubnetId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg000/providers/Microsoft.Network/virtualNetworks/vnet1/subnets/subnet1"),
                DataCollectionOptions = new DataCollectionConfig()
                {
                    IsDiagnosticsEventsEnabled = false,
                    IsHealthMonitoringEnabled = false,
                    IsIncidentLogsEnabled = false,
                },
                DisplayName = "cluster 1",
                DbServers =
{
"ocid1..aaaa"
},
            };
            ArmOperation<CloudVmClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, cloudvmclustername, data);
            CloudVmClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudVmClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
