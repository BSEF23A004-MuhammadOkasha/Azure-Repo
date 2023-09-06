// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of common properties of cluster support events. </summary>
    public partial class ContainerServiceClusterSupportEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceClusterSupportEventData"/>. </summary>
        internal ContainerServiceClusterSupportEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceClusterSupportEventData"/>. </summary>
        /// <param name="kubernetesVersion"> The Kubernetes version of the ManagedCluster resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceClusterSupportEventData(string kubernetesVersion, Dictionary<string, BinaryData> rawData)
        {
            KubernetesVersion = kubernetesVersion;
            _rawData = rawData;
        }

        /// <summary> The Kubernetes version of the ManagedCluster resource. </summary>
        public string KubernetesVersion { get; }
    }
}
