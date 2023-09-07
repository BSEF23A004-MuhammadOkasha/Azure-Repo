// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration service environment subnet network health. </summary>
    public partial class IntegrationServiceEnvironmentNetworkDependencyHealth
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentNetworkDependencyHealth"/>. </summary>
        internal IntegrationServiceEnvironmentNetworkDependencyHealth()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentNetworkDependencyHealth"/>. </summary>
        /// <param name="error"> The error if any occurred during the operation. </param>
        /// <param name="state"> The network dependency health state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationServiceEnvironmentNetworkDependencyHealth(IntegrationServiceErrorInfo error, IntegrationServiceEnvironmentNetworkDependencyHealthState? state, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Error = error;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The error if any occurred during the operation. </summary>
        public IntegrationServiceErrorInfo Error { get; }
        /// <summary> The network dependency health state. </summary>
        public IntegrationServiceEnvironmentNetworkDependencyHealthState? State { get; }
    }
}
