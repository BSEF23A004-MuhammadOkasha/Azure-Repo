// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Execute data flow activity. </summary>
    public partial class ExecuteDataFlowActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of ExecuteDataFlowActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="dataFlow"> Data flow reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="dataFlow"/> is null. </exception>
        public ExecuteDataFlowActivity(string name, DataFlowReference dataFlow) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (dataFlow == null)
            {
                throw new ArgumentNullException(nameof(dataFlow));
            }

            DataFlow = dataFlow;
            Type = "ExecuteDataFlow";
        }

        /// <summary> Initializes a new instance of ExecuteDataFlowActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="dataFlow"> Data flow reference. </param>
        /// <param name="staging"> Staging info for execute data flow activity. </param>
        /// <param name="integrationRuntime"> The integration runtime reference. </param>
        /// <param name="compute"> Compute properties for data flow activity. </param>
        internal ExecuteDataFlowActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, DataFlowReference dataFlow, DataFlowStagingInfo staging, IntegrationRuntimeReference integrationRuntime, ExecuteDataFlowActivityTypePropertiesCompute compute) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            DataFlow = dataFlow;
            Staging = staging;
            IntegrationRuntime = integrationRuntime;
            Compute = compute;
            Type = type ?? "ExecuteDataFlow";
        }

        /// <summary> Data flow reference. </summary>
        public DataFlowReference DataFlow { get; set; }
        /// <summary> Staging info for execute data flow activity. </summary>
        public DataFlowStagingInfo Staging { get; set; }
        /// <summary> The integration runtime reference. </summary>
        public IntegrationRuntimeReference IntegrationRuntime { get; set; }
        /// <summary> Compute properties for data flow activity. </summary>
        public ExecuteDataFlowActivityTypePropertiesCompute Compute { get; set; }
    }
}
