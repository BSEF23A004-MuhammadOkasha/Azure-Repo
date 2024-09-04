// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Synchronize certification record request. </summary>
    public partial class SyncCertRecordContent
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

        /// <summary> Initializes a new instance of <see cref="SyncCertRecordContent"/>. </summary>
        /// <param name="certRecord"> certification record to be synchronized. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certRecord"/> is null. </exception>
        public SyncCertRecordContent(CertSyncRecord certRecord)
        {
            Argument.AssertNotNull(certRecord, nameof(certRecord));

            CertRecord = certRecord;
        }

        /// <summary> Initializes a new instance of <see cref="SyncCertRecordContent"/>. </summary>
        /// <param name="certRecord"> certification record to be synchronized. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SyncCertRecordContent(CertSyncRecord certRecord, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CertRecord = certRecord;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SyncCertRecordContent"/> for deserialization. </summary>
        internal SyncCertRecordContent()
        {
        }

        /// <summary> certification record to be synchronized. </summary>
        public CertSyncRecord CertRecord { get; }
    }
}
