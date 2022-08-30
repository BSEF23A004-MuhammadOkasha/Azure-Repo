// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary> A class representing the VirtualApplicationGroup data model. </summary>
    public partial class VirtualApplicationGroupData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualApplicationGroupData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="hostPoolId"> HostPool arm path of ApplicationGroup. </param>
        /// <param name="applicationGroupType"> Resource Type of ApplicationGroup. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolId"/> is null. </exception>
        public VirtualApplicationGroupData(AzureLocation location, ResourceIdentifier hostPoolId, VirtualApplicationGroupType applicationGroupType) : base(location)
        {
            if (hostPoolId == null)
            {
                throw new ArgumentNullException(nameof(hostPoolId));
            }

            HostPoolId = hostPoolId;
            ApplicationGroupType = applicationGroupType;
        }

        /// <summary> Initializes a new instance of VirtualApplicationGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="objectId"> ObjectId of ApplicationGroup. (internal use). </param>
        /// <param name="description"> Description of ApplicationGroup. </param>
        /// <param name="friendlyName"> Friendly name of ApplicationGroup. </param>
        /// <param name="hostPoolId"> HostPool arm path of ApplicationGroup. </param>
        /// <param name="workspaceId"> Workspace arm path of ApplicationGroup. </param>
        /// <param name="applicationGroupType"> Resource Type of ApplicationGroup. </param>
        /// <param name="migrationRequest"> The registration info of HostPool. </param>
        /// <param name="isCloudPCResource"> Is cloud pc resource. </param>
        /// <param name="managedBy"> The fully qualified resource ID of the resource that manages this resource. Indicates if this resource is managed by another Azure resource. If this is present, complete mode deployment will not delete the resource if it is removed from the template since it is managed by another resource. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="etag"> The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </param>
        /// <param name="identity"> Gets or sets the identity. Current supported identity types: SystemAssigned. </param>
        /// <param name="sku"> The resource model definition representing SKU. </param>
        /// <param name="plan"> Gets or sets the plan. </param>
        internal VirtualApplicationGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string objectId, string description, string friendlyName, ResourceIdentifier hostPoolId, ResourceIdentifier workspaceId, VirtualApplicationGroupType applicationGroupType, DesktopVirtualizationMigrationProperties migrationRequest, bool? isCloudPCResource, ResourceIdentifier managedBy, string kind, ETag? etag, ManagedServiceIdentity identity, DesktopVirtualizationSku sku, ArmPlan plan) : base(id, name, resourceType, systemData, tags, location)
        {
            ObjectId = objectId;
            Description = description;
            FriendlyName = friendlyName;
            HostPoolId = hostPoolId;
            WorkspaceId = workspaceId;
            ApplicationGroupType = applicationGroupType;
            MigrationRequest = migrationRequest;
            IsCloudPCResource = isCloudPCResource;
            ManagedBy = managedBy;
            Kind = kind;
            ETag = etag;
            Identity = identity;
            Sku = sku;
            Plan = plan;
        }

        /// <summary> ObjectId of ApplicationGroup. (internal use). </summary>
        public string ObjectId { get; }
        /// <summary> Description of ApplicationGroup. </summary>
        public string Description { get; set; }
        /// <summary> Friendly name of ApplicationGroup. </summary>
        public string FriendlyName { get; set; }
        /// <summary> HostPool arm path of ApplicationGroup. </summary>
        public ResourceIdentifier HostPoolId { get; set; }
        /// <summary> Workspace arm path of ApplicationGroup. </summary>
        public ResourceIdentifier WorkspaceId { get; }
        /// <summary> Resource Type of ApplicationGroup. </summary>
        public VirtualApplicationGroupType ApplicationGroupType { get; set; }
        /// <summary> The registration info of HostPool. </summary>
        public DesktopVirtualizationMigrationProperties MigrationRequest { get; set; }
        /// <summary> Is cloud pc resource. </summary>
        public bool? IsCloudPCResource { get; }
        /// <summary> The fully qualified resource ID of the resource that manages this resource. Indicates if this resource is managed by another Azure resource. If this is present, complete mode deployment will not delete the resource if it is removed from the template since it is managed by another resource. </summary>
        public ResourceIdentifier ManagedBy { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </summary>
        public string Kind { get; set; }
        /// <summary> The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </summary>
        public ETag? ETag { get; }
        /// <summary> Gets or sets the identity. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The resource model definition representing SKU. </summary>
        public DesktopVirtualizationSku Sku { get; set; }
        /// <summary> Gets or sets the plan. </summary>
        public ArmPlan Plan { get; set; }
    }
}
