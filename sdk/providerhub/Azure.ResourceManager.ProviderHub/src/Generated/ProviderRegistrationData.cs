// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary> A class representing the ProviderRegistration data model. </summary>
    public partial class ProviderRegistrationData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProviderRegistrationData"/>. </summary>
        public ProviderRegistrationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProviderRegistrationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProviderRegistrationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ProviderRegistrationProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the properties. </summary>
        public ProviderRegistrationProperties Properties { get; set; }
    }
}
