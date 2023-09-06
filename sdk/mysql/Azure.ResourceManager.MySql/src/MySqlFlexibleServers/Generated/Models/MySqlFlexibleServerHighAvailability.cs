// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Network related properties of a server. </summary>
    public partial class MySqlFlexibleServerHighAvailability
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerHighAvailability"/>. </summary>
        public MySqlFlexibleServerHighAvailability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerHighAvailability"/>. </summary>
        /// <param name="mode"> High availability mode for a server. </param>
        /// <param name="state"> The state of server high availability. </param>
        /// <param name="standbyAvailabilityZone"> Availability zone of the standby server. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerHighAvailability(MySqlFlexibleServerHighAvailabilityMode? mode, MySqlFlexibleServerHighAvailabilityState? state, string standbyAvailabilityZone, Dictionary<string, BinaryData> rawData)
        {
            Mode = mode;
            State = state;
            StandbyAvailabilityZone = standbyAvailabilityZone;
            _rawData = rawData;
        }

        /// <summary> High availability mode for a server. </summary>
        public MySqlFlexibleServerHighAvailabilityMode? Mode { get; set; }
        /// <summary> The state of server high availability. </summary>
        public MySqlFlexibleServerHighAvailabilityState? State { get; }
        /// <summary> Availability zone of the standby server. </summary>
        public string StandbyAvailabilityZone { get; set; }
    }
}
