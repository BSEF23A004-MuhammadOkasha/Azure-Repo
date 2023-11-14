// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeDataProtection : IUtf8JsonSerializable, IJsonModel<NetAppVolumeDataProtection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeDataProtection>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NetAppVolumeDataProtection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NetAppVolumeDataProtection>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NetAppVolumeDataProtection>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Replication))
            {
                writer.WritePropertyName("replication"u8);
                writer.WriteObjectValue(Replication);
            }
            if (Optional.IsDefined(Snapshot))
            {
                writer.WritePropertyName("snapshot"u8);
                writer.WriteObjectValue(Snapshot);
            }
            if (Optional.IsDefined(VolumeRelocation))
            {
                writer.WritePropertyName("volumeRelocation"u8);
                writer.WriteObjectValue(VolumeRelocation);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        NetAppVolumeDataProtection IJsonModel<NetAppVolumeDataProtection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetAppVolumeDataProtection)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeDataProtection(document.RootElement, options);
        }

        internal static NetAppVolumeDataProtection DeserializeNetAppVolumeDataProtection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetAppReplicationObject> replication = default;
            Optional<VolumeSnapshotProperties> snapshot = default;
            Optional<NetAppVolumeRelocationProperties> volumeRelocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replication = NetAppReplicationObject.DeserializeNetAppReplicationObject(property.Value);
                    continue;
                }
                if (property.NameEquals("snapshot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snapshot = VolumeSnapshotProperties.DeserializeVolumeSnapshotProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("volumeRelocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    volumeRelocation = NetAppVolumeRelocationProperties.DeserializeNetAppVolumeRelocationProperties(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppVolumeDataProtection(replication.Value, snapshot.Value, volumeRelocation.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumeDataProtection>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetAppVolumeDataProtection)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetAppVolumeDataProtection IPersistableModel<NetAppVolumeDataProtection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetAppVolumeDataProtection)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetAppVolumeDataProtection(document.RootElement, options);
        }

        string IPersistableModel<NetAppVolumeDataProtection>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
