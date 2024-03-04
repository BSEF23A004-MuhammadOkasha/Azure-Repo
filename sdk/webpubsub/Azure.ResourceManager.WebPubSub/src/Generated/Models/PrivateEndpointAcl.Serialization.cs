// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.WebPubSub;

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class PrivateEndpointAcl : IUtf8JsonSerializable, IJsonModel<PrivateEndpointAcl>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateEndpointAcl>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrivateEndpointAcl>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointAcl>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpointAcl)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (!(Allow is ChangeTrackingList<WebPubSubRequestType> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("allow"u8);
                writer.WriteStartArray();
                foreach (var item in Allow)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(Deny is ChangeTrackingList<WebPubSubRequestType> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("deny"u8);
                writer.WriteStartArray();
                foreach (var item in Deny)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
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

        PrivateEndpointAcl IJsonModel<PrivateEndpointAcl>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointAcl>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpointAcl)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateEndpointAcl(document.RootElement, options);
        }

        internal static PrivateEndpointAcl DeserializePrivateEndpointAcl(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<WebPubSubRequestType> allow = default;
            IList<WebPubSubRequestType> deny = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebPubSubRequestType> array = new List<WebPubSubRequestType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new WebPubSubRequestType(item.GetString()));
                    }
                    allow = array;
                    continue;
                }
                if (property.NameEquals("deny"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebPubSubRequestType> array = new List<WebPubSubRequestType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new WebPubSubRequestType(item.GetString()));
                    }
                    deny = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PrivateEndpointAcl(allow ?? new ChangeTrackingList<WebPubSubRequestType>(), deny ?? new ChangeTrackingList<WebPubSubRequestType>(), serializedAdditionalRawData, name);
        }

        BinaryData IPersistableModel<PrivateEndpointAcl>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointAcl>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpointAcl)} does not support '{options.Format}' format.");
            }
        }

        PrivateEndpointAcl IPersistableModel<PrivateEndpointAcl>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointAcl>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateEndpointAcl(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpointAcl)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateEndpointAcl>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
