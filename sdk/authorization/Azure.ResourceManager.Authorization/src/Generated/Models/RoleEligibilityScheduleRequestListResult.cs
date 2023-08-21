// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Role eligibility schedule request list operation result. </summary>
    internal partial class RoleEligibilityScheduleRequestListResult
    {
        /// <summary> Initializes a new instance of RoleEligibilityScheduleRequestListResult. </summary>
        internal RoleEligibilityScheduleRequestListResult()
        {
            Value = new Core.ChangeTrackingList<RoleEligibilityScheduleRequestData>();
        }

        /// <summary> Initializes a new instance of RoleEligibilityScheduleRequestListResult. </summary>
        /// <param name="value"> Role eligibility schedule request list. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal RoleEligibilityScheduleRequestListResult(IReadOnlyList<RoleEligibilityScheduleRequestData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Role eligibility schedule request list. </summary>
        public IReadOnlyList<RoleEligibilityScheduleRequestData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
