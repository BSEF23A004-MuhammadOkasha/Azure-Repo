// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataBoxEdge.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DataBoxEdge.Samples
{
    public partial class Sample_DataBoxEdgeStorageAccountCredentialResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SACGet()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/SACGet.json
            // this example is just showing the usage of "StorageAccountCredentials_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeStorageAccountCredentialResource created on azure
            // for more information of creating DataBoxEdgeStorageAccountCredentialResource, please refer to the document of DataBoxEdgeStorageAccountCredentialResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string name = "sac1";
            ResourceIdentifier dataBoxEdgeStorageAccountCredentialResourceId = DataBoxEdgeStorageAccountCredentialResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, name);
            DataBoxEdgeStorageAccountCredentialResource dataBoxEdgeStorageAccountCredential = client.GetDataBoxEdgeStorageAccountCredentialResource(dataBoxEdgeStorageAccountCredentialResourceId);

            // invoke the operation
            DataBoxEdgeStorageAccountCredentialResource result = await dataBoxEdgeStorageAccountCredential.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataBoxEdgeStorageAccountCredentialData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SACPut()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/SACPut.json
            // this example is just showing the usage of "StorageAccountCredentials_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeStorageAccountCredentialResource created on azure
            // for more information of creating DataBoxEdgeStorageAccountCredentialResource, please refer to the document of DataBoxEdgeStorageAccountCredentialResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string name = "sac1";
            ResourceIdentifier dataBoxEdgeStorageAccountCredentialResourceId = DataBoxEdgeStorageAccountCredentialResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, name);
            DataBoxEdgeStorageAccountCredentialResource dataBoxEdgeStorageAccountCredential = client.GetDataBoxEdgeStorageAccountCredentialResource(dataBoxEdgeStorageAccountCredentialResourceId);

            // invoke the operation
            DataBoxEdgeStorageAccountCredentialData data = new DataBoxEdgeStorageAccountCredentialData("sac1", DataBoxEdgeStorageAccountSslStatus.Disabled, DataBoxEdgeStorageAccountType.BlobStorage)
            {
                UserName = "cisbvt",
                AccountKey = new AsymmetricEncryptedSecret("lAeZEYi6rNP1/EyNaVUYmTSZEYyaIaWmwUsGwek0+xiZj54GM9Ue9/UA2ed/ClC03wuSit2XzM/cLRU5eYiFBwks23rGwiQOr3sruEL2a74EjPD050xYjA6M1I2hu/w2yjVHhn5j+DbXS4Xzi+rHHNZK3DgfDO3PkbECjPck+PbpSBjy9+6Mrjcld5DIZhUAeMlMHrFlg+WKRKB14o/og56u5/xX6WKlrMLEQ+y6E18dUwvWs2elTNoVO8PBE8SM/CfooX4AMNvaNdSObNBPdP+F6Lzc556nFNWXrBLRt0vC7s9qTiVRO4x/qCNaK/B4y7IqXMllwQFf4Np9UQ2ECA==", DataBoxEdgeEncryptionAlgorithm.Aes256)
                {
                    EncryptionCertThumbprint = "2A9D8D6BE51574B5461230AEF02F162C5F01AD31",
                },
            };
            ArmOperation<DataBoxEdgeStorageAccountCredentialResource> lro = await dataBoxEdgeStorageAccountCredential.UpdateAsync(WaitUntil.Completed, data);
            DataBoxEdgeStorageAccountCredentialResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataBoxEdgeStorageAccountCredentialData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_SACDelete()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/SACDelete.json
            // this example is just showing the usage of "StorageAccountCredentials_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeStorageAccountCredentialResource created on azure
            // for more information of creating DataBoxEdgeStorageAccountCredentialResource, please refer to the document of DataBoxEdgeStorageAccountCredentialResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            string name = "sac1";
            ResourceIdentifier dataBoxEdgeStorageAccountCredentialResourceId = DataBoxEdgeStorageAccountCredentialResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName, name);
            DataBoxEdgeStorageAccountCredentialResource dataBoxEdgeStorageAccountCredential = client.GetDataBoxEdgeStorageAccountCredentialResource(dataBoxEdgeStorageAccountCredentialResourceId);

            // invoke the operation
            await dataBoxEdgeStorageAccountCredential.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
