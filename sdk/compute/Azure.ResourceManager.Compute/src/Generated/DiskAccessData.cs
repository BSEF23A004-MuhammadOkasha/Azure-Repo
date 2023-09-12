// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the DiskAccess data model.
    /// disk access resource.
    /// </summary>
    public partial class DiskAccessData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DiskAccessData"/>. </summary>
        /// <param name="location"> The location. </param>
        public DiskAccessData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<ComputePrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="DiskAccessData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location where the disk access will be created. Extended location cannot be changed. </param>
        /// <param name="privateEndpointConnections"> A readonly collection of private endpoint connections created on the disk. Currently only one endpoint connection is supported. </param>
        /// <param name="provisioningState"> The disk access resource provisioning state. </param>
        /// <param name="timeCreated"> The time when the disk access was created. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskAccessData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, IReadOnlyList<ComputePrivateEndpointConnectionData> privateEndpointConnections, string provisioningState, DateTimeOffset? timeCreated, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            TimeCreated = timeCreated;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DiskAccessData"/> for deserialization. </summary>
        internal DiskAccessData()
        {
        }

        /// <summary> The extended location where the disk access will be created. Extended location cannot be changed. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> A readonly collection of private endpoint connections created on the disk. Currently only one endpoint connection is supported. </summary>
        public IReadOnlyList<ComputePrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The disk access resource provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> The time when the disk access was created. </summary>
        public DateTimeOffset? TimeCreated { get; }
    }
}
