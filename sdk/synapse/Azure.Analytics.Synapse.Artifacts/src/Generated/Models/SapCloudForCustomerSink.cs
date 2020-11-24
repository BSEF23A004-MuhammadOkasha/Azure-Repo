// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity SAP Cloud for Customer sink. </summary>
    public partial class SapCloudForCustomerSink : CopySink
    {
        /// <summary> Initializes a new instance of SapCloudForCustomerSink. </summary>
        public SapCloudForCustomerSink()
        {
            Type = "SapCloudForCustomerSink";
        }

        /// <summary> Initializes a new instance of SapCloudForCustomerSink. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="writeBehavior"> The write behavior for the operation. Default is &apos;Insert&apos;. </param>
        internal SapCloudForCustomerSink(string type, object writeBatchSize, object writeBatchTimeout, object sinkRetryCount, object sinkRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, SapCloudForCustomerSinkWriteBehavior? writeBehavior) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties)
        {
            WriteBehavior = writeBehavior;
            Type = type ?? "SapCloudForCustomerSink";
        }

        /// <summary> The write behavior for the operation. Default is &apos;Insert&apos;. </summary>
        public SapCloudForCustomerSinkWriteBehavior? WriteBehavior { get; set; }
    }
}
