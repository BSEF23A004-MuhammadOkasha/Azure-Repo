// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Response for getting all the linkable environments. </summary>
    public partial class LinkableEnvironmentResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LinkableEnvironmentResult"/>. </summary>
        internal LinkableEnvironmentResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkableEnvironmentResult"/>. </summary>
        /// <param name="environmentId"> environment id for which user is an admin. </param>
        /// <param name="environmentName"> Name of the environment. </param>
        /// <param name="planData"> Billing plan information. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkableEnvironmentResult(string environmentId, string environmentName, DynatraceBillingPlanInfo planData, Dictionary<string, BinaryData> rawData)
        {
            EnvironmentId = environmentId;
            EnvironmentName = environmentName;
            PlanData = planData;
            _rawData = rawData;
        }

        /// <summary> environment id for which user is an admin. </summary>
        public string EnvironmentId { get; }
        /// <summary> Name of the environment. </summary>
        public string EnvironmentName { get; }
        /// <summary> Billing plan information. </summary>
        public DynatraceBillingPlanInfo PlanData { get; }
    }
}
