// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing the DevCenterEnvironmentType data model.
    /// Represents an environment type.
    /// </summary>
    public partial class DevCenterEnvironmentTypeData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevCenterEnvironmentTypeData"/>. </summary>
        public DevCenterEnvironmentTypeData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterEnvironmentTypeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevCenterEnvironmentTypeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, DevCenterProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Tags = tags;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public DevCenterProvisioningState? ProvisioningState { get; }
    }
}
