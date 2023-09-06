// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List Client operation. </summary>
    internal partial class ClientsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ClientsListResult"/>. </summary>
        internal ClientsListResult()
        {
            Value = new ChangeTrackingList<EventGridNamespaceClientData>();
        }

        /// <summary> Initializes a new instance of <see cref="ClientsListResult"/>. </summary>
        /// <param name="value"> A collection of Client. </param>
        /// <param name="nextLink"> A link for the next page of Client. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ClientsListResult(IReadOnlyList<EventGridNamespaceClientData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A collection of Client. </summary>
        public IReadOnlyList<EventGridNamespaceClientData> Value { get; }
        /// <summary> A link for the next page of Client. </summary>
        public string NextLink { get; }
    }
}
