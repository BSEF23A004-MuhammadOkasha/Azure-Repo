// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.PolicyInsights.PolicyStateDeleted event. </summary>
    public partial class PolicyInsightsPolicyStateDeletedEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PolicyInsightsPolicyStateDeletedEventData"/>. </summary>
        internal PolicyInsightsPolicyStateDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicyInsightsPolicyStateDeletedEventData"/>. </summary>
        /// <param name="timestamp"> The time that the resource was scanned by Azure Policy in the Universal ISO 8601 DateTime format yyyy-MM-ddTHH:mm:ss.fffffffZ. </param>
        /// <param name="policyAssignmentId"> The resource ID of the policy assignment. </param>
        /// <param name="policyDefinitionId"> The resource ID of the policy definition. </param>
        /// <param name="policyDefinitionReferenceId"> The reference ID for the policy definition inside the initiative definition, if the policy assignment is for an initiative. May be empty. </param>
        /// <param name="complianceState"> The compliance state of the resource with respect to the policy assignment. </param>
        /// <param name="subscriptionId"> The subscription ID of the resource. </param>
        /// <param name="complianceReasonCode"> The compliance reason code. May be empty. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyInsightsPolicyStateDeletedEventData(DateTimeOffset? timestamp, string policyAssignmentId, string policyDefinitionId, string policyDefinitionReferenceId, string complianceState, string subscriptionId, string complianceReasonCode, Dictionary<string, BinaryData> rawData)
        {
            Timestamp = timestamp;
            PolicyAssignmentId = policyAssignmentId;
            PolicyDefinitionId = policyDefinitionId;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            ComplianceState = complianceState;
            SubscriptionId = subscriptionId;
            ComplianceReasonCode = complianceReasonCode;
            _rawData = rawData;
        }

        /// <summary> The time that the resource was scanned by Azure Policy in the Universal ISO 8601 DateTime format yyyy-MM-ddTHH:mm:ss.fffffffZ. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The resource ID of the policy assignment. </summary>
        public string PolicyAssignmentId { get; }
        /// <summary> The resource ID of the policy definition. </summary>
        public string PolicyDefinitionId { get; }
        /// <summary> The reference ID for the policy definition inside the initiative definition, if the policy assignment is for an initiative. May be empty. </summary>
        public string PolicyDefinitionReferenceId { get; }
        /// <summary> The compliance state of the resource with respect to the policy assignment. </summary>
        public string ComplianceState { get; }
        /// <summary> The subscription ID of the resource. </summary>
        public string SubscriptionId { get; }
        /// <summary> The compliance reason code. May be empty. </summary>
        public string ComplianceReasonCode { get; }
    }
}
