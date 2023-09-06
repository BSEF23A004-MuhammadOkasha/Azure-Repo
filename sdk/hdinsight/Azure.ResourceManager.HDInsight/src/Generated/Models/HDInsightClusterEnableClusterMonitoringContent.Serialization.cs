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

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterEnableClusterMonitoringContent : IUtf8JsonSerializable, IModelJsonSerializable<HDInsightClusterEnableClusterMonitoringContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HDInsightClusterEnableClusterMonitoringContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HDInsightClusterEnableClusterMonitoringContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterEnableClusterMonitoringContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(WorkspaceId))
            {
                writer.WritePropertyName("workspaceId"u8);
                writer.WriteStringValue(WorkspaceId);
            }
            if (Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("primaryKey"u8);
                writer.WriteStringValue(PrimaryKey);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static HDInsightClusterEnableClusterMonitoringContent DeserializeHDInsightClusterEnableClusterMonitoringContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> workspaceId = default;
            Optional<string> primaryKey = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HDInsightClusterEnableClusterMonitoringContent(workspaceId.Value, primaryKey.Value, rawData);
        }

        HDInsightClusterEnableClusterMonitoringContent IModelJsonSerializable<HDInsightClusterEnableClusterMonitoringContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterEnableClusterMonitoringContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterEnableClusterMonitoringContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HDInsightClusterEnableClusterMonitoringContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterEnableClusterMonitoringContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HDInsightClusterEnableClusterMonitoringContent IModelSerializable<HDInsightClusterEnableClusterMonitoringContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterEnableClusterMonitoringContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHDInsightClusterEnableClusterMonitoringContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HDInsightClusterEnableClusterMonitoringContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HDInsightClusterEnableClusterMonitoringContent"/> to convert. </param>
        public static implicit operator RequestContent(HDInsightClusterEnableClusterMonitoringContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HDInsightClusterEnableClusterMonitoringContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HDInsightClusterEnableClusterMonitoringContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHDInsightClusterEnableClusterMonitoringContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
