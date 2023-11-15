// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Addon configurations. </summary>
    public partial class AddonProfiles
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AddonProfiles"/>. </summary>
        public AddonProfiles()
        {
            Config = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AddonProfiles"/>. </summary>
        /// <param name="config"> Config - Key-value pairs for configuring an add-on. </param>
        /// <param name="enabled"> Enabled - Whether the add-on is enabled or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AddonProfiles(IDictionary<string, string> config, bool? enabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Config = config;
            Enabled = enabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Config - Key-value pairs for configuring an add-on. </summary>
        public IDictionary<string, string> Config { get; }
        /// <summary> Enabled - Whether the add-on is enabled or not. </summary>
        public bool? Enabled { get; set; }
    }
}
