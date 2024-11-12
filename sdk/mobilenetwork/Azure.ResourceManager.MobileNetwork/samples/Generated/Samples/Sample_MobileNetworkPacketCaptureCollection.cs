// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.MobileNetwork.Samples
{
    public partial class Sample_MobileNetworkPacketCaptureCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatePacketCapture()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCaptureCreate.json
            // this example is just showing the usage of "PacketCaptures_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this MobileNetworkPacketCaptureResource
            MobileNetworkPacketCaptureCollection collection = packetCoreControlPlane.GetMobileNetworkPacketCaptures();

            // invoke the operation
            string packetCaptureName = "pc1";
            MobileNetworkPacketCaptureData data = new MobileNetworkPacketCaptureData()
            {
                NetworkInterfaces =
{
"/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/TestPacketCoreCP","/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/TestPacketCoreCP/packetCoreDataPlanes/TestPacketCoreDP","/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/TestPacketCoreCP/packetCoreDataPlanes/TestPacketCoreDP/attachedDataNetworks/TestADN"
},
                BytesToCapturePerPacket = 10000L,
                TotalBytesPerSession = 100000L,
                TimeLimitInSeconds = 100,
            };
            ArmOperation<MobileNetworkPacketCaptureResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, packetCaptureName, data);
            MobileNetworkPacketCaptureResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MobileNetworkPacketCaptureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPacketCaptureSession()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCaptureGet.json
            // this example is just showing the usage of "PacketCaptures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this MobileNetworkPacketCaptureResource
            MobileNetworkPacketCaptureCollection collection = packetCoreControlPlane.GetMobileNetworkPacketCaptures();

            // invoke the operation
            string packetCaptureName = "pc1";
            MobileNetworkPacketCaptureResource result = await collection.GetAsync(packetCaptureName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MobileNetworkPacketCaptureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetPacketCaptureSession()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCaptureGet.json
            // this example is just showing the usage of "PacketCaptures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this MobileNetworkPacketCaptureResource
            MobileNetworkPacketCaptureCollection collection = packetCoreControlPlane.GetMobileNetworkPacketCaptures();

            // invoke the operation
            string packetCaptureName = "pc1";
            bool result = await collection.ExistsAsync(packetCaptureName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetPacketCaptureSession()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCaptureGet.json
            // this example is just showing the usage of "PacketCaptures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this MobileNetworkPacketCaptureResource
            MobileNetworkPacketCaptureCollection collection = packetCoreControlPlane.GetMobileNetworkPacketCaptures();

            // invoke the operation
            string packetCaptureName = "pc1";
            NullableResponse<MobileNetworkPacketCaptureResource> response = await collection.GetIfExistsAsync(packetCaptureName);
            MobileNetworkPacketCaptureResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MobileNetworkPacketCaptureData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListPacketCaptureSessionsUnderAPacketCoreControlPlane()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCaptureListByPacketCoreControlPlane.json
            // this example is just showing the usage of "PacketCaptures_ListByPacketCoreControlPlane" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this MobileNetworkPacketCaptureResource
            MobileNetworkPacketCaptureCollection collection = packetCoreControlPlane.GetMobileNetworkPacketCaptures();

            // invoke the operation and iterate over the result
            await foreach (MobileNetworkPacketCaptureResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MobileNetworkPacketCaptureData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
