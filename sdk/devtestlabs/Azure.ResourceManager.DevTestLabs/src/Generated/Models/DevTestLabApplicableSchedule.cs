// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Schedules applicable to a virtual machine. The schedules may have been defined on a VM or on lab level. </summary>
    public partial class DevTestLabApplicableSchedule : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabApplicableSchedule"/>. </summary>
        /// <param name="location"> The location. </param>
        public DevTestLabApplicableSchedule(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabApplicableSchedule"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="labVmsShutdown"> The auto-shutdown schedule, if one has been set at the lab or lab resource level. </param>
        /// <param name="labVmsStartup"> The auto-startup schedule, if one has been set at the lab or lab resource level. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabApplicableSchedule(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DevTestLabScheduleData labVmsShutdown, DevTestLabScheduleData labVmsStartup, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            LabVmsShutdown = labVmsShutdown;
            LabVmsStartup = labVmsStartup;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabApplicableSchedule"/> for deserialization. </summary>
        internal DevTestLabApplicableSchedule()
        {
        }

        /// <summary> The auto-shutdown schedule, if one has been set at the lab or lab resource level. </summary>
        public DevTestLabScheduleData LabVmsShutdown { get; set; }
        /// <summary> The auto-startup schedule, if one has been set at the lab or lab resource level. </summary>
        public DevTestLabScheduleData LabVmsStartup { get; set; }
    }
}
