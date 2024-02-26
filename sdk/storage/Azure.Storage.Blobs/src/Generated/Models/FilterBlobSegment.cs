// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The result of a Filter Blobs API call. </summary>
    internal partial class FilterBlobSegment
    {
        /// <summary> Initializes a new instance of <see cref="FilterBlobSegment"/>. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="where"></param>
        /// <param name="blobs"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpoint"/>, <paramref name="where"/> or <paramref name="blobs"/> is null. </exception>
        internal FilterBlobSegment(string serviceEndpoint, string @where, IEnumerable<FilterBlobItem> blobs)
        {
            if (serviceEndpoint == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpoint));
            }
            if (@where == null)
            {
                throw new ArgumentNullException(nameof(@where));
            }
            if (blobs == null)
            {
                throw new ArgumentNullException(nameof(blobs));
            }

            ServiceEndpoint = serviceEndpoint;
            Where = @where;
            Blobs = blobs.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="FilterBlobSegment"/>. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="where"></param>
        /// <param name="blobs"></param>
        /// <param name="nextMarker"></param>
        internal FilterBlobSegment(string serviceEndpoint, string @where, IReadOnlyList<FilterBlobItem> blobs, string nextMarker)
        {
            ServiceEndpoint = serviceEndpoint;
            Where = @where;
            Blobs = blobs;
            NextMarker = nextMarker;
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
