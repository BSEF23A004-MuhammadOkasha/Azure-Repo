// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Pipeline resource type. </summary>
    public partial class PipelineResource : SubResource
    {
        /// <summary> Initializes a new instance of PipelineResource. </summary>
        public PipelineResource()
        {
            Activities = new ChangeTrackingList<Activity>();
            Parameters = new ChangeTrackingDictionary<string, ParameterSpecification>();
            Variables = new ChangeTrackingDictionary<string, VariableSpecification>();
            Annotations = new ChangeTrackingList<object>();
            RunDimensions = new ChangeTrackingDictionary<string, object>();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of PipelineResource. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="description"> The description of the pipeline. </param>
        /// <param name="activities">
        /// List of activities in pipeline.
        /// Please note <see cref="Activity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="ControlActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="ExecutionActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="GetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="IfConditionActivity"/>, <see cref="LookupActivity"/>, <see cref="ScriptActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SynapseSparkJobDefinitionActivity"/>, <see cref="SqlPoolStoredProcedureActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SwitchActivity"/>, <see cref="SynapseNotebookActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/>, <see cref="WebActivity"/> and <see cref="WebHookActivity"/>.
        /// </param>
        /// <param name="parameters"> List of parameters for pipeline. </param>
        /// <param name="variables"> List of variables for pipeline. </param>
        /// <param name="concurrency"> The max number of concurrent runs for the pipeline. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Pipeline. </param>
        /// <param name="runDimensions"> Dimensions emitted by Pipeline. </param>
        /// <param name="folder"> The folder that this Pipeline is in. If not specified, Pipeline will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal PipelineResource(string id, string name, string type, string etag, string description, IList<Activity> activities, IDictionary<string, ParameterSpecification> parameters, IDictionary<string, VariableSpecification> variables, int? concurrency, IList<object> annotations, IDictionary<string, object> runDimensions, PipelineFolder folder, IDictionary<string, object> additionalProperties) : base(id, name, type, etag)
        {
            Description = description;
            Activities = activities;
            Parameters = parameters;
            Variables = variables;
            Concurrency = concurrency;
            Annotations = annotations;
            RunDimensions = runDimensions;
            Folder = folder;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The description of the pipeline. </summary>
        public string Description { get; set; }
        /// <summary>
        /// List of activities in pipeline.
        /// Please note <see cref="Activity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="ControlActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="ExecutionActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="GetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="IfConditionActivity"/>, <see cref="LookupActivity"/>, <see cref="ScriptActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SynapseSparkJobDefinitionActivity"/>, <see cref="SqlPoolStoredProcedureActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SwitchActivity"/>, <see cref="SynapseNotebookActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/>, <see cref="WebActivity"/> and <see cref="WebHookActivity"/>.
        /// </summary>
        public IList<Activity> Activities { get; }
        /// <summary> List of parameters for pipeline. </summary>
        public IDictionary<string, ParameterSpecification> Parameters { get; }
        /// <summary> List of variables for pipeline. </summary>
        public IDictionary<string, VariableSpecification> Variables { get; }
        /// <summary> The max number of concurrent runs for the pipeline. </summary>
        public int? Concurrency { get; set; }
        /// <summary> List of tags that can be used for describing the Pipeline. </summary>
        public IList<object> Annotations { get; }
        /// <summary> Dimensions emitted by Pipeline. </summary>
        public IDictionary<string, object> RunDimensions { get; }
        /// <summary> The folder that this Pipeline is in. If not specified, Pipeline will appear at the root level. </summary>
        public PipelineFolder Folder { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
