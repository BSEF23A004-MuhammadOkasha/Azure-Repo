// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The batch release criteria. </summary>
    public partial class IntegrationAccountBatchReleaseCriteria
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountBatchReleaseCriteria"/>. </summary>
        public IntegrationAccountBatchReleaseCriteria()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountBatchReleaseCriteria"/>. </summary>
        /// <param name="messageCount"> The message count. </param>
        /// <param name="batchSize"> The batch size in bytes. </param>
        /// <param name="recurrence"> The recurrence. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationAccountBatchReleaseCriteria(int? messageCount, int? batchSize, LogicWorkflowTriggerRecurrence recurrence, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MessageCount = messageCount;
            BatchSize = batchSize;
            Recurrence = recurrence;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The message count. </summary>
        public int? MessageCount { get; set; }
        /// <summary> The batch size in bytes. </summary>
        public int? BatchSize { get; set; }
        /// <summary> The recurrence. </summary>
        public LogicWorkflowTriggerRecurrence Recurrence { get; set; }
    }
}
