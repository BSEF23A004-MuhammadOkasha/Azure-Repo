// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Definition of which streams are sent to which destinations. </summary>
    public partial class DataFlow
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataFlow"/>. </summary>
        public DataFlow()
        {
            Streams = new ChangeTrackingList<DataFlowStream>();
            Destinations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DataFlow"/>. </summary>
        /// <param name="streams"> List of streams for this data flow. </param>
        /// <param name="destinations"> List of destinations for this data flow. </param>
        /// <param name="transformKql"> The KQL query to transform stream data. </param>
        /// <param name="outputStream"> The output stream of the transform. Only required if the transform changes data to a different stream. </param>
        /// <param name="builtInTransform"> The builtIn transform to transform stream data. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFlow(IList<DataFlowStream> streams, IList<string> destinations, string transformKql, string outputStream, string builtInTransform, Dictionary<string, BinaryData> rawData)
        {
            Streams = streams;
            Destinations = destinations;
            TransformKql = transformKql;
            OutputStream = outputStream;
            BuiltInTransform = builtInTransform;
            _rawData = rawData;
        }

        /// <summary> List of streams for this data flow. </summary>
        public IList<DataFlowStream> Streams { get; }
        /// <summary> List of destinations for this data flow. </summary>
        public IList<string> Destinations { get; }
        /// <summary> The KQL query to transform stream data. </summary>
        public string TransformKql { get; set; }
        /// <summary> The output stream of the transform. Only required if the transform changes data to a different stream. </summary>
        public string OutputStream { get; set; }
        /// <summary> The builtIn transform to transform stream data. </summary>
        public string BuiltInTransform { get; set; }
    }
}
