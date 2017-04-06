// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Class containing endpoint monitoring settings in a Traffic Manager
    /// profile.
    /// </summary>
    public partial class MonitorConfig
    {
        /// <summary>
        /// Initializes a new instance of the MonitorConfig class.
        /// </summary>
        public MonitorConfig() { }

        /// <summary>
        /// Initializes a new instance of the MonitorConfig class.
        /// </summary>
        public MonitorConfig(string profileMonitorStatus = default(string), string protocol = default(string), long? port = default(long?), string path = default(string))
        {
            ProfileMonitorStatus = profileMonitorStatus;
            Protocol = protocol;
            Port = port;
            Path = path;
        }

        /// <summary>
        /// Gets or sets the profile-level monitoring status of the Traffic
        /// Manager profile.
        /// </summary>
        [JsonProperty(PropertyName = "profileMonitorStatus")]
        public string ProfileMonitorStatus { get; set; }

        /// <summary>
        /// Gets or sets the protocol (HTTP or HTTPS) used to probe for
        /// endpoint health.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the TCP port used to probe for endpoint health.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }

        /// <summary>
        /// Gets or sets the path relative to the endpoint domain name used to
        /// probe for endpoint health.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

    }
}
