// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector.Models
{
    /// <summary> The response of change point detection. </summary>
    public partial class ChangePointDetectResponse
    {
        /// <summary> Initializes a new instance of ChangePointDetectResponse. </summary>
        internal ChangePointDetectResponse()
        {
            IsChangePoint = new ChangeTrackingList<bool>();
            ConfidenceScores = new ChangeTrackingList<float>();
        }

        /// <summary> Initializes a new instance of ChangePointDetectResponse. </summary>
        /// <param name="period"> Frequency extracted from the series, zero means no recurrent pattern has been found. </param>
        /// <param name="isChangePoint"> isChangePoint contains change point properties for each input point. True means an anomaly either negative or positive has been detected. The index of the array is consistent with the input series. </param>
        /// <param name="confidenceScores"> the change point confidence of each point. </param>
        internal ChangePointDetectResponse(int? period, IReadOnlyList<bool> isChangePoint, IReadOnlyList<float> confidenceScores)
        {
            Period = period;
            IsChangePoint = isChangePoint;
            ConfidenceScores = confidenceScores;
        }

        /// <summary> Frequency extracted from the series, zero means no recurrent pattern has been found. </summary>
        public int? Period { get; }
        /// <summary> isChangePoint contains change point properties for each input point. True means an anomaly either negative or positive has been detected. The index of the array is consistent with the input series. </summary>
        public IReadOnlyList<bool> IsChangePoint { get; }
        /// <summary> the change point confidence of each point. </summary>
        public IReadOnlyList<float> ConfidenceScores { get; }
    }
}
