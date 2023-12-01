// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The L2 Isolation Domain patch resource definition. </summary>
    public partial class NetworkFabricL2IsolationDomainPatch : NetworkRackPatch
    {
        /// <summary> Initializes a new instance of <see cref="NetworkFabricL2IsolationDomainPatch"/>. </summary>
        public NetworkFabricL2IsolationDomainPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricL2IsolationDomainPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="mtu"> Maximum transmission unit. Default value is 1500. </param>
        internal NetworkFabricL2IsolationDomainPatch(IDictionary<string, string> tags, string annotation, int? mtu) : base(tags)
        {
            Annotation = annotation;
            Mtu = mtu;
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> Maximum transmission unit. Default value is 1500. </summary>
        public int? Mtu { get; set; }
    }
}
