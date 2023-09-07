// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Object of plans per context. </summary>
    public partial class ContextAndPlansDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContextAndPlansDetails"/>. </summary>
        public ContextAndPlansDetails()
        {
            PlanIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContextAndPlansDetails"/>. </summary>
        /// <param name="context"> Plan's context, e.g. subscription ID, tenant ID. </param>
        /// <param name="planIds"> List of plan IDs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContextAndPlansDetails(string context, IList<string> planIds, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Context = context;
            PlanIds = planIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Plan's context, e.g. subscription ID, tenant ID. </summary>
        public string Context { get; set; }
        /// <summary> List of plan IDs. </summary>
        public IList<string> PlanIds { get; }
    }
}
