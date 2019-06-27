// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AlertsOperations.
    /// </summary>
    public static partial class AlertsOperationsExtensions
    {
            /// <summary>
            /// List all existing alerts, where the results can be filtered on the basis of
            /// multiple parameters (e.g. time range). The results can then be sorted on
            /// the basis specific fields, with the default being lastModifiedDateTime.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetResource'>
            /// Filter by target resource( which is full ARM ID) Default value is select
            /// all.
            /// </param>
            /// <param name='targetResourceType'>
            /// Filter by target resource type. Default value is select all.
            /// </param>
            /// <param name='targetResourceGroup'>
            /// Filter by target resource group name. Default value is select all.
            /// </param>
            /// <param name='monitorService'>
            /// Filter by monitor service which generates the alert instance. Default value
            /// is select all. Possible values include: 'Application Insights',
            /// 'ActivityLog Administrative', 'ActivityLog Security', 'ActivityLog
            /// Recommendation', 'ActivityLog Policy', 'ActivityLog Autoscale', 'Log
            /// Analytics', 'Nagios', 'Platform', 'SCOM', 'ServiceHealth', 'SmartDetector',
            /// 'VM Insights', 'Zabbix'
            /// </param>
            /// <param name='monitorCondition'>
            /// Filter by monitor condition which is either 'Fired' or 'Resolved'. Default
            /// value is to select all. Possible values include: 'Fired', 'Resolved'
            /// </param>
            /// <param name='severity'>
            /// Filter by severity.  Default value is select all. Possible values include:
            /// 'Sev0', 'Sev1', 'Sev2', 'Sev3', 'Sev4'
            /// </param>
            /// <param name='alertState'>
            /// Filter by state of the alert instance. Default value is to select all.
            /// Possible values include: 'New', 'Acknowledged', 'Closed'
            /// </param>
            /// <param name='alertRule'>
            /// Filter by specific alert rule.  Default value is to select all.
            /// </param>
            /// <param name='smartGroupId'>
            /// Filter the alerts list by the Smart Group Id. Default value is none.
            /// </param>
            /// <param name='includeContext'>
            /// Include context which has contextual data specific to the monitor service.
            /// Default value is false'
            /// </param>
            /// <param name='includeEgressConfig'>
            /// Include egress config which would be used for displaying the content in
            /// portal.  Default value is 'false'.
            /// </param>
            /// <param name='pageCount'>
            /// Determines number of alerts returned per page in response. Permissible
            /// value is between 1 to 250. When the "includeContent"  filter is selected,
            /// maximum value allowed is 25. Default value is 25.
            /// </param>
            /// <param name='sortBy'>
            /// Sort the query results by input field,  Default value is
            /// 'lastModifiedDateTime'. Possible values include: 'name', 'severity',
            /// 'alertState', 'monitorCondition', 'targetResource', 'targetResourceName',
            /// 'targetResourceGroup', 'targetResourceType', 'startDateTime',
            /// 'lastModifiedDateTime'
            /// </param>
            /// <param name='sortOrder'>
            /// Sort the query results order in either ascending or descending.  Default
            /// value is 'desc' for time fields and 'asc' for others. Possible values
            /// include: 'asc', 'desc'
            /// </param>
            /// <param name='select'>
            /// This filter allows to selection of the fields(comma separated) which would
            /// be part of the essential section. This would allow to project only the
            /// required fields rather than getting entire content.  Default is to fetch
            /// all the fields in the essentials section.
            /// </param>
            /// <param name='timeRange'>
            /// Filter by time range by below listed values. Default value is 1 day.
            /// Possible values include: '1h', '1d', '7d', '30d'
            /// </param>
            /// <param name='customTimeRange'>
            /// Filter by custom time range in the format
            /// &lt;start-time&gt;/&lt;end-time&gt;  where time is in (ISO-8601 format)'.
            /// Permissible values is within 30 days from  query time. Either timeRange or
            /// customTimeRange could be used but not both. Default is none.
            /// </param>
            public static IPage<Alert> GetAll(this IAlertsOperations operations, string targetResource = default(string), string targetResourceType = default(string), string targetResourceGroup = default(string), string monitorService = default(string), string monitorCondition = default(string), string severity = default(string), string alertState = default(string), string alertRule = default(string), string smartGroupId = default(string), bool? includeContext = default(bool?), bool? includeEgressConfig = default(bool?), int? pageCount = default(int?), string sortBy = default(string), string sortOrder = default(string), string select = default(string), string timeRange = default(string), string customTimeRange = default(string))
            {
                return operations.GetAllAsync(targetResource, targetResourceType, targetResourceGroup, monitorService, monitorCondition, severity, alertState, alertRule, smartGroupId, includeContext, includeEgressConfig, pageCount, sortBy, sortOrder, select, timeRange, customTimeRange).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all existing alerts, where the results can be filtered on the basis of
            /// multiple parameters (e.g. time range). The results can then be sorted on
            /// the basis specific fields, with the default being lastModifiedDateTime.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetResource'>
            /// Filter by target resource( which is full ARM ID) Default value is select
            /// all.
            /// </param>
            /// <param name='targetResourceType'>
            /// Filter by target resource type. Default value is select all.
            /// </param>
            /// <param name='targetResourceGroup'>
            /// Filter by target resource group name. Default value is select all.
            /// </param>
            /// <param name='monitorService'>
            /// Filter by monitor service which generates the alert instance. Default value
            /// is select all. Possible values include: 'Application Insights',
            /// 'ActivityLog Administrative', 'ActivityLog Security', 'ActivityLog
            /// Recommendation', 'ActivityLog Policy', 'ActivityLog Autoscale', 'Log
            /// Analytics', 'Nagios', 'Platform', 'SCOM', 'ServiceHealth', 'SmartDetector',
            /// 'VM Insights', 'Zabbix'
            /// </param>
            /// <param name='monitorCondition'>
            /// Filter by monitor condition which is either 'Fired' or 'Resolved'. Default
            /// value is to select all. Possible values include: 'Fired', 'Resolved'
            /// </param>
            /// <param name='severity'>
            /// Filter by severity.  Default value is select all. Possible values include:
            /// 'Sev0', 'Sev1', 'Sev2', 'Sev3', 'Sev4'
            /// </param>
            /// <param name='alertState'>
            /// Filter by state of the alert instance. Default value is to select all.
            /// Possible values include: 'New', 'Acknowledged', 'Closed'
            /// </param>
            /// <param name='alertRule'>
            /// Filter by specific alert rule.  Default value is to select all.
            /// </param>
            /// <param name='smartGroupId'>
            /// Filter the alerts list by the Smart Group Id. Default value is none.
            /// </param>
            /// <param name='includeContext'>
            /// Include context which has contextual data specific to the monitor service.
            /// Default value is false'
            /// </param>
            /// <param name='includeEgressConfig'>
            /// Include egress config which would be used for displaying the content in
            /// portal.  Default value is 'false'.
            /// </param>
            /// <param name='pageCount'>
            /// Determines number of alerts returned per page in response. Permissible
            /// value is between 1 to 250. When the "includeContent"  filter is selected,
            /// maximum value allowed is 25. Default value is 25.
            /// </param>
            /// <param name='sortBy'>
            /// Sort the query results by input field,  Default value is
            /// 'lastModifiedDateTime'. Possible values include: 'name', 'severity',
            /// 'alertState', 'monitorCondition', 'targetResource', 'targetResourceName',
            /// 'targetResourceGroup', 'targetResourceType', 'startDateTime',
            /// 'lastModifiedDateTime'
            /// </param>
            /// <param name='sortOrder'>
            /// Sort the query results order in either ascending or descending.  Default
            /// value is 'desc' for time fields and 'asc' for others. Possible values
            /// include: 'asc', 'desc'
            /// </param>
            /// <param name='select'>
            /// This filter allows to selection of the fields(comma separated) which would
            /// be part of the essential section. This would allow to project only the
            /// required fields rather than getting entire content.  Default is to fetch
            /// all the fields in the essentials section.
            /// </param>
            /// <param name='timeRange'>
            /// Filter by time range by below listed values. Default value is 1 day.
            /// Possible values include: '1h', '1d', '7d', '30d'
            /// </param>
            /// <param name='customTimeRange'>
            /// Filter by custom time range in the format
            /// &lt;start-time&gt;/&lt;end-time&gt;  where time is in (ISO-8601 format)'.
            /// Permissible values is within 30 days from  query time. Either timeRange or
            /// customTimeRange could be used but not both. Default is none.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Alert>> GetAllAsync(this IAlertsOperations operations, string targetResource = default(string), string targetResourceType = default(string), string targetResourceGroup = default(string), string monitorService = default(string), string monitorCondition = default(string), string severity = default(string), string alertState = default(string), string alertRule = default(string), string smartGroupId = default(string), bool? includeContext = default(bool?), bool? includeEgressConfig = default(bool?), int? pageCount = default(int?), string sortBy = default(string), string sortOrder = default(string), string select = default(string), string timeRange = default(string), string customTimeRange = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllWithHttpMessagesAsync(targetResource, targetResourceType, targetResourceGroup, monitorService, monitorCondition, severity, alertState, alertRule, smartGroupId, includeContext, includeEgressConfig, pageCount, sortBy, sortOrder, select, timeRange, customTimeRange, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a specific alert.
            /// </summary>
            /// <remarks>
            /// Get information related to a specific alert
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='alertId'>
            /// Unique ID of an alert instance.
            /// </param>
            public static Alert GetById(this IAlertsOperations operations, string alertId)
            {
                return operations.GetByIdAsync(alertId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a specific alert.
            /// </summary>
            /// <remarks>
            /// Get information related to a specific alert
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='alertId'>
            /// Unique ID of an alert instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Alert> GetByIdAsync(this IAlertsOperations operations, string alertId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(alertId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Change the state of an alert.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='alertId'>
            /// Unique ID of an alert instance.
            /// </param>
            /// <param name='newState'>
            /// New state of the alert. Possible values include: 'New', 'Acknowledged',
            /// 'Closed'
            /// </param>
            public static Alert ChangeState(this IAlertsOperations operations, string alertId, string newState)
            {
                return operations.ChangeStateAsync(alertId, newState).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Change the state of an alert.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='alertId'>
            /// Unique ID of an alert instance.
            /// </param>
            /// <param name='newState'>
            /// New state of the alert. Possible values include: 'New', 'Acknowledged',
            /// 'Closed'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Alert> ChangeStateAsync(this IAlertsOperations operations, string alertId, string newState, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ChangeStateWithHttpMessagesAsync(alertId, newState, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the history of an alert, which captures any monitor condition changes
            /// (Fired/Resolved) and alert state changes (New/Acknowledged/Closed).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='alertId'>
            /// Unique ID of an alert instance.
            /// </param>
            public static AlertModification GetHistory(this IAlertsOperations operations, string alertId)
            {
                return operations.GetHistoryAsync(alertId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the history of an alert, which captures any monitor condition changes
            /// (Fired/Resolved) and alert state changes (New/Acknowledged/Closed).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='alertId'>
            /// Unique ID of an alert instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AlertModification> GetHistoryAsync(this IAlertsOperations operations, string alertId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetHistoryWithHttpMessagesAsync(alertId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a summarized count of your alerts grouped by various parameters (e.g.
            /// grouping by 'Severity' returns the count of alerts for each severity).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupby'>
            /// This parameter allows the result set to be grouped by input fields (Maximum
            /// 2 comma separated fields supported). For example, groupby=severity or
            /// groupby=severity,alertstate. Possible values include: 'severity',
            /// 'alertState', 'monitorCondition', 'monitorService', 'signalType',
            /// 'alertRule'
            /// </param>
            /// <param name='includeSmartGroupsCount'>
            /// Include count of the SmartGroups as part of the summary. Default value is
            /// 'false'.
            /// </param>
            /// <param name='targetResource'>
            /// Filter by target resource( which is full ARM ID) Default value is select
            /// all.
            /// </param>
            /// <param name='targetResourceType'>
            /// Filter by target resource type. Default value is select all.
            /// </param>
            /// <param name='targetResourceGroup'>
            /// Filter by target resource group name. Default value is select all.
            /// </param>
            /// <param name='monitorService'>
            /// Filter by monitor service which generates the alert instance. Default value
            /// is select all. Possible values include: 'Application Insights',
            /// 'ActivityLog Administrative', 'ActivityLog Security', 'ActivityLog
            /// Recommendation', 'ActivityLog Policy', 'ActivityLog Autoscale', 'Log
            /// Analytics', 'Nagios', 'Platform', 'SCOM', 'ServiceHealth', 'SmartDetector',
            /// 'VM Insights', 'Zabbix'
            /// </param>
            /// <param name='monitorCondition'>
            /// Filter by monitor condition which is either 'Fired' or 'Resolved'. Default
            /// value is to select all. Possible values include: 'Fired', 'Resolved'
            /// </param>
            /// <param name='severity'>
            /// Filter by severity.  Default value is select all. Possible values include:
            /// 'Sev0', 'Sev1', 'Sev2', 'Sev3', 'Sev4'
            /// </param>
            /// <param name='alertState'>
            /// Filter by state of the alert instance. Default value is to select all.
            /// Possible values include: 'New', 'Acknowledged', 'Closed'
            /// </param>
            /// <param name='alertRule'>
            /// Filter by specific alert rule.  Default value is to select all.
            /// </param>
            /// <param name='timeRange'>
            /// Filter by time range by below listed values. Default value is 1 day.
            /// Possible values include: '1h', '1d', '7d', '30d'
            /// </param>
            /// <param name='customTimeRange'>
            /// Filter by custom time range in the format
            /// &lt;start-time&gt;/&lt;end-time&gt;  where time is in (ISO-8601 format)'.
            /// Permissible values is within 30 days from  query time. Either timeRange or
            /// customTimeRange could be used but not both. Default is none.
            /// </param>
            public static AlertsSummary GetSummary(this IAlertsOperations operations, string groupby, bool? includeSmartGroupsCount = default(bool?), string targetResource = default(string), string targetResourceType = default(string), string targetResourceGroup = default(string), string monitorService = default(string), string monitorCondition = default(string), string severity = default(string), string alertState = default(string), string alertRule = default(string), string timeRange = default(string), string customTimeRange = default(string))
            {
                return operations.GetSummaryAsync(groupby, includeSmartGroupsCount, targetResource, targetResourceType, targetResourceGroup, monitorService, monitorCondition, severity, alertState, alertRule, timeRange, customTimeRange).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a summarized count of your alerts grouped by various parameters (e.g.
            /// grouping by 'Severity' returns the count of alerts for each severity).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupby'>
            /// This parameter allows the result set to be grouped by input fields (Maximum
            /// 2 comma separated fields supported). For example, groupby=severity or
            /// groupby=severity,alertstate. Possible values include: 'severity',
            /// 'alertState', 'monitorCondition', 'monitorService', 'signalType',
            /// 'alertRule'
            /// </param>
            /// <param name='includeSmartGroupsCount'>
            /// Include count of the SmartGroups as part of the summary. Default value is
            /// 'false'.
            /// </param>
            /// <param name='targetResource'>
            /// Filter by target resource( which is full ARM ID) Default value is select
            /// all.
            /// </param>
            /// <param name='targetResourceType'>
            /// Filter by target resource type. Default value is select all.
            /// </param>
            /// <param name='targetResourceGroup'>
            /// Filter by target resource group name. Default value is select all.
            /// </param>
            /// <param name='monitorService'>
            /// Filter by monitor service which generates the alert instance. Default value
            /// is select all. Possible values include: 'Application Insights',
            /// 'ActivityLog Administrative', 'ActivityLog Security', 'ActivityLog
            /// Recommendation', 'ActivityLog Policy', 'ActivityLog Autoscale', 'Log
            /// Analytics', 'Nagios', 'Platform', 'SCOM', 'ServiceHealth', 'SmartDetector',
            /// 'VM Insights', 'Zabbix'
            /// </param>
            /// <param name='monitorCondition'>
            /// Filter by monitor condition which is either 'Fired' or 'Resolved'. Default
            /// value is to select all. Possible values include: 'Fired', 'Resolved'
            /// </param>
            /// <param name='severity'>
            /// Filter by severity.  Default value is select all. Possible values include:
            /// 'Sev0', 'Sev1', 'Sev2', 'Sev3', 'Sev4'
            /// </param>
            /// <param name='alertState'>
            /// Filter by state of the alert instance. Default value is to select all.
            /// Possible values include: 'New', 'Acknowledged', 'Closed'
            /// </param>
            /// <param name='alertRule'>
            /// Filter by specific alert rule.  Default value is to select all.
            /// </param>
            /// <param name='timeRange'>
            /// Filter by time range by below listed values. Default value is 1 day.
            /// Possible values include: '1h', '1d', '7d', '30d'
            /// </param>
            /// <param name='customTimeRange'>
            /// Filter by custom time range in the format
            /// &lt;start-time&gt;/&lt;end-time&gt;  where time is in (ISO-8601 format)'.
            /// Permissible values is within 30 days from  query time. Either timeRange or
            /// customTimeRange could be used but not both. Default is none.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AlertsSummary> GetSummaryAsync(this IAlertsOperations operations, string groupby, bool? includeSmartGroupsCount = default(bool?), string targetResource = default(string), string targetResourceType = default(string), string targetResourceGroup = default(string), string monitorService = default(string), string monitorCondition = default(string), string severity = default(string), string alertState = default(string), string alertRule = default(string), string timeRange = default(string), string customTimeRange = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSummaryWithHttpMessagesAsync(groupby, includeSmartGroupsCount, targetResource, targetResourceType, targetResourceGroup, monitorService, monitorCondition, severity, alertState, alertRule, timeRange, customTimeRange, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all existing alerts, where the results can be filtered on the basis of
            /// multiple parameters (e.g. time range). The results can then be sorted on
            /// the basis specific fields, with the default being lastModifiedDateTime.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Alert> GetAllNext(this IAlertsOperations operations, string nextPageLink)
            {
                return operations.GetAllNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all existing alerts, where the results can be filtered on the basis of
            /// multiple parameters (e.g. time range). The results can then be sorted on
            /// the basis specific fields, with the default being lastModifiedDateTime.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Alert>> GetAllNextAsync(this IAlertsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
