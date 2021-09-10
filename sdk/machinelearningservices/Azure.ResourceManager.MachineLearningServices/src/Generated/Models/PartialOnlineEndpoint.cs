// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Mutable online endpoint configuration. </summary>
    public partial class PartialOnlineEndpoint
    {
        /// <summary> Initializes a new instance of PartialOnlineEndpoint. </summary>
        public PartialOnlineEndpoint()
        {
            Traffic = new ChangeTrackingDictionary<string, int>();
        }

        /// <summary> Percentage of traffic from endpoint to divert to each deployment. Traffic values need to sum to 100. </summary>
        public IDictionary<string, int> Traffic { get; set; }
    }
}
