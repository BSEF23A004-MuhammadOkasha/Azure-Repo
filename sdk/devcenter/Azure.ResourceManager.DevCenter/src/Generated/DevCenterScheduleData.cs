// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing the DevCenterSchedule data model.
    /// Represents a Schedule to execute a task.
    /// </summary>
    public partial class DevCenterScheduleData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevCenterScheduleData"/>. </summary>
        public DevCenterScheduleData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterScheduleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scheduledType"> Supported type this scheduled task represents. </param>
        /// <param name="frequency"> The frequency of this scheduled task. </param>
        /// <param name="time"> The target time to trigger the action. The format is HH:MM. </param>
        /// <param name="timeZone"> The IANA timezone id at which the schedule should execute. </param>
        /// <param name="state"> Indicates whether or not this scheduled task is enabled. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevCenterScheduleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DevCenterScheduledType? scheduledType, DevCenterScheduledFrequency? frequency, string time, string timeZone, DevCenterScheduleEnableStatus? state, DevCenterProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ScheduledType = scheduledType;
            Frequency = frequency;
            Time = time;
            TimeZone = timeZone;
            State = state;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Supported type this scheduled task represents. </summary>
        public DevCenterScheduledType? ScheduledType { get; set; }
        /// <summary> The frequency of this scheduled task. </summary>
        public DevCenterScheduledFrequency? Frequency { get; set; }
        /// <summary> The target time to trigger the action. The format is HH:MM. </summary>
        public string Time { get; set; }
        /// <summary> The IANA timezone id at which the schedule should execute. </summary>
        public string TimeZone { get; set; }
        /// <summary> Indicates whether or not this scheduled task is enabled. </summary>
        public DevCenterScheduleEnableStatus? State { get; set; }
        /// <summary> The provisioning state of the resource. </summary>
        public DevCenterProvisioningState? ProvisioningState { get; }
    }
}
