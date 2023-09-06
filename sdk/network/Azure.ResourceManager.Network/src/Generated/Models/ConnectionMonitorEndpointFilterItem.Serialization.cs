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

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorEndpointFilterItem : IUtf8JsonSerializable, IModelJsonSerializable<ConnectionMonitorEndpointFilterItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectionMonitorEndpointFilterItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectionMonitorEndpointFilterItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionMonitorEndpointFilterItem>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ItemType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ItemType.Value.ToString());
            }
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address"u8);
                writer.WriteStringValue(Address);
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

        internal static ConnectionMonitorEndpointFilterItem DeserializeConnectionMonitorEndpointFilterItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ConnectionMonitorEndpointFilterItemType> type = default;
            Optional<string> address = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ConnectionMonitorEndpointFilterItemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectionMonitorEndpointFilterItem(Optional.ToNullable(type), address.Value, rawData);
        }

        ConnectionMonitorEndpointFilterItem IModelJsonSerializable<ConnectionMonitorEndpointFilterItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionMonitorEndpointFilterItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionMonitorEndpointFilterItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectionMonitorEndpointFilterItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionMonitorEndpointFilterItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectionMonitorEndpointFilterItem IModelSerializable<ConnectionMonitorEndpointFilterItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionMonitorEndpointFilterItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectionMonitorEndpointFilterItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectionMonitorEndpointFilterItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectionMonitorEndpointFilterItem"/> to convert. </param>
        public static implicit operator RequestContent(ConnectionMonitorEndpointFilterItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectionMonitorEndpointFilterItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectionMonitorEndpointFilterItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectionMonitorEndpointFilterItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
