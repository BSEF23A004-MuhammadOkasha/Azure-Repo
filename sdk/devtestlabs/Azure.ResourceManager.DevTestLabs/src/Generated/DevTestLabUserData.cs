// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing the DevTestLabUser data model.
    /// Profile of a lab user.
    /// </summary>
    public partial class DevTestLabUserData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabUserData"/>. </summary>
        /// <param name="location"> The location. </param>
        public DevTestLabUserData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabUserData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity of the user. </param>
        /// <param name="secretStore"> The secret store of the user. </param>
        /// <param name="createdOn"> The creation date of the user profile. </param>
        /// <param name="provisioningState"> The provisioning status of the resource. </param>
        /// <param name="uniqueIdentifier"> The unique immutable identifier of a resource (Guid). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabUserData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DevTestLabUserIdentity identity, DevTestLabUserSecretStore secretStore, DateTimeOffset? createdOn, string provisioningState, Guid? uniqueIdentifier, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            SecretStore = secretStore;
            CreatedOn = createdOn;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabUserData"/> for deserialization. </summary>
        internal DevTestLabUserData()
        {
        }

        /// <summary> The identity of the user. </summary>
        public DevTestLabUserIdentity Identity { get; set; }
        /// <summary> The secret store of the user. </summary>
        public DevTestLabUserSecretStore SecretStore { get; set; }
        /// <summary> The creation date of the user profile. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The provisioning status of the resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> The unique immutable identifier of a resource (Guid). </summary>
        public Guid? UniqueIdentifier { get; }
    }
}
