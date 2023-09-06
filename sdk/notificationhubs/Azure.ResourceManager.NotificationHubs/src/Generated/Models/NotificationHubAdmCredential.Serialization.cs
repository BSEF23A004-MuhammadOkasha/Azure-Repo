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

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class NotificationHubAdmCredential : IUtf8JsonSerializable, IModelJsonSerializable<NotificationHubAdmCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NotificationHubAdmCredential>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NotificationHubAdmCredential>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotificationHubAdmCredential>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteStringValue(ClientSecret);
            }
            if (Optional.IsDefined(AuthTokenUri))
            {
                writer.WritePropertyName("authTokenUrl"u8);
                writer.WriteStringValue(AuthTokenUri.AbsoluteUri);
            }
            writer.WriteEndObject();
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

        internal static NotificationHubAdmCredential DeserializeNotificationHubAdmCredential(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientId = default;
            Optional<string> clientSecret = default;
            Optional<Uri> authTokenUrl = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("clientId"u8))
                        {
                            clientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            clientSecret = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authTokenUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authTokenUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NotificationHubAdmCredential(clientId.Value, clientSecret.Value, authTokenUrl.Value, rawData);
        }

        NotificationHubAdmCredential IModelJsonSerializable<NotificationHubAdmCredential>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotificationHubAdmCredential>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationHubAdmCredential(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NotificationHubAdmCredential>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotificationHubAdmCredential>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NotificationHubAdmCredential IModelSerializable<NotificationHubAdmCredential>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotificationHubAdmCredential>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNotificationHubAdmCredential(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NotificationHubAdmCredential"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NotificationHubAdmCredential"/> to convert. </param>
        public static implicit operator RequestContent(NotificationHubAdmCredential model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NotificationHubAdmCredential"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NotificationHubAdmCredential(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNotificationHubAdmCredential(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
