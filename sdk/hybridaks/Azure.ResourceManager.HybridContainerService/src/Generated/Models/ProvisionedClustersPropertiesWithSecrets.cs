// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Properties of provisioned clusters that contain secrets. </summary>
    public partial class ProvisionedClustersPropertiesWithSecrets
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProvisionedClustersPropertiesWithSecrets"/>. </summary>
        public ProvisionedClustersPropertiesWithSecrets()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClustersPropertiesWithSecrets"/>. </summary>
        /// <param name="aadProfile"> AAD profile for the provisioned cluster. </param>
        /// <param name="windowsProfile"> WindowsProfile - Profile for Windows VMs in the Provisioned Cluster. </param>
        /// <param name="httpProxyConfig"> HttpProxyConfig - Configurations for provisioning the cluster with HTTP proxy servers. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProvisionedClustersPropertiesWithSecrets(AADProfile aadProfile, WindowsProfile windowsProfile, HttpProxyConfig httpProxyConfig, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AadProfile = aadProfile;
            WindowsProfile = windowsProfile;
            HttpProxyConfig = httpProxyConfig;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> AAD profile for the provisioned cluster. </summary>
        public AADProfile AadProfile { get; set; }
        /// <summary> WindowsProfile - Profile for Windows VMs in the Provisioned Cluster. </summary>
        public WindowsProfile WindowsProfile { get; set; }
        /// <summary> HttpProxyConfig - Configurations for provisioning the cluster with HTTP proxy servers. </summary>
        public HttpProxyConfig HttpProxyConfig { get; set; }
    }
}
