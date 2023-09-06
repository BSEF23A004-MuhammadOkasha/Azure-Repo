// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The IncidentProperty. </summary>
    internal partial class IncidentProperty
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IncidentProperty"/>. </summary>
        /// <param name="maxSeverity"> max severity of latest anomalies in the incident. </param>
        /// <param name="incidentStatus">
        /// incident status
        ///
        /// only return for alerting incident result
        /// </param>
        /// <param name="valueOfRootNode"> value of the root node. </param>
        internal IncidentProperty(AnomalySeverity maxSeverity, AnomalyIncidentStatus incidentStatus, double valueOfRootNode)
        {
            MaxSeverity = maxSeverity;
            IncidentStatus = incidentStatus;
            ValueOfRootNode = valueOfRootNode;
        }

        /// <summary> Initializes a new instance of <see cref="IncidentProperty"/>. </summary>
        /// <param name="maxSeverity"> max severity of latest anomalies in the incident. </param>
        /// <param name="incidentStatus">
        /// incident status
        ///
        /// only return for alerting incident result
        /// </param>
        /// <param name="valueOfRootNode"> value of the root node. </param>
        /// <param name="expectedValueOfRootNode"> expected value of the root node given by smart detector. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IncidentProperty(AnomalySeverity maxSeverity, AnomalyIncidentStatus incidentStatus, double valueOfRootNode, double? expectedValueOfRootNode, Dictionary<string, BinaryData> rawData)
        {
            MaxSeverity = maxSeverity;
            IncidentStatus = incidentStatus;
            ValueOfRootNode = valueOfRootNode;
            ExpectedValueOfRootNode = expectedValueOfRootNode;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="IncidentProperty"/> for deserialization. </summary>
        internal IncidentProperty()
        {
        }

        /// <summary> max severity of latest anomalies in the incident. </summary>
        public AnomalySeverity MaxSeverity { get; }
        /// <summary>
        /// incident status
        ///
        /// only return for alerting incident result
        /// </summary>
        public AnomalyIncidentStatus IncidentStatus { get; }
        /// <summary> value of the root node. </summary>
        public double ValueOfRootNode { get; }
        /// <summary> expected value of the root node given by smart detector. </summary>
        public double? ExpectedValueOfRootNode { get; }
    }
}
