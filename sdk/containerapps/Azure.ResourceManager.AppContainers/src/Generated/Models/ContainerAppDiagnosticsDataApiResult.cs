// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Diagnostics data returned from a detector. </summary>
    public partial class ContainerAppDiagnosticsDataApiResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppDiagnosticsDataApiResult"/>. </summary>
        public ContainerAppDiagnosticsDataApiResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppDiagnosticsDataApiResult"/>. </summary>
        /// <param name="table"> Table response. </param>
        /// <param name="renderingProperties"> Details of the table response. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppDiagnosticsDataApiResult(ContainerAppDiagnosticDataTableResult table, ContainerAppDiagnosticRendering renderingProperties, Dictionary<string, BinaryData> rawData)
        {
            Table = table;
            RenderingProperties = renderingProperties;
            _rawData = rawData;
        }

        /// <summary> Table response. </summary>
        public ContainerAppDiagnosticDataTableResult Table { get; set; }
        /// <summary> Details of the table response. </summary>
        public ContainerAppDiagnosticRendering RenderingProperties { get; set; }
    }
}
