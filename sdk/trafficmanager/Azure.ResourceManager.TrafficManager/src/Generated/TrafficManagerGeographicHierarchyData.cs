// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary> A class representing the TrafficManagerGeographicHierarchy data model. </summary>
    public partial class TrafficManagerGeographicHierarchyData : ProxyResource
    {
        /// <summary> Initializes a new instance of TrafficManagerGeographicHierarchyData. </summary>
        public TrafficManagerGeographicHierarchyData()
        {
        }

        /// <summary> Initializes a new instance of TrafficManagerGeographicHierarchyData. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="resourceType"> The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles. </param>
        /// <param name="geographicHierarchy"> The region at the root of the hierarchy from all the regions in the hierarchy can be retrieved. </param>
        internal TrafficManagerGeographicHierarchyData(string id, string name, string resourceType, Region geographicHierarchy) : base(id, name, resourceType)
        {
            GeographicHierarchy = geographicHierarchy;
        }

        /// <summary> The region at the root of the hierarchy from all the regions in the hierarchy can be retrieved. </summary>
        public Region GeographicHierarchy { get; set; }
    }
}
