// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Response containing status for a specific purge operation. </summary>
    public partial class OperationalInsightsWorkspacePurgeStatusResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspacePurgeStatusResult"/>. </summary>
        /// <param name="status"> Status of the operation represented by the requested Id. </param>
        internal OperationalInsightsWorkspacePurgeStatusResult(OperationalInsightsWorkspacePurgeState status)
        {
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspacePurgeStatusResult"/>. </summary>
        /// <param name="status"> Status of the operation represented by the requested Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationalInsightsWorkspacePurgeStatusResult(OperationalInsightsWorkspacePurgeState status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspacePurgeStatusResult"/> for deserialization. </summary>
        internal OperationalInsightsWorkspacePurgeStatusResult()
        {
        }

        /// <summary> Status of the operation represented by the requested Id. </summary>
        public OperationalInsightsWorkspacePurgeState Status { get; }
    }
}
