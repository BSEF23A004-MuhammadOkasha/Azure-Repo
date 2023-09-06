// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Data flow policy rule configuration. </summary>
    public partial class PccRuleConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PccRuleConfiguration"/>. </summary>
        /// <param name="ruleName"> The name of the rule. This must be unique within the parent service. You must not use any of the following reserved strings - `default`, `requested` or `service`. </param>
        /// <param name="rulePrecedence"> A precedence value that is used to decide between data flow policy rules when identifying the QoS values to use for a particular SIM. A lower value means a higher priority. This value should be unique among all data flow policy rules configured in the mobile network. </param>
        /// <param name="serviceDataFlowTemplates"> The set of data flow templates to use for this data flow policy rule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="serviceDataFlowTemplates"/> is null. </exception>
        public PccRuleConfiguration(string ruleName, int rulePrecedence, IEnumerable<MobileNetworkServiceDataFlowTemplate> serviceDataFlowTemplates)
        {
            Argument.AssertNotNull(ruleName, nameof(ruleName));
            Argument.AssertNotNull(serviceDataFlowTemplates, nameof(serviceDataFlowTemplates));

            RuleName = ruleName;
            RulePrecedence = rulePrecedence;
            ServiceDataFlowTemplates = serviceDataFlowTemplates.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PccRuleConfiguration"/>. </summary>
        /// <param name="ruleName"> The name of the rule. This must be unique within the parent service. You must not use any of the following reserved strings - `default`, `requested` or `service`. </param>
        /// <param name="rulePrecedence"> A precedence value that is used to decide between data flow policy rules when identifying the QoS values to use for a particular SIM. A lower value means a higher priority. This value should be unique among all data flow policy rules configured in the mobile network. </param>
        /// <param name="ruleQosPolicy"> The QoS policy to use for packets matching this rule. If this field is null then the parent service will define the QoS settings. </param>
        /// <param name="trafficControl"> Determines whether flows that match this data flow policy rule are permitted. </param>
        /// <param name="serviceDataFlowTemplates"> The set of data flow templates to use for this data flow policy rule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PccRuleConfiguration(string ruleName, int rulePrecedence, PccRuleQosPolicy ruleQosPolicy, MobileNetworkTrafficControlPermission? trafficControl, IList<MobileNetworkServiceDataFlowTemplate> serviceDataFlowTemplates, Dictionary<string, BinaryData> rawData)
        {
            RuleName = ruleName;
            RulePrecedence = rulePrecedence;
            RuleQosPolicy = ruleQosPolicy;
            TrafficControl = trafficControl;
            ServiceDataFlowTemplates = serviceDataFlowTemplates;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PccRuleConfiguration"/> for deserialization. </summary>
        internal PccRuleConfiguration()
        {
        }

        /// <summary> The name of the rule. This must be unique within the parent service. You must not use any of the following reserved strings - `default`, `requested` or `service`. </summary>
        public string RuleName { get; set; }
        /// <summary> A precedence value that is used to decide between data flow policy rules when identifying the QoS values to use for a particular SIM. A lower value means a higher priority. This value should be unique among all data flow policy rules configured in the mobile network. </summary>
        public int RulePrecedence { get; set; }
        /// <summary> The QoS policy to use for packets matching this rule. If this field is null then the parent service will define the QoS settings. </summary>
        public PccRuleQosPolicy RuleQosPolicy { get; set; }
        /// <summary> Determines whether flows that match this data flow policy rule are permitted. </summary>
        public MobileNetworkTrafficControlPermission? TrafficControl { get; set; }
        /// <summary> The set of data flow templates to use for this data flow policy rule. </summary>
        public IList<MobileNetworkServiceDataFlowTemplate> ServiceDataFlowTemplates { get; }
    }
}
