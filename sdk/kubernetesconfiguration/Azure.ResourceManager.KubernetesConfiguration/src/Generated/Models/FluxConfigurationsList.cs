// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KubernetesConfiguration;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Result of the request to list Flux Configurations.  It contains a list of FluxConfiguration objects and a URL link to get the next set of results. </summary>
    internal partial class FluxConfigurationsList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FluxConfigurationsList"/>. </summary>
        internal FluxConfigurationsList()
        {
            Value = new ChangeTrackingList<KubernetesFluxConfigurationData>();
        }

        /// <summary> Initializes a new instance of <see cref="FluxConfigurationsList"/>. </summary>
        /// <param name="value"> List of Flux Configurations within a Kubernetes cluster. </param>
        /// <param name="nextLink"> URL to get the next set of configuration objects, if any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FluxConfigurationsList(IReadOnlyList<KubernetesFluxConfigurationData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of Flux Configurations within a Kubernetes cluster. </summary>
        public IReadOnlyList<KubernetesFluxConfigurationData> Value { get; }
        /// <summary> URL to get the next set of configuration objects, if any. </summary>
        public string NextLink { get; }
    }
}
