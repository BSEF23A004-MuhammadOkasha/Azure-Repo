// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseMaintenanceWindow data model.
    /// Maintenance windows.
    /// </summary>
    public partial class SynapseMaintenanceWindowData : ResourceData
    {
        /// <summary> Initializes a new instance of SynapseMaintenanceWindowData. </summary>
        public SynapseMaintenanceWindowData()
        {
            TimeRanges = new Core.ChangeTrackingList<SynapseMaintenanceWindowTimeRange>();
        }

        /// <summary> Initializes a new instance of SynapseMaintenanceWindowData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="timeRanges"></param>
        internal SynapseMaintenanceWindowData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<SynapseMaintenanceWindowTimeRange> timeRanges) : base(id, name, resourceType, systemData)
        {
            TimeRanges = timeRanges;
        }

        /// <summary> Gets the time ranges. </summary>
        public IList<SynapseMaintenanceWindowTimeRange> TimeRanges { get; }
    }
}
