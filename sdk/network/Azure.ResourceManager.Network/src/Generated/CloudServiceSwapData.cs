// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the CloudServiceSwap data model.
    /// SwapResource to represent slot type on the specified cloud service.
    /// </summary>
    public partial class CloudServiceSwapData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudServiceSwapData"/>. </summary>
        public CloudServiceSwapData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudServiceSwapData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Swap resource properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudServiceSwapData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CloudServiceSwapProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Swap resource properties. </summary>
        internal CloudServiceSwapProperties Properties { get; set; }
        /// <summary> Specifies slot info on a cloud service. </summary>
        public SwapSlotType? CloudServiceSwapSlotType
        {
            get => Properties is null ? default : Properties.SlotType;
            set
            {
                if (Properties is null)
                    Properties = new CloudServiceSwapProperties();
                Properties.SlotType = value;
            }
        }
    }
}
