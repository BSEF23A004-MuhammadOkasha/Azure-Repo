// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing the BlobInventoryPolicy data model. </summary>
    public partial class BlobInventoryPolicyData : Resource
    {
        /// <summary> Initializes a new instance of BlobInventoryPolicyData. </summary>
        public BlobInventoryPolicyData()
        {
        }

        /// <summary> Initializes a new instance of BlobInventoryPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="lastModifiedTime"> Returns the last modified date and time of the blob inventory policy. </param>
        /// <param name="policy"> The storage account blob inventory policy object. It is composed of policy rules. </param>
        internal BlobInventoryPolicyData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, DateTimeOffset? lastModifiedTime, BlobInventoryPolicySchema policy) : base(id, name, type)
        {
            SystemData = systemData;
            LastModifiedTime = lastModifiedTime;
            Policy = policy;
        }

        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
        /// <summary> Returns the last modified date and time of the blob inventory policy. </summary>
        public DateTimeOffset? LastModifiedTime { get; }
        /// <summary> The storage account blob inventory policy object. It is composed of policy rules. </summary>
        public BlobInventoryPolicySchema Policy { get; set; }
    }
}
