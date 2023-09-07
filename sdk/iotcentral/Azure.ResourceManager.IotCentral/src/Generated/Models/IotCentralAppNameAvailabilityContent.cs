// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> Input values. </summary>
    public partial class IotCentralAppNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotCentralAppNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name of the IoT Central application instance to check. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public IotCentralAppNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="IotCentralAppNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name of the IoT Central application instance to check. </param>
        /// <param name="resourceType"> The type of the IoT Central resource to query. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotCentralAppNameAvailabilityContent(string name, string resourceType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotCentralAppNameAvailabilityContent"/> for deserialization. </summary>
        internal IotCentralAppNameAvailabilityContent()
        {
        }

        /// <summary> The name of the IoT Central application instance to check. </summary>
        public string Name { get; }
        /// <summary> The type of the IoT Central resource to query. </summary>
        public string ResourceType { get; set; }
    }
}
