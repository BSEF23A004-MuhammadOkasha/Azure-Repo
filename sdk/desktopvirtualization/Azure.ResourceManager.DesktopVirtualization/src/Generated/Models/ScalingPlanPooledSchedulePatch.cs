// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> ScalingPlanPooledSchedule properties that can be patched. </summary>
    public partial class ScalingPlanPooledSchedulePatch : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ScalingPlanPooledSchedulePatch"/>. </summary>
        public ScalingPlanPooledSchedulePatch()
        {
            DaysOfWeek = new ChangeTrackingList<DesktopVirtualizationDayOfWeek>();
        }

        /// <summary> Initializes a new instance of <see cref="ScalingPlanPooledSchedulePatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="daysOfWeek"> Set of days of the week on which this schedule is active. </param>
        /// <param name="rampUpStartTime"> Starting time for ramp up period. </param>
        /// <param name="rampUpLoadBalancingAlgorithm"> Load balancing algorithm for ramp up period. </param>
        /// <param name="rampUpMinimumHostsPct"> Minimum host percentage for ramp up period. </param>
        /// <param name="rampUpCapacityThresholdPct"> Capacity threshold for ramp up period. </param>
        /// <param name="peakStartTime"> Starting time for peak period. </param>
        /// <param name="peakLoadBalancingAlgorithm"> Load balancing algorithm for peak period. </param>
        /// <param name="rampDownStartTime"> Starting time for ramp down period. </param>
        /// <param name="rampDownLoadBalancingAlgorithm"> Load balancing algorithm for ramp down period. </param>
        /// <param name="rampDownMinimumHostsPct"> Minimum host percentage for ramp down period. </param>
        /// <param name="rampDownCapacityThresholdPct"> Capacity threshold for ramp down period. </param>
        /// <param name="rampDownForceLogoffUsers"> Should users be logged off forcefully from hosts. </param>
        /// <param name="rampDownStopHostsWhen"> Specifies when to stop hosts during ramp down period. </param>
        /// <param name="rampDownWaitTimeMinutes"> Number of minutes to wait to stop hosts during ramp down period. </param>
        /// <param name="rampDownNotificationMessage"> Notification message for users during ramp down period. </param>
        /// <param name="offPeakStartTime"> Starting time for off-peak period. </param>
        /// <param name="offPeakLoadBalancingAlgorithm"> Load balancing algorithm for off-peak period. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ScalingPlanPooledSchedulePatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<DesktopVirtualizationDayOfWeek> daysOfWeek, ScalingActionTime rampUpStartTime, SessionHostLoadBalancingAlgorithm? rampUpLoadBalancingAlgorithm, int? rampUpMinimumHostsPct, int? rampUpCapacityThresholdPct, ScalingActionTime peakStartTime, SessionHostLoadBalancingAlgorithm? peakLoadBalancingAlgorithm, ScalingActionTime rampDownStartTime, SessionHostLoadBalancingAlgorithm? rampDownLoadBalancingAlgorithm, int? rampDownMinimumHostsPct, int? rampDownCapacityThresholdPct, bool? rampDownForceLogoffUsers, DesktopVirtualizationStopHostsWhen? rampDownStopHostsWhen, int? rampDownWaitTimeMinutes, string rampDownNotificationMessage, ScalingActionTime offPeakStartTime, SessionHostLoadBalancingAlgorithm? offPeakLoadBalancingAlgorithm, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            DaysOfWeek = daysOfWeek;
            RampUpStartTime = rampUpStartTime;
            RampUpLoadBalancingAlgorithm = rampUpLoadBalancingAlgorithm;
            RampUpMinimumHostsPct = rampUpMinimumHostsPct;
            RampUpCapacityThresholdPct = rampUpCapacityThresholdPct;
            PeakStartTime = peakStartTime;
            PeakLoadBalancingAlgorithm = peakLoadBalancingAlgorithm;
            RampDownStartTime = rampDownStartTime;
            RampDownLoadBalancingAlgorithm = rampDownLoadBalancingAlgorithm;
            RampDownMinimumHostsPct = rampDownMinimumHostsPct;
            RampDownCapacityThresholdPct = rampDownCapacityThresholdPct;
            RampDownForceLogoffUsers = rampDownForceLogoffUsers;
            RampDownStopHostsWhen = rampDownStopHostsWhen;
            RampDownWaitTimeMinutes = rampDownWaitTimeMinutes;
            RampDownNotificationMessage = rampDownNotificationMessage;
            OffPeakStartTime = offPeakStartTime;
            OffPeakLoadBalancingAlgorithm = offPeakLoadBalancingAlgorithm;
            _rawData = rawData;
        }

        /// <summary> Set of days of the week on which this schedule is active. </summary>
        public IList<DesktopVirtualizationDayOfWeek> DaysOfWeek { get; }
        /// <summary> Starting time for ramp up period. </summary>
        public ScalingActionTime RampUpStartTime { get; set; }
        /// <summary> Load balancing algorithm for ramp up period. </summary>
        public SessionHostLoadBalancingAlgorithm? RampUpLoadBalancingAlgorithm { get; set; }
        /// <summary> Minimum host percentage for ramp up period. </summary>
        public int? RampUpMinimumHostsPct { get; set; }
        /// <summary> Capacity threshold for ramp up period. </summary>
        public int? RampUpCapacityThresholdPct { get; set; }
        /// <summary> Starting time for peak period. </summary>
        public ScalingActionTime PeakStartTime { get; set; }
        /// <summary> Load balancing algorithm for peak period. </summary>
        public SessionHostLoadBalancingAlgorithm? PeakLoadBalancingAlgorithm { get; set; }
        /// <summary> Starting time for ramp down period. </summary>
        public ScalingActionTime RampDownStartTime { get; set; }
        /// <summary> Load balancing algorithm for ramp down period. </summary>
        public SessionHostLoadBalancingAlgorithm? RampDownLoadBalancingAlgorithm { get; set; }
        /// <summary> Minimum host percentage for ramp down period. </summary>
        public int? RampDownMinimumHostsPct { get; set; }
        /// <summary> Capacity threshold for ramp down period. </summary>
        public int? RampDownCapacityThresholdPct { get; set; }
        /// <summary> Should users be logged off forcefully from hosts. </summary>
        public bool? RampDownForceLogoffUsers { get; set; }
        /// <summary> Specifies when to stop hosts during ramp down period. </summary>
        public DesktopVirtualizationStopHostsWhen? RampDownStopHostsWhen { get; set; }
        /// <summary> Number of minutes to wait to stop hosts during ramp down period. </summary>
        public int? RampDownWaitTimeMinutes { get; set; }
        /// <summary> Notification message for users during ramp down period. </summary>
        public string RampDownNotificationMessage { get; set; }
        /// <summary> Starting time for off-peak period. </summary>
        public ScalingActionTime OffPeakStartTime { get; set; }
        /// <summary> Load balancing algorithm for off-peak period. </summary>
        public SessionHostLoadBalancingAlgorithm? OffPeakLoadBalancingAlgorithm { get; set; }
    }
}
