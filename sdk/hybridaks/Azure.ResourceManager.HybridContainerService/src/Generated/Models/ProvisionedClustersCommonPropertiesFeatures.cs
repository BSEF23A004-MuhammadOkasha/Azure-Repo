// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Additional features specs like Arc Agent Onboarding. </summary>
    internal partial class ProvisionedClustersCommonPropertiesFeatures
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProvisionedClustersCommonPropertiesFeatures"/>. </summary>
        public ProvisionedClustersCommonPropertiesFeatures()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClustersCommonPropertiesFeatures"/>. </summary>
        /// <param name="arcAgentProfile"> Arc agentry configuration for the provisioned cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProvisionedClustersCommonPropertiesFeatures(ArcAgentProfile arcAgentProfile, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ArcAgentProfile = arcAgentProfile;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Arc agentry configuration for the provisioned cluster. </summary>
        public ArcAgentProfile ArcAgentProfile { get; set; }
    }
}
