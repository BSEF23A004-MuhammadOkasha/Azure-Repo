// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> Data struct to contain only C section with custom fields. </summary>
#pragma warning disable AZC0012 // Avoid single word type names
    public partial class Base
#pragma warning restore AZC0012 // Avoid single word type names
    {
        /// <summary> Initializes a new instance of Base. </summary>
        public Base()
        {
        }

        /// <summary> Name of item (B section) if any. If telemetry data is derived straight from this, this should be null. </summary>
        public string BaseType { get; set; }
        /// <summary> The data payload for the telemetry request. </summary>
        public Domain BaseData { get; set; }
    }
}
