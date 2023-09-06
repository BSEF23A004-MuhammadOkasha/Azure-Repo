// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Details of VM Resource having NewRelic OneAgent installed. </summary>
    public partial class NewRelicObservabilityVmInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityVmInfo"/>. </summary>
        internal NewRelicObservabilityVmInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityVmInfo"/>. </summary>
        /// <param name="vmId"> Azure VM resource ID. </param>
        /// <param name="agentVersion"> Version of the NewRelic agent installed on the VM. </param>
        /// <param name="agentStatus"> Status of the NewRelic agent installed on the VM. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicObservabilityVmInfo(ResourceIdentifier vmId, string agentVersion, string agentStatus, Dictionary<string, BinaryData> rawData)
        {
            VmId = vmId;
            AgentVersion = agentVersion;
            AgentStatus = agentStatus;
            _rawData = rawData;
        }

        /// <summary> Azure VM resource ID. </summary>
        public ResourceIdentifier VmId { get; }
        /// <summary> Version of the NewRelic agent installed on the VM. </summary>
        public string AgentVersion { get; }
        /// <summary> Status of the NewRelic agent installed on the VM. </summary>
        public string AgentStatus { get; }
    }
}
