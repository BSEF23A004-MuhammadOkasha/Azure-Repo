// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtectionBackup
{
    /// <summary>
    /// A class representing the ResourceGuardProxyBaseResource data model.
    /// ResourceGuardProxyBaseResource object, used for response and request bodies for ResourceGuardProxy APIs
    /// </summary>
    public partial class ResourceGuardProxyBaseResourceData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceGuardProxyBaseResourceData"/>. </summary>
        public ResourceGuardProxyBaseResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceGuardProxyBaseResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> ResourceGuardProxyBaseResource properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceGuardProxyBaseResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceGuardProxyBase properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> ResourceGuardProxyBaseResource properties. </summary>
        public ResourceGuardProxyBase Properties { get; set; }
    }
}
