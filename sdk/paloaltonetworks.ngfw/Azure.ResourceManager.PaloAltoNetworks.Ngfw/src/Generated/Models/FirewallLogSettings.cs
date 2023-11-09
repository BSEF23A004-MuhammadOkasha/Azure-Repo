// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Log Settings for Firewall. </summary>
    public partial class FirewallLogSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FirewallLogSettings"/>. </summary>
        public FirewallLogSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FirewallLogSettings"/>. </summary>
        /// <param name="logType"> One of possible log type. </param>
        /// <param name="logOption"> Log option SAME/INDIVIDUAL. </param>
        /// <param name="applicationInsights"> Application Insight details. </param>
        /// <param name="commonDestination"> Common destination configurations. </param>
        /// <param name="trafficLogDestination"> Traffic destination configurations. </param>
        /// <param name="threatLogDestination"> Threat destination configurations. </param>
        /// <param name="decryptLogDestination"> Decrypt destination configurations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallLogSettings(FirewallLogType? logType, FirewallLogOption? logOption, FirewallApplicationInsights applicationInsights, FirewallLogDestination commonDestination, FirewallLogDestination trafficLogDestination, FirewallLogDestination threatLogDestination, FirewallLogDestination decryptLogDestination, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LogType = logType;
            LogOption = logOption;
            ApplicationInsights = applicationInsights;
            CommonDestination = commonDestination;
            TrafficLogDestination = trafficLogDestination;
            ThreatLogDestination = threatLogDestination;
            DecryptLogDestination = decryptLogDestination;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> One of possible log type. </summary>
        public FirewallLogType? LogType { get; set; }
        /// <summary> Log option SAME/INDIVIDUAL. </summary>
        public FirewallLogOption? LogOption { get; set; }
        /// <summary> Application Insight details. </summary>
        public FirewallApplicationInsights ApplicationInsights { get; set; }
        /// <summary> Common destination configurations. </summary>
        public FirewallLogDestination CommonDestination { get; set; }
        /// <summary> Traffic destination configurations. </summary>
        public FirewallLogDestination TrafficLogDestination { get; set; }
        /// <summary> Threat destination configurations. </summary>
        public FirewallLogDestination ThreatLogDestination { get; set; }
        /// <summary> Decrypt destination configurations. </summary>
        public FirewallLogDestination DecryptLogDestination { get; set; }
    }
}
