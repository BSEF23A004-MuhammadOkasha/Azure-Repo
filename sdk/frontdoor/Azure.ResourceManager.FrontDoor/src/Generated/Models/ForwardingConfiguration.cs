// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Describes Forwarding Route. </summary>
    public partial class ForwardingConfiguration : RouteConfiguration
    {
        /// <summary> Initializes a new instance of ForwardingConfiguration. </summary>
        public ForwardingConfiguration()
        {
            OdataType = "#Microsoft.Azure.FrontDoor.Models.FrontdoorForwardingConfiguration";
        }

        /// <summary> Initializes a new instance of ForwardingConfiguration. </summary>
        /// <param name="odataType"></param>
        /// <param name="customForwardingPath"> A custom path used to rewrite resource paths matched by this rule. Leave empty to use incoming path. </param>
        /// <param name="forwardingProtocol"> Protocol this rule will use when forwarding traffic to backends. </param>
        /// <param name="cacheConfiguration"> The caching configuration associated with this rule. </param>
        /// <param name="backendPool"> A reference to the BackendPool which this rule routes to. </param>
        internal ForwardingConfiguration(string odataType, string customForwardingPath, FrontDoorForwardingProtocol? forwardingProtocol, CacheConfiguration cacheConfiguration, WritableSubResource backendPool) : base(odataType)
        {
            CustomForwardingPath = customForwardingPath;
            ForwardingProtocol = forwardingProtocol;
            CacheConfiguration = cacheConfiguration;
            BackendPool = backendPool;
            OdataType = odataType ?? "#Microsoft.Azure.FrontDoor.Models.FrontdoorForwardingConfiguration";
        }

        /// <summary> A custom path used to rewrite resource paths matched by this rule. Leave empty to use incoming path. </summary>
        public string CustomForwardingPath { get; set; }
        /// <summary> Protocol this rule will use when forwarding traffic to backends. </summary>
        public FrontDoorForwardingProtocol? ForwardingProtocol { get; set; }
        /// <summary> The caching configuration associated with this rule. </summary>
        public CacheConfiguration CacheConfiguration { get; set; }
        /// <summary> A reference to the BackendPool which this rule routes to. </summary>
        internal WritableSubResource BackendPool { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier BackendPoolId
        {
            get => BackendPool is null ? default : BackendPool.Id;
            set
            {
                if (BackendPool is null)
                    BackendPool = new WritableSubResource();
                BackendPool.Id = value;
            }
        }
    }
}
