// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Core
{
    /// <summary> Resource information. </summary>
    public partial class GenericResourceExpandedData : GenericResourceData
    {
        /// <summary> Initializes a new instance of GenericResourceExpanded. </summary>
        public GenericResourceExpandedData()
        {
        }

        /// <summary> Initializes a new instance of GenericResourceExpanded. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="plan"> The plan of the resource. </param>
        /// <param name="properties"> The resource properties. </param>
        /// <param name="kind"> The kind of the resource. </param>
        /// <param name="managedBy"> ID of the resource that manages this resource. </param>
        /// <param name="sku"> The SKU of the resource. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="createdTime"> The created time of the resource. This is only present if requested via the $expand query parameter. </param>
        /// <param name="changedTime"> The changed time of the resource. This is only present if requested via the $expand query parameter. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. This is only present if requested via the $expand query parameter. </param>
        internal GenericResourceExpandedData(string id, string name, string type, string location, IDictionary<string, string> tags, Plan plan, object properties, string kind, string managedBy, Sku sku, Identity identity, DateTimeOffset? createdTime, DateTimeOffset? changedTime, string provisioningState) : base(id, name, type, location, tags, plan, properties, kind, managedBy, sku, identity)
        {
            CreatedTime = createdTime;
            ChangedTime = changedTime;
            ProvisioningState = provisioningState;
        }

        /// <summary> The created time of the resource. This is only present if requested via the $expand query parameter. </summary>
        public DateTimeOffset? CreatedTime { get; }
        /// <summary> The changed time of the resource. This is only present if requested via the $expand query parameter. </summary>
        public DateTimeOffset? ChangedTime { get; }
        /// <summary> The provisioning state of the resource. This is only present if requested via the $expand query parameter. </summary>
        public string ProvisioningState { get; }
    }
}
