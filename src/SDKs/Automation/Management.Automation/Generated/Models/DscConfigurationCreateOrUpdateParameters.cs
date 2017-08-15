// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Automation;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create or update configuration
    /// operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DscConfigurationCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DscConfigurationCreateOrUpdateParameters class.
        /// </summary>
        public DscConfigurationCreateOrUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DscConfigurationCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="source">Gets or sets the source.</param>
        /// <param name="logVerbose">Gets or sets verbose log option.</param>
        /// <param name="logProgress">Gets or sets progress log option.</param>
        /// <param name="parameters">Gets or sets the configuration
        /// parameters.</param>
        /// <param name="description">Gets or sets the description of the
        /// configuration.</param>
        /// <param name="name">Gets or sets name of the resource.</param>
        /// <param name="location">Gets or sets the location of the
        /// resource.</param>
        /// <param name="tags">Gets or sets the tags attached to the
        /// resource.</param>
        public DscConfigurationCreateOrUpdateParameters(ContentSource source, bool? logVerbose = default(bool?), bool? logProgress = default(bool?), IDictionary<string, DscConfigurationParameter> parameters = default(IDictionary<string, DscConfigurationParameter>), string description = default(string), string name = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            LogVerbose = logVerbose;
            LogProgress = logProgress;
            Source = source;
            Parameters = parameters;
            Description = description;
            Name = name;
            Location = location;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets verbose log option.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logVerbose")]
        public bool? LogVerbose { get; set; }

        /// <summary>
        /// Gets or sets progress log option.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logProgress")]
        public bool? LogProgress { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public ContentSource Source { get; set; }

        /// <summary>
        /// Gets or sets the configuration parameters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, DscConfigurationParameter> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the description of the configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the tags attached to the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (Source != null)
            {
                Source.Validate();
            }
        }
    }
}
