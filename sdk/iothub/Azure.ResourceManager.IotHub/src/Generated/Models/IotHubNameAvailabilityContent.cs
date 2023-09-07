// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Input values. </summary>
    public partial class IotHubNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotHubNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name of the IoT hub to check. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public IotHubNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name of the IoT hub to check. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubNameAvailabilityContent(string name, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubNameAvailabilityContent"/> for deserialization. </summary>
        internal IotHubNameAvailabilityContent()
        {
        }

        /// <summary> The name of the IoT hub to check. </summary>
        public string Name { get; }
    }
}
