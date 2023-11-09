// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The UnknownRuleCondition. </summary>
    internal partial class UnknownRuleCondition : AlertRuleCondition
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRuleCondition"/>. </summary>
        /// <param name="odataType"> specifies the type of condition. This can be one of three types: ManagementEventRuleCondition (occurrences of management events), LocationThresholdRuleCondition (based on the number of failures of a web test), and ThresholdRuleCondition (based on the threshold of a metric). </param>
        /// <param name="dataSource">
        /// the resource from which the rule collects its data. For this type dataSource will always be of type RuleMetricDataSource.
        /// Please note <see cref="RuleDataSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RuleManagementEventDataSource"/> and <see cref="RuleMetricDataSource"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRuleCondition(string odataType, RuleDataSource dataSource, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(odataType, dataSource, serializedAdditionalRawData)
        {
            OdataType = odataType ?? "Unknown";
        }
    }
}
