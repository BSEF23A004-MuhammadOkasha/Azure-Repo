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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MongoDBPrivilegeResourceInfo : IUtf8JsonSerializable, IModelJsonSerializable<MongoDBPrivilegeResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MongoDBPrivilegeResourceInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MongoDBPrivilegeResourceInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DBName))
            {
                writer.WritePropertyName("db"u8);
                writer.WriteStringValue(DBName);
            }
            if (Optional.IsDefined(Collection))
            {
                writer.WritePropertyName("collection"u8);
                writer.WriteStringValue(Collection);
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

        internal static MongoDBPrivilegeResourceInfo DeserializeMongoDBPrivilegeResourceInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> db = default;
            Optional<string> collection = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("db"u8))
                {
                    db = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collection"u8))
                {
                    collection = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MongoDBPrivilegeResourceInfo(db.Value, collection.Value, rawData);
        }

        MongoDBPrivilegeResourceInfo IModelJsonSerializable<MongoDBPrivilegeResourceInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBPrivilegeResourceInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MongoDBPrivilegeResourceInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MongoDBPrivilegeResourceInfo IModelSerializable<MongoDBPrivilegeResourceInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMongoDBPrivilegeResourceInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MongoDBPrivilegeResourceInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MongoDBPrivilegeResourceInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMongoDBPrivilegeResourceInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
