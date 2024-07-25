// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> The GuestConfigurationAssignmentReportInfo. </summary>
    public partial class GuestConfigurationAssignmentReportInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationAssignmentReportInfo"/>. </summary>
        public GuestConfigurationAssignmentReportInfo()
        {
            Resources = new ChangeTrackingList<AssignmentReportResourceInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationAssignmentReportInfo"/>. </summary>
        /// <param name="id"> ARM resource id of the report for the guest configuration assignment. </param>
        /// <param name="reportId"> GUID that identifies the guest configuration assignment report under a subscription, resource group. </param>
        /// <param name="assignment"> Configuration details of the guest configuration assignment. </param>
        /// <param name="vm"> Information about the VM. </param>
        /// <param name="startOn"> Start date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="endOn"> End date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="complianceStatus"> A value indicating compliance status of the machine for the assigned guest configuration. </param>
        /// <param name="operationType"> Type of report, Consistency or Initial. </param>
        /// <param name="resources"> The list of resources for which guest configuration assignment compliance is checked. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GuestConfigurationAssignmentReportInfo(ResourceIdentifier id, Guid? reportId, GuestConfigurationAssignmentInfo assignment, GuestConfigurationVmInfo vm, DateTimeOffset? startOn, DateTimeOffset? endOn, AssignedGuestConfigurationMachineComplianceStatus? complianceStatus, GuestConfigurationAssignmentReportType? operationType, IList<AssignmentReportResourceInfo> resources, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ReportId = reportId;
            Assignment = assignment;
            Vm = vm;
            StartOn = startOn;
            EndOn = endOn;
            ComplianceStatus = complianceStatus;
            OperationType = operationType;
            Resources = resources;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ARM resource id of the report for the guest configuration assignment. </summary>
        [WirePath("id")]
        public ResourceIdentifier Id { get; }
        /// <summary> GUID that identifies the guest configuration assignment report under a subscription, resource group. </summary>
        [WirePath("reportId")]
        public Guid? ReportId { get; }
        /// <summary> Configuration details of the guest configuration assignment. </summary>
        [WirePath("assignment")]
        public GuestConfigurationAssignmentInfo Assignment { get; set; }
        /// <summary> Information about the VM. </summary>
        [WirePath("vm")]
        public GuestConfigurationVmInfo Vm { get; set; }
        /// <summary> Start date and time of the guest configuration assignment compliance status check. </summary>
        [WirePath("startTime")]
        public DateTimeOffset? StartOn { get; }
        /// <summary> End date and time of the guest configuration assignment compliance status check. </summary>
        [WirePath("endTime")]
        public DateTimeOffset? EndOn { get; }
        /// <summary> A value indicating compliance status of the machine for the assigned guest configuration. </summary>
        [WirePath("complianceStatus")]
        public AssignedGuestConfigurationMachineComplianceStatus? ComplianceStatus { get; }
        /// <summary> Type of report, Consistency or Initial. </summary>
        [WirePath("operationType")]
        public GuestConfigurationAssignmentReportType? OperationType { get; }
        /// <summary> The list of resources for which guest configuration assignment compliance is checked. </summary>
        [WirePath("resources")]
        public IList<AssignmentReportResourceInfo> Resources { get; }
    }
}
