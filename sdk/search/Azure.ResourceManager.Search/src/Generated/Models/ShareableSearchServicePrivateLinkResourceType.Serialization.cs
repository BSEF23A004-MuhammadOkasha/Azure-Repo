// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    public partial class ShareableSearchServicePrivateLinkResourceType : IUtf8JsonSerializable, IJsonModel<ShareableSearchServicePrivateLinkResourceType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ShareableSearchServicePrivateLinkResourceType>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ShareableSearchServicePrivateLinkResourceType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareableSearchServicePrivateLinkResourceType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareableSearchServicePrivateLinkResourceType)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Properties != null)
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
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

        ShareableSearchServicePrivateLinkResourceType IJsonModel<ShareableSearchServicePrivateLinkResourceType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareableSearchServicePrivateLinkResourceType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareableSearchServicePrivateLinkResourceType)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeShareableSearchServicePrivateLinkResourceType(document.RootElement, options);
        }

        internal static ShareableSearchServicePrivateLinkResourceType DeserializeShareableSearchServicePrivateLinkResourceType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ShareableSearchServicePrivateLinkResourceProperties> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = ShareableSearchServicePrivateLinkResourceProperties.DeserializeShareableSearchServicePrivateLinkResourceProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ShareableSearchServicePrivateLinkResourceType(name.Value, properties.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ShareableSearchServicePrivateLinkResourceType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareableSearchServicePrivateLinkResourceType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ShareableSearchServicePrivateLinkResourceType)} does not support '{options.Format}' format.");
            }
        }

        ShareableSearchServicePrivateLinkResourceType IPersistableModel<ShareableSearchServicePrivateLinkResourceType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareableSearchServicePrivateLinkResourceType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeShareableSearchServicePrivateLinkResourceType(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ShareableSearchServicePrivateLinkResourceType)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ShareableSearchServicePrivateLinkResourceType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
