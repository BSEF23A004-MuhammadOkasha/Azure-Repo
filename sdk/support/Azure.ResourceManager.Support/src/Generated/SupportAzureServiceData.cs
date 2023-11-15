// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A class representing the SupportAzureService data model.
    /// Object that represents a Service resource.
    /// </summary>
    public partial class SupportAzureServiceData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SupportAzureServiceData"/>. </summary>
        internal SupportAzureServiceData()
        {
            ResourceTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SupportAzureServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Localized name of the Azure service. </param>
        /// <param name="resourceTypes"> ARM Resource types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SupportAzureServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, IReadOnlyList<string> resourceTypes, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            ResourceTypes = resourceTypes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Localized name of the Azure service. </summary>
        public string DisplayName { get; }
        /// <summary> ARM Resource types. </summary>
        public IReadOnlyList<string> ResourceTypes { get; }
    }
}
