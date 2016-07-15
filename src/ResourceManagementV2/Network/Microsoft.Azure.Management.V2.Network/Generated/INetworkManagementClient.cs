// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// The Microsoft Azure Network management API provides a RESTful set of
    /// web services that interact with Microsoft Azure Networks service to
    /// manage your network resrources. The API has entities that capture the
    /// relationship between an end user and the Microsoft Azure Networks
    /// service.
    /// </summary>
    public partial interface INetworkManagementClient : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Client Api Version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is
        /// generated and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IApplicationGatewaysOperations.
        /// </summary>
        IApplicationGatewaysOperations ApplicationGateways { get; }

        /// <summary>
        /// Gets the IExpressRouteCircuitAuthorizationsOperations.
        /// </summary>
        IExpressRouteCircuitAuthorizationsOperations ExpressRouteCircuitAuthorizations { get; }

        /// <summary>
        /// Gets the IExpressRouteCircuitPeeringsOperations.
        /// </summary>
        IExpressRouteCircuitPeeringsOperations ExpressRouteCircuitPeerings { get; }

        /// <summary>
        /// Gets the IExpressRouteCircuitsOperations.
        /// </summary>
        IExpressRouteCircuitsOperations ExpressRouteCircuits { get; }

        /// <summary>
        /// Gets the IExpressRouteServiceProvidersOperations.
        /// </summary>
        IExpressRouteServiceProvidersOperations ExpressRouteServiceProviders { get; }

        /// <summary>
        /// Gets the ILoadBalancersOperations.
        /// </summary>
        ILoadBalancersOperations LoadBalancers { get; }

        /// <summary>
        /// Gets the ILocalNetworkGatewaysOperations.
        /// </summary>
        ILocalNetworkGatewaysOperations LocalNetworkGateways { get; }

        /// <summary>
        /// Gets the INetworkInterfacesOperations.
        /// </summary>
        INetworkInterfacesOperations NetworkInterfaces { get; }

        /// <summary>
        /// Gets the INetworkSecurityGroupsOperations.
        /// </summary>
        INetworkSecurityGroupsOperations NetworkSecurityGroups { get; }

        /// <summary>
        /// Gets the IPublicIPAddressesOperations.
        /// </summary>
        IPublicIPAddressesOperations PublicIPAddresses { get; }

        /// <summary>
        /// Gets the IRouteTablesOperations.
        /// </summary>
        IRouteTablesOperations RouteTables { get; }

        /// <summary>
        /// Gets the IRoutesOperations.
        /// </summary>
        IRoutesOperations Routes { get; }

        /// <summary>
        /// Gets the ISecurityRulesOperations.
        /// </summary>
        ISecurityRulesOperations SecurityRules { get; }

        /// <summary>
        /// Gets the ISubnetsOperations.
        /// </summary>
        ISubnetsOperations Subnets { get; }

        /// <summary>
        /// Gets the IVirtualNetworkPeeringsOperations.
        /// </summary>
        IVirtualNetworkPeeringsOperations VirtualNetworkPeerings { get; }

        /// <summary>
        /// Gets the IUsagesOperations.
        /// </summary>
        IUsagesOperations Usages { get; }

        /// <summary>
        /// Gets the IVirtualNetworkGatewayConnectionsOperations.
        /// </summary>
        IVirtualNetworkGatewayConnectionsOperations VirtualNetworkGatewayConnections { get; }

        /// <summary>
        /// Gets the IVirtualNetworkGatewaysOperations.
        /// </summary>
        IVirtualNetworkGatewaysOperations VirtualNetworkGateways { get; }

        /// <summary>
        /// Gets the IVirtualNetworksOperations.
        /// </summary>
        IVirtualNetworksOperations VirtualNetworks { get; }

            /// <summary>
        /// Checks whether a domain name in the cloudapp.net zone is available
        /// for use.
        /// </summary>
        /// <param name='location'>
        /// The location of the domain name
        /// </param>
        /// <param name='domainNameLabel'>
        /// The domain name to be verified. It must conform to the following
        /// regular expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DnsNameAvailabilityResultInner>> CheckDnsNameAvailabilityWithHttpMessagesAsync(string location, string domainNameLabel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
