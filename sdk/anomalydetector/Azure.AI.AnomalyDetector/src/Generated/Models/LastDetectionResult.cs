// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector.Models
{
    /// <summary> The LastDetectionResult. </summary>
    public partial class LastDetectionResult
    {
        /// <summary> Initializes a new instance of <see cref="LastDetectionResult"/>. </summary>
        internal LastDetectionResult()
        {
            VariableStates = new ChangeTrackingList<VariableState>();
            Results = new ChangeTrackingList<AnomalyState>();
        }

        /// <summary> Initializes a new instance of <see cref="LastDetectionResult"/>. </summary>
        /// <param name="variableStates"></param>
        /// <param name="results"></param>
        internal LastDetectionResult(IReadOnlyList<VariableState> variableStates, IReadOnlyList<AnomalyState> results)
        {
            VariableStates = variableStates;
            Results = results;
        }

        /// <summary> Gets the variable states. </summary>
        public IReadOnlyList<VariableState> VariableStates { get; }
        /// <summary> Gets the results. </summary>
        public IReadOnlyList<AnomalyState> Results { get; }
    }
}
