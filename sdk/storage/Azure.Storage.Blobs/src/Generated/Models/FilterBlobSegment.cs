// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The result of a Filter Blobs API call. </summary>
    internal partial class FilterBlobSegment
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FilterBlobSegment"/>. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="where"></param>
        /// <param name="blobs"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpoint"/>, <paramref name="where"/> or <paramref name="blobs"/> is null. </exception>
        internal FilterBlobSegment(string serviceEndpoint, string @where, IEnumerable<FilterBlobItem> blobs)
        {
            Argument.AssertNotNull(serviceEndpoint, nameof(serviceEndpoint));
            Argument.AssertNotNull(@where, nameof(@where));
            Argument.AssertNotNull(blobs, nameof(blobs));

            ServiceEndpoint = serviceEndpoint;
            Where = @where;
            Blobs = blobs.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="FilterBlobSegment"/>. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="where"></param>
        /// <param name="blobs"></param>
        /// <param name="nextMarker"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FilterBlobSegment(string serviceEndpoint, string @where, IReadOnlyList<FilterBlobItem> blobs, string nextMarker, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServiceEndpoint = serviceEndpoint;
            Where = @where;
            Blobs = blobs;
            NextMarker = nextMarker;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FilterBlobSegment"/> for deserialization. </summary>
        internal FilterBlobSegment()
        {
        }

        /// <summary> Gets the service endpoint. </summary>
        public string ServiceEndpoint { get; }
        /// <summary> Gets the where. </summary>
        public string Where { get; }
        /// <summary> Gets the blobs. </summary>
        public IReadOnlyList<FilterBlobItem> Blobs { get; }
        /// <summary> Gets the next marker. </summary>
        public string NextMarker { get; }
    }
}
