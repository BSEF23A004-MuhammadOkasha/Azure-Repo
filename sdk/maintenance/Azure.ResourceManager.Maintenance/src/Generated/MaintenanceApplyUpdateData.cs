// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Maintenance.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Maintenance
{
    /// <summary>
    /// A class representing the MaintenanceApplyUpdate data model.
    /// Apply Update request
    /// </summary>
    public partial class MaintenanceApplyUpdateData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MaintenanceApplyUpdateData"/>. </summary>
        public MaintenanceApplyUpdateData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MaintenanceApplyUpdateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> The status. </param>
        /// <param name="resourceId"> The resourceId. </param>
        /// <param name="lastUpdatedOn"> Last Update time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MaintenanceApplyUpdateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MaintenanceUpdateStatus? status, ResourceIdentifier resourceId, DateTimeOffset? lastUpdatedOn, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Status = status;
            ResourceId = resourceId;
            LastUpdatedOn = lastUpdatedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status. </summary>
        public MaintenanceUpdateStatus? Status { get; set; }
        /// <summary> The resourceId. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> Last Update time. </summary>
        public DateTimeOffset? LastUpdatedOn { get; set; }
    }
}
