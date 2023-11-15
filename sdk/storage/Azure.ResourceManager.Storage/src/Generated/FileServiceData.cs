// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary>
    /// A class representing the FileService data model.
    /// The properties of File services in storage account.
    /// </summary>
    public partial class FileServiceData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FileServiceData"/>. </summary>
        public FileServiceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FileServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> Sku name and tier. </param>
        /// <param name="cors"> Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the File service. </param>
        /// <param name="shareDeleteRetentionPolicy"> The file service properties for share soft delete. </param>
        /// <param name="protocolSettings"> Protocol settings for file service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FileServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, StorageSku sku, StorageCorsRules cors, DeleteRetentionPolicy shareDeleteRetentionPolicy, ProtocolSettings protocolSettings, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            Cors = cors;
            ShareDeleteRetentionPolicy = shareDeleteRetentionPolicy;
            ProtocolSettings = protocolSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Sku name and tier. </summary>
        public StorageSku Sku { get; }
        /// <summary> Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the File service. </summary>
        internal StorageCorsRules Cors { get; set; }
        /// <summary> The List of CORS rules. You can include up to five CorsRule elements in the request. </summary>
        public IList<StorageCorsRule> CorsRules
        {
            get
            {
                if (Cors is null)
                    Cors = new StorageCorsRules();
                return Cors.CorsRules;
            }
        }

        /// <summary> The file service properties for share soft delete. </summary>
        public DeleteRetentionPolicy ShareDeleteRetentionPolicy { get; set; }
        /// <summary> Protocol settings for file service. </summary>
        internal ProtocolSettings ProtocolSettings { get; set; }
        /// <summary> Setting for SMB protocol. </summary>
        public SmbSetting ProtocolSmbSetting
        {
            get => ProtocolSettings is null ? default : ProtocolSettings.SmbSetting;
            set
            {
                if (ProtocolSettings is null)
                    ProtocolSettings = new ProtocolSettings();
                ProtocolSettings.SmbSetting = value;
            }
        }
    }
}
