// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a published blueprint.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PublishedBlueprint : AzureResourceBase
    {
        /// <summary>
        /// Initializes a new instance of the PublishedBlueprint class.
        /// </summary>
        public PublishedBlueprint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublishedBlueprint class.
        /// </summary>
        /// <param name="id">String Id used to locate any resource on
        /// Azure.</param>
        /// <param name="type">Type of this resource.</param>
        /// <param name="name">Name of this resource.</param>
        /// <param name="displayName">One-liner string explain this
        /// resource.</param>
        /// <param name="description">Multi-line explain this resource.</param>
        /// <param name="status">Status of the blueprint. This field is
        /// readonly.</param>
        /// <param name="targetScope">The scope where this blueprint definition
        /// can be assigned. Management group is reserved for future use.
        /// Possible values include: 'subscription', 'managementGroup'</param>
        /// <param name="parameters">Parameters required by this blueprint
        /// definition.</param>
        /// <param name="resourceGroups">Resource group placeholders defined by
        /// this blueprint definition.</param>
        /// <param name="blueprintName">Name of the published blueprint
        /// definition.</param>
        /// <param name="changeNotes">Version-specific change notes.</param>
        public PublishedBlueprint(string id = default(string), string type = default(string), string name = default(string), string displayName = default(string), string description = default(string), BlueprintStatus status = default(BlueprintStatus), BlueprintTargetScope? targetScope = default(BlueprintTargetScope?), IDictionary<string, ParameterDefinition> parameters = default(IDictionary<string, ParameterDefinition>), IDictionary<string, ResourceGroupDefinition> resourceGroups = default(IDictionary<string, ResourceGroupDefinition>), string blueprintName = default(string), string changeNotes = default(string))
            : base(id, type, name)
        {
            DisplayName = displayName;
            Description = description;
            Status = status;
            TargetScope = targetScope;
            Parameters = parameters;
            ResourceGroups = resourceGroups;
            BlueprintName = blueprintName;
            ChangeNotes = changeNotes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets one-liner string explain this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets multi-line explain this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets status of the blueprint. This field is readonly.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public BlueprintStatus Status { get; private set; }

        /// <summary>
        /// Gets or sets the scope where this blueprint definition can be
        /// assigned. Management group is reserved for future use. Possible
        /// values include: 'subscription', 'managementGroup'
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetScope")]
        public BlueprintTargetScope? TargetScope { get; set; }

        /// <summary>
        /// Gets or sets parameters required by this blueprint definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, ParameterDefinition> Parameters { get; set; }

        /// <summary>
        /// Gets or sets resource group placeholders defined by this blueprint
        /// definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroups")]
        public IDictionary<string, ResourceGroupDefinition> ResourceGroups { get; set; }

        /// <summary>
        /// Gets or sets name of the published blueprint definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.blueprintName")]
        public string BlueprintName { get; set; }

        /// <summary>
        /// Gets or sets version-specific change notes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changeNotes")]
        public string ChangeNotes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName != null)
            {
                if (DisplayName.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 256);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 500)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 500);
                }
            }
            if (Parameters != null)
            {
                foreach (var valueElement in Parameters.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
            if (ResourceGroups != null)
            {
                foreach (var valueElement1 in ResourceGroups.Values)
                {
                    if (valueElement1 != null)
                    {
                        valueElement1.Validate();
                    }
                }
            }
            if (ChangeNotes != null)
            {
                if (ChangeNotes.Length > 500)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ChangeNotes", 500);
                }
            }
        }
    }
}
