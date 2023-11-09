// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Search job execution statistics. </summary>
    public partial class OperationalInsightsTableResultStatistics
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsTableResultStatistics"/>. </summary>
        internal OperationalInsightsTableResultStatistics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsTableResultStatistics"/>. </summary>
        /// <param name="progress"> Search job completion percentage. </param>
        /// <param name="ingestedRecords"> The number of rows that were returned by the search job. </param>
        /// <param name="scannedGB"> Search job: Amount of scanned data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationalInsightsTableResultStatistics(float? progress, int? ingestedRecords, float? scannedGB, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Progress = progress;
            IngestedRecords = ingestedRecords;
            ScannedGB = scannedGB;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Search job completion percentage. </summary>
        public float? Progress { get; }
        /// <summary> The number of rows that were returned by the search job. </summary>
        public int? IngestedRecords { get; }
        /// <summary> Search job: Amount of scanned data. </summary>
        public float? ScannedGB { get; }
    }
}
