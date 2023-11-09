// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> Data struct to contain only C section with custom fields. </summary>
    internal partial class MonitorBase
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MonitorBase"/>. </summary>
        public MonitorBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MonitorBase"/>. </summary>
        /// <param name="baseType"> Name of item (B section) if any. If telemetry data is derived straight from this, this should be null. </param>
        /// <param name="baseData"> The data payload for the telemetry request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorBase(string baseType, MonitorDomain baseData, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BaseType = baseType;
            BaseData = baseData;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of item (B section) if any. If telemetry data is derived straight from this, this should be null. </summary>
        public string BaseType { get; set; }
        /// <summary> The data payload for the telemetry request. </summary>
        public MonitorDomain BaseData { get; set; }
    }
}
