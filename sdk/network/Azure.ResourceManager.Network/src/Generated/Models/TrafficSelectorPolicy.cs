// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> An traffic selector policy for a virtual network gateway connection. </summary>
    public partial class TrafficSelectorPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TrafficSelectorPolicy"/>. </summary>
        /// <param name="localAddressRanges"> A collection of local address spaces in CIDR format. </param>
        /// <param name="remoteAddressRanges"> A collection of remote address spaces in CIDR format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="localAddressRanges"/> or <paramref name="remoteAddressRanges"/> is null. </exception>
        public TrafficSelectorPolicy(IEnumerable<string> localAddressRanges, IEnumerable<string> remoteAddressRanges)
        {
            Argument.AssertNotNull(localAddressRanges, nameof(localAddressRanges));
            Argument.AssertNotNull(remoteAddressRanges, nameof(remoteAddressRanges));

            LocalAddressRanges = localAddressRanges.ToList();
            RemoteAddressRanges = remoteAddressRanges.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="TrafficSelectorPolicy"/>. </summary>
        /// <param name="localAddressRanges"> A collection of local address spaces in CIDR format. </param>
        /// <param name="remoteAddressRanges"> A collection of remote address spaces in CIDR format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrafficSelectorPolicy(IList<string> localAddressRanges, IList<string> remoteAddressRanges, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LocalAddressRanges = localAddressRanges;
            RemoteAddressRanges = remoteAddressRanges;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TrafficSelectorPolicy"/> for deserialization. </summary>
        internal TrafficSelectorPolicy()
        {
        }

        /// <summary> A collection of local address spaces in CIDR format. </summary>
        public IList<string> LocalAddressRanges { get; }
        /// <summary> A collection of remote address spaces in CIDR format. </summary>
        public IList<string> RemoteAddressRanges { get; }
    }
}
