// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Binary read settings. </summary>
    public partial class BinaryReadSettings : FormatReadSettings
    {
        /// <summary> Initializes a new instance of BinaryReadSettings. </summary>
        public BinaryReadSettings()
        {
            Type = "BinaryReadSettings";
        }

        /// <summary> Initializes a new instance of BinaryReadSettings. </summary>
        /// <param name="type"> The read setting type. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="compressionProperties"> Compression settings. </param>
        internal BinaryReadSettings(string type, IDictionary<string, object> additionalProperties, CompressionReadSettings compressionProperties) : base(type, additionalProperties)
        {
            CompressionProperties = compressionProperties;
            Type = type ?? "BinaryReadSettings";
        }

        /// <summary> Compression settings. </summary>
        public CompressionReadSettings CompressionProperties { get; set; }
    }
}
