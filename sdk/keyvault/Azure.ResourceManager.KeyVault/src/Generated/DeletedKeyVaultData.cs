// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary>
    /// A class representing the DeletedKeyVault data model.
    /// Deleted vault information with extended details.
    /// </summary>
    public partial class DeletedKeyVaultData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeletedKeyVaultData"/>. </summary>
        internal DeletedKeyVaultData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeletedKeyVaultData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeletedKeyVaultData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DeletedKeyVaultProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Properties of the vault. </summary>
        public DeletedKeyVaultProperties Properties { get; }
    }
}
