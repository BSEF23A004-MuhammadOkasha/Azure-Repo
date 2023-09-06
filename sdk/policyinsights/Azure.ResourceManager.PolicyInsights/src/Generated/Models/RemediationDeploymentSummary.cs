// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The deployment status summary for all deployments created by the remediation. </summary>
    public partial class RemediationDeploymentSummary
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RemediationDeploymentSummary"/>. </summary>
        internal RemediationDeploymentSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RemediationDeploymentSummary"/>. </summary>
        /// <param name="totalDeployments"> The number of deployments required by the remediation. </param>
        /// <param name="successfulDeployments"> The number of deployments required by the remediation that have succeeded. </param>
        /// <param name="failedDeployments"> The number of deployments required by the remediation that have failed. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RemediationDeploymentSummary(int? totalDeployments, int? successfulDeployments, int? failedDeployments, Dictionary<string, BinaryData> rawData)
        {
            TotalDeployments = totalDeployments;
            SuccessfulDeployments = successfulDeployments;
            FailedDeployments = failedDeployments;
            _rawData = rawData;
        }

        /// <summary> The number of deployments required by the remediation. </summary>
        public int? TotalDeployments { get; }
        /// <summary> The number of deployments required by the remediation that have succeeded. </summary>
        public int? SuccessfulDeployments { get; }
        /// <summary> The number of deployments required by the remediation that have failed. </summary>
        public int? FailedDeployments { get; }
    }
}
