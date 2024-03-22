// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownActivity))]
    public partial class PipelineActivity : IUtf8JsonSerializable, IJsonModel<PipelineActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PipelineActivity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PipelineActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineActivity)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ActivityType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(OnInactiveMarkAs))
            {
                writer.WritePropertyName("onInactiveMarkAs"u8);
                writer.WriteStringValue(OnInactiveMarkAs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue<PipelineActivityDependency>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties"u8);
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue<PipelineActivityUserProperty>(item, options);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        PipelineActivity IJsonModel<PipelineActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineActivity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePipelineActivity(document.RootElement, options);
        }

        internal static PipelineActivity DeserializePipelineActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AppendVariable": return AppendVariableActivity.DeserializeAppendVariableActivity(element, options);
                    case "AzureDataExplorerCommand": return AzureDataExplorerCommandActivity.DeserializeAzureDataExplorerCommandActivity(element, options);
                    case "AzureFunctionActivity": return AzureFunctionActivity.DeserializeAzureFunctionActivity(element, options);
                    case "AzureMLBatchExecution": return AzureMLBatchExecutionActivity.DeserializeAzureMLBatchExecutionActivity(element, options);
                    case "AzureMLExecutePipeline": return AzureMLExecutePipelineActivity.DeserializeAzureMLExecutePipelineActivity(element, options);
                    case "AzureMLUpdateResource": return AzureMLUpdateResourceActivity.DeserializeAzureMLUpdateResourceActivity(element, options);
                    case "Container": return ControlActivity.DeserializeControlActivity(element, options);
                    case "Copy": return CopyActivity.DeserializeCopyActivity(element, options);
                    case "Custom": return CustomActivity.DeserializeCustomActivity(element, options);
                    case "DatabricksNotebook": return DatabricksNotebookActivity.DeserializeDatabricksNotebookActivity(element, options);
                    case "DatabricksSparkJar": return DatabricksSparkJarActivity.DeserializeDatabricksSparkJarActivity(element, options);
                    case "DatabricksSparkPython": return DatabricksSparkPythonActivity.DeserializeDatabricksSparkPythonActivity(element, options);
                    case "DataLakeAnalyticsU-SQL": return DataLakeAnalyticsUsqlActivity.DeserializeDataLakeAnalyticsUsqlActivity(element, options);
                    case "Delete": return DeleteActivity.DeserializeDeleteActivity(element, options);
                    case "ExecuteDataFlow": return ExecuteDataFlowActivity.DeserializeExecuteDataFlowActivity(element, options);
                    case "ExecutePipeline": return ExecutePipelineActivity.DeserializeExecutePipelineActivity(element, options);
                    case "ExecuteSSISPackage": return ExecuteSsisPackageActivity.DeserializeExecuteSsisPackageActivity(element, options);
                    case "ExecuteWranglingDataflow": return ExecuteWranglingDataflowActivity.DeserializeExecuteWranglingDataflowActivity(element, options);
                    case "Execution": return ExecutionActivity.DeserializeExecutionActivity(element, options);
                    case "Fail": return FailActivity.DeserializeFailActivity(element, options);
                    case "Filter": return FilterActivity.DeserializeFilterActivity(element, options);
                    case "ForEach": return ForEachActivity.DeserializeForEachActivity(element, options);
                    case "GetMetadata": return GetDatasetMetadataActivity.DeserializeGetDatasetMetadataActivity(element, options);
                    case "HDInsightHive": return HDInsightHiveActivity.DeserializeHDInsightHiveActivity(element, options);
                    case "HDInsightMapReduce": return HDInsightMapReduceActivity.DeserializeHDInsightMapReduceActivity(element, options);
                    case "HDInsightPig": return HDInsightPigActivity.DeserializeHDInsightPigActivity(element, options);
                    case "HDInsightSpark": return HDInsightSparkActivity.DeserializeHDInsightSparkActivity(element, options);
                    case "HDInsightStreaming": return HDInsightStreamingActivity.DeserializeHDInsightStreamingActivity(element, options);
                    case "IfCondition": return IfConditionActivity.DeserializeIfConditionActivity(element, options);
                    case "Lookup": return LookupActivity.DeserializeLookupActivity(element, options);
                    case "Script": return DataFactoryScriptActivity.DeserializeDataFactoryScriptActivity(element, options);
                    case "SetVariable": return SetVariableActivity.DeserializeSetVariableActivity(element, options);
                    case "SparkJob": return SynapseSparkJobDefinitionActivity.DeserializeSynapseSparkJobDefinitionActivity(element, options);
                    case "SqlServerStoredProcedure": return SqlServerStoredProcedureActivity.DeserializeSqlServerStoredProcedureActivity(element, options);
                    case "Switch": return SwitchActivity.DeserializeSwitchActivity(element, options);
                    case "SynapseNotebook": return SynapseNotebookActivity.DeserializeSynapseNotebookActivity(element, options);
                    case "Until": return UntilActivity.DeserializeUntilActivity(element, options);
                    case "Validation": return ValidationActivity.DeserializeValidationActivity(element, options);
                    case "Wait": return WaitActivity.DeserializeWaitActivity(element, options);
                    case "WebActivity": return WebActivity.DeserializeWebActivity(element, options);
                    case "WebHook": return WebHookActivity.DeserializeWebHookActivity(element, options);
                }
            }
            return UnknownActivity.DeserializeUnknownActivity(element, options);
        }

        BinaryData IPersistableModel<PipelineActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PipelineActivity)} does not support writing '{options.Format}' format.");
            }
        }

        PipelineActivity IPersistableModel<PipelineActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePipelineActivity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PipelineActivity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PipelineActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
