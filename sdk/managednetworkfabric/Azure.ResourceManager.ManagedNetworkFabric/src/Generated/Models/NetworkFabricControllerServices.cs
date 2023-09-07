// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Network Fabric Controller services. </summary>
    public partial class NetworkFabricControllerServices
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkFabricControllerServices"/>. </summary>
        internal NetworkFabricControllerServices()
        {
            IPv4AddressSpaces = new ChangeTrackingList<string>();
            IPv6AddressSpaces = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricControllerServices"/>. </summary>
        /// <param name="ipv4AddressSpaces"> The IPv4 Address space is optional, if the value is not defined at the time of NFC creation, then the default value 10.0.0.0/19 is considered. The IPV4 address subnet is an optional attribute. </param>
        /// <param name="ipv6AddressSpaces"> The IPv6 is not supported right now. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricControllerServices(IReadOnlyList<string> ipv4AddressSpaces, IReadOnlyList<string> ipv6AddressSpaces, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPv4AddressSpaces = ipv4AddressSpaces;
            IPv6AddressSpaces = ipv6AddressSpaces;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The IPv4 Address space is optional, if the value is not defined at the time of NFC creation, then the default value 10.0.0.0/19 is considered. The IPV4 address subnet is an optional attribute. </summary>
        public IReadOnlyList<string> IPv4AddressSpaces { get; }
        /// <summary> The IPv6 is not supported right now. </summary>
        public IReadOnlyList<string> IPv6AddressSpaces { get; }
    }
}
