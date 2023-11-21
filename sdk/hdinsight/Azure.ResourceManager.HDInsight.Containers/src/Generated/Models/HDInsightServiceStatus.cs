// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Describes the status of a service of a HDInsight on aks cluster. </summary>
    public partial class HDInsightServiceStatus
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

        /// <summary> Initializes a new instance of <see cref="HDInsightServiceStatus"/>. </summary>
        /// <param name="kind"> Kind of the service. E.g. "Zookeeper". </param>
        /// <param name="ready"> Indicates if the service is ready / healthy. Values can be "true", "false", "unknown" or anything else. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kind"/> or <paramref name="ready"/> is null. </exception>
        internal HDInsightServiceStatus(string kind, string ready)
        {
            Argument.AssertNotNull(kind, nameof(kind));
            Argument.AssertNotNull(ready, nameof(ready));

            Kind = kind;
            Ready = ready;
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightServiceStatus"/>. </summary>
        /// <param name="kind"> Kind of the service. E.g. "Zookeeper". </param>
        /// <param name="ready"> Indicates if the service is ready / healthy. Values can be "true", "false", "unknown" or anything else. </param>
        /// <param name="message"> A message describing the error if any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightServiceStatus(string kind, string ready, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Ready = ready;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightServiceStatus"/> for deserialization. </summary>
        internal HDInsightServiceStatus()
        {
        }

        /// <summary> Kind of the service. E.g. "Zookeeper". </summary>
        public string Kind { get; }
        /// <summary> Indicates if the service is ready / healthy. Values can be "true", "false", "unknown" or anything else. </summary>
        public string Ready { get; }
        /// <summary> A message describing the error if any. </summary>
        public string Message { get; }
    }
}
