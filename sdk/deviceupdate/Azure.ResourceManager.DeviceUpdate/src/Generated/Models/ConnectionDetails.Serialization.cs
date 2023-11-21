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

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class ConnectionDetails : IUtf8JsonSerializable, IJsonModel<ConnectionDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectionDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectionDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ConnectionDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIpAddress"u8);
                writer.WriteStringValue(PrivateIPAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(LinkIdentifier))
            {
                writer.WritePropertyName("linkIdentifier"u8);
                writer.WriteStringValue(LinkIdentifier);
            }
            if (options.Format != "W" && Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (options.Format != "W" && Optional.IsDefined(MemberName))
            {
                writer.WritePropertyName("memberName"u8);
                writer.WriteStringValue(MemberName);
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

        ConnectionDetails IJsonModel<ConnectionDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ConnectionDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionDetails(document.RootElement, options);
        }

        internal static ConnectionDetails DeserializeConnectionDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> privateIPAddress = default;
            Optional<string> linkIdentifier = default;
            Optional<string> groupId = default;
            Optional<string> memberName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"u8))
                {
                    privateIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkIdentifier"u8))
                {
                    linkIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memberName"u8))
                {
                    memberName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectionDetails(id.Value, privateIPAddress.Value, linkIdentifier.Value, groupId.Value, memberName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectionDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ConnectionDetails)} does not support '{options.Format}' format.");
            }
        }

        ConnectionDetails IPersistableModel<ConnectionDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectionDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ConnectionDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectionDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
