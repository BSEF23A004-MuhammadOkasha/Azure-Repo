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

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class ConnectionDetails : IUtf8JsonSerializable, IModelJsonSerializable<ConnectionDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectionDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectionDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionDetails>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ConnectionDetails DeserializeConnectionDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> privateIPAddress = default;
            Optional<string> linkIdentifier = default;
            Optional<string> groupId = default;
            Optional<string> memberName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"u8))
                {
                    privateIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkIdentifier"u8))
                {
                    linkIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memberName"u8))
                {
                    memberName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectionDetails(id.Value, privateIPAddress.Value, linkIdentifier.Value, groupId.Value, memberName.Value, rawData);
        }

        ConnectionDetails IModelJsonSerializable<ConnectionDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectionDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectionDetails IModelSerializable<ConnectionDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectionDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectionDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectionDetails"/> to convert. </param>
        public static implicit operator RequestContent(ConnectionDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectionDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectionDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectionDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
