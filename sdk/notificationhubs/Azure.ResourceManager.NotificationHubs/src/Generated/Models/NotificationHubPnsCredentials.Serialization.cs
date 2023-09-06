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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class NotificationHubPnsCredentials : IUtf8JsonSerializable, IModelJsonSerializable<NotificationHubPnsCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NotificationHubPnsCredentials>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NotificationHubPnsCredentials>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotificationHubPnsCredentials>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NotificationHubSku>)Sku).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ApnsCredential))
            {
                writer.WritePropertyName("apnsCredential"u8);
                if (ApnsCredential is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NotificationHubApnsCredential>)ApnsCredential).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(WnsCredential))
            {
                writer.WritePropertyName("wnsCredential"u8);
                if (WnsCredential is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NotificationHubWnsCredential>)WnsCredential).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(GcmCredential))
            {
                writer.WritePropertyName("gcmCredential"u8);
                if (GcmCredential is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NotificationHubGcmCredential>)GcmCredential).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(MpnsCredential))
            {
                writer.WritePropertyName("mpnsCredential"u8);
                if (MpnsCredential is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NotificationHubMpnsCredential>)MpnsCredential).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AdmCredential))
            {
                writer.WritePropertyName("admCredential"u8);
                if (AdmCredential is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NotificationHubAdmCredential>)AdmCredential).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(BaiduCredential))
            {
                writer.WritePropertyName("baiduCredential"u8);
                if (BaiduCredential is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NotificationHubBaiduCredential>)BaiduCredential).Serialize(writer, options);
                }
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

        internal static NotificationHubPnsCredentials DeserializeNotificationHubPnsCredentials(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NotificationHubSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<NotificationHubApnsCredential> apnsCredential = default;
            Optional<NotificationHubWnsCredential> wnsCredential = default;
            Optional<NotificationHubGcmCredential> gcmCredential = default;
            Optional<NotificationHubMpnsCredential> mpnsCredential = default;
            Optional<NotificationHubAdmCredential> admCredential = default;
            Optional<NotificationHubBaiduCredential> baiduCredential = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = NotificationHubSku.DeserializeNotificationHubSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("apnsCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apnsCredential = NotificationHubApnsCredential.DeserializeNotificationHubApnsCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("wnsCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            wnsCredential = NotificationHubWnsCredential.DeserializeNotificationHubWnsCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("gcmCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            gcmCredential = NotificationHubGcmCredential.DeserializeNotificationHubGcmCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("mpnsCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mpnsCredential = NotificationHubMpnsCredential.DeserializeNotificationHubMpnsCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("admCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            admCredential = NotificationHubAdmCredential.DeserializeNotificationHubAdmCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("baiduCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            baiduCredential = NotificationHubBaiduCredential.DeserializeNotificationHubBaiduCredential(property0.Value);
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
            return new NotificationHubPnsCredentials(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, apnsCredential.Value, wnsCredential.Value, gcmCredential.Value, mpnsCredential.Value, admCredential.Value, baiduCredential.Value, sku.Value, rawData);
        }

        NotificationHubPnsCredentials IModelJsonSerializable<NotificationHubPnsCredentials>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotificationHubPnsCredentials>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationHubPnsCredentials(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NotificationHubPnsCredentials>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotificationHubPnsCredentials>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NotificationHubPnsCredentials IModelSerializable<NotificationHubPnsCredentials>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotificationHubPnsCredentials>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNotificationHubPnsCredentials(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NotificationHubPnsCredentials"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NotificationHubPnsCredentials"/> to convert. </param>
        public static implicit operator RequestContent(NotificationHubPnsCredentials model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NotificationHubPnsCredentials"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NotificationHubPnsCredentials(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNotificationHubPnsCredentials(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
