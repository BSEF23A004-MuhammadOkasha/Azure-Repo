// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines modifiable attributes of a Profile. </summary>
    public partial class FrontDoorNetworkExperimentProfilePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FrontDoorNetworkExperimentProfilePatch"/>. </summary>
        public FrontDoorNetworkExperimentProfilePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorNetworkExperimentProfilePatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="enabledState"> The enabled state of the Profile. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorNetworkExperimentProfilePatch(IDictionary<string, string> tags, FrontDoorExperimentState? enabledState, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            EnabledState = enabledState;
            _rawData = rawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The enabled state of the Profile. </summary>
        public FrontDoorExperimentState? EnabledState { get; set; }
    }
}
