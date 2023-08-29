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

namespace Azure.Communication.NetworkTraversal
{
    internal partial class CommunicationRelayConfigurationRequest : IUtf8JsonSerializable, IModelJsonSerializable<CommunicationRelayConfigurationRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CommunicationRelayConfigurationRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CommunicationRelayConfigurationRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(RouteType))
            {
                writer.WritePropertyName("routeType"u8);
                writer.WriteStringValue(RouteType.Value.ToString());
            }
            if (Optional.IsDefined(Ttl))
            {
                writer.WritePropertyName("ttl"u8);
                writer.WriteNumberValue(Ttl.Value);
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

        internal static CommunicationRelayConfigurationRequest DeserializeCommunicationRelayConfigurationRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<RouteType> routeType = default;
            Optional<int> ttl = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routeType = new RouteType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ttl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ttl = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CommunicationRelayConfigurationRequest(id.Value, Optional.ToNullable(routeType), Optional.ToNullable(ttl), rawData);
        }

        CommunicationRelayConfigurationRequest IModelJsonSerializable<CommunicationRelayConfigurationRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCommunicationRelayConfigurationRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CommunicationRelayConfigurationRequest>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CommunicationRelayConfigurationRequest IModelSerializable<CommunicationRelayConfigurationRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCommunicationRelayConfigurationRequest(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CommunicationRelayConfigurationRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CommunicationRelayConfigurationRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCommunicationRelayConfigurationRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
