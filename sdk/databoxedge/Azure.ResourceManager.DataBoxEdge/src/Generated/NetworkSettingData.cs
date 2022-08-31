// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary> A class representing the NetworkSetting data model. </summary>
    public partial class NetworkSettingData : ResourceData
    {
        /// <summary> Initializes a new instance of NetworkSettingData. </summary>
        public NetworkSettingData()
        {
            NetworkAdapters = new ChangeTrackingList<NetworkAdapter>();
        }

        /// <summary> Initializes a new instance of NetworkSettingData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="networkAdapters"> The network adapter list on the device. </param>
        internal NetworkSettingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyList<NetworkAdapter> networkAdapters) : base(id, name, resourceType, systemData)
        {
            NetworkAdapters = networkAdapters;
        }

        /// <summary> The network adapter list on the device. </summary>
        public IReadOnlyList<NetworkAdapter> NetworkAdapters { get; }
    }
}
