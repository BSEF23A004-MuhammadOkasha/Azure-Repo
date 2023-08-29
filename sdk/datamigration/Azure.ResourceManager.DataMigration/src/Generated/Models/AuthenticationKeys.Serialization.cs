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
    public partial class AuthenticationKeys : IUtf8JsonSerializable, IModelJsonSerializable<AuthenticationKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AuthenticationKeys>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AuthenticationKeys>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AuthKey1))
            {
                writer.WritePropertyName("authKey1"u8);
                writer.WriteStringValue(AuthKey1);
            }
            if (Optional.IsDefined(AuthKey2))
            {
                writer.WritePropertyName("authKey2"u8);
                writer.WriteStringValue(AuthKey2);
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

        internal static AuthenticationKeys DeserializeAuthenticationKeys(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> authKey1 = default;
            Optional<string> authKey2 = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authKey1"u8))
                {
                    authKey1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authKey2"u8))
                {
                    authKey2 = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AuthenticationKeys(authKey1.Value, authKey2.Value, rawData);
        }

        AuthenticationKeys IModelJsonSerializable<AuthenticationKeys>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAuthenticationKeys(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AuthenticationKeys>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AuthenticationKeys IModelSerializable<AuthenticationKeys>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAuthenticationKeys(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AuthenticationKeys model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AuthenticationKeys(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAuthenticationKeys(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
