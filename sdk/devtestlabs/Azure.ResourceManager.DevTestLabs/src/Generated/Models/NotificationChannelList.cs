// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> The response of a list operation. </summary>
    internal partial class NotificationChannelList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NotificationChannelList"/>. </summary>
        internal NotificationChannelList()
        {
            Value = new ChangeTrackingList<DevTestLabNotificationChannelData>();
        }

        /// <summary> Initializes a new instance of <see cref="NotificationChannelList"/>. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link for next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationChannelList(IReadOnlyList<DevTestLabNotificationChannelData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<DevTestLabNotificationChannelData> Value { get; }
        /// <summary> Link for next set of results. </summary>
        public string NextLink { get; }
    }
}
