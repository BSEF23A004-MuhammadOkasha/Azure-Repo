// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.LoadTesting.Models
{
    /// <summary> Details about the connection between the Batch service and the endpoint. </summary>
    public partial class LoadTestingEndpointDetail
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LoadTestingEndpointDetail"/>. </summary>
        internal LoadTestingEndpointDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LoadTestingEndpointDetail"/>. </summary>
        /// <param name="port"> The port an endpoint is connected to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LoadTestingEndpointDetail(int? port, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Port = port;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The port an endpoint is connected to. </summary>
        public int? Port { get; }
    }
}
