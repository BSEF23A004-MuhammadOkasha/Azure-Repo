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
using Azure.ResourceManager.CosmosDBForPostgreSql;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    internal partial class CosmosDBForPostgreSqlClusterServerListResult : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBForPostgreSqlClusterServerListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBForPostgreSqlClusterServerListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBForPostgreSqlClusterServerListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
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

        internal static CosmosDBForPostgreSqlClusterServerListResult DeserializeCosmosDBForPostgreSqlClusterServerListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<CosmosDBForPostgreSqlClusterServerData>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBForPostgreSqlClusterServerData> array = new List<CosmosDBForPostgreSqlClusterServerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBForPostgreSqlClusterServerData.DeserializeCosmosDBForPostgreSqlClusterServerData(item));
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
            return new CosmosDBForPostgreSqlClusterServerListResult(Optional.ToList(value), rawData);
        }

        CosmosDBForPostgreSqlClusterServerListResult IModelJsonSerializable<CosmosDBForPostgreSqlClusterServerListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBForPostgreSqlClusterServerListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBForPostgreSqlClusterServerListResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBForPostgreSqlClusterServerListResult IModelSerializable<CosmosDBForPostgreSqlClusterServerListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBForPostgreSqlClusterServerListResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CosmosDBForPostgreSqlClusterServerListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CosmosDBForPostgreSqlClusterServerListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBForPostgreSqlClusterServerListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
