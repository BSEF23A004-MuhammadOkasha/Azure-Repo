// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The response of the List Namespace IDs operation. </summary>
    internal partial class EHNamespaceIdListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EHNamespaceIdListResult"/>. </summary>
        internal EHNamespaceIdListResult()
        {
            Value = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="EHNamespaceIdListResult"/>. </summary>
        /// <param name="value"> Result of the List Namespace IDs operation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EHNamespaceIdListResult(IReadOnlyList<SubResource> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Result of the List Namespace IDs operation. </summary>
        public IReadOnlyList<SubResource> Value { get; }
    }
}
