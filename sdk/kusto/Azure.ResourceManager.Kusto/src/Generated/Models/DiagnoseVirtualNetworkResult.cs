// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The DiagnoseVirtualNetworkResult. </summary>
    public partial class DiagnoseVirtualNetworkResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DiagnoseVirtualNetworkResult"/>. </summary>
        internal DiagnoseVirtualNetworkResult()
        {
            Findings = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DiagnoseVirtualNetworkResult"/>. </summary>
        /// <param name="findings"> The list of network connectivity diagnostic finding. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiagnoseVirtualNetworkResult(IReadOnlyList<string> findings, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Findings = findings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of network connectivity diagnostic finding. </summary>
        public IReadOnlyList<string> Findings { get; }
    }
}
