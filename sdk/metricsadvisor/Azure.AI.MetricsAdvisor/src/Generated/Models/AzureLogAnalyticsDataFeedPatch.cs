// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureLogAnalyticsDataFeedPatch. </summary>
    internal partial class AzureLogAnalyticsDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of AzureLogAnalyticsDataFeedPatch. </summary>
        public AzureLogAnalyticsDataFeedPatch()
        {
            DataSourceType = DataFeedSourceType.LogAnalytics;
        }

        public AzureLogAnalyticsParameterPatch DataSourceParameter { get; set; }
    }
}
