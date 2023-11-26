// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan manual action details. </summary>
    public partial class RecoveryPlanManualActionDetails : RecoveryPlanActionDetails
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryPlanManualActionDetails"/>. </summary>
        public RecoveryPlanManualActionDetails()
        {
            InstanceType = "ManualActionDetails";
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanManualActionDetails"/>. </summary>
        /// <param name="instanceType"> Gets the type of action details (see RecoveryPlanActionDetailsTypes enum for possible values). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="description"> The manual action description. </param>
        internal RecoveryPlanManualActionDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string description) : base(instanceType, serializedAdditionalRawData)
        {
            Description = description;
            InstanceType = instanceType ?? "ManualActionDetails";
        }

        /// <summary> The manual action description. </summary>
        public string Description { get; set; }
    }
}
