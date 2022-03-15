// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the TemplateSpecVersion data model. </summary>
    public partial class TemplateSpecVersionData : ResourceData
    {
        /// <summary> Initializes a new instance of TemplateSpecVersionData. </summary>
        /// <param name="location"> The location of the Template Spec Version. It must match the location of the parent Template Spec. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public TemplateSpecVersionData(string location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
            LinkedTemplates = new ChangeTrackingList<LinkedTemplateArtifact>();
        }

        /// <summary> Initializes a new instance of TemplateSpecVersionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The location of the Template Spec Version. It must match the location of the parent Template Spec. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="description"> Template Spec version description. </param>
        /// <param name="linkedTemplates"> An array of linked template artifacts. </param>
        /// <param name="metadata"> The version metadata. Metadata is an open-ended object and is typically a collection of key-value pairs. </param>
        /// <param name="mainTemplate"> The main Azure Resource Manager template content. </param>
        /// <param name="uiFormDefinition"> The Azure Resource Manager template UI definition content. </param>
        internal TemplateSpecVersionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string location, IDictionary<string, string> tags, string description, IList<LinkedTemplateArtifact> linkedTemplates, object metadata, object mainTemplate, object uiFormDefinition) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Tags = tags;
            Description = description;
            LinkedTemplates = linkedTemplates;
            Metadata = metadata;
            MainTemplate = mainTemplate;
            UiFormDefinition = uiFormDefinition;
        }

        /// <summary> The location of the Template Spec Version. It must match the location of the parent Template Spec. </summary>
        public string Location { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Template Spec version description. </summary>
        public string Description { get; set; }
        /// <summary> An array of linked template artifacts. </summary>
        public IList<LinkedTemplateArtifact> LinkedTemplates { get; }
        /// <summary> The version metadata. Metadata is an open-ended object and is typically a collection of key-value pairs. </summary>
        public object Metadata { get; set; }
        /// <summary> The main Azure Resource Manager template content. </summary>
        public object MainTemplate { get; set; }
        /// <summary> The Azure Resource Manager template UI definition content. </summary>
        public object UiFormDefinition { get; set; }
    }
}
