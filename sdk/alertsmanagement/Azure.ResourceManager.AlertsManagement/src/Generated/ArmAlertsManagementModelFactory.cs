// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.AlertsManagement;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmAlertsManagementModelFactory
    {
        /// <summary> Initializes a new instance of AlertProcessingRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Alert processing rule properties. </param>
        /// <returns> A new <see cref="AlertsManagement.AlertProcessingRuleData"/> instance for mocking. </returns>
        public static AlertProcessingRuleData AlertProcessingRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, AlertProcessingRuleProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new AlertProcessingRuleData(id, name, resourceType, systemData, tags, location, properties);
        }

        /// <summary> Initializes a new instance of ServiceAlertMetadata. </summary>
        /// <param name="properties">
        /// alert meta data property bag
        /// Please note <see cref="ServiceAlertMetadataProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.MonitorServiceList"/>.
        /// </param>
        /// <returns> A new <see cref="Models.ServiceAlertMetadata"/> instance for mocking. </returns>
        public static ServiceAlertMetadata ServiceAlertMetadata(ServiceAlertMetadataProperties properties = null)
        {
            return new ServiceAlertMetadata(properties);
        }

        /// <summary> Initializes a new instance of ServiceAlertData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Alert property bag. </param>
        /// <returns> A new <see cref="AlertsManagement.ServiceAlertData"/> instance for mocking. </returns>
        public static ServiceAlertData ServiceAlertData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ServiceAlertProperties properties = null)
        {
            return new ServiceAlertData(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of ServiceAlertProperties. </summary>
        /// <param name="essentials"> This object contains consistent fields across different monitor services. </param>
        /// <param name="context"> Information specific to the monitor service that gives more contextual details about the alert. </param>
        /// <param name="egressConfig"> Config which would be used for displaying the data in portal. </param>
        /// <returns> A new <see cref="Models.ServiceAlertProperties"/> instance for mocking. </returns>
        public static ServiceAlertProperties ServiceAlertProperties(ServiceAlertEssentials essentials = null, BinaryData context = null, BinaryData egressConfig = null)
        {
            return new ServiceAlertProperties(essentials, context, egressConfig);
        }

        /// <summary> Initializes a new instance of ServiceAlertEssentials. </summary>
        /// <param name="severity"> Severity of alert Sev0 being highest and Sev4 being lowest. </param>
        /// <param name="signalType"> The type of signal the alert is based on, which could be metrics, logs or activity logs. </param>
        /// <param name="alertState"> Alert object state, which can be modified by the user. </param>
        /// <param name="monitorCondition"> Condition of the rule at the monitor service. It represents whether the underlying conditions have crossed the defined alert rule thresholds. </param>
        /// <param name="targetResource"> Target ARM resource, on which alert got created. </param>
        /// <param name="targetResourceName"> Name of the target ARM resource name, on which alert got created. </param>
        /// <param name="targetResourceGroup"> Resource group of target ARM resource, on which alert got created. </param>
        /// <param name="targetResourceType"> Resource type of target ARM resource, on which alert got created. </param>
        /// <param name="monitorService"> Monitor service on which the rule(monitor) is set. </param>
        /// <param name="alertRule"> Rule(monitor) which fired alert instance. Depending on the monitor service,  this would be ARM id or name of the rule. </param>
        /// <param name="sourceCreatedId"> Unique Id created by monitor service for each alert instance. This could be used to track the issue at the monitor service, in case of Nagios, Zabbix, SCOM etc. </param>
        /// <param name="smartGroupId"> Unique Id of the smart group. </param>
        /// <param name="smartGroupingReason"> Verbose reason describing the reason why this alert instance is added to a smart group. </param>
        /// <param name="startOn"> Creation time(ISO-8601 format) of alert instance. </param>
        /// <param name="lastModifiedOn"> Last modification time(ISO-8601 format) of alert instance. </param>
        /// <param name="monitorConditionResolvedOn"> Resolved time(ISO-8601 format) of alert instance. This will be updated when monitor service resolves the alert instance because the rule condition is no longer met. </param>
        /// <param name="lastModifiedBy"> User who last modified the alert, in case of monitor service updates user would be 'system', otherwise name of the user. </param>
        /// <param name="isSuppressed"> Action status. </param>
        /// <param name="description"> Alert description. </param>
        /// <returns> A new <see cref="Models.ServiceAlertEssentials"/> instance for mocking. </returns>
        public static ServiceAlertEssentials ServiceAlertEssentials(ServiceAlertSeverity? severity = null, ServiceAlertSignalType? signalType = null, ServiceAlertState? alertState = null, MonitorCondition? monitorCondition = null, string targetResource = null, string targetResourceName = null, string targetResourceGroup = null, string targetResourceType = null, MonitorServiceSourceForAlert? monitorService = null, string alertRule = null, string sourceCreatedId = null, Guid? smartGroupId = null, string smartGroupingReason = null, DateTimeOffset? startOn = null, DateTimeOffset? lastModifiedOn = null, DateTimeOffset? monitorConditionResolvedOn = null, string lastModifiedBy = null, bool? isSuppressed = null, string description = null)
        {
            return new ServiceAlertEssentials(severity, signalType, alertState, monitorCondition, targetResource, targetResourceName, targetResourceGroup, targetResourceType, monitorService, alertRule, sourceCreatedId, smartGroupId, smartGroupingReason, startOn, lastModifiedOn, monitorConditionResolvedOn, lastModifiedBy, isSuppressed != null ? new ServiceAlertActionStatus(isSuppressed) : null, description);
        }

        /// <summary> Initializes a new instance of ServiceAlertModification. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the alert modification item. </param>
        /// <returns> A new <see cref="Models.ServiceAlertModification"/> instance for mocking. </returns>
        public static ServiceAlertModification ServiceAlertModification(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ServiceAlertModificationProperties properties = null)
        {
            return new ServiceAlertModification(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of ServiceAlertModificationProperties. </summary>
        /// <param name="alertId"> Unique Id of the alert for which the history is being retrieved. </param>
        /// <param name="modifications"> Modification details. </param>
        /// <returns> A new <see cref="Models.ServiceAlertModificationProperties"/> instance for mocking. </returns>
        public static ServiceAlertModificationProperties ServiceAlertModificationProperties(Guid? alertId = null, IEnumerable<ServiceAlertModificationItemInfo> modifications = null)
        {
            modifications ??= new List<ServiceAlertModificationItemInfo>();

            return new ServiceAlertModificationProperties(alertId, modifications?.ToList());
        }

        /// <summary> Initializes a new instance of ServiceAlertSummary. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Group the result set. </param>
        /// <returns> A new <see cref="Models.ServiceAlertSummary"/> instance for mocking. </returns>
        public static ServiceAlertSummary ServiceAlertSummary(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ServiceAlertSummaryGroup properties = null)
        {
            return new ServiceAlertSummary(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of SmartGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="alertsCount"> Total number of alerts in smart group. </param>
        /// <param name="smartGroupState"> Smart group state. </param>
        /// <param name="severity"> Severity of smart group is the highest(Sev0 &gt;... &gt; Sev4) severity of all the alerts in the group. </param>
        /// <param name="startOn"> Creation time of smart group. Date-Time in ISO-8601 format. </param>
        /// <param name="lastModifiedOn"> Last updated time of smart group. Date-Time in ISO-8601 format. </param>
        /// <param name="lastModifiedBy"> Last modified by user name. </param>
        /// <param name="resources"> Summary of target resources in the smart group. </param>
        /// <param name="resourceTypes"> Summary of target resource types in the smart group. </param>
        /// <param name="resourceGroups"> Summary of target resource groups in the smart group. </param>
        /// <param name="monitorServices"> Summary of monitorServices in the smart group. </param>
        /// <param name="monitorConditions"> Summary of monitorConditions in the smart group. </param>
        /// <param name="alertStates"> Summary of alertStates in the smart group. </param>
        /// <param name="alertSeverities"> Summary of alertSeverities in the smart group. </param>
        /// <param name="nextLink"> The URI to fetch the next page of alerts. Call ListNext() with this URI to fetch the next page alerts. </param>
        /// <returns> A new <see cref="AlertsManagement.SmartGroupData"/> instance for mocking. </returns>
        public static SmartGroupData SmartGroupData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, long? alertsCount = null, SmartGroupState? smartGroupState = null, ServiceAlertSeverity? severity = null, DateTimeOffset? startOn = null, DateTimeOffset? lastModifiedOn = null, string lastModifiedBy = null, IEnumerable<SmartGroupAggregatedProperty> resources = null, IEnumerable<SmartGroupAggregatedProperty> resourceTypes = null, IEnumerable<SmartGroupAggregatedProperty> resourceGroups = null, IEnumerable<SmartGroupAggregatedProperty> monitorServices = null, IEnumerable<SmartGroupAggregatedProperty> monitorConditions = null, IEnumerable<SmartGroupAggregatedProperty> alertStates = null, IEnumerable<SmartGroupAggregatedProperty> alertSeverities = null, string nextLink = null)
        {
            resources ??= new List<SmartGroupAggregatedProperty>();
            resourceTypes ??= new List<SmartGroupAggregatedProperty>();
            resourceGroups ??= new List<SmartGroupAggregatedProperty>();
            monitorServices ??= new List<SmartGroupAggregatedProperty>();
            monitorConditions ??= new List<SmartGroupAggregatedProperty>();
            alertStates ??= new List<SmartGroupAggregatedProperty>();
            alertSeverities ??= new List<SmartGroupAggregatedProperty>();

            return new SmartGroupData(id, name, resourceType, systemData, alertsCount, smartGroupState, severity, startOn, lastModifiedOn, lastModifiedBy, resources?.ToList(), resourceTypes?.ToList(), resourceGroups?.ToList(), monitorServices?.ToList(), monitorConditions?.ToList(), alertStates?.ToList(), alertSeverities?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of SmartGroupModification. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the smartGroup modification item. </param>
        /// <returns> A new <see cref="Models.SmartGroupModification"/> instance for mocking. </returns>
        public static SmartGroupModification SmartGroupModification(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, SmartGroupModificationProperties properties = null)
        {
            return new SmartGroupModification(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of SmartGroupModificationProperties. </summary>
        /// <param name="smartGroupId"> Unique Id of the smartGroup for which the history is being retrieved. </param>
        /// <param name="modifications"> Modification details. </param>
        /// <param name="nextLink"> URL to fetch the next set of results. </param>
        /// <returns> A new <see cref="Models.SmartGroupModificationProperties"/> instance for mocking. </returns>
        public static SmartGroupModificationProperties SmartGroupModificationProperties(Guid? smartGroupId = null, IEnumerable<SmartGroupModificationItemInfo> modifications = null, string nextLink = null)
        {
            modifications ??= new List<SmartGroupModificationItemInfo>();

            return new SmartGroupModificationProperties(smartGroupId, modifications?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of MonitorServiceList. </summary>
        /// <param name="data"> Array of operations. </param>
        /// <returns> A new <see cref="Models.MonitorServiceList"/> instance for mocking. </returns>
        public static MonitorServiceList MonitorServiceList(IEnumerable<MonitorServiceDetails> data = null)
        {
            data ??= new List<MonitorServiceDetails>();

            return new MonitorServiceList(ServiceAlertMetadataIdentifier.MonitorServiceList, data?.ToList());
        }

        /// <summary> Initializes a new instance of MonitorServiceDetails. </summary>
        /// <param name="name"> Monitor service name. </param>
        /// <param name="displayName"> Monitor service display name. </param>
        /// <returns> A new <see cref="Models.MonitorServiceDetails"/> instance for mocking. </returns>
        public static MonitorServiceDetails MonitorServiceDetails(string name = null, string displayName = null)
        {
            return new MonitorServiceDetails(name, displayName);
        }
    }
}
