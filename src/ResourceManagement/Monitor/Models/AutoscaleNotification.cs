// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.Fluent.ServiceBus;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Autoscale notification.
    /// </summary>
    public partial class AutoscaleNotification
    {
        /// <summary>
        /// Initializes a new instance of the AutoscaleNotification class.
        /// </summary>
        public AutoscaleNotification()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoscaleNotification class.
        /// </summary>
        /// <param name="email">the email notification.</param>
        /// <param name="webhooks">the collection of webhook
        /// notifications.</param>
        public AutoscaleNotification(EmailNotification email = default(EmailNotification), IList<WebhookNotification> webhooks = default(IList<WebhookNotification>))
        {
            Email = email;
            Webhooks = webhooks;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for AutoscaleNotification class.
        /// </summary>
        static AutoscaleNotification()
        {
            Operation = "Scale";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the email notification.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public EmailNotification Email { get; set; }

        /// <summary>
        /// Gets or sets the collection of webhook notifications.
        /// </summary>
        [JsonProperty(PropertyName = "webhooks")]
        public IList<WebhookNotification> Webhooks { get; set; }

        /// <summary>
        /// the operation associated with the notification and its value must
        /// be "scale"
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public static string Operation { get; private set; }

    }
}
