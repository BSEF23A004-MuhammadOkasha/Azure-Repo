// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class representing Abnormal Time Period identified in diagnosis. </summary>
    public partial class AbnormalTimePeriod
    {
        /// <summary> Initializes a new instance of AbnormalTimePeriod. </summary>
        public AbnormalTimePeriod()
        {
            Events = new Core.ChangeTrackingList<DetectorAbnormalTimePeriod>();
            Solutions = new Core.ChangeTrackingList<DiagnosticSolution>();
        }

        /// <summary> Initializes a new instance of AbnormalTimePeriod. </summary>
        /// <param name="startOn"> Start time of the downtime. </param>
        /// <param name="endOn"> End time of the downtime. </param>
        /// <param name="events"> List of Possible Cause of downtime. </param>
        /// <param name="solutions"> List of proposed solutions. </param>
        internal AbnormalTimePeriod(DateTimeOffset? startOn, DateTimeOffset? endOn, IList<DetectorAbnormalTimePeriod> events, IList<DiagnosticSolution> solutions)
        {
            StartOn = startOn;
            EndOn = endOn;
            Events = events;
            Solutions = solutions;
        }

        /// <summary> Start time of the downtime. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> End time of the downtime. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> List of Possible Cause of downtime. </summary>
        public IList<DetectorAbnormalTimePeriod> Events { get; }
        /// <summary> List of proposed solutions. </summary>
        public IList<DiagnosticSolution> Solutions { get; }
    }
}
