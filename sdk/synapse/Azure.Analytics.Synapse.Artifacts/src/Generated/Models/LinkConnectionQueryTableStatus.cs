// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkConnectionQueryTableStatus. </summary>
    public partial class LinkConnectionQueryTableStatus
    {
        /// <summary> Initializes a new instance of LinkConnectionQueryTableStatus. </summary>
        internal LinkConnectionQueryTableStatus()
        {
            Value = new Core.ChangeTrackingList<LinkTableStatus>();
        }

        /// <summary> Initializes a new instance of LinkConnectionQueryTableStatus. </summary>
        /// <param name="value"> Link tables' status. </param>
        /// <param name="continuationToken"> Continuation token to query table status. </param>
        internal LinkConnectionQueryTableStatus(IReadOnlyList<LinkTableStatus> value, object continuationToken)
        {
            Value = value;
            ContinuationToken = continuationToken;
        }

        /// <summary> Link tables' status. </summary>
        public IReadOnlyList<LinkTableStatus> Value { get; }
        /// <summary> Continuation token to query table status. </summary>
        public object ContinuationToken { get; }
    }
}
