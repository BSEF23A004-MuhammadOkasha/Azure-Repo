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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MISqlConnectionInfo : IUtf8JsonSerializable, IModelJsonSerializable<MISqlConnectionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MISqlConnectionInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MISqlConnectionInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MISqlConnectionInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("managedInstanceResourceId"u8);
            writer.WriteStringValue(ManagedInstanceResourceId);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ConnectionInfoType);
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
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

        internal static MISqlConnectionInfo DeserializeMISqlConnectionInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string managedInstanceResourceId = default;
            string type = default;
            Optional<string> userName = default;
            Optional<string> password = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedInstanceResourceId"u8))
                {
                    managedInstanceResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userName"u8))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MISqlConnectionInfo(type, userName.Value, password.Value, managedInstanceResourceId, rawData);
        }

        MISqlConnectionInfo IModelJsonSerializable<MISqlConnectionInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MISqlConnectionInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMISqlConnectionInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MISqlConnectionInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MISqlConnectionInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MISqlConnectionInfo IModelSerializable<MISqlConnectionInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MISqlConnectionInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMISqlConnectionInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MISqlConnectionInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MISqlConnectionInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMISqlConnectionInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
