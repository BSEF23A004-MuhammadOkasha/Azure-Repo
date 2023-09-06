// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Azure reachability report details. </summary>
    public partial class AzureReachabilityReport
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AzureReachabilityReport"/>. </summary>
        /// <param name="aggregationLevel"> The aggregation level of Azure reachability report. Can be Country, State or City. </param>
        /// <param name="providerLocation"> Parameters that define a geographic location. </param>
        /// <param name="reachabilityReport"> List of Azure reachability report items. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aggregationLevel"/>, <paramref name="providerLocation"/> or <paramref name="reachabilityReport"/> is null. </exception>
        internal AzureReachabilityReport(string aggregationLevel, AzureReachabilityReportLocation providerLocation, IEnumerable<AzureReachabilityReportItem> reachabilityReport)
        {
            Argument.AssertNotNull(aggregationLevel, nameof(aggregationLevel));
            Argument.AssertNotNull(providerLocation, nameof(providerLocation));
            Argument.AssertNotNull(reachabilityReport, nameof(reachabilityReport));

            AggregationLevel = aggregationLevel;
            ProviderLocation = providerLocation;
            ReachabilityReport = reachabilityReport.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AzureReachabilityReport"/>. </summary>
        /// <param name="aggregationLevel"> The aggregation level of Azure reachability report. Can be Country, State or City. </param>
        /// <param name="providerLocation"> Parameters that define a geographic location. </param>
        /// <param name="reachabilityReport"> List of Azure reachability report items. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureReachabilityReport(string aggregationLevel, AzureReachabilityReportLocation providerLocation, IReadOnlyList<AzureReachabilityReportItem> reachabilityReport, Dictionary<string, BinaryData> rawData)
        {
            AggregationLevel = aggregationLevel;
            ProviderLocation = providerLocation;
            ReachabilityReport = reachabilityReport;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AzureReachabilityReport"/> for deserialization. </summary>
        internal AzureReachabilityReport()
        {
        }

        /// <summary> The aggregation level of Azure reachability report. Can be Country, State or City. </summary>
        public string AggregationLevel { get; }
        /// <summary> Parameters that define a geographic location. </summary>
        public AzureReachabilityReportLocation ProviderLocation { get; }
        /// <summary> List of Azure reachability report items. </summary>
        public IReadOnlyList<AzureReachabilityReportItem> ReachabilityReport { get; }
    }
}
