// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The parameters used to check the availability of the managed hsm name. </summary>
    public partial class ManagedHsmNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedHsmNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The managed hsm name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ManagedHsmNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedHsmNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The managed hsm name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedHsmNameAvailabilityContent(string name, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedHsmNameAvailabilityContent"/> for deserialization. </summary>
        internal ManagedHsmNameAvailabilityContent()
        {
        }

        /// <summary> The managed hsm name. </summary>
        public string Name { get; }
    }
}
