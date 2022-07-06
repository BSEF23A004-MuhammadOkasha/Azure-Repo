// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Autoscale notification. </summary>
    public partial class AutoscaleNotification
    {
        /// <summary> Initializes a new instance of AutoscaleNotification. </summary>
        public AutoscaleNotification()
        {
            Operation = MonitorOperationType.Scale;
            Webhooks = new ChangeTrackingList<WebhookNotification>();
        }

        /// <summary> Initializes a new instance of AutoscaleNotification. </summary>
        /// <param name="operation"> the operation associated with the notification and its value must be &quot;scale&quot;. </param>
        /// <param name="email"> the email notification. </param>
        /// <param name="webhooks"> the collection of webhook notifications. </param>
        internal AutoscaleNotification(MonitorOperationType operation, EmailNotification email, IList<WebhookNotification> webhooks)
        {
            Operation = operation;
            Email = email;
            Webhooks = webhooks;
        }

        /// <summary> the operation associated with the notification and its value must be &quot;scale&quot;. </summary>
        public MonitorOperationType Operation { get; set; }
        /// <summary> the email notification. </summary>
        public EmailNotification Email { get; set; }
        /// <summary> the collection of webhook notifications. </summary>
        public IList<WebhookNotification> Webhooks { get; }
    }
}
