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
    /// Specifies the action to post to service when the rule condition is
    /// evaluated. The discriminator is always RuleWebhookAction in this case.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Azure.Management.Insights.Models.RuleWebhookAction")]
    public partial class RuleWebhookAction : RuleAction
    {
        /// <summary>
        /// Initializes a new instance of the RuleWebhookAction class.
        /// </summary>
        public RuleWebhookAction()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RuleWebhookAction class.
        /// </summary>
        /// <param name="serviceUri">the service uri to Post the notitication
        /// when the alert activates or resolves.</param>
        /// <param name="properties">the dictionary of custom properties to
        /// include with the post operation. These data are appended to the
        /// webhook payload.</param>
        public RuleWebhookAction(string serviceUri = default(string), IDictionary<string, string> properties = default(IDictionary<string, string>))
        {
            ServiceUri = serviceUri;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the service uri to Post the notitication when the
        /// alert activates or resolves.
        /// </summary>
        [JsonProperty(PropertyName = "serviceUri")]
        public string ServiceUri { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of custom properties to include with
        /// the post operation. These data are appended to the webhook payload.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

    }
}
