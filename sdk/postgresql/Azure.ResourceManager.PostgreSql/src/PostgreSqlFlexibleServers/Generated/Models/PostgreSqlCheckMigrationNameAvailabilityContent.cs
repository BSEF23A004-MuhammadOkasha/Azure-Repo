// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Represents a migration name's availability. </summary>
    public partial class PostgreSqlCheckMigrationNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlCheckMigrationNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The resource name to verify. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PostgreSqlCheckMigrationNameAvailabilityContent(string name, ResourceType resourceType)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlCheckMigrationNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The resource name to verify. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="isNameAvailable"> Indicates whether the resource name is available. </param>
        /// <param name="reason"> Migration name availability reason. </param>
        /// <param name="message"> Migration name availability message. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlCheckMigrationNameAvailabilityContent(string name, ResourceType resourceType, bool? isNameAvailable, PostgreSqlMigrationNameUnavailableReason? reason, string message, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ResourceType = resourceType;
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlCheckMigrationNameAvailabilityContent"/> for deserialization. </summary>
        internal PostgreSqlCheckMigrationNameAvailabilityContent()
        {
        }

        /// <summary> The resource name to verify. </summary>
        public string Name { get; set; }
        /// <summary> The type of the resource. </summary>
        public ResourceType ResourceType { get; set; }
        /// <summary> Indicates whether the resource name is available. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> Migration name availability reason. </summary>
        public PostgreSqlMigrationNameUnavailableReason? Reason { get; }
        /// <summary> Migration name availability message. </summary>
        public string Message { get; }
    }
}
