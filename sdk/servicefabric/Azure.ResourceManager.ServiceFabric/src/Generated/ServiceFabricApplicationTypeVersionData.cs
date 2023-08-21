// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    /// <summary>
    /// A class representing the ServiceFabricApplicationTypeVersion data model.
    /// An application type version resource for the specified application type name resource.
    /// </summary>
    public partial class ServiceFabricApplicationTypeVersionData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ServiceFabricApplicationTypeVersionData. </summary>
        /// <param name="location"> The location. </param>
        public ServiceFabricApplicationTypeVersionData(AzureLocation location) : base(location)
        {
            DefaultParameterList = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ServiceFabricApplicationTypeVersionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The current deployment or provisioning state, which only appears in the response. </param>
        /// <param name="appPackageUri"> The URL to the application package. </param>
        /// <param name="defaultParameterList"> List of application type parameters that can be overridden when creating or updating the application. </param>
        /// <param name="etag"> Azure resource etag. </param>
        internal ServiceFabricApplicationTypeVersionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string provisioningState, Uri appPackageUri, IReadOnlyDictionary<string, string> defaultParameterList, ETag? etag) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            AppPackageUri = appPackageUri;
            DefaultParameterList = defaultParameterList;
            ETag = etag;
        }

        /// <summary> The current deployment or provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The URL to the application package. </summary>
        public Uri AppPackageUri { get; set; }
        /// <summary> List of application type parameters that can be overridden when creating or updating the application. </summary>
        public IReadOnlyDictionary<string, string> DefaultParameterList { get; }
        /// <summary> Azure resource etag. </summary>
        public ETag? ETag { get; }
    }
}
