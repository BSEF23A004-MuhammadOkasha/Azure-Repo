// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Contains all settings for the cluster. </summary>
    public partial class ClusterQuotaConfigurationProperties
    {
        /// <summary> Initializes a new instance of ClusterQuotaConfigurationProperties. </summary>
        public ClusterQuotaConfigurationProperties()
        {
            Settings = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ClusterQuotaConfigurationProperties. </summary>
        /// <param name="settings"> All possible Cluster settings - a collection of key/value paired settings which apply to quotas and configurations imposed on the cluster. </param>
        internal ClusterQuotaConfigurationProperties(IDictionary<string, string> settings)
        {
            Settings = settings;
        }

        /// <summary> All possible Cluster settings - a collection of key/value paired settings which apply to quotas and configurations imposed on the cluster. </summary>
        public IDictionary<string, string> Settings { get; }
    }
}
