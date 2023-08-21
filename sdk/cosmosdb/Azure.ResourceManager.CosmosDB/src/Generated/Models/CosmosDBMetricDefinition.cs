// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The definition of a metric. </summary>
    public partial class CosmosDBMetricDefinition
    {
        /// <summary> Initializes a new instance of CosmosDBMetricDefinition. </summary>
        internal CosmosDBMetricDefinition()
        {
            MetricAvailabilities = new ChangeTrackingList<CosmosDBMetricAvailability>();
        }

        /// <summary> Initializes a new instance of CosmosDBMetricDefinition. </summary>
        /// <param name="metricAvailabilities"> The list of metric availabilities for the account. </param>
        /// <param name="primaryAggregationType"> The primary aggregation type of the metric. </param>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="resourceId"> The resource uri of the database. </param>
        /// <param name="name"> The name information for the metric. </param>
        internal CosmosDBMetricDefinition(IReadOnlyList<CosmosDBMetricAvailability> metricAvailabilities, CosmosDBMetricPrimaryAggregationType? primaryAggregationType, CosmosDBMetricUnitType? unit, ResourceIdentifier resourceId, CosmosDBMetricName name)
        {
            MetricAvailabilities = metricAvailabilities;
            PrimaryAggregationType = primaryAggregationType;
            Unit = unit;
            ResourceId = resourceId;
            Name = name;
        }

        /// <summary> The list of metric availabilities for the account. </summary>
        public IReadOnlyList<CosmosDBMetricAvailability> MetricAvailabilities { get; }
        /// <summary> The primary aggregation type of the metric. </summary>
        public CosmosDBMetricPrimaryAggregationType? PrimaryAggregationType { get; }
        /// <summary> The unit of the metric. </summary>
        public CosmosDBMetricUnitType? Unit { get; }
        /// <summary> The resource uri of the database. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> The name information for the metric. </summary>
        public CosmosDBMetricName Name { get; }
    }
}
