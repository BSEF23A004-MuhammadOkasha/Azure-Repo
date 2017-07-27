// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Monitor;
    using Microsoft.Azure.Management.Monitor.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The log profile resource for patch operations.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LogProfileResourcePatch
    {
        /// <summary>
        /// Initializes a new instance of the LogProfileResourcePatch class.
        /// </summary>
        public LogProfileResourcePatch() { }

        /// <summary>
        /// Initializes a new instance of the LogProfileResourcePatch class.
        /// </summary>
        /// <param name="locations">List of regions for which Activity Log
        /// events should be stored or streamed. It is a comma separated list
        /// of valid ARM locations including the 'global' location.</param>
        /// <param name="categories">the categories of the logs. These
        /// categories are created as is convenient to the user. Some values
        /// are: 'Write', 'Delete', and/or 'Action.'</param>
        /// <param name="retentionPolicy">the retention policy for the events
        /// in the log.</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="storageAccountId">the resource id of the storage
        /// account to which you would like to send the Activity Log.</param>
        /// <param name="serviceBusRuleId">The service bus rule ID of the
        /// service bus namespace in which you would like to have Event Hubs
        /// created for streaming the Activity Log. The rule ID is of the
        /// format: '{service bus resource ID}/authorizationrules/{key
        /// name}'.</param>
        public LogProfileResourcePatch(IList<string> locations, IList<string> categories, RetentionPolicy retentionPolicy, IDictionary<string, string> tags = default(IDictionary<string, string>), string storageAccountId = default(string), string serviceBusRuleId = default(string))
        {
            Tags = tags;
            StorageAccountId = storageAccountId;
            ServiceBusRuleId = serviceBusRuleId;
            Locations = locations;
            Categories = categories;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the resource id of the storage account to which you
        /// would like to send the Activity Log.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the service bus rule ID of the service bus namespace
        /// in which you would like to have Event Hubs created for streaming
        /// the Activity Log. The rule ID is of the format: '{service bus
        /// resource ID}/authorizationrules/{key name}'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceBusRuleId")]
        public string ServiceBusRuleId { get; set; }

        /// <summary>
        /// Gets or sets list of regions for which Activity Log events should
        /// be stored or streamed. It is a comma separated list of valid ARM
        /// locations including the 'global' location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.locations")]
        public IList<string> Locations { get; set; }

        /// <summary>
        /// Gets or sets the categories of the logs. These categories are
        /// created as is convenient to the user. Some values are: 'Write',
        /// 'Delete', and/or 'Action.'
        /// </summary>
        [JsonProperty(PropertyName = "properties.categories")]
        public IList<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the retention policy for the events in the log.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Locations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Locations");
            }
            if (Categories == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Categories");
            }
            if (RetentionPolicy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RetentionPolicy");
            }
            if (RetentionPolicy != null)
            {
                RetentionPolicy.Validate();
            }
        }
    }
}
