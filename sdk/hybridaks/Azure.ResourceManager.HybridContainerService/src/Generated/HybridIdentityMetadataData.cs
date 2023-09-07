// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary>
    /// A class representing the HybridIdentityMetadata data model.
    /// Defines the hybridIdentityMetadata.
    /// </summary>
    public partial class HybridIdentityMetadataData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HybridIdentityMetadataData"/>. </summary>
        public HybridIdentityMetadataData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HybridIdentityMetadataData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="resourceUid"> Unique id of the parent provisioned cluster resource. </param>
        /// <param name="publicKey"> Onboarding public key for provisioning the Managed identity for the HybridAKS cluster. </param>
        /// <param name="identity"> The identity of the provisioned cluster. Current supported identity types: None, SystemAssigned. </param>
        /// <param name="provisioningState"> provisioning state of the hybridIdentityMetadata resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HybridIdentityMetadataData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string resourceUid, string publicKey, ManagedServiceIdentity identity, string provisioningState, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ResourceUid = resourceUid;
            PublicKey = publicKey;
            Identity = identity;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Unique id of the parent provisioned cluster resource. </summary>
        public string ResourceUid { get; set; }
        /// <summary> Onboarding public key for provisioning the Managed identity for the HybridAKS cluster. </summary>
        public string PublicKey { get; set; }
        /// <summary> The identity of the provisioned cluster. Current supported identity types: None, SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> provisioning state of the hybridIdentityMetadata resource. </summary>
        public string ProvisioningState { get; }
    }
}
