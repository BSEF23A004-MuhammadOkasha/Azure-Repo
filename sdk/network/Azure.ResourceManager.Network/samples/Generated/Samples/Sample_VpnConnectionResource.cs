// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VpnConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_VpnConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VpnConnectionGet.json
            // this example is just showing the usage of "VpnConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnConnectionResource created on azure
            // for more information of creating VpnConnectionResource, please refer to the document of VpnConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string connectionName = "vpnConnection1";
            ResourceIdentifier vpnConnectionResourceId = VpnConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, connectionName);
            VpnConnectionResource vpnConnection = client.GetVpnConnectionResource(vpnConnectionResourceId);

            // invoke the operation
            VpnConnectionResource result = await vpnConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_VpnConnectionPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VpnConnectionPut.json
            // this example is just showing the usage of "VpnConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnConnectionResource created on azure
            // for more information of creating VpnConnectionResource, please refer to the document of VpnConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string connectionName = "vpnConnection1";
            ResourceIdentifier vpnConnectionResourceId = VpnConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, connectionName);
            VpnConnectionResource vpnConnection = client.GetVpnConnectionResource(vpnConnectionResourceId);

            // invoke the operation
            VpnConnectionData data = new VpnConnectionData()
            {
                RemoteVpnSiteId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/vpnSites/vpnSite1"),
                TrafficSelectorPolicies =
{
},
                VpnLinkConnections =
{
new VpnSiteLinkConnectionData()
{
VpnSiteLinkId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/vpnSites/vpnSite1/vpnSiteLinks/siteLink1"),
VpnLinkConnectionMode = VpnLinkConnectionMode.Default,
VpnConnectionProtocolType = VirtualNetworkGatewayConnectionProtocol.IkeV2,
ConnectionBandwidth = 200,
SharedKey = "key",
UsePolicyBasedTrafficSelectors = false,
Name = "Connection-Link1",
}
},
                RoutingConfiguration = new RoutingConfiguration()
                {
                    AssociatedRouteTableId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/hub1/hubRouteTables/hubRouteTable1"),
                    PropagatedRouteTables = new PropagatedRouteTable()
                    {
                        Labels =
{
"label1","label2"
},
                        Ids =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/hub1/hubRouteTables/hubRouteTable1"),
},new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/hub1/hubRouteTables/hubRouteTable2"),
},new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/hub1/hubRouteTables/hubRouteTable3"),
}
},
                    },
                    InboundRouteMapId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/routeMaps/routeMap1"),
                    OutboundRouteMapId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/virtualHub1/routeMaps/routeMap2"),
                },
            };
            ArmOperation<VpnConnectionResource> lro = await vpnConnection.UpdateAsync(WaitUntil.Completed, data);
            VpnConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_VpnConnectionDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VpnConnectionDelete.json
            // this example is just showing the usage of "VpnConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnConnectionResource created on azure
            // for more information of creating VpnConnectionResource, please refer to the document of VpnConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string connectionName = "vpnConnection1";
            ResourceIdentifier vpnConnectionResourceId = VpnConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, connectionName);
            VpnConnectionResource vpnConnection = client.GetVpnConnectionResource(vpnConnectionResourceId);

            // invoke the operation
            await vpnConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task StartPacketCapture_StartPacketCaptureOnVpnConnectionWithFilter()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VpnConnectionStartPacketCaptureFilterData.json
            // this example is just showing the usage of "VpnConnections_StartPacketCapture" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnConnectionResource created on azure
            // for more information of creating VpnConnectionResource, please refer to the document of VpnConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string vpnConnectionName = "vpnConnection1";
            ResourceIdentifier vpnConnectionResourceId = VpnConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, vpnConnectionName);
            VpnConnectionResource vpnConnection = client.GetVpnConnectionResource(vpnConnectionResourceId);

            // invoke the operation
            VpnConnectionPacketCaptureStartContent content = new VpnConnectionPacketCaptureStartContent()
            {
                FilterData = "{'TracingFlags': 11,'MaxPacketBufferSize': 120,'MaxFileSize': 200,'Filters': [{'SourceSubnets': ['20.1.1.0/24'],'DestinationSubnets': ['10.1.1.0/24'],'SourcePort': [500],'DestinationPort': [4500],'Protocol': 6,'TcpFlags': 16,'CaptureSingleDirectionTrafficOnly': true}]}",
                LinkConnectionNames =
{
"siteLink1","siteLink2"
},
            };
            ArmOperation<string> lro = await vpnConnection.StartPacketCaptureAsync(WaitUntil.Completed, content: content);
            string result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task StartPacketCapture_StartPacketCaptureOnVpnConnectionWithoutFilter()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VpnConnectionStartPacketCapture.json
            // this example is just showing the usage of "VpnConnections_StartPacketCapture" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnConnectionResource created on azure
            // for more information of creating VpnConnectionResource, please refer to the document of VpnConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string vpnConnectionName = "vpnConnection1";
            ResourceIdentifier vpnConnectionResourceId = VpnConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, vpnConnectionName);
            VpnConnectionResource vpnConnection = client.GetVpnConnectionResource(vpnConnectionResourceId);

            // invoke the operation
            VpnConnectionPacketCaptureStartContent content = new VpnConnectionPacketCaptureStartContent()
            {
                LinkConnectionNames =
{
"siteLink1","siteLink2"
},
            };
            ArmOperation<string> lro = await vpnConnection.StartPacketCaptureAsync(WaitUntil.Completed, content: content);
            string result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task StopPacketCapture_StartPacketCaptureOnVpnConnectionWithoutFilter()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VpnConnectionStopPacketCapture.json
            // this example is just showing the usage of "VpnConnections_StopPacketCapture" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnConnectionResource created on azure
            // for more information of creating VpnConnectionResource, please refer to the document of VpnConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string vpnConnectionName = "vpnConnection1";
            ResourceIdentifier vpnConnectionResourceId = VpnConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, vpnConnectionName);
            VpnConnectionResource vpnConnection = client.GetVpnConnectionResource(vpnConnectionResourceId);

            // invoke the operation
            VpnConnectionPacketCaptureStopContent content = new VpnConnectionPacketCaptureStopContent()
            {
                SasUri = new Uri("https://teststorage.blob.core.windows.net/?sv=2018-03-28&ss=bfqt&srt=sco&sp=rwdlacup&se=2019-09-13T07:44:05Z&st=2019-09-06T23:44:05Z&spr=https&sig=V1h9D1riltvZMI69d6ihENnFo%2FrCvTqGgjO2lf%2FVBhE%3D"),
                LinkConnectionNames =
{
"vpnSiteLink1","vpnSiteLink2"
},
            };
            ArmOperation<string> lro = await vpnConnection.StopPacketCaptureAsync(WaitUntil.Completed, content: content);
            string result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
