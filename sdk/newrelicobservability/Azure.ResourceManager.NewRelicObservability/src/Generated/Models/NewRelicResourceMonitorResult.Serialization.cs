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

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicResourceMonitorResult : IUtf8JsonSerializable, IModelJsonSerializable<NewRelicResourceMonitorResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NewRelicResourceMonitorResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NewRelicResourceMonitorResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NewRelicResourceMonitorResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(SendingMetrics))
            {
                writer.WritePropertyName("sendingMetrics"u8);
                writer.WriteStringValue(SendingMetrics.Value.ToString());
            }
            if (Optional.IsDefined(ReasonForMetricsStatus))
            {
                writer.WritePropertyName("reasonForMetricsStatus"u8);
                writer.WriteStringValue(ReasonForMetricsStatus);
            }
            if (Optional.IsDefined(SendingLogs))
            {
                writer.WritePropertyName("sendingLogs"u8);
                writer.WriteStringValue(SendingLogs.Value.ToString());
            }
            if (Optional.IsDefined(ReasonForLogsStatus))
            {
                writer.WritePropertyName("reasonForLogsStatus"u8);
                writer.WriteStringValue(ReasonForLogsStatus);
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

        internal static NewRelicResourceMonitorResult DeserializeNewRelicResourceMonitorResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<NewRelicObservabilitySendingMetricsStatus> sendingMetrics = default;
            Optional<string> reasonForMetricsStatus = default;
            Optional<NewRelicObservabilitySendingLogsStatus> sendingLogs = default;
            Optional<string> reasonForLogsStatus = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendingMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendingMetrics = new NewRelicObservabilitySendingMetricsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reasonForMetricsStatus"u8))
                {
                    reasonForMetricsStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sendingLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendingLogs = new NewRelicObservabilitySendingLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reasonForLogsStatus"u8))
                {
                    reasonForLogsStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NewRelicResourceMonitorResult(id.Value, Optional.ToNullable(sendingMetrics), reasonForMetricsStatus.Value, Optional.ToNullable(sendingLogs), reasonForLogsStatus.Value, rawData);
        }

        NewRelicResourceMonitorResult IModelJsonSerializable<NewRelicResourceMonitorResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NewRelicResourceMonitorResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicResourceMonitorResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NewRelicResourceMonitorResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NewRelicResourceMonitorResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NewRelicResourceMonitorResult IModelSerializable<NewRelicResourceMonitorResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NewRelicResourceMonitorResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNewRelicResourceMonitorResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NewRelicResourceMonitorResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NewRelicResourceMonitorResult"/> to convert. </param>
        public static implicit operator RequestContent(NewRelicResourceMonitorResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NewRelicResourceMonitorResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NewRelicResourceMonitorResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNewRelicResourceMonitorResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
