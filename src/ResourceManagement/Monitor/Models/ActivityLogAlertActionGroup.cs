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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A pointer to an Azure Action Group.
    /// </summary>
    public partial class ActivityLogAlertActionGroup
    {
        /// <summary>
        /// Initializes a new instance of the ActivityLogAlertActionGroup
        /// class.
        /// </summary>
        public ActivityLogAlertActionGroup()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityLogAlertActionGroup
        /// class.
        /// </summary>
        /// <param name="actionGroupId">The resourceId of the action group.
        /// This cannot be null or empty.</param>
        /// <param name="webhookProperties">the dictionary of custom properties
        /// to include with the post operation. These data are appended to the
        /// webhook payload.</param>
        public ActivityLogAlertActionGroup(string actionGroupId, IDictionary<string, string> webhookProperties = default(IDictionary<string, string>))
        {
            ActionGroupId = actionGroupId;
            WebhookProperties = webhookProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resourceId of the action group. This cannot be
        /// null or empty.
        /// </summary>
        [JsonProperty(PropertyName = "actionGroupId")]
        public string ActionGroupId { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of custom properties to include with
        /// the post operation. These data are appended to the webhook payload.
        /// </summary>
        [JsonProperty(PropertyName = "webhookProperties")]
        public IDictionary<string, string> WebhookProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ActionGroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ActionGroupId");
            }
        }
    }
}
