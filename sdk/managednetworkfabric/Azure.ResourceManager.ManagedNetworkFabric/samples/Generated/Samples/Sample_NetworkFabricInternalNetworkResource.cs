// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ManagedNetworkFabric.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric.Samples
{
    public partial class Sample_NetworkFabricInternalNetworkResource
    {
        // InternalNetworks_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_InternalNetworksGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/InternalNetworks_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "InternalNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricInternalNetworkResource created on azure
            // for more information of creating NetworkFabricInternalNetworkResource, please refer to the document of NetworkFabricInternalNetworkResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l3IsolationDomainName = "example-l3domain";
            string internalNetworkName = "example-internalnetwork";
            ResourceIdentifier networkFabricInternalNetworkResourceId = NetworkFabricInternalNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName, internalNetworkName);
            NetworkFabricInternalNetworkResource networkFabricInternalNetwork = client.GetNetworkFabricInternalNetworkResource(networkFabricInternalNetworkResourceId);

            // invoke the operation
            NetworkFabricInternalNetworkResource result = await networkFabricInternalNetwork.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFabricInternalNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // InternalNetworks_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_InternalNetworksUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/InternalNetworks_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "InternalNetworks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricInternalNetworkResource created on azure
            // for more information of creating NetworkFabricInternalNetworkResource, please refer to the document of NetworkFabricInternalNetworkResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l3IsolationDomainName = "example-l3domain";
            string internalNetworkName = "example-internalnetwork";
            ResourceIdentifier networkFabricInternalNetworkResourceId = NetworkFabricInternalNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName, internalNetworkName);
            NetworkFabricInternalNetworkResource networkFabricInternalNetwork = client.GetNetworkFabricInternalNetworkResource(networkFabricInternalNetworkResourceId);

            // invoke the operation
            NetworkFabricInternalNetworkPatch patch = new NetworkFabricInternalNetworkPatch()
            {
                Annotation = "annotation",
                Mtu = 1500,
                ConnectedIPv4Subnets =
{
new ConnectedSubnet("10.0.0.0/24")
{
Annotation = "annotation",
}
},
                ConnectedIPv6Subnets =
{
new ConnectedSubnet("3FFE:FFFF:0:CD30::a0/29")
{
Annotation = "annotation",
}
},
                ImportRoutePolicyId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.ManagedNetworkFabric/routePolicies/routePolicyName"),
                ExportRoutePolicyId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.ManagedNetworkFabric/routePolicies/routePolicyName"),
                ImportRoutePolicy = new ImportRoutePolicy()
                {
                    ImportIPv4RoutePolicyId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.ManagedNetworkFabric/routePolicies/routePolicyName"),
                    ImportIPv6RoutePolicyId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.ManagedNetworkFabric/routePolicies/routePolicyName"),
                },
                ExportRoutePolicy = new ExportRoutePolicy()
                {
                    ExportIPv4RoutePolicyId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.ManagedNetworkFabric/routePolicies/routePolicyName"),
                    ExportIPv6RoutePolicyId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.ManagedNetworkFabric/routePolicies/routePolicyName"),
                },
                IngressAclId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.ManagedNetworkFabric/accessControlLists/example-acl"),
                EgressAclId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.ManagedNetworkFabric/accessControlLists/example-acl"),
                IsMonitoringEnabled = IsMonitoringEnabled.True,
                BgpConfiguration = new BgpConfiguration()
                {
                    BfdConfiguration = new BfdConfiguration()
                    {
                        IntervalInMilliSeconds = 300,
                        Multiplier = 5,
                    },
                    DefaultRouteOriginate = NetworkFabricBooleanValue.True,
                    AllowAS = 10,
                    AllowASOverride = AllowASOverride.Enable,
                    PeerAsn = 61234L,
                    IPv4ListenRangePrefixes =
{
"10.1.0.0/25"
},
                    IPv6ListenRangePrefixes =
{
"2fff::/66"
},
                    IPv4NeighborAddress =
{
new NeighborAddress()
{
Address = "10.1.0.0",
}
},
                    IPv6NeighborAddress =
{
new NeighborAddress()
{
Address = "2fff::",
}
},
                    Annotation = "annotation",
                },
                StaticRouteConfiguration = new StaticRouteConfiguration()
                {
                    BfdConfiguration = new BfdConfiguration()
                    {
                        IntervalInMilliSeconds = 300,
                        Multiplier = 15,
                    },
                    IPv4Routes =
{
new StaticRouteProperties("20.20.20.20/25",new string[]
{
"10.0.0.1"
})
},
                    IPv6Routes =
{
new StaticRouteProperties("2fff::/64",new string[]
{
"3ffe::1"
})
},
                },
            };
            ArmOperation<NetworkFabricInternalNetworkResource> lro = await networkFabricInternalNetwork.UpdateAsync(WaitUntil.Completed, patch);
            NetworkFabricInternalNetworkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFabricInternalNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // InternalNetworks_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_InternalNetworksDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/InternalNetworks_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "InternalNetworks_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricInternalNetworkResource created on azure
            // for more information of creating NetworkFabricInternalNetworkResource, please refer to the document of NetworkFabricInternalNetworkResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l3IsolationDomainName = "example-l3domain";
            string internalNetworkName = "example-internalnetwork";
            ResourceIdentifier networkFabricInternalNetworkResourceId = NetworkFabricInternalNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName, internalNetworkName);
            NetworkFabricInternalNetworkResource networkFabricInternalNetwork = client.GetNetworkFabricInternalNetworkResource(networkFabricInternalNetworkResourceId);

            // invoke the operation
            await networkFabricInternalNetwork.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // InternalNetworks_UpdateAdministrativeState_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpdateAdministrativeState_InternalNetworksUpdateAdministrativeStateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/InternalNetworks_UpdateAdministrativeState_MaximumSet_Gen.json
            // this example is just showing the usage of "InternalNetworks_UpdateAdministrativeState" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricInternalNetworkResource created on azure
            // for more information of creating NetworkFabricInternalNetworkResource, please refer to the document of NetworkFabricInternalNetworkResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l3IsolationDomainName = "example-l3domain";
            string internalNetworkName = "example-internalnetwork";
            ResourceIdentifier networkFabricInternalNetworkResourceId = NetworkFabricInternalNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName, internalNetworkName);
            NetworkFabricInternalNetworkResource networkFabricInternalNetwork = client.GetNetworkFabricInternalNetworkResource(networkFabricInternalNetworkResourceId);

            // invoke the operation
            UpdateAdministrativeStateContent content = new UpdateAdministrativeStateContent()
            {
                State = AdministrativeEnableState.Enable,
                ResourceIds =
{
new ResourceIdentifier("")
},
            };
            ArmOperation<StateUpdateCommonPostActionResult> lro = await networkFabricInternalNetwork.UpdateAdministrativeStateAsync(WaitUntil.Completed, content);
            StateUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // InternalNetworks_UpdateBgpAdministrativeState_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpdateBgpAdministrativeState_InternalNetworksUpdateBgpAdministrativeStateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/InternalNetworks_UpdateBgpAdministrativeState_MaximumSet_Gen.json
            // this example is just showing the usage of "InternalNetworks_UpdateBgpAdministrativeState" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricInternalNetworkResource created on azure
            // for more information of creating NetworkFabricInternalNetworkResource, please refer to the document of NetworkFabricInternalNetworkResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l3IsolationDomainName = "example-l3domain";
            string internalNetworkName = "example-internalNetwork";
            ResourceIdentifier networkFabricInternalNetworkResourceId = NetworkFabricInternalNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName, internalNetworkName);
            NetworkFabricInternalNetworkResource networkFabricInternalNetwork = client.GetNetworkFabricInternalNetworkResource(networkFabricInternalNetworkResourceId);

            // invoke the operation
            UpdateAdministrativeStateContent content = new UpdateAdministrativeStateContent()
            {
                State = AdministrativeEnableState.Enable,
                ResourceIds =
{
new ResourceIdentifier("")
},
            };
            ArmOperation<StateUpdateCommonPostActionResult> lro = await networkFabricInternalNetwork.UpdateBgpAdministrativeStateAsync(WaitUntil.Completed, content);
            StateUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // InternalNetworks_UpdateStaticRouteBfdAdministrativeState_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpdateStaticRouteBfdAdministrativeState_InternalNetworksUpdateStaticRouteBfdAdministrativeStateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/InternalNetworks_UpdateStaticRouteBfdAdministrativeState_MaximumSet_Gen.json
            // this example is just showing the usage of "InternalNetworks_UpdateStaticRouteBfdAdministrativeState" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricInternalNetworkResource created on azure
            // for more information of creating NetworkFabricInternalNetworkResource, please refer to the document of NetworkFabricInternalNetworkResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l3IsolationDomainName = "example-l3domain";
            string internalNetworkName = "example-internalNetwork";
            ResourceIdentifier networkFabricInternalNetworkResourceId = NetworkFabricInternalNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName, internalNetworkName);
            NetworkFabricInternalNetworkResource networkFabricInternalNetwork = client.GetNetworkFabricInternalNetworkResource(networkFabricInternalNetworkResourceId);

            // invoke the operation
            UpdateAdministrativeStateContent content = new UpdateAdministrativeStateContent()
            {
                State = AdministrativeEnableState.Enable,
                ResourceIds =
{
new ResourceIdentifier("")
},
            };
            ArmOperation<StateUpdateCommonPostActionResult> lro = await networkFabricInternalNetwork.UpdateStaticRouteBfdAdministrativeStateAsync(WaitUntil.Completed, content);
            StateUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
