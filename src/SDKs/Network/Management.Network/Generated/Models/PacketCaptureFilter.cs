// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Filter that is applied to packet capture request. Multiple filters can
    /// be applied.
    /// </summary>
    public partial class PacketCaptureFilter
    {
        /// <summary>
        /// Initializes a new instance of the PacketCaptureFilter class.
        /// </summary>
        public PacketCaptureFilter()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PacketCaptureFilter class.
        /// </summary>
        /// <param name="protocol">Protocol to be filtered on. Possible values
        /// include: 'TCP', 'UDP', 'Any'</param>
        /// <param name="localIPAddress">Local IP Address to be filtered on.
        /// Notation: "127.0.0.1" for single address entry.
        /// "127.0.0.1-127.0.0.255" for range. "127.0.0.1;127.0.0.5"? for
        /// multiple entries. Multiple ranges not currently supported. Mixing
        /// ranges with multiple entries not currently supported. Default =
        /// null.</param>
        /// <param name="remoteIPAddress">Local IP Address to be filtered on.
        /// Notation: "127.0.0.1" for single address entry.
        /// "127.0.0.1-127.0.0.255" for range. "127.0.0.1;127.0.0.5;" for
        /// multiple entries. Multiple ranges not currently supported. Mixing
        /// ranges with multiple entries not currently supported. Default =
        /// null.</param>
        /// <param name="localPort">Local port to be filtered on. Notation:
        /// "80" for single port entry."80-85" for range. "80;443;" for
        /// multiple entries. Multiple ranges not currently supported. Mixing
        /// ranges with multiple entries not currently supported. Default =
        /// null.</param>
        /// <param name="remotePort">Remote port to be filtered on. Notation:
        /// "80" for single port entry."80-85" for range. "80;443;" for
        /// multiple entries. Multiple ranges not currently supported. Mixing
        /// ranges with multiple entries not currently supported. Default =
        /// null.</param>
        public PacketCaptureFilter(string protocol = default(string), string localIPAddress = default(string), string remoteIPAddress = default(string), string localPort = default(string), string remotePort = default(string))
        {
            Protocol = protocol;
            LocalIPAddress = localIPAddress;
            RemoteIPAddress = remoteIPAddress;
            LocalPort = localPort;
            RemotePort = remotePort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets protocol to be filtered on. Possible values include:
        /// 'TCP', 'UDP', 'Any'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets local IP Address to be filtered on. Notation:
        /// "127.0.0.1" for single address entry. "127.0.0.1-127.0.0.255" for
        /// range. "127.0.0.1;127.0.0.5"? for multiple entries. Multiple ranges
        /// not currently supported. Mixing ranges with multiple entries not
        /// currently supported. Default = null.
        /// </summary>
        [JsonProperty(PropertyName = "localIPAddress")]
        public string LocalIPAddress { get; set; }

        /// <summary>
        /// Gets or sets local IP Address to be filtered on. Notation:
        /// "127.0.0.1" for single address entry. "127.0.0.1-127.0.0.255" for
        /// range. "127.0.0.1;127.0.0.5;" for multiple entries. Multiple ranges
        /// not currently supported. Mixing ranges with multiple entries not
        /// currently supported. Default = null.
        /// </summary>
        [JsonProperty(PropertyName = "remoteIPAddress")]
        public string RemoteIPAddress { get; set; }

        /// <summary>
        /// Gets or sets local port to be filtered on. Notation: "80" for
        /// single port entry."80-85" for range. "80;443;" for multiple
        /// entries. Multiple ranges not currently supported. Mixing ranges
        /// with multiple entries not currently supported. Default = null.
        /// </summary>
        [JsonProperty(PropertyName = "localPort")]
        public string LocalPort { get; set; }

        /// <summary>
        /// Gets or sets remote port to be filtered on. Notation: "80" for
        /// single port entry."80-85" for range. "80;443;" for multiple
        /// entries. Multiple ranges not currently supported. Mixing ranges
        /// with multiple entries not currently supported. Default = null.
        /// </summary>
        [JsonProperty(PropertyName = "remotePort")]
        public string RemotePort { get; set; }

    }
}
