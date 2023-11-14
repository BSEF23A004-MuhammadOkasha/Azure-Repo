// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Request from client to check resource name availability. </summary>
    public partial class MySqlFlexibleServerNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Resource name to verify. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public MySqlFlexibleServerNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Resource name to verify. </param>
        /// <param name="resourceType"> Resource type used for verification. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerNameAvailabilityContent(string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerNameAvailabilityContent"/> for deserialization. </summary>
        internal MySqlFlexibleServerNameAvailabilityContent()
        {
        }

        /// <summary> Resource name to verify. </summary>
        public string Name { get; }
        /// <summary> Resource type used for verification. </summary>
        public ResourceType? ResourceType { get; set; }
    }
}
