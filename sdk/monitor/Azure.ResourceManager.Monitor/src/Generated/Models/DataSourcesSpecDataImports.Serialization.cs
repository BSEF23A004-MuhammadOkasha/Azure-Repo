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
    internal partial class DataSourcesSpecDataImports : IUtf8JsonSerializable, IModelJsonSerializable<DataSourcesSpecDataImports>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataSourcesSpecDataImports>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataSourcesSpecDataImports>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataSourcesSpecDataImports>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EventHub))
            {
                writer.WritePropertyName("eventHub"u8);
                if (EventHub is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DataImportSourcesEventHub>)EventHub).Serialize(writer, options);
                }
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

        internal static DataSourcesSpecDataImports DeserializeDataSourcesSpecDataImports(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataImportSourcesEventHub> eventHub = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventHub"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventHub = DataImportSourcesEventHub.DeserializeDataImportSourcesEventHub(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataSourcesSpecDataImports(eventHub.Value, rawData);
        }

        DataSourcesSpecDataImports IModelJsonSerializable<DataSourcesSpecDataImports>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataSourcesSpecDataImports>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataSourcesSpecDataImports(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataSourcesSpecDataImports>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataSourcesSpecDataImports>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataSourcesSpecDataImports IModelSerializable<DataSourcesSpecDataImports>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataSourcesSpecDataImports>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataSourcesSpecDataImports(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataSourcesSpecDataImports"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataSourcesSpecDataImports"/> to convert. </param>
        public static implicit operator RequestContent(DataSourcesSpecDataImports model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataSourcesSpecDataImports"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataSourcesSpecDataImports(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataSourcesSpecDataImports(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
