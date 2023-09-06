// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Application gateway backendhealth http settings. </summary>
    public partial class ApplicationGatewayBackendHealthServer
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealthServer"/>. </summary>
        internal ApplicationGatewayBackendHealthServer()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealthServer"/>. </summary>
        /// <param name="address"> IP address or FQDN of backend server. </param>
        /// <param name="ipConfiguration"> Reference to IP configuration of backend server. </param>
        /// <param name="health"> Health of backend server. </param>
        /// <param name="healthProbeLog"> Health Probe Log. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayBackendHealthServer(string address, NetworkInterfaceIPConfigurationData ipConfiguration, ApplicationGatewayBackendHealthServerHealth? health, string healthProbeLog, Dictionary<string, BinaryData> rawData)
        {
            Address = address;
            IPConfiguration = ipConfiguration;
            Health = health;
            HealthProbeLog = healthProbeLog;
            _rawData = rawData;
        }

        /// <summary> IP address or FQDN of backend server. </summary>
        public string Address { get; }
        /// <summary> Reference to IP configuration of backend server. </summary>
        public NetworkInterfaceIPConfigurationData IPConfiguration { get; }
        /// <summary> Health of backend server. </summary>
        public ApplicationGatewayBackendHealthServerHealth? Health { get; }
        /// <summary> Health Probe Log. </summary>
        public string HealthProbeLog { get; }
    }
}
