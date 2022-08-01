// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The connectivity properties
    /// Serialized Name: ConnectivityEndpoint
    /// </summary>
    public partial class ConnectivityEndpoint
    {
        /// <summary> Initializes a new instance of ConnectivityEndpoint. </summary>
        public ConnectivityEndpoint()
        {
        }

        /// <summary> Initializes a new instance of ConnectivityEndpoint. </summary>
        /// <param name="name">
        /// The name of the endpoint.
        /// Serialized Name: ConnectivityEndpoint.name
        /// </param>
        /// <param name="protocol">
        /// The protocol of the endpoint.
        /// Serialized Name: ConnectivityEndpoint.protocol
        /// </param>
        /// <param name="location">
        /// The location of the endpoint.
        /// Serialized Name: ConnectivityEndpoint.location
        /// </param>
        /// <param name="port">
        /// The port to connect to.
        /// Serialized Name: ConnectivityEndpoint.port
        /// </param>
        /// <param name="privateIPAddress">
        /// The private ip address of the endpoint.
        /// Serialized Name: ConnectivityEndpoint.privateIPAddress
        /// </param>
        internal ConnectivityEndpoint(string name, string protocol, AzureLocation? location, int? port, string privateIPAddress)
        {
            Name = name;
            Protocol = protocol;
            Location = location;
            Port = port;
            PrivateIPAddress = privateIPAddress;
        }

        /// <summary>
        /// The name of the endpoint.
        /// Serialized Name: ConnectivityEndpoint.name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The protocol of the endpoint.
        /// Serialized Name: ConnectivityEndpoint.protocol
        /// </summary>
        public string Protocol { get; set; }
        /// <summary>
        /// The location of the endpoint.
        /// Serialized Name: ConnectivityEndpoint.location
        /// </summary>
        public AzureLocation? Location { get; set; }
        /// <summary>
        /// The port to connect to.
        /// Serialized Name: ConnectivityEndpoint.port
        /// </summary>
        public int? Port { get; set; }
        /// <summary>
        /// The private ip address of the endpoint.
        /// Serialized Name: ConnectivityEndpoint.privateIPAddress
        /// </summary>
        public string PrivateIPAddress { get; set; }
    }
}
