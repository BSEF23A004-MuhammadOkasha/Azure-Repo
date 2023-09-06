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

namespace Azure.ResourceManager.PostgreSql.Models
{
    public partial class PostgreSqlNameAvailabilityContent : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlNameAvailabilityContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlNameAvailabilityContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlNameAvailabilityContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlNameAvailabilityContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
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

        internal static PostgreSqlNameAvailabilityContent DeserializePostgreSqlNameAvailabilityContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<ResourceType> type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostgreSqlNameAvailabilityContent(name, Optional.ToNullable(type), rawData);
        }

        PostgreSqlNameAvailabilityContent IModelJsonSerializable<PostgreSqlNameAvailabilityContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlNameAvailabilityContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlNameAvailabilityContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlNameAvailabilityContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlNameAvailabilityContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlNameAvailabilityContent IModelSerializable<PostgreSqlNameAvailabilityContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlNameAvailabilityContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlNameAvailabilityContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PostgreSqlNameAvailabilityContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PostgreSqlNameAvailabilityContent"/> to convert. </param>
        public static implicit operator RequestContent(PostgreSqlNameAvailabilityContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PostgreSqlNameAvailabilityContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PostgreSqlNameAvailabilityContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlNameAvailabilityContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
