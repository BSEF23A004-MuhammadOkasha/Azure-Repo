// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The request body which contain contact detail metadata. </summary>
    public partial class NotificationContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NotificationContent"/>. </summary>
        /// <param name="alertType"> The value of the supported alert type. Supported alert type values are: servicehealth, metricstaticthreshold, metricsdynamicthreshold, logalertv2, smartalert, webtestalert, logalertv1numresult, logalertv1metricmeasurement, resourcehealth, activitylog, actualcostbudget, forecastedbudget. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alertType"/> is null. </exception>
        public NotificationContent(string alertType)
        {
            Argument.AssertNotNull(alertType, nameof(alertType));

            AlertType = alertType;
            EmailReceivers = new ChangeTrackingList<MonitorEmailReceiver>();
            SmsReceivers = new ChangeTrackingList<MonitorSmsReceiver>();
            WebhookReceivers = new ChangeTrackingList<MonitorWebhookReceiver>();
            ItsmReceivers = new ChangeTrackingList<MonitorItsmReceiver>();
            AzureAppPushReceivers = new ChangeTrackingList<MonitorAzureAppPushReceiver>();
            AutomationRunbookReceivers = new ChangeTrackingList<MonitorAutomationRunbookReceiver>();
            VoiceReceivers = new ChangeTrackingList<MonitorVoiceReceiver>();
            LogicAppReceivers = new ChangeTrackingList<MonitorLogicAppReceiver>();
            AzureFunctionReceivers = new ChangeTrackingList<MonitorAzureFunctionReceiver>();
            ArmRoleReceivers = new ChangeTrackingList<MonitorArmRoleReceiver>();
            EventHubReceivers = new ChangeTrackingList<MonitorEventHubReceiver>();
        }

        /// <summary> Initializes a new instance of <see cref="NotificationContent"/>. </summary>
        /// <param name="alertType"> The value of the supported alert type. Supported alert type values are: servicehealth, metricstaticthreshold, metricsdynamicthreshold, logalertv2, smartalert, webtestalert, logalertv1numresult, logalertv1metricmeasurement, resourcehealth, activitylog, actualcostbudget, forecastedbudget. </param>
        /// <param name="emailReceivers"> The list of email receivers that are part of this action group. </param>
        /// <param name="smsReceivers"> The list of SMS receivers that are part of this action group. </param>
        /// <param name="webhookReceivers"> The list of webhook receivers that are part of this action group. </param>
        /// <param name="itsmReceivers"> The list of ITSM receivers that are part of this action group. </param>
        /// <param name="azureAppPushReceivers"> The list of AzureAppPush receivers that are part of this action group. </param>
        /// <param name="automationRunbookReceivers"> The list of AutomationRunbook receivers that are part of this action group. </param>
        /// <param name="voiceReceivers"> The list of voice receivers that are part of this action group. </param>
        /// <param name="logicAppReceivers"> The list of logic app receivers that are part of this action group. </param>
        /// <param name="azureFunctionReceivers"> The list of azure function receivers that are part of this action group. </param>
        /// <param name="armRoleReceivers"> The list of ARM role receivers that are part of this action group. Roles are Azure RBAC roles and only built-in roles are supported. </param>
        /// <param name="eventHubReceivers"> The list of event hub receivers that are part of this action group. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationContent(string alertType, IList<MonitorEmailReceiver> emailReceivers, IList<MonitorSmsReceiver> smsReceivers, IList<MonitorWebhookReceiver> webhookReceivers, IList<MonitorItsmReceiver> itsmReceivers, IList<MonitorAzureAppPushReceiver> azureAppPushReceivers, IList<MonitorAutomationRunbookReceiver> automationRunbookReceivers, IList<MonitorVoiceReceiver> voiceReceivers, IList<MonitorLogicAppReceiver> logicAppReceivers, IList<MonitorAzureFunctionReceiver> azureFunctionReceivers, IList<MonitorArmRoleReceiver> armRoleReceivers, IList<MonitorEventHubReceiver> eventHubReceivers, Dictionary<string, BinaryData> rawData)
        {
            AlertType = alertType;
            EmailReceivers = emailReceivers;
            SmsReceivers = smsReceivers;
            WebhookReceivers = webhookReceivers;
            ItsmReceivers = itsmReceivers;
            AzureAppPushReceivers = azureAppPushReceivers;
            AutomationRunbookReceivers = automationRunbookReceivers;
            VoiceReceivers = voiceReceivers;
            LogicAppReceivers = logicAppReceivers;
            AzureFunctionReceivers = azureFunctionReceivers;
            ArmRoleReceivers = armRoleReceivers;
            EventHubReceivers = eventHubReceivers;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationContent"/> for deserialization. </summary>
        internal NotificationContent()
        {
        }

        /// <summary> The value of the supported alert type. Supported alert type values are: servicehealth, metricstaticthreshold, metricsdynamicthreshold, logalertv2, smartalert, webtestalert, logalertv1numresult, logalertv1metricmeasurement, resourcehealth, activitylog, actualcostbudget, forecastedbudget. </summary>
        public string AlertType { get; }
        /// <summary> The list of email receivers that are part of this action group. </summary>
        public IList<MonitorEmailReceiver> EmailReceivers { get; }
        /// <summary> The list of SMS receivers that are part of this action group. </summary>
        public IList<MonitorSmsReceiver> SmsReceivers { get; }
        /// <summary> The list of webhook receivers that are part of this action group. </summary>
        public IList<MonitorWebhookReceiver> WebhookReceivers { get; }
        /// <summary> The list of ITSM receivers that are part of this action group. </summary>
        public IList<MonitorItsmReceiver> ItsmReceivers { get; }
        /// <summary> The list of AzureAppPush receivers that are part of this action group. </summary>
        public IList<MonitorAzureAppPushReceiver> AzureAppPushReceivers { get; }
        /// <summary> The list of AutomationRunbook receivers that are part of this action group. </summary>
        public IList<MonitorAutomationRunbookReceiver> AutomationRunbookReceivers { get; }
        /// <summary> The list of voice receivers that are part of this action group. </summary>
        public IList<MonitorVoiceReceiver> VoiceReceivers { get; }
        /// <summary> The list of logic app receivers that are part of this action group. </summary>
        public IList<MonitorLogicAppReceiver> LogicAppReceivers { get; }
        /// <summary> The list of azure function receivers that are part of this action group. </summary>
        public IList<MonitorAzureFunctionReceiver> AzureFunctionReceivers { get; }
        /// <summary> The list of ARM role receivers that are part of this action group. Roles are Azure RBAC roles and only built-in roles are supported. </summary>
        public IList<MonitorArmRoleReceiver> ArmRoleReceivers { get; }
        /// <summary> The list of event hub receivers that are part of this action group. </summary>
        public IList<MonitorEventHubReceiver> EventHubReceivers { get; }
    }
}
