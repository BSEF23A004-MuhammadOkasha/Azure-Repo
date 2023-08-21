// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The approval stage. </summary>
    public partial class RoleManagementApprovalStage
    {
        /// <summary> Initializes a new instance of RoleManagementApprovalStage. </summary>
        public RoleManagementApprovalStage()
        {
            PrimaryApprovers = new Core.ChangeTrackingList<RoleManagementUserInfo>();
            EscalationApprovers = new Core.ChangeTrackingList<RoleManagementUserInfo>();
        }

        /// <summary> Initializes a new instance of RoleManagementApprovalStage. </summary>
        /// <param name="approvalStageTimeOutInDays"> The time in days when approval request would be timed out. </param>
        /// <param name="isApproverJustificationRequired"> Determines whether approver need to provide justification for his decision. </param>
        /// <param name="escalationTimeInMinutes"> The time in minutes when the approval request would be escalated if the primary approver does not approve. </param>
        /// <param name="primaryApprovers"> The primary approver of the request. </param>
        /// <param name="isEscalationEnabled"> The value determine whether escalation feature is enabled. </param>
        /// <param name="escalationApprovers"> The escalation approver of the request. </param>
        internal RoleManagementApprovalStage(int? approvalStageTimeOutInDays, bool? isApproverJustificationRequired, int? escalationTimeInMinutes, IList<RoleManagementUserInfo> primaryApprovers, bool? isEscalationEnabled, IList<RoleManagementUserInfo> escalationApprovers)
        {
            ApprovalStageTimeOutInDays = approvalStageTimeOutInDays;
            IsApproverJustificationRequired = isApproverJustificationRequired;
            EscalationTimeInMinutes = escalationTimeInMinutes;
            PrimaryApprovers = primaryApprovers;
            IsEscalationEnabled = isEscalationEnabled;
            EscalationApprovers = escalationApprovers;
        }

        /// <summary> The time in days when approval request would be timed out. </summary>
        public int? ApprovalStageTimeOutInDays { get; set; }
        /// <summary> Determines whether approver need to provide justification for his decision. </summary>
        public bool? IsApproverJustificationRequired { get; set; }
        /// <summary> The time in minutes when the approval request would be escalated if the primary approver does not approve. </summary>
        public int? EscalationTimeInMinutes { get; set; }
        /// <summary> The primary approver of the request. </summary>
        public IList<RoleManagementUserInfo> PrimaryApprovers { get; }
        /// <summary> The value determine whether escalation feature is enabled. </summary>
        public bool? IsEscalationEnabled { get; set; }
        /// <summary> The escalation approver of the request. </summary>
        public IList<RoleManagementUserInfo> EscalationApprovers { get; }
    }
}
