// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Quality of Service defines the traffic configuration between endpoints. Mandatory to have one marking. </summary>
    public partial class DscpQosDefinition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DscpQosDefinition"/>. </summary>
        public DscpQosDefinition()
        {
            Markings = new ChangeTrackingList<int>();
            SourceIPRanges = new ChangeTrackingList<QosIPRange>();
            DestinationIPRanges = new ChangeTrackingList<QosIPRange>();
            SourcePortRanges = new ChangeTrackingList<QosPortRange>();
            DestinationPortRanges = new ChangeTrackingList<QosPortRange>();
        }

        /// <summary> Initializes a new instance of <see cref="DscpQosDefinition"/>. </summary>
        /// <param name="markings"> List of markings to be used in the configuration. </param>
        /// <param name="sourceIPRanges"> Source IP ranges. </param>
        /// <param name="destinationIPRanges"> Destination IP ranges. </param>
        /// <param name="sourcePortRanges"> Sources port ranges. </param>
        /// <param name="destinationPortRanges"> Destination port ranges. </param>
        /// <param name="protocol"> RNM supported protocol types. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DscpQosDefinition(IList<int> markings, IList<QosIPRange> sourceIPRanges, IList<QosIPRange> destinationIPRanges, IList<QosPortRange> sourcePortRanges, IList<QosPortRange> destinationPortRanges, ProtocolType? protocol, Dictionary<string, BinaryData> rawData)
        {
            Markings = markings;
            SourceIPRanges = sourceIPRanges;
            DestinationIPRanges = destinationIPRanges;
            SourcePortRanges = sourcePortRanges;
            DestinationPortRanges = destinationPortRanges;
            Protocol = protocol;
            _rawData = rawData;
        }

        /// <summary> List of markings to be used in the configuration. </summary>
        public IList<int> Markings { get; }
        /// <summary> Source IP ranges. </summary>
        public IList<QosIPRange> SourceIPRanges { get; }
        /// <summary> Destination IP ranges. </summary>
        public IList<QosIPRange> DestinationIPRanges { get; }
        /// <summary> Sources port ranges. </summary>
        public IList<QosPortRange> SourcePortRanges { get; }
        /// <summary> Destination port ranges. </summary>
        public IList<QosPortRange> DestinationPortRanges { get; }
        /// <summary> RNM supported protocol types. </summary>
        public ProtocolType? Protocol { get; set; }
    }
}
