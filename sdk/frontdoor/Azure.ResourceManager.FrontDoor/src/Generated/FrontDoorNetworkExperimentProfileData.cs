// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary>
    /// A class representing the FrontDoorNetworkExperimentProfile data model.
    /// Defines an Network Experiment Profile and lists of Experiments
    /// </summary>
    public partial class FrontDoorNetworkExperimentProfileData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FrontDoorNetworkExperimentProfileData"/>. </summary>
        /// <param name="location"> The location. </param>
        public FrontDoorNetworkExperimentProfileData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorNetworkExperimentProfileData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> Gets a unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceState"> Resource status. </param>
        /// <param name="enabledState"> The state of the Experiment. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorNetworkExperimentProfileData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, NetworkExperimentResourceState? resourceState, FrontDoorExperimentState? enabledState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            ResourceState = resourceState;
            EnabledState = enabledState;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorNetworkExperimentProfileData"/> for deserialization. </summary>
        internal FrontDoorNetworkExperimentProfileData()
        {
        }

        /// <summary> Gets a unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Resource status. </summary>
        public NetworkExperimentResourceState? ResourceState { get; }
        /// <summary> The state of the Experiment. </summary>
        public FrontDoorExperimentState? EnabledState { get; set; }
    }
}
