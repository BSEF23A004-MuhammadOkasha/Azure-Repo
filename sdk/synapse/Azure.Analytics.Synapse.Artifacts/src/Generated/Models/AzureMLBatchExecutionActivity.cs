// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure ML Batch Execution activity. </summary>
    public partial class AzureMLBatchExecutionActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of AzureMLBatchExecutionActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public AzureMLBatchExecutionActivity(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            GlobalParameters = new Core.ChangeTrackingDictionary<string, object>();
            WebServiceOutputs = new Core.ChangeTrackingDictionary<string, AzureMLWebServiceFile>();
            WebServiceInputs = new Core.ChangeTrackingDictionary<string, AzureMLWebServiceFile>();
            Type = "AzureMLBatchExecution";
        }

        /// <summary> Initializes a new instance of AzureMLBatchExecutionActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="globalParameters"> Key,Value pairs to be passed to the Azure ML Batch Execution Service endpoint. Keys must match the names of web service parameters defined in the published Azure ML web service. Values will be passed in the GlobalParameters property of the Azure ML batch execution request. </param>
        /// <param name="webServiceOutputs"> Key,Value pairs, mapping the names of Azure ML endpoint's Web Service Outputs to AzureMLWebServiceFile objects specifying the output Blob locations. This information will be passed in the WebServiceOutputs property of the Azure ML batch execution request. </param>
        /// <param name="webServiceInputs"> Key,Value pairs, mapping the names of Azure ML endpoint's Web Service Inputs to AzureMLWebServiceFile objects specifying the input Blob locations.. This information will be passed in the WebServiceInputs property of the Azure ML batch execution request. </param>
        internal AzureMLBatchExecutionActivity(string name, string type, string description, ActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, IDictionary<string, object> globalParameters, IDictionary<string, AzureMLWebServiceFile> webServiceOutputs, IDictionary<string, AzureMLWebServiceFile> webServiceInputs) : base(name, type, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            GlobalParameters = globalParameters;
            WebServiceOutputs = webServiceOutputs;
            WebServiceInputs = webServiceInputs;
            Type = type ?? "AzureMLBatchExecution";
        }

        /// <summary> Key,Value pairs to be passed to the Azure ML Batch Execution Service endpoint. Keys must match the names of web service parameters defined in the published Azure ML web service. Values will be passed in the GlobalParameters property of the Azure ML batch execution request. </summary>
        public IDictionary<string, object> GlobalParameters { get; }
        /// <summary> Key,Value pairs, mapping the names of Azure ML endpoint's Web Service Outputs to AzureMLWebServiceFile objects specifying the output Blob locations. This information will be passed in the WebServiceOutputs property of the Azure ML batch execution request. </summary>
        public IDictionary<string, AzureMLWebServiceFile> WebServiceOutputs { get; }
        /// <summary> Key,Value pairs, mapping the names of Azure ML endpoint's Web Service Inputs to AzureMLWebServiceFile objects specifying the input Blob locations.. This information will be passed in the WebServiceInputs property of the Azure ML batch execution request. </summary>
        public IDictionary<string, AzureMLWebServiceFile> WebServiceInputs { get; }
    }
}
