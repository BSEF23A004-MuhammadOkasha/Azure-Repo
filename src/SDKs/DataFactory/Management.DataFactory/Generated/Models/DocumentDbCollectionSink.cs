// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A copy activity Document Database Collection sink.
    /// </summary>
    public partial class DocumentDbCollectionSink : CopySink
    {
        /// <summary>
        /// Initializes a new instance of the DocumentDbCollectionSink class.
        /// </summary>
        public DocumentDbCollectionSink()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DocumentDbCollectionSink class.
        /// </summary>
        /// <param name="writeBatchSize">Write batch size. Type: integer (or
        /// Expression with resultType integer), minimum: 0.</param>
        /// <param name="writeBatchTimeout">Write batch timeout. Type: string
        /// (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="sinkRetryCount">Sink retry count. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="sinkRetryWait">Sink retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="nestingSeparator">Nested properties separator. Default
        /// is . (dot). Type: string (or Expression with resultType
        /// string).</param>
        public DocumentDbCollectionSink(object writeBatchSize = default(object), object writeBatchTimeout = default(object), object sinkRetryCount = default(object), object sinkRetryWait = default(object), object nestingSeparator = default(object))
            : base(writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait)
        {
            NestingSeparator = nestingSeparator;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets nested properties separator. Default is . (dot). Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "nestingSeparator")]
        public object NestingSeparator { get; set; }

    }
}
