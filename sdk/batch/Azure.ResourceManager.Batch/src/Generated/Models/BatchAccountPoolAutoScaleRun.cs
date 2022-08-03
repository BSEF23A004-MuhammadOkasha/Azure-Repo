// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The results and errors from an execution of a pool autoscale formula. </summary>
    public partial class BatchAccountPoolAutoScaleRun
    {
        /// <summary> Initializes a new instance of BatchAccountPoolAutoScaleRun. </summary>
        /// <param name="evaluationOn"> The time at which the autoscale formula was last evaluated. </param>
        internal BatchAccountPoolAutoScaleRun(DateTimeOffset evaluationOn)
        {
            EvaluationOn = evaluationOn;
        }

        /// <summary> Initializes a new instance of BatchAccountPoolAutoScaleRun. </summary>
        /// <param name="evaluationOn"> The time at which the autoscale formula was last evaluated. </param>
        /// <param name="results"> Each variable value is returned in the form $variable=value, and variables are separated by semicolons. </param>
        /// <param name="error"> An error that occurred when autoscaling a pool. </param>
        internal BatchAccountPoolAutoScaleRun(DateTimeOffset evaluationOn, string results, ResponseError error)
        {
            EvaluationOn = evaluationOn;
            Results = results;
            Error = error;
        }

        /// <summary> The time at which the autoscale formula was last evaluated. </summary>
        public DateTimeOffset EvaluationOn { get; }
        /// <summary> Each variable value is returned in the form $variable=value, and variables are separated by semicolons. </summary>
        public string Results { get; }
        /// <summary> An error that occurred when autoscaling a pool. </summary>
        public ResponseError Error { get; }
    }
}
