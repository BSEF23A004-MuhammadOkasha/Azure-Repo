// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class DiskPoolVolume : IUtf8JsonSerializable, IJsonModel<DiskPoolVolume>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiskPoolVolume>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DiskPoolVolume>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskPoolVolume>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiskPoolVolume)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("targetId"u8);
            writer.WriteStringValue(TargetId);
            writer.WritePropertyName("lunName"u8);
            writer.WriteStringValue(LunName);
            if (MountOption.HasValue)
            {
                writer.WritePropertyName("mountOption"u8);
                writer.WriteStringValue(MountOption.Value.ToString());
            }
            if (options.Format != "W" && Path != null)
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
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

        DiskPoolVolume IJsonModel<DiskPoolVolume>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskPoolVolume>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiskPoolVolume)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiskPoolVolume(document.RootElement, options);
        }

        internal static DiskPoolVolume DeserializeDiskPoolVolume(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier targetId = default;
            string lunName = default;
            Optional<LunMountMode> mountOption = default;
            Optional<string> path = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetId"u8))
                {
                    targetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lunName"u8))
                {
                    lunName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mountOption = new LunMountMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DiskPoolVolume(targetId, lunName, Optional.ToNullable(mountOption), path.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiskPoolVolume>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskPoolVolume>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiskPoolVolume)} does not support '{options.Format}' format.");
            }
        }

        DiskPoolVolume IPersistableModel<DiskPoolVolume>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskPoolVolume>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiskPoolVolume(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiskPoolVolume)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiskPoolVolume>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
