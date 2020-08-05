// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Synapse top-level resource. </summary>
    internal partial class Resource
    {
        /// <summary> Initializes a new instance of Resource. </summary>
        internal Resource()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The resource identifier. </summary>
        public string Id { get; }
        /// <summary> The resource name. </summary>
        public string Name { get; }
        /// <summary> The resource type. </summary>
        public string Type { get; }
        /// <summary> The resource location. </summary>
        public string Location { get; }
        /// <summary> The resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> Etag identifies change in the resource. </summary>
        public string ETag { get; }
    }
}
