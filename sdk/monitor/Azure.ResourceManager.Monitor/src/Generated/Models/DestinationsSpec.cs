// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Specification of destinations that can be used in data flows. </summary>
    public partial class DestinationsSpec
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DestinationsSpec"/>. </summary>
        public DestinationsSpec()
        {
            LogAnalytics = new ChangeTrackingList<LogAnalyticsDestination>();
            MonitoringAccounts = new ChangeTrackingList<MonitoringAccountDestination>();
            EventHubs = new ChangeTrackingList<DataCollectionRuleEventHubDestination>();
            EventHubsDirect = new ChangeTrackingList<DataCollectionRuleEventHubDirectDestination>();
            StorageBlobsDirect = new ChangeTrackingList<DataCollectionRuleStorageBlobDestination>();
            StorageTablesDirect = new ChangeTrackingList<DataCollectionRuleStorageTableDestination>();
            StorageAccounts = new ChangeTrackingList<DataCollectionRuleStorageBlobDestination>();
        }

        /// <summary> Initializes a new instance of <see cref="DestinationsSpec"/>. </summary>
        /// <param name="logAnalytics"> List of Log Analytics destinations. </param>
        /// <param name="monitoringAccounts"> List of monitoring account destinations. </param>
        /// <param name="azureMonitorMetrics"> Azure Monitor Metrics destination. </param>
        /// <param name="eventHubs"> List of Event Hubs destinations. </param>
        /// <param name="eventHubsDirect"> List of Event Hubs Direct destinations. </param>
        /// <param name="storageBlobsDirect"> List of Storage Blob Direct destinations. To be used only for sending data directly to store from the agent. </param>
        /// <param name="storageTablesDirect"> List of Storage Table Direct destinations. </param>
        /// <param name="storageAccounts"> List of storage accounts destinations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DestinationsSpec(IList<LogAnalyticsDestination> logAnalytics, IList<MonitoringAccountDestination> monitoringAccounts, DestinationsSpecAzureMonitorMetrics azureMonitorMetrics, IList<DataCollectionRuleEventHubDestination> eventHubs, IList<DataCollectionRuleEventHubDirectDestination> eventHubsDirect, IList<DataCollectionRuleStorageBlobDestination> storageBlobsDirect, IList<DataCollectionRuleStorageTableDestination> storageTablesDirect, IList<DataCollectionRuleStorageBlobDestination> storageAccounts, Dictionary<string, BinaryData> rawData)
        {
            LogAnalytics = logAnalytics;
            MonitoringAccounts = monitoringAccounts;
            AzureMonitorMetrics = azureMonitorMetrics;
            EventHubs = eventHubs;
            EventHubsDirect = eventHubsDirect;
            StorageBlobsDirect = storageBlobsDirect;
            StorageTablesDirect = storageTablesDirect;
            StorageAccounts = storageAccounts;
            _rawData = rawData;
        }

        /// <summary> List of Log Analytics destinations. </summary>
        public IList<LogAnalyticsDestination> LogAnalytics { get; }
        /// <summary> List of monitoring account destinations. </summary>
        public IList<MonitoringAccountDestination> MonitoringAccounts { get; }
        /// <summary> Azure Monitor Metrics destination. </summary>
        internal DestinationsSpecAzureMonitorMetrics AzureMonitorMetrics { get; set; }
        /// <summary>
        /// A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </summary>
        public string AzureMonitorMetricsName
        {
            get => AzureMonitorMetrics is null ? default : AzureMonitorMetrics.Name;
            set
            {
                if (AzureMonitorMetrics is null)
                    AzureMonitorMetrics = new DestinationsSpecAzureMonitorMetrics();
                AzureMonitorMetrics.Name = value;
            }
        }

        /// <summary> List of Event Hubs destinations. </summary>
        public IList<DataCollectionRuleEventHubDestination> EventHubs { get; }
        /// <summary> List of Event Hubs Direct destinations. </summary>
        public IList<DataCollectionRuleEventHubDirectDestination> EventHubsDirect { get; }
        /// <summary> List of Storage Blob Direct destinations. To be used only for sending data directly to store from the agent. </summary>
        public IList<DataCollectionRuleStorageBlobDestination> StorageBlobsDirect { get; }
        /// <summary> List of Storage Table Direct destinations. </summary>
        public IList<DataCollectionRuleStorageTableDestination> StorageTablesDirect { get; }
        /// <summary> List of storage accounts destinations. </summary>
        public IList<DataCollectionRuleStorageBlobDestination> StorageAccounts { get; }
    }
}
