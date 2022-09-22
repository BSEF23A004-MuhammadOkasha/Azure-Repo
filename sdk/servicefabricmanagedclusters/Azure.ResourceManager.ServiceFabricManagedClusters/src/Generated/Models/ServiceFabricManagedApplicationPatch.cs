// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Application update request. </summary>
    public partial class ServiceFabricManagedApplicationPatch
    {
        /// <summary> Initializes a new instance of ServiceFabricManagedApplicationPatch. </summary>
        public ServiceFabricManagedApplicationPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Application update parameters. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
