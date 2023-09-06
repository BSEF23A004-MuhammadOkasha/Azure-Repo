// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventDataConverter))]
    public partial class ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData : IUtf8JsonSerializable, IModelJsonSerializable<ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(NamespaceName))
            {
                writer.WritePropertyName("namespaceName"u8);
                writer.WriteStringValue(NamespaceName);
            }
            if (Optional.IsDefined(RequestUri))
            {
                writer.WritePropertyName("requestUri"u8);
                writer.WriteStringValue(RequestUri);
            }
            if (Optional.IsDefined(EntityType))
            {
                writer.WritePropertyName("entityType"u8);
                writer.WriteStringValue(EntityType);
            }
            if (Optional.IsDefined(QueueName))
            {
                writer.WritePropertyName("queueName"u8);
                writer.WriteStringValue(QueueName);
            }
            if (Optional.IsDefined(TopicName))
            {
                writer.WritePropertyName("topicName"u8);
                writer.WriteStringValue(TopicName);
            }
            if (Optional.IsDefined(SubscriptionName))
            {
                writer.WritePropertyName("subscriptionName"u8);
                writer.WriteStringValue(SubscriptionName);
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

        internal static ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData DeserializeServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> namespaceName = default;
            Optional<string> requestUri = default;
            Optional<string> entityType = default;
            Optional<string> queueName = default;
            Optional<string> topicName = default;
            Optional<string> subscriptionName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("namespaceName"u8))
                {
                    namespaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestUri"u8))
                {
                    requestUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityType"u8))
                {
                    entityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueName"u8))
                {
                    queueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topicName"u8))
                {
                    topicName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionName"u8))
                {
                    subscriptionName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData(namespaceName.Value, requestUri.Value, entityType.Value, queueName.Value, topicName.Value, subscriptionName.Value, rawData);
        }

        ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData IModelJsonSerializable<ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData IModelSerializable<ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData"/> to convert. </param>
        public static implicit operator RequestContent(ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventDataConverter : JsonConverter<ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData>
        {
            public override void Write(Utf8JsonWriter writer, ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeServiceBusDeadletterMessagesAvailablePeriodicNotificationsEventData(document.RootElement);
            }
        }
    }
}
