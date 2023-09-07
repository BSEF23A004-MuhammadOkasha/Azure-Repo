// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> A private link resource. </summary>
    public partial class ManagedHsmPrivateLinkResourceData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedHsmPrivateLinkResourceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ManagedHsmPrivateLinkResourceData(AzureLocation location) : base(location)
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedHsmPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="groupId"> Group identifier of private link resource. </param>
        /// <param name="requiredMembers"> Required member names of private link resource. </param>
        /// <param name="requiredZoneNames"> Required DNS zone names of the the private link resource. </param>
        /// <param name="sku"> SKU details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedHsmPrivateLinkResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string groupId, IReadOnlyList<string> requiredMembers, IList<string> requiredZoneNames, ManagedHsmSku sku, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            Sku = sku;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedHsmPrivateLinkResourceData"/> for deserialization. </summary>
        internal ManagedHsmPrivateLinkResourceData()
        {
        }

        /// <summary> Group identifier of private link resource. </summary>
        public string GroupId { get; }
        /// <summary> Required member names of private link resource. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> Required DNS zone names of the the private link resource. </summary>
        public IList<string> RequiredZoneNames { get; }
        /// <summary> SKU details. </summary>
        public ManagedHsmSku Sku { get; set; }
    }
}
