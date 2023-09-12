// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Information about the current running state of the overall upgrade. </summary>
    public partial class RollingUpgradeRunningStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RollingUpgradeRunningStatus"/>. </summary>
        internal RollingUpgradeRunningStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RollingUpgradeRunningStatus"/>. </summary>
        /// <param name="code"> Code indicating the current status of the upgrade. </param>
        /// <param name="startOn"> Start time of the upgrade. </param>
        /// <param name="lastAction"> The last action performed on the rolling upgrade. </param>
        /// <param name="lastActionOn"> Last action time of the upgrade. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RollingUpgradeRunningStatus(RollingUpgradeStatusCode? code, DateTimeOffset? startOn, RollingUpgradeActionType? lastAction, DateTimeOffset? lastActionOn, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            StartOn = startOn;
            LastAction = lastAction;
            LastActionOn = lastActionOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Code indicating the current status of the upgrade. </summary>
        public RollingUpgradeStatusCode? Code { get; }
        /// <summary> Start time of the upgrade. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The last action performed on the rolling upgrade. </summary>
        public RollingUpgradeActionType? LastAction { get; }
        /// <summary> Last action time of the upgrade. </summary>
        public DateTimeOffset? LastActionOn { get; }
    }
}
