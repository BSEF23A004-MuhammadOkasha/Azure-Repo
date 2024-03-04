// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeSnapshotRestoreFilesContent : IUtf8JsonSerializable, IJsonModel<NetAppVolumeSnapshotRestoreFilesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeSnapshotRestoreFilesContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetAppVolumeSnapshotRestoreFilesContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeSnapshotRestoreFilesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeSnapshotRestoreFilesContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("filePaths"u8);
            writer.WriteStartArray();
            foreach (var item in FilePaths)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(DestinationPath))
            {
                writer.WritePropertyName("destinationPath"u8);
                writer.WriteStringValue(DestinationPath);
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

        NetAppVolumeSnapshotRestoreFilesContent IJsonModel<NetAppVolumeSnapshotRestoreFilesContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeSnapshotRestoreFilesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeSnapshotRestoreFilesContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeSnapshotRestoreFilesContent(document.RootElement, options);
        }

        internal static NetAppVolumeSnapshotRestoreFilesContent DeserializeNetAppVolumeSnapshotRestoreFilesContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> filePaths = default;
            string destinationPath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filePaths"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    filePaths = array;
                    continue;
                }
                if (property.NameEquals("destinationPath"u8))
                {
                    destinationPath = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppVolumeSnapshotRestoreFilesContent(filePaths, destinationPath, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumeSnapshotRestoreFilesContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeSnapshotRestoreFilesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeSnapshotRestoreFilesContent)} does not support '{options.Format}' format.");
            }
        }

        NetAppVolumeSnapshotRestoreFilesContent IPersistableModel<NetAppVolumeSnapshotRestoreFilesContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeSnapshotRestoreFilesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppVolumeSnapshotRestoreFilesContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeSnapshotRestoreFilesContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppVolumeSnapshotRestoreFilesContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
