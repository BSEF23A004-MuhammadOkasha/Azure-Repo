// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Trigger that schedules pipeline reruns for all fixed time interval windows from a requested start time to requested end time. </summary>
    public partial class RerunTumblingWindowTrigger : Trigger
    {
        /// <summary> Initializes a new instance of RerunTumblingWindowTrigger. </summary>
        /// <param name="requestedStartTime"> The start time for the time period for which restatement is initiated. Only UTC time is currently supported. </param>
        /// <param name="requestedEndTime"> The end time for the time period for which restatement is initiated. Only UTC time is currently supported. </param>
        /// <param name="maxConcurrency"> The max number of parallel time windows (ready for execution) for which a rerun is triggered. </param>
        public RerunTumblingWindowTrigger(DateTimeOffset requestedStartTime, DateTimeOffset requestedEndTime, int maxConcurrency)
        {
            RequestedStartTime = requestedStartTime;
            RequestedEndTime = requestedEndTime;
            MaxConcurrency = maxConcurrency;
            Type = "RerunTumblingWindowTrigger";
        }

        /// <summary> Initializes a new instance of RerunTumblingWindowTrigger. </summary>
        /// <param name="type"> Trigger type. </param>
        /// <param name="description"> Trigger description. </param>
        /// <param name="runtimeState"> Indicates if trigger is running or not. Updated when Start/Stop APIs are called on the Trigger. </param>
        /// <param name="annotations"> List of tags that can be used for describing the trigger. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="parentTrigger"> The parent trigger reference. </param>
        /// <param name="requestedStartTime"> The start time for the time period for which restatement is initiated. Only UTC time is currently supported. </param>
        /// <param name="requestedEndTime"> The end time for the time period for which restatement is initiated. Only UTC time is currently supported. </param>
        /// <param name="maxConcurrency"> The max number of parallel time windows (ready for execution) for which a rerun is triggered. </param>
        internal RerunTumblingWindowTrigger(string type, string description, TriggerRuntimeState? runtimeState, IList<object> annotations, IDictionary<string, object> additionalProperties, object parentTrigger, DateTimeOffset requestedStartTime, DateTimeOffset requestedEndTime, int maxConcurrency) : base(type, description, runtimeState, annotations, additionalProperties)
        {
            ParentTrigger = parentTrigger;
            RequestedStartTime = requestedStartTime;
            RequestedEndTime = requestedEndTime;
            MaxConcurrency = maxConcurrency;
            Type = type ?? "RerunTumblingWindowTrigger";
        }

        /// <summary> The parent trigger reference. </summary>
        public object ParentTrigger { get; set; }
        /// <summary> The start time for the time period for which restatement is initiated. Only UTC time is currently supported. </summary>
        public DateTimeOffset RequestedStartTime { get; set; }
        /// <summary> The end time for the time period for which restatement is initiated. Only UTC time is currently supported. </summary>
        public DateTimeOffset RequestedEndTime { get; set; }
        /// <summary> The max number of parallel time windows (ready for execution) for which a rerun is triggered. </summary>
        public int MaxConcurrency { get; set; }
    }
}
