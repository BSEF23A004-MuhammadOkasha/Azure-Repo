// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> details of synchronization. </summary>
    internal partial class SynchronizationDetailsList
    {
        /// <summary> Initializes a new instance of SynchronizationDetailsList. </summary>
        /// <param name="value"> Collection of items of type DataTransferObjects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SynchronizationDetailsList(IEnumerable<SynchronizationDetails> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of SynchronizationDetailsList. </summary>
        /// <param name="nextLink"> The Url of next result page. </param>
        /// <param name="value"> Collection of items of type DataTransferObjects. </param>
        internal SynchronizationDetailsList(string nextLink, IReadOnlyList<SynchronizationDetails> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The Url of next result page. </summary>
        public string NextLink { get; }
        /// <summary> Collection of items of type DataTransferObjects. </summary>
        public IReadOnlyList<SynchronizationDetails> Value { get; }
    }
}
