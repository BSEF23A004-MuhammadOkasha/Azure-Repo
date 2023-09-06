// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> The check availability request body. </summary>
    public partial class PostgreSqlFlexibleServerNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name of the resource for which availability needs to be checked. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PostgreSqlFlexibleServerNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name of the resource for which availability needs to be checked. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerNameAvailabilityContent(string name, ResourceType? resourceType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerNameAvailabilityContent"/> for deserialization. </summary>
        internal PostgreSqlFlexibleServerNameAvailabilityContent()
        {
        }

        /// <summary> The name of the resource for which availability needs to be checked. </summary>
        public string Name { get; }
        /// <summary> The resource type. </summary>
        public ResourceType? ResourceType { get; set; }
    }
}
