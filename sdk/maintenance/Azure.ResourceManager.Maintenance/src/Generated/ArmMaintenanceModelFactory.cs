// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Maintenance;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Maintenance.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMaintenanceModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Maintenance.MaintenanceConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="namespace"> Gets or sets namespace of the resource. </param>
        /// <param name="extensionProperties"> Gets or sets extensionProperties of the maintenanceConfiguration. </param>
        /// <param name="maintenanceScope"> Gets or sets maintenanceScope of the configuration. </param>
        /// <param name="visibility"> Gets or sets the visibility of the configuration. The default value is 'Custom'. </param>
        /// <param name="installPatches"> The input parameters to be passed to the patch run operation. </param>
        /// <param name="startOn"> Effective start date of the maintenance window in YYYY-MM-DD hh:mm format. The start date can be set to either the current date or future date. The window will be created in the time zone provided and adjusted to daylight savings according to that time zone. </param>
        /// <param name="expireOn"> Effective expiration date of the maintenance window in YYYY-MM-DD hh:mm format. The window will be created in the time zone provided and adjusted to daylight savings according to that time zone. Expiration date must be set to a future date. If not provided, it will be set to the maximum datetime 9999-12-31 23:59:59. </param>
        /// <param name="duration"> Duration of the maintenance window in HH:mm format. If not provided, default value will be used based on maintenance scope provided. Example: 05:00. </param>
        /// <param name="timeZone"> Name of the timezone. List of timezones can be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell. Example: Pacific Standard Time, UTC, W. Europe Standard Time, Korea Standard Time, Cen. Australia Standard Time. </param>
        /// <param name="recurEvery"> Rate at which a Maintenance window is expected to recur. The rate can be expressed as daily, weekly, or monthly schedules. Daily schedule are formatted as recurEvery: [Frequency as integer]['Day(s)']. If no frequency is provided, the default frequency is 1. Daily schedule examples are recurEvery: Day, recurEvery: 3Days.  Weekly schedule are formatted as recurEvery: [Frequency as integer]['Week(s)'] [Optional comma separated list of weekdays Monday-Sunday]. Weekly schedule examples are recurEvery: 3Weeks, recurEvery: Week Saturday,Sunday. Monthly schedules are formatted as [Frequency as integer]['Month(s)'] [Comma separated list of month days] or [Frequency as integer]['Month(s)'] [Week of Month (First, Second, Third, Fourth, Last)] [Weekday Monday-Sunday] [Optional Offset(No. of days)]. Offset value must be between -6 to 6 inclusive. Monthly schedule examples are recurEvery: Month, recurEvery: 2Months, recurEvery: Month day23,day24, recurEvery: Month Last Sunday, recurEvery: Month Fourth Monday, recurEvery: Month Last Sunday Offset-3, recurEvery: Month Third Sunday Offset6. </param>
        /// <returns> A new <see cref="Maintenance.MaintenanceConfigurationData"/> instance for mocking. </returns>
        public static MaintenanceConfigurationData MaintenanceConfigurationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string @namespace = null, IDictionary<string, string> extensionProperties = null, MaintenanceScope? maintenanceScope = null, MaintenanceConfigurationVisibility? visibility = null, MaintenancePatchConfiguration installPatches = null, DateTimeOffset? startOn = null, DateTimeOffset? expireOn = null, TimeSpan? duration = null, string timeZone = null, string recurEvery = null)
        {
            tags ??= new Dictionary<string, string>();
            extensionProperties ??= new Dictionary<string, string>();

            return new MaintenanceConfigurationData(id, name, resourceType, systemData, tags, location, @namespace, extensionProperties, maintenanceScope, visibility, installPatches, startOn, expireOn, duration, timeZone, recurEvery, new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Maintenance.MaintenanceApplyUpdateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> The status. </param>
        /// <param name="resourceId"> The resourceId. </param>
        /// <param name="lastUpdatedOn"> Last Update time. </param>
        /// <returns> A new <see cref="Maintenance.MaintenanceApplyUpdateData"/> instance for mocking. </returns>
        public static MaintenanceApplyUpdateData MaintenanceApplyUpdateData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, MaintenanceUpdateStatus? status = null, ResourceIdentifier resourceId = null, DateTimeOffset? lastUpdatedOn = null)
        {
            return new MaintenanceApplyUpdateData(id, name, resourceType, systemData, status, resourceId, lastUpdatedOn, new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Models.MaintenanceConfigurationAssignmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Location of the resource. </param>
        /// <param name="maintenanceConfigurationId"> The maintenance configuration Id. </param>
        /// <param name="resourceId"> The unique resourceId. </param>
        /// <param name="filter"> Properties of the configuration assignment. </param>
        /// <returns> A new <see cref="Models.MaintenanceConfigurationAssignmentData"/> instance for mocking. </returns>
        public static MaintenanceConfigurationAssignmentData MaintenanceConfigurationAssignmentData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, AzureLocation? location = null, ResourceIdentifier maintenanceConfigurationId = null, ResourceIdentifier resourceId = null, MaintenanceConfigurationAssignmentFilter filter = null)
        {
            return new MaintenanceConfigurationAssignmentData(id, name, resourceType, systemData, location, maintenanceConfigurationId, resourceId, filter, new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Models.MaintenanceUpdate"/>. </summary>
        /// <param name="maintenanceScope"> The impact area. </param>
        /// <param name="impactType"> The impact type. </param>
        /// <param name="status"> The status. </param>
        /// <param name="impactDurationInSec"> Duration of impact in seconds. </param>
        /// <param name="notBefore"> Time when Azure will start force updates if not self-updated by customer before this time. </param>
        /// <param name="resourceId"> The resourceId. </param>
        /// <returns> A new <see cref="Models.MaintenanceUpdate"/> instance for mocking. </returns>
        public static MaintenanceUpdate MaintenanceUpdate(MaintenanceScope? maintenanceScope = null, MaintenanceImpactType? impactType = null, MaintenanceUpdateStatus? status = null, int? impactDurationInSec = null, DateTimeOffset? notBefore = null, ResourceIdentifier resourceId = null)
        {
            return new MaintenanceUpdate(maintenanceScope, impactType, status, impactDurationInSec, notBefore, resourceId, new Dictionary<string, BinaryData>());
        }
    }
}
