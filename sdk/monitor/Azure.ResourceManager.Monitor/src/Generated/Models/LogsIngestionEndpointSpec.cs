// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Definition of the endpoint used for ingesting logs. </summary>
    internal partial class LogsIngestionEndpointSpec
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogsIngestionEndpointSpec"/>. </summary>
        public LogsIngestionEndpointSpec()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogsIngestionEndpointSpec"/>. </summary>
        /// <param name="endpoint"> The endpoint. This property is READ-ONLY. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogsIngestionEndpointSpec(string endpoint, Dictionary<string, BinaryData> rawData)
        {
            Endpoint = endpoint;
            _rawData = rawData;
        }

        /// <summary> The endpoint. This property is READ-ONLY. </summary>
        public string Endpoint { get; }
    }
}
