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
    internal partial class AzureMonitorMetricsDestination : IUtf8JsonSerializable, IModelJsonSerializable<AzureMonitorMetricsDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureMonitorMetricsDestination>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureMonitorMetricsDestination>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureMonitorMetricsDestination>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        internal static AzureMonitorMetricsDestination DeserializeAzureMonitorMetricsDestination(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AzureMonitorMetricsDestination(name.Value, rawData);
        }

        AzureMonitorMetricsDestination IModelJsonSerializable<AzureMonitorMetricsDestination>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureMonitorMetricsDestination>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureMonitorMetricsDestination(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureMonitorMetricsDestination>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureMonitorMetricsDestination>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureMonitorMetricsDestination IModelSerializable<AzureMonitorMetricsDestination>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureMonitorMetricsDestination>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureMonitorMetricsDestination(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AzureMonitorMetricsDestination"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AzureMonitorMetricsDestination"/> to convert. </param>
        public static implicit operator RequestContent(AzureMonitorMetricsDestination model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AzureMonitorMetricsDestination"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AzureMonitorMetricsDestination(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureMonitorMetricsDestination(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
