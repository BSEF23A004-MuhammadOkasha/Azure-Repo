// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.DigitalTwins.Core
{
    /// <summary> A route which directs notification and telemetry events to an endpoint. Endpoints are a destination outside of Azure Digital Twins such as an EventHub. </summary>
    public partial class DigitalTwinsEventRoute
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsEventRoute"/>. </summary>
        /// <param name="endpointName"> The name of the endpoint this event route is bound to. </param>
        /// <param name="filter"> An expression which describes the events which are routed to the endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="filter"/> is null. </exception>
        public DigitalTwinsEventRoute(string endpointName, string filter)
        {
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(filter, nameof(filter));

            EndpointName = endpointName;
            Filter = filter;
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsEventRoute"/>. </summary>
        /// <param name="id"> The id of the event route. </param>
        /// <param name="endpointName"> The name of the endpoint this event route is bound to. </param>
        /// <param name="filter"> An expression which describes the events which are routed to the endpoint. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DigitalTwinsEventRoute(string id, string endpointName, string filter, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            EndpointName = endpointName;
            Filter = filter;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsEventRoute"/> for deserialization. </summary>
        internal DigitalTwinsEventRoute()
        {
        }

        /// <summary> The id of the event route. </summary>
        public string Id { get; }
        /// <summary> The name of the endpoint this event route is bound to. </summary>
        public string EndpointName { get; set; }
        /// <summary> An expression which describes the events which are routed to the endpoint. </summary>
        public string Filter { get; set; }
    }
}
