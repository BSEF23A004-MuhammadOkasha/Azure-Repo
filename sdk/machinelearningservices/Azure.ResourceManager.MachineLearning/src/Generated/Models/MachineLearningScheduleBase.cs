// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningScheduleBase. </summary>
    public partial class MachineLearningScheduleBase
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningScheduleBase"/>. </summary>
        public MachineLearningScheduleBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningScheduleBase"/>. </summary>
        /// <param name="id"> A system assigned id for the schedule. </param>
        /// <param name="provisioningStatus"> The current deployment state of schedule. </param>
        /// <param name="status"> Is the schedule enabled or disabled?. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningScheduleBase(string id, MachineLearningScheduleProvisioningState? provisioningStatus, MachineLearningScheduleStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ProvisioningStatus = provisioningStatus;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A system assigned id for the schedule. </summary>
        public string Id { get; set; }
        /// <summary> The current deployment state of schedule. </summary>
        public MachineLearningScheduleProvisioningState? ProvisioningStatus { get; set; }
        /// <summary> Is the schedule enabled or disabled?. </summary>
        public MachineLearningScheduleStatus? Status { get; set; }
    }
}
