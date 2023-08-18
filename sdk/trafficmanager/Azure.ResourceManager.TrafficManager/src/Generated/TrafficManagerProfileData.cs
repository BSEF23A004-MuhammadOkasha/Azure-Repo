// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary>
    /// A class representing the TrafficManagerProfile data model.
    /// Class representing a Traffic Manager profile.
    /// </summary>
    public partial class TrafficManagerProfileData : TrafficManagerTrackedResourceData
    {
        /// <summary> Initializes a new instance of TrafficManagerProfileData. </summary>
        public TrafficManagerProfileData()
        {
            Endpoints = new Core.ChangeTrackingList<TrafficManagerEndpointData>();
            AllowedEndpointRecordTypes = new Core.ChangeTrackingList<AllowedEndpointRecordType>();
        }

        /// <summary> Initializes a new instance of TrafficManagerProfileData. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="resourceType"> The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The Azure Region where the resource lives. </param>
        /// <param name="profileStatus"> The status of the Traffic Manager profile. </param>
        /// <param name="trafficRoutingMethod"> The traffic routing method of the Traffic Manager profile. </param>
        /// <param name="dnsConfig"> The DNS settings of the Traffic Manager profile. </param>
        /// <param name="monitorConfig"> The endpoint monitoring settings of the Traffic Manager profile. </param>
        /// <param name="endpoints"> The list of endpoints in the Traffic Manager profile. </param>
        /// <param name="trafficViewEnrollmentStatus"> Indicates whether Traffic View is 'Enabled' or 'Disabled' for the Traffic Manager profile. Null, indicates 'Disabled'. Enabling this feature will increase the cost of the Traffic Manage profile. </param>
        /// <param name="allowedEndpointRecordTypes"> The list of allowed endpoint record types. </param>
        /// <param name="maxReturn"> Maximum number of endpoints to be returned for MultiValue routing type. </param>
        internal TrafficManagerProfileData(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, string> tags, AzureLocation? location, TrafficManagerProfileStatus? profileStatus, TrafficRoutingMethod? trafficRoutingMethod, TrafficManagerDnsConfig dnsConfig, TrafficManagerMonitorConfig monitorConfig, IList<TrafficManagerEndpointData> endpoints, TrafficViewEnrollmentStatus? trafficViewEnrollmentStatus, IList<AllowedEndpointRecordType> allowedEndpointRecordTypes, long? maxReturn) : base(id, name, resourceType, tags, location)
        {
            ProfileStatus = profileStatus;
            TrafficRoutingMethod = trafficRoutingMethod;
            DnsConfig = dnsConfig;
            MonitorConfig = monitorConfig;
            Endpoints = endpoints;
            TrafficViewEnrollmentStatus = trafficViewEnrollmentStatus;
            AllowedEndpointRecordTypes = allowedEndpointRecordTypes;
            MaxReturn = maxReturn;
        }

        /// <summary> The status of the Traffic Manager profile. </summary>
        public TrafficManagerProfileStatus? ProfileStatus { get; set; }
        /// <summary> The traffic routing method of the Traffic Manager profile. </summary>
        public TrafficRoutingMethod? TrafficRoutingMethod { get; set; }
        /// <summary> The DNS settings of the Traffic Manager profile. </summary>
        public TrafficManagerDnsConfig DnsConfig { get; set; }
        /// <summary> The endpoint monitoring settings of the Traffic Manager profile. </summary>
        public TrafficManagerMonitorConfig MonitorConfig { get; set; }
        /// <summary> The list of endpoints in the Traffic Manager profile. </summary>
        public IList<TrafficManagerEndpointData> Endpoints { get; }
        /// <summary> Indicates whether Traffic View is 'Enabled' or 'Disabled' for the Traffic Manager profile. Null, indicates 'Disabled'. Enabling this feature will increase the cost of the Traffic Manage profile. </summary>
        public TrafficViewEnrollmentStatus? TrafficViewEnrollmentStatus { get; set; }
        /// <summary> The list of allowed endpoint record types. </summary>
        public IList<AllowedEndpointRecordType> AllowedEndpointRecordTypes { get; }
        /// <summary> Maximum number of endpoints to be returned for MultiValue routing type. </summary>
        public long? MaxReturn { get; set; }
    }
}
