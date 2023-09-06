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

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureSQLConnectionStringParam : IUtf8JsonSerializable, IModelJsonSerializable<AzureSQLConnectionStringParam>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureSQLConnectionStringParam>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureSQLConnectionStringParam>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureSQLConnectionStringParam>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString"u8);
                writer.WriteStringValue(ConnectionString);
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

        internal static AzureSQLConnectionStringParam DeserializeAzureSQLConnectionStringParam(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> connectionString = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionString"u8))
                {
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AzureSQLConnectionStringParam(connectionString.Value, rawData);
        }

        AzureSQLConnectionStringParam IModelJsonSerializable<AzureSQLConnectionStringParam>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureSQLConnectionStringParam>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureSQLConnectionStringParam(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureSQLConnectionStringParam>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureSQLConnectionStringParam>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureSQLConnectionStringParam IModelSerializable<AzureSQLConnectionStringParam>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureSQLConnectionStringParam>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureSQLConnectionStringParam(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AzureSQLConnectionStringParam"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AzureSQLConnectionStringParam"/> to convert. </param>
        public static implicit operator RequestContent(AzureSQLConnectionStringParam model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AzureSQLConnectionStringParam"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AzureSQLConnectionStringParam(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureSQLConnectionStringParam(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
