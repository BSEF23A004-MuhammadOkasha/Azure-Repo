// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> The UnknownAlertProcessingRuleRecurrence. </summary>
    internal partial class UnknownAlertProcessingRuleRecurrence : AlertProcessingRuleRecurrence
    {
        /// <summary> Initializes a new instance of UnknownAlertProcessingRuleRecurrence. </summary>
        /// <param name="recurrenceType"> Specifies when the recurrence should be applied. </param>
        /// <param name="startOn"> Start time for recurrence. </param>
        /// <param name="endOn"> End time for recurrence. </param>
        internal UnknownAlertProcessingRuleRecurrence(RecurrenceType recurrenceType, TimeSpan? startOn, TimeSpan? endOn) : base(recurrenceType, startOn, endOn)
        {
            RecurrenceType = recurrenceType;
        }
    }
}
