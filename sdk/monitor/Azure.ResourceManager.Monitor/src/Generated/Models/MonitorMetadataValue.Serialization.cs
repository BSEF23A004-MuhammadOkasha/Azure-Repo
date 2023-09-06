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
    public partial class MonitorMetadataValue : IUtf8JsonSerializable, IModelJsonSerializable<MonitorMetadataValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MonitorMetadataValue>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MonitorMetadataValue>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorMetadataValue>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                if (Name is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MonitorLocalizableString>)Name).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
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

        internal static MonitorMetadataValue DeserializeMonitorMetadataValue(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MonitorLocalizableString> name = default;
            Optional<string> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = MonitorLocalizableString.DeserializeMonitorLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MonitorMetadataValue(name.Value, value.Value, rawData);
        }

        MonitorMetadataValue IModelJsonSerializable<MonitorMetadataValue>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorMetadataValue>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorMetadataValue(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MonitorMetadataValue>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorMetadataValue>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MonitorMetadataValue IModelSerializable<MonitorMetadataValue>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorMetadataValue>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMonitorMetadataValue(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MonitorMetadataValue"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MonitorMetadataValue"/> to convert. </param>
        public static implicit operator RequestContent(MonitorMetadataValue model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MonitorMetadataValue"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MonitorMetadataValue(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMonitorMetadataValue(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
