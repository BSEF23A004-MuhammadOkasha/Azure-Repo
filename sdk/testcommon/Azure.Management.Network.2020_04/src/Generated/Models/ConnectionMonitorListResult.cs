// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> List of connection monitors. </summary>
    public partial class ConnectionMonitorListResult
    {
        /// <summary> Initializes a new instance of ConnectionMonitorListResult. </summary>
        internal ConnectionMonitorListResult()
        {
            Value = new ChangeTrackingList<ConnectionMonitorResult>();
        }

        /// <summary> Initializes a new instance of ConnectionMonitorListResult. </summary>
        /// <param name="value"> Information about connection monitors. </param>
        internal ConnectionMonitorListResult(IReadOnlyList<ConnectionMonitorResult> value)
        {
            Value = value;
        }

        /// <summary> Information about connection monitors. </summary>
        public IReadOnlyList<ConnectionMonitorResult> Value { get; }
    }
}
