// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network Manager Deployment Status. </summary>
    public partial class NetworkManagerDeploymentStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkManagerDeploymentStatus"/>. </summary>
        internal NetworkManagerDeploymentStatus()
        {
            ConfigurationIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkManagerDeploymentStatus"/>. </summary>
        /// <param name="commitOn"> Commit Time. </param>
        /// <param name="region"> Region Name. </param>
        /// <param name="deploymentState"> Deployment Status. </param>
        /// <param name="configurationIds"> List of configuration ids. </param>
        /// <param name="deploymentType"> Configuration Deployment Type. </param>
        /// <param name="errorMessage"> Error Message. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkManagerDeploymentStatus(DateTimeOffset? commitOn, string region, NetworkManagerDeploymentState? deploymentState, IReadOnlyList<string> configurationIds, NetworkConfigurationDeploymentType? deploymentType, string errorMessage, Dictionary<string, BinaryData> rawData)
        {
            CommitOn = commitOn;
            Region = region;
            DeploymentState = deploymentState;
            ConfigurationIds = configurationIds;
            DeploymentType = deploymentType;
            ErrorMessage = errorMessage;
            _rawData = rawData;
        }

        /// <summary> Commit Time. </summary>
        public DateTimeOffset? CommitOn { get; }
        /// <summary> Region Name. </summary>
        public string Region { get; }
        /// <summary> Deployment Status. </summary>
        public NetworkManagerDeploymentState? DeploymentState { get; }
        /// <summary> List of configuration ids. </summary>
        public IReadOnlyList<string> ConfigurationIds { get; }
        /// <summary> Configuration Deployment Type. </summary>
        public NetworkConfigurationDeploymentType? DeploymentType { get; }
        /// <summary> Error Message. </summary>
        public string ErrorMessage { get; }
    }
}
