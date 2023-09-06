// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> NetApp account patch resource. </summary>
    public partial class NetAppAccountPatch : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetAppAccountPatch"/>. </summary>
        /// <param name="location"> The location. </param>
        public NetAppAccountPatch(AzureLocation location) : base(location)
        {
            ActiveDirectories = new ChangeTrackingList<NetAppAccountActiveDirectory>();
        }

        /// <summary> Initializes a new instance of <see cref="NetAppAccountPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity used for the resource. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        /// <param name="activeDirectories"> Active Directories. </param>
        /// <param name="encryption"> Encryption settings. </param>
        /// <param name="disableShowmount"> Shows the status of disableShowmount for all volumes under the subscription, null equals false. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppAccountPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string provisioningState, IList<NetAppAccountActiveDirectory> activeDirectories, NetAppAccountEncryption encryption, bool? disableShowmount, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            ActiveDirectories = activeDirectories;
            Encryption = encryption;
            DisableShowmount = disableShowmount;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppAccountPatch"/> for deserialization. </summary>
        internal NetAppAccountPatch()
        {
        }

        /// <summary> The identity used for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
        /// <summary> Active Directories. </summary>
        public IList<NetAppAccountActiveDirectory> ActiveDirectories { get; }
        /// <summary> Encryption settings. </summary>
        public NetAppAccountEncryption Encryption { get; set; }
        /// <summary> Shows the status of disableShowmount for all volumes under the subscription, null equals false. </summary>
        public bool? DisableShowmount { get; }
    }
}
