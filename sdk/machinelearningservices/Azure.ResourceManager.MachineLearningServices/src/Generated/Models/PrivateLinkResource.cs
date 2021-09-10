// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> A private link resource. </summary>
    public partial class PrivateLinkResource : Resource
    {
        /// <summary> Initializes a new instance of PrivateLinkResource. </summary>
        public PrivateLinkResource()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PrivateLinkResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="location"> Specifies the location of the resource. </param>
        /// <param name="tags"> Contains resource tags defined as key/value pairs. </param>
        /// <param name="sku"> The sku of the workspace. </param>
        /// <param name="systemData"> System data. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource Private link DNS zone name. </param>
        internal PrivateLinkResource(ResourceIdentifier id, string name, ResourceType type, Identity identity, string location, IDictionary<string, string> tags, Sku sku, SystemData systemData, string groupId, IReadOnlyList<string> requiredMembers, IList<string> requiredZoneNames) : base(id, name, type)
        {
            Identity = identity;
            Location = location;
            Tags = tags;
            Sku = sku;
            SystemData = systemData;
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> The identity of the resource. </summary>
        public Identity Identity { get; set; }
        /// <summary> Specifies the location of the resource. </summary>
        public string Location { get; set; }
        /// <summary> Contains resource tags defined as key/value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The sku of the workspace. </summary>
        public Sku Sku { get; set; }
        /// <summary> System data. </summary>
        public SystemData SystemData { get; }
        /// <summary> The private link resource group id. </summary>
        public string GroupId { get; }
        /// <summary> The private link resource required member names. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The private link resource Private link DNS zone name. </summary>
        public IList<string> RequiredZoneNames { get; }
    }
}
