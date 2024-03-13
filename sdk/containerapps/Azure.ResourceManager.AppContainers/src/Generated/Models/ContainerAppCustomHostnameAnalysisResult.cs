// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Custom domain analysis. </summary>
    public partial class ContainerAppCustomHostnameAnalysisResult
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomHostnameAnalysisResult"/>. </summary>
        internal ContainerAppCustomHostnameAnalysisResult()
        {
            CNameRecords = new ChangeTrackingList<string>();
            TxtRecords = new ChangeTrackingList<string>();
            ARecords = new ChangeTrackingList<string>();
            AlternateCNameRecords = new ChangeTrackingList<string>();
            AlternateTxtRecords = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomHostnameAnalysisResult"/>. </summary>
        /// <param name="hostName"> Host name that was analyzed. </param>
        /// <param name="isHostnameAlreadyVerified"> &lt;code&gt;true&lt;/code&gt; if hostname is already verified; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="customDomainVerificationTest"> DNS verification test result. </param>
        /// <param name="customDomainVerificationFailureInfo"> Raw failure information if DNS verification fails. </param>
        /// <param name="hasConflictOnManagedEnvironment"> &lt;code&gt;true&lt;/code&gt; if there is a conflict on the Container App's managed environment; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="conflictWithEnvironmentCustomDomain"> &lt;code&gt;true&lt;/code&gt; if there is a conflict on the Container App's managed environment level custom domain; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="conflictingContainerAppResourceId"> Name of the conflicting Container App on the Managed Environment if it's within the same subscription. </param>
        /// <param name="cNameRecords"> CName records visible for this hostname. </param>
        /// <param name="txtRecords"> TXT records visible for this hostname. </param>
        /// <param name="aRecords"> A records visible for this hostname. </param>
        /// <param name="alternateCNameRecords"> Alternate CName records visible for this hostname. </param>
        /// <param name="alternateTxtRecords"> Alternate TXT records visible for this hostname. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppCustomHostnameAnalysisResult(string hostName, bool? isHostnameAlreadyVerified, ContainerAppDnsVerificationTestResult? customDomainVerificationTest, ContainerAppCustomDomainVerificationFailureInfo customDomainVerificationFailureInfo, bool? hasConflictOnManagedEnvironment, bool? conflictWithEnvironmentCustomDomain, string conflictingContainerAppResourceId, IReadOnlyList<string> cNameRecords, IReadOnlyList<string> txtRecords, IReadOnlyList<string> aRecords, IReadOnlyList<string> alternateCNameRecords, IReadOnlyList<string> alternateTxtRecords, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HostName = hostName;
            IsHostnameAlreadyVerified = isHostnameAlreadyVerified;
            CustomDomainVerificationTest = customDomainVerificationTest;
            CustomDomainVerificationFailureInfo = customDomainVerificationFailureInfo;
            HasConflictOnManagedEnvironment = hasConflictOnManagedEnvironment;
            ConflictWithEnvironmentCustomDomain = conflictWithEnvironmentCustomDomain;
            ConflictingContainerAppResourceId = conflictingContainerAppResourceId;
            CNameRecords = cNameRecords;
            TxtRecords = txtRecords;
            ARecords = aRecords;
            AlternateCNameRecords = alternateCNameRecords;
            AlternateTxtRecords = alternateTxtRecords;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Host name that was analyzed. </summary>
        [WirePath("hostName")]
        public string HostName { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if hostname is already verified; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("isHostnameAlreadyVerified")]
        public bool? IsHostnameAlreadyVerified { get; }
        /// <summary> DNS verification test result. </summary>
        [WirePath("customDomainVerificationTest")]
        public ContainerAppDnsVerificationTestResult? CustomDomainVerificationTest { get; }
        /// <summary> Raw failure information if DNS verification fails. </summary>
        [WirePath("customDomainVerificationFailureInfo")]
        public ContainerAppCustomDomainVerificationFailureInfo CustomDomainVerificationFailureInfo { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if there is a conflict on the Container App's managed environment; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("hasConflictOnManagedEnvironment")]
        public bool? HasConflictOnManagedEnvironment { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if there is a conflict on the Container App's managed environment level custom domain; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("conflictWithEnvironmentCustomDomain")]
        public bool? ConflictWithEnvironmentCustomDomain { get; }
        /// <summary> Name of the conflicting Container App on the Managed Environment if it's within the same subscription. </summary>
        [WirePath("conflictingContainerAppResourceId")]
        public string ConflictingContainerAppResourceId { get; }
        /// <summary> CName records visible for this hostname. </summary>
        [WirePath("cNameRecords")]
        public IReadOnlyList<string> CNameRecords { get; }
        /// <summary> TXT records visible for this hostname. </summary>
        [WirePath("txtRecords")]
        public IReadOnlyList<string> TxtRecords { get; }
        /// <summary> A records visible for this hostname. </summary>
        [WirePath("aRecords")]
        public IReadOnlyList<string> ARecords { get; }
        /// <summary> Alternate CName records visible for this hostname. </summary>
        [WirePath("alternateCNameRecords")]
        public IReadOnlyList<string> AlternateCNameRecords { get; }
        /// <summary> Alternate TXT records visible for this hostname. </summary>
        [WirePath("alternateTxtRecords")]
        public IReadOnlyList<string> AlternateTxtRecords { get; }
    }
}
