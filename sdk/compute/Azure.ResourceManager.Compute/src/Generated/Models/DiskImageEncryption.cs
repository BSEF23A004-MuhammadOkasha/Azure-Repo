// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the disk image encryption base class. </summary>
    public partial class DiskImageEncryption
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DiskImageEncryption"/>. </summary>
        public DiskImageEncryption()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DiskImageEncryption"/>. </summary>
        /// <param name="diskEncryptionSetId"> A relative URI containing the resource ID of the disk encryption set. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskImageEncryption(ResourceIdentifier diskEncryptionSetId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskEncryptionSetId = diskEncryptionSetId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A relative URI containing the resource ID of the disk encryption set. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; set; }
    }
}
