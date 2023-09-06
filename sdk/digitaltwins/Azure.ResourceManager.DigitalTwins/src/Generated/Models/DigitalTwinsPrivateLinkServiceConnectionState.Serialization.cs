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

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class DigitalTwinsPrivateLinkServiceConnectionState : IUtf8JsonSerializable, IModelJsonSerializable<DigitalTwinsPrivateLinkServiceConnectionState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DigitalTwinsPrivateLinkServiceConnectionState>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DigitalTwinsPrivateLinkServiceConnectionState>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsPrivateLinkServiceConnectionState>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WritePropertyName("description"u8);
            writer.WriteStringValue(Description);
            if (Optional.IsDefined(ActionsRequired))
            {
                writer.WritePropertyName("actionsRequired"u8);
                writer.WriteStringValue(ActionsRequired);
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

        internal static DigitalTwinsPrivateLinkServiceConnectionState DeserializeDigitalTwinsPrivateLinkServiceConnectionState(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DigitalTwinsPrivateLinkServiceConnectionStatus status = default;
            string description = default;
            Optional<string> actionsRequired = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = new DigitalTwinsPrivateLinkServiceConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"u8))
                {
                    actionsRequired = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DigitalTwinsPrivateLinkServiceConnectionState(status, description, actionsRequired.Value, rawData);
        }

        DigitalTwinsPrivateLinkServiceConnectionState IModelJsonSerializable<DigitalTwinsPrivateLinkServiceConnectionState>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsPrivateLinkServiceConnectionState>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsPrivateLinkServiceConnectionState(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DigitalTwinsPrivateLinkServiceConnectionState>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsPrivateLinkServiceConnectionState>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DigitalTwinsPrivateLinkServiceConnectionState IModelSerializable<DigitalTwinsPrivateLinkServiceConnectionState>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsPrivateLinkServiceConnectionState>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDigitalTwinsPrivateLinkServiceConnectionState(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DigitalTwinsPrivateLinkServiceConnectionState"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DigitalTwinsPrivateLinkServiceConnectionState"/> to convert. </param>
        public static implicit operator RequestContent(DigitalTwinsPrivateLinkServiceConnectionState model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DigitalTwinsPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DigitalTwinsPrivateLinkServiceConnectionState(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDigitalTwinsPrivateLinkServiceConnectionState(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
