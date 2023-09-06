// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Settings for data ingestion. </summary>
    public partial class MonitorWorkspaceIngestionSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MonitorWorkspaceIngestionSettings"/>. </summary>
        internal MonitorWorkspaceIngestionSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MonitorWorkspaceIngestionSettings"/>. </summary>
        /// <param name="dataCollectionRuleResourceId"> The Azure resource Id of the default data collection rule for this workspace. </param>
        /// <param name="dataCollectionEndpointResourceId"> The Azure resource Id of the default data collection endpoint for this workspace. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorWorkspaceIngestionSettings(ResourceIdentifier dataCollectionRuleResourceId, ResourceIdentifier dataCollectionEndpointResourceId, Dictionary<string, BinaryData> rawData)
        {
            DataCollectionRuleResourceId = dataCollectionRuleResourceId;
            DataCollectionEndpointResourceId = dataCollectionEndpointResourceId;
            _rawData = rawData;
        }

        /// <summary> The Azure resource Id of the default data collection rule for this workspace. </summary>
        public ResourceIdentifier DataCollectionRuleResourceId { get; }
        /// <summary> The Azure resource Id of the default data collection endpoint for this workspace. </summary>
        public ResourceIdentifier DataCollectionEndpointResourceId { get; }
    }
}
