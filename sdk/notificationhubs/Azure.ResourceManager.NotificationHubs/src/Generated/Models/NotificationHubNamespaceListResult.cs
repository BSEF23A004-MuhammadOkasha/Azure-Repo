// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NotificationHubs;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> The response of the List Namespace operation. </summary>
    internal partial class NotificationHubNamespaceListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NotificationHubNamespaceListResult"/>. </summary>
        internal NotificationHubNamespaceListResult()
        {
            Value = new ChangeTrackingList<NotificationHubNamespaceData>();
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubNamespaceListResult"/>. </summary>
        /// <param name="value"> Result of the List Namespace operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of Namespaces. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationHubNamespaceListResult(IReadOnlyList<NotificationHubNamespaceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Result of the List Namespace operation. </summary>
        public IReadOnlyList<NotificationHubNamespaceData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of Namespaces. </summary>
        public string NextLink { get; }
    }
}
