// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> A data connection check name availability request. </summary>
    public partial class KustoDataConnectionNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KustoDataConnectionNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Data Connection name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public KustoDataConnectionNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = KustoDataConnectionType.MicrosoftKustoClustersDatabasesDataConnections;
        }

        /// <summary> Initializes a new instance of <see cref="KustoDataConnectionNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Data Connection name. </param>
        /// <param name="resourceType"> The type of resource, Microsoft.Kusto/clusters/databases/dataConnections. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoDataConnectionNameAvailabilityContent(string name, KustoDataConnectionType resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KustoDataConnectionNameAvailabilityContent"/> for deserialization. </summary>
        internal KustoDataConnectionNameAvailabilityContent()
        {
        }

        /// <summary> Data Connection name. </summary>
        public string Name { get; }
        /// <summary> The type of resource, Microsoft.Kusto/clusters/databases/dataConnections. </summary>
        public KustoDataConnectionType ResourceType { get; }
    }
}
