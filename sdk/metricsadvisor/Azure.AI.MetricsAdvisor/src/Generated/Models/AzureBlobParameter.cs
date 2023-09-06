// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureBlobParameter. </summary>
    internal partial class AzureBlobParameter
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AzureBlobParameter"/>. </summary>
        /// <param name="container"> The container name in this Azure Blob. </param>
        /// <param name="blobTemplate"> The path template in this container. </param>
        public AzureBlobParameter(string container, string blobTemplate)
        {
            Container = container;
            BlobTemplate = blobTemplate;
        }

        /// <summary> Initializes a new instance of <see cref="AzureBlobParameter"/>. </summary>
        /// <param name="connectionString"> The connection string of this Azure Blob. </param>
        /// <param name="container"> The container name in this Azure Blob. </param>
        /// <param name="blobTemplate"> The path template in this container. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureBlobParameter(string connectionString, string container, string blobTemplate, Dictionary<string, BinaryData> rawData)
        {
            ConnectionString = connectionString;
            Container = container;
            BlobTemplate = blobTemplate;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AzureBlobParameter"/> for deserialization. </summary>
        internal AzureBlobParameter()
        {
        }

        /// <summary> The connection string of this Azure Blob. </summary>
        public string ConnectionString { get; set; }
        /// <summary> The container name in this Azure Blob. </summary>
        public string Container { get; set; }
        /// <summary> The path template in this container. </summary>
        public string BlobTemplate { get; set; }
    }
}
