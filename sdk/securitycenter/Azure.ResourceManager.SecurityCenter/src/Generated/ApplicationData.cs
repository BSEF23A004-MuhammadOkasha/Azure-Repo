// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary> A class representing the Application data model. </summary>
    public partial class ApplicationData : ResourceData
    {
        /// <summary> Initializes a new instance of ApplicationData. </summary>
        public ApplicationData()
        {
            ConditionSets = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of ApplicationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> display name of the application. </param>
        /// <param name="description"> description of the application. </param>
        /// <param name="sourceResourceType"> The application source, what it affects, e.g. Assessments. </param>
        /// <param name="conditionSets"> The application conditionSets - see examples. </param>
        internal ApplicationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string description, ApplicationSourceResourceType? sourceResourceType, IList<BinaryData> conditionSets) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Description = description;
            SourceResourceType = sourceResourceType;
            ConditionSets = conditionSets;
        }

        /// <summary> display name of the application. </summary>
        public string DisplayName { get; set; }
        /// <summary> description of the application. </summary>
        public string Description { get; set; }
        /// <summary> The application source, what it affects, e.g. Assessments. </summary>
        public ApplicationSourceResourceType? SourceResourceType { get; set; }
        /// <summary> The application conditionSets - see examples. </summary>
        public IList<BinaryData> ConditionSets { get; }
    }
}
