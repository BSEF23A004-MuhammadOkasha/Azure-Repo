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
using Azure.ResourceManager.NotificationHubs.Models;

namespace Azure.ResourceManager.NotificationHubs
{
    public partial class NotificationHubNamespaceData : IUtf8JsonSerializable, IModelJsonSerializable<NotificationHubNamespaceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NotificationHubNamespaceData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NotificationHubNamespaceData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotificationHubNamespaceData>(this, options.Format);

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
            if (Optional.IsDefined(NamespaceName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(NamespaceName);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedAt"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(ServiceBusEndpoint))
            {
                writer.WritePropertyName("serviceBusEndpoint"u8);
                writer.WriteStringValue(ServiceBusEndpoint.AbsoluteUri);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(ScaleUnit))
            {
                writer.WritePropertyName("scaleUnit"u8);
                writer.WriteStringValue(ScaleUnit);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(IsCritical))
            {
                writer.WritePropertyName("critical"u8);
                writer.WriteBooleanValue(IsCritical.Value);
            }
            if (Optional.IsDefined(DataCenter))
            {
                writer.WritePropertyName("dataCenter"u8);
                writer.WriteStringValue(DataCenter);
            }
            if (Optional.IsDefined(NamespaceType))
            {
                writer.WritePropertyName("namespaceType"u8);
                writer.WriteStringValue(NamespaceType.Value.ToSerialString());
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

        internal static NotificationHubNamespaceData DeserializeNotificationHubNamespaceData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<string> name0 = default;
            Optional<string> provisioningState = default;
            Optional<string> region = default;
            Optional<string> metricId = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> updatedAt = default;
            Optional<Uri> serviceBusEndpoint = default;
            Optional<string> subscriptionId = default;
            Optional<string> scaleUnit = default;
            Optional<bool> enabled = default;
            Optional<bool> critical = default;
            Optional<string> dataCenter = default;
            Optional<NotificationHubNamespaceType> namespaceType = default;
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
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("region"u8))
                        {
                            region = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metricId"u8))
                        {
                            metricId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("serviceBusEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceBusEndpoint = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("subscriptionId"u8))
                        {
                            subscriptionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scaleUnit"u8))
                        {
                            scaleUnit = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("critical"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            critical = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dataCenter"u8))
                        {
                            dataCenter = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("namespaceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            namespaceType = property0.Value.GetString().ToNotificationHubNamespaceType();
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
            return new NotificationHubNamespaceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, name0.Value, provisioningState.Value, region.Value, metricId.Value, status.Value, Optional.ToNullable(createdAt), Optional.ToNullable(updatedAt), serviceBusEndpoint.Value, subscriptionId.Value, scaleUnit.Value, Optional.ToNullable(enabled), Optional.ToNullable(critical), dataCenter.Value, Optional.ToNullable(namespaceType), sku.Value, rawData);
        }

        NotificationHubNamespaceData IModelJsonSerializable<NotificationHubNamespaceData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotificationHubNamespaceData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationHubNamespaceData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NotificationHubNamespaceData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotificationHubNamespaceData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NotificationHubNamespaceData IModelSerializable<NotificationHubNamespaceData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotificationHubNamespaceData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNotificationHubNamespaceData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NotificationHubNamespaceData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NotificationHubNamespaceData"/> to convert. </param>
        public static implicit operator RequestContent(NotificationHubNamespaceData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NotificationHubNamespaceData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NotificationHubNamespaceData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNotificationHubNamespaceData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
