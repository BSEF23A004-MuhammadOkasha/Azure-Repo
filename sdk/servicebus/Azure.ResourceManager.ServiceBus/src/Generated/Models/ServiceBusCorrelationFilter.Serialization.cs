// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class ServiceBusCorrelationFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ApplicationProperties))
            {
                writer.WritePropertyName("properties");
                writer.WriteStartObject();
                foreach (var item in ApplicationProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId");
                writer.WriteStringValue(CorrelationId);
            }
            if (Optional.IsDefined(MessageId))
            {
                writer.WritePropertyName("messageId");
                writer.WriteStringValue(MessageId);
            }
            if (Optional.IsDefined(SendTo))
            {
                writer.WritePropertyName("to");
                writer.WriteStringValue(SendTo);
            }
            if (Optional.IsDefined(ReplyTo))
            {
                writer.WritePropertyName("replyTo");
                writer.WriteStringValue(ReplyTo);
            }
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("label");
                writer.WriteStringValue(Subject);
            }
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId");
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsDefined(ReplyToSessionId))
            {
                writer.WritePropertyName("replyToSessionId");
                writer.WriteStringValue(ReplyToSessionId);
            }
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("contentType");
                writer.WriteStringValue(ContentType);
            }
            if (Optional.IsDefined(RequiresPreprocessing))
            {
                writer.WritePropertyName("requiresPreprocessing");
                writer.WriteBooleanValue(RequiresPreprocessing.Value);
            }
            writer.WriteEndObject();
        }

        internal static ServiceBusCorrelationFilter DeserializeServiceBusCorrelationFilter(JsonElement element)
        {
            Optional<IDictionary<string, object>> properties = default;
            Optional<string> correlationId = default;
            Optional<string> messageId = default;
            Optional<string> to = default;
            Optional<string> replyTo = default;
            Optional<string> label = default;
            Optional<string> sessionId = default;
            Optional<string> replyToSessionId = default;
            Optional<string> contentType = default;
            Optional<bool> requiresPreprocessing = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("correlationId"))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageId"))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("to"))
                {
                    to = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replyTo"))
                {
                    replyTo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionId"))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replyToSessionId"))
                {
                    replyToSessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"))
                {
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requiresPreprocessing"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requiresPreprocessing = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ServiceBusCorrelationFilter(Optional.ToDictionary(properties), correlationId.Value, messageId.Value, to.Value, replyTo.Value, label.Value, sessionId.Value, replyToSessionId.Value, contentType.Value, Optional.ToNullable(requiresPreprocessing));
        }
    }
}
