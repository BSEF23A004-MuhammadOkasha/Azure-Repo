// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class EmergingIssueBannerType : IUtf8JsonSerializable, IJsonModel<EmergingIssueBannerType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EmergingIssueBannerType>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EmergingIssueBannerType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EmergingIssueBannerType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EmergingIssueBannerType)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(Cloud))
            {
                writer.WritePropertyName("cloud"u8);
                writer.WriteStringValue(Cloud);
            }
            if (Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        EmergingIssueBannerType IJsonModel<EmergingIssueBannerType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EmergingIssueBannerType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EmergingIssueBannerType)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEmergingIssueBannerType(document.RootElement, options);
        }

        internal static EmergingIssueBannerType DeserializeEmergingIssueBannerType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> title = default;
            Optional<string> message = default;
            Optional<string> cloud = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloud"u8))
                {
                    cloud = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EmergingIssueBannerType(title.Value, message.Value, cloud.Value, Optional.ToNullable(lastModifiedTime), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EmergingIssueBannerType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EmergingIssueBannerType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(EmergingIssueBannerType)} does not support '{options.Format}' format.");
            }
        }

        EmergingIssueBannerType IPersistableModel<EmergingIssueBannerType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EmergingIssueBannerType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEmergingIssueBannerType(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(EmergingIssueBannerType)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EmergingIssueBannerType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
