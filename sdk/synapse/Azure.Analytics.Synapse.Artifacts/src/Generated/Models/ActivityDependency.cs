// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Activity dependency information. </summary>
    public partial class ActivityDependency
    {
        /// <summary> Initializes a new instance of ActivityDependency. </summary>
        /// <param name="activity"> Activity name. </param>
        /// <param name="dependencyConditions"> Match-Condition for the dependency. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="activity"/> or <paramref name="dependencyConditions"/> is null. </exception>
        public ActivityDependency(string activity, IEnumerable<DependencyCondition> dependencyConditions)
        {
            Argument.AssertNotNull(activity, nameof(activity));
            Argument.AssertNotNull(dependencyConditions, nameof(dependencyConditions));

            Activity = activity;
            DependencyConditions = dependencyConditions.ToList();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of ActivityDependency. </summary>
        /// <param name="activity"> Activity name. </param>
        /// <param name="dependencyConditions"> Match-Condition for the dependency. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ActivityDependency(string activity, IList<DependencyCondition> dependencyConditions, IDictionary<string, object> additionalProperties)
        {
            Activity = activity;
            DependencyConditions = dependencyConditions;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Activity name. </summary>
        public string Activity { get; set; }
        /// <summary> Match-Condition for the dependency. </summary>
        public IList<DependencyCondition> DependencyConditions { get; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
