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

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubTestAllRoutesContent : IUtf8JsonSerializable, IModelJsonSerializable<IotHubTestAllRoutesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotHubTestAllRoutesContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotHubTestAllRoutesContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubTestAllRoutesContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RoutingSource))
            {
                writer.WritePropertyName("routingSource"u8);
                writer.WriteStringValue(RoutingSource.Value.ToString());
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                if (Message is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RoutingMessage>)Message).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Twin))
            {
                writer.WritePropertyName("twin"u8);
                if (Twin is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RoutingTwin>)Twin).Serialize(writer, options);
                }
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static IotHubTestAllRoutesContent DeserializeIotHubTestAllRoutesContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IotHubRoutingSource> routingSource = default;
            Optional<RoutingMessage> message = default;
            Optional<RoutingTwin> twin = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routingSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingSource = new IotHubRoutingSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    message = RoutingMessage.DeserializeRoutingMessage(property.Value);
                    continue;
                }
                if (property.NameEquals("twin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    twin = RoutingTwin.DeserializeRoutingTwin(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IotHubTestAllRoutesContent(Optional.ToNullable(routingSource), message.Value, twin.Value, serializedAdditionalRawData);
        }

        IotHubTestAllRoutesContent IModelJsonSerializable<IotHubTestAllRoutesContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubTestAllRoutesContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubTestAllRoutesContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotHubTestAllRoutesContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubTestAllRoutesContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotHubTestAllRoutesContent IModelSerializable<IotHubTestAllRoutesContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubTestAllRoutesContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotHubTestAllRoutesContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IotHubTestAllRoutesContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IotHubTestAllRoutesContent"/> to convert. </param>
        public static implicit operator RequestContent(IotHubTestAllRoutesContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IotHubTestAllRoutesContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IotHubTestAllRoutesContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotHubTestAllRoutesContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
