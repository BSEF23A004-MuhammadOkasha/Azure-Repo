// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Build service agent pool properties. </summary>
    public partial class BuildServiceAgentPoolProperties
    {
        /// <summary> Initializes a new instance of <see cref="BuildServiceAgentPoolProperties"/>. </summary>
        public BuildServiceAgentPoolProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BuildServiceAgentPoolProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning state of the build service agent pool. </param>
        /// <param name="poolSize"> build service agent pool size properties. </param>
        internal BuildServiceAgentPoolProperties(string provisioningState, BuildServiceAgentPoolSizeProperties poolSize)
        {
            ProvisioningState = provisioningState;
            PoolSize = poolSize;
        }

        /// <summary> Provisioning state of the build service agent pool. </summary>
        public string ProvisioningState { get; }
        /// <summary> build service agent pool size properties. </summary>
        public BuildServiceAgentPoolSizeProperties PoolSize { get; set; }
    }
}
