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

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorWorkspaceMetrics : IUtf8JsonSerializable, IModelJsonSerializable<MonitorWorkspaceMetrics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MonitorWorkspaceMetrics>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MonitorWorkspaceMetrics>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorWorkspaceMetrics>(this, options.Format);

            writer.WriteStartObject();
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

        internal static MonitorWorkspaceMetrics DeserializeMonitorWorkspaceMetrics(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> prometheusQueryEndpoint = default;
            Optional<string> internalId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prometheusQueryEndpoint"u8))
                {
                    prometheusQueryEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("internalId"u8))
                {
                    internalId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MonitorWorkspaceMetrics(prometheusQueryEndpoint.Value, internalId.Value, rawData);
        }

        MonitorWorkspaceMetrics IModelJsonSerializable<MonitorWorkspaceMetrics>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorWorkspaceMetrics>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorWorkspaceMetrics(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MonitorWorkspaceMetrics>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorWorkspaceMetrics>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MonitorWorkspaceMetrics IModelSerializable<MonitorWorkspaceMetrics>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorWorkspaceMetrics>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMonitorWorkspaceMetrics(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MonitorWorkspaceMetrics"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MonitorWorkspaceMetrics"/> to convert. </param>
        public static implicit operator RequestContent(MonitorWorkspaceMetrics model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MonitorWorkspaceMetrics"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MonitorWorkspaceMetrics(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMonitorWorkspaceMetrics(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
