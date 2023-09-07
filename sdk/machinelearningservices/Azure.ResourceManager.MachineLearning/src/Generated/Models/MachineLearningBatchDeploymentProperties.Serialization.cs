// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningBatchDeploymentProperties : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningBatchDeploymentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningBatchDeploymentProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningBatchDeploymentProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningBatchDeploymentProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Compute))
            {
                if (Compute != null)
                {
                    writer.WritePropertyName("compute"u8);
                    writer.WriteStringValue(Compute);
                }
                else
                {
                    writer.WriteNull("compute");
                }
            }
            if (Optional.IsDefined(ErrorThreshold))
            {
                writer.WritePropertyName("errorThreshold"u8);
                writer.WriteNumberValue(ErrorThreshold.Value);
            }
            if (Optional.IsDefined(LoggingLevel))
            {
                writer.WritePropertyName("loggingLevel"u8);
                writer.WriteStringValue(LoggingLevel.Value.ToString());
            }
            if (Optional.IsDefined(MaxConcurrencyPerInstance))
            {
                writer.WritePropertyName("maxConcurrencyPerInstance"u8);
                writer.WriteNumberValue(MaxConcurrencyPerInstance.Value);
            }
            if (Optional.IsDefined(MiniBatchSize))
            {
                writer.WritePropertyName("miniBatchSize"u8);
                writer.WriteNumberValue(MiniBatchSize.Value);
            }
            if (Optional.IsDefined(Model))
            {
                if (Model != null)
                {
                    writer.WritePropertyName("model"u8);
                    if (Model is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningAssetReferenceBase>)Model).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("model");
                }
            }
            if (Optional.IsDefined(OutputAction))
            {
                writer.WritePropertyName("outputAction"u8);
                writer.WriteStringValue(OutputAction.Value.ToString());
            }
            if (Optional.IsDefined(OutputFileName))
            {
                writer.WritePropertyName("outputFileName"u8);
                writer.WriteStringValue(OutputFileName);
            }
            if (Optional.IsDefined(Resources))
            {
                if (Resources != null)
                {
                    writer.WritePropertyName("resources"u8);
                    if (Resources is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningDeploymentResourceConfiguration>)Resources).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("resources");
                }
            }
            if (Optional.IsDefined(RetrySettings))
            {
                if (RetrySettings != null)
                {
                    writer.WritePropertyName("retrySettings"u8);
                    if (RetrySettings is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningBatchRetrySettings>)RetrySettings).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("retrySettings");
                }
            }
            if (Optional.IsDefined(CodeConfiguration))
            {
                if (CodeConfiguration != null)
                {
                    writer.WritePropertyName("codeConfiguration"u8);
                    if (CodeConfiguration is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningCodeConfiguration>)CodeConfiguration).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("codeConfiguration");
                }
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                if (EnvironmentId != null)
                {
                    writer.WritePropertyName("environmentId"u8);
                    writer.WriteStringValue(EnvironmentId);
                }
                else
                {
                    writer.WriteNull("environmentId");
                }
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                if (EnvironmentVariables != null)
                {
                    writer.WritePropertyName("environmentVariables"u8);
                    writer.WriteStartObject();
                    foreach (var item in EnvironmentVariables)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("environmentVariables");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningBatchDeploymentProperties DeserializeMachineLearningBatchDeploymentProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> compute = default;
            Optional<int> errorThreshold = default;
            Optional<MachineLearningBatchLoggingLevel> loggingLevel = default;
            Optional<int> maxConcurrencyPerInstance = default;
            Optional<long> miniBatchSize = default;
            Optional<MachineLearningAssetReferenceBase> model = default;
            Optional<MachineLearningBatchOutputAction> outputAction = default;
            Optional<string> outputFileName = default;
            Optional<MachineLearningDeploymentProvisioningState> provisioningState = default;
            Optional<MachineLearningDeploymentResourceConfiguration> resources = default;
            Optional<MachineLearningBatchRetrySettings> retrySettings = default;
            Optional<MachineLearningCodeConfiguration> codeConfiguration = default;
            Optional<string> description = default;
            Optional<string> environmentId = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            Optional<IDictionary<string, string>> properties = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("compute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        compute = null;
                        continue;
                    }
                    compute = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("loggingLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loggingLevel = new MachineLearningBatchLoggingLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxConcurrencyPerInstance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrencyPerInstance = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("miniBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    miniBatchSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        model = null;
                        continue;
                    }
                    model = MachineLearningAssetReferenceBase.DeserializeMachineLearningAssetReferenceBase(property.Value);
                    continue;
                }
                if (property.NameEquals("outputAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputAction = new MachineLearningBatchOutputAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputFileName"u8))
                {
                    outputFileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MachineLearningDeploymentProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resources = null;
                        continue;
                    }
                    resources = MachineLearningDeploymentResourceConfiguration.DeserializeMachineLearningDeploymentResourceConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("retrySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        retrySettings = null;
                        continue;
                    }
                    retrySettings = MachineLearningBatchRetrySettings.DeserializeMachineLearningBatchRetrySettings(property.Value);
                    continue;
                }
                if (property.NameEquals("codeConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        codeConfiguration = null;
                        continue;
                    }
                    codeConfiguration = MachineLearningCodeConfiguration.DeserializeMachineLearningCodeConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentId = null;
                        continue;
                    }
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentVariables = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningBatchDeploymentProperties(codeConfiguration.Value, description.Value, environmentId.Value, Optional.ToDictionary(environmentVariables), Optional.ToDictionary(properties), compute.Value, Optional.ToNullable(errorThreshold), Optional.ToNullable(loggingLevel), Optional.ToNullable(maxConcurrencyPerInstance), Optional.ToNullable(miniBatchSize), model.Value, Optional.ToNullable(outputAction), outputFileName.Value, Optional.ToNullable(provisioningState), resources.Value, retrySettings.Value, serializedAdditionalRawData);
        }

        MachineLearningBatchDeploymentProperties IModelJsonSerializable<MachineLearningBatchDeploymentProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningBatchDeploymentProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningBatchDeploymentProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningBatchDeploymentProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningBatchDeploymentProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningBatchDeploymentProperties IModelSerializable<MachineLearningBatchDeploymentProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningBatchDeploymentProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningBatchDeploymentProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningBatchDeploymentProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningBatchDeploymentProperties"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningBatchDeploymentProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningBatchDeploymentProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningBatchDeploymentProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningBatchDeploymentProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
