// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes the connection monitor endpoint. </summary>
    public partial class ConnectionMonitorEndpoint
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorEndpoint"/>. </summary>
        /// <param name="name"> The name of the connection monitor endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ConnectionMonitorEndpoint(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorEndpoint"/>. </summary>
        /// <param name="name"> The name of the connection monitor endpoint. </param>
        /// <param name="endpointType"> The endpoint type. </param>
        /// <param name="resourceId"> Resource ID of the connection monitor endpoint. </param>
        /// <param name="address"> Address of the connection monitor endpoint (IP or domain name). </param>
        /// <param name="filter"> Filter for sub-items within the endpoint. </param>
        /// <param name="scope"> Endpoint scope. </param>
        /// <param name="coverageLevel"> Test coverage for the endpoint. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectionMonitorEndpoint(string name, ConnectionMonitorEndpointType? endpointType, ResourceIdentifier resourceId, string address, ConnectionMonitorEndpointFilter filter, ConnectionMonitorEndpointScope scope, CoverageLevel? coverageLevel, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            EndpointType = endpointType;
            ResourceId = resourceId;
            Address = address;
            Filter = filter;
            Scope = scope;
            CoverageLevel = coverageLevel;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorEndpoint"/> for deserialization. </summary>
        internal ConnectionMonitorEndpoint()
        {
        }

        /// <summary> The name of the connection monitor endpoint. </summary>
        public string Name { get; set; }
        /// <summary> The endpoint type. </summary>
        public ConnectionMonitorEndpointType? EndpointType { get; set; }
        /// <summary> Resource ID of the connection monitor endpoint. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> Address of the connection monitor endpoint (IP or domain name). </summary>
        public string Address { get; set; }
        /// <summary> Filter for sub-items within the endpoint. </summary>
        public ConnectionMonitorEndpointFilter Filter { get; set; }
        /// <summary> Endpoint scope. </summary>
        public ConnectionMonitorEndpointScope Scope { get; set; }
        /// <summary> Test coverage for the endpoint. </summary>
        public CoverageLevel? CoverageLevel { get; set; }
    }
}
