// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.ContainerService.NewKubernetesVersionAvailable event. </summary>
    public partial class ContainerServiceNewKubernetesVersionAvailableEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceNewKubernetesVersionAvailableEventData"/>. </summary>
        internal ContainerServiceNewKubernetesVersionAvailableEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceNewKubernetesVersionAvailableEventData"/>. </summary>
        /// <param name="latestSupportedKubernetesVersion"> The highest PATCH Kubernetes version for the highest MINOR version supported by ManagedCluster resource. </param>
        /// <param name="latestStableKubernetesVersion"> The highest PATCH Kubernetes version for the MINOR version considered stable for the ManagedCluster resource. </param>
        /// <param name="lowestMinorKubernetesVersion"> The highest PATCH Kubernetes version for the lowest applicable MINOR version available for the ManagedCluster resource. </param>
        /// <param name="latestPreviewKubernetesVersion"> The highest PATCH Kubernetes version considered preview for the ManagedCluster resource. There might not be any version in preview at the time of publishing the event. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceNewKubernetesVersionAvailableEventData(string latestSupportedKubernetesVersion, string latestStableKubernetesVersion, string lowestMinorKubernetesVersion, string latestPreviewKubernetesVersion, Dictionary<string, BinaryData> rawData)
        {
            LatestSupportedKubernetesVersion = latestSupportedKubernetesVersion;
            LatestStableKubernetesVersion = latestStableKubernetesVersion;
            LowestMinorKubernetesVersion = lowestMinorKubernetesVersion;
            LatestPreviewKubernetesVersion = latestPreviewKubernetesVersion;
            _rawData = rawData;
        }

        /// <summary> The highest PATCH Kubernetes version for the highest MINOR version supported by ManagedCluster resource. </summary>
        public string LatestSupportedKubernetesVersion { get; }
        /// <summary> The highest PATCH Kubernetes version for the MINOR version considered stable for the ManagedCluster resource. </summary>
        public string LatestStableKubernetesVersion { get; }
        /// <summary> The highest PATCH Kubernetes version for the lowest applicable MINOR version available for the ManagedCluster resource. </summary>
        public string LowestMinorKubernetesVersion { get; }
        /// <summary> The highest PATCH Kubernetes version considered preview for the ManagedCluster resource. There might not be any version in preview at the time of publishing the event. </summary>
        public string LatestPreviewKubernetesVersion { get; }
    }
}
