// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> HybridAKSNodePoolStatus defines the observed state of HybridAKSNodePool. </summary>
    public partial class AgentPoolProvisioningStatusStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AgentPoolProvisioningStatusStatus"/>. </summary>
        public AgentPoolProvisioningStatusStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AgentPoolProvisioningStatusStatus"/>. </summary>
        /// <param name="errorMessage"> ErrorMessage - Error messages during creation of cluster. </param>
        /// <param name="provisioningStatus"> Contains Provisioning errors. </param>
        /// <param name="readyReplicas"> Total number of ready machines targeted by this deployment. </param>
        /// <param name="replicas"> Total number of non-terminated machines targeted by this deployment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AgentPoolProvisioningStatusStatus(string errorMessage, AgentPoolProvisioningStatusStatusProvisioningStatus provisioningStatus, int? readyReplicas, int? replicas, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ErrorMessage = errorMessage;
            ProvisioningStatus = provisioningStatus;
            ReadyReplicas = readyReplicas;
            Replicas = replicas;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ErrorMessage - Error messages during creation of cluster. </summary>
        public string ErrorMessage { get; set; }
        /// <summary> Contains Provisioning errors. </summary>
        public AgentPoolProvisioningStatusStatusProvisioningStatus ProvisioningStatus { get; set; }
        /// <summary> Total number of ready machines targeted by this deployment. </summary>
        public int? ReadyReplicas { get; set; }
        /// <summary> Total number of non-terminated machines targeted by this deployment. </summary>
        public int? Replicas { get; set; }
    }
}
