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
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class DiagnosticSettingsCategoryResourceCollection : IUtf8JsonSerializable, IModelJsonSerializable<DiagnosticSettingsCategoryResourceCollection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DiagnosticSettingsCategoryResourceCollection>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DiagnosticSettingsCategoryResourceCollection>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiagnosticSettingsCategoryResourceCollection>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DiagnosticSettingsCategoryData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static DiagnosticSettingsCategoryResourceCollection DeserializeDiagnosticSettingsCategoryResourceCollection(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DiagnosticSettingsCategoryData>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiagnosticSettingsCategoryData> array = new List<DiagnosticSettingsCategoryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiagnosticSettingsCategoryData.DeserializeDiagnosticSettingsCategoryData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DiagnosticSettingsCategoryResourceCollection(Optional.ToList(value), rawData);
        }

        DiagnosticSettingsCategoryResourceCollection IModelJsonSerializable<DiagnosticSettingsCategoryResourceCollection>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiagnosticSettingsCategoryResourceCollection>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDiagnosticSettingsCategoryResourceCollection(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DiagnosticSettingsCategoryResourceCollection>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiagnosticSettingsCategoryResourceCollection>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DiagnosticSettingsCategoryResourceCollection IModelSerializable<DiagnosticSettingsCategoryResourceCollection>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiagnosticSettingsCategoryResourceCollection>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDiagnosticSettingsCategoryResourceCollection(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DiagnosticSettingsCategoryResourceCollection"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DiagnosticSettingsCategoryResourceCollection"/> to convert. </param>
        public static implicit operator RequestContent(DiagnosticSettingsCategoryResourceCollection model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DiagnosticSettingsCategoryResourceCollection"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DiagnosticSettingsCategoryResourceCollection(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDiagnosticSettingsCategoryResourceCollection(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
