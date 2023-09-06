// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Compliance summary on a particular summary level. </summary>
    public partial class PolicySummaryResults
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PolicySummaryResults"/>. </summary>
        internal PolicySummaryResults()
        {
            ResourceDetails = new ChangeTrackingList<ComplianceDetail>();
            PolicyDetails = new ChangeTrackingList<ComplianceDetail>();
            PolicyGroupDetails = new ChangeTrackingList<ComplianceDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="PolicySummaryResults"/>. </summary>
        /// <param name="queryResultsUri"> HTTP POST URI for queryResults action on Microsoft.PolicyInsights to retrieve raw results for the compliance summary. This property will not be available by default in future API versions, but could be queried explicitly. </param>
        /// <param name="nonCompliantResources"> Number of non-compliant resources. </param>
        /// <param name="nonCompliantPolicies"> Number of non-compliant policies. </param>
        /// <param name="resourceDetails"> The resources summary at this level. </param>
        /// <param name="policyDetails"> The policy artifact summary at this level. For query scope level, it represents policy assignment summary. For policy assignment level, it represents policy definitions summary. </param>
        /// <param name="policyGroupDetails"> The policy definition group summary at this level. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicySummaryResults(Uri queryResultsUri, int? nonCompliantResources, int? nonCompliantPolicies, IReadOnlyList<ComplianceDetail> resourceDetails, IReadOnlyList<ComplianceDetail> policyDetails, IReadOnlyList<ComplianceDetail> policyGroupDetails, Dictionary<string, BinaryData> rawData)
        {
            QueryResultsUri = queryResultsUri;
            NonCompliantResources = nonCompliantResources;
            NonCompliantPolicies = nonCompliantPolicies;
            ResourceDetails = resourceDetails;
            PolicyDetails = policyDetails;
            PolicyGroupDetails = policyGroupDetails;
            _rawData = rawData;
        }

        /// <summary> HTTP POST URI for queryResults action on Microsoft.PolicyInsights to retrieve raw results for the compliance summary. This property will not be available by default in future API versions, but could be queried explicitly. </summary>
        public Uri QueryResultsUri { get; }
        /// <summary> Number of non-compliant resources. </summary>
        public int? NonCompliantResources { get; }
        /// <summary> Number of non-compliant policies. </summary>
        public int? NonCompliantPolicies { get; }
        /// <summary> The resources summary at this level. </summary>
        public IReadOnlyList<ComplianceDetail> ResourceDetails { get; }
        /// <summary> The policy artifact summary at this level. For query scope level, it represents policy assignment summary. For policy assignment level, it represents policy definitions summary. </summary>
        public IReadOnlyList<ComplianceDetail> PolicyDetails { get; }
        /// <summary> The policy definition group summary at this level. </summary>
        public IReadOnlyList<ComplianceDetail> PolicyGroupDetails { get; }
    }
}
