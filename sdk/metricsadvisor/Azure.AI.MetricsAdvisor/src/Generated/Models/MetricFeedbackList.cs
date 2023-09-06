// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.MetricsAdvisor;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The MetricFeedbackList. </summary>
    internal partial class MetricFeedbackList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MetricFeedbackList"/>. </summary>
        internal MetricFeedbackList()
        {
            Value = new ChangeTrackingList<MetricFeedback>();
        }

        /// <summary> Initializes a new instance of <see cref="MetricFeedbackList"/>. </summary>
        /// <param name="nextLink"></param>
        /// <param name="value">
        /// Please note <see cref="MetricFeedback"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MetricAnomalyFeedback"/>, <see cref="MetricChangePointFeedback"/>, <see cref="MetricCommentFeedback"/> and <see cref="MetricPeriodFeedback"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MetricFeedbackList(string nextLink, IReadOnlyList<MetricFeedback> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
        /// <summary>
        /// Gets the value
        /// Please note <see cref="MetricFeedback"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MetricAnomalyFeedback"/>, <see cref="MetricChangePointFeedback"/>, <see cref="MetricCommentFeedback"/> and <see cref="MetricPeriodFeedback"/>.
        /// </summary>
        public IReadOnlyList<MetricFeedback> Value { get; }
    }
}
