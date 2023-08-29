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
    public partial class CosmosDBAccountLocation : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBAccountLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBAccountLocation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBAccountLocation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LocationName))
            {
                writer.WritePropertyName("locationName"u8);
                writer.WriteStringValue(LocationName.Value);
            }
            if (Optional.IsDefined(FailoverPriority))
            {
                writer.WritePropertyName("failoverPriority"u8);
                writer.WriteNumberValue(FailoverPriority.Value);
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("isZoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
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

        internal static CosmosDBAccountLocation DeserializeCosmosDBAccountLocation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<AzureLocation> locationName = default;
            Optional<string> documentEndpoint = default;
            Optional<string> provisioningState = default;
            Optional<int> failoverPriority = default;
            Optional<bool> isZoneRedundant = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locationName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    locationName = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("documentEndpoint"u8))
                {
                    documentEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failoverPriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failoverPriority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isZoneRedundant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isZoneRedundant = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CosmosDBAccountLocation(id.Value, Optional.ToNullable(locationName), documentEndpoint.Value, provisioningState.Value, Optional.ToNullable(failoverPriority), Optional.ToNullable(isZoneRedundant), rawData);
        }

        CosmosDBAccountLocation IModelJsonSerializable<CosmosDBAccountLocation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBAccountLocation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBAccountLocation>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBAccountLocation IModelSerializable<CosmosDBAccountLocation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBAccountLocation(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CosmosDBAccountLocation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CosmosDBAccountLocation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBAccountLocation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
