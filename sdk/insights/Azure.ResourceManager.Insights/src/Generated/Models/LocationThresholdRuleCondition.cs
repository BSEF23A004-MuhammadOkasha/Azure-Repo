// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> A rule condition based on a certain number of locations failing. </summary>
    public partial class LocationThresholdRuleCondition : RuleCondition
    {
        /// <summary> Initializes a new instance of LocationThresholdRuleCondition. </summary>
        /// <param name="failedLocationCount"> the number of locations that must fail to activate the alert. </param>
        public LocationThresholdRuleCondition(int failedLocationCount)
        {
            FailedLocationCount = failedLocationCount;
            OdataType = "Microsoft.Azure.Management.Insights.Models.LocationThresholdRuleCondition";
        }

        /// <summary> Initializes a new instance of LocationThresholdRuleCondition. </summary>
        /// <param name="odataType"> specifies the type of condition. This can be one of three types: ManagementEventRuleCondition (occurrences of management events), LocationThresholdRuleCondition (based on the number of failures of a web test), and ThresholdRuleCondition (based on the threshold of a metric). </param>
        /// <param name="dataSource"> the resource from which the rule collects its data. For this type dataSource will always be of type RuleMetricDataSource. </param>
        /// <param name="windowSize"> the period of time (in ISO 8601 duration format) that is used to monitor alert activity based on the threshold. If specified then it must be between 5 minutes and 1 day. </param>
        /// <param name="failedLocationCount"> the number of locations that must fail to activate the alert. </param>
        internal LocationThresholdRuleCondition(string odataType, RuleDataSource dataSource, TimeSpan? windowSize, int failedLocationCount) : base(odataType, dataSource)
        {
            WindowSize = windowSize;
            FailedLocationCount = failedLocationCount;
            OdataType = odataType ?? "Microsoft.Azure.Management.Insights.Models.LocationThresholdRuleCondition";
        }

        /// <summary> the period of time (in ISO 8601 duration format) that is used to monitor alert activity based on the threshold. If specified then it must be between 5 minutes and 1 day. </summary>
        public TimeSpan? WindowSize { get; set; }
        /// <summary> the number of locations that must fail to activate the alert. </summary>
        public int FailedLocationCount { get; set; }
    }
}
