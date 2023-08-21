// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Workspace features. </summary>
    public partial class OperationalInsightsWorkspaceFeatures
    {
        /// <summary> Initializes a new instance of OperationalInsightsWorkspaceFeatures. </summary>
        public OperationalInsightsWorkspaceFeatures()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of OperationalInsightsWorkspaceFeatures. </summary>
        /// <param name="isDataExportEnabled"> Flag that indicate if data should be exported. </param>
        /// <param name="immediatePurgeDataOn30Days"> Flag that describes if we want to remove the data after 30 days. </param>
        /// <param name="isLogAccessUsingOnlyResourcePermissionsEnabled"> Flag that indicate which permission to use - resource or workspace or both. </param>
        /// <param name="clusterResourceId"> Dedicated LA cluster resourceId that is linked to the workspaces. </param>
        /// <param name="isLocalAuthDisabled"> Disable Non-AAD based Auth. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal OperationalInsightsWorkspaceFeatures(bool? isDataExportEnabled, bool? immediatePurgeDataOn30Days, bool? isLogAccessUsingOnlyResourcePermissionsEnabled, ResourceIdentifier clusterResourceId, bool? isLocalAuthDisabled, IDictionary<string, BinaryData> additionalProperties)
        {
            IsDataExportEnabled = isDataExportEnabled;
            ImmediatePurgeDataOn30Days = immediatePurgeDataOn30Days;
            IsLogAccessUsingOnlyResourcePermissionsEnabled = isLogAccessUsingOnlyResourcePermissionsEnabled;
            ClusterResourceId = clusterResourceId;
            IsLocalAuthDisabled = isLocalAuthDisabled;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Flag that indicate if data should be exported. </summary>
        public bool? IsDataExportEnabled { get; set; }
        /// <summary> Flag that describes if we want to remove the data after 30 days. </summary>
        public bool? ImmediatePurgeDataOn30Days { get; set; }
        /// <summary> Flag that indicate which permission to use - resource or workspace or both. </summary>
        public bool? IsLogAccessUsingOnlyResourcePermissionsEnabled { get; set; }
        /// <summary> Dedicated LA cluster resourceId that is linked to the workspaces. </summary>
        public ResourceIdentifier ClusterResourceId { get; set; }
        /// <summary> Disable Non-AAD based Auth. </summary>
        public bool? IsLocalAuthDisabled { get; set; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
