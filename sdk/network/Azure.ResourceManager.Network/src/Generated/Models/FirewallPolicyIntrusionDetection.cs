// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Configuration for intrusion detection mode and rules. </summary>
    public partial class FirewallPolicyIntrusionDetection
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyIntrusionDetection"/>. </summary>
        public FirewallPolicyIntrusionDetection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyIntrusionDetection"/>. </summary>
        /// <param name="mode"> Intrusion detection general state. </param>
        /// <param name="configuration"> Intrusion detection configuration properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallPolicyIntrusionDetection(FirewallPolicyIntrusionDetectionStateType? mode, FirewallPolicyIntrusionDetectionConfiguration configuration, Dictionary<string, BinaryData> rawData)
        {
            Mode = mode;
            Configuration = configuration;
            _rawData = rawData;
        }

        /// <summary> Intrusion detection general state. </summary>
        public FirewallPolicyIntrusionDetectionStateType? Mode { get; set; }
        /// <summary> Intrusion detection configuration properties. </summary>
        public FirewallPolicyIntrusionDetectionConfiguration Configuration { get; set; }
    }
}
