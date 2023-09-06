// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Notification preference for a job stage. </summary>
    public partial class NotificationPreference
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NotificationPreference"/>. </summary>
        /// <param name="stageName"> Name of the stage. </param>
        /// <param name="isNotificationRequired"> Notification is required or not. </param>
        public NotificationPreference(NotificationStageName stageName, bool isNotificationRequired)
        {
            StageName = stageName;
            IsNotificationRequired = isNotificationRequired;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationPreference"/>. </summary>
        /// <param name="stageName"> Name of the stage. </param>
        /// <param name="isNotificationRequired"> Notification is required or not. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationPreference(NotificationStageName stageName, bool isNotificationRequired, Dictionary<string, BinaryData> rawData)
        {
            StageName = stageName;
            IsNotificationRequired = isNotificationRequired;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationPreference"/> for deserialization. </summary>
        internal NotificationPreference()
        {
        }

        /// <summary> Name of the stage. </summary>
        public NotificationStageName StageName { get; set; }
        /// <summary> Notification is required or not. </summary>
        public bool IsNotificationRequired { get; set; }
    }
}
