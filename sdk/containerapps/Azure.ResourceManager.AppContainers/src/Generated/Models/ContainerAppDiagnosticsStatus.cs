// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Rendering details of a diagnostics table. </summary>
    public partial class ContainerAppDiagnosticsStatus
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppDiagnosticsStatus"/>. </summary>
        public ContainerAppDiagnosticsStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppDiagnosticsStatus"/>. </summary>
        /// <param name="message"> Diagnostic message. </param>
        /// <param name="statusId"> Status. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppDiagnosticsStatus(string message, int? statusId, Dictionary<string, BinaryData> rawData)
        {
            Message = message;
            StatusId = statusId;
            _rawData = rawData;
        }

        /// <summary> Diagnostic message. </summary>
        public string Message { get; set; }
        /// <summary> Status. </summary>
        public int? StatusId { get; set; }
    }
}
