// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The workflow run action correlation properties. </summary>
    public partial class LogicWorkflowRunActionCorrelation : LogicWorkflowRunCorrelation
    {
        /// <summary> Initializes a new instance of LogicWorkflowRunActionCorrelation. </summary>
        public LogicWorkflowRunActionCorrelation()
        {
        }

        /// <summary> Initializes a new instance of LogicWorkflowRunActionCorrelation. </summary>
        /// <param name="clientTrackingId"> The client tracking identifier. </param>
        /// <param name="clientKeywords"> The client keywords. </param>
        /// <param name="actionTrackingId"> The action tracking identifier. </param>
        internal LogicWorkflowRunActionCorrelation(string clientTrackingId, IList<string> clientKeywords, Guid? actionTrackingId) : base(clientTrackingId, clientKeywords)
        {
            ActionTrackingId = actionTrackingId;
        }

        /// <summary> The action tracking identifier. </summary>
        public Guid? ActionTrackingId { get; set; }
    }
}
