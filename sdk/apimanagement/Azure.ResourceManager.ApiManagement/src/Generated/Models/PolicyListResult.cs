// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The response of the list policy operation. </summary>
    internal partial class PolicyListResult
    {
        /// <summary> Initializes a new instance of PolicyListResult. </summary>
        internal PolicyListResult()
        {
            Value = new ChangeTrackingList<PolicyContractData>();
        }

        /// <summary> Initializes a new instance of PolicyListResult. </summary>
        /// <param name="value"> Policy Contract value. </param>
        /// <param name="count"> Total record count number. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        internal PolicyListResult(IReadOnlyList<PolicyContractData> value, long? count, string nextLink)
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
        }

        /// <summary> Policy Contract value. </summary>
        public IReadOnlyList<PolicyContractData> Value { get; }
        /// <summary> Total record count number. </summary>
        public long? Count { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
