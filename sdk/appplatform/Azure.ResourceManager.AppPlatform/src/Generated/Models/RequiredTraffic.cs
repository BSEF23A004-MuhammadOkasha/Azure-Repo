// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Required inbound or outbound traffic for Azure Spring Cloud instance. </summary>
    public partial class RequiredTraffic
    {
        /// <summary> Initializes a new instance of <see cref="RequiredTraffic"/>. </summary>
        internal RequiredTraffic()
        {
            IPs = new ChangeTrackingList<string>();
            Fqdns = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="RequiredTraffic"/>. </summary>
        /// <param name="protocol"> The protocol of required traffic. </param>
        /// <param name="port"> The port of required traffic. </param>
        /// <param name="iPs"> The ip list of required traffic. </param>
        /// <param name="fqdns"> The FQDN list of required traffic. </param>
        /// <param name="direction"> The direction of required traffic. </param>
        internal RequiredTraffic(string protocol, int? port, IReadOnlyList<string> iPs, IReadOnlyList<string> fqdns, TrafficDirection? direction)
        {
            Protocol = protocol;
            Port = port;
            IPs = iPs;
            Fqdns = fqdns;
            Direction = direction;
        }

        /// <summary> The protocol of required traffic. </summary>
        public string Protocol { get; }
        /// <summary> The port of required traffic. </summary>
        public int? Port { get; }
        /// <summary> The ip list of required traffic. </summary>
        public IReadOnlyList<string> IPs { get; }
        /// <summary> The FQDN list of required traffic. </summary>
        public IReadOnlyList<string> Fqdns { get; }
        /// <summary> The direction of required traffic. </summary>
        public TrafficDirection? Direction { get; }
    }
}
